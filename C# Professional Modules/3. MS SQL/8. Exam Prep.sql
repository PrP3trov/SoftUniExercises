--1 DDl
CREATE TABLE Passengers
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(80) NOT NULL
)

CREATE TABLE Towns
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL
)

CREATE TABLE RailwayStations
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE Trains
(
	Id INT PRIMARY KEY IDENTITY,
	HourOfDeparture VARCHAR(5) NOT NULL,
	HourOfArrival VARCHAR(5) NOT NULL,
	DepartureTownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id),
	ArrivalTownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE TrainsRailwayStations
(
	TrainId INT NOT NULL FOREIGN KEY REFERENCES Trains(Id),
	RailwayStationId INT NOT NULL FOREIGN KEY REFERENCES RailwayStations(Id),
	PRIMARY KEY (TrainId,RailwayStationId)
)

CREATE TABLE MaintenanceRecords
(
	Id INT PRIMARY KEY IDENTITY,
	DateOfMaintenance DATE NOT NULL,
	Details VARCHAR(2000) NOT NULL,
	TrainId INT FOREIGN KEY REFERENCES Trains(Id)
)

CREATE TABLE Tickets
(
	Id INT PRIMARY KEY IDENTITY,
	Price Decimal(10,2) NOT NULL,
	DateOfDeparture DATE NOT NULL,
	DateOfArrival DATE NOT NULL,
	TrainId INT FOREIGN KEY REFERENCES Trains(Id),
	PassengerId INT FOREIGN KEY REFERENCES Passengers(Id)
)

--2. Insert
INSERT INTO Trains(HourOfDeparture, HourOfArrival, DepartureTownId, ArrivalTownId)
VALUES ('07:00', '19:00', 1, 3),
('08:30', '20:30', 5, 6),
('09:00', '21:00', 4, 8),
('06:45', '03:55', 27, 7),
('10:15', '12:15', 15, 5)

INSERT INTO TrainsRailwayStations(TrainId,RailwayStationId)
VALUES (36,1),
(36,4),
(36,31),
(36,57),
(36,7),
(36,13),
(36,54),
(37,60),
(37,16),
(38,10),
(38,50),
(38,52),
(38,22),
(39,68),
(39,3),
(39,31),
(39,19),
(40,41),
(40,7),
(40,52),
(40,13)

INSERT INTO Tickets(Price,DateOfDeparture,DateOfArrival,TrainId,PassengerId)
VALUES (90.00,	'2023-12-01',	'2023-12-01',	36,	1),
(115.00	,'2023-08-02','2023-08-02',	37,	2),
(160.00	,'2023-08-03','2023-08-03',	38,	3),
(255.00	,'2023-09-01','2023-09-02',	39,	21),
(95.00	,'2023-09-02','2023-09-03',	40,	22)

--3. Update
UPDATE Tickets
SET DateOfDeparture = DATEADD(DAY, 7, DateOfDeparture),
DateOfArrival = DATEADD(DAY, 7, DateOfArrival)
WHERE DateOfDeparture > '2023-10-31'

--4. Delete
DELETE
FROM TrainsRailwayStations
WHERE TrainId = 7

DELETE
FROM MaintenanceRecords
WHERE TrainId = 7

DELETE
FROM Tickets
WHERE TrainId = 7

DELETE
FROM Trains
WHERE DepartureTownId = 3

--5. Tickets by Price and Date of Departure
SELECT
	DateOfDeparture AS DateOfDeparture,
	Price AS TicketPrice
FROM Tickets
ORDER BY Price, DateOfDeparture DESC

--6. Passengers with their Tickets
SELECT
	p.[Name] AS PassengerName,
	t.Price AS TicketPrice,
	t.DateOfDeparture,
	t.TrainId
FROM Tickets AS t
JOIN Passengers AS p ON t.PassengerId = p.Id
ORDER BY t.Price DESC, p.[Name]

--7. Railway Stations without Passing Trains
SELECT 
	t.[Name] AS Town,
	rs.[Name] AS RailwayStation
FROM RailwayStations AS rs
JOIN Towns AS t ON rs.TownId = t.Id
WHERE rs.Id NOT IN
(SELECT RailwayStationId FROM TrainsRailwayStations)
ORDER BY t.[Name], rs.[Name]

--8. First 3 Trains Between 8:00 and 8:59
SELECT TOP 3
	t.Id AS TrainId,
	t.HourOfDeparture,
	tc.Price AS TicketPrice,
	tw.[Name] AS Destination
FROM Trains AS t
JOIN Tickets AS tc ON t.ID = tc.TrainId
JOIN Towns as tw ON t.ArrivalTownId = tw.Id
WHERE t.HourOfDeparture LIKE '08:%'
AND tc.Price > 50.00
ORDER BY tc.Price

--9. Count of Passengers Paid More Than Average With Arrival Towns
SELECT
	tw.[Name] AS TownName,
	COUNT(p.Id) AS PassengersCount
FROM Trains AS t
JOIN Tickets AS tk ON t.Id = tk.TrainId
JOIN Passengers AS p ON tk.PassengerId = p.Id
JOIN Towns AS tw ON t.ArrivalTownId = tw.Id
WHERE tk.Price > 76.99
GROUP BY tw.[Name]
ORDER BY tw.[Name]

--10. Maintenance Inspection with Town
SELECT
	t.Id AS TrainID,
	tw.[Name] AS DepartureTown,
	Details AS Details
FROM Trains AS t
JOIN Towns AS tw ON t.DepartureTownId = tw.Id
JOIN MaintenanceRecords AS m ON t.Id = m.TrainId
WHERE m.Details LIKE '%inspection%'
ORDER BY t.Id

--11. Towns with Trains
CREATE FUNCTION udf_TownsWithTrains(@name VARCHAR(MAX))
RETURNS INT
AS
BEGIN
	DECLARE @result INT

	SELECT @result = 
		COUNT(t.id)
	FROM Trains AS t
	JOIN Towns AS tw ON t.ArrivalTownId = tw.Id
	JOIN Towns AS td ON t.DepartureTownId = td.Id
	WHERE tw.[Name] = @name OR td.[Name] = @name

	RETURN @result
END

SELECT dbo.udf_TownsWithTrains('Paris')

--12. Search Passenger Travelling to Specific Town
CREATE PROCEDURE usp_SearchByTown(@townName VARCHAR(MAX))
AS
BEGIN
	SELECT
		p.[Name] AS PassengerName,
		tk.DateOfDeparture,
		t.HourOfDeparture
	FROM Trains AS t
		JOIN Tickets AS tk ON t.Id = tk.TrainId
		JOIN Passengers AS p ON tk.PassengerId = p.Id
		JOIN Towns AS tw ON t.ArrivalTownId = tw.Id
	WHERE tw.[Name] = @townName
	ORDER BY tk.DateOfDeparture DESC, p.[Name]
END

EXEC usp_SearchByTown 'Berlin'