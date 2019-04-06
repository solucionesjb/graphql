CREATE TABLE [dbo].[CatEvents] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (300) NOT NULL,
    [Type] BIT           NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED ([Id] ASC)
);

