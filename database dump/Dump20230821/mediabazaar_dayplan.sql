-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: mediabazaar
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `dayplan`
--

DROP TABLE IF EXISTS `dayplan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dayplan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Emp_ID` varchar(45) DEFAULT NULL,
  `Date` varchar(45) DEFAULT NULL,
  `Morning` varchar(45) DEFAULT NULL,
  `Afternoon` varchar(45) DEFAULT NULL,
  `Evening` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=452 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dayplan`
--

LOCK TABLES `dayplan` WRITE;
/*!40000 ALTER TABLE `dayplan` DISABLE KEYS */;
INSERT INTO `dayplan` VALUES (419,'2','2023-08-21 00:00:00','1','0','0'),(420,'4','2023-08-21 00:00:00','1','0','0'),(421,'4','2023-08-21 00:00:00','0','1','0'),(422,'5','2023-08-21 00:00:00','0','0','1'),(423,'10','2023-08-21 00:00:00','0','0','1'),(424,'2','2023-08-23 00:00:00','1','0','0'),(425,'3','2023-08-23 00:00:00','1','0','0'),(426,'3','2023-08-23 00:00:00','0','1','0'),(427,'10','2023-08-23 00:00:00','0','1','0'),(428,'4','2023-08-26 00:00:00','0','1','0'),(429,'4','2023-08-26 00:00:00','0','0','1'),(430,'2','2023-08-28 00:00:00','1','0','0'),(431,'4','2023-08-28 00:00:00','1','0','0'),(432,'4','2023-08-28 00:00:00','0','1','0'),(433,'5','2023-08-28 00:00:00','0','0','1'),(434,'10','2023-08-28 00:00:00','0','0','1'),(435,'2','2023-08-30 00:00:00','1','0','0'),(436,'3','2023-08-30 00:00:00','1','0','0'),(437,'3','2023-08-30 00:00:00','0','1','0'),(438,'10','2023-08-30 00:00:00','0','1','0'),(439,'4','2023-09-02 00:00:00','0','1','0'),(440,'4','2023-09-02 00:00:00','0','0','1'),(441,'2','2023-09-04 00:00:00','1','0','0'),(442,'4','2023-09-04 00:00:00','1','0','0'),(443,'4','2023-09-04 00:00:00','0','1','0'),(444,'5','2023-09-04 00:00:00','0','0','1'),(445,'10','2023-09-04 00:00:00','0','0','1'),(446,'2','2023-09-06 00:00:00','1','0','0'),(447,'3','2023-09-06 00:00:00','1','0','0'),(448,'3','2023-09-06 00:00:00','0','1','0'),(449,'10','2023-09-06 00:00:00','0','1','0'),(450,'4','2023-09-09 00:00:00','0','1','0'),(451,'4','2023-09-09 00:00:00','0','0','1');
/*!40000 ALTER TABLE `dayplan` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-21 17:37:16
