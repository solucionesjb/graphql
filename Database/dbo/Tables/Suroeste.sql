CREATE TABLE [dbo].[Suroeste] (
    [Id]               INT     IDENTITY (1, 1) NOT NULL,
    [ContaminacionId]  INT     NOT NULL,
    [Ozono]            TINYINT NULL,
    [DioxidoAzufre]    TINYINT NULL,
    [DioxidoNitrogeno] TINYINT NULL,
    [MonoxidoCarbono]  TINYINT NULL,
    [Pm10]             TINYINT NULL,
    CONSTRAINT [PK_Suroeste] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Suroeste_Contaminacion] FOREIGN KEY ([ContaminacionId]) REFERENCES [dbo].[Contaminacion] ([Id])
);

