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
-- Table structure for table `place`
--

DROP TABLE IF EXISTS `place`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `place` (
  `id_place` tinyint(4) NOT NULL AUTO_INCREMENT,
  `id_hall` tinyint(4) NOT NULL,
  `row_place` int(10) NOT NULL,
  `place` int(10) NOT NULL,
  PRIMARY KEY (`id_place`),
  KEY `id_hall` (`id_hall`),
  CONSTRAINT `place_ibfk_1` FOREIGN KEY (`id_hall`) REFERENCES `hall` (`id_hall`)
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `place`
--

LOCK TABLES `place` WRITE;
/*!40000 ALTER TABLE `place` DISABLE KEYS */;
INSERT INTO `place` VALUES (1,1,1,1),(2,1,1,2),(3,1,1,3),(4,1,1,4),(5,1,1,5),(6,1,1,6),(7,1,1,7),(8,1,1,8),(9,1,1,9),(10,1,1,10),(11,1,2,1),(12,1,2,2),(13,1,2,3),(14,1,2,4),(15,1,2,5),(16,1,2,6),(17,1,2,7),(18,1,2,8),(19,1,2,9),(20,1,2,10),(21,1,2,11),(22,1,2,12),(23,1,3,1),(24,1,3,2),(25,1,3,3),(26,1,3,4),(27,1,3,5),(28,1,3,6),(29,1,3,7),(30,1,3,8),(31,1,3,9),(32,1,3,10),(45,1,4,1),(46,1,4,2),(47,1,4,3),(48,1,4,4),(49,1,4,5),(50,1,4,6),(51,1,4,7),(52,1,4,8),(53,1,4,9),(54,1,4,10),(55,1,4,11),(56,1,4,12),(57,1,5,1),(58,1,5,2),(59,1,5,3),(60,1,5,4),(61,1,5,5),(62,1,5,6),(63,1,5,7),(64,1,5,8),(65,1,5,9),(66,1,5,10),(67,1,5,11),(68,1,5,12),(69,1,6,1),(70,1,6,2),(71,1,6,3),(72,1,6,4),(73,1,6,5),(74,1,6,6),(75,1,6,7),(76,1,6,8),(77,1,6,9),(78,1,6,10),(79,1,6,11),(80,1,6,12);
/*!40000 ALTER TABLE `place` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-09  3:48:33
