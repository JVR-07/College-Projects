CREATE DATABASE AdventureWorks22211600
USE AdventureWorks22211600

CREATE SCHEMA HumanResource;

CREATE TABLE HumanResources.Department
(
	 DepartmentID SMALLINT IDENTITY(1,1), 
	 Name NVARCHAR(50) NOT NULL,
	 GroupName NVARCHAR(50) NOT NULL,
	 ModifiedDate DATETIME NOT NULL DEFAULT GETDATE()
	 CONSTRAINT PK_Department_DepartmentID PRIMARY KEY (DepartmentID) 
);

CREATE TABLE HumanResources.Employee
(
	BusinessEntityID INT,
	NationalIDNumber NVARCHAR(15) NOT NULL,
	LoginID NVARCHAR(256) NOT NULL,
	OrganizationNode HIERARCHYID,

	JobTitle NVARCHAR(50) NOT NULL,
	BirthDate DATE NOT NULL,
	MaritalStatus NCHAR(1) NOT NULL,
	Gender NCHAR(1) NOT NULL,
	HireDate DATE NOT NULL,
	SalariedFlag BIT DEFAULT 1,
	VacationHours SMALLINT DEFAULT 0,
	SickLeaveHours SMALLINT DEFAULT 0,
	rowguid UNIQUEIDENTIFIER DEFAULT NEWID(),
	ModifiedDate DATETIME DEFAULT GETDATE()
	CONSTRAINT PK_Employee_BusinessEntityID PRIMARY KEY (BusinessEntityID)
);

CREATE TABLE HumanResources.EmployeeDepartmentHistory
(
	BusinessEntityID INT NOT NULL,
	DepartmentID SMALLINT NOT NULL,
	ShiftID TINYINT NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE()
	CONSTRAINT PK_EmployeeDepartmentHistory PRIMARY KEY (BusinessEntityID, DepartmentID, ShiftID, StartDate)
);

CREATE TABLE HumanResources.EmployeePayHistory
(
	BusinessEntityID INT NOT NULL,
	RateChangeDate DATETIME NOT NULL, 
	Rate MONEY NOT NULL,
	PayFrequency TINYINT NOT NULL,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE()
	CONSTRAINT PK_EmployeePayHistoriy PRIMARY KEY (BusinessEntityID, RateChangeDate)
);

CREATE TABLE HumanResources.JobCandidate
(
	JobCandidateID INT IDENTITY(1,1),
	BusinessEntityID INT,
	Resume XML,
	ModifiedDate DATETIME NOT NULL DEFAULT GETDATE()
	CONSTRAINT PK_JobCandidate_JobCandidateID PRIMARY KEY (JobCandidateID)
);

CREATE TABLE HumanResources.Shift
(
	ShiftID TINYINT IDENTITY(1,1),
	Name NVARCHAR(50) NOT NULL,
	StartTime TIME(7) NOT NULL,
	EndTime TIME(7) NOT NULL,
	ModifiedDate DATETIME NOT NULL, DEFAULT GETDATE()
)