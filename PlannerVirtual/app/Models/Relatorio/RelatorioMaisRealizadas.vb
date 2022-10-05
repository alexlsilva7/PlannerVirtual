Public Class RelatorioMaisRealizadas
    Inherits Relatorio

    Public Sub New(dataInicio As Date, dataFim As Date)
        MyBase.New(dataInicio, dataFim)
    End Sub

    Public Function calcularCategoriasMaisRealizadas() As Dictionary(Of String, Integer)
        Dim tarefasExecutadas As List(Of Tarefa) = getTarefasExecutadas()
        Dim categoriasMaisRealizadas As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

        For Each tarefa As Tarefa In tarefasExecutadas
            If categoriasMaisRealizadas.ContainsKey(tarefa.categoria.nome) Then
                categoriasMaisRealizadas(tarefa.categoria.nome) += 1
            Else
                categoriasMaisRealizadas.Add(tarefa.categoria.nome, 1)
            End If
        Next

        Dim sorted = From pair In categoriasMaisRealizadas
                     Order By pair.Value Descending
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        Return sortedDictionary
    End Function
End Class
