CREATE TABLE [dbo].[Standplatz] (
    [Id]          INT   IDENTITY (1, 1) NOT NULL,
    [StandortId]  INT   NULL,
    [PreisProTag] MONEY NULL,
	[CreatedAt]  DATETIME     NOT NULL,
	[CreatedBy]  VARCHAR (50) NOT NULL,
	[UpdatedAt]  DATETIME     NULL,
	[UpdatedBy]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Standplatz] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Standplatz_Standort] FOREIGN KEY ([StandortId]) REFERENCES [dbo].[Standort] ([Id])
);



