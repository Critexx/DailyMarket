CREATE TABLE [dbo].[Pendenz] (
    [Id]                     INT           IDENTITY (1, 1) NOT NULL,
    [AnbieterId]             INT           NOT NULL,
    [MitgliedsanforderungId] INT           NULL,
    [Titel]                  VARCHAR (60)  NOT NULL,
    [Beschreibung]           VARCHAR (MAX) NULL,
    [Status]                 INT           NOT NULL,
    CONSTRAINT [PK_Pendenz] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pendenz_Anbieter] FOREIGN KEY ([AnbieterId]) REFERENCES [dbo].[Anbieter] ([Id]),
    CONSTRAINT [FK_Pendenz_Mitgliedsanforderung] FOREIGN KEY ([MitgliedsanforderungId]) REFERENCES [dbo].[Mitgliedsanforderung] ([Id])
);

