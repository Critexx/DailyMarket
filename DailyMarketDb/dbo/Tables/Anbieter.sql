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



