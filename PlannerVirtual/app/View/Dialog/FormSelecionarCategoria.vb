Imports System.Reflection

Public Class FormSelecionarCategoria
    Public result As Categoria
    Public categoriaSelecionadaId As Integer = -1

    Private _categoriaDAO As ICategoriaDAO

    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initState()
        carregaDados()
    End Sub
    Private Sub initState()
        _categoriaDAO = CategoriaDAO.getSingletonObject
    End Sub

    Private Sub dgvCategorias_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvCategorias.CurrentCellChanged
        If Me.dgvCategorias.CurrentCellAddress.X < 0 Or Me.dgvCategorias.CurrentCellAddress.Y < 0 Then
            Exit Sub
            ' The Windows Me.I_DataGridView object will have already deselected the current cell and selected the 
            ' new cell as per user navigation using mouse or cursor keys.  We just need to store the current
            ' co-ordinates for the currently selected cell.

        End If

        Dim linhaAtual As Int32 = dgvCategorias.CurrentCell.RowIndex
        categoriaSelecionadaId = linhaAtual




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

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click
        Dim categoriaDao As CategoriaDAO = CategoriaDAO.getSingletonObject
        Dim categoriaLista = categoriaDao.listar()
        Dim categoriaItem = categoriaLista.ElementAt(categoriaSelecionadaId)

        result = categoriaItem
        Me.Close()
    End Sub
End Class