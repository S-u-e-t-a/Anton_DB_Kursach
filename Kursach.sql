/*
Created: 05.04.2021
Modified: 08.05.2021
Project: kursach
Model: MySQL 8.0
Database: MySQL 8.0
*/

-- Create tables section -------------------------------------------------

-- Table Custom

CREATE TABLE `Custom`
(
  `Cus_ID` Int NOT NULL AUTO_INCREMENT,
  `Cus_status` Bool NOT NULL,
  `Cus_date` Datetime NOT NULL,
  `Cus_amount` Int NOT NULL,
  `Mat_ID` Int NOT NULL,
  PRIMARY KEY (`Cus_ID`)
)
;

CREATE INDEX `IX_Relationship8` ON `Custom` (`Mat_ID`)
;

-- Table Material

CREATE TABLE `Material`
(
  `Mat_ID` Int NOT NULL,
  `Mat_description` Char(40) NOT NULL,
  `Spec_ID` Int NOT NULL,
  `Map_ID` Int NOT NULL
)
;

CREATE INDEX `IX_Relationship2` ON `Material` (`Spec_ID`)
;

CREATE INDEX `IX_Relationship5` ON `Material` (`Map_ID`)
;

ALTER TABLE `Material` ADD PRIMARY KEY (`Mat_ID`)
;

-- Table Storage

CREATE TABLE `Storage`
(
  `St_ID` Int NOT NULL,
  `St_description` Char(40) NOT NULL
)
;

ALTER TABLE `Storage` ADD PRIMARY KEY (`St_ID`)
;

-- Table Contains

CREATE TABLE `Contains`
(
  `Mat_ID` Int NOT NULL,
  `St_ID` Int NOT NULL,
  `Cont_amount` Int
)
;

ALTER TABLE `Contains` ADD PRIMARY KEY (`Mat_ID`, `St_ID`)
;

-- Table Factory

CREATE TABLE `Factory`
(
  `Fact_ID` Int NOT NULL,
  `Fact_status` Char(20) NOT NULL,
  `Fact_time` Time NOT NULL
)
;

ALTER TABLE `Factory` ADD PRIMARY KEY (`Fact_ID`)
;

-- Table Group_change

CREATE TABLE `Group_change`
(
  `Gr_ID` Int NOT NULL,
  `Fact_ID` Int NOT NULL
)
;

ALTER TABLE `Group_change` ADD PRIMARY KEY (`Gr_ID`, `Fact_ID`)
;

-- Table Specification

CREATE TABLE `Specification`
(
  `Spec_ID` Int NOT NULL,
  `Spec_description` Char(30) NOT NULL
)
;

ALTER TABLE `Specification` ADD PRIMARY KEY (`Spec_ID`)
;

-- Table Comp_spec

CREATE TABLE `Comp_spec`
(
  `Comp_ID` Int NOT NULL,
  `Comp_desc` Char(25) NOT NULL,
  `Operation_ID` Int NOT NULL,
  `Comp_amount` Int NOT NULL,
  `Spec_ID` Int NOT NULL,
  `Mat_ID` Int NOT NULL
)
;

CREATE INDEX `IX_Relationship4` ON `Comp_spec` (`Mat_ID`)
;

ALTER TABLE `Comp_spec` ADD PRIMARY KEY (`Comp_ID`, `Spec_ID`)
;

-- Table Technological_map

CREATE TABLE `Technological_map`
(
  `Map_ID` Int NOT NULL,
  `Map_description` Char(35) NOT NULL
)
;

ALTER TABLE `Technological_map` ADD PRIMARY KEY (`Map_ID`)
;

-- Table Comp_Map

CREATE TABLE `Comp_Map`
(
  `Oper_ID` Int NOT NULL,
  `Oper_desc` Char(25) NOT NULL,
  `Oper_time` Time NOT NULL,
  `Next_oper_ID` Int NOT NULL,
  `Map_ID` Int NOT NULL,
  `Fact_ID` Int NOT NULL
)
;

CREATE INDEX `IX_Relationship7` ON `Comp_Map` (`Fact_ID`)
;

ALTER TABLE `Comp_Map` ADD PRIMARY KEY (`Oper_ID`, `Map_ID`)
;

-- Create foreign keys (relationships) section -------------------------------------------------

ALTER TABLE `Contains` ADD CONSTRAINT `Contains_of1` FOREIGN KEY (`Mat_ID`) REFERENCES `Material` (`Mat_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Contains` ADD CONSTRAINT `Contains_of2` FOREIGN KEY (`St_ID`) REFERENCES `Storage` (`St_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Group_change` ADD CONSTRAINT `Belongs` FOREIGN KEY (`Fact_ID`) REFERENCES `Factory` (`Fact_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Material` ADD CONSTRAINT `Spec_uses` FOREIGN KEY (`Spec_ID`) REFERENCES `Specification` (`Spec_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Comp_spec` ADD CONSTRAINT `Includes_spec` FOREIGN KEY (`Spec_ID`) REFERENCES `Specification` (`Spec_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Comp_spec` ADD CONSTRAINT `Mat_Comp_uses` FOREIGN KEY (`Mat_ID`) REFERENCES `Material` (`Mat_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Material` ADD CONSTRAINT `TM_uses` FOREIGN KEY (`Map_ID`) REFERENCES `Technological_map` (`Map_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Comp_Map` ADD CONSTRAINT `Includes_oper` FOREIGN KEY (`Map_ID`) REFERENCES `Technological_map` (`Map_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Comp_Map` ADD CONSTRAINT `Using` FOREIGN KEY (`Fact_ID`) REFERENCES `Factory` (`Fact_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;

ALTER TABLE `Custom` ADD CONSTRAINT `Contains_cus` FOREIGN KEY (`Mat_ID`) REFERENCES `Material` (`Mat_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
;


