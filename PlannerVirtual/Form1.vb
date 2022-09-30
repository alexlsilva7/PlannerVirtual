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
End Class
