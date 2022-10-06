Imports System.ComponentModel

Public Class FormTarefa
    Private _TarefaDAO As ITarefaDAO
    Dim dataInicioSemana As Date
    Dim dataFimSemana As Date
    Private Sub FormTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarSemana()
        _TarefaDAO = TarefaDAO.getSingletonObject
        inicializarFiltros()
        carregaTarefas()
    End Sub

    Private Sub inicializarFiltros()
        Dim categoriasLista = CategoriaDAO.getSingletonObject().listar()
        cbFiltroCategoria.Items.Add("Todas")

        For Each item In categoriasLista
            cbFiltroCategoria.Items.Add(item.nome)
        Next
        cbFiltroCategoria.SelectedIndex = 0

        Dim estados As Array
        estados = System.Enum.GetValues(GetType(EstadoAtividade))

        cbFiltroEstado.Items.Add("Todos")

        For Each item In estados
            cbFiltroEstado.Items.Add(item)
        Next
        cbFiltroEstado.SelectedIndex = 0

    End Sub
    Private Sub carregarSegunda()
        carregaListView(listViewSegunda, DayOfWeek.Monday)
        lblDay2.Text = dataInicioSemana.AddDays(1).ToString("dd")
    End Sub

    Private Sub carregarTerca()
        carregaListView(listViewTerca, DayOfWeek.Tuesday)
        lblDay3.Text = dataInicioSemana.AddDays(2).ToString("dd")
    End Sub

    Private Sub carregarQuarta()
        carregaListView(listViewQuarta, DayOfWeek.Wednesday)
        lblDay4.Text = dataInicioSemana.AddDays(3).ToString("dd")
    End Sub

    Private Sub carregarQuinta()
        carregaListView(listViewQuinta, DayOfWeek.Thursday)
        lblDay5.Text = dataInicioSemana.AddDays(4).ToString("dd")
    End Sub

    Private Sub carregarSexta()
        carregaListView(listViewSexta, DayOfWeek.Friday)
        lblDay6.Text = dataInicioSemana.AddDays(5).ToString("dd")
    End Sub

    Private Sub carregarSabado()
        carregaListView(listViewSabado, DayOfWeek.Saturday)
        lblDay7.Text = dataInicioSemana.AddDays(6).ToString("dd")
    End Sub

    Private Sub carregarDomingo()
        carregaListView(listViewDomingo, DayOfWeek.Sunday)
        lblDay1.Text = dataInicioSemana.ToString("dd")
    End Sub

    Private Sub carregaListView(listView As ListView, dayOfWeek As DayOfWeek)
        'limpar listview
        listView.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Tarefa) = _TarefaDAO.listar()

        'Pega os lembretes da semana
        Dim listaSemana = lista.FindAll(
                Function(tarefa)
                    Return tarefa.horarioInicio >= dataInicioSemana And tarefa.horarioInicio <= dataFimSemana And tarefa.horarioInicio.DayOfWeek = dayOfWeek
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
                Dim item = New ListViewItem({tarefa.descricao})
                If (tarefa.estado = EstadoAtividade.executada) Then
                    item.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Strikeout)
                End If
                item.ForeColor = tarefa.categoria.cor

                'Filtros
                If (cbFiltroCategoria.SelectedIndex > 0) Then
                    If (cbFiltroCategoria.SelectedItem.ToString <> tarefa.categoria.nome) Then
                        Continue For
                    End If
                End If

                If (cbFiltroEstado.SelectedIndex > 0) Then
                    If (cbFiltroEstado.SelectedItem.ToString <> tarefa.estado.ToString) Then
                        Continue For
                    End If
                End If


                listView.Items.Add(item)

            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub carregaTarefas()
        carregarDomingo()
        carregarSegunda()
        carregarTerca()
        carregarQuarta()
        carregarQuinta()
        carregarSexta()
        carregarSabado()
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


    Private Sub cbFiltroCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroCategoria.SelectedIndexChanged
        carregaTarefas()
    End Sub

    Private Sub cbFiltroEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroEstado.SelectedIndexChanged
        carregaTarefas()
    End Sub



    Private Sub listViewDomingo_Click(sender As Object, e As EventArgs) Handles listViewDomingo.Click
        If listViewDomingo.SelectedItems.Count > 0 Then
            Dim tarefaDescricao = listViewDomingo.SelectedItems(0).Text
            Dim tarefa As Tarefa = _TarefaDAO.listar().Find(Function(t) t.descricao = tarefaDescricao)
            Dim form As New FormMostrarTarefa
            form.tarefa = tarefa
            form.ShowDialog()
            carregarDomingo()
        End If
    End Sub

    Private Sub listViewSegunda_Click(sender As Object, e As EventArgs) Handles listViewSegunda.Click
        If listViewSegunda.SelectedItems.Count > 0 Then
            Dim tarefaDescricao = listViewSegunda.SelectedItems(0).Text
            Dim tarefa As Tarefa = _TarefaDAO.listar().Find(Function(t) t.descricao = tarefaDescricao)
            Dim form As New FormMostrarTarefa
            form.tarefa = tarefa
            form.ShowDialog()
            carregarSegunda()
        End If
    End Sub

    Private Sub listViewTerca_Click(sender As Object, e As EventArgs) Handles listViewTerca.Click
        If listViewTerca.SelectedItems.Count > 0 Then
            Dim tarefaDescricao = listViewTerca.SelectedItems(0).Text
            Dim tarefa As Tarefa = _TarefaDAO.listar().Find(Function(t) t.descricao = tarefaDescricao)
            Dim form As New FormMostrarTarefa
            form.tarefa = tarefa
            form.ShowDialog()
            carregarTerca()
        End If
    End Sub

    Private Sub listViewQuarta_Click(sender As Object, e As EventArgs) Handles listViewQuarta.Click
        If listViewQuarta.SelectedItems.Count > 0 Then
            Dim tarefaDescricao = listViewQuarta.SelectedItems(0).Text
            Dim tarefa As Tarefa = _TarefaDAO.listar().Find(Function(t) t.descricao = tarefaDescricao)
            Dim form As New FormMostrarTarefa
            form.tarefa = tarefa
            form.ShowDialog()
            carregarQuarta()
        End If
    End Sub

    Private Sub listViewQuinta_Click(sender As Object, e As EventArgs) Handles listViewQuinta.Click
        If listViewQuinta.SelectedItems.Count > 0 Then
            Dim tarefaDescricao = listViewQuinta.SelectedItems(0).Text
            Dim tarefa As Tarefa = _TarefaDAO.listar().Find(Function(t) t.descricao = tarefaDescricao)
            Dim form As New FormMostrarTarefa
            form.tarefa = tarefa
            form.ShowDialog()
            carregarQuinta()
        End If
    End Sub

    Private Sub listViewSexta_Click(sender As Object, e As EventArgs) Handles listViewSexta.Click
        If listViewSexta.SelectedItems.Count > 0 Then
            Dim tarefaDescricao = listViewSexta.SelectedItems(0).Text
            Dim tarefa As Tarefa = _TarefaDAO.listar().Find(Function(t) t.descricao = tarefaDescricao)
            Dim form As New FormMostrarTarefa
            form.tarefa = tarefa
            form.ShowDialog()
            carregarSexta()
        End If
    End Sub

    Private Sub listViewSabado_Click(sender As Object, e As EventArgs) Handles listViewSabado.Click
        If listViewSabado.SelectedItems.Count > 0 Then
            Dim tarefaDescricao = listViewSabado.SelectedItems(0).Text
            Dim tarefa As Tarefa = _TarefaDAO.listar().Find(Function(t) t.descricao = tarefaDescricao)
            Dim form As New FormMostrarTarefa
            form.tarefa = tarefa
            form.ShowDialog()
            carregarSabado()
        End If
    End Sub


End Class