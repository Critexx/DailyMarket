CREATE TABLE [dbo].[Anbieter] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Vorname]    VARCHAR (50) NULL,
    [Nachname]   VARCHAR (50) NULL,
    [IsMitglied] BIT          NOT NULL,
    [CreatedAt]  DATETIME     NOT NULL,
    [CreatedBy]  VARCHAR (50) NOT NULL,
    [UpdatedAt]  DATETIME     NULL,
    [UpdatedBy]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Anbieter] PRIMARY KEY CLUSTERED ([Id] ASC)
);






GO

CREATE TRIGGER CreateInitialPendenz
   ON  Anbieter
   AFTER INSERT
AS 
BEGIN

DECLARE @anbieterId INT;
SELECT * INTO #insertedTemp from inserted;

WHILE (SELECT COUNT(*) FROM #insertedTemp) <> 0
BEGIN

SET @anbieterId = (SELECT TOP (1) Id FROM #insertedTemp);

EXEC spCreatePendenz @anbieterId;

DELETE TOP (1) FROM #insertedTemp;
END

END