-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE TarefaSelecionar
@Id int = null
AS
BEGIN
	SET NOCOUNT ON;

	IF @Id IS NULL 
		SELECT [id]
		  ,[Nome]
		  ,[Prioridade]
		  ,[Concluida]
		  ,[Observacoes]
		FROM [Pessoal].[dbo].[Tarefa]
		ORDER BY Concluida, Prioridade
	ELSE
		SELECT [id]
		  ,[Nome]
		  ,[Prioridade]
		  ,[Concluida]
		  ,[Observacoes]
		FROM [Pessoal].[dbo].[Tarefa]
		WHERE id = @id
		ORDER BY Concluida, Prioridade
END
