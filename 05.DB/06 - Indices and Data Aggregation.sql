USE [Gringotts]

-- 1 - Records' Count
SELECT COUNT([Id]) AS [Count] FROM [WizzardDeposits]

-- 2 - Longest Magic Wand
SELECT TOP(1) [MagicWandSize] FROM [WizzardDeposits] ORDER BY [MagicWandSize] DESC

-- 3 - Longest Magic Wand per Deposit Groups
SELECT [DepositGroup], MAX([MagicWandSize]) AS [LongestMagicWand] FROM [WizzardDeposits] GROUP BY [DepositGroup]

-- 4 - Smallest Deposit Group Per Magic Wand Size
SELECT [DepositGroup] FROM [WizzardDeposits] GROUP BY [DepositGroup] ORDER BY AVG([MagicWandSize])

-- 5 - Deposits Sum
SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum] FROM [WizzardDeposits] GROUP BY [DepositGroup]

-- 6 - Deposits Sum for Ollivander Family
SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum] FROM [WizzardDeposits]
WHERE [MagicWandCreator] = 'Ollivander family' GROUP BY [DepositGroup]

-- 7 - Deposits Filter
SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum] FROM [WizzardDeposits]
WHERE [MagicWandCreator] = 'Ollivander family' GROUP BY [DepositGroup]
HAVING SUM([DepositAmount]) < 150000 ORDER BY [TotalSum] DESC

-- 8 - Deposit Charge
SELECT [DepositGroup], [MagicWandCreator], MIN([DepositCharge]) AS [MinDepositCharge] FROM [WizzardDeposits]
GROUP BY [DepositGroup], [MagicWandCreator] ORDER BY [MagicWandCreator], [DepositGroup]

-- 9 - Age Groups
SELECT [AgeGroup], COUNT(*) AS [WizardCount] FROM
(
SELECT
	CASE
		WHEN [Age] BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN [Age] BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN [Age] BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN [Age] BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN [Age] BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN [Age] BETWEEN 51 AND 60 THEN '[51-60]'
		ELSE '[61+]'
	END AS [AgeGroup]
FROM [WizzardDeposits]
)
AS [AgeGroupSubquery] GROUP BY [AgeGroup]

-- 10 - First Letter
SELECT SUBSTRING([FirstName], 1, 1) AS [FirstLetter] FROM [WizzardDeposits]
WHERE [DepositGroup] = 'Troll Chest'
GROUP BY SUBSTRING([FirstName], 1, 1)
ORDER BY [FirstLetter]

-- 11 - Average Interest
SELECT [DepositGroup], [IsDepositExpired], AVG([DepositInterest]) AS [AverageInterest] FROM [WizzardDeposits]
WHERE [DepositStartDate] > '01/01/1985'
GROUP BY [DepositGroup], [IsDepositExpired]
ORDER BY [DepositGroup] DESC, [IsDepositExpired]

-- 12 - Rich Wizard, Poor Wizard
SELECT SUM([Difference]) AS [Sum Difference] FROM
(
SELECT
[FirstName] AS [Host Wizard],
[DepositAmount] AS [Host Wizard Deposit],
LEAD([FirstName]) OVER(ORDER BY [Id]) AS [Guest Wizard],
LEAD([DepositAmount]) OVER(ORDER BY [Id]) AS [Guest Wizard Deposit],
[DepositAmount] - LEAD([DepositAmount]) OVER(ORDER BY [Id]) AS [Difference]
FROM [WizzardDeposits]
)
AS [Difference Subquery]

-- 13 - Departments Total Salaries
USE [SoftUni]

GO

SELECT [DepartmentId], SUM([Salary]) AS [TotalSalary] FROM [Employees] GROUP BY [DepartmentId] ORDER BY [DepartmentId]

-- 14 - Employees Minimum Salaries
SELECT [DepartmentId], MIN([Salary]) AS [MinimumSalary] FROM [Employees]
WHERE [HireDate] > '01/01/2000' AND [DepartmentId] IN (2, 5, 7)
GROUP BY [DepartmentId] ORDER BY [DepartmentId]

-- 15 - Employees Average Salaries
SELECT * INTO [NewEmployeesTable] FROM [Employees] WHERE [Salary] > 30000

DELETE FROM [NewEmployeesTable] WHERE [ManagerID] = 42

UPDATE [NewEmployeesTable] SET [Salary] += 5000 WHERE [DepartmentID] = 1

SELECT [DepartmentID], AVG([Salary]) AS [AverageSalary] FROM [NewEmployeesTable] GROUP BY [DepartmentID]

-- 16 - Employees Maximum Salaries
SELECT [DepartmentID], MAX([Salary]) AS [MaxSalary] FROM [Employees]
GROUP BY [DepartmentID] HAVING MAX([Salary]) NOT BETWEEN 30000 AND 70000

-- 17 - Employees Count Salaries
SELECT COUNT(*) AS [Count] FROM [Employees] WHERE [ManagerID] IS NULL

-- 18 - 3rd Highest Salary
SELECT DISTINCT [DepartmentID], [Salary] AS [ThirdHighestSalary] FROM
(
SELECT [DepartmentID], [Salary], DENSE_RANK() OVER(PARTITION BY [DepartmentID] ORDER BY [Salary] DESC) AS [SalaryRank] FROM [Employees]
)
AS [SalaryRankingSubquery] WHERE [SalaryRank] = 3

-- 19 - Salary Challenge
SELECT TOP(10) [e].[FirstName], [e].[LastName], [e].[DepartmentID] FROM [Employees] AS [e]
WHERE [e].[Salary] >
(
SELECT AVG([Salary]) AS [AverageSalary] FROM [Employees] AS [eSub]
WHERE [eSub].[DepartmentID] = [e].[DepartmentID]
GROUP BY [DepartmentId]
)
ORDER BY [e].[DepartmentID]