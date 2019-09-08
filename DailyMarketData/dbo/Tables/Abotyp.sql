CREATE TABLE [dbo].[Abotyp] (
    [Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [Bezeichnung]           VARCHAR (50)   NOT NULL,
    [Beschreibung]          VARCHAR (MAX)  NULL,
    [Mietdauer]             INT            NOT NULL,
    [AnzahlBelegungErlaubt] INT            NOT NULL,
    [GueltigVon]            INT            NOT NULL,
    [GueltigBis]            INT            NULL,
    [RabattInProzent]       DECIMAL (5, 2) NOT NULL,
    CONSTRAINT [PK_Abotyp] PRIMARY KEY CLUSTERED ([Id] ASC)
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Abotyp_Bezeichnung]
    ON [dbo].[Abotyp]([Bezeichnung] ASC);

