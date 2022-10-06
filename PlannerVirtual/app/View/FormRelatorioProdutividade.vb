Public Class FormRelatorioProdutividade

    Dim dataInicio As Date
    Dim dataFim As Date

    Enum TipoRelatorio
        Turno
        Semana
        Mes
    End Enum

    Private Sub FormRelatorioProdutividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbIntervaloTempo.SelectedIndex = 0 'IntervaloTempo.Semana
        inicializar()
        PopularGraficoTurnos()
        PopularGraficoSemanas()
    End Sub

    Private Sub inicializar()
        Select Case cbIntervaloTempo.SelectedIndex
            Case 0
                Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
                dataInicio = DateTime.Today.AddDays(-1 * diaDaSemana * 50)
                dataFim = DateTime.Today.AddDays(50).AddSeconds(-1)
            Case 1
                dataInicio = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
                dataFim = dataInicio.AddMonths(1).AddSeconds(-1)
        End Select
    End Sub

    Private Function CriarRelatorio(tipo As Integer) As Dictionary(Of String, Integer)
        Dim relatorio As RelatorioProdutividade = New RelatorioProdutividade(dataInicio, dataFim)
        Select Case tipo
            Case TipoRelatorio.Turno
                Return relatorio.calcularTurnosMaisProdutivos()
            Case TipoRelatorio.Semana
                Return relatorio.calcularSemanasMaisProdutivas()
            Case TipoRelatorio.Mes
                'Return relatorio.getProdutividadePorMes()
        End Select
        Return relatorio.calcularTurnosMaisProdutivos()
    End Function

    Private Sub PopularGraficoTurnos()
        Dim turnosMaisProdutivos As Dictionary(Of String, Integer) = CriarRelatorio(TipoRelatorio.Turno)

        Dim i As Integer = 0
        For Each turno As KeyValuePair(Of String, Integer) In turnosMaisProdutivos
            ChartTurnos.Series("Turnos").Points.AddXY(turno.Key & "\n(" & turno.Value.ToString & ")", turno.Value)
            ChartTurnos.Series("Turnos").Points(i).LegendText = turno.Key
            ChartTurnos.Series("Turnos").Points(i).LabelForeColor = Color.FromArgb(255, 255, 255)
            i += 1
        Next
    End Sub

    Private Sub PopularGraficoSemanas()
        Dim semanasMaisProdutivas As Dictionary(Of String, Integer) = CriarRelatorio(TipoRelatorio.Semana)

        Dim i As Integer = 0
        For Each semana As KeyValuePair(Of String, Integer) In semanasMaisProdutivas
            ChartSemanas.Series("Semanas").Points.AddXY(semana.Key, semana.Value)
            ChartSemanas.Series("Semanas").Points(i).LegendText = semana.Key
            ChartSemanas.Series("Semanas").Points(i).LabelForeColor = Color.FromArgb(255, 255, 255)
            i += 1
        Next
    End Sub
End Class