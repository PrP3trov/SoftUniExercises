--1. Employee Address

SELECT TOP 5
	e.EmployeeID,
	e.JobTitle,
	e.AddressID,
	a.AddressText
FROM Employees AS e
JOIN Addresses as a ON e.AddressID = a.AddressID
ORDER BY AddressID

--2. Addresses with Towns

SELECT TOP 50
	e.FirstName,
	e.LastName,
	t.[Name],
	a.AddressText
FROM Employees AS e
JOIN Addresses as a ON e.AddressID = a.AddressID
JOIN Towns as t ON a.TownID = t.TownID
ORDER BY e.FirstName,e.LastName

--3. Sales Employee

SELECT 
	e.EmployeeID,
	e.FirstName,
	e.LastName,
	d.[Name]
FROM Employees AS e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Sales'
ORDER BY e.EmployeeID

--4. Employee Departments

SELECT TOP 5
	e.EmployeeID,
	e.FirstName,
	e.Salary,
	d.[Name]
FROM Employees AS e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY d.DepartmentID

--5. Employees Without Project

SELECT TOP 3 
	EmployeeID,
	FirstName
FROM Employees
WHERE EmployeeID NOT IN 
(
	SELECT DISTINCT EmployeeID FROM EmployeesProjects
)

--6. Employees Hired After

SELECT
	e.FirstName,
	e.LastName,
	e.HireDate,
	d.[Name]
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE 
	e.HireDate > '1.1.1999' AND
	d.[Name] IN ('Sales', 'Finance')
ORDER BY e.HireDate

--7. Employees with Project

SELECT TOP 5
	e.EmployeeID,
	e.FirstName,
	p.[Name]
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '2002.08.13' AND p.EndDate IS NULL
ORDER BY e.EmployeeID

--08. Employee 24

SELECT  
	e.EmployeeID,
	e.FirstName,
CASE 
	WHEN DATEPART(YEAR,p.StartDate) >= 2005 THEN NULL
	ELSE p.[Name]
	END AS [ProjectName]
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE ep.EmployeeID = 24

--9. Employee Manager

SELECT 
	e.EmployeeID,
	e.FirstName,
	m.EmployeeID,
	m.FirstName
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID

--10. Employees Summary

SELECT TOP 50
	e.EmployeeID,
	CONCAT_WS(' ',e.FirstName,e.LastName) AS [EmployeeName],
	CONCAT_WS(' ',m.FirstName,m.LastName) AS [ManagerName],
	d.[Name] AS [DepartmentName]
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID

--11. Min Average Salary

SELECT
	MIN(a.AverageSalary) AS MinAverageSalary
 FROM
 (
	 SELECT 
		e.DepartmentID,
		AVG(e.Salary) AS AverageSalary
	 FROM Employees AS e
	 GROUP BY e.DepartmentID
 ) AS a

--12. Highest Peaks in Bulgaria

SELECT 
	c.CountryCode,
	m.MountainRange,
	p.PeakName,
	p.Elevation
FROM Countries AS c
JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
JOIN Mountains AS m ON mc.MountainId = m.Id
JOIN Peaks AS p ON m.Id = p.MountainId
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC

--13. Count Mountain Ranges

SELECT 
	c.CountryCode,
	COUNT(m.MountainRange)AS [MountainRanges]
FROM Countries AS c
JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
JOIN Mountains AS m ON mc.MountainId = m.Id
WHERE c.CountryCode IN ('BG','RU','US')
GROUP BY c.CountryCode

--14. Countries With or Without Rivers

SELECT TOP 5
	c.CountryName,
	r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
WHERE ContinentCode = 'AF'
ORDER BY c.CountryName

--15. Continents and Currencies

--16. Countries Without Any Mountains

SELECT  COUNT(*) AS [Count]
FROM Countries
WHERE CountryCode NOT IN (SELECT DISTINCT CountryCode FROM MountainsCountries)

--17. Highest Peak and Longest River by Country

SELECT TOP 5
	c.CountryName,
	MAX(p.Elevation) AS [HighestPeakElevation],
	MAX(r.[Length]) AS [LongestRiverLength]
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p ON m.Id = p.MountainId
GROUP BY CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName