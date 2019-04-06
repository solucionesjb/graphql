CREATE TABLE [dbo].[OpEventCampaignManagement] (
    [Id]                INT      IDENTITY (1, 1) NOT NULL,
    [CatUserId]         INT      NOT NULL,
    [OpEventCampaignId] INT      NOT NULL,
    [Date]              DATETIME NOT NULL,
    [CatEventStatusId]  INT      NOT NULL,
    CONSTRAINT [PK_RepresentativeEvents] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OpEventCampaignManagement_CatEventStatus] FOREIGN KEY ([CatEventStatusId]) REFERENCES [dbo].[CatEventStatus] ([Id]),
    CONSTRAINT [FK_OpEventCampaignManagement_CatUsers] FOREIGN KEY ([CatUserId]) REFERENCES [dbo].[CatUsers] ([Id]),
    CONSTRAINT [FK_OpEventCampaignManagement_OpEventCampaign] FOREIGN KEY ([OpEventCampaignId]) REFERENCES [dbo].[OpEventCampaign] ([Id])
);

