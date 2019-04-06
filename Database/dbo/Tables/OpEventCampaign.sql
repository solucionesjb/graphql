CREATE TABLE [dbo].[OpEventCampaign] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [CatCampaignId] INT NOT NULL,
    [CatEventId]    INT NOT NULL,
    [CatCycleId]    INT NOT NULL,
    CONSTRAINT [PK_EventConferences] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OpEventCampaign_CatCampaign] FOREIGN KEY ([CatCampaignId]) REFERENCES [dbo].[CatCampaign] ([Id]),
    CONSTRAINT [FK_OpEventCampaign_CatCycles] FOREIGN KEY ([CatCycleId]) REFERENCES [dbo].[CatCycles] ([Id]),
    CONSTRAINT [FK_OpEventCampaign_CatEvents] FOREIGN KEY ([CatEventId]) REFERENCES [dbo].[CatEvents] ([Id])
);

