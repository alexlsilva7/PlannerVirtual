Public Class Relatorio

    Protected _dataInicio As Date
    Protected _dataFim As Date
    Protected _tarefaDAO As ITarefaDAO
    Protected _metaDAO As IMetaDAO

    Public Property dataInicio() As Date
        Get
            Return _dataInicio
        End Get
        Set(value As Date)
            _dataInicio = value
        End Set
    End Property

    Public Property dataFim() As Date
        Get
            Return _dataFim
        End Get
        Set(value As Date)
            _dataFim = value
        End Set
    End Property

    Public Sub New(dataInicio As Date, dataFim As Date)
        _dataInicio = dataInicio
        _dataFim = dataFim
        _tarefaDAO = TarefaDAO.getSingletonObject
        _metaDAO = MetaDAO.getSingletonObject
    End Sub

    Public Function getTarefasExecutadas() As List(Of Tarefa)
        Dim tarefas As List(Of Tarefa) = _tarefaDAO.listarEntreDatas(_dataInicio, _dataFim)
        Dim tarefasExecutadas As List(Of Tarefa) = New List(Of Tarefa)

        For Each tarefa In tarefas
            If tarefa.estado = EstadoAtividade.executada Then
                tarefasExecutadas.Add(tarefa)
            End If
        Next

        Return tarefasExecutadas
    End Function
End Class
