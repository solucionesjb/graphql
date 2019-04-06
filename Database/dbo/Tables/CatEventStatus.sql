CREATE TABLE [dbo].[CatEventStatus] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CatEventStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);

