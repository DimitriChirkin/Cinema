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
-- Table structure for table `tab`
--

DROP TABLE IF EXISTS `tab`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tab` (
  `id_tab` tinyint(4) NOT NULL AUTO_INCREMENT,
  `id_employees` tinyint(4) NOT NULL,
  `date_sale` date NOT NULL,
  `time_sale` time NOT NULL,
  PRIMARY KEY (`id_tab`),
  KEY `id_employees` (`id_employees`),
  CONSTRAINT `tab_ibfk_1` FOREIGN KEY (`id_employees`) REFERENCES `employees` (`id_employees`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tab`
--

LOCK TABLES `tab` WRITE;
/*!40000 ALTER TABLE `tab` DISABLE KEYS */;
INSERT INTO `tab` VALUES (1,1,'2019-04-01','12:00:00'),(2,1,'2019-04-01','12:12:00'),(3,1,'2019-04-01','13:00:00'),(4,1,'2019-01-04','19:01:06'),(5,1,'2019-01-04','19:03:24'),(6,1,'2019-01-04','19:05:58'),(7,1,'2019-01-04','19:09:18'),(8,1,'2019-01-04','19:09:18'),(9,1,'2019-01-04','19:09:18'),(10,1,'2019-01-04','19:13:31'),(11,1,'2019-01-04','19:13:56'),(12,1,'2019-01-04','19:20:28'),(13,1,'2019-01-04','19:40:41'),(14,1,'2019-01-04','19:49:50'),(15,1,'2019-01-05','13:15:40'),(16,3,'2019-01-05','15:20:59'),(17,3,'2019-01-08','18:34:09');
/*!40000 ALTER TABLE `tab` ENABLE KEYS */;
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
