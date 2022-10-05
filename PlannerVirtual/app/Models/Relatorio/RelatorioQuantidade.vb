Public Class RelatorioQuantidade
    Inherits Relatorio

    Public Sub New(dataInicio As Date, dataFim As Date)
        MyBase.New(dataInicio, dataFim)
    End Sub

    Public Function calcularQuantidadeTarefasExecutadas() As Integer
        Dim tarefas As List(Of Tarefa) = getTarefasExecutadas()
        Return tarefas.Count
    End Function

    Public Function calcularQuantidadeMetasCumpridas() As Integer
        Dim metas As List(Of Meta) = getMetasCumpridas()
        Return metas.Count
    End Function

    Public Function calcularPorcentagemTarefasExecutadas() As Double
        Return calcularQuantidadeTarefasExecutadas() / getQuantidadeDeTarefas()
    End Function

    Public Function calcularPorcentagemMetasCumpridas() As Double
        Return calcularQuantidadeMetasCumpridas() / getQuantidadeDeMetas()
    End Function
End Class
