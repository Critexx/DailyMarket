CREATE TABLE [dbo].[Mitgliedsanforderung_Anbieter] (
    [Id]                     INT  IDENTITY (1, 1) NOT NULL,
    [MitgliedsanforderungId] INT  NOT NULL,
    [AnbieterId]             INT  NOT NULL,
    [GueltigAb]              DATE NOT NULL,
    [GueltigBis]             DATE NULL,
    [Status]                 INT  NOT NULL,
    CONSTRAINT [PK_Mitgliedsanforderung_Anbieter] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Mitgliedsanforderung_Anbieter_Anbieter] FOREIGN KEY ([AnbieterId]) REFERENCES [dbo].[Anbieter] ([Id]),
    CONSTRAINT [FK_Mitgliedsanforderung_Anbieter_Mitgliedsanforderung] FOREIGN KEY ([MitgliedsanforderungId]) REFERENCES [dbo].[Mitgliedsanforderung] ([Id])
);

