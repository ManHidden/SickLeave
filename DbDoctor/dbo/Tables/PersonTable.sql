CREATE TABLE [dbo].[PersonTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [PESEL] NUMERIC(11) NOT NULL, 
    [BirthDay] DATE NOT NULL, 
    [DayOfLeave] DATE NOT NULL
)
