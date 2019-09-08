CREATE TABLE [dbo].[Anbieter] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Vorname]    VARCHAR (50) NULL,
    [Nachname]   VARCHAR (50) NULL,
    [IsMitglied] BIT          NULL,
    CONSTRAINT [PK_Anbieter] PRIMARY KEY CLUSTERED ([Id] ASC)
);



