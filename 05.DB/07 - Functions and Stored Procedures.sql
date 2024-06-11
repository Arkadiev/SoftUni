USE [SoftUni]

GO

-- 1 - Employees with Salary Above 35000
CREATE PROCEDURE [usp_GetEmployeesSalaryAbove35000] AS
BEGIN
SELECT [FirstName], [LastName] FROM [Employees] WHERE [Salary] > 35000
END

EXEC [dbo].[usp_GetEmployeesSalaryAbove35000]

GO

-- 2 - Employees with Salary Above Number
CREATE PROC [usp_GetEmployeesSalaryAboveNumber] @minSalary DECIMAL(18, 4) AS
BEGIN
SELECT [FirstName], [LastName] FROM [Employees] WHERE [Salary] >= @minSalary
END

EXEC [usp_GetEmployeesSalaryAboveNumber] 48100

GO

-- 3 - Town Names Starting With
CREATE PROC [usp_GetTownsStartingWith] @substring VARCHAR(50) AS
BEGIN
SELECT [Name] FROM [Towns] WHERE LEFT([Name], LEN(@substring)) = @substring
END

GO

-- 4 - Employees from Town
CREATE PROC [usp_GetEmployeesFromTown] @townName VARCHAR(50) AS
BEGIN
SELECT [e].[FirstName], [e].[LastName] FROM [Employees] AS [e]
INNER JOIN [Addresses] AS [a] ON [e].[AddressID] = [a].[AddressID]
INNER JOIN [Towns] AS [t] ON [a].[TownID] = [t].[TownID]
WHERE [t].[Name] = @townName
END

EXEC [usp_GetEmployeesFromTown] 'Sofia'

GO

-- 5 - Salary Level Function
CREATE FUNCTION [ufn_GetSalaryLevel] (@salary DECIMAL(18,4)) RETURNS VARCHAR(8) AS
BEGIN
DECLARE @salaryLevel VARCHAR(8)
IF @salary < 30000 BEGIN SET @salaryLevel = 'Low' END
ELSE IF @salary BETWEEN 30000 AND 50000 BEGIN SET @salaryLevel = 'Average' END
ELSE IF @salary > 50000 BEGIN SET @salaryLevel = 'High' END
RETURN @salaryLevel
END

GO

-- 6 - Employees by Salary Level
CREATE PROC [usp_EmployeesBySalaryLevel] @salaryLevel VARCHAR(8) AS
BEGIN
SELECT [FirstName], [LastName] FROM [Employees]
WHERE [dbo].[ufn_GetSalaryLevel]([Salary]) = @salaryLevel
END

GO

-- 7 - Define Function
CREATE FUNCTION [ufn_IsWordComprised] (@setOfLetters VARCHAR(50), @word VARCHAR(50)) RETURNS BIT AS
BEGIN
	DECLARE @wordIndex INT = 1
	WHILE (@wordIndex <= LEN(@word))
	BEGIN
		DECLARE @currentCharacter CHAR = SUBSTRING(@word, @wordIndex, 1)
		IF CHARINDEX(@currentCharacter, @setOfLetters) = 0 BEGIN RETURN 0 END
		SET @wordIndex += 1
	END
	RETURN 1
END

GO

-- 8 - Delete Employees and Departments
CREATE PROC [usp_DeleteEmployeesFromDepartment] @departmentId INT AS
BEGIN
	DECLARE @employeesToDelete TABLE ([Id] INT);
	INSERT INTO @employeesToDelete
	SELECT [EmployeeID] FROM [Employees] WHERE [DepartmentID] = @departmentId

	DELETE FROM [EmployeesProjects] WHERE [EmployeeID] IN (SELECT [Id] FROM @employeesToDelete)

	ALTER TABLE [Departments] ALTER COLUMN [ManagerID] INT
	UPDATE [Departments] SET [ManagerID] = NULL WHERE [ManagerID] IN (SELECT [Id] FROM @employeesToDelete)

	UPDATE [Employees] SET [ManagerID] = NULL WHERE [ManagerID] IN (SELECT [Id] FROM @employeesToDelete)

	DELETE FROM [Employees] WHERE [DepartmentID] = @departmentId

	DELETE FROM [Departments] WHERE [DepartmentID] = @departmentId

	SELECT COUNT(*) FROM [Employees] WHERE [DepartmentID] = @departmentId
END

GO

-- 9 - Find Full Name
USE [Bank]

GO

CREATE PROC [usp_GetHoldersFullName] AS
BEGIN
SELECT ([FirstName] + ' ' + [LastName]) AS [Full Name] FROM [AccountHolders]
END

GO

-- 10 - People with Balance Higher Than
CREATE PROC [usp_GetHoldersWithBalanceHigherThan] @number DECIMAL(16,4) AS
BEGIN
SELECT [FirstName] AS [FirstName], [LastName] AS [Last Name] FROM
(
	SELECT [FirstName], [LastName], SUM([a].[Balance]) AS [Total Balance] FROM [AccountHolders] AS [ah]
	INNER JOIN [Accounts] AS [a] ON [ah].[Id] = [a].[AccountHolderId]
	GROUP BY [ah].[FirstName], [ah].[LastName]
) AS [tb]
WHERE [tb].[Total Balance] > @number
ORDER BY [FirstName], [LastName]
END

GO

-- 11 - Future Value Function
CREATE FUNCTION [ufn_CalculateFutureValue] (@sum DECIMAL (18,4), @interest FLOAT, @years INT) RETURNS DECIMAL(18,4)
BEGIN
	DECLARE @futureValue DECIMAL (18,4)
	SET @futureValue = @sum * POWER((1 + @interest), @years)
	RETURN @futureValue
END

GO

-- 12 - Calculating Interest
CREATE PROC [usp_CalculateFutureValueForAccount] (@accountId INT, @interestRate FLOAT) AS
BEGIN
	SELECT [a].[Id] AS [Account Id], [ah].[FirstName] AS [First Name], [ah].[LastName] AS [Last Name], [a].[Balance],
	[dbo].[ufn_CalculateFutureValue]([Balance], @interestRate, 5) AS [Balance in 5 years]
	FROM [AccountHolders] AS [ah]
	INNER JOIN [Accounts] AS [a] ON [ah].[Id] = [a].[Id]
	WHERE [a].[Id] = @accountId
END

GO

-- 13 - Cash in User Games Odd Rows
USE [Diablo]

GO

CREATE FUNCTION [ufn_CashInUsersGames] (@gameName NVARCHAR(50)) RETURNS TABLE AS
RETURN
(
	SELECT SUM([Cash]) AS [SumCash] FROM
	(
	SELECT [g].[Name], [ug].[Cash], ROW_NUMBER() OVER(ORDER BY [ug].[Cash] DESC) AS [RowNumber] FROM [UsersGames] AS [ug]
	INNER JOIN [Games] AS [g] ON [ug].[GameId] = [g].[Id]
	WHERE [g].[Name] = @gameName
	) AS [RankingSubquery]
	WHERE [RowNumber] % 2 <> 0
)

GO