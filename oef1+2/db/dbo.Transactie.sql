CREATE TABLE [dbo].[Transacties]
(
	[AandeelId] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [AantalGekocht] INT NOT NULL DEFAULT 0, 
    [Koers] MONEY NOT NULL, 
    [TransactieDatum] DATETIME NOT NULL, 
    CONSTRAINT [FK_AandeelId] FOREIGN KEY (AandeelId) REFERENCES Aandeel (AandeelId)

)
