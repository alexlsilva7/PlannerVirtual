Public Class FormConsultarCategoria
    Private _categoriaDAO As ICategoriaDAO

    Private Sub FormConsultarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        initState()
    End Sub

    Private Sub initState()
        _categoriaDAO = CategoriaDAO.getSingletonObject
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim nome As String = txtNomeConsultar.Text
        Try
            Dim categoria = _categoriaDAO.consultar(nome)
            MsgBox("Categoria - Nome: " & categoria.nome & " | Cor(ARGB): " & categoria.cor.ToArgb)
        Catch naoEncontradoException As CategoriaNaoEncontradaException
            MsgBox("Categoria não encontrada!")
        Catch ex As Exception
            MsgBox("Erro ao consultar categoria: " & ex.ToString)
        End Try
    End Sub


End Class