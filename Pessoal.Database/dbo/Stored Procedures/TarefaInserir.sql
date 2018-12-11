-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE TarefaInserir
@Nome nvarchar(100),
@Prioridade tinyint,
@Concluida bit,
@Observacoes nvarchar(1000)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Tarefa]
           ([Nome]
           ,[Prioridade]
           ,[Concluida]
           ,[Observacoes])
	 output inserted.Id	
     VALUES
           (@Nome 
           ,@Prioridade
           ,@Concluida
           ,@Observacoes)
END;
