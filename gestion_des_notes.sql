-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 05, 2018 at 07:21 PM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gestion_des_notes`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `Login` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `NOM_COMPLET` varchar(50) NOT NULL,
  PRIMARY KEY (`Login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Login`, `Password`, `NOM_COMPLET`) VALUES
('login', 'password', 'ADMINISTRATEUR');

-- --------------------------------------------------------

--
-- Table structure for table `etudiant`
--

DROP TABLE IF EXISTS `etudiant`;
CREATE TABLE IF NOT EXISTS `etudiant` (
  `Login` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `NOM_COMPLET` varchar(50) NOT NULL,
  `FILIERE` varchar(50) NOT NULL,
  `Niveau` int(10) NOT NULL,
  `CNE` varchar(20) NOT NULL,
  PRIMARY KEY (`Login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `etudiant`
--

INSERT INTO `etudiant` (`Login`, `Password`, `NOM_COMPLET`, `FILIERE`, `Niveau`, `CNE`) VALUES
('login', 'password', 'OUHSSAIN ZAKARIAE', 'INFORMATIQUE', 2, '1513944615'),
('bouchra', 'password', 'BENLAMKADEM BOUCHRA', 'INFORMATIQUE', 2, '1513944616'),
('houssam', 'mahraz', 'MAHRAZ HOUSSAM', 'INFORMATIQUE', 2, '1513944617'),
('amine', 'moussaoui', 'MOUSSAOUI AMINE', 'INFORMATIQUE', 2, '1513944614'),
('aymane', 'rizke', 'AYMANE RIZKE', 'INFORMATIQUE', 2, '1513944613'),
('zineb', 'kebbab', 'KEBBAB ZINEB', 'INFORMATIQUE', 2, '1513944612'),
('zina', 'marham', 'MARHAM ZINA', 'INFORMATIQUE', 2, '1513944611'),
('ayoub', 'bouhmadi', 'BOUHMADI AYOUB', 'INFORMATIQUE', 2, '1513944610'),
('sara', 'houssaini', 'HOUSSAINI SARA', 'INFORMATIQUE', 2, '1513944609');

-- --------------------------------------------------------

--
-- Table structure for table `note`
--

DROP TABLE IF EXISTS `note`;
CREATE TABLE IF NOT EXISTS `note` (
  `CNE` varchar(20) NOT NULL,
  `Note_Module` float NOT NULL,
  `FILIERE` varchar(50) NOT NULL,
  `MATIERE` varchar(50) NOT NULL,
  `Niveau` int(10) NOT NULL,
  `NOM_COMPLET` varchar(50) NOT NULL,
  PRIMARY KEY (`CNE`,`MATIERE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `note`
--

INSERT INTO `note` (`CNE`, `Note_Module`, `FILIERE`, `MATIERE`, `Niveau`, `NOM_COMPLET`) VALUES
('1513944615', 16, 'INFORMATIQUE', 'C#', 2, 'OUHSSAIN ZAKARIAE'),
('1513944615', 19.75, 'INFORMATIQUE', 'JAVA', 2, 'OUHSSAIN ZAKARIAE'),
('1513944616', 12, 'INFORMATIQUE', 'C#', 2, 'BENLAMKADEM BOUCHRA'),
('1513944617', 7.5, 'INFORMATIQUE', 'C#', 2, 'MAHRAZ HOUSSAM'),
('1513944617', 12.5, 'INFORMATIQUE', 'JAVA', 2, 'MAHRAZ HOUSSAM'),
('1513944616', 16, 'INFORMATIQUE', 'JAVA', 2, 'BENLAMKADEM BOUCHRA'),
('1513944614', 13.75, 'INFORMATIQUE', 'C#', 2, 'MOUSSAOUI AMINE'),
('1513944614', 13.75, 'INFORMATIQUE', 'JAVA', 2, 'MOUSSAOUI AMINE'),
('1513944613', 16.25, 'INFORMATIQUE', 'C#', 2, 'AYMANE RIZKE'),
('1513944612', 17.5, 'INFORMATIQUE', 'C#', 2, 'KEBBAB ZINEB'),
('1513944612', 12.5, 'INFORMATIQUE', 'JAVA', 2, 'KEBBAB ZINEB'),
('1513944611', 14.25, 'INFORMATIQUE', 'C#', 2, 'MARHAM ZINA'),
('1513944611', 12.25, 'INFORMATIQUE', 'JAVA', 2, 'MARHAM ZINA'),
('1513944610', 2.5, 'INFORMATIQUE', 'C#', 2, 'BOUHMADI AYOUB'),
('1513944610', 12.5, 'INFORMATIQUE', 'JAVA', 2, 'BOUHMADI AYOUB'),
('1513944609', 13, 'INFORMATIQUE', 'C#', 2, 'HOUSSAINI SARA'),
('1513944609', 17.5, 'INFORMATIQUE', 'JAVA', 2, 'HOUSSAINI SARA'),
('1513944613', 17.25, 'INFORMATIQUE', 'JAVA', 2, 'AYMANE RIZKE');

-- --------------------------------------------------------

--
-- Table structure for table `prof`
--

DROP TABLE IF EXISTS `prof`;
CREATE TABLE IF NOT EXISTS `prof` (
  `Login` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `NOM_COMPLET` varchar(50) NOT NULL,
  `FILIERE` varchar(50) NOT NULL,
  `Niveau` int(10) NOT NULL,
  `MATIERE` varchar(50) NOT NULL,
  PRIMARY KEY (`Login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `prof`
--

INSERT INTO `prof` (`Login`, `Password`, `NOM_COMPLET`, `FILIERE`, `Niveau`, `MATIERE`) VALUES
('login', 'password', 'BERRADA MOHAMMED', 'INFORMATIQUE', 2, 'C#'),
('youness', 'lakhrissi', 'LAKHRISSI YOUNESS', 'INFORMATIQUE', 2, 'JAVA');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
