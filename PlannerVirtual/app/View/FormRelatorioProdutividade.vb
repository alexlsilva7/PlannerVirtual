Public Class FormRelatorioProdutividade

    Dim dataInicio As Date
    Dim dataFim As Date

    Enum IntervaloTempo
        Semana
        Mes
    End Enum

    Private Sub FormRelatorioProdutividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbIntervaloTempo.SelectedIndex = IntervaloTempo.Semana
        inicializar()
        PopularGrafico()
    End Sub

    Private Sub inicializar()
        Select Case cbIntervaloTempo.SelectedIndex
            Case IntervaloTempo.Semana
                Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
                dataInicio = DateTime.Today.AddDays(-1 * diaDaSemana)
                dataFim = DateTime.Today.AddDays(7 - diaDaSemana).AddSeconds(-1)
            Case IntervaloTempo.Mes
                dataInicio = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
                dataFim = dataInicio.AddMonths(1).AddSeconds(-1)
        End Select
    End Sub

    Private Function CriarRelatorio() As Dictionary(Of String, Integer)
        Dim relatorio As RelatorioProdutividade = New RelatorioProdutividade(dataInicio, dataFim)

        Return relatorio.calcularTurnosMaisProdutivos()
    End Function

    Private Sub PopularGrafico()
        Dim turnosMaisProdutivos As Dictionary(Of String, Integer) = CriarRelatorio()

        Dim i As Integer = 0
        For Each turno As KeyValuePair(Of String, Integer) In turnosMaisProdutivos
            ChartTurnos.Series("Turnos").Points.AddXY(turno.Key & "\n(" & turno.Value.ToString & ")", turno.Value)
            ChartTurnos.Series("Turnos").Points(i).LegendText = turno.Key
            ChartTurnos.Series("Turnos").Points(i).LabelForeColor = Color.FromArgb(255, 255, 255)
            i += 1
        Next
    End Sub
End Class