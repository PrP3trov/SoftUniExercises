--1. Find Names of All Employees by First Name

SELECT FirstName, LastName
FROM Employees
WHERE FirstName LIKE 'Sa%'

--2.Find Names of All Employees by Last Name 

SELECT FirstName,LastName
FROM Employees
WHERE LastName LIKE '%ei%'

--3. Find First Names of All Employees

SELECT FirstName
FROM Employees
WHERE DepartmentID = 3 OR DepartmentID = 10 
AND DATEPART(YEAR,HireDate) BETWEEN 1995 AND 2005

--4. Find All Employees Except Engineers

SELECT FirstName,LastName
FROM Employees
WHERE NOT JobTitle LIKE '%engineer%'

--5. Find Towns with Name Length

SELECT [Name]
FROM Towns
WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
ORDER BY [Name]

--6. Find Towns Starting With

SELECT *
FROM Towns
WHERE [Name] LIKE '[mkbe]%'
ORDER BY [Name]

--7. Find Towns Not Starting With

SELECT *
FROM Towns
WHERE NOT [Name] LIKE '[rbd]%'
ORDER BY [Name]

--8. Create View Employees Hired After 2000 Year

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName,LastName
FROM Employees
WHERE DATEPART(YEAR,Hiredate) > 2000

--9. Length of Last Name

SELECT FirstName,LastName
FROM Employees
WHERE LEN(LastName) = 5

--10. Rank Employees by Salary

SELECT EmployeeID,FirstName,LastName,Salary,
	DENSE_RANK() OVER
	(PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC

--11. Find All Employees with Rank 2

WITH CTE_RankedEmployees AS
(
	SELECT EmployeeID,FirstName,LastName,Salary,
		DENSE_RANK() OVER
		(PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
	FROM Employees
	WHERE Salary BETWEEN 10000 AND 50000
)
SELECT *
FROM CTE_RankedEmployees
WHERE [Rank] = 2
ORDER BY Salary DESC

--12. Countries Holding 'A' 3 or More Times

SELECT CountryName,IsoCode
FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode

--13. Mix of Peak and River Names

SELECT PeakName,RiverName,
LOWER(CONCAT(SUBSTRING(PeakName,1,LEN(PeakName)-1),RiverName)) AS Mix
FROM Peaks,Rivers
WHERE RIGHT(PeakName,1) = LEFT(RiverName,1)
ORDER BY Mix

--14. Games from 2011 and 2012 Year

SELECT TOP 50 [Name], FORMAT([Start],'yyyy-MM-dd') AS [Start]
FROM Games
WHERE DATEPART(YEAR,[Start]) = 2011 OR DATEPART(YEAR,Start) = 2012
ORDER BY [Start],[Name]

--15. User Email Providers

SELECT Username,SUBSTRING(Email,CHARINDEX('@',Email) + 1,LEN(Email)) AS [Email Provider]
FROM Users
Order by Email, Username

--16. Get Users with IP Address Like Pattern

SELECT Username,IpAddress
FROM Users
WHERE IpAddress LIKE '___.1_%._%.___'
ORDER BY Username

--17. Show All Games with Duration and Part of the Day

SELECT [Name],[Part of the Day] =
	CASE
		WHEN DATEPART(HOUR,[Start]) < 12 THEN 'Morning'
		WHEN DATEPART(HOUR,[Start]) < 18 THEN 'Afternoon'
		ELSE 'Evening'
	END, 
	[Duration] = 
	CASE
		WHEN [Duration] <= 3 THEN 'Extra Short'
		WHEN [Duration] <= 6 THEN 'Short'
		WHEN [Duration] > 6 THEN 'Long'
		ELSE 'Extra Long'
	END
FROM Games
ORDER BY [Name],Duration,[Part of the Day]

--18. Orders Table

SELECT ProductName,OrderDate,
	DATEADD(DAY,3,OrderDate) AS [Pay Due],
	DATEADD(MONTH,1,OrderDate) AS [Delivery Due]
FROM Orders