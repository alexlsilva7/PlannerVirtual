Imports System.Data.SQLite
Imports System.Reflection
Imports System.Resources.ResXFileRef

Public Class Form1
    Private _categoriaDAO As ICategoriaDAO

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTelaCategorias_Click(sender As Object, e As EventArgs) Handles btnTelaCategorias.Click
        'Abre o formulario em paralelo com o outro
        'FormCategoria.Show()

        'Abre um dialog que espera pra ser fechado
        'FormCategoria.ShowDialog()

        'Forma moderna, pegando o retorno do formulario
        Dim formCategoria As New FormCategoria
        Dim dialogResult = formCategoria.ShowDialog()
        MsgBox("result: " + formCategoria.result)

    End Sub

    Private Sub btnSelecionarCategoriaDialog_Click(sender As Object, e As EventArgs) Handles btnSelecionarCategoriaDialog.Click
        Dim formSelecionarCategoria As FormSelecionarCategoria = New FormSelecionarCategoria()
        formSelecionarCategoria.ShowDialog()
        Dim resultado = formSelecionarCategoria.result
        If IsNothing(resultado) Then
            MsgBox("Resultado do dialog: NOTHING")
        Else
            MsgBox("Resultado do dialog: Categoria: " + resultado.nome)
        End If
    End Sub

    Private Sub btnTelaLembretes_Click(sender As Object, e As EventArgs) Handles btnTelaLembretes.Click
        Dim formLembrete As New FormLembrete
        Dim result = formLembrete.ShowDialog()
    End Sub

    Private Sub btnTarefas_Click(sender As Object, e As EventArgs) Handles btnTarefas.Click
        Dim formTarefa As New FormTarefa
        Dim result = formTarefa.ShowDialog()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim formHome As New FormHome
        Dim result = formHome.ShowDialog()
    End Sub

    Private Sub btnSemana_Click(sender As Object, e As EventArgs) Handles btnSemana.Click
        Dim formSemana As New FormExibicaoSemanal
        Dim result = formSemana.ShowDialog()
    End Sub
End Class
