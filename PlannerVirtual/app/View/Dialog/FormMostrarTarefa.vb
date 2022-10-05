Public Class FormMostrarTarefa
    Public tarefa As Tarefa

    Private _tarefaDAO As ITarefaDAO
    Private Sub FormMostrarTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tarefaDAO = TarefaDAO.getSingletonObject()

        inicializarLabels()
    End Sub

    Private Sub inicializarLabels()
        lblDescricao.Text = tarefa.descricao

        Select Case tarefa.duracao
            Case 30
                lblDuracao.Text = "30 min"
                lblData.Text = tarefa.horarioInicio.ToString("dd/MM/yyyy HH:mm")
            Case 60
                lblDuracao.Text = "1h"
                lblData.Text = tarefa.horarioInicio.ToString("dd/MM/yyyy HH:mm")
            Case 240
                If tarefa.horarioInicio.Hour = 8 Then
                    lblDuracao.Text = "De manhã (8h às 12h)"
                ElseIf tarefa.horarioInicio.Hour = 13 Then
                    lblDuracao.Text = "De tarde (13h às 17h)"
                ElseIf tarefa.horarioInicio.Hour = 18 Then
                    lblDuracao.Text = "De noite (18h às 22h)"
                End If
                lblData.Text = tarefa.horarioInicio.ToString("dd/MM/yyyy")
        End Select
        lblCategoria.Text = tarefa.categoria.nome
        lblCategoria.ForeColor = tarefa.categoria.cor
        Select Case tarefa.estado
            Case 0
                lblEstado.Text = "A executar"
            Case 1
                lblEstado.Text = "Parcialmente executada"
            Case 2
                lblEstado.Text = "Adiada"
            Case 3
                lblEstado.Text = "Executada"
        End Select
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim formAdicionarTarefa = New FormAdicionarTarefa
        formAdicionarTarefa.tarefa = tarefa
        formAdicionarTarefa.ShowDialog()
        tarefa = formAdicionarTarefa.tarefa

        inicializarLabels()
    End Sub

    Private Sub BtnApagar_Click(sender As Object, e As EventArgs) Handles BtnApagar.Click

        Dim result As DialogResult = MessageBox.Show("Deseja apagar a tarefa: " & tarefa.descricao & " ?", "Apagar Tarefa", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            _tarefaDAO.deletar(tarefa.id)
            Me.Close()
        End If
    End Sub
End Class