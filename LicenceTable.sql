CREATE TABLE [dbo].[Licence]
(
	[Name] NCHAR(10) NOT NULL, 
    [Address] NCHAR(10) NOT NULL, 
    [Phone] INT NOT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    [Photo] IMAGE NOT NULL, 
    [Payment] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Licence] PRIMARY KEY ([Phone]) 
)