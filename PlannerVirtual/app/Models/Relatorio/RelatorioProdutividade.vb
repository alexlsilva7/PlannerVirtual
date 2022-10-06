Public Class RelatorioProdutividade
    Inherits Relatorio

    Public Sub New(dataInicio As Date, dataFim As Date)
        MyBase.New(dataInicio, dataFim)
    End Sub

    Public Function calcularSemanasMaisProdutivas(intervalo As Integer) As Dictionary(Of String, Integer)

        If intervalo = 1 Then
            Return getSemanasMaisProdutivas(intervalo)
        ElseIf intervalo = 2 Then
            Return getMesesMaisProdutivos(intervalo)
        End If
        Return Nothing
    End Function

    Public Function calcularTurnosMaisProdutivos(intervalo As Integer) As Dictionary(Of String, Integer)

        If intervalo = 0 Then
            Return getTurnosMaisProdutivos(intervalo)
        ElseIf intervalo = 1 Then
            Return getTurnosMaisProdutivos(intervalo)
        ElseIf intervalo = 2 Then
            Return getTurnosMaisProdutivos(intervalo)
        End If
        Return Nothing
    End Function

    Public Function getTurnosMaisProdutivos(intervalo As Integer) As Dictionary(Of String, Integer)

        Dim turnosMaisProdutivos As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim tarefasExecutadas As List(Of Tarefa) = getTarefasExecutadas()

        For Each tarefa As Tarefa In tarefasExecutadas
            Dim turno As String = getTurno(tarefa)

            If Not turnosMaisProdutivos.ContainsKey(turno) Then
                turnosMaisProdutivos.Add(turno, 1)
            Else
                turnosMaisProdutivos(turno) += 1
            End If
        Next

        Return turnosMaisProdutivos
    End Function

    Public Function getTurno(tarefa As Tarefa) As String
        Dim turno As String = ""

        If tarefa.horarioInicio.Hour >= 8 And tarefa.horarioInicio.Hour < 12 Then
            turno = "Manhã"
        ElseIf tarefa.horarioInicio.Hour >= 12 And tarefa.horarioInicio.Hour < 18 Then
            turno = "Tarde"
        ElseIf tarefa.horarioInicio.Hour >= 18 And tarefa.horarioInicio.Hour < 22 Then
            turno = "Noite"
        ElseIf tarefa.horarioInicio.Hour >= 22 Or tarefa.horarioInicio.Hour < 8 Then
            turno = "Madrugada"
        End If

        Return turno
    End Function

    Public Function getSemana(tarefa As Tarefa) As String
        Dim semanaInicio As String = ""
        Dim semanaFim As String = ""

        Dim diaDaSemana = CInt(tarefa.horarioInicio.DayOfWeek)
        Dim diaMes = tarefa.horarioInicio.Day
        If diaMes < diaDaSemana + 1 Then
            semanaInicio = "1/" & tarefa.horarioInicio.Month & "/" & tarefa.horarioInicio.Year
        Else
            Dim inicioSemana = tarefa.horarioInicio.AddDays(-1 * diaDaSemana)
            semanaInicio = inicioSemana.Day & "/" & inicioSemana.Month & "/" & inicioSemana.Year
        End If

        If diaMes - tarefa.horarioInicio.DayOfWeek + 6 > getDiasMes(tarefa.horarioInicio) Then
            semanaFim = getDiasMes(tarefa.horarioInicio) & "/" & tarefa.horarioInicio.Month & "/" & tarefa.horarioInicio.Year
        Else
            Dim fimSemana = tarefa.horarioInicio.AddDays(6 - diaDaSemana)
            semanaFim = fimSemana.Day & "/" & fimSemana.Month & "/" & fimSemana.Year
        End If

        Return semanaInicio & " - " & semanaFim
    End Function

    Public Function getDiasMes(dia As Date) As Integer
        Dim diasMes As Integer = dia.Month

        If diasMes = 1 Or diasMes = 3 Or diasMes = 5 Or diasMes = 7 Or diasMes = 8 Or diasMes = 10 Or diasMes = 12 Then
            Return 31
        ElseIf diasMes = 4 Or diasMes = 6 Or diasMes = 9 Or diasMes = 11 Then
            Return 30
        ElseIf diasMes = 2 Then
            If dia.Year Mod 4 = 0 Then
                Return 29
            Else
                Return 28
            End If
        End If

        Return 0
    End Function

    Public Function getSemanasMaisProdutivas(intervalo As Integer) As Dictionary(Of String, Integer)

        Dim semanasMaisProdutivas As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim tarefasExecutadas As List(Of Tarefa) = getTarefasExecutadas()
        For Each tarefa As Tarefa In tarefasExecutadas
            Dim semana As String = getSemana(tarefa)

            If Not semanasMaisProdutivas.ContainsKey(semana) Then
                semanasMaisProdutivas.Add(semana, 1)
            Else
                semanasMaisProdutivas(semana) += 1
            End If
        Next

        Dim sorted = From pair In semanasMaisProdutivas
                     Order By pair.Value
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        Return sortedDictionary
    End Function

    Public Function getMesesMaisProdutivos(intervalo As Integer) As Dictionary(Of String, Integer)
        Dim mesesMaisProdutivos As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim tarefasExecutadas As List(Of Tarefa) = getTarefasExecutadas()

        For Each tarefa As Tarefa In tarefasExecutadas
            Dim mes As String = getMes(tarefa)

            If Not mesesMaisProdutivos.ContainsKey(mes) Then
                mesesMaisProdutivos.Add(mes, 1)
            Else
                mesesMaisProdutivos(mes) += 1
            End If
        Next

        Dim sorted = From pair In mesesMaisProdutivos
                     Order By pair.Value
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        Return sortedDictionary

    End Function

    Public Function getAnosMaisProdutivos(intervalo As Integer) As Dictionary(Of String, Integer)
        Dim anosMaisProdutivos As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim tarefasExecutadas As List(Of Tarefa) = getTarefasExecutadas()

        For Each tarefa As Tarefa In tarefasExecutadas
            Dim ano As String = getAno(tarefa)

            If Not anosMaisProdutivos.ContainsKey(ano) Then
                anosMaisProdutivos.Add(ano, 1)
            Else
                anosMaisProdutivos(ano) += 1
            End If
        Next

        Dim sorted = From pair In anosMaisProdutivos
                     Order By pair.Value
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        Return sortedDictionary
    End Function

    Public Function getAno(tarefa As Tarefa) As String
        Return tarefa.horarioInicio.Year
    End Function


    Public Function getMes(tarefa As Tarefa) As String
        Dim mes As String = ""

        If tarefa.horarioInicio.Month = 1 Then
            mes = "Janeiro"
        ElseIf tarefa.horarioInicio.Month = 2 Then
            mes = "Fevereiro"
        ElseIf tarefa.horarioInicio.Month = 3 Then
            mes = "Março"
        ElseIf tarefa.horarioInicio.Month = 4 Then
            mes = "Abril"
        ElseIf tarefa.horarioInicio.Month = 5 Then
            mes = "Maio"
        ElseIf tarefa.horarioInicio.Month = 6 Then
            mes = "Junho"
        ElseIf tarefa.horarioInicio.Month = 7 Then
            mes = "Julho"
        ElseIf tarefa.horarioInicio.Month = 8 Then
            mes = "Agosto"
        ElseIf tarefa.horarioInicio.Month = 9 Then
            mes = "Setembro"
        ElseIf tarefa.horarioInicio.Month = 10 Then
            mes = "Outubro"
        ElseIf tarefa.horarioInicio.Month = 11 Then
            mes = "Novembro"
        ElseIf tarefa.horarioInicio.Month = 12 Then
            mes = "Dezembro"
        End If

        Return mes
    End Function

End Class
