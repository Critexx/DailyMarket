CREATE TABLE [dbo].[Belegung] (
    [MietvertragId] INT NOT NULL,
    [StandplatzId]  INT NOT NULL,
    CONSTRAINT [PK_Belegung_1] PRIMARY KEY CLUSTERED ([MietvertragId] ASC, [StandplatzId] ASC),
    CONSTRAINT [FK_Belegung_Mietvertrag] FOREIGN KEY ([MietvertragId]) REFERENCES [dbo].[Mietvertrag] ([Id]),
    CONSTRAINT [FK_Belegung_Standplatz] FOREIGN KEY ([StandplatzId]) REFERENCES [dbo].[Standplatz] ([Id])
);

