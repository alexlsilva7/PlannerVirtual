Public Class RelatorioProdutividade
    Inherits Relatorio

    Public Sub New(dataInicio As Date, dataFim As Date)
        MyBase.New(dataInicio, dataFim)
    End Sub

    Public Function calcularTurnosMaisProdutivos() As Dictionary(Of String, Integer)

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
End Class
