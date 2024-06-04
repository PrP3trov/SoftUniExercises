--1. Employees with Salary Above 35000
CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000 
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary >35000
END

--2. Employees with Salary Above Number
CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber @salary DECIMAL(18,4)
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary >= @salary
END

--3. Town Names Starting With
CREATE PROCEDURE usp_GetTownsStartingWith @input VARCHAR(MAX)
AS
BEGIN
		SELECT [Name] AS [Town]
		FROM Towns
		WHERE [Name] LIKE CONCAT(@input,'%')
END

--4. Employees from Town
CREATE PROCEDURE usp_GetEmployeesFromTown @town VARCHAR(MAX)
AS
BEGIN
		SELECT FirstName,LastName
		FROM Employees AS e
		JOIN Addresses AS a ON e.AddressID = a.AddressID
		JOIN Towns AS t ON a.TownID = t.TownID
		WHERE t.[Name] = @town
END

--5. Salary Level Function
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS NVARCHAR(10)
AS
BEGIN
		DECLARE @salaryLevel VARCHAR(10)
		IF (@Salary < 30000)
		 SET @salaryLevel =	'Low'
		ELSE IF(@Salary <= 50000)
		 SET @salaryLevel = 'Average'
		ELSE
		 SET @salaryLevel = 'High'
		RETURN @salaryLevel
END;

--6. Employees by Salary Level
CREATE PROCEDURE usp_EmployeesBySalaryLevel @salaryLevel VARCHAR(10)
AS
BEGIN
		SELECT FirstName, LastName
		FROM Employees
		WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel
END

--7. Define Function
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	DECLARE @WordLength INT = LEN(@word)
	DECLARE @Iterator INT = 1

	WHILE(@Iterator <= @WordLength)
		BEGIN
			IF(CHARINDEX(SUBSTRING(@word,@Iterator,1), @setOFLetters) = 0)
				RETURN 0
			SET @Iterator +=1
		END
	RETURN 1
END

--8. Delete Employees and Departments
CREATE PROCEDURE usp_DeleteEmployeesFromDepartment (@departmentId INT) 
AS
BEGIN
	DECLARE @deletedEmployees TABLE(Id INT)
	INSERT INTO @deletedEmployees
		SELECT EmployeeID
		FROM Employees
		WHERE DepartmentID = @departmentId
	
	ALTER TABLE Departments
	ALTER COLUMN ManagerID INT NULL

	UPDATE Departments
	SET ManagerID = NULL
	WHERE ManagerID IN (SELECT EmployeeID from Employees WHERE DepartmentID = @departmentId)

	DELETE FROM EmployeesProjects
	WHERE EmployeeID IN (SELECT EmployeeID from Employees WHERE DepartmentID = @departmentId)

	UPDATE Employees
	SET ManagerID = NULL
	WHERE EmployeeID IN (SELECT EmployeeID from Employees WHERE DepartmentID = @departmentId)

	DELETE FROM Employees
	WHERE DepartmentID = @departmentId

	DELETE FROM Departments
	WHERE DepartmentID = @departmentId

	SELECT COUNT(*) FROM Employees
	WHERE DepartmentID = @departmentId
END

--9. Find Full Name
CREATE PROCEDURE usp_GetHoldersFullName
AS
BEGIN
	SELECT CONCAT_WS(' ',FirstName,LastName) AS [Full Name]
	FROM AccountHolders
END

--10. People with Balance Higher Than
CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan  (@amount money)
AS
BEGIN
	SELECT FirstName, LastName
	FROM  AccountHolders AS ah
	JOIN Accounts AS a ON ah.Id = a.AccountHolderId
	GROUP BY FirstName,LastName
	HAVING SUM(a.Balance) > @amount
	ORDER BY FirstName, LastName
END

--11. Future Value Function
CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(10,4), @yearlyInterestRate FLOAT, @years INT)
RETURNS DECIMAL(10,4)
AS
BEGIN
	RETURN @sum * (POWER((1+ @yearlyInterestRate),@years))
END

--12. Calculating Interest
CREATE PROCEDURE usp_CalculateFutureValueForAccount(@accountID INT, @interestRate FLOAT)
AS
BEGIN
	DECLARE @term INT = 5

	SELECT 
		a.Id AS [Account Id],
		FirstName,
		LastName,
		Balance AS [Current Balacne],
		dbo.ufn_CalculateFutureValue(Balance,@interestRate,@term) AS [Balance in 5 years]
	FROM AccountHolders AS ah
	JOIN Accounts AS a ON ah.Id = a.AccountHolderId
	WHERE a.Id = @accountID
END

--13. *Scalar Function: Cash in User Games Odd Rows
CREATE FUNCTION ufn_CashInUsersGames (@gameName VARCHAR(MAX))
RETURNS TABLE
AS
RETURN(
	SELECT SUM(Cash) AS [SumCash]
	FROM 
	(SELECT
			g.Id,
			g.[Name],
			ug.Cash,
			ROW_NUMBER() OVER (ORDER BY ug.Cash DESC) AS RowRank
		FROM Games AS g
		JOIN UsersGames AS ug ON g.Id = ug.GameId
		WHERE g.[Name] = @gameName) as Query
	WHERE RowRank % 2 = 1)
