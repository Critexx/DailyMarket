CREATE TABLE [dbo].[Mitgliedsanforderung] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Bezeichnung]       VARCHAR (50)  NOT NULL,
    [Beschreibung]      VARCHAR (MAX) NULL,
    [Gueltigkeitsdauer] INT           NULL,
	[CreatedAt]  DATETIME     NOT NULL,
	[CreatedBy]  VARCHAR (50) NOT NULL,
	[UpdatedAt]  DATETIME     NULL,
	[UpdatedBy]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Mitgliedsanforderung] PRIMARY KEY CLUSTERED ([Id] ASC)
);

