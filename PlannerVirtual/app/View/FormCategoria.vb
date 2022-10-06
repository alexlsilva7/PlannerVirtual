Imports System.Data.SQLite
Imports System.Reflection
Imports System.Resources.ResXFileRef

Public Class FormCategoria

    Public result As String = "RESULT FORM CATEGORIA"

    Private _categoriaDAO As ICategoriaDAO

    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        initState()
        carregaDados()
    End Sub

    Private Sub initState()
        _categoriaDAO = CategoriaDAO.getSingletonObject
    End Sub

    Private Sub carregaDados()
        'limpar listview
        listviewCategorias.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Categoria) = _categoriaDAO.listar()
        Try
            For Each categoria As Categoria In lista
                Dim item = New ListViewItem({categoria.nome, categoria.cor.ToArgb.ToString})
                item.ForeColor = categoria.cor
                listviewCategorias.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNovaCategoria_Click(sender As Object, e As EventArgs)
        Dim formNovaCategoria = New FormNovaCategoria()
        formNovaCategoria.ShowDialog()
        carregaDados()
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        If listviewCategorias.SelectedItems.Count > 0 Then
            'verifica se alguma tarefa ou meta está usando a categoria
            Dim listaTarefas As List(Of Tarefa) = TarefaDAO.getSingletonObject.listar()
            Dim listaMetas As List(Of Meta) = MetaDAO.getSingletonObject.listar()

            Dim tarefaUsandoCategoria As Boolean = False
            Dim metaUsandoCategoria As Boolean = False

            Dim nomeCategoria As String = listviewCategorias.SelectedItems(0).Text

            For Each tarefa As Tarefa In listaTarefas
                If tarefa.categoria.nome = nomeCategoria Then
                    tarefaUsandoCategoria = True
                    Exit For
                End If
            Next


            For Each meta As Meta In listaMetas
                If meta.categoria.nome = nomeCategoria Then
                    metaUsandoCategoria = True
                    Exit For
                End If
            Next

            If tarefaUsandoCategoria Or metaUsandoCategoria Then
                MessageBox.Show("Não é possível apagar a categoria " & nomeCategoria & " pois ela está sendo usada por uma tarefa ou meta.")
            Else
                If MessageBox.Show("Tem certeza que deseja apagar a categoria " & nomeCategoria & "?", "Atenção", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    _categoriaDAO.deletar(nomeCategoria)
                    carregaDados()
                End If
            End If
        Else
            MsgBox("Selecione uma categoria para poder apagar!")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim formNovaCategoria = New FormNovaCategoria()
        If listviewCategorias.SelectedItems.Count > 0 Then
            Dim nome As String = listviewCategorias.SelectedItems(0).Text
            Dim categoria = _categoriaDAO.consultar(nome)
            formNovaCategoria.categoria = categoria
            formNovaCategoria.ShowDialog()
            carregaDados()
        Else
            MsgBox("Selecione uma categoria para poder editar!")
        End If
    End Sub

    Private Sub btnConsultarCategoria_Click(sender As Object, e As EventArgs) Handles btnConsultarCategoria.Click
        Dim formConsultarCategoria = New FormConsultarCategoria()
        formConsultarCategoria.ShowDialog()
    End Sub

    Private Sub btnNovaCategoria_Click_1(sender As Object, e As EventArgs) Handles btnNovaCategoria.Click
        Dim formNovaCategoria = New FormNovaCategoria()
        formNovaCategoria.ShowDialog()
        carregaDados()
    End Sub
End Class
