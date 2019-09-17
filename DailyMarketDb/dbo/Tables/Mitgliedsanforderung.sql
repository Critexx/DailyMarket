CREATE TABLE [dbo].[Mitgliedsanforderung] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Bezeichnung]       VARCHAR (50)  NOT NULL,
    [Beschreibung]      VARCHAR (MAX) NULL,
    [Gueltigkeitsdauer] INT           NULL,
    CONSTRAINT [PK_Mitgliedsanforderung] PRIMARY KEY CLUSTERED ([Id] ASC)
);

