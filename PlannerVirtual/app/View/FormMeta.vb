Public Class FormMeta
    Private _metaDAO As IMetaDAO
    Private Sub FormMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _metaDAO = MetaDAO.getSingletonObject
        carregarTodasMetas()
    End Sub

    Private Sub carregarTodasMetas()
        'limpar listview
        listViewMetas.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listar()

        'Preencher o listview
        Try
            For Each meta As Meta In lista
                Dim item = New ListViewItem({meta.descricao, meta.tipo, meta.data, meta.estado})
                listViewMetas.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub
End Class
