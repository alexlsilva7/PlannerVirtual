Imports System.Reflection

Public Class FormSelecionarCategoria
    Public result As Categoria
    Public categoriaSelecionadaId As Integer = -1

    Private _categoriaDAO As ICategoriaDAO

    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        initState()
        carregaDados()
    End Sub
    Private Sub initState()
        _categoriaDAO = CategoriaDAO.getSingletonObject
    End Sub

    Private Sub listviewCategorias_Click(sender As Object, e As EventArgs) Handles listviewCategorias.Click
        If listviewCategorias.SelectedItems.Count > 0 Then
            Dim categoriaSelecionadaNome = listviewCategorias.SelectedItems(0).Text
            Dim categoriaItem = _categoriaDAO.consultar(categoriaSelecionadaNome)
            result = categoriaItem
            Me.Close()
        Else
            MsgBox("Selecione uma categoria valida!")
        End If

    End Sub

    Private Sub carregaDados()
        'limpar listview
        listviewCategorias.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Categoria) = _categoriaDAO.listar()

        'Preencher o listview
        Try
            For Each categoria As Categoria In lista
                Dim item = New ListViewItem({categoria.nome, categoria.cor.ToString})
                item.ForeColor = categoria.cor
                listviewCategorias.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

End Class