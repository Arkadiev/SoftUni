-- 1 - Create Database
CREATE DATABASE [Minions]

USE [Minions]

-- 2 - Create Tables
CREATE TABLE Minions (
	Id INT PRIMARY KEY,
	[Name] VARCHAR(100),
	Age INT
)

CREATE TABLE Towns (
	Id INT PRIMARY KEY,
	[Name] VARCHAR(100)
)

-- 3 - Alter Minions Table
ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCES Towns(Id)

-- 4 - Insert Records in Both Tables
INSERT INTO Towns
VALUES
	(1, 'Sofia'),
	(2, 'Plovdiv'),
	(3, 'Varna')

INSERT INTO Minions
VALUES
	(1, 'Kevin', 22, 1),
	(2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2)

-- 5 - Truncate Table Minions
TRUNCATE TABLE Minions

-- 6 - Drop All Tables
DROP TABLE Minions
DROP TABLE Towns

-- 7 - Create Table People
CREATE TABLE People (
	Id INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX) CHECK(LEN(Picture) >= 2000000),
	Height DECIMAL,
	[Weight] DECIMAL,
	Gender CHAR(1),
	Birthdate DATETIME2 NOT NULL,
	Biography NVARCHAR(MAX),
)

INSERT INTO People ([Name], Height, [Weight], Gender, Birthdate)
VALUES
	('Pesho', 172, 67, 'm', '1996-10-27'),
	('Gosho', 183, 76, 'm', '1994-07-12'),
	('Ivan', 165, 61, 'm', '2001-03-14'),
	('Martin', 180, 69, 'm', '1993-11-17'),
	('Elena', 160, 58, 'f', '1999-07-21')

-- 8 - Create Table Users
CREATE TABLE Users (
	Id BIGINT IDENTITY PRIMARY KEY,
	Username VARCHAR (30) NOT NULL,
	[Password] VARCHAR (26) NOT NULL,
	ProfilePicture VARBINARY(MAX) CHECK(LEN(ProfilePicture) >= 900000),
	LastLoginTime DATETIME2,
	IsDeleted BIT
);

INSERT INTO Users
VALUES
	('Pesho', '1234567', null, '10-20-2023', 0),
	('Pesho2', '7654321', null, '11-20-2022', 1),
	('Pesho3', '1234567', null, '12-20-2022', 0),
	('Pesho4', '7654321', null, '10-20-2022', 1),
	('Pesho5', 'PisnaMi', null, '9-20-2022', 0)

-- 9 - Change Primary Key
ALTER TABLE Users DROP CONSTRAINT PK__Users__3214EC075203FB90;
ALTER TABLE Users ADD CONSTRAINT PK_IdUsername PRIMARY KEY (Id, Username);

-- 10 - Add Check Constraint
ALTER TABLE Users ADD CONSTRAINT CHK_PasswordMinLen CHECK(LEN([Password]) >= 5)

-- 11 - Set Default Value of a Field
ALTER TABLE Users ADD CONSTRAINT DF_LastLoginTime DEFAULT GETDATE() FOR LastLoginTime

-- 12 - Set Unique Field
ALTER TABLE Users DROP CONSTRAINT PK_IdUsername
ALTER TABLE Users ADD CONSTRAINT PK_Id PRIMARY KEY (Id)
ALTER TABLE Users ADD CONSTRAINT UC_Username UNIQUE (Username)
ALTER TABLE Users ADD CONSTRAINT CHK_UsernameMinLen CHECK(LEN([Password]) >= 3)

-- 13 - Movies Database
CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors (
	Id INT PRIMARY KEY,
	DirectorName NVARCHAR(100) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors (Id, DirectorName)
VALUES
	(1, 'Filip'),
	(2, 'Doncho'),
	(3, 'MaikaTi'),
	(4, 'StoyanKolev'),
	(5, 'EmiliTrotinetkata')

CREATE TABLE Genres (
	Id INT PRIMARY KEY,
	GenreName NVARCHAR(100) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Genres (Id, GenreName)
VALUES
	(1, 'Ekshan'),
	(2, 'Komedi'),
	(3, 'Ujast'),
	(4, 'MaikaViMrusna'),
	(5, 'VieSeEbavateSMene')

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	CategoryName NVARCHAR(100) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories (Id, CategoryName)
VALUES
	(1, 'ZaTvaLi'),
	(2, 'Dadoh500Leva'),
	(3, 'BeShanajiiSkapani'),
	(4, 'DaSeUchaSamShtoto'),
	(5, 'FilipIDonchoSaAutisti')

CREATE TABLE Movies (
	Id INT PRIMARY KEY,
	Title NVARCHAR(100) NOT NULL,
	DirectorId INT NOT NULL,
	CopyrightYear INT,
	[Length] TIME NOT NULL,
	GenreId INT NOT NULL,
	CategoryId INT NOT NULL,
	Rating INT,
	Notes NVARCHAR(MAX)
)

INSERT INTO Movies (Id, Title, DirectorId, [Length], GenreId, CategoryId)
VALUES
	(1, 'Random2', 1, '2:45', 1, 1),
	(2, 'Random', 2, '1:38', 2, 2),
	(3, 'asdasd', 1, '2:20', 1, 1),
	(4, 'TestTest', 2, '3:10', 1, 1),
	(5, 'Pisna Mi', 1, '1:50', 2, 2)

-- 14 - Car Rental Database

CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	CategoryName NVARCHAR(100) NOT NULL,
	DailyRate DECIMAL,
	WeeklyRate DECIMAL,
	MonthlyRate DECIMAL,
	WeekendRate DECIMAL
)

INSERT INTO Categories (Id, CategoryName)
VALUES
	(1, 'Cars'),
	(2, 'Bikes'),
	(3, 'Trucks')

CREATE TABLE Cars (
	Id INT PRIMARY KEY,
	PlateNumber NVARCHAR(5) NOT NULL,
	Manufacturer NVARCHAR(100) NOT NULL,
	Model NVARCHAR(100) NOT NULL,
	CarYear NVARCHAR(4),
	CategoryId INT,
	Doors INT,
	Picture VARBINARY(MAX),
	Condition NVARCHAR(100),
	Available BIT
)

INSERT INTO Cars (Id, PlateNumber, Manufacturer, Model)
VALUES
	(1, '12345', 'Audi', 'A3'),
	(2, 'ASD12', 'VW', 'Golf'),
	(3, 'SO12A', 'Mercedes', '204')

CREATE TABLE Employees (
	Id INT PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Title NVARCHAR(100),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (Id, FirstName, LastName)
VALUES
	(1, 'Pesho', 'Goshov'),
	(2, 'Filip', 'Doncho'),
	(3, 'Bai', 'Hui')

CREATE TABLE Customers (
	Id INT PRIMARY KEY,
	DriverLicenseNumber INT NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	[Address] NVARCHAR(100),
	City NVARCHAR(100),
	ZIPCode NVARCHAR(4),
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers (Id, DriverLicenseNumber, FullName)
VALUES
	(1, 23, 'Unufri'),
	(2, 23, 'Kircho'),
	(3, 23, 'Petkan')

CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY,
	EmployeeId INT NOT NULL,
	CustomerId INT NOT NULL,
	CardId INT NOT NULL,
	TankLevel INT,
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate DATETIME2,
	EndDate DATETIME2,
	TotalDays INT,
	RateApplied INT,
	TaxRate INT,
	OrderStatus NVARCHAR(100),
	Notes NVARCHAR(MAX)
)

INSERT INTO RentalOrders (Id, EmployeeId, CustomerId, CardId)
VALUES
	(1, 1, 1, 1),
	(2, 2, 2, 2),
	(3, 1, 2, 1)

-- 15 - Hotel Database
CREATE DATABASE Hotel

USE Hotel

CREATE TABLE Employees (
	Id INT PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Title NVARCHAR(100),
	Notes NVARCHAR(MAX)
)
INSERT INTO Employees (Id, FirstName, LastName)
VALUES
	(1, 'Misho', 'Ivanov'),
	(2, 'Pesho', 'Slepiq'),
	(3, 'Bat', 'Gergi')

CREATE TABLE Customers (
	AccountNumber INT PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	PhoneNumber CHAR(10) NOT NULL,
	EmergencyName NVARCHAR(100),
	EmergencyNumber CHAR(10),
	Notes NVARCHAR(MAX)
)
INSERT INTO Customers (AccountNumber, FirstName, LastName, PhoneNumber)
VALUES
	(1, 'Isus', 'Hristos', '1234567890'),
	(2, 'Stoyan', 'Kolev', '0987654321'),
	(3, 'Napoleon', 'Bonapart', '1227696496')

CREATE TABLE RoomStatus (
	RoomStatus NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomStatus (RoomStatus)
VALUES
	('Occupied'),
	('Free'),
	('Pending')

CREATE TABLE RoomTypes (
	RoomType NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)
INSERT INTO RoomTypes (RoomType)
VALUES
	('Small'),
	('Medium'),
	('Large')

CREATE TABLE BedTypes (
	BedType NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)
INSERT INTO BedTypes (BedType)
VALUES
	('Small'),
	('Medium'),
	('Large')

CREATE TABLE Rooms (
	RoomNumber INT PRIMARY KEY,
	RoomType NVARCHAR(10) NOT NULL,
	BedType NVARCHAR(10) NOT NULL,
	Rate TINYINT,
	RoomStatus NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)
INSERT INTO Rooms (RoomNumber, RoomType, BedType, RoomStatus)
VALUES
	(1, 'Small', 'Small', 'Free'),
	(2, 'Medium', 'Medium', 'Occupied'),
	(3, 'Large', 'Large', 'Pending')

CREATE TABLE Payments (
	Id INT PRIMARY KEY,
	EmployeeId INT NOT NULL,
	PaymentDate DATETIME2,
	AccountNumber INT NOT NULL,
	FirstDateOccupied DATETIME2,
	LastDateOccupied DATETIME2,
	TotalDays TINYINT,
	AmountCharged DECIMAL(15,2),
	TaxRate INT,
	TaxAmount DECIMAL(15,2),
	PaymentTotal DECIMAL(15,2),
	Notes NVARCHAR(MAX)
)
INSERT INTO Payments (Id, EmployeeId, AccountNumber)
VALUES
	(1, 23, 1234),
	(2, 14, 5678),
	(3, 45, 9101)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY,
	EmployeeId INT NOT NULL,
	DateOccupied DATETIME2,
	AccountNumber INT NOT NULL,
	RoomNumber INT,
	RateApplied INT,
	PhoneCharge DECIMAL,
	Notes NVARCHAR(MAX)
)
INSERT INTO Occupancies (Id, EmployeeId, AccountNumber)
VALUES
	(1, 23, 1234),
	(2, 14, 5678),
	(3, 45, 9101)

-- 16 - Create SoftUni Database
CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Towns (
	Id INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(100) NOT NULL,
)

CREATE TABLE Addresses (
	Id INT IDENTITY PRIMARY KEY,
	AddressText NVARCHAR(100) NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE Departments (
	Id INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(100) NOT NULL
)

CREATE TABLE Employees (
	Id INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	MiddleName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	JobTitle NVARCHAR(100) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
	HireDate DATETIME2 NOT NULL,
	Salary DECIMAL NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id)
)

-- 17 - Backup Database
BACKUP DATABASE SoftUni
TO DISK = 'C:\Users\georgi\Downloads\softuni-backup.bak'

DROP DATABASE SoftUni

RESTORE DATABASE SoftUni
FROM DISK = 'C:\Users\georgi\Downloads\softuni-backup.bak'

-- 18 - Basic Insert
INSERT INTO Towns
VALUES
	('Sofia'),
	('Plovdiv'),
	('Varna'),
	('Burgas')

INSERT INTO Departments
VALUES
	('Engineering'),
	('Sales'),
	('Marketing'),
	('Software Development'),
	('Quality Assurance')

INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate)
VALUES
	('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00),
	('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00),
	('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.00),
	('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00),
	('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88)

-- 19 - Basic Select All Fields
SELECT * FROM Towns
SELECT * FROM Departments
SELECT * FROM Employees

-- 20 - Basic Select All Fields and Order Them
SELECT * FROM Towns ORDER BY [Name] ASC
SELECT * FROM Departments ORDER BY [Name] ASC
SELECT * FROM Employees ORDER BY [Salary] DESC

-- 21 - Basic Select Some Fields
SELECT [Name] FROM Towns ORDER BY [Name] ASC
SELECT [Name] FROM Departments ORDER BY [Name] ASC
SELECT [FirstName], [LastName], [JobTitle], [Salary] FROM Employees ORDER BY [Salary] DESC

-- 22 - Increase Employees Salary
UPDATE Employees SET SALARY *= 1.1
SELECT [Salary] FROM Employees

-- 23 - Decrease Tax Rate
USE Hotel

UPDATE Payments SET TaxRate-=0.03
SELECT TaxRate FROM Payments

-- 24 - Delete All Records
DELETE Occupancies