CREATE TABLE [dbo].[Sureste] (
    [Id]               INT     IDENTITY (1, 1) NOT NULL,
    [ContaminacionId]  INT     NOT NULL,
    [Ozono]            TINYINT NULL,
    [DioxidoAzufre]    TINYINT NULL,
    [DioxidoNitrogeno] TINYINT NULL,
    [MonoxidoCarbono]  TINYINT NULL,
    [Pm10]             TINYINT NULL,
    CONSTRAINT [PK_Sureste] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sureste_Contaminacion] FOREIGN KEY ([ContaminacionId]) REFERENCES [dbo].[Contaminacion] ([Id])
);

