using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BiblioClasse;

namespace DBConnectSpace
{
    public class DBConnect
    {
        #region Outils Commun

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructeur pour la requête de connexion
        public DBConnect(string srv, string DB, string ID, string MDP)
        {
            server = srv;
            database = DB;
            uid = ID;
            password = MDP;
            Initialize();
        }
        //Initialisation des valeurs
        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //Ouverture de la connexion à la BD
        public bool OpenConnection()
        {
            try
            {
                connection.Close();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Connexion au serveur impossible ! Contactez l'administrateur");
                        break;
                    case 0:
                        MessageBox.Show("Login et/ou mot de passe invalide(s). Réessayez");
                        break;
                }
                return false;
            }
        }

        #endregion

        #region Outils Rapport

        //Recherche tout les rapports possédant l'id visiteur en parametres  
        public List<int> ChercherIdsRapportsVisiteur(int idVisiteur)
        {
            OpenConnection();
            string query = "SELECT idRapport FROM rapport WHERE idVisiteur='" + idVisiteur + "' ORDER BY date DESC";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<int> LesIdsRapportVisi = new List<int>();
            while (reader.Read())
            {
                LesIdsRapportVisi.Add((int)reader["idRapport"]);
            }
            reader.Close();
            cmd.Connection.Close();
            return LesIdsRapportVisi;
        }

        //Recherche tout les rapports possédant l'id médecin en parametres
        public List<int> ChercherIdsRapportsMedecin(int idMedecin)
        {
            OpenConnection();
            string query = "SELECT idRapport FROM rapport " + " WHERE idMedecin='" + idMedecin + "' ORDER BY date DESC";
            List<int> liste = new List<int>(); 
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["idRapport"];
                liste.Add(id);
            }
            reader.Close();
            return liste;
        }

        //Recupère le rapport possédant l'id en paramètre 
        public Rapport ChargerRapport(int idRapport)
        {

            OpenConnection();
            //prépare la requete
            string query = "SELECT * FROM rapport WHERE rapport.idRapport = " + idRapport;
            //place la requete préparer dans une variable de commande MySql
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Execute la commande 
            MySqlDataReader reader = cmd.ExecuteReader();
            Rapport leRapport = null;
            if (reader.Read())
            {
                leRapport = new Rapport(
                    (int)reader["idRapport"],
                    (DateTime)reader["date"],
                    (string)reader["motif"],
                    (string)reader["bilan"],
                    (int)reader["idVisiteur"],
                    (int)reader["idMedecin"]);
            }
            reader.Close();

            //Appel la méthode getMedecin afin de recupère un medecin avec l'id lié à celui présent dans le rapport
            Medecin unMedecin = GetMedecin(leRapport.IdMedecin);
            //Appel la méthode getvisiteur afin de recupère un visiteur avec l'id lié à celui présent dans le rapport
            Visiteur unVisiteur = GetVisiteur(leRapport.IdVisiteur);
            //Appel la méthode lesEchantillon afin de recupère tout les echantillons avec lié au rapport
            List<Echantillon> lesEchantillons = ListEchantillon(leRapport.IdRap);

            //Créer un nouveau rapport mais qui contient cette fois des objets médecins et visiteur ainsi qu'une liste lesEchantillons
            Rapport leRapportFinal = new Rapport(
                leRapport.IdRap,
                leRapport.Date,
                leRapport.Modif,
                leRapport.Bilan,
                lesEchantillons,
                unMedecin,
                unVisiteur
                );
            return leRapportFinal;
        }

        //Méthode pour ajouter un Rapport
        public void AddRapport(Rapport nouveauRapport)
        {
            OpenConnection();
            Rapport ajoutable = nouveauRapport;

            //place dans une variable l'id du visiteur à l"origine du rapport
            int idVisi = ajoutable.LeVisi.Id;

            //place dans une variable l'id du medecin à sujet du rapport
            int idMed = ajoutable.LeMed.Id;

            //prépare et stock la requete SQL
            string query = "INSERT INTO `rapport`(`date`, `motif`, `bilan`, `idVisiteur`, `idMedecin`) " +
                "VALUES(" +
                " '" + ajoutable.Date.ToString("yyyy-MM-dd") + "'," +
                " '" + ajoutable.Modif + "'," +
                " '" + ajoutable.Bilan + "'," +
                " '" + idVisi + "'," +
                " '" + idMed + "');";

            MySqlCommand cmd = new MySqlCommand(query, connection);


            try
            {
                //execute la requête SQL
                cmd.ExecuteNonQuery();

                MessageBox.Show("Rapport Ajouter avec succes", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'ajout", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //Crée une list contenant tout les rapports
        public List<Rapport> RapportList()
        {

            OpenConnection();
            //prépare et stock la requete SQL
            string query = "SELECT * FROM rapport";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Rapport> ListeRapport = new List<Rapport>();

            while (reader.Read())
            {
                ListeRapport.Add(new Rapport(
                    (int)reader["idRapport"],
                    (DateTime)reader["date"],
                    (string)reader["motif"],
                    (string)reader["bilan"],
                    (int)reader["idVisiteur"],
                    (int)reader["idMedecin"]));
            }
            reader.Close();
            cmd.Connection.Close();

            return ListeRapport;

        }

        #endregion

        #region Outils médicament

        //création liste des médicaments
        public List<Medicamant> MedocsList()
        {
            OpenConnection();
            //prépare et stock la requete SQL
            string query = "SELECT * FROM medicament inner join famille WHERE medicament.idFamille = famille.idFamille ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Medicamant> ListeMedocs = new List<Medicamant>();


            while (reader.Read())
            {
                ListeMedocs.Add(new Medicamant(
                    (int)reader["idMedicament"],
                    reader["nomCommercial"].ToString(),
                    reader["contreindications"].ToString(),
                    reader["effets"].ToString(),
                    reader["composition"].ToString(),
                    new Famille(reader["libelle"].ToString(),
                    (int)reader["idFamille"])));
            }
            reader.Close();
            cmd.Connection.Close();
            return ListeMedocs;

        }

        //liste le nombre de médicament dans la base
        public int NbMedicament()
        {
            string countquery = "SELECT COUNT(idMedicament) FROM medicament";
            MySqlCommand countcmd = new MySqlCommand(countquery, connection);
            int countLine = Convert.ToInt32(countcmd.ExecuteScalar());
            return countLine;
        }

        //Crée et renvoie une liste de toute les familles de médicament enregistrer dans la base
        public List<Famille> ListesDesFam()
        {
            OpenConnection();
            string query = "SELECT * FROM famille ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Famille> ListesDesFam = new List<Famille>();

            while (reader.Read())
            {
                ListesDesFam.Add(new Famille(
                    reader["libelle"].ToString(),
                    (int)reader["idFamille"]));
            }
            reader.Close();
            cmd.Connection.Close();
            return ListesDesFam;

        }

        //Méthode pour ajouter des médicaments à la base de donnée
        public void addmedocs(Medicamant newMedoc)
        {
            OpenConnection();
            Medicamant ajoutable = newMedoc;
            //int pas entre cote et date entrecote


            string query = "INSERT INTO medicament( nomCommercial, composition, effets, contreindications, idFamille) " +
                "VALUES(" +
                " '" + ajoutable.NomCommercial + "'," +
                " '" + ajoutable.Composition + "'," +
                " '" + ajoutable.Effets + "'," +
                " '" + ajoutable.Contreindiactions + "'," +
                       ajoutable.LaFamille.Id + ");";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Membre Ajouter avec succes", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'ajout", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        //Permet d'acceder à un medicament grace à sont id
        public Medicamant Getmedocs(int idMedoc)
        {
            OpenConnection();
            string query = "SELECT* FROM Medicament WHERE idMedicament = " + idMedoc;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            Medicamant unMedoc = null;

            while (reader.Read())
            {
                unMedoc = new Medicamant(
                    (int)reader["idMedicament"],
                    reader["nomCommercial"].ToString(),
                    reader["contreindications"].ToString(),
                    reader["effets"].ToString(),
                    reader["composition"].ToString()
                    );
            }
            reader.Close();
            return unMedoc;

        }

        //Cree une list d'echantillon lié à un id de rapport 
        public List<Echantillon> ListEchantillon(int idRapport)
        {
            string query = "SELECT * FROM offrir WHERE idRapport = " + idRapport + " ORDER BY idRapport DESC";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Echantillon> lesEchantillons = new List<Echantillon>();

            while (reader.Read())
            {
                lesEchantillons.Add(new Echantillon(
                    (int)reader["idRapport"],
                    (int)reader["idMedicament"],
                    (int)reader["quantite"]
                    ));
            }
            reader.Close();
            return lesEchantillons;

        }

        //Ajoute un echantillon à la base
        public void addEchantillon(Echantillon newEchantillon)
        {
            OpenConnection();
            Echantillon ajoutable = newEchantillon;
            //int pas entre cote et date entrecote


            string query = "INSERT INTO `offrir`( `idRapport`,`idMedicament`, `quantite`) " +
                "VALUES(" +
                " '" + ajoutable.IdRapport + "'," +
                " '" + ajoutable.IdMedicament + "'," +
                " '" + ajoutable.Quantite + "');";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Echantillon Ajouter avec succes", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'ajout", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        #endregion

        #region Outils Visiteurs

        //Cree et renvoie une liste de tout les visiteurs enregistrer
        public List<Visiteur> VisiteursList()
        {

            OpenConnection();
            string query = "SELECT * FROM visiteur ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Visiteur> ListeVisiteur = new List<Visiteur>();


            while (reader.Read())
            {
                ListeVisiteur.Add(new Visiteur(
                    reader["login"].ToString(),
                    reader["mdp"].ToString(),
                    reader["cp"].ToString(),
                    reader["ville"].ToString(),
                    (DateTime)reader["dateEmbauche"],
                    (int)reader["idVisiteur"],
                    reader["nom"].ToString(),
                    reader["prenom"].ToString(),
                    reader["adresse"].ToString()));
                //MessageBox.Show(ListeVisiteur.Last().DateEmbauche.ToString(), "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reader.Close();
            cmd.Connection.Close();

            return ListeVisiteur;

        }

        //renvoie le nombre total de visiteur
        public int NbVisiteur()
        {
            string countquery = "SELECT COUNT(nom) FROM visiteur";
            MySqlCommand countcmd = new MySqlCommand(countquery, connection);
            int countLine = Convert.ToInt32(countcmd.ExecuteScalar());
            return countLine;

        }

        //Methode d'ajout d'un visiteur à la base de donnée 
        public void addVisiteur(Visiteur newVisteur)
        {
            OpenConnection();
            Visiteur ajoutable = newVisteur;
            //int pas entre cote et date entrecote

            string query =
                "INSERT INTO `visiteur`(nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) " +
                "VALUES (" +
                " '" + ajoutable.Nom + "'," +
                " '" + ajoutable.Prenom + "'," +
                " '" + ajoutable.Login + "'," +
                " '" + ajoutable.Mdp + "'," +
                " '" + ajoutable.Adresse + "'," +
                " '" + ajoutable.Cp + "'," +
                " '" + ajoutable.Ville + "'," +
                " '" + ajoutable.DateEmbauche.ToString("yyyy-MM-dd") + "'" + ")"
                ;

            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Visiteur Ajouter avec succes", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Erreur lors de l'ajout", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Renvoie le visiteur possédant l'id en parametre
        public Visiteur GetVisiteur(int idVisiteur)
        {
            OpenConnection();
            string query = "SELECT* FROM visiteur WHERE idVisiteur = " + idVisiteur;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            Visiteur unVisiteur = null;
            while (reader.Read())
            {
                unVisiteur = new Visiteur(
                    reader["login"].ToString(),
                    reader["mdp"].ToString(),
                    reader["cp"].ToString(),
                    reader["ville"].ToString(),
                    (DateTime)reader["dateEmbauche"],
                    (int)reader["idVisiteur"],
                    reader["nom"].ToString(),
                    reader["prenom"].ToString(),
                    reader["adresse"].ToString()
                    );
            }
            reader.Close();
            return unVisiteur;

        }

        #endregion

        #region Outils Médecin

        //Renvoie le nombre total de médecin enregistrer dans la base
        public int NbMedecin()
        {
            string countquery = "SELECT COUNT(idMedecin) FROM medecin";
            MySqlCommand countcmd = new MySqlCommand(countquery, connection);
            int countLine = Convert.ToInt32(countcmd.ExecuteScalar());
            return countLine;
        }

        //Crée et renvoi une liste contenant les médecins 
        public List<Medecin> MedecinList()
        {
            OpenConnection();
            string query = "SELECT * FROM Medecin INNER JOIN specialite WHERE medecin.idSpecialite = specialite.idSpecialite";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Medecin> ListeMeds = new List<Medecin>();
            //string tel, int departement, int id, string nom, string prenom, string adresse, Specialite laSpecialite
            while (reader.Read())
            {
                ListeMeds.Add(new Medecin(
                    reader["tel"].ToString(),
                    (int)reader["departement"],
                    (int)reader["idMedecin"],
                    reader["nom"].ToString(),
                    reader["prenom"].ToString(),
                    reader["adresse"].ToString(),
                    new Specialite((int)reader["idSpecialite"],
                    reader["libelle"].ToString())));
                
            }
            reader.Close();
            cmd.Connection.Close();
            return ListeMeds;

        }

        //Renvoi un médecin ayant pour id l'idMedecin fourni en paramètre
        public Medecin GetMedecin(int idMedecin)
        {
            OpenConnection();
            string query = "SELECT* FROM Medecin WHERE idMedecin = " + idMedecin;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            Medecin unMedecin = null;

            while (reader.Read())
            {
                unMedecin = new Medecin(
                    reader["tel"].ToString(),
                    (int)reader["departement"],
                    (int)reader["idMedecin"],
                    reader["nom"].ToString(),
                    reader["prenom"].ToString(),
                    reader["adresse"].ToString()
                    );
            }
            reader.Close();
            cmd.Connection.Close();
            return unMedecin;

        }

        //Crée une cotenant toute les spécialité 
        public List<Specialite> ListSpecia()
        {
            OpenConnection();
            string query = "SELECT * FROM specialite";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Specialite> ListeSpecia = new List<Specialite>();
            //string tel, int departement, int id, string nom, string prenom, string adresse, Specialite laSpecialite
            while (reader.Read())
            {
                ListeSpecia.Add(new Specialite(
                    (int)reader["idSpecialite"],
                    reader["libelle"].ToString()
                    ));

            }
            reader.Close();
            cmd.Connection.Close();
            return ListeSpecia;
        }

        //Méthode permetant d'ajouter un médecin 
        public void addMedecin(Medecin nouveauMedecin)
        {
            OpenConnection();
            Medecin ajoutable = nouveauMedecin;
            //int pas entre cote et date entrecote


            string query = "INSERT INTO `medecin`(`nom`, `prenom`, `adresse`, `tel`,`departement`, `idSpecialite`) " +
                "VALUES(" +
                " '" + ajoutable.Nom + "'," +
                " '" + ajoutable.Prenom + "'," +
                " '" + ajoutable.Adresse + "'," +
                " '" + ajoutable.Tel + "'," +
                " '" + ajoutable.Departement + "'," +
                       ajoutable.LaSpecialite.IdSpe + ");";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Medecin Ajouter avec succes", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'ajout", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        #endregion
    }
}
