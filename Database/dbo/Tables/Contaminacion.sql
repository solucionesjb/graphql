CREATE TABLE [dbo].[Contaminacion] (
    [Id]    INT     IDENTITY (1, 1) NOT NULL,
    [Fecha] DATE    NOT NULL,
    [Hora]  TINYINT NOT NULL,
    CONSTRAINT [PK_Contamination] PRIMARY KEY CLUSTERED ([Id] ASC)
);

