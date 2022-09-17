Imports System.Data.SQLite
Imports System.Reflection
Imports System.Resources.ResXFileRef

Public Class FormCategoria

    Private corSelecionada As Color = Color.Red

    Public result As String = "RESULT FORM CATEGORIA"

    Private _categoriaDAO As ICategoriaDAO

    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelCor.BackColor = Color.Red
        initState()
        carregaDados()
    End Sub

    Private Sub initState()
        _categoriaDAO = CategoriaDAO.getSingletonObject
    End Sub

    Public categoriaSelecionadaId As Integer = -1

    'Atualizar id da categoria selecionada no DataGridView

    Private Sub dgvCategorias_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvCategorias.CurrentCellChanged

        If Me.dgvCategorias.CurrentCellAddress.X < 0 Or Me.dgvCategorias.CurrentCellAddress.Y < 0 Then
            Exit Sub
            ' The Windows Me.I_DataGridView object will have already deselected the current cell and selected the 
            ' new cell as per user navigation using mouse or cursor keys.  We just need to store the current
            ' co-ordinates for the currently selected cell.

        End If

        Dim linhaAtual As Int32 = dgvCategorias.CurrentCell.RowIndex
        categoriaSelecionadaId = linhaAtual
        lblIdSelecionado.Text = "categoriaSelecionadaID: " + categoriaSelecionadaId.ToString

    End Sub

    Private Sub dgvCategorias_RowPrePaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvCategorias.RowPrePaint

        If e.RowIndex >= 0 Then
            Dim categoriaDao As CategoriaDAO = CategoriaDAO.getSingletonObject
            Dim categoriaLista = categoriaDao.listar()
            Dim categoriaItem = categoriaLista.ElementAt(e.RowIndex)

            Me.dgvCategorias.Rows(e.RowIndex).Cells(1).Style.BackColor = categoriaItem.cor
        End If
    End Sub

    Private Sub carregaDados()
        'Busca os dados
        Dim lista As List(Of Categoria) = _categoriaDAO.listar()
        Try
            dgvCategorias.DataSource = ConverterListParaDataTable(lista)
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Function ConverterListParaDataTable(Of T)(items As List(Of T)) As DataTable
        Try
            Dim dataTable As New DataTable(GetType(T).Name)
            'Pega todas as propriedades
            Dim Propriedades As PropertyInfo() = GetType(T).GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
            For Each _propriedade As PropertyInfo In Propriedades
                'Define os nomes das colunas como os nomes das propriedades
                dataTable.Columns.Add(_propriedade.Name)
            Next
            For Each item As T In items
                Dim valores = New Object(Propriedades.Length - 1) {}
                For i As Integer = 0 To Propriedades.Length - 1
                    'inclui os valores das propriedades nas linhas do datatable
                    valores(i) = Propriedades(i).GetValue(item, Nothing)
                    If (TypeOf valores(i) Is Color) Then
                        valores(i) = CType(valores(i), Color).ToArgb
                    End If
                Next
                dataTable.Rows.Add(valores)
            Next
            Return dataTable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim nome As String = txtNomeCategoria.Text
        Dim cor As Color = corSelecionada

        Dim novaCategoria As Categoria = New Categoria(nome, cor)
        If nome <> "" Then
            Try
                _categoriaDAO.inserir(novaCategoria)
                txtNomeCategoria.ResetText()
                carregaDados()
            Catch ex As CategoriaExistenteException
                MsgBox("Categoria já existente!")
            Catch ex As Exception
                MsgBox("Erro ao adicionar categoria: " & ex.ToString)
            End Try
        Else
            MsgBox("Digite um nome para a categoria para poder salvar!")
        End If


    End Sub



    Private Sub btnDeletarPrimeiro_Click(sender As Object, e As EventArgs) Handles btnDeletarPrimeiro.Click
        Try
            Dim lista = _categoriaDAO.listar()
            _categoriaDAO.deletar(lista.First.nome)
            carregaDados()
        Catch ex As Exception
            MsgBox("Erro ao deletar categoria: " & ex.ToString)
        End Try
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

    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Tem certeza que deseja sair da tela de categorias?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAlterarCor_Click(sender As Object, e As EventArgs) Handles btnAlterarCor.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            corSelecionada = ColorDialog1.Color
            panelCor.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class
