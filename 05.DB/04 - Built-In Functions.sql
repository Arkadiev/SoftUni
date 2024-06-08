USE [SoftUni]

GO

-- 1 - Find Names of All Employees by First Name
SELECT [FirstName], [LastName] FROM [Employees] WHERE LEFT([FirstName], 2) = 'Sa'

SELECT [FirstName], [LastName] FROM [Employees] WHERE [FirstName] LIKE 'Sa%'

-- 2 - Find Names of All Employees by Last Name
SELECT [FirstName], [LastName] FROM [Employees] WHERE CHARINDEX('ei', [LastName]) > 0

SELECT [FirstName], [LastName] FROM [Employees] WHERE [LastName] LIKE '%ei%'

-- 3 - Find First Names of All Employees
SELECT [FirstName] FROM [Employees] WHERE [DepartmentID] IN (3, 10) AND YEAR([HireDate]) BETWEEN 1995 AND 2005

-- 4 - Find All Employees Except Engineers
SELECT [FirstName], [LastName] FROM [Employees] WHERE CHARINDEX('engineer', [JobTitle]) = 0

SELECT [FirstName], [LastName] FROM [Employees] WHERE [JobTitle] NOT LIKE '%engineer%'

-- 5 - Find Towns with Name Length
SELECT [Name] FROM [Towns] WHERE LEN([Name]) IN (5, 6) ORDER BY [Name]

-- 6 - Find Towns Starting With
SELECT * FROM [Towns] WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E') ORDER BY [Name]

SELECT * FROM [Towns] WHERE [Name] LIKE '[MKBE]%' ORDER BY [Name]

-- 7 - Find Towns Not Starting With
SELECT * FROM [Towns] WHERE LEFT([Name], 1) NOT IN ('R', 'B', 'D') ORDER BY [Name]

SELECT * FROM [Towns] WHERE [Name] NOT LIKE '[RBD]%' ORDER BY [Name]

-- 8 - Create View Employees Hired After 2000 Year
CREATE VIEW [V_EmployeesHiredAfter2000] AS (SELECT [FirstName], [LastName] FROM [Employees] WHERE YEAR([HireDate]) > 2000)

-- 9 - Length of Last Name
SELECT [FirstName], [LastName] FROM [Employees] WHERE LEN([LastName]) = 5

-- 10 - Rank Employees By Salary
SELECT [EmployeeID], [FirstName], [LastName], [Salary],
DENSE_RANK() OVER(PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
FROM [Employees] WHERE [Salary] BETWEEN 10000 AND 50000 ORDER BY [Salary] DESC

-- 11 - Find All Employees with Rank 2
SELECT * FROM
(
SELECT [EmployeeID], [FirstName], [LastName], [Salary],
DENSE_RANK() OVER(PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
FROM [Employees] WHERE [Salary] BETWEEN 10000 AND 50000
)
AS [RankingSubquery] WHERE [Rank] = 2 ORDER BY [Salary] DESC

-- 12 - Countries Holding 'A' 3 or More Times
USE [Geography]

GO

SELECT [CountryName] AS [Country Name], [ISOCode] AS [ISO Code] FROM [Countries]
WHERE LOWER([CountryName]) LIKE '%a%a%a%' ORDER BY [ISOCode]

SELECT [CountryName] AS [Country Name], [ISOCode] AS [ISO Code] FROM [Countries]
WHERE LEN([CountryName]) - LEN(REPLACE(LOWER([CountryName]), 'a', '')) >= 3 ORDER BY [ISOCode]

-- 13 - Mix of Peak and River Names
SELECT [p].[PeakName], [r].[RiverName], LOWER(CONCAT(SUBSTRING([p].[PeakName], 1, LEN([p].[PeakName]) - 1), [r].[RiverName])) AS [Mix]
FROM [Peaks] AS [p], [Rivers] AS [r] WHERE RIGHT(LOWER([p].[PeakName]), 1) = LEFT(LOWER([r].[RiverName]), 1) ORDER BY [Mix]

-- 14 - Games From 2011 and 2012 Year
USE [Diablo]

GO

SELECT TOP(50) [Name], CONVERT(CHAR(10), [Start], 126) AS [Start] FROM [Games] WHERE YEAR([Start]) BETWEEN 2011 AND 2012 ORDER BY [Start], [Name]

-- 15 - User Email Providers
SELECT [Username], SUBSTRING([Email], CHARINDEX('@', [Email]) + 1, LEN([Email]) - CHARINDEX('@', [Email])) AS [Email Provider]
FROM [Users] ORDER BY [Email Provider], [Username]

-- 16 - Get Users with IP Address Like Pattern
SELECT [Username], [IpAddress] AS [IP Address] FROM [Users] WHERE [IpAddress] LIKE '___.1_%._%.___' ORDER BY [Username]

-- 17 - Show All Games with Duration & Part of the Day
SELECT [Name] AS [Game],
	CASE
		WHEN DATEPART(HOUR, [Start]) >= 0 AND DATEPART(HOUR, [Start]) < 12 THEN 'Morning'
		WHEN DATEPART(HOUR, [Start]) >= 12 AND DATEPART(HOUR, [Start]) < 18 THEN 'Afternoon'
		ELSE 'Evening'
	END
	AS [Part of the Day],
	CASE
		WHEN [Duration] <= 3 THEN 'Extra Short'
		WHEN [Duration] BETWEEN 4 AND 6 THEN 'Short'
		WHEN [Duration] > 6 THEN 'Long'
		ELSE 'Extra Long'
	END
	AS [Duration]
FROM [Games] ORDER BY [Game], [Duration]

-- 18 - Orders Table
SELECT [ProductName], [OrderDate], DATEADD(DAY, 3, [OrderDate]) AS [Pay Due], DATEADD(MONTH, 1, [OrderDate]) AS [Deliver Due] FROM [Orders]