CREATE TABLE [dbo].[OpEventCampaignDetails] (
    [Id]                          INT IDENTITY (1, 1) NOT NULL,
    [OpEventCampaignManagementId] INT NOT NULL,
    [CatUserId]                   INT NOT NULL,
    [Prospects]                   INT NOT NULL,
    CONSTRAINT [PK_EventHistory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OpEventCampaignDetails_CatUsers] FOREIGN KEY ([CatUserId]) REFERENCES [dbo].[CatUsers] ([Id]),
    CONSTRAINT [FK_OpEventCampaignDetails_OpEventCampaignManagement] FOREIGN KEY ([OpEventCampaignManagementId]) REFERENCES [dbo].[OpEventCampaignManagement] ([Id])
);

