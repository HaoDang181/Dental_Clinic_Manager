CREATE TABLE `appointment_schedule` (
  `Date` date DEFAULT NULL,
  `Time` time DEFAULT NULL,
  `PatientName` varchar(45) DEFAULT NULL,
  `DoctorID` int DEFAULT NULL,
  `WaitingNumber` int DEFAULT NULL,
  KEY `FK_Doctor_Appointment_idx` (`DoctorID`),
  CONSTRAINT `FK_Doctor_Appointment` FOREIGN KEY (`DoctorID`) REFERENCES `doctor` (`DoctorID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `bill` (
  `BillID` int NOT NULL,
  `Date` date DEFAULT NULL,
  `PatientName` varchar(45) DEFAULT NULL,
  `TotalSuppliles` int DEFAULT NULL,
  `Total` float DEFAULT NULL,
  PRIMARY KEY (`BillID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `doctor` (
  `DoctorID` int NOT NULL,
  `DoctorName` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  `ExperienceYear` int DEFAULT NULL,
  PRIMARY KEY (`DoctorID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `patient` (
  `PatientID` int NOT NULL,
  `PatientName` varchar(45) DEFAULT NULL,
  `Age` varchar(45) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Illness` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PatientID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
