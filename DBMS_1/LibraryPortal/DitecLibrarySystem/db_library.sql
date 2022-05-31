-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Feb 18, 2019 at 06:17 PM
-- Server version: 5.7.19
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_library`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barrow_books`
--

DROP TABLE IF EXISTS `tbl_barrow_books`;
CREATE TABLE IF NOT EXISTS `tbl_barrow_books` (
  `RefCode` int(11) NOT NULL AUTO_INCREMENT,
  `BookID` int(11) NOT NULL,
  `MemberID` varchar(10) NOT NULL,
  `IssueDate` date NOT NULL,
  `ReturnDate` date NOT NULL,
  `Status` varchar(12) NOT NULL,
  PRIMARY KEY (`RefCode`),
  KEY `BookID` (`BookID`),
  KEY `MemberID` (`MemberID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_book`
--

DROP TABLE IF EXISTS `tbl_book`;
CREATE TABLE IF NOT EXISTS `tbl_book` (
  `BookID` int(11) NOT NULL AUTO_INCREMENT,
  `BookName` varchar(100) NOT NULL,
  `BookPrice` decimal(10,2) NOT NULL,
  `Author` varchar(100) NOT NULL,
  `Category` varchar(20) NOT NULL,
  `Status` varchar(25) NOT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_member`
--

DROP TABLE IF EXISTS `tbl_member`;
CREATE TABLE IF NOT EXISTS `tbl_member` (
  `NIC` varchar(12) NOT NULL,
  `MemberName` varchar(100) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Lifelong` varchar(3) NOT NULL,
  PRIMARY KEY (`NIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_barrow_books`
--
ALTER TABLE `tbl_barrow_books`
  ADD CONSTRAINT `tbl_barrow_books_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `tbl_member` (`NIC`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
