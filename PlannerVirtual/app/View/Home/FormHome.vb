Public Class FormHome

    Private listFlowLayoutDay As New List(Of FlowLayoutPanel)

    Private dataAtual As DateTime = DateTime.Today

    Dim _tarefaDAO As TarefaDAO

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tarefaDAO = TarefaDAO.getSingletonObject()
        GerarDias(42)
        MostrarDatas()
    End Sub

    Private Sub GerarDias(ByVal totalDias As Integer)
        flDays.Controls.Clear()
        listFlowLayoutDay.Clear()
        For i As Integer = 1 To totalDias
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(128, 99)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf AddNovaTarefa
            flDays.Controls.Add(fl)
            listFlowLayoutDay.Add(fl)
        Next
    End Sub

    Private Sub MostrarDatas()
        lblMonthAndYear.Text = dataAtual.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetDiaDaSemanaDoPrimeiroDiaMesAtual()
        Dim totalDay As Integer = GetTotalDiasMesAtual()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddTarefaToFlDay(firstDayAtFlNumber)
    End Sub

    Private Function GetDiaDaSemanaDoPrimeiroDiaMesAtual() As Integer
        Dim primeiroDiadoMes As DateTime = New Date(dataAtual.Year, dataAtual.Month, 1)
        Return primeiroDiadoMes.DayOfWeek + 1
    End Function

    Private Function GetTotalDiasMesAtual() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(dataAtual.Year, dataAtual.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlowLayoutDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlowLayoutDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlowLayoutDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            'Define a cor do dia atual
            If New Date(dataAtual.Year, dataAtual.Month, i) = Date.Today Then
                listFlowLayoutDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Lavender
            End If
        Next
    End Sub

    Private Sub btnVoltarMes_Click(sender As Object, e As EventArgs) Handles btnVoltarMes.Click
        dataAtual = dataAtual.AddMonths(-1)
        MostrarDatas()
    End Sub

    Private Sub btnAvancarMes_Click(sender As Object, e As EventArgs) Handles btnAvancarMes.Click
        dataAtual = dataAtual.AddMonths(1)
        MostrarDatas()
    End Sub

    Private Sub btnMesAtual_Click(sender As Object, e As EventArgs) Handles btnMesAtual.Click
        dataAtual = DateTime.Today
        MostrarDatas()
    End Sub

    Private Sub AddTarefaToFlDay(ByVal diaInicialNoFlowPanel As Integer)
        Dim dataInicial As DateTime = New Date(dataAtual.Year, dataAtual.Month, 1)
        Dim dataFinal As DateTime = dataInicial.AddMonths(1).AddDays(-1)

        'Pegar tarefas do inicio ao fim
        Dim listaTarefas As List(Of Tarefa) = _tarefaDAO.listarEntreDatas(dataInicial, dataFinal)

        For Each tarefa As Tarefa In listaTarefas
            Dim link As New LinkLabel
            link.Tag = tarefa.id
            link.Name = $"link{tarefa.id}"
            link.Text = tarefa.descricao
            AddHandler link.Click, AddressOf ExibirDetalhesTarefa
            link.LinkColor = tarefa.categoria.cor
            link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            listFlowLayoutDay((tarefa.horarioInicio.Day - 1) + (diaInicialNoFlowPanel - 1)).Controls.Add(link)
        Next
    End Sub

    Private Sub AddNovaTarefa(ByVal sender As Object, e As EventArgs)
        Dim dia As Integer = CType(sender, FlowLayoutPanel).Tag
        If dia <> 0 Then
            'TODO setar data do form
            Dim form As New FormAdicionarTarefa
            form.ShowDialog()
            MostrarDatas()
        End If
    End Sub

    Private Sub ExibirDetalhesTarefa(sender As Object, e As EventArgs)
        Dim id As Integer = CType(sender, LinkLabel).Tag
        Dim tarefa = _tarefaDAO.consultar(id)
        'TODO ABRIR TELA PERSONALIZADA DE DELTALHES
        MsgBox("Tarefa: " & tarefa.descricao)
        MostrarDatas()
    End Sub

End Class