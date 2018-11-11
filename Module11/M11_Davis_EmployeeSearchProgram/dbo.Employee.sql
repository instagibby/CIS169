CREATE TABLE [dbo].[Employee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Position] NVARCHAR(50) NOT NULL, 
    [HourlyPayRate] MONEY NOT NULL
)
