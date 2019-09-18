CREATE TABLE [dbo].[Rapport] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [MitarbeiterId] INT             NOT NULL,
    [PendenzId]     INT             NOT NULL,
    [Datum]         DATE            NOT NULL,
    [Beschreibung]  VARCHAR (MAX)   NULL,
    [Aufwand]       DECIMAL (17, 2) NOT NULL,
    [Stundensatz]   DECIMAL (17, 2) NOT NULL,
	[CreatedAt]  DATETIME     NOT NULL,
	[CreatedBy]  VARCHAR (50) NOT NULL,
	[UpdatedAt]  DATETIME     NULL,
	[UpdatedBy]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Rapport] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Rapport_Mitarbeiter] FOREIGN KEY ([MitarbeiterId]) REFERENCES [dbo].[Mitarbeiter] ([Id]),
    CONSTRAINT [FK_Rapport_Pendenz] FOREIGN KEY ([PendenzId]) REFERENCES [dbo].[Pendenz] ([Id])
);

