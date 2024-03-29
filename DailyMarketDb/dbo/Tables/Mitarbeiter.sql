﻿CREATE TABLE [dbo].[Mitarbeiter] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Vorname]     VARCHAR (50)    NOT NULL,
    [Nachname]    VARCHAR (50)    NOT NULL,
    [Stundensatz] DECIMAL (17, 2) NOT NULL,
    [IsActive]    BIT             CONSTRAINT [DF_Mitarbeiter_IsActive] DEFAULT ((1)) NOT NULL,
    [CreatedAt]   DATETIME        NOT NULL,
    [CreatedBy]   VARCHAR (50)    NOT NULL,
    [UpdatedAt]   DATETIME        NULL,
    [UpdatedBy]   VARCHAR (50)    NULL,
    CONSTRAINT [PK_Mitarbeiter] PRIMARY KEY CLUSTERED ([Id] ASC)
);



