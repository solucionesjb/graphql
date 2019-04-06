CREATE TABLE [dbo].[OpRecord] (
    [Id]                          INT      IDENTITY (1, 1) NOT NULL,
    [OpEventCampaignManagementId] INT      NOT NULL,
    [CatUserId]                   INT      NOT NULL,
    [UserCreationId]              INT      NOT NULL,
    [UserLastModificationId]      INT      NOT NULL,
    [DateCreation]                DATETIME NOT NULL,
    [DateLastModification]        DATETIME NOT NULL,
    [Deleted]                     BIT      CONSTRAINT [DF_OpRecord_Deleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_OpRecord] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OpRecord_CatUsers] FOREIGN KEY ([CatUserId]) REFERENCES [dbo].[CatUsers] ([Id]),
    CONSTRAINT [FK_OpRecord_CatUsers1] FOREIGN KEY ([UserCreationId]) REFERENCES [dbo].[CatUsers] ([Id]),
    CONSTRAINT [FK_OpRecord_CatUsers2] FOREIGN KEY ([UserLastModificationId]) REFERENCES [dbo].[CatUsers] ([Id]),
    CONSTRAINT [FK_OpRecord_OpEventCampaignManagement] FOREIGN KEY ([OpEventCampaignManagementId]) REFERENCES [dbo].[OpEventCampaignManagement] ([Id])
);

