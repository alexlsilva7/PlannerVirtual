Public Class FormRelatorioQuantidade
    Dim dataInicio As Date
    Dim dataFim As Date

    Enum IntervaloTempo
        Semana
        Mes
        Ano
    End Enum

    Private Sub FormRelatorioQuantidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbIntervaloTempo.SelectedIndex = IntervaloTempo.Semana
        cbTipoRelatorio.SelectedIndex = 0
        cbIntervaloTempo.DropDownStyle = ComboBoxStyle.DropDownList
        cbTipoRelatorio.DropDownStyle = ComboBoxStyle.DropDownList
        inicializar()
        PreencherListView()
    End Sub

    Private Function CriarRelatorio(tipo As Integer) As Double()
        Dim relatorio As RelatorioQuantidade = New RelatorioQuantidade(dataInicio, dataFim)
        Select Case tipo
            Case 0
                Dim quantidadeTarefas As Double = CDbl(relatorio.getQuantidadeDeTarefas())
                Dim quantidadeTarefasExecutadas As Double = CDbl(relatorio.calcularQuantidadeTarefasExecutadas())
                Dim porcentagem As Double = CDbl(relatorio.calcularPorcentagemTarefasExecutadas * 100)
                Dim vetorQuantidade = New Double() {quantidadeTarefas, quantidadeTarefasExecutadas, porcentagem}
                Return vetorQuantidade
            Case 1
                Dim quantidadeMetas As Double = CDbl(Relatorio.getQuantidadeDeMetas())
                Dim quantidadeMetasCumpridas As Double = CDbl(Relatorio.calcularQuantidadeMetasCumpridas())
                Dim porcentagem As Double = CDbl(Relatorio.calcularPorcentagemMetasCumpridas * 100)
                Dim vetorQuantidade = New Double() {quantidadeMetas, quantidadeMetasCumpridas, porcentagem}
                Return vetorQuantidade
        End Select

        Return Nothing
    End Function

    Private Sub inicializar()
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
                dataInicio = DateTime.Today.AddDays(-1 * diaDaSemana)
                dataFim = DateTime.Today.AddDays(7 - diaDaSemana).AddSeconds(-1)
            Case IntervaloTempo.Mes
                dataInicio = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
                dataFim = dataInicio.AddMonths(1).AddSeconds(-1)
            Case IntervaloTempo.Ano
                dataInicio = New DateTime(DateTime.Today.Year, 1, 1)
                dataFim = dataInicio.AddYears(1).AddSeconds(-1)
        End Select

        ChangeLabelText()
    End Sub

    Private Sub ChangeLabelText()
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                lblSemana.Text = dataInicio.ToString("dd/MM/yyyy") & " - " & dataFim.ToString("dd/MM/yyyy")
            Case IntervaloTempo.Mes
                lblSemana.Text = dataInicio.ToString("MMMM/yyyy")
            Case IntervaloTempo.Ano
                lblSemana.Text = dataInicio.ToString("yyyy")
        End Select

        Select Case cbTipoRelatorio.SelectedIndex
            Case 0
                lblTipoRelatorio.Text = "Quantidade de Tarefas Executadas"
            Case 1
                lblTipoRelatorio.Text = "Quantidade de Metas Cumpridas"
        End Select
    End Sub

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        AlterarIntervaloTempo(-1)
        PreencherListView()
        ChangeLabelText()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        AlterarIntervaloTempo(1)
        PreencherListView()
        ChangeLabelText()
    End Sub

    Private Sub PreencherListView()
        ListViewRelatorio.Items.Clear()
        Dim relatorioQuantidade() As Double = CriarRelatorio(cbTipoRelatorio.SelectedIndex)
        Dim item = New ListViewItem({relatorioQuantidade.GetValue(0), relatorioQuantidade.GetValue(1), FormatNumber(relatorioQuantidade.GetValue(2).ToString, 2) + "%"})
        ListViewRelatorio.Items.Add(item)
    End Sub

    Private Sub AlterarIntervaloTempo(multiplicador)
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                dataInicio = dataInicio.AddDays(7 * multiplicador)
                dataFim = dataFim.AddDays(7 * multiplicador)
            Case IntervaloTempo.Mes
                dataInicio = dataInicio.AddMonths(multiplicador)
                dataFim = dataFim.AddMonths(multiplicador)
            Case IntervaloTempo.Ano
                dataInicio = dataInicio.AddYears(multiplicador)
                dataFim = dataFim.AddYears(multiplicador)
        End Select
    End Sub


    Private Sub btnIrSemanaAtual_Click(sender As Object, e As EventArgs) Handles btnIrSemanaAtual.Click
        inicializar()
        PreencherListView()
    End Sub

    Private Sub cbIntervaloTempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntervaloTempo.SelectedIndexChanged
        ChangeLabelText()
    End Sub

    Private Sub cbTipoRelatorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoRelatorio.SelectedIndexChanged
        ChangeLabelText()
        PreencherListView()
    End Sub

End Class