-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 29, 2014 at 05:56 AM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `netbaru`
--

-- --------------------------------------------------------

--
-- Table structure for table `dosen`
--

CREATE TABLE IF NOT EXISTS `dosen` (
  `nip` varchar(20) NOT NULL,
  `namadsn` varchar(25) NOT NULL,
  `passworddsn` varchar(20) NOT NULL,
  PRIMARY KEY (`nip`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dosen`
--

INSERT INTO `dosen` (`nip`, `namadsn`, `passworddsn`) VALUES
('091011', 'dirinya', '091011'),
('101112', 'bapak', '101112'),
('111213', 'ibu', '111213'),
('121314', 'aku', '121314'),
('131415', 'dia', '131415'),
('141516', 'kau', '141516');

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE IF NOT EXISTS `kelas` (
  `idkls` varchar(40) NOT NULL,
  `namakls` varchar(3) NOT NULL,
  `id_mk` varchar(20) NOT NULL,
  `nip` varchar(20) NOT NULL,
  `tahun` int(11) NOT NULL,
  `peserta` int(11) NOT NULL,
  PRIMARY KEY (`idkls`),
  KEY `nip` (`nip`),
  KEY `id_mk` (`id_mk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`idkls`, `namakls`, `id_mk`, `nip`, `tahun`, `peserta`) VALUES
('A BI 2012', 'A', 'BI', '141516', 2012, 2),
('A BI 2013', 'A', 'BI', '141516', 2013, 2),
('A BI 2014', 'A', 'BI', '141516', 2014, 1),
('A KK 2014', 'A', 'KK', '131415', 2014, 2),
('A KWN 2013', 'A', 'KWN', '131415', 2013, 3),
('A KWN 2014', 'A', 'KWN', '121314', 2014, 2),
('A NET 2013', 'A', 'NET', '141516', 2013, 2),
('A NET 2014', 'A', 'NET', '141516', 2014, 2),
('A PBO 2014', 'A', 'PBO', '111213', 2014, 1),
('A PT 2012', 'A', 'PT', '101112', 2012, 1),
('A PT 2013', 'A', 'PT', '121314', 2013, 1),
('A PT 2014', 'A', 'PT', '121314', 2014, 1),
('B KK 2014', 'B', 'KK', '131415', 2014, 2),
('B NET 2013', 'B', 'NET', '141516', 2013, 2),
('B PT 2012', 'B', 'PT', '111213', 2012, 1);

-- --------------------------------------------------------

--
-- Table structure for table `laporan`
--

CREATE TABLE IF NOT EXISTS `laporan` (
  `nrp` varchar(10) NOT NULL,
  `idkls` varchar(40) NOT NULL,
  `nilai` char(3) NOT NULL,
  `semesterambil` int(11) NOT NULL,
  KEY `nrp` (`nrp`),
  KEY `idkls` (`idkls`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `laporan`
--

INSERT INTO `laporan` (`nrp`, `idkls`, `nilai`, `semesterambil`) VALUES
('5112100049', 'A BI 2014', 'B', 1),
('5112100049', 'A PT 2014', 'BC', 1),
('5112100036', 'A BI 2013', 'B', 2),
('5112100036', 'A KWN 2013', 'B', 2),
('5112100036', 'A NET 2014', 'AB', 3),
('5112100184', 'A PBO 2014', 'C', 4),
('5112100184', 'A BI 2012', 'B', 1),
('5112100184', 'A KWN 2013', 'AB', 2),
('5112100184', 'A NET 2013', 'A', 3),
('5112100183', 'A KK 2014', 'BC', 5),
('5113100013', 'A NET 2014', 'A', 3),
('5113100013', 'A KWN 2014', 'A', 2),
('5113100013', 'A BI 2013', 'A', 1),
('5113100013', 'A PT 2013', 'B', 1);

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE IF NOT EXISTS `mahasiswa` (
  `nrp` varchar(10) NOT NULL,
  `namamhs` varchar(25) NOT NULL,
  `semester` int(11) NOT NULL,
  `sks` int(11) NOT NULL,
  `ipk` float NOT NULL,
  `passwordmhs` varchar(20) NOT NULL,
  PRIMARY KEY (`nrp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`nrp`, `namamhs`, `semester`, `sks`, `ipk`, `passwordmhs`) VALUES
('5112100036', 'Agus Adi', 3, 7, 3.21429, 'sogol'),
('5112100049', 'Adhi Purwanto', 1, 6, 2.66667, 'coba'),
('5112100112', 'Surya Darma', 5, 0, 0, 'surya'),
('5112100183', 'Aldrin Wiguna', 5, 3, 2.5, 'coba'),
('5112100184', 'Aditya Mustika', 5, 11, 3.10714, 'coba'),
('5113100013', 'Dwika Setyawan', 3, 11, 3.63636, 'wik');

-- --------------------------------------------------------

--
-- Table structure for table `matakuliah`
--

CREATE TABLE IF NOT EXISTS `matakuliah` (
  `id_mk` varchar(20) NOT NULL,
  `namamk` varchar(40) NOT NULL,
  `sks` int(11) NOT NULL,
  PRIMARY KEY (`id_mk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `matakuliah`
--

INSERT INTO `matakuliah` (`id_mk`, `namamk`, `sks`) VALUES
('BI', 'Bahasa Indonesia', 2),
('KK', 'kecerdasan komptasional', 3),
('KWN', 'Kewarganegaraan', 2),
('NET', 'framework', 3),
('PAA', 'perancangan dan analisis algoritma', 3),
('PBO', 'pemrograman berorientasi objek', 4),
('PT', 'pemrograman terstruktur', 4),
('Techno', 'Technopreneurship', 3);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kelas`
--
ALTER TABLE `kelas`
  ADD CONSTRAINT `kelas_ibfk_1` FOREIGN KEY (`nip`) REFERENCES `dosen` (`nip`),
  ADD CONSTRAINT `kelas_ibfk_2` FOREIGN KEY (`id_mk`) REFERENCES `matakuliah` (`id_mk`);

--
-- Constraints for table `laporan`
--
ALTER TABLE `laporan`
  ADD CONSTRAINT `laporan_ibfk_1` FOREIGN KEY (`nrp`) REFERENCES `mahasiswa` (`nrp`),
  ADD CONSTRAINT `laporan_ibfk_2` FOREIGN KEY (`idkls`) REFERENCES `kelas` (`idkls`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
