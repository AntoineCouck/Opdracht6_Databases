CREATE TABLE [dbo].[Aandeel]
(
    [AandeelId] INT IDENTITY (1, 1) NOT NULL,
    [Symbool]   VARCHAR (10) NOT NULL,
    [Naam]      VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([AandeelId] ASC)
)


