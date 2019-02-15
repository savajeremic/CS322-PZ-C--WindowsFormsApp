-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 13, 2018 at 01:58 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cs322`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart_items`
--

CREATE TABLE `cart_items` (
  `id` int(11) NOT NULL,
  `game_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `flag` int(11) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cart_items`
--

INSERT INTO `cart_items` (`id`, `game_id`, `user_id`, `flag`) VALUES
(1, 2, 2, 2),
(2, 7, 8, 2);

-- --------------------------------------------------------

--
-- Table structure for table `game`
--

CREATE TABLE `game` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `company` varchar(100) NOT NULL,
  `description` varchar(255) NOT NULL,
  `price` int(50) NOT NULL,
  `genre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `game`
--

INSERT INTO `game` (`id`, `name`, `company`, `description`, `price`, `genre`) VALUES
(1, 'The Witcher 3: Wild Hunt - Game of the Year Edition', 'CD PROJEKT RED', 'Become a professional monster slayer and embark on an adventure of epic proportions! Upon its release, The Witcher 3: Wild Hunt ', 19, 'RPG'),
(2, 'The Elder Scrolls V', 'Bethesda Studios', 'Skyrim Special Edition brings the epic fantasy to life in stunning detail.', 27, 'RPG'),
(5, 'GWENT: The Witcher Card Game', 'CD PROJEKT RED', 'Join in The Witcher universe’s favorite card game! In GWENT, you clash with your friends in fast-paced duels that combine bluffing, on-the-fly decision making and careful deck construction.', 0, 'CCG'),
(6, 'Heroes of Might and Magic® 3: Complete', '3DO', 'Murder, treachery, resurrection, savage battles and ultimately-freedom!\\r\\nWhen Erathia''''s King Gryphonheart is murdered by traitors he is resurrected as an undead warlord who leads a ruthless invasion of his former Kingdom.', 15, 'Turn-based'),
(7, 'Divinity 2 Original Sin', 'Lamios Studios', 'Gather your party and develop relationships with your companions. Blast your opponents in deep, tactical, turn-based combat.', 44, 'Tactical Turn-Based RPG'),
(8, 'Cuphead', 'StudioMDHR', 'Cuphead is a classic run and gun action game heavily focused on boss battles. Inspired by cartoons of the 1930.', 19, 'Run and gun');

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

CREATE TABLE `genre` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `genre`
--

INSERT INTO `genre` (`id`, `name`) VALUES
(1, 'Action'),
(2, 'Adventure'),
(3, 'Indie'),
(4, 'RPG'),
(5, 'Shooters'),
(6, 'Simulation'),
(7, 'Sports'),
(8, 'Racing'),
(9, 'Strategy'),
(10, 'Fantasy'),
(11, 'Turn-based'),
(12, 'Point-and-click'),
(13, 'Horror'),
(14, 'Historical'),
(15, 'Real-Time'),
(16, 'Sci-fi');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `name` varchar(80) NOT NULL,
  `surname` varchar(80) NOT NULL,
  `flag` int(11) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `email`, `name`, `surname`, `flag`) VALUES
(1, 'admin', 'admin', 'admin96@gmail.com', 'Admin', 'Adminic', 0),
(2, 'vosa', 'vosa', 'vossa@gmail.com', 'Sava', 'Jeremic', 1),
(8, 'neko', 'neko', 'neko96@gmail.com', 'nekos', 'nekosic', 1),
(12, 'nekos', 'neko', 'neko', 'neko', 'neko', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart_items`
--
ALTER TABLE `cart_items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `game`
--
ALTER TABLE `game`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `genre`
--
ALTER TABLE `genre`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cart_items`
--
ALTER TABLE `cart_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `game`
--
ALTER TABLE `game`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `genre`
--
ALTER TABLE `genre`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
