-- MySQL Script generated by MySQL Workbench
-- Wed Sep 30 16:14:10 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema db_sed
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema db_sed
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_sed` DEFAULT CHARACTER SET utf8 ;
USE `db_sed` ;

-- -----------------------------------------------------
-- Table `db_sed`.`Colaboradores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Colaboradores` (
  `id_Colaborador` INT NOT NULL AUTO_INCREMENT,
  `dni` VARCHAR(10) NOT NULL,
  `nombres` VARCHAR(100) NOT NULL,
  `apellidos` VARCHAR(100) NOT NULL,
  `direccion` VARCHAR(200) NOT NULL,
  `correo` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(12) NOT NULL,
  `fechaNac` DATE NOT NULL,
  `id_Jefe` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Colaborador`),
  INDEX `fk_Colaboradores_Colaboradores1_idx` (`id_Jefe` ASC) VISIBLE,
  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC) VISIBLE,
  CONSTRAINT `fk_Colaboradores_Colaboradores1`
    FOREIGN KEY (`id_Jefe`)
    REFERENCES `db_sed`.`Colaboradores` (`id_Colaborador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Periodos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Periodos` (
  `id_Periodo` INT NOT NULL AUTO_INCREMENT,
  `fechaInicio` DATE NOT NULL,
  `fechaFin` DATE NOT NULL,
  `pesoEvalObj` DOUBLE NULL,
  `pesoEvalComp` DOUBLE NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Periodo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Escalas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Escalas` (
  `id_Escala` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NOT NULL,
  `tipo` TINYINT(1) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Escala`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Evaluaciones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Evaluaciones` (
  `id_Evaluacion` INT NOT NULL AUTO_INCREMENT,
  `id_Colaborador` INT NOT NULL,
  `id_Periodo` INT NOT NULL,
  `id_EscalaSinCalibrar` INT NULL,
  `id_EscalaFinal` INT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Evaluacion`),
  INDEX `fk_Evaluaciones_Colaboradores1_idx` (`id_Colaborador` ASC) VISIBLE,
  INDEX `fk_Evaluaciones_Periodos1_idx` (`id_Periodo` ASC) VISIBLE,
  INDEX `fk_Evaluaciones_Escalas1_idx` (`id_EscalaSinCalibrar` ASC) VISIBLE,
  INDEX `fk_Evaluaciones_Escalas2_idx` (`id_EscalaFinal` ASC) VISIBLE,
  CONSTRAINT `fk_Evaluaciones_Colaboradores1`
    FOREIGN KEY (`id_Colaborador`)
    REFERENCES `db_sed`.`Colaboradores` (`id_Colaborador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Evaluaciones_Periodos1`
    FOREIGN KEY (`id_Periodo`)
    REFERENCES `db_sed`.`Periodos` (`id_Periodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Evaluaciones_Escalas1`
    FOREIGN KEY (`id_EscalaSinCalibrar`)
    REFERENCES `db_sed`.`Escalas` (`id_Escala`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Evaluaciones_Escalas2`
    FOREIGN KEY (`id_EscalaFinal`)
    REFERENCES `db_sed`.`Escalas` (`id_Escala`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`EvaluacionesDesempenho`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`EvaluacionesDesempenho` (
  `observacionesComp` VARCHAR(100) NULL,
  `notaAutoEvalComp` DOUBLE NULL,
  `notaPreviaComp` DOUBLE NULL,
  `notaFinalComp` DOUBLE NULL,
  `observacionesObj` VARCHAR(100) NULL,
  `notaAutoEvalObj` DOUBLE NULL,
  `notaPreviaObj` DOUBLE NULL,
  `notaFinalObj` DOUBLE NULL,
  `id_Evaluacion` INT NOT NULL,
  PRIMARY KEY (`id_Evaluacion`),
  CONSTRAINT `fk_EvaluacionesDesempenho_Evaluaciones1`
    FOREIGN KEY (`id_Evaluacion`)
    REFERENCES `db_sed`.`Evaluaciones` (`id_Evaluacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Objetivos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Objetivos` (
  `id_Objetivo` INT NOT NULL AUTO_INCREMENT,
  `id_Colaborador` INT NOT NULL,
  `descripcion` VARCHAR(200) NOT NULL,
  `estado` INT NOT NULL,
  `fechaFormulacion` DATE NOT NULL,
  `fechaAprobacion` DATE NULL,
  `meta` DOUBLE NOT NULL,
  `unidadMedida` VARCHAR(50) NOT NULL,
  `observacion` VARCHAR(200) NULL,
  `peso` DOUBLE NOT NULL,
  `notaPrevia` DOUBLE NULL,
  `notaAutoEval` DOUBLE NULL,
  `notaFinal` DOUBLE NULL,
  `id_Evaluacion` INT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Objetivo`),
  INDEX `fk_Objetivos_Colaboradores_idx` (`id_Colaborador` ASC) VISIBLE,
  INDEX `fk_Objetivos_EvaluacionesDesempenho1_idx` (`id_Evaluacion` ASC) VISIBLE,
  CONSTRAINT `fk_Objetivos_Colaboradores`
    FOREIGN KEY (`id_Colaborador`)
    REFERENCES `db_sed`.`Colaboradores` (`id_Colaborador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Objetivos_EvaluacionesDesempenho1`
    FOREIGN KEY (`id_Evaluacion`)
    REFERENCES `db_sed`.`EvaluacionesDesempenho` (`id_Evaluacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Areas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Areas` (
  `id_Area` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NOT NULL,
  `descripcion` VARCHAR(150) NULL,
  `activo` TINYINT(1) NULL,
  PRIMARY KEY (`id_Area`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Colaboradores_Areas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Colaboradores_Areas` (
  `id_Colaborador` INT NOT NULL,
  `id_Area` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Colaborador`, `id_Area`),
  INDEX `fk_Colaboradores_has_Areas_Areas1_idx` (`id_Area` ASC) VISIBLE,
  INDEX `fk_Colaboradores_has_Areas_Colaboradores1_idx` (`id_Colaborador` ASC) VISIBLE,
  CONSTRAINT `fk_Colaboradores_has_Areas_Colaboradores1`
    FOREIGN KEY (`id_Colaborador`)
    REFERENCES `db_sed`.`Colaboradores` (`id_Colaborador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Colaboradores_has_Areas_Areas1`
    FOREIGN KEY (`id_Area`)
    REFERENCES `db_sed`.`Areas` (`id_Area`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`PuestosTrabajo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`PuestosTrabajo` (
  `id_PuestosTrabajo` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NOT NULL,
  `descripcion` VARCHAR(150) NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_PuestosTrabajo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Areas_Periodos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Areas_Periodos` (
  `id_Area` INT NOT NULL,
  `id_Periodo` INT NOT NULL,
  `fechaInicioPlan` DATE NULL,
  `fechaFinPlan` DATE NULL,
  `fechaInicioEval` DATE NULL,
  `fechaFinEval` DATE NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Area`, `id_Periodo`),
  INDEX `fk_Areas_has_Periodos_Periodos1_idx` (`id_Periodo` ASC) VISIBLE,
  INDEX `fk_Areas_has_Periodos_Areas1_idx` (`id_Area` ASC) VISIBLE,
  CONSTRAINT `fk_Areas_has_Periodos_Areas1`
    FOREIGN KEY (`id_Area`)
    REFERENCES `db_sed`.`Areas` (`id_Area`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Areas_has_Periodos_Periodos1`
    FOREIGN KEY (`id_Periodo`)
    REFERENCES `db_sed`.`Periodos` (`id_Periodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Areas_PuestosTrabajo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Areas_PuestosTrabajo` (
  `id_Area` INT NOT NULL,
  `id_PuestosTrabajo` INT NOT NULL,
  `activo` TINYINT(1) NULL,
  PRIMARY KEY (`id_Area`, `id_PuestosTrabajo`),
  INDEX `fk_Areas_has_PuestosTrabajo_PuestosTrabajo1_idx` (`id_PuestosTrabajo` ASC) VISIBLE,
  INDEX `fk_Areas_has_PuestosTrabajo_Areas1_idx` (`id_Area` ASC) VISIBLE,
  CONSTRAINT `fk_Areas_has_PuestosTrabajo_Areas1`
    FOREIGN KEY (`id_Area`)
    REFERENCES `db_sed`.`Areas` (`id_Area`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Areas_has_PuestosTrabajo_PuestosTrabajo1`
    FOREIGN KEY (`id_PuestosTrabajo`)
    REFERENCES `db_sed`.`PuestosTrabajo` (`id_PuestosTrabajo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Criterios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Criterios` (
  `id_Criterio` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NOT NULL,
  `descripcion` VARCHAR(150) NOT NULL,
  `esVigente` TINYINT(1) NULL,
  `tipo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Criterio`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`ItemsPDI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`ItemsPDI` (
  `id_ItemPDI` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_ItemPDI`))
ENGINE = InnoDB
COMMENT = 'I';


-- -----------------------------------------------------
-- Table `db_sed`.`Subcriterios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Subcriterios` (
  `id_Subcriterios` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NOT NULL,
  `descripcion` VARCHAR(150) NULL,
  `esVigente` TINYINT(1) NULL,
  `tipo` TINYINT(1) NOT NULL,
  `id_Criterio` INT NOT NULL,
  PRIMARY KEY (`id_Subcriterios`),
  INDEX `fk_Subcriterios_Criterios1_idx` (`id_Criterio` ASC) VISIBLE,
  CONSTRAINT `fk_Subcriterios_Criterios1`
    FOREIGN KEY (`id_Criterio`)
    REFERENCES `db_sed`.`Criterios` (`id_Criterio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Colaboradores_PuestosTrabajo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Colaboradores_PuestosTrabajo` (
  `id_Colaborador` INT NOT NULL,
  `id_PuestosTrabajo` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Colaborador`, `id_PuestosTrabajo`),
  INDEX `fk_Colaboradores_has_PuestosTrabajo_PuestosTrabajo1_idx` (`id_PuestosTrabajo` ASC) VISIBLE,
  INDEX `fk_Colaboradores_has_PuestosTrabajo_Colaboradores1_idx` (`id_Colaborador` ASC) VISIBLE,
  CONSTRAINT `fk_Colaboradores_has_PuestosTrabajo_Colaboradores1`
    FOREIGN KEY (`id_Colaborador`)
    REFERENCES `db_sed`.`Colaboradores` (`id_Colaborador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Colaboradores_has_PuestosTrabajo_PuestosTrabajo1`
    FOREIGN KEY (`id_PuestosTrabajo`)
    REFERENCES `db_sed`.`PuestosTrabajo` (`id_PuestosTrabajo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Escalas_Periodos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Escalas_Periodos` (
  `id_Escala` INT NOT NULL,
  `id_Periodo` INT NOT NULL,
  `notaMax` DOUBLE NULL,
  `notaMin` DOUBLE NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Escala`, `id_Periodo`),
  INDEX `fk_Escalas_has_Periodos_Periodos1_idx` (`id_Periodo` ASC) VISIBLE,
  INDEX `fk_Escalas_has_Periodos_Escalas1_idx` (`id_Escala` ASC) VISIBLE,
  CONSTRAINT `fk_Escalas_has_Periodos_Escalas1`
    FOREIGN KEY (`id_Escala`)
    REFERENCES `db_sed`.`Escalas` (`id_Escala`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Escalas_has_Periodos_Periodos1`
    FOREIGN KEY (`id_Periodo`)
    REFERENCES `db_sed`.`Periodos` (`id_Periodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`Cupos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`Cupos` (
  `id_Escala` INT NOT NULL,
  `id_Periodo` INT NOT NULL,
  `id_Area` INT NOT NULL,
  `num_Cupos` TINYINT(1) NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_Escala`, `id_Periodo`, `id_Area`),
  INDEX `fk_Escalas_Periodos_has_Areas_Areas1_idx` (`id_Area` ASC) VISIBLE,
  INDEX `fk_Escalas_Periodos_has_Areas_Escalas_Periodos1_idx` (`id_Escala` ASC, `id_Periodo` ASC) VISIBLE,
  CONSTRAINT `fk_Escalas_Periodos_has_Areas_Escalas_Periodos1`
    FOREIGN KEY (`id_Escala` , `id_Periodo`)
    REFERENCES `db_sed`.`Escalas_Periodos` (`id_Escala` , `id_Periodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Escalas_Periodos_has_Areas_Areas1`
    FOREIGN KEY (`id_Area`)
    REFERENCES `db_sed`.`Areas` (`id_Area`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`ItemsPDI_Periodos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`ItemsPDI_Periodos` (
  `id_ItemPDI` INT NOT NULL,
  `id_Periodo` INT NOT NULL,
  `notaMin` DOUBLE NOT NULL,
  `notaMax` DOUBLE NOT NULL,
  PRIMARY KEY (`id_ItemPDI`, `id_Periodo`),
  INDEX `fk_ItemsPDI_has_Periodos_Periodos1_idx` (`id_Periodo` ASC) VISIBLE,
  INDEX `fk_ItemsPDI_has_Periodos_ItemsPDI1_idx` (`id_ItemPDI` ASC) VISIBLE,
  CONSTRAINT `fk_ItemsPDI_has_Periodos_ItemsPDI1`
    FOREIGN KEY (`id_ItemPDI`)
    REFERENCES `db_sed`.`ItemsPDI` (`id_ItemPDI`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemsPDI_has_Periodos_Periodos1`
    FOREIGN KEY (`id_Periodo`)
    REFERENCES `db_sed`.`Periodos` (`id_Periodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`PesosCriterios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`PesosCriterios` (
  `id_Area` INT NOT NULL,
  `id_PuestosTrabajo` INT NOT NULL,
  `id_Periodo` INT NOT NULL,
  `id_Criterio` INT NOT NULL,
  `id_PesoCriterio` INT NOT NULL AUTO_INCREMENT,
  `peso` DOUBLE NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_PesoCriterio`),
  INDEX `fk_Areas_PuestosTrabajo_has_Periodos_Periodos1_idx` (`id_Periodo` ASC) VISIBLE,
  INDEX `fk_Areas_PuestosTrabajo_has_Periodos_Areas_PuestosTrabajo1_idx` (`id_Area` ASC, `id_PuestosTrabajo` ASC) VISIBLE,
  INDEX `fk_Areas_PuestosTrabajo_has_Periodos_Criterios1_idx` (`id_Criterio` ASC) VISIBLE,
  CONSTRAINT `fk_Areas_PuestosTrabajo_has_Periodos_Areas_PuestosTrabajo1`
    FOREIGN KEY (`id_Area` , `id_PuestosTrabajo`)
    REFERENCES `db_sed`.`Areas_PuestosTrabajo` (`id_Area` , `id_PuestosTrabajo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Areas_PuestosTrabajo_has_Periodos_Periodos1`
    FOREIGN KEY (`id_Periodo`)
    REFERENCES `db_sed`.`Periodos` (`id_Periodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Areas_PuestosTrabajo_has_Periodos_Criterios1`
    FOREIGN KEY (`id_Criterio`)
    REFERENCES `db_sed`.`Criterios` (`id_Criterio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`PesosSubcriterios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`PesosSubcriterios` (
  `id_Area` INT NOT NULL,
  `id_PuestosTrabajo` INT NOT NULL,
  `id_Subcriterios` INT NOT NULL,
  `id_PesoSubcriterio` INT NOT NULL AUTO_INCREMENT,
  `peso` DOUBLE NOT NULL,
  `id_Periodo` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_PesoSubcriterio`),
  INDEX `fk_Areas_PuestosTrabajo_has_Subcriterios_Subcriterios1_idx` (`id_Subcriterios` ASC) VISIBLE,
  INDEX `fk_Areas_PuestosTrabajo_has_Subcriterios_Areas_PuestosTraba_idx` (`id_Area` ASC, `id_PuestosTrabajo` ASC) VISIBLE,
  INDEX `fk_PesosSubcriterios_Periodos1_idx` (`id_Periodo` ASC) VISIBLE,
  CONSTRAINT `fk_Areas_PuestosTrabajo_has_Subcriterios_Areas_PuestosTrabajo1`
    FOREIGN KEY (`id_Area` , `id_PuestosTrabajo`)
    REFERENCES `db_sed`.`Areas_PuestosTrabajo` (`id_Area` , `id_PuestosTrabajo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Areas_PuestosTrabajo_has_Subcriterios_Subcriterios1`
    FOREIGN KEY (`id_Subcriterios`)
    REFERENCES `db_sed`.`Subcriterios` (`id_Subcriterios`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PesosSubcriterios_Periodos1`
    FOREIGN KEY (`id_Periodo`)
    REFERENCES `db_sed`.`Periodos` (`id_Periodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`EvaluacionesPotencial`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`EvaluacionesPotencial` (
  `observaciones` VARCHAR(150) NULL,
  `notaAutoEval` DOUBLE NULL,
  `notaPrevia` DOUBLE NULL,
  `notaFinal` DOUBLE NULL,
  `id_Evaluacion` INT NOT NULL,
  PRIMARY KEY (`id_Evaluacion`),
  CONSTRAINT `fk_EvaluacionesPotencial_Evaluaciones1`
    FOREIGN KEY (`id_Evaluacion`)
    REFERENCES `db_sed`.`Evaluaciones` (`id_Evaluacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`LineasEvaluacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`LineasEvaluacion` (
  `id_Evaluacion` INT NOT NULL,
  `id_PesoCriterio` INT NOT NULL,
  `id_ItemPDI` INT NOT NULL,
  `id_LineaEvaluacion` INT NOT NULL AUTO_INCREMENT,
  `notaAutoEval` DOUBLE NULL,
  `notaPrevia` DOUBLE NULL,
  `notaFinal` DOUBLE NULL,
  `activo` TINYINT(1) NOT NULL,
  INDEX `fk_Evaluaciones_has_PesosCriterios_PesosCriterios1_idx` (`id_PesoCriterio` ASC) VISIBLE,
  INDEX `fk_Evaluaciones_has_PesosCriterios_Evaluaciones1_idx` (`id_Evaluacion` ASC) VISIBLE,
  INDEX `fk_Evaluaciones_has_PesosCriterios_ItemsPDI1_idx` (`id_ItemPDI` ASC) VISIBLE,
  PRIMARY KEY (`id_LineaEvaluacion`),
  CONSTRAINT `fk_Evaluaciones_has_PesosCriterios_Evaluaciones1`
    FOREIGN KEY (`id_Evaluacion`)
    REFERENCES `db_sed`.`Evaluaciones` (`id_Evaluacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Evaluaciones_has_PesosCriterios_PesosCriterios1`
    FOREIGN KEY (`id_PesoCriterio`)
    REFERENCES `db_sed`.`PesosCriterios` (`id_PesoCriterio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Evaluaciones_has_PesosCriterios_ItemsPDI1`
    FOREIGN KEY (`id_ItemPDI`)
    REFERENCES `db_sed`.`ItemsPDI` (`id_ItemPDI`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`LineasCriterio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`LineasCriterio` (
  `id_LineaEvaluacion` INT NOT NULL,
  `id_PesoSubcriterio` INT NOT NULL,
  `id_LineaCriterio` INT NOT NULL AUTO_INCREMENT,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_LineaCriterio`),
  INDEX `fk_LineasEvaluacion_has_PesosSubcriterios_PesosSubcriterios_idx` (`id_PesoSubcriterio` ASC) VISIBLE,
  INDEX `fk_LineasEvaluacion_has_PesosSubcriterios_LineasEvaluacion1_idx` (`id_LineaEvaluacion` ASC) VISIBLE,
  CONSTRAINT `fk_LineasEvaluacion_has_PesosSubcriterios_LineasEvaluacion1`
    FOREIGN KEY (`id_LineaEvaluacion`)
    REFERENCES `db_sed`.`LineasEvaluacion` (`id_LineaEvaluacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_LineasEvaluacion_has_PesosSubcriterios_PesosSubcriterios1`
    FOREIGN KEY (`id_PesoSubcriterio`)
    REFERENCES `db_sed`.`PesosSubcriterios` (`id_PesoSubcriterio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`LineasPotencial`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`LineasPotencial` (
  `cumplioAutoEval` TINYINT(1) NULL,
  `cumplioPrevia` TINYINT(1) NULL,
  `cumplioFinal` TINYINT(1) NULL,
  `id_LineaCriterio` INT NOT NULL,
  PRIMARY KEY (`id_LineaCriterio`),
  CONSTRAINT `fk_LineasPotencial_LineasCriterio1`
    FOREIGN KEY (`id_LineaCriterio`)
    REFERENCES `db_sed`.`LineasCriterio` (`id_LineaCriterio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sed`.`LineasCompetencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sed`.`LineasCompetencia` (
  `id_LineaCriterio` INT NOT NULL,
  `notaAutoEval` DOUBLE NULL,
  `notaPrevia` DOUBLE NULL,
  `notaFinal` DOUBLE NULL,
  PRIMARY KEY (`id_LineaCriterio`),
  CONSTRAINT `fk_LineasCompetencia_LineasCriterio1`
    FOREIGN KEY (`id_LineaCriterio`)
    REFERENCES `db_sed`.`LineasCriterio` (`id_LineaCriterio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


-- Modificaciones

ALTER TABLE `db_sed`.`Colaboradores` 
DROP FOREIGN KEY `fk_Colaboradores_Colaboradores1`;
ALTER TABLE `db_sed`.`Colaboradores` 
CHANGE COLUMN `id_Jefe` `id_Jefe` INT NULL ;
ALTER TABLE `db_sed`.`Colaboradores` 
ADD CONSTRAINT `fk_Colaboradores_Colaboradores1`
  FOREIGN KEY (`id_Jefe`)
  REFERENCES `db_sed`.`Colaboradores` (`id_Colaborador`);


ALTER TABLE `db_sed`.`Cupos` 
CHANGE COLUMN `num_Cupos` `num_Cupos` INT NULL DEFAULT NULL ;