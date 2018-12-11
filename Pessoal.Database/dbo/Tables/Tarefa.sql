CREATE TABLE [dbo].[Tarefa] (
    [id]          INT             IDENTITY (1, 1) NOT NULL,
    [Nome]        NVARCHAR (100)  NULL,
    [Prioridade]  TINYINT         NULL,
    [Concluida]   BIT             NULL,
    [Observacoes] NVARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

