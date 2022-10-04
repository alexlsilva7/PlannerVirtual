Public Class FormMeta
    Private _metaDAO As IMetaDAO
    Private Sub FormMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _metaDAO = MetaDAO.getSingletonObject
        carregarTodasMetas()
    End Sub

    Private Sub carregarTodasMetas()
        carregarMetasSemanais()
        carregarMetasMensais()
        carregarMetasAnuais()
    End Sub

    Private Sub carregarMetasSemanais()
        'limpar listview
        listViewSemanais.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.semanal)

        'Preencher o listview
        Try
            For Each meta As Meta In lista
                Console.WriteLine(meta)
                Dim item = New ListViewItem({meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
                listViewSemanais.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub carregarMetasMensais()
        'limpar listview
        ListViewMensais.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.mensal)

        'Preencher o listview
        Try
            For Each meta As Meta In lista
                Console.WriteLine(meta)
                Dim item = New ListViewItem({meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
                ListViewMensais.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub carregarMetasAnuais()
        'limpar listview
        ListViewAnuais.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.anual)

        'Preencher o listview
        Try
            For Each meta As Meta In lista
                Console.WriteLine(meta)
                Dim item = New ListViewItem({meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
                ListViewAnuais.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub
End Class
