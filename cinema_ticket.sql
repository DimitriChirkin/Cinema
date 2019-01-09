-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: cinema
-- ------------------------------------------------------
-- Server version	5.5.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ticket` (
  `barcode` tinyint(4) NOT NULL AUTO_INCREMENT,
  `id_tab` tinyint(4) NOT NULL,
  `id_timetable` tinyint(4) DEFAULT NULL,
  `id_place` tinyint(4) NOT NULL,
  PRIMARY KEY (`barcode`),
  KEY `id_tab` (`id_tab`),
  KEY `id_timetable` (`id_timetable`),
  KEY `id_place` (`id_place`),
  CONSTRAINT `ticket_ibfk_1` FOREIGN KEY (`id_tab`) REFERENCES `tab` (`id_tab`),
  CONSTRAINT `ticket_ibfk_2` FOREIGN KEY (`id_timetable`) REFERENCES `timetable` (`id_timetable`),
  CONSTRAINT `ticket_ibfk_3` FOREIGN KEY (`id_place`) REFERENCES `place` (`id_place`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES (1,1,1,1),(2,2,1,2),(3,1,1,3),(4,1,1,4),(5,1,1,10),(6,1,1,20),(7,1,1,50),(8,1,1,60),(9,1,1,9),(10,12,1,6),(11,12,1,7),(12,13,1,5),(13,13,1,16),(14,14,3,4),(15,14,3,5),(16,15,5,1),(17,15,5,2),(18,15,5,3),(19,15,5,4),(20,15,5,5),(21,15,5,6),(22,15,5,7),(23,15,5,8),(24,15,5,9),(25,15,5,10),(26,15,5,73),(27,15,5,74),(28,15,5,75),(29,16,3,73),(30,16,3,74),(31,16,3,75),(32,17,1,26),(33,17,1,27);
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-09  3:48:34
