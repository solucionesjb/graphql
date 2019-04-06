CREATE TABLE [dbo].[CatLevels] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CatLevels] PRIMARY KEY CLUSTERED ([Id] ASC)
);

