﻿CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(20) NOT NULL, 
    [LastName] NVARCHAR(30) NOT NULL, 
    [BirthDay] CHAR(10) NOT NULL, 
    [PESEL] NUMERIC(11) NOT NULL
)
