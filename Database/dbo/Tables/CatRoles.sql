CREATE TABLE [dbo].[CatRoles] (
    [Id]      INT           NOT NULL,
    [Name]    VARCHAR (50)  NOT NULL,
    [Actions] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_CatRoles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

