CREATE TABLE [dbo].[Musteriler]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Ad] VARCHAR(50) NULL, 
    [Soyad] VARCHAR(50) NULL,
	[Cinsiyet] VARCHAR(5) NULL,
	[Kimlik] VARCHAR(16) NULL, 
	[Yas] INT NULL, 
    [Telefon] VARCHAR(50) NOT NULL,
    [Email] VARCHAR(50) NULL, 
    [Adres] VARCHAR(MAX) NULL
)
