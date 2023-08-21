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
-- Table structure for table `departmentreqemp`
--

DROP TABLE IF EXISTS `departmentreqemp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departmentreqemp` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Dep_ID` varchar(45) DEFAULT NULL,
  `ReqEmpMonMor` varchar(45) DEFAULT NULL,
  `ReqEmpMonAft` varchar(45) DEFAULT NULL,
  `ReqEmpMonEve` varchar(45) DEFAULT NULL,
  `ReqEmpTueMor` varchar(45) DEFAULT NULL,
  `ReqEmpTueAft` varchar(45) DEFAULT NULL,
  `ReqEmpTueEve` varchar(45) DEFAULT NULL,
  `ReqEmpWedMor` varchar(45) DEFAULT NULL,
  `ReqEmpWedAft` varchar(45) DEFAULT NULL,
  `ReqEmpWedEve` varchar(45) DEFAULT NULL,
  `ReqEmpThuMor` varchar(45) DEFAULT NULL,
  `ReqEmpThuAft` varchar(45) DEFAULT NULL,
  `ReqEmpThuEve` varchar(45) DEFAULT NULL,
  `ReqEmpFriMor` varchar(45) DEFAULT NULL,
  `ReqEmpFriAft` varchar(45) DEFAULT NULL,
  `ReqEmpFriEve` varchar(45) DEFAULT NULL,
  `ReqEmpSatMor` varchar(45) DEFAULT NULL,
  `ReqEmpSatAft` varchar(45) DEFAULT NULL,
  `ReqEmpSatEve` varchar(45) DEFAULT NULL,
  `ReqEmpSunMor` varchar(45) DEFAULT NULL,
  `ReqEmpSunAft` varchar(45) DEFAULT NULL,
  `ReqEmpSunEve` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departmentreqemp`
--

LOCK TABLES `departmentreqemp` WRITE;
/*!40000 ALTER TABLE `departmentreqemp` DISABLE KEYS */;
INSERT INTO `departmentreqemp` VALUES (1,'2','2','1','2','0','0','0','2','3','0','0','0','0','0','0','0','0','1','1','0','0','0');
/*!40000 ALTER TABLE `departmentreqemp` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-21 17:37:17
