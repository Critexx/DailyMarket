CREATE TABLE [dbo].[Mietvertrag] (
    [Id]         INT   IDENTITY (1, 1) NOT NULL,
    [AbotypId]   INT   NOT NULL,
    [AnbieterId] INT   NOT NULL,
    [GueltigVon] DATE  NOT NULL,
    [GueltigBis] DATE  NULL,
    [Abrechnung] MONEY NOT NULL,
	[CreatedAt]  DATETIME     NOT NULL,
	[CreatedBy]  VARCHAR (50) NOT NULL,
	[UpdatedAt]  DATETIME     NULL,
	[UpdatedBy]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Belegung] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Mietvertrag_Abotyp] FOREIGN KEY ([AbotypId]) REFERENCES [dbo].[Abotyp] ([Id]),
    CONSTRAINT [FK_Mietvertrag_Anbieter] FOREIGN KEY ([AnbieterId]) REFERENCES [dbo].[Anbieter] ([Id])
);



