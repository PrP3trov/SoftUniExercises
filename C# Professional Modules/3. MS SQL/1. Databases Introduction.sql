CREATE TABLE Towns
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(50)
)

--03. Alter Minions Table
ALTER TABLE Minions
ADD TownId INT

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)

--04. Insert Records In Both Tables
INSERT INTO Towns
VALUES(1,'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO Minions
VALUES (1, 'Kevin',22,1),
 (2, 'Bob',15,3),
 (3, 'Steward',NULL,2)

--05. Truncate Table Minions
 TRUNCATE TABLE Minions 
 
--06. Drop All Tables
 DROP TABLE Minions 
 DROP TABLE Towns

 --07. Create Table People
 CREATE TABLE People
 (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX),
	Height DECIMAL(3,2),
	[Weight] DECIMAL (5,2),
	Gender CHAR(1) NOT NULL,
		CHECK (Gender in('m','f')),
	Birthdate DATETIME2 NOT NULL,
	Biography VARCHAR(MAX)
 )

 INSERT INTO People ([Name], Gender, Birthdate)
				VALUES ('Ivan','m','1998-08-08'),
				 ('Stoqn','m','1995-03-26'),
				 ('Mariq','f','1999-08-05'),
				 ('Simona','f','1992-07-24'),
			     ('Aleksander','m','1998-07-12')


--08. Create Table Users
 CREATE TABLE Users
 (
	Id BIGINT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL,
	[Passwords] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX),
	LastLoginTime DATETIME2,
	IsDeleted BIT
 )
 INSERT INTO Users (Username,Passwords)
				VALUES ('Hacker123','pancho17'),
				('SexaIgruda','12364'),
				('mariajn59','851486'),
				('sofia17','126456274'),
				('azsumqk','471847')

--9. Change Primary Key			
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC072ED9FC72

ALTER TABLE Users
ADD CONSTRAINT PK_UsersTable PRIMARY KEY(Id,Username)

--10.Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT CHK_PasswrodIsAtLeastFiveSymbols
	CHECK(LEN(Passwords) >= 5)

 --11. Set Default Value of a Field
 ALTER TABLE Users
 ADD CONSTRAINT DF_LastLoginTime

 --12.Set Unique Field
ALTER TABLE Users
DROP CONSTRAINT PK_UsersTable

ALTER TABLE Users
ADD CONSTRAINT PK_UsersTable PRIMARY KEY(Id)

--13.Movies Database
CREATE DATABASE Movies
USE Movies

CREATE TABLE Directors
(
	Id INT PRIMARY KEY,
	DirectroName VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX)

)

CREATE TABLE Genres
(
	Id INT PRIMARY KEY,
	GenreName VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY,
	CategoryName VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Movies
(
	Id INT PRIMARY KEY,
	Tilte VARCHAR(MAX) NOT NULL,
	DirectorId INT NOT NULL,
	CopyrightYear VARCHAR(MAX),
	[Length] DECIMAL NOT NULL,
	GenreId INT NOT NULL,
	CategoryId INT NOT NULL,
	Rating VARCHAR(MAX) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Directors (Id,DirectroName)
VALUES (1,'Ivan'),
(2,'Qsakazal'),
(3,'Petar'),
(4,'Simeon'),
(5,'Kaloqn')

INSERT INTO Genres (Id,GenreName)
VALUES (1,'Komediq'),
(2,'Drama'),
(3,'Ekshun'),
(4,'Strashen'),
(5,'Epichen')

INSERT INTO Categories (Id,CategoryName)
VALUES (1,'Blqt'),
(2,'Nz'),
(3,'Kvoekatoegoriq'),
(4,'ok'),
(5,'TakjeoN')

INSERT INTO Movies (Id,Tilte,DirectorId,Length,GenreId,CategoryId,Rating)
VALUES(1,'Brachna nosht',2,60,1,3,4),
(2,'Sex nosht',3,60,1,2,3),
(3,'Nz nosht',4,20,2,1,5),
(4,'Az nosht',5,35,4,5,2),
(5,'Pedal nosht',1,40,5,2,1)

-- 14. Car Rental Database (DOVURSHETE SAMI)
CREATE DATABASE CarRental 

CREATE TABLE Categories
(
	Id INT PRIMARY KEY,
	CategoryName VARCHAR(60) NOT NULL,
	DailyRate DECIMAL(5,1),
	WeeklyRate DECIMAL(5,1),
	MonthlyRate DECIMAL(5,1),
	WeekendRate DECIMAL(5,1) 
)

CREATE TABLE Cars
(
	Id INT PRIMARY KEY,
	PlateNumber VARCHAR(60) NOT NULL,
	Manufacturer DECIMAL(5,1) NOT NULL,
	Model VARCHAR(60) NOT NULL,
	CarYears INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors INT NOT NULL,
	Picture VARBINARY(MAX),
	Condition VARCHAR(MAX),
	Available BIT NOT NULL
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY,
	FristName VARCHAR(MAX) NOT NULL,
	LastName VARCHAR(MAX) NOT NULL,
	Title VARCHAR(MAX),
	Notes VARCHAR(MAX)
)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY,
	DriverLicenceNumber INT NOT NULL,
	FullName VARCHAR(MAX) NOT NULL,
	Address VARCHAR(MAX) NOT NULL,
	City VARCHAR(MAX) NOT NULL,
	ZIPCode INT NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE RentalOrders 
(
	Id INT PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	CarId INT FOREIGN KEY REFERENCES Cars(Id),
	TankLevel DECIMAL(5,1),
	KilometrageStart DECIMAL(5,1),
	KilometrageEnd DECIMAL(5,1),
	TotalKilometrage DECIMAL(5,1),
	StartDate DATETIME2,
	EndDate DATETIME2,
	TotalDays INT,
	RateApplied DECIMAL(5,1),
	TaxRate INT,
	OrderStatus VARCHAR(60),
	Notes VARCHAR(MAX)
)

INSERT INTO Categories
VALUES (1,'SUV',5.1,4.2,5.1,6.0),
	(2,'Kola',5.2,2.2,4.5,2.4),
	(3,'Kamion',2.3,4.2,5.2,1.5)

INSERT INTO Cars
VALUES (1,'5453','IvanCars','Pedal','ibiza',2006,1,4,1),
	(2,'5453','SashkoCars','Pisnami','e32',2006,3,4,0),
	(3,'5453','BMW','Nz','e46',2004,2,4,1)

--15. Hotel Database
CREATE DATABASE Hotel

CREATE TABLE Employees 
(
    Id INT PRIMARY KEY IDENTITY, 
	FirstName VARCHAR(60) NOT NULL, 
	LastName VARCHAR(60) NOT NULL, 
	Title VARCHAR(60), 
	Notes VARCHAR(MAX)
)

CREATE TABLE Customers 
(
	AccountNumber INT PRIMARY KEY IDENTITY, 
	FirstName VARCHAR(60) NOT NULL, 
	LastName VARCHAR(60) NOT NULL, 
	PhoneNumber INT, 
	EmergencyName VARCHAR(60) NOT NULL, 
	EmergencyNumber INT, 
	Notes VARCHAR(MAX) NOT NULL
)

CREATE TABLE RoomStatus 
(
	RoomStatus VARCHAR(60) PRIMARY KEY, 
	Notes VARCHAR(MAX)
)

CREATE TABLE RoomTypes
(
	RoomType VARCHAR(60) PRIMARY KEY,
	Notes VARCHAR(60)
)

CREATE TABLE BedTypes
(
	BedType VARCHAR(60) PRIMARY KEY,
	Notes VARCHAR(60)
)

CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY,
	RoomType VARCHAR(60) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType VARCHAR(60) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate INT NOT NULL,
	RoomStatus VARCHAR(60) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes VARCHAR(MAX)
)

CREATE TABLE Payments 
(
	Id INT PRIMARY KEY, 
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id), 
	PaymentDate DATETIME2, 
	AccountNumber INT, 
	FirstDateOccupied DATETIME2, 
	LastDateOccupied DATETIME2, 
	TotalDays INT, 
	AmountCharged DECIMAL (10,2), 
	TaxRate INT, 
	TaxAmount DECIMAL (10,2), 
	PaymentTotal DECIMAL (10,2), 
	Notes VARCHAR(MAX)
)

CREATE TABLE Occupancies 
(
	Id INT PRIMARY KEY, 
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATETIME2, 
	AccountNumber INT, 
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber), 
	RateApplied INT, 
	PhoneCharge INT, 
	Notes VARCHAR(MAX)
)

INSERT INTO Employees (FirstName,LastName)
VALUES ('Ivan', 'Ivanov'),
		('Petar', 'Petrov'),
		('Stokata', 'Narkomana')

INSERT INTO Customers (FirstName,LastName,EmergencyName,Notes)
VALUES ('Patkan','Sagapo','Kure','qk pich'),
		('Momchil','Sagapo','Kure2','ne sta pich'),
		('Ivan','Sagapo','Kure3',' dobur')

INSERT INTO RoomStatus (RoomStatus)
VALUES('Good'),
('Fair'),
('Perfect')

INSERT INTO RoomTypes(RoomType)
VALUES ('Single room'),
('Standard double room'),
('Standard twin room.')

INSERT INTO BedTypes(BedType)
VALUES ('Double'),
('Large Double'),
('Single')

INSERT INTO Rooms(RoomNumber,RoomType,BedType,Rate,RoomStatus)
VALUES(245,'Single room','Double',4,'Good'),
(345,'Single room','Double',4,'Good'),
(485,'Single room','Double',4,'Good')

INSERT INTO Payments(Id,EmployeeId)
VALUES(1,1),
(2,2),
(3,3)

INSERT INTO Occupancies(Id,EmployeeId,RoomNumber)
VALUES (1,1,245),
(2,3,345),
(3,2,485)

--16. Create SoftUni Database

CREATE TABLE Towns
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(60)
)

CREATE TABLE Addresses 
(
	Id INT PRIMARY KEY IDENTITY,
	AddressText VARCHAR(MAX),
	TownId INT FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(60)
)

CREATE TABLE Employees 
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(60),
	MiddleName VARCHAR(60),
	LastName VARCHAR(60),
	JobTiltle VARCHAR(60),
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
	HireDate DATETIME2,
	Salary DECIMAL(10,2),
	AddressId INT FOREIGN KEY REFERENCES Addresses (Id)
)


--18. Basic Insert

INSERT INTO Towns
VALUES ('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

INSERT INTO Departments
VALUES ('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

INSERT INTO Employees 
(FirstName, MiddleName, LastName, JobTiltle,DepartmentId, HireDate, Salary)
			VALUES ('Ivan','Ivanov','Ivanov','.NET Developer',1,'2013-02-01',3500),
						('Petar','Petrov','Petrov','Senior Engineer',2,'2004-02-01',4000),
						('Maria','Petrova','Ivanova','Inetern',3,'2016-08-28',525.25),
						('Georgi','Terizev','Ivanov','CEO',4,'2007-12-09',3000),
						('Petar','Pan','Pan','Intern',5,'2016-08-28',599.88


--19.Basic Select All Fields
SELECT * FROM Towns
SELECT * FROM Departments
SELECT * FROM Employees

--20.Basic Select All Fields and Order Them
SELECT *
FROM Towns
ORDER BY [Name] ASC

SELECT *
FROM Departments
ORDER BY [Name] ASC

SELECT *
FROM Employees
ORDER BY Salary DESC

--21.Basic Select Some Fields
SELECT [Name]
FROM Towns
ORDER BY [Name] ASC

SELECT [Name]
FROM Departments
ORDER BY [Name] ASC

SELECT FirstName,LastName,JobTitle,Salary
FROM Employees
ORDER BY Salary DESC

--22.Increase Employees Salary
UPDATE Employees
SET Salary = Salary *1.1
SELECT Salary FROM Employees


--23. Decrease Tax Rate
UPDATE Payments
SET TaxRate = TaxRate * 0.97
SELECT TaxRate FROM Payments

--24. Delete All Records
TRUNCATE TABLE Occupancies
