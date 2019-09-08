CREATE TABLE [dbo].[Standplatz] (
    [Id]          INT   IDENTITY (1, 1) NOT NULL,
    [StandortId]  INT   NULL,
    [PreisProTag] MONEY NULL,
    CONSTRAINT [PK_Standplatz] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Standplatz_Standort] FOREIGN KEY ([StandortId]) REFERENCES [dbo].[Standort] ([Id])
);



