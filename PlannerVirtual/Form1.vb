Imports System.Data.SQLite
Imports System.Net.Http
Imports System.Reflection
Imports System.Resources.ResXFileRef

Public Class Form1
    Private _categoriaDAO As ICategoriaDAO

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Sub LoadHome()
        Dim formHome As New FormExibirMensal()
        formHome.Show()
    End Sub
    Private Sub btnTelaCategorias_Click(sender As Object, e As EventArgs)
        'Abre o formulario em paralelo com o outro
        'FormCategoria.Show()

        'Abre um dialog que espera pra ser fechado
        'FormCategoria.ShowDialog()

        'Forma moderna, pegando o retorno do formulario
        Dim formCategoria As New FormCategoria
        Dim dialogResult = formCategoria.ShowDialog()
        MsgBox("result: " + formCategoria.result)

    End Sub

    Private Sub btnSelecionarCategoriaDialog_Click(sender As Object, e As EventArgs)
        Dim formSelecionarCategoria As FormSelecionarCategoria = New FormSelecionarCategoria()
        formSelecionarCategoria.ShowDialog()
        Dim resultado = formSelecionarCategoria.result
        If IsNothing(resultado) Then
            MsgBox("Resultado do dialog: NOTHING")
        Else
            MsgBox("Resultado do dialog: Categoria: " + resultado.nome)
        End If
    End Sub

    Private Sub btnTelaLembretes_Click(sender As Object, e As EventArgs)
        Dim formLembrete As New FormLembrete
        Dim result = formLembrete.ShowDialog()
    End Sub

    Private Sub btnTelaMetas_Click(sender As Object, e As EventArgs)
        Dim formMetas As New FormMeta
        Dim result = formMetas.ShowDialog()
    End Sub

    Private Sub btnTarefas_Click(sender As Object, e As EventArgs)
        Dim formTarefa As New FormTarefa
        Dim result = formTarefa.ShowDialog()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        Dim formHome As New FormExibirMensal
        Dim result = formHome.ShowDialog()
    End Sub

    Private Sub btnSemana_Click(sender As Object, e As EventArgs) Handles btnSemana.Click
        Dim formSemana As New FormExibicaoSemanal
        Dim result = formSemana.ShowDialog()
    End Sub

    Private Sub BtnRelatorios_Click(sender As Object, e As EventArgs)
        Dim formRelatorio As New FormRelatorioCategoriasMaisRealizadas
        Dim result = formRelatorio.ShowDialog()
    End Sub

    Private Sub btnquantidade_Click(sender As Object, e As EventArgs)
        Dim formRelatorio As New FormRelatorioQuantidade
        Dim result = formRelatorio.ShowDialog()
    End Sub

End Class
