CREATE TABLE [dbo].[Standplatz] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [StandortId]  INT          NOT NULL,
    [Nr]          INT          NOT NULL,
    [PreisProTag] MONEY        NULL,
    [CreatedAt]   DATETIME     NOT NULL,
    [CreatedBy]   VARCHAR (50) NOT NULL,
    [UpdatedAt]   DATETIME     NULL,
    [UpdatedBy]   VARCHAR (50) NULL,
    CONSTRAINT [PK_Standplatz] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Standplatz_Standort] FOREIGN KEY ([StandortId]) REFERENCES [dbo].[Standort] ([Id])
);








GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Standplatz_StandortId_Nr]
    ON [dbo].[Standplatz]([StandortId] ASC, [Nr] ASC);




GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'StandplatzNr muss pro Standort unique sein', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Standplatz', @level2type = N'INDEX', @level2name = N'UQ_Standplatz_StandortId_Nr';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'StandplatzNr muss pro Standort unique sein', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Standplatz', @level2type = N'INDEX', @level2name = N'UQ_Standplatz_StandortId_Nr';

