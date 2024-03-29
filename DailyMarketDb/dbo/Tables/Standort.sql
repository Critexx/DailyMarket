﻿CREATE TABLE [dbo].[Standort] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Bezeichnung] VARCHAR (50) NOT NULL,
    [Strasse]     VARCHAR (50) NOT NULL,
    [Plz]         VARCHAR (10) NOT NULL,
    [Ort]         VARCHAR (50) NOT NULL,
	[CreatedAt]  DATETIME     NOT NULL,
	[CreatedBy]  VARCHAR (50) NOT NULL,
	[UpdatedAt]  DATETIME     NULL,
	[UpdatedBy]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Standort] PRIMARY KEY CLUSTERED ([Id] ASC)
);



