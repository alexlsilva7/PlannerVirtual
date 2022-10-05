Public Class RelatorioMaisRealizadas
    Inherits Relatorio

    Public Sub New(dataInicio As Date, dataFim As Date)
        MyBase.New(dataInicio, dataFim)
    End Sub

    Public Function calcularCategoriasMaisRealizadas(tipo As Integer) As Dictionary(Of String, Integer)


        Dim categoriasMaisRealizadas As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

        Select Case tipo
            Case 0 'Categorias mais realizadas de Tarefas
                Dim tarefasExecutadas As List(Of Tarefa) = getTarefasExecutadas()
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
            Case 1 'Categorias Mais Realizadas de Metas
                Dim metasCumpridas As List(Of Meta) = getMetasCumpridas()
                For Each metas As Meta In metasCumpridas
                    If categoriasMaisRealizadas.ContainsKey(metas.categoria.nome) Then
                        categoriasMaisRealizadas(metas.categoria.nome) += 1
                    Else
                        categoriasMaisRealizadas.Add(metas.categoria.nome, 1)
                    End If
                Next

                Dim sorted = From pair In categoriasMaisRealizadas
                             Order By pair.Value Descending
                Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

                Return sortedDictionary
        End Select

        Return Nothing
    End Function
End Class
