/*
SQLyog Community v12.12 (32 bit)
MySQL - 10.1.34-MariaDB : Database - evento_poa
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`evento_poa` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `evento_poa`;

/*Table structure for table `eventos` */

DROP TABLE IF EXISTS `eventos`;

CREATE TABLE `eventos` (
  `idEvento` int(11) NOT NULL AUTO_INCREMENT,
  `nomeEvento` varchar(200) NOT NULL,
  `dia` datetime DEFAULT NULL,
  `categoria` varchar(50) DEFAULT NULL,
  `descricao` text,
  `nomeCriador` varchar(150) NOT NULL,
  PRIMARY KEY (`idEvento`),
  KEY `nomeCriador` (`nomeCriador`),
  CONSTRAINT `eventos_ibfk_1` FOREIGN KEY (`nomeCriador`) REFERENCES `usuario` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

/*Data for the table `eventos` */

insert  into `eventos`(`idEvento`,`nomeEvento`,`dia`,`categoria`,`descricao`,`nomeCriador`) values (7,'Festa co whiskey','2018-11-24 00:00:00','Festa','Fexta do carai','mopires'),(8,'Dont let go','2018-11-20 00:00:00','Festa','Lets go motherfuckeeeer\r\n','mopires'),(9,'Festa da lasagna','2018-12-01 00:00:00','Festa','comer lasagna','mopires'),(10,'huehuebr','2018-12-05 00:00:00','Festa','hahaha','huebr'),(11,'show me love','2018-12-05 00:00:00','Festa','i just came to show love','mopires'),(12,'vai dar tudo certo','2018-12-05 00:00:00','Festa','Laaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa','matheuspires'),(13,'ah ah ah ah a ha ah ah ah','2019-01-15 00:00:00','Festa','asçddplqldlqldlqelpldlpqepepeldpepeplpldpdplllpqe','mopires'),(14,'Com Hora mais que certa','0000-00-00 00:00:00','Festa','tomar um cafesao ','mopires'),(15,'ttttttttttttttttttttttttttttttttttttttttttttttttttttt','2018-11-20 00:00:00','Festa','bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb','mopires'),(16,'aaaaaaaaaaaaaa','2018-11-24 00:00:00','Festa','aaaaaaaaaaaaaaa','mopires'),(18,'vgvvkvkhkjvkjvjjvk','2018-11-20 15:00:00','Festa','biiiiiiiiiy','mopires');

/*Table structure for table `participacoes` */

DROP TABLE IF EXISTS `participacoes`;

CREATE TABLE `participacoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idEvento` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idEvento` (`idEvento`),
  KEY `username` (`username`),
  CONSTRAINT `participacoes_ibfk_1` FOREIGN KEY (`idEvento`) REFERENCES `eventos` (`idEvento`),
  CONSTRAINT `participacoes_ibfk_2` FOREIGN KEY (`username`) REFERENCES `usuario` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

/*Data for the table `participacoes` */

insert  into `participacoes`(`id`,`idEvento`,`username`) values (4,7,'huebr'),(5,8,'huebr'),(6,9,'huebr'),(14,11,'mopires'),(15,11,'matheuspires'),(16,12,'matheuspires'),(17,7,'mopirrrr'),(18,11,'mopirrrr'),(19,12,'mopirrrr'),(22,18,'mopires');

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `username` varchar(20) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `sobrenome` varchar(100) DEFAULT NULL,
  `dataNascimento` date DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `usuario` */

insert  into `usuario`(`username`,`pass`,`nome`,`sobrenome`,`dataNascimento`) values ('huebr','123','hueheu','brbr','1994-11-07'),('matheuspires','123456','matheus','pires','0000-00-00'),('mopires','12345','Matheus','Pires','1995-05-14'),('mopirrrr','123','mmmmmm','jkl','0000-00-00');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
