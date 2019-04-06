CREATE TABLE [dbo].[CatUsers] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]      VARCHAR (100) NOT NULL,
    [LastName]       VARCHAR (100) NOT NULL,
    [SecondLastName] VARCHAR (100) NOT NULL,
    [Birthdate]      DATE          NOT NULL,
    [Curp]           VARCHAR (18)  NULL,
    [Rfc]            VARCHAR (13)  NULL,
    [PhoneNumber]    NVARCHAR (15) NULL,
    [Mail]           VARCHAR (300) NULL,
    [IdAvon]         INT           NULL,
    [CatUserId]      NCHAR (10)    NULL,
    [Password]       VARCHAR (50)  NULL,
    [CatRoleId]      INT           NULL,
    CONSTRAINT [PK_CatRepresentatives] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CatUsers_CatRoles] FOREIGN KEY ([CatRoleId]) REFERENCES [dbo].[CatRoles] ([Id])
);

