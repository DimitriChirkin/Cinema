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
-- Table structure for table `film`
--

DROP TABLE IF EXISTS `film`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `film` (
  `id_film` tinyint(4) NOT NULL AUTO_INCREMENT,
  `name_film` char(100) NOT NULL,
  `lasting` int(4) NOT NULL,
  `producer` char(100) NOT NULL,
  `description` text NOT NULL,
  `limitation` varchar(3) NOT NULL,
  `genre` char(100) NOT NULL,
  `Main_male_role` char(50) NOT NULL,
  `Main_female_role` char(50) NOT NULL,
  PRIMARY KEY (`id_film`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `film`
--

LOCK TABLES `film` WRITE;
/*!40000 ALTER TABLE `film` DISABLE KEYS */;
INSERT INTO `film` VALUES (1,'Веном',111,'Рубен Фляйшер','Журналист Эдди Брок берет интервью у бизнесмена и ученого Карлтона Дрейка. Эта беседа оборачивается для Брока потерей работы. Однако вскоре Эдди удается узнать, что у Дрейка в лаборатории есть некий инопланетный паразит, которого он использует в экспериментах над людьми. Чтобы вернуть себе работу, Эдди решает вывести Дрейка на чистую воду. Он пробирается в лабораторию, пытаясь спасти жертву эксперимента, но в итоге сам сливается с инопланетным симбиотом. Научившись пользоваться суперсилами, полученными от пришельца, Эдди становится борцом с преступностью по имени Веном.','+16','боевик,ужасы,фантастика','Том Харди','Мишель Уильямс'),(3,'asdsa',111,'asdas','asdasd','12','asdasd','asdas','asd'),(4,'фыв',123,'фыв','фыв','2','фыв','фыв','фыв');
/*!40000 ALTER TABLE `film` ENABLE KEYS */;
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
