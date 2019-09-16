CREATE TABLE [dbo].[Abotyp] (
    [Id]                   INT            IDENTITY (1, 1) NOT NULL,
    [Bezeichnung]          VARCHAR (50)   NOT NULL,
    [Beschreibung]         VARCHAR (MAX)  NULL,
    [Mietdauer]            INT            NOT NULL,
    [AnzahlBelegungNoetig] INT            NOT NULL,
    [GueltigVon]           DATE           NOT NULL,
    [GueltigBis]           DATE           NULL,
    [RabattInProzent]      DECIMAL (5, 2) NOT NULL,
	[CreatedAt]            DATETIME       NOT NULL,
	[CreatedBy]            VARCHAR (50)   NOT NULL,
	[UpdatedAt]            DATETIME       NULL,
	[UpdatedBy]            VARCHAR (50)   NULL,
    CONSTRAINT [PK_Abotyp] PRIMARY KEY CLUSTERED ([Id] ASC)
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Abotyp_Bezeichnung]
    ON [dbo].[Abotyp]([Bezeichnung] ASC);

