USE master 
GO

CREATE DATABASE AerolineaDB
GO

USE AerolineaDB
GO

CREATE TABLE BASE 
    (
     BS_ID INTEGER NOT NULL , 
     BS_NOMBRE VARCHAR (100) NOT NULL , 
     BS_CIUDAD VARCHAR (100) NOT NULL , 
     BS_ESTADO VARCHAR (100) NOT NULL ,
	 CONSTRAINT PK_BS_ID PRIMARY KEY (BS_ID)
    )
GO

CREATE TABLE AVION 
    (
     AVN_ID INTEGER NOT NULL , 
     AVN_MODELO VARCHAR (20) NOT NULL , 
     BS_ID INTEGER NOT NULL,
	 CONSTRAINT PK_AVN_ID PRIMARY KEY (AVN_ID),
	 CONSTRAINT FK_BS_ID_AVN FOREIGN KEY (BS_ID) REFERENCES BASE (BS_ID)
    )
GO

CREATE TABLE PILOTO 
    (
     PIL_ID INTEGER NOT NULL , 
     PIL_PRIMNOM VARCHAR (25) NOT NULL , 
     PIL_SEGNOM VARCHAR (25) , 
     PIL_PRIMAPE VARCHAR (25) NOT NULL , 
     PIL_SEGAPE VARCHAR (25) , 
     PIL_HRSVUEL TIME NOT NULL , 
     BS_ID INTEGER NOT NULL ,
	 CONSTRAINT PK_PIL_ID PRIMARY KEY (PIL_ID),
	 CONSTRAINT FK_BS_ID_PIL FOREIGN KEY (BS_ID) REFERENCES BASE (BS_ID)
    )
GO

CREATE TABLE TRIPULANTE 
    (
     TRIP_ID INTEGER NOT NULL , 
     TRIP_PRIMNOM VARCHAR (25) NOT NULL , 
     TRIP_SEGNOM VARCHAR (25) , 
     TRIP_PRIMAPE VARCHAR (25) NOT NULL , 
     TRIP_SEGAPE VARCHAR (25) ,
	 BS_ID INTEGER NOT NULL,
	 CONSTRAINT PK_TRIP_ID PRIMARY KEY (TRIP_ID),
	 CONSTRAINT FK_BS_ID_TRIP FOREIGN KEY (BS_ID) REFERENCES BASE (BS_ID)
    )
GO

CREATE TABLE USUARIO 
    (
     USR_NOMBRE VARCHAR (50) NOT NULL , 
     USR_CONTRA VARCHAR (50) NOT NULL ,
	 CONSTRAINT PK_USR_NOMBRE PRIMARY KEY (USR_NOMBRE)
    )
GO

CREATE TABLE VUELO 
    (
     VUE_ID INTEGER NOT NULL , 
     VUE_CIUDEST VARCHAR (100) NOT NULL , 
     VUE_ESTDEST VARCHAR (50) NOT NULL , 
     VUE_CIUORIGEN VARCHAR (50) NOT NULL , 
     VUE_ESTORIGEN VARCHAR (100) NOT NULL , 
     VUE_HORASAL TIME NOT NULL , 
     VUE_HORALLEG TIME NOT NULL , 
     PIL_ID INTEGER NOT NULL , 
     AVN_ID INTEGER NOT NULL ,
	 CONSTRAINT PK_VUE_ID PRIMARY KEY (VUE_ID),
	 CONSTRAINT FK_PIL_ID_VUE FOREIGN KEY (PIL_ID) REFERENCES PILOTO (PIL_ID),
	 CONSTRAINT FK_AVN_ID_VUE FOREIGN KEY (AVN_ID) REFERENCES AVION (AVN_ID)
    )
GO

CREATE TABLE DETALLE_VUELO_TRIPULANTE 
    (
     VUE_ID INTEGER NOT NULL,
	 TRIP_ID INTEGER NOT NULL,
	 CONSTRAINT PK_VUE_ID_TRIP_ID PRIMARY KEY (VUE_ID, TRIP_ID),
	 CONSTRAINT FK_VUE_ID_DETALLES FOREIGN KEY (VUE_ID) REFERENCES VUELO (VUE_ID),
	 CONSTRAINT FK_TRIP_ID_DETALLES FOREIGN KEY (TRIP_ID) REFERENCES TRIPULANTE (TRIP_ID)
    )
GO