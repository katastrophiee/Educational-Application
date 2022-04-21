CREATE DATABASE  IF NOT EXISTS `gibjohn_tutoring` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `gidjohn_tutoring`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: gidjohn_tutoring
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `class`
--

DROP TABLE IF EXISTS `class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `class` (
  `classID` int NOT NULL,
  `className` varchar(45) NOT NULL,
  `classMemberUsername` varchar(45) NOT NULL,
  `isTeacher` tinyint NOT NULL,
  `entryID` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`entryID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class`
--

LOCK TABLES `class` WRITE;
/*!40000 ALTER TABLE `class` DISABLE KEYS */;
INSERT INTO `class` VALUES (1,'Math','kaytlen',1,1),(1,'Math','david',0,2),(2,'English','kaytlen',1,3),(3,'Science','kaytlen',1,4);
/*!40000 ALTER TABLE `class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `codes`
--

DROP TABLE IF EXISTS `codes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `codes` (
  `code` int NOT NULL,
  `school` varchar(45) NOT NULL,
  `isTeacher` tinyint NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `codes`
--

LOCK TABLES `codes` WRITE;
/*!40000 ALTER TABLE `codes` DISABLE KEYS */;
INSERT INTO `codes` VALUES (96503094,'test',1),(134958264,'test',1),(374923845,'test',0),(377856756,'test',0),(679456734,'test',0),(746285673,'test',0),(749214852,'test',0),(823492103,'test',1),(845934569,'test',0),(945204769,'test',0),(945720474,'test',0);
/*!40000 ALTER TABLE `codes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `studentID` int NOT NULL AUTO_INCREMENT,
  `studentName` varchar(45) NOT NULL,
  `studentUsername` varchar(45) NOT NULL,
  `studentPassword` varchar(1000) NOT NULL,
  `studentEmail` varchar(45) NOT NULL,
  `code` int NOT NULL,
  PRIMARY KEY (`studentID`),
  UNIQUE KEY `username_UNIQUE` (`studentUsername`),
  UNIQUE KEY `studentEmail_UNIQUE` (`studentEmail`),
  UNIQUE KEY `code_UNIQUE` (`code`),
  KEY `user_code_idx` (`code`),
  CONSTRAINT `user_code` FOREIGN KEY (`code`) REFERENCES `codes` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'ds','f','442950B52567A514EAF136EE64F78408CBABD88975267F3EBC265348DE8E5CE86BA62A198ADC3C83A27BFA874F819871B6D029854C94182CF41C76CD1D0D9D4C','sdj@fmn.cp',945720474),(67,'David','david','5B0192EB3A8EC46A3C39C5E9DA8A86EAD8B1BB282724AD7010F2FD9DBD0BDC9714E2F6E15AC51BCF43E1576519BA0906D08FF56933A061336766972F420EC1DD','david@david.com',845934569),(73,'d','sfsdfsd','BCA1DC443FBC70155E3142ED7702E667E32A35E30362B7226E8CEA7D7A41529D2CC1BFE87BE6AB978B8B4E73709E9A5248A0431DE8C9FE99C4B57EFB312BCA85','edfs@jd.com',377856756);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teachers` (
  `teacherID` int NOT NULL AUTO_INCREMENT,
  `teacherName` varchar(45) NOT NULL,
  `teacherUsername` varchar(45) NOT NULL,
  `teacherPassword` varchar(1000) NOT NULL,
  `teacherEmail` varchar(45) NOT NULL,
  `code` int NOT NULL,
  PRIMARY KEY (`teacherID`),
  UNIQUE KEY `teacherID_UNIQUE` (`teacherID`),
  UNIQUE KEY `teacherUsername_UNIQUE` (`teacherUsername`),
  UNIQUE KEY `teacherEmail_UNIQUE` (`teacherEmail`),
  UNIQUE KEY `code_UNIQUE` (`code`),
  CONSTRAINT `code` FOREIGN KEY (`code`) REFERENCES `codes` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'test','testing','test','test@test.com',96503094),(2,'teacher','teacher','TEACHER','teacher',823492103),(6,'Kaytlen','kaytlen','4AAF837546E1398761626BB98BCC48F41E0B4ED0C31F10FB1E11B59E6EFFFCC3E73DB318D4DC0C01AFC19A90C8AA1587B1A9A63522B9F08676EECE0D3C9EFC71','kaytlen@kaytlen.com',134958264);
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tests`
--

DROP TABLE IF EXISTS `tests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tests` (
  `testTakenID` int NOT NULL AUTO_INCREMENT,
  `testID` int DEFAULT NULL,
  `studentID` int DEFAULT NULL,
  `testName` varchar(45) DEFAULT NULL,
  `dateOfTest` datetime DEFAULT NULL,
  `score` int DEFAULT NULL,
  `studentUsername` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`testTakenID`),
  UNIQUE KEY `testID_UNIQUE` (`testTakenID`),
  KEY `studentID_idx` (`studentID`),
  CONSTRAINT `studentID` FOREIGN KEY (`studentID`) REFERENCES `students` (`studentID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tests`
--

LOCK TABLES `tests` WRITE;
/*!40000 ALTER TABLE `tests` DISABLE KEYS */;
INSERT INTO `tests` VALUES (1,1,67,'Maths - Paper 1','2022-03-22 00:00:00',34,'david'),(2,2,67,'Maths - Paper 2','2022-03-27 00:00:00',65,'david'),(3,3,67,'English Language - Paper 1','2022-03-31 00:00:00',56,'david'),(4,2,67,'English Literature - Paper 2','2022-04-09 00:00:00',29,'david'),(5,NULL,NULL,NULL,NULL,30,NULL),(6,NULL,NULL,NULL,NULL,100,NULL);
/*!40000 ALTER TABLE `tests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `topics`
--

DROP TABLE IF EXISTS `topics`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `topics` (
  `topicID` int NOT NULL AUTO_INCREMENT,
  `topicAreaName` varchar(45) NOT NULL,
  `subject` varchar(45) NOT NULL,
  PRIMARY KEY (`topicID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `topics`
--

LOCK TABLES `topics` WRITE;
/*!40000 ALTER TABLE `topics` DISABLE KEYS */;
/*!40000 ALTER TABLE `topics` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-21 13:58:57
