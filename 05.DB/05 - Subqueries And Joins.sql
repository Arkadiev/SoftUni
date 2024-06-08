USE [SoftUni]

GO

-- 1 - Employee Address
SELECT TOP(5) [e].[EmployeeID], [e].[JobTitle], [e].[AddressID], [a].[AddressText] FROM [Employees] AS [e]
LEFT JOIN [Addresses] AS [a] ON [e].[AddressID] = [a].[AddressID] ORDER BY [e].[AddressID]

-- 2 - Addresses with Towns
SELECT TOP(50) [e].[FirstName], [e].[LastName], [t].[Name] AS [Town], [a].[AddressText] FROM [Employees] AS [e]
LEFT JOIN [Addresses] AS [a] ON [e].[AddressID] = [a].[AddressID]
LEFT JOIN [Towns] AS [t] ON [a].[TownID] = [t].[TownID]
ORDER BY [e].[FirstName], [e].[LastName]

-- 3 - Sales Employees
SELECT [e].[EmployeeID], [e].[FirstName], [e].[LastName], [d].[Name] FROM [Employees] AS [e]
LEFT JOIN [Departments] AS [d] ON [e].[DepartmentID] = [d].[DepartmentID]
WHERE [d].[Name] = 'Sales' ORDER BY [e].[EmployeeID]

-- 4 - Employee Departments
SELECT TOP(5) [e].[EmployeeID], [e].[FirstName], [e].[Salary], [d].[Name] FROM [Employees] AS [e]
LEFT JOIN [Departments] AS [d] ON [e].[DepartmentID] = [d].[DepartmentID]
WHERE [e].[Salary] > 15000 ORDER BY [e].[DepartmentID]

-- 5 - Employees Without Projects
SELECT TOP(3) [e].[EmployeeID], [e].[FirstName] FROM [Employees] AS [e]
LEFT JOIN [EmployeesProjects] AS [ep] ON [e].[EmployeeID] = [ep].[EmployeeID]
WHERE [ep].[ProjectID] IS NULL ORDER BY [e].[EmployeeID]

-- 6 - Employees Hired After
SELECT [e].[FirstName], [e].[LastName], [e].[HireDate], [d].[Name] AS [DeptName] FROM [Employees] AS [e]
LEFT JOIN [Departments] AS [d] ON [e].[DepartmentID] = [d].[DepartmentID]
WHERE [d].[Name] IN ('Sales', 'Finance') AND YEAR([e].[HireDate]) > 1999 ORDER BY [e].[HireDate]

-- 7 - Employees With Project
SELECT TOP(5) [e].[EmployeeID], [e].[FirstName], [p].[Name] AS [ProjectName] FROM [Employees] AS [e]
INNER JOIN [EmployeesProjects] AS [ep] ON [e].[EmployeeID] = [ep].[EmployeeID]
INNER JOIN [Projects] AS [p] ON [ep].[ProjectID] = [p].[ProjectID]
WHERE [p].[StartDate] > '08-13-2002' AND [p].[EndDate] IS NULL ORDER BY [e].[EmployeeID]

-- 8 - Employee 24
SELECT [e].[EmployeeID], [e].[FirstName],
[ProjectName] = CASE WHEN YEAR([p].[StartDate]) > 2004 THEN NULL ELSE [p].[Name] END
FROM [Employees] AS [e]
INNER JOIN [EmployeesProjects] AS [ep] ON [e].[EmployeeID] = [ep].[EmployeeID]
INNER JOIN [Projects] AS [p] ON [ep].[ProjectID] = [p].[ProjectID]
WHERE [e].[EmployeeID] = 24

-- 9 - Employee Manager
SELECT [e].[EmployeeID], [e].[FirstName], [e].[ManagerID], [m].[FirstName] AS [ManagerName] FROM [Employees] AS [e]
INNER JOIN [Employees] AS [m] ON [e].[ManagerID] = [m].[EmployeeID]
WHERE [e].[ManagerID] IN (3, 7) ORDER BY [e].[EmployeeID]

-- 10 - Employees Summary
SELECT TOP(50) [e].[EmployeeID], [e].[FirstName] + ' ' + [e].[LastName] AS [EmployeeName],
[m].[FirstName] + ' ' + [m].[LastName] AS [ManagerName], [d].[Name] AS [DepartmentName]
FROM [Employees] AS [e]
INNER JOIN [Employees] AS [m] ON [e].[ManagerID] = [m].[EmployeeID]
INNER JOIN [Departments] AS [d] ON [e].[DepartmentID] = [d].[DepartmentID]
ORDER BY [e].[EmployeeID]

-- 11 - Min Average Salary
SELECT TOP(1) AVG([Salary]) AS [MinAverageSalary] FROM [Employees] GROUP BY [DepartmentID] ORDER BY [MinAverageSalary]

-- 12 - Highest Peaks in Bulgaria
USE [Geography]

GO

SELECT [mc].[CountryCode], [m].[MountainRange], [p].[PeakName], [p].[Elevation] FROM [MountainsCountries] AS [mc]
INNER JOIN [Countries] AS [c] ON [mc].[CountryCode] = [c].[CountryCode]
INNER JOIN [Mountains] AS [m] ON [mc].[MountainID] = [m].[Id]
INNER JOIN [Peaks] AS [p] ON [p].[MountainId] = [m].[Id]
WHERE [c].[CountryName] = 'Bulgaria' AND [p].[Elevation] > 2835
ORDER BY [p].[Elevation] DESC

-- 13 - Count Mountain Ranges
SELECT [CountryCode], COUNT([MountainId]) AS [MountainRanges] FROM [MountainsCountries]
WHERE [CountryCode] IN (SELECT [CountryCode] FROM [Countries] WHERE [CountryName] IN ('United States', 'Russia', 'Bulgaria'))
GROUP BY [CountryCode]

-- 14 - Countries With or Without Rivers
SELECT TOP(5) [c].[CountryName], [r].[RiverName] FROM [Countries] AS [c]
LEFT JOIN [CountriesRivers] AS [cr] ON [c].[CountryCode] = [cr].[CountryCode]
LEFT JOIN [Rivers] AS [r] ON [cr].[RiverId] = [r].[Id]
WHERE [c].[ContinentCode] = 'AF' ORDER BY [c].[CountryName]

-- 15 - Continents and Currencies
SELECT [ContinentCode], [CurrencyCode], [CurrencyUsage] FROM
(
	SELECT *, DENSE_RANK() OVER(PARTITION BY [ContinentCode] ORDER BY [CurrencyUsage] DESC) AS [CurrencyRank] FROM
	(
		SELECT [ContinentCode], [CurrencyCode], COUNT(*) AS [CurrencyUsage] FROM [Countries]
		GROUP BY [ContinentCode], [CurrencyCode]
		HAVING COUNT(*) > 1
	)
	AS [CurrencyUsageSubquery]
)
AS [CurrencyRankingQuery]
WHERE [CurrencyRank] = 1

-- 16 - Countries Without any Mountains
SELECT COUNT([c].[CountryCode]) AS [Count] FROM [Countries] AS [c]
LEFT JOIN [MountainsCountries] AS [mc] ON [c].[CountryCode] = [mc].[CountryCode]
WHERE [mc].[MountainId] IS NULL

-- 17 - Highest Peak and Longest River by Country
SELECT TOP(5) [c].[CountryName], MAX([p].[Elevation]) AS [HighestPeakElevation], MAX([r].[Length]) AS [LongestRiverLength] FROM [Countries] AS [c]
LEFT JOIN [CountriesRivers] AS [cr] ON [c].[CountryCode] = [cr].[CountryCode]
LEFT JOIN [Rivers] AS [r] ON [cr].[RiverId] = [r].[Id]
LEFT JOIN [MountainsCountries] AS [mc] ON [c].[CountryCode] = [mc].[CountryCode]
LEFT JOIN [Mountains] AS [m] ON [m].[Id] = [mc].[MountainId]
LEFT JOIN [Peaks] AS [p] ON [p].[MountainId] = [m].[Id]
GROUP BY [c].[CountryName] ORDER BY [HighestPeakElevation] DESC, [LongestRiverLength] DESC, [c].[CountryName]

-- 18 - Highest Peak Name and Elevation by Country
SELECT TOP(5) [CountryName] AS [Country],
CASE WHEN [PeakName] IS NULL THEN '(no highest peak)' ELSE [PeakName] END AS [Highest Peak Name],
CASE WHEN [Elevation] IS NULL THEN 0 ELSE [Elevation] END AS [Highest Peak Elevation],
CASE WHEN [MountainRange] IS NULL THEN '(no mountain)' ELSE [MountainRange] END AS [Mountain]
FROM
(
SELECT [c].[CountryName], [p].[PeakName], [p].[Elevation], [m].[MountainRange],
DENSE_RANK() OVER (PARTITION BY [c].[CountryName] ORDER BY [p].[Elevation]) AS [PeakRank]
FROM [Countries] AS [c]
LEFT JOIN [MountainsCountries] AS [mc] ON [c].[CountryCode] = [mc].[CountryCode]
LEFT JOIN [Mountains] AS [m] ON [m].[Id] = [mc].[MountainId]
LEFT JOIN [Peaks] AS [p] ON [p].[MountainId] = [m].[Id]
)
AS [PeakRankingSubquery]
WHERE [PeakRank] = 1
ORDER BY [Country], [Highest Peak Name]