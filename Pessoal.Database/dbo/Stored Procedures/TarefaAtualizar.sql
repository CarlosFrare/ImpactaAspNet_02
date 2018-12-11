-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE TarefaAtualizar
@Id int,
@Nome nvarchar(100),
@Prioridade tinyint,
@Concluida bit,
@Observacoes nvarchar(1000)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[Tarefa] 
	SET 
	 [Nome] = @Nome 
	,[Prioridade] = @Prioridade
	,[Concluida] = @Concluida
	,[Observacoes] = @Observacoes
	WHERE id = @Id;

END;
