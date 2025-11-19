-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: IG_DB
-- ------------------------------------------------------
-- Server version	9.5.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ 'a8ed7277-b8b4-11f0-8dd8-c63b9f992c0e:1-62';

--
-- Table structure for table `Biltegia`
--

DROP TABLE IF EXISTS `Biltegia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Biltegia` (
  `Izena` varchar(100) NOT NULL,
  `Kantitatea` int NOT NULL,
  `Prezioa` float DEFAULT NULL,
  PRIMARY KEY (`Izena`),
  UNIQUE KEY `Izena` (`Izena`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Biltegia`
--

LOCK TABLES `Biltegia` WRITE;
/*!40000 ALTER TABLE `Biltegia` DISABLE KEYS */;
INSERT INTO `Biltegia` VALUES ('Cafe',1,3.4),('Patatas',6,2.4);
/*!40000 ALTER TABLE `Biltegia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Erabiltzaileak`
--

DROP TABLE IF EXISTS `Erabiltzaileak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Erabiltzaileak` (
  `Izena` varchar(100) NOT NULL,
  `Pazahitza` mediumtext NOT NULL,
  `Mota` mediumtext NOT NULL,
  PRIMARY KEY (`Izena`),
  UNIQUE KEY `Izena` (`Izena`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Erabiltzaileak`
--

LOCK TABLES `Erabiltzaileak` WRITE;
/*!40000 ALTER TABLE `Erabiltzaileak` DISABLE KEYS */;
INSERT INTO `Erabiltzaileak` VALUES ('Julen','123','Admin'),('Prueba','123','Erabiltzaile'),('Vin','123','Erabiltzaile');
/*!40000 ALTER TABLE `Erabiltzaileak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Mahiak`
--

DROP TABLE IF EXISTS `Mahiak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Mahiak` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mahia` int NOT NULL,
  `erreserbatua` tinyint(1) NOT NULL,
  `data` date NOT NULL,
  `mota` mediumtext NOT NULL,
  `erabiltzailea` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `erabiltzailea` (`erabiltzailea`),
  CONSTRAINT `Mahiak_ibfk_1` FOREIGN KEY (`erabiltzailea`) REFERENCES `Erabiltzaileak` (`Izena`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Mahiak`
--

LOCK TABLES `Mahiak` WRITE;
/*!40000 ALTER TABLE `Mahiak` DISABLE KEYS */;
/*!40000 ALTER TABLE `Mahiak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'IG_DB'
--
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-19 12:38:59
