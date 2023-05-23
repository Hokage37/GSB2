-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : lun. 22 mai 2023 à 13:54
-- Version du serveur :  5.7.24
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsb_p2`
--

-- --------------------------------------------------------

--
-- Structure de la table `famille`
--

CREATE TABLE `famille` (
  `idFamille` int(10) NOT NULL,
  `libelle` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `famille`
--

INSERT INTO `famille` (`idFamille`, `libelle`) VALUES
(1, 'Analgésiques'),
(2, 'Anti-inflammatoires'),
(3, 'Antibiotiques'),
(4, 'Antibactériens'),
(5, 'Antituberculeux'),
(6, 'Antilépreux'),
(7, 'Antimycosiques'),
(8, 'Antiviraux'),
(9, 'Cardiologie'),
(10, 'Dermatologie'),
(11, 'Diététique'),
(12, 'Nutrition'),
(13, 'Endocrinologie'),
(14, 'Gastro-entérologie'),
(15, 'Hépatologie'),
(16, 'Gynécologie'),
(17, 'obstétrique'),
(18, 'Contraception'),
(19, 'Hématologie'),
(20, 'Immunologie'),
(21, 'Allergologie'),
(22, 'Neurologie'),
(23, 'Oto-rhino-laryngologie'),
(24, 'Parasitologie'),
(25, 'Pneumologie'),
(26, 'Psychiatrie'),
(27, 'Réanimation'),
(28, 'Toxicologie'),
(29, 'Rhumatologie'),
(30, 'Stomatologie'),
(31, 'Urologie'),
(32, 'Vaccins'),
(33, 'Immunoglobulines'),
(34, 'Sérothérapie'),
(35, 'Cancérologie'),
(36, 'Anesthésiques locaux'),
(37, 'Ophtalmologie');

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

CREATE TABLE `medecin` (
  `idMedecin` int(10) NOT NULL,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL,
  `adresse` varchar(25) NOT NULL,
  `tel` varchar(20) NOT NULL,
  `idSpecialite` int(10) NOT NULL,
  `departement` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`idMedecin`, `nom`, `prenom`, `adresse`, `tel`, `idSpecialite`, `departement`) VALUES
(1, 'Autexier', 'Maxime', 'centre médicalisé ', '0386070809', 2, 58000),
(2, 'Dupont', 'Jean', 'centre médicalisé', '0386070809', 1, 58000);

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

CREATE TABLE `medicament` (
  `idMedicament` int(10) NOT NULL,
  `nomCommercial` varchar(25) NOT NULL,
  `idFamille` int(10) NOT NULL,
  `composition` varchar(255) DEFAULT NULL,
  `effets` varchar(255) DEFAULT NULL,
  `contreindications` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`idMedicament`, `nomCommercial`, `idFamille`, `composition`, `effets`, `contreindications`) VALUES
(1, 'Dolidodo', 2, 'paracétamol gélule', 'réduction des maux de tête et traumatisme aigu', '2 par jour (midi et soir)'),
(2, 'MoinsAie', 1, 'Antidouleur', 'douleur forte', '1 par jour'),
(4, 'covid19', 32, 'Sel (potassium chloride, monobasic,potassium phosphate\r\nsodium chloride,basic sodium phosphate dihydrate)\r\nSucre (Sucrose)\r\nLipides ', 'Reduit les risque de contracter le covid19', '');

-- --------------------------------------------------------

--
-- Structure de la table `offrir`
--

CREATE TABLE `offrir` (
  `idRapport` int(10) NOT NULL,
  `idMedicament` int(10) NOT NULL,
  `quantite` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `offrir`
--

INSERT INTO `offrir` (`idRapport`, `idMedicament`, `quantite`) VALUES
(1, 2, 1),
(2, 1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `rapport`
--

CREATE TABLE `rapport` (
  `idRapport` int(10) NOT NULL,
  `date` date NOT NULL,
  `motif` varchar(255) NOT NULL,
  `bilan` varchar(255) NOT NULL,
  `idVisiteur` int(10) NOT NULL,
  `idMedecin` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `rapport`
--

INSERT INTO `rapport` (`idRapport`, `date`, `motif`, `bilan`, `idVisiteur`, `idMedecin`) VALUES
(1, '2021-10-01', 'Antidouleur', 'Favorable, possibilité de prescription', 1, 2),
(2, '2022-10-05', 'paracétamol', 'peu favorable, prescription mitiger', 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

CREATE TABLE `specialite` (
  `idSpecialite` int(10) NOT NULL,
  `libelle` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `specialite`
--

INSERT INTO `specialite` (`idSpecialite`, `libelle`) VALUES
(1, 'ostéopathe'),
(2, 'généraliste');

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

CREATE TABLE `visiteur` (
  `idVisiteur` int(9) NOT NULL,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL,
  `login` varchar(20) NOT NULL,
  `mdp` varchar(25) NOT NULL,
  `adresse` varchar(40) NOT NULL,
  `cp` varchar(10) NOT NULL,
  `ville` varchar(25) NOT NULL,
  `dateEmbauche` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `visiteur`
--

INSERT INTO `visiteur` (`idVisiteur`, `nom`, `prenom`, `login`, `mdp`, `adresse`, `cp`, `ville`, `dateEmbauche`) VALUES
(1, 'Augendre', 'Meidi', 'maugendre', 'rootbeer', 'lycee raoul follereau', '58000', 'nevers', '2021-09-02'),
(2, 'Cheymol', 'Quentin', 'qcheymol', 'rootbeer', 'lycee raoul follereau', '5800', 'Nevers', '2021-09-02'),
(3, 'Foucard', 'Tom', 'tFoucard', 'rootbear', 'lycée raoul follereau', '58000', 'nevers', '2023-05-22'),
(4, 'Foucard', 'Tom', 'tFoucard', 'rootbear', 'lycée raoul follereau', '58000', 'nevers', '2023-05-22');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `famille`
--
ALTER TABLE `famille`
  ADD PRIMARY KEY (`idFamille`);

--
-- Index pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD PRIMARY KEY (`idMedecin`),
  ADD KEY `fkSpecialite` (`idSpecialite`);

--
-- Index pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD PRIMARY KEY (`idMedicament`),
  ADD KEY `fkFamille` (`idFamille`);

--
-- Index pour la table `offrir`
--
ALTER TABLE `offrir`
  ADD KEY `fkRapport` (`idRapport`),
  ADD KEY `fkMedicament` (`idMedicament`);

--
-- Index pour la table `rapport`
--
ALTER TABLE `rapport`
  ADD PRIMARY KEY (`idRapport`),
  ADD KEY `fkVisiteur` (`idVisiteur`),
  ADD KEY `fkMedecin` (`idMedecin`);

--
-- Index pour la table `specialite`
--
ALTER TABLE `specialite`
  ADD PRIMARY KEY (`idSpecialite`);

--
-- Index pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD PRIMARY KEY (`idVisiteur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `famille`
--
ALTER TABLE `famille`
  MODIFY `idFamille` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT pour la table `medecin`
--
ALTER TABLE `medecin`
  MODIFY `idMedecin` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `medicament`
--
ALTER TABLE `medicament`
  MODIFY `idMedicament` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `rapport`
--
ALTER TABLE `rapport`
  MODIFY `idRapport` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `specialite`
--
ALTER TABLE `specialite`
  MODIFY `idSpecialite` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `visiteur`
--
ALTER TABLE `visiteur`
  MODIFY `idVisiteur` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD CONSTRAINT `fkSpecialite` FOREIGN KEY (`idSpecialite`) REFERENCES `specialite` (`idSpecialite`);

--
-- Contraintes pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD CONSTRAINT `fkFamille` FOREIGN KEY (`idFamille`) REFERENCES `famille` (`idFamille`);

--
-- Contraintes pour la table `offrir`
--
ALTER TABLE `offrir`
  ADD CONSTRAINT `fkMedicament` FOREIGN KEY (`idMedicament`) REFERENCES `medicament` (`idMedicament`),
  ADD CONSTRAINT `fkRapport` FOREIGN KEY (`idRapport`) REFERENCES `rapport` (`idRapport`);

--
-- Contraintes pour la table `rapport`
--
ALTER TABLE `rapport`
  ADD CONSTRAINT `fkMedecin` FOREIGN KEY (`idMedecin`) REFERENCES `medecin` (`idMedecin`),
  ADD CONSTRAINT `fkVisiteur` FOREIGN KEY (`idVisiteur`) REFERENCES `visiteur` (`idVisiteur`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
