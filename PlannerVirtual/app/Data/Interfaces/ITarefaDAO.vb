Public Interface ITarefaDAO

    Sub inserir(ByVal tarefa As Tarefa)
    Sub deletar(ByVal id As Integer)
    Function listar() As List(Of Tarefa)
    Function listarEntreDatas(ByVal dataInicial As Date, ByVal dataFinal As Date) As List(Of Tarefa)
    Function consultar(ByVal id As Integer) As Tarefa

    Sub atualizar(ByVal tarefa As Tarefa)
    Function getTarefasByEstado(tipoLembrete As EstadoAtividade) As List(Of Tarefa)
End Interface
