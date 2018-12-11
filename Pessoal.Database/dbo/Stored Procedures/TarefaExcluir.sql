-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE TarefaExcluir 
@Id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM [dbo].[Tarefa]
    WHERE id = @Id;

END
