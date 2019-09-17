CREATE TABLE [dbo].[Mitarbeiter] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Vorname]     VARCHAR (50)    NOT NULL,
    [Nachname]    VARCHAR (50)    NOT NULL,
    [Stundensatz] DECIMAL (17, 2) NOT NULL,
    CONSTRAINT [PK_Mitarbeiter] PRIMARY KEY CLUSTERED ([Id] ASC)
);

