-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 04 Novembre 2016 à 09:35
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `cookieclicker`
--

-- --------------------------------------------------------

--
-- Structure de la table `buildings`
--

CREATE TABLE IF NOT EXISTS `buildings` (
  `idBuilding` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `basePrice` double NOT NULL,
  `basePricePuissanceDe10` int(11) NOT NULL,
  `baseCps` double NOT NULL,
  `baseCpsPuissanceDe10` int(11) NOT NULL,
  `imgFileName` varchar(50) NOT NULL,
  PRIMARY KEY (`idBuilding`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=15 ;

--
-- Contenu de la table `buildings`
--

INSERT INTO `buildings` (`idBuilding`, `name`, `basePrice`, `basePricePuissanceDe10`, `baseCps`, `baseCpsPuissanceDe10`, `imgFileName`) VALUES
(1, 'Cursor', 1.5, 1, 1, -1, 'Cursor.png'),
(2, 'Grandma', 1, 2, 1, 0, 'Grandma.png'),
(3, 'Farm', 1.1, 3, 8, 0, 'Farm.png'),
(4, 'Mine', 1.2, 4, 4.7, 1, 'Mine.png'),
(5, 'Factory', 1.3, 5, 2.6, 2, 'Factory.png'),
(6, 'Bank', 1.4, 6, 1.4, 3, 'Bank.png'),
(7, 'Temple', 2, 7, 7.8, 3, 'Temple.png'),
(8, 'Wizard Tower', 3.3, 8, 4.4, 4, 'Wizardtower.png'),
(9, 'Shipment', 5.1, 9, 2.6, 5, 'Shipment.png'),
(10, 'Alchemy Lab', 7.5, 10, 1.6, 6, 'Alchemylab.png'),
(11, 'Portal', 1, 12, 1.6, 7, 'Portal.png'),
(12, 'Time Machine', 1.4, 13, 6.5, 7, 'Timemachine.png'),
(13, 'Antimatter Condenser', 1.7, 14, 4.3, 8, 'Antim.png'),
(14, 'Prism', 2.1, 15, 2.9, 9, 'Prism.png');

-- --------------------------------------------------------

--
-- Structure de la table `effects`
--

CREATE TABLE IF NOT EXISTS `effects` (
  `idEffect` int(11) NOT NULL AUTO_INCREMENT,
  `effect` varchar(50) NOT NULL,
  PRIMARY KEY (`idEffect`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=14 ;

--
-- Contenu de la table `effects`
--

INSERT INTO `effects` (`idEffect`, `effect`) VALUES
(1, 'Grandmas are twice as efficient.'),
(2, 'Frams are twice as efficient.'),
(3, 'Mines are twice as efficient.'),
(4, 'Factories are twice as efficient.'),
(5, 'Banks are twice as efficient.'),
(6, 'Temples are twice as efficient.'),
(7, 'Wizard are twice as efficient.'),
(8, 'Shipments are twice as efficient.'),
(9, 'Alchemy labs are twice as efficient.'),
(10, 'Portals are twice as efficient.'),
(11, 'Time machines are twice as efficient.'),
(12, 'Antimatter condensers are twice as efficient.'),
(13, 'Prisms are twice as efficient.');

-- --------------------------------------------------------

--
-- Structure de la table `upgrades`
--

CREATE TABLE IF NOT EXISTS `upgrades` (
  `idUpgrade` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `basePrice` double NOT NULL,
  `basePricePuissanceDe10` int(11) NOT NULL,
  `buildingsQuantityNeeded` int(11) DEFAULT NULL,
  `imgFileName` varchar(50) NOT NULL,
  PRIMARY KEY (`idUpgrade`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=105 ;

--
-- Contenu de la table `upgrades`
--

INSERT INTO `upgrades` (`idUpgrade`, `name`, `basePrice`, `basePricePuissanceDe10`, `buildingsQuantityNeeded`, `imgFileName`) VALUES
(1, 'Forwards from grandma', 1, 3, 1, 'RollingPin.png'),
(2, 'Steel-plated rolling pins', 5, 3, 5, 'PinkRollingPin.png'),
(3, 'Lubricated dentures', 5, 4, 25, 'CyanRollingPin.png'),
(4, 'Prune juice', 5, 6, 50, 'OrangeRollingPin.png'),
(5, 'Double-thick glasses', 5, 8, 100, 'GoldRollingPin.png'),
(6, 'Aging agents', 5, 10, 150, 'RustedRollingPin.png'),
(7, 'Xtreme walkers', 5, 13, 200, 'BlackRollingPin.png'),
(8, 'The Unbridling', 5, 16, 250, 'SilverRollingPin.png'),
(9, 'Cheap hoes', 1.1, 4, 1, 'WateringCan.png'),
(10, 'Fertilizer', 5.5, 4, 5, 'PinkWateringCan.png'),
(11, 'Cookie trees', 5.5, 5, 25, 'CyanWateringCan.png'),
(12, 'Genetically-modified cookies', 5.5, 7, 50, 'OrangeWateringCan.png'),
(13, 'Gingerbread scarecrows', 5.5, 9, 100, 'GoldWateringCan.png'),
(14, 'Pulsar sprinklers', 5.5, 11, 150, 'RustedWateringCan.png'),
(15, 'Fudge fungus', 5.5, 14, 200, 'BlackWateringCan.png'),
(16, 'Wheat triffids', 5.5, 17, 250, 'SilverWateringCan.png'),
(17, 'Sugar gas', 1.2, 5, 1, 'Pick.png'),
(18, 'Megadrill', 6, 5, 5, 'PinkPick.png'),
(19, 'Ultradrill', 6, 6, 25, 'CyanPick.png'),
(20, 'Ultimadrill', 6, 8, 50, 'OrangePick.png'),
(21, 'H-bomb mining', 6, 10, 100, 'GoldPick.png'),
(22, 'Coreforge', 6, 12, 150, 'RustedPick.png'),
(23, 'Planetsplitters', 6, 15, 200, 'BlackPick.png'),
(24, 'Canola oil wells', 6, 18, 250, 'SilverPick.png'),
(25, 'Sturdier conveyor belts', 1.3, 6, 1, 'Gears.png'),
(26, 'Child labor', 6.5, 6, 5, 'PinkGears.png'),
(27, 'Sweatshop', 6.5, 7, 25, 'CyanGears.png'),
(28, 'Radium reactors', 6.5, 9, 50, 'OrangeGears.png'),
(29, 'Recombobulators', 6.5, 11, 100, 'GoldGears.png'),
(30, 'Deep-bake process', 6.5, 13, 150, 'RustedGears.png'),
(31, 'Cyborg workforce', 6.5, 16, 200, 'BlackGears.png'),
(32, '78-hour days', 6.5, 19, 250, 'SilverGears.png'),
(33, 'Taller tellers', 1.4, 7, 1, 'Sack.png'),
(34, 'Scissor-resistant credit cards', 7, 7, 5, 'PinkSack.png'),
(35, 'Acid-proof vaults', 7, 8, 25, 'CyanSack.png'),
(36, 'Chocolate coins', 7, 10, 50, 'OrangeSack.png'),
(37, 'Exponential interest rates', 7, 12, 100, 'GoldSack.png'),
(38, 'Financial zen', 7, 14, 150, 'RustedSack.png'),
(39, 'Way of the wallet', 7, 17, 200, 'BlackSack.png'),
(40, 'The stuff rationale', 7, 20, 250, 'SilverSack.png'),
(41, 'Golden idols', 2, 8, 1, 'Idol.png'),
(42, 'Sacrifices', 1, 9, 5, 'PinkIdol.png'),
(43, 'Delicious blessing', 1, 10, 25, 'CyanIdol.png'),
(44, 'Sun festival', 1, 12, 50, 'OrangeIdol.png'),
(45, 'Enlarged pantheon', 1, 14, 100, 'GoldIdol.png'),
(46, 'Great Baker in the sky', 1, 16, 150, 'RustedIdol.png'),
(47, 'Creation myth', 1, 19, 200, 'BlackIdol.png'),
(48, 'Theocracy', 1, 22, 250, 'SilverIdol.png'),
(49, 'Pointier hats', 3.3, 9, 1, 'Hat.png'),
(50, 'Beardlier beards', 1.65, 10, 5, 'PinkHat.png'),
(51, 'Ancient grimoires', 1.65, 11, 25, 'CyanHat.png'),
(52, 'Kitchen curses', 1.65, 13, 50, 'OrangeHat.png'),
(53, 'School of sorcery', 1.65, 15, 100, 'GoldHat.png'),
(54, 'Dark formulas', 1.65, 17, 150, 'RustedHat.png'),
(55, 'Cookiemancy', 1.65, 20, 200, 'BlackHat.png'),
(56, 'Rabbit trick', 1.65, 23, 250, 'SilverHat.png'),
(57, 'Vanilla nebulae', 5.1, 10, 1, 'Spaceship.png'),
(58, 'Wormholes', 2.55, 11, 5, 'PinkSpaceship.png'),
(59, 'Frequent flyer', 2.55, 12, 25, 'CyanSpaceship.png'),
(60, 'Warp drive', 2.55, 14, 50, 'OrangeSpaceship.png'),
(61, 'Chocolate monoliths', 2.55, 16, 100, 'GoldSpaceship.png'),
(62, 'Generation ship', 2.55, 18, 150, 'RustedSpaceship.png'),
(63, 'Dyson sphere', 2.55, 21, 200, 'BlackSpaceship.png'),
(64, 'The final frontier', 2.55, 24, 250, 'SilverSpaceship.png'),
(65, 'Antimony', 7.5, 11, 1, 'Flask.png'),
(66, 'Essence of dough', 3.75, 12, 5, 'PinkFlask.png'),
(67, 'True chocolate', 3.75, 13, 25, 'CyanFlask.png'),
(68, 'Ambrosia', 3.75, 15, 50, 'OrangeFlask.png'),
(69, 'Aqua crustulae', 3.75, 17, 100, 'GoldFlask.png'),
(70, 'Origin crucible', 3.75, 19, 150, 'RustedFlask.png'),
(71, 'Theory of atomic fluidity', 3.75, 22, 200, 'BlackFlask.png'),
(72, 'Beige goo', 3.75, 25, 250, 'SilverFlask.png'),
(73, 'Ancient tablet', 1, 13, 1, 'Galaxy.png'),
(74, 'Insane oatling workers', 5, 13, 5, 'PinkGalaxy.png'),
(75, 'Soul bond', 5, 14, 25, 'CyanGalaxy.png'),
(76, 'Sanity dance', 5, 16, 50, 'OrangeGalaxy.png'),
(77, 'Brane transplant', 5, 18, 100, 'GoldGalaxy.png'),
(78, 'Deity-sized portals', 5, 20, 150, 'RustedGalaxy.png'),
(79, 'End of times back-up plan', 5, 23, 200, 'BlackGalaxy.png'),
(80, 'Maddening chants', 5, 26, 250, 'SilverGalaxy.png'),
(81, 'Flux capacitors', 1.4, 14, 1, 'PocketWatch.png'),
(82, 'Time paradox resolver', 7, 14, 5, 'PinkPocketWatch.png'),
(83, 'Quantum conundrum', 7, 15, 25, 'CyanPocketWatch.png'),
(84, 'Causality enforcer', 7, 17, 50, 'OrangePocketWatch.png'),
(85, 'Yestermorrow comparators', 7, 19, 100, 'GoldPocketWatch.png'),
(86, 'Far future enactment', 7, 21, 150, 'RustedPocketWatch.png'),
(87, 'Great loop hypothesis', 7, 24, 200, 'BlackPocketWatch.png'),
(88, 'Cookietopian moments of maybe', 7, 27, 250, 'SilverPocketWatch.png'),
(89, 'Sugar bosons', 1.7, 15, 1, 'Particles.png'),
(90, 'String theory', 8.5, 15, 5, 'PinkParticles.png'),
(91, 'Large macaron collider', 8.5, 16, 25, 'CyanParticles.png'),
(92, 'Big bang bake', 8.5, 18, 50, 'OrangeParticles.png'),
(93, 'Reverse cyclotrons', 8.5, 20, 100, 'GoldParticles.png'),
(94, 'anocosmics', 8.5, 22, 150, 'RustedParticles.png'),
(95, 'The Pulse', 8.5, 25, 200, 'BlackParticles.png'),
(96, 'Some other super-tiny fundamental particle? Probab', 8.5, 28, 250, 'SilverParticles.png'),
(97, 'Gem polish', 2.1, 16, 1, 'Prism.png'),
(98, '9th color', 1.05, 17, 5, 'PinkPrism.png'),
(99, 'Chocolate light', 1.05, 18, 25, 'CyanPrism.png'),
(100, 'Grainbow', 1.05, 20, 50, 'OrangePrism.png'),
(101, 'Pure cosmic light', 1.05, 22, 100, 'GoldPrism.png'),
(102, 'Glow-in-the-dark', 1.05, 24, 150, 'RustedPrism.png'),
(103, 'Lux sanctorum', 1.05, 27, 200, 'BlackPrism.png'),
(104, 'Reverse shadows', 1.05, 30, 250, 'SilverPrism.png');

-- --------------------------------------------------------

--
-- Structure de la table `upgrades_has_effects`
--

CREATE TABLE IF NOT EXISTS `upgrades_has_effects` (
  `idUpgrade` int(11) NOT NULL,
  `idEffect` int(11) NOT NULL,
  PRIMARY KEY (`idUpgrade`,`idEffect`),
  KEY `idEffect` (`idEffect`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `upgrades_has_effects`
--

INSERT INTO `upgrades_has_effects` (`idUpgrade`, `idEffect`) VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 1),
(5, 1),
(6, 1),
(7, 1),
(8, 1),
(9, 2),
(10, 2),
(11, 2),
(12, 2),
(13, 2),
(14, 2),
(15, 2),
(16, 2),
(17, 3),
(18, 3),
(19, 3),
(20, 3),
(21, 3),
(22, 3),
(23, 3),
(24, 3),
(25, 4),
(26, 4),
(27, 4),
(28, 4),
(29, 4),
(30, 4),
(31, 4),
(32, 4),
(33, 5),
(34, 5),
(35, 5),
(36, 5),
(37, 5),
(38, 5),
(39, 5),
(40, 5),
(41, 6),
(42, 6),
(43, 6),
(44, 6),
(45, 6),
(46, 6),
(47, 6),
(48, 6),
(49, 7),
(50, 7),
(51, 7),
(52, 7),
(53, 7),
(54, 7),
(55, 7),
(56, 7),
(57, 8),
(58, 8),
(59, 8),
(60, 8),
(61, 8),
(62, 8),
(63, 8),
(64, 8),
(65, 9),
(66, 9),
(67, 9),
(68, 9),
(69, 9),
(70, 9),
(71, 9),
(72, 9),
(73, 10),
(74, 10),
(75, 10),
(76, 10),
(77, 10),
(78, 10),
(79, 10),
(80, 10),
(81, 11),
(82, 11),
(83, 11),
(84, 11),
(85, 11),
(86, 11),
(87, 11),
(88, 11),
(89, 12),
(90, 12),
(91, 12),
(92, 12),
(93, 12),
(94, 12),
(95, 12),
(96, 12),
(97, 13),
(98, 13),
(99, 13),
(100, 13),
(101, 13),
(102, 13),
(103, 13),
(104, 13);

-- --------------------------------------------------------

--
-- Structure de la table `upgrades_isfor_buildings`
--

CREATE TABLE IF NOT EXISTS `upgrades_isfor_buildings` (
  `idUpgrade` int(11) NOT NULL,
  `idBuilding` int(11) NOT NULL,
  PRIMARY KEY (`idUpgrade`,`idBuilding`),
  KEY `idBuilding` (`idBuilding`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `upgrades_isfor_buildings`
--

INSERT INTO `upgrades_isfor_buildings` (`idUpgrade`, `idBuilding`) VALUES
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(5, 2),
(6, 2),
(7, 2),
(8, 2),
(9, 3),
(10, 3),
(11, 3),
(12, 3),
(13, 3),
(14, 3),
(15, 3),
(16, 3),
(17, 4),
(18, 4),
(19, 4),
(20, 4),
(21, 4),
(22, 4),
(23, 4),
(24, 4),
(25, 5),
(26, 5),
(27, 5),
(28, 5),
(29, 5),
(30, 5),
(31, 5),
(32, 5),
(33, 6),
(34, 6),
(35, 6),
(36, 6),
(37, 6),
(38, 6),
(39, 6),
(40, 6),
(41, 7),
(42, 7),
(43, 7),
(44, 7),
(45, 7),
(46, 7),
(47, 7),
(48, 7),
(49, 8),
(50, 8),
(51, 8),
(52, 8),
(53, 8),
(54, 8),
(55, 8),
(56, 8),
(57, 9),
(58, 9),
(59, 9),
(60, 9),
(61, 9),
(62, 9),
(63, 9),
(64, 9),
(65, 10),
(66, 10),
(67, 10),
(68, 10),
(69, 10),
(70, 10),
(71, 10),
(72, 10),
(73, 11),
(74, 11),
(75, 11),
(76, 11),
(77, 11),
(78, 11),
(79, 11),
(80, 11),
(81, 12),
(82, 12),
(83, 12),
(84, 12),
(85, 12),
(86, 12),
(87, 12),
(88, 12),
(89, 13),
(90, 13),
(91, 13),
(92, 13),
(93, 13),
(94, 13),
(95, 13),
(96, 13),
(97, 14),
(98, 14),
(99, 14),
(100, 14),
(101, 14),
(102, 14),
(103, 14),
(104, 14);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `upgrades_has_effects`
--
ALTER TABLE `upgrades_has_effects`
  ADD CONSTRAINT `upgrades_has_effects_ibfk_1` FOREIGN KEY (`idUpgrade`) REFERENCES `upgrades` (`idUpgrade`),
  ADD CONSTRAINT `upgrades_has_effects_ibfk_2` FOREIGN KEY (`idEffect`) REFERENCES `effects` (`idEffect`);

--
-- Contraintes pour la table `upgrades_isfor_buildings`
--
ALTER TABLE `upgrades_isfor_buildings`
  ADD CONSTRAINT `upgrades_isfor_buildings_ibfk_1` FOREIGN KEY (`idUpgrade`) REFERENCES `upgrades` (`idUpgrade`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
