CREATE TABLE [dbo].[CatZone] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (300) NOT NULL,
    CONSTRAINT [PK_CatZone] PRIMARY KEY CLUSTERED ([Id] ASC)
);

