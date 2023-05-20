-- MySQL dump 10.13  Distrib 8.0.27, for macos11 (x86_64)
--
-- Host: localhost    Database: claires_salon
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Appointments`
--

DROP TABLE IF EXISTS `Appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Appointments` (
  `AppointmentId` int NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Time` time DEFAULT NULL,
  `ClientId` int DEFAULT NULL,
  `StylistId` int DEFAULT NULL,
  PRIMARY KEY (`AppointmentId`),
  KEY `ClientId_idx` (`ClientId`),
  KEY `StylistId_idx` (`StylistId`),
  CONSTRAINT `appointments_ibfk_1` FOREIGN KEY (`StylistId`) REFERENCES `Stylists` (`StylistId`),
  CONSTRAINT `ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Clients` (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Appointments`
--

LOCK TABLES `Appointments` WRITE;
/*!40000 ALTER TABLE `Appointments` DISABLE KEYS */;
INSERT INTO `Appointments` VALUES (12,'2023-05-03','19:36:00',11,9),(15,'2023-05-20','18:00:00',13,10),(16,'2023-06-10','10:48:00',15,11),(17,'2023-06-10','08:46:00',16,12),(18,'2023-05-27','16:55:00',13,10);
/*!40000 ALTER TABLE `Appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Clients`
--

DROP TABLE IF EXISTS `Clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Phone` varchar(14) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `StylistId` int DEFAULT NULL,
  PRIMARY KEY (`ClientId`),
  KEY `StylistId_idx` (`StylistId`),
  CONSTRAINT `clients_ibfk_1` FOREIGN KEY (`StylistId`) REFERENCES `Stylists` (`StylistId`),
  CONSTRAINT `StylistId` FOREIGN KEY (`StylistId`) REFERENCES `Stylists` (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Clients`
--

LOCK TABLES `Clients` WRITE;
/*!40000 ALTER TABLE `Clients` DISABLE KEYS */;
INSERT INTO `Clients` VALUES (11,'Squeal Yeller','654-234-2333','squealer@gmail.com',9),(12,'Harold Bones','543-443-3333','harold@gord.net',9),(13,'Dull Skinbo','432-333-2222','skin@netscape.net',9),(14,'Reed Marsh','543-444-3333','reed@marsh.net',9),(15,'Peel Banana','543-233-4444','bannana@bana.com',10),(16,'Hobart McDagger','654-908-0999','hobart@gmail.com',12);
/*!40000 ALTER TABLE `Clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Stylists`
--

DROP TABLE IF EXISTS `Stylists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` int DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Stylists`
--

LOCK TABLES `Stylists` WRITE;
/*!40000 ALTER TABLE `Stylists` DISABLE KEYS */;
INSERT INTO `Stylists` VALUES (9,'Seal Birth',1),(10,'Gary McGary',3),(11,'Greg Francesca',2),(12,'Walter McDiggin',8);
/*!40000 ALTER TABLE `Stylists` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-19 17:01:49
