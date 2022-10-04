Imports System.ComponentModel

Public Class FormTarefa
    Private _TarefaDAO As ITarefaDAO
    Dim dataInicioSemana As Date
    Dim dataFimSemana As Date
    Private Sub FormTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarSemana()
        _TarefaDAO = TarefaDAO.getSingletonObject
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
                Dim duracao As String
                Select Case tarefa.duracao
                    Case 30
                        duracao = "30 min"
                    Case 60
                        duracao = "1h"
                    Case 240
                        If tarefa.horarioInicio.Hour = 8 Then
                            duracao = "De manhã (8h às 12h)"
                        ElseIf tarefa.horarioInicio.Hour = 13 Then
                            duracao = "De tarde (13h às 17h)"
                        ElseIf tarefa.horarioInicio.Hour = 18 Then
                            duracao = "De noite (18h às 22h)"
                        End If
                End Select
                Dim item = New ListViewItem({tarefa.id.ToString, tarefa.descricao, tarefa.horarioInicio, duracao, tarefa.estado.ToString, tarefa.categoria.nome.ToString})
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
        carregaTarefas()
    End Sub

    Private Sub btnApagarTarefa_Click(sender As Object, e As EventArgs) Handles btnApagarTarefa.Click
        Dim result = apagarTarefa(listViewTarefas)
        If result Then carregaTarefas()
    End Sub

    Private Function apagarTarefa(listview As ListView) As Boolean
        If listview.SelectedItems.Count > 0 Then
            Dim descricaoSelecionada = listview.SelectedItems(0).SubItems(1).Text
            Dim idSelecionao = Integer.Parse(listview.SelectedItems(0).SubItems(0).Text)
            Dim result As DialogResult = MessageBox.Show("Deseja apagar a tarefa: " & descricaoSelecionada & " ?", "Apagar Tarefa", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return False
            ElseIf result = DialogResult.Yes Then
                _TarefaDAO.deletar(idSelecionao)
                Return True
            End If
        Else
            MsgBox("Selecione uma tarefa para apagar")
        End If
        Return False
    End Function

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(-7)
        dataFimSemana = dataFimSemana.AddDays(-7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregaTarefas()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(7)
        dataFimSemana = dataFimSemana.AddDays(7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregaTarefas()
    End Sub


    Private Sub btnIrSemanaAtual_Click(sender As Object, e As EventArgs) Handles btnIrSemanaAtual.Click
        inicializarSemana()
        carregaTarefas()
    End Sub

    Private Sub btnEditarTarefa_Click(sender As Object, e As EventArgs) Handles btnEditarTarefa.Click
        Dim result = editarTarefa(listViewTarefas, FormAdicionarTarefa.ComboBox2.SelectedItem)
        If result Then carregaTarefas()
    End Sub

    Private Function editarTarefa(listview As ListView, Estado As EstadoAtividade) As Boolean
        If listview.SelectedItems.Count > 0 Then
            Dim formAdicionarTarefa = New FormAdicionarTarefa
            formAdicionarTarefa.ComboBox2.SelectedItem = Estado
            formAdicionarTarefa.tarefa = _TarefaDAO.consultar(Integer.Parse(listview.SelectedItems(0).SubItems(0).Text))
            formAdicionarTarefa.ShowDialog()
            Return True
        Else
            MsgBox("Selecione uma tarefa para editar")
        End If
        Return False
    End Function

    Private Sub listViewTarefas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewTarefas.SelectedIndexChanged

    End Sub
End Class