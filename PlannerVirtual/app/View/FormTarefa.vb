Public Class FormTarefa
    Private _TarefaDAO As ITarefaDAO
    Dim dataInicioSemana As Date
    Dim dataFimSemana As Date
    Private Sub FormTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarSemana()
        _TarefaDAO = TarefaDAO.getSingletonObject
        carregarTodasTarefas()
    End Sub

    Private Sub carregarTodasTarefas()
        carregaTarefas()
    End Sub

    Private Sub carregaTarefas()
        'limpar listview
        listViewTarefas.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Tarefa) = _TarefaDAO.getTarefasByEstado(EstadoAtividade.aExecutar)

        'Pega os lembretes da semana
        Dim listaSemana = lista.FindAll(
                Function(tarefa)
                    Return tarefa.horarioInicio >= dataInicioSemana And tarefa.horarioInicio <= dataFimSemana
                End Function
            )

        'Preencher o listview
        Try
            For Each tarefa As Tarefa In listaSemana
                Dim item = New ListViewItem({tarefa.id.ToString, tarefa.descricao, tarefa.horarioInicio, tarefa.duracao, tarefa.estado, tarefa.categoria.ToString})
                listViewTarefas.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub inicializarSemana()
        Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
        dataInicioSemana = DateTime.Today.AddDays(-1 * diaDaSemana)
        dataFimSemana = DateTime.Today.AddDays(7 - diaDaSemana).AddSeconds(-1)

        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btnAddTarefa_Click(sender As Object, e As EventArgs) Handles btnAddTarefa.Click
        Dim formAdicionarTarefa As New FormAdicionarTarefa
        formAdicionarTarefa.ShowDialog()
        carregarTodasTarefas()
    End Sub

    Private Sub btnApagarTarefa_Click(sender As Object, e As EventArgs) Handles btnApagarTarefa.Click

    End Sub


    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(-7)
        dataFimSemana = dataFimSemana.AddDays(-7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarTodasTarefas()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(7)
        dataFimSemana = dataFimSemana.AddDays(7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarTodasTarefas()
    End Sub


    Private Sub btnIrSemanaAtual_Click(sender As Object, e As EventArgs) Handles btnIrSemanaAtual.Click
        inicializarSemana()
        carregarTodasTarefas()
    End Sub

    Private Sub btnEditarTarefa_Click(sender As Object, e As EventArgs) Handles btnEditarTarefa.Click
        Dim formEditarTarefa As New FormAdicionarTarefa
        formEditarTarefa.ShowDialog()
        carregarTodasTarefas()
    End Sub
End Class