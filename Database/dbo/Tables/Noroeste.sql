CREATE TABLE [dbo].[Noroeste] (
    [Id]               INT     IDENTITY (1, 1) NOT NULL,
    [ContaminacionId]  INT     NOT NULL,
    [Ozono]            TINYINT NULL,
    [DioxidoAzufre]    TINYINT NULL,
    [DioxidoNitrogeno] TINYINT NULL,
    [MonoxidoCarbono]  TINYINT NULL,
    [Pm10]             TINYINT NULL,
    CONSTRAINT [PK_Noroeste] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Noroeste_Contaminacion] FOREIGN KEY ([ContaminacionId]) REFERENCES [dbo].[Contaminacion] ([Id])
);

