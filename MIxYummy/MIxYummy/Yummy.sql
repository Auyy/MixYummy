-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Aug 02, 2021 at 12:06 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Yummy`
--

-- --------------------------------------------------------

--
-- Table structure for table `MY_Profile_Shop`
--

CREATE TABLE `MY_Profile_Shop` (
  `Profile_Shop_id` int(11) NOT NULL,
  `Shop_Email` varchar(100) NOT NULL,
  `Shop_Password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `MY_Profile_Shop`
--

INSERT INTO `MY_Profile_Shop` (`Profile_Shop_id`, `Shop_Email`, `Shop_Password`) VALUES
(1, 'Kwa_kwakwa@gmail.com', '12345');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `MY_Profile_Shop`
--
ALTER TABLE `MY_Profile_Shop`
  ADD PRIMARY KEY (`Profile_Shop_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `MY_Profile_Shop`
--
ALTER TABLE `MY_Profile_Shop`
  MODIFY `Profile_Shop_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
