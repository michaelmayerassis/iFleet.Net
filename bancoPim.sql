-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: pim
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `contato`
--

DROP TABLE IF EXISTS `contato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contato` (
  `Telefone_PK` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Motorista_Id` int(10) unsigned NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  PRIMARY KEY (`Telefone_PK`),
  KEY `fk_Mot_Contato` (`Motorista_Id`),
  CONSTRAINT `fk_Mot_Contato` FOREIGN KEY (`Motorista_Id`) REFERENCES `motorista` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contato`
--

LOCK TABLES `contato` WRITE;
/*!40000 ALTER TABLE `contato` DISABLE KEYS */;
/*!40000 ALTER TABLE `contato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empresa` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(250) NOT NULL,
  `Cnpj` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Email` varchar(250) NOT NULL,
  `Endereco` varchar(250) NOT NULL,
  `Numero` int(10) unsigned NOT NULL,
  `Cidade` varchar(200) NOT NULL,
  `Bairro` varchar(200) DEFAULT NULL,
  `senha` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Cnpj` (`Cnpj`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa` VALUES (1,'a','a','a','a','a',1,'a','a','a');
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manutencao`
--

DROP TABLE IF EXISTS `manutencao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manutencao` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Veiculo_Id` int(10) unsigned NOT NULL,
  `Descricao` varchar(250) NOT NULL,
  `Data` date NOT NULL,
  `DataPrevista` date NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Vai_Manutencao` (`Veiculo_Id`),
  CONSTRAINT `fk_Vai_Manutencao` FOREIGN KEY (`Veiculo_Id`) REFERENCES `veiculo` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manutencao`
--

LOCK TABLES `manutencao` WRITE;
/*!40000 ALTER TABLE `manutencao` DISABLE KEYS */;
/*!40000 ALTER TABLE `manutencao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motorista`
--

DROP TABLE IF EXISTS `motorista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `motorista` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Cpf` varchar(50) NOT NULL,
  `Nome` varchar(250) NOT NULL,
  `Cnh` varchar(50) NOT NULL,
  `Categoria_Cnh` varchar(50) NOT NULL,
  `Dt_Nascimento` date NOT NULL,
  `Exame_Medico` varchar(250) NOT NULL,
  `Email` varchar(250) NOT NULL,
  `Endereco` varchar(250) NOT NULL,
  `Numero` int(10) unsigned NOT NULL,
  `Cidade` varchar(150) NOT NULL,
  `Bairro` varchar(150) DEFAULT NULL,
  `Cep` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`Id`,`Cpf`),
  UNIQUE KEY `Cpf` (`Cpf`),
  UNIQUE KEY `Cnh` (`Cnh`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motorista`
--

LOCK TABLES `motorista` WRITE;
/*!40000 ALTER TABLE `motorista` DISABLE KEYS */;
/*!40000 ALTER TABLE `motorista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `multa`
--

DROP TABLE IF EXISTS `multa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `multa` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Veiculo_Id` int(10) unsigned NOT NULL,
  `Endereco` varchar(250) NOT NULL,
  `Cidade` varchar(250) NOT NULL,
  `Estado` varchar(4) NOT NULL,
  `Cep` varchar(50) NOT NULL,
  `Gravidade` varchar(150) NOT NULL,
  `Data` date NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Vei_Multa` (`Veiculo_Id`),
  CONSTRAINT `fk_Vei_Multa` FOREIGN KEY (`Veiculo_Id`) REFERENCES `veiculo` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `multa`
--

LOCK TABLES `multa` WRITE;
/*!40000 ALTER TABLE `multa` DISABLE KEYS */;
/*!40000 ALTER TABLE `multa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `peca`
--

DROP TABLE IF EXISTS `peca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `peca` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(250) NOT NULL,
  `Descricao` varchar(250) DEFAULT 'null',
  `Prateleira` varchar(250) DEFAULT 'null',
  `Quantidade` int(10) unsigned DEFAULT '0',
  `valor` decimal(9,2) DEFAULT NULL,
  `EstoqueMinimo` int(10) unsigned DEFAULT '0',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Nome` (`Nome`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `peca`
--

LOCK TABLES `peca` WRITE;
/*!40000 ALTER TABLE `peca` DISABLE KEYS */;
INSERT INTO `peca` VALUES (1,'q','q','q',11,12.99,1),(2,'as',NULL,NULL,NULL,13.55,NULL),(3,'qk',NULL,NULL,NULL,11.34,NULL);
/*!40000 ALTER TABLE `peca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seguro`
--

DROP TABLE IF EXISTS `seguro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `seguro` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Veiculo_Id` int(10) unsigned NOT NULL,
  `Seguradora` varchar(250) NOT NULL,
  `Plano` varchar(150) NOT NULL,
  `Apolice` varchar(150) NOT NULL,
  `Validade` date NOT NULL,
  PRIMARY KEY (`Id`,`Veiculo_Id`),
  KEY `fk_Vei_Seguro` (`Veiculo_Id`),
  CONSTRAINT `fk_Vei_Seguro` FOREIGN KEY (`Veiculo_Id`) REFERENCES `veiculo` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seguro`
--

LOCK TABLES `seguro` WRITE;
/*!40000 ALTER TABLE `seguro` DISABLE KEYS */;
/*!40000 ALTER TABLE `seguro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculo`
--

DROP TABLE IF EXISTS `veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `veiculo` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Empresa_Id` int(10) unsigned NOT NULL,
  `Nome` varchar(250) NOT NULL,
  `Marca` varchar(200) NOT NULL,
  `Modelo` varchar(250) NOT NULL,
  `Cor` varchar(50) NOT NULL,
  `Renavan` varchar(50) NOT NULL,
  `Placa` varchar(50) NOT NULL,
  `Ano` int(10) unsigned NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Renavan` (`Renavan`),
  UNIQUE KEY `Placa` (`Placa`),
  KEY `fk_Emp_veiculo` (`Empresa_Id`),
  CONSTRAINT `fk_Emp_veiculo` FOREIGN KEY (`Empresa_Id`) REFERENCES `empresa` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo`
--

LOCK TABLES `veiculo` WRITE;
/*!40000 ALTER TABLE `veiculo` DISABLE KEYS */;
INSERT INTO `veiculo` VALUES (1,1,'ford','gol','2011','preta','12wsa','12wa',2011);
/*!40000 ALTER TABLE `veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculomanutencao`
--

DROP TABLE IF EXISTS `veiculomanutencao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `veiculomanutencao` (
  `Veiculo_Id` int(10) unsigned NOT NULL,
  `Manutencao_Id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`Veiculo_Id`,`Manutencao_Id`),
  KEY `fk_Vei_Manu` (`Manutencao_Id`),
  CONSTRAINT `fk_Man_vei` FOREIGN KEY (`Veiculo_Id`) REFERENCES `veiculo` (`Id`),
  CONSTRAINT `fk_Vei_Manu` FOREIGN KEY (`Manutencao_Id`) REFERENCES `manutencao` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculomanutencao`
--

LOCK TABLES `veiculomanutencao` WRITE;
/*!40000 ALTER TABLE `veiculomanutencao` DISABLE KEYS */;
/*!40000 ALTER TABLE `veiculomanutencao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculoviagem`
--

DROP TABLE IF EXISTS `veiculoviagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `veiculoviagem` (
  `Veiculo_Id` int(10) unsigned NOT NULL,
  `Viagem_Id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`Veiculo_Id`,`Viagem_Id`),
  KEY `fk_Vei_Viagem` (`Viagem_Id`),
  CONSTRAINT `fk_Vei_Viagem` FOREIGN KEY (`Viagem_Id`) REFERENCES `viagem` (`Id`),
  CONSTRAINT `fk_Via_veiculo` FOREIGN KEY (`Veiculo_Id`) REFERENCES `veiculo` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculoviagem`
--

LOCK TABLES `veiculoviagem` WRITE;
/*!40000 ALTER TABLE `veiculoviagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `veiculoviagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `viagem`
--

DROP TABLE IF EXISTS `viagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `viagem` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Motorista_Cpf` int(10) unsigned NOT NULL,
  `Local` varchar(250) NOT NULL,
  `Dt_Saida` date NOT NULL,
  `Dt_Entrada` date NOT NULL,
  `km_Saida` double unsigned NOT NULL,
  `Km_Entrada` double unsigned NOT NULL,
  `Situacao` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_Cpf_Viagem` (`Motorista_Cpf`),
  CONSTRAINT `fk_Cpf_Viagem` FOREIGN KEY (`Motorista_Cpf`) REFERENCES `motorista` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viagem`
--

LOCK TABLES `viagem` WRITE;
/*!40000 ALTER TABLE `viagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `viagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pim'
--

--
-- Dumping routines for database 'pim'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-10 13:03:50
