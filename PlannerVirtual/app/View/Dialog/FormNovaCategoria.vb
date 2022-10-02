Imports System.Windows.Controls

Public Class FormNovaCategoria

    Private _categoriaDAO As ICategoriaDAO

    Private corSelecionada As Color = Color.Red

    Public categoria As Categoria

    Private Sub FormNovaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initState()
    End Sub

    Private Sub initState()
        _categoriaDAO = CategoriaDAO.getSingletonObject
        corSelecionada = Color.Blue
        panelCor.BackColor = Color.Blue

        If categoria IsNot Nothing Then
            txtNomeCategoria.Text = categoria.nome
            corSelecionada = categoria.cor
            panelCor.BackColor = categoria.cor
            lblTitulo.Text = "Editar Categoria"
            btnAdicionar.Text = "Editar"
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim nome As String = txtNomeCategoria.Text
        Dim cor As Color = corSelecionada


        If nome <> "" Then
            Dim novaCategoria = New Categoria(nome, cor)
            If categoria IsNot Nothing Then
                'Editar categoria
                Try
                    _categoriaDAO.atualizar(novaCategoria, categoria.nome)
                    txtNomeCategoria.ResetText()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao adicionar categoria: " & ex.ToString)
                End Try
            Else
                'Adicionar categoria
                Try
                    _categoriaDAO.inserir(novaCategoria)
                    Me.Close()
                Catch ex As CategoriaExistenteException
                    MsgBox("Categoria já existente")
                Catch ex As Exception
                    MsgBox("Erro ao adicionar categoria: " & ex.ToString)
                End Try
            End If
        Else
            MsgBox("Digite um nome para a categoria para poder salvar!")
        End If
    End Sub

    Private Sub btnAlterarCor_Click(sender As Object, e As EventArgs) Handles btnAlterarCor.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            corSelecionada = ColorDialog1.Color
            panelCor.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class