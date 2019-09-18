CREATE TABLE [dbo].[Belegung] (
    [MietvertragId] INT NOT NULL,
    [StandplatzId]  INT NOT NULL,
	[CreatedAt]  DATETIME     NOT NULL,
	[CreatedBy]  VARCHAR (50) NOT NULL,
	[UpdatedAt]  DATETIME     NULL,
	[UpdatedBy]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Belegung_1] PRIMARY KEY CLUSTERED ([MietvertragId] ASC, [StandplatzId] ASC),
    CONSTRAINT [FK_Belegung_Mietvertrag] FOREIGN KEY ([MietvertragId]) REFERENCES [dbo].[Mietvertrag] ([Id]),
    CONSTRAINT [FK_Belegung_Standplatz] FOREIGN KEY ([StandplatzId]) REFERENCES [dbo].[Standplatz] ([Id])
);

