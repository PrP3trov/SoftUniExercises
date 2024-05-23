--1. One-To-One Relationship

CREATE TABLE Persons
(
	PersonID INT IDENTITY,
	FirstName VARCHAR(60) NOT NULL,
	Salary DECIMAL(7,2) NOT NULL,
	PassportID INT NOT NULL
)

CREATE TABLE Passports
(
	PassportID INT NOT NULL UNIQUE,
	PassportNumber NVARCHAR(25),
)

INSERT INTO Persons (FirstName,Salary,PassportID)
VALUES('Roberto',43300.00,102),
('Tom',56100.00,103),
('Yana',60200.00,101)

INSERT INTO Passports (PassportID,PassportNumber)
VALUES (101,'N34FG21B'),
(102,'K65LO4R7'),
(103,'ZE657QP2')

ALTER TABLE Persons
ADD CONSTRAINT PK_PersonID PRIMARY KEY (PersonID)

ALTER TABLE Passports
ADD CONSTRAINT PK_PassportID PRIMARY KEY (PassportID)

ALTER TABLE Persons
ADD CONSTRAINT FK_Persons_Passports FOREIGN KEY(PassportID)
REFERENCES Passports(PassportID)

--2.One-To-Many Relationship

CREATE TABLE Models
(
	ModelID INT NOT NULL UNIQUE,
	[Name] VARCHAR(26) NOT NULL,
	ManufacturerID INT NOT NULL,
)

CREATE TABLE Manufacturers
(
	ManufacturerID INT NOT NULL,
	[Name] VARCHAR(26) NOT NULL,
	EstablishedOn DATETIME NOT NULL
)

INSERT INTO Models
VALUES (101,'X1',1),
(102,'i6',1),
(103,'Model S',2),
(104,'Model X',2),
(105,'Model 3',2),
(106,'Nova',3)

INSERT INTO Manufacturers
VALUES (1,'BMW',07/03/1916),
(2,'Tesla',01/01/2033),
(3,'Lada',01/05/1966)

ALTER TABLE Models
ADD CONSTRAINT PK_ModelID PRIMARY KEY (ModelID)

ALTER TABLE Manufacturers
ADD CONSTRAINT PK_ManufacturerID PRIMARY KEY (ManufacturerID)

ALTER TABLE Models
ADD CONSTRAINT FK_Models_Manufacturers FOREIGN KEY (ManufacturerID)
REFERENCES Manufacturers(ManufacturerID)

--3. Many-To-Many Relationship

CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(60) NOT NULL
)

CREATE TABLE Exams
(
	ExamID INT PRIMARY KEY,
	[Name] VARCHAR(60) NOT NULL
)

CREATE TABLE StudentsExams
(
	StudentID INT NOT NULL,
	ExamID INT NOT NULL
	CONSTRAINT PK_StudentID_ExamID PRIMARY KEY(StudentID, ExamID),
	CONSTRAINT FK_StudentsExams_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
	CONSTRAINT FK_StudentsExams_ExamID FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
)

INSERT INTO Students
VALUES ('Mila'),
('Toin'),
('Ron')

INSERT INTO Exams
VALUES (101,'SpringMVC'),
(102,'Neo4j'),
(103,'Oracle 11g')

INSERT INTO StudentsExams
VALUES (1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103)

--4. Self-Referencing 

CREATE TABLE Teachers
(
	TeacherID INT PRIMARY KEY,
	[Name] VARCHAR(60) NOT NULL,
	ManagerID INT REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers
VALUES (101,'John',NULL),
(102,'Maya',106),
(103,'Silvia',106),
(104,'Ted',105),
(105,'Mark',101),
(106,'Greta',101)

--5. Online Store Database

CREATE DATABASE OnlineStore
USE OnlineStore

CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY,
	[Name] VARCHAR(32) NOT NULL
)

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY,
	[Name] VARCHAR(60) NOT NULL,
	ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
	CityID INT PRIMARY KEY,
	[Name] VARCHAR(64) NOT NULL
)

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY,
	[Name] VARCHAR(64) NOT NULL,
	Birthday DATETIME2 NOT NULL,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY,
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems
(
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ItemID INT FOREIGN KEY REFERENCES Items(ItemID),
	CONSTRAINT PK_OrderID_ItemID PRIMARY KEY (OrderID,ItemID)
)

--6. University Database

CREATE DATABASE University
USE University

CREATE TABLE Majors
(
	MajorID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(60) NOT NULL
)

CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	StudentNumber INT NOT NULL,
	StudentName VARCHAR(60) NOT NULL,
	MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
	PaymentID INT PRIMARY KEY IDENTITY,
	PaymentDate DATETIME2 NOT NULL,
	PaymentAmount DECIMAL(10,2) NOT NULL,
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
)

CREATE TABLE Subjects
(
	SubjectID INT PRIMARY KEY IDENTITY,
	SubjectName VARCHAR(36) NOT NULL
)

CREATE TABLE Agenda
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID)
	CONSTRAINT PK_Studnet_Subjects PRIMARY KEY (StudentID,SubjectID)
)

--9. Peaks in Rila

SELECT MountainRange,
	   PeakName,
	   Elevation
FROM Peaks
JOIN Mountains ON Peaks.MountainID = Mountains.ID
WHERE MountainID = 17
ORDER BY Elevation DESC