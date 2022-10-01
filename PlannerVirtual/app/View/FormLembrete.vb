Public Class FormLembrete
    Private _lembreteDAO As ILembreteDAO

    Private Sub FormLembrete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _lembreteDAO = LembreteDAO.getSingletonObject
        carregaDadosLigacoes()
        carregaDadosReunioes()
    End Sub

    Private Sub carregaDadosLigacoes()
        'limpar listview
        listViewLigacoes.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Lembrete) = _lembreteDAO.listar(TipoLembrete.ligacoesImportantes)
        'Preencher o listview
        Try
            For Each lembrete As Lembrete In lista
                Dim item = New ListViewItem({lembrete.id.ToString, lembrete.descricao, lembrete.data})
                listViewLigacoes.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub carregaDadosReunioes()
        'limpar listview
        listViewReunioes.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Lembrete) = _lembreteDAO.listar(TipoLembrete.reunioes)
        'Preencher o listview
        Try
            For Each lembrete As Lembrete In lista
                Dim item = New ListViewItem({lembrete.id.ToString, lembrete.descricao, lembrete.data})
                listViewReunioes.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddLigacaoImportate_Click(sender As Object, e As EventArgs)
        Dim formAdicionarLembrete As New FormAdicionarLembrete
        formAdicionarLembrete.tipoLembrete = TipoLembrete.ligacoesImportantes
        formAdicionarLembrete.ShowDialog()
        carregaDadosLigacoes()
    End Sub

    Private Sub btnAddReuniao_Click(sender As Object, e As EventArgs) Handles btnAddReuniao.Click
        Dim formAdicionarLembrete As New FormAdicionarLembrete
        formAdicionarLembrete.tipoLembrete = TipoLembrete.reunioes
        formAdicionarLembrete.ShowDialog()
        carregaDadosReunioes()
    End Sub
End Class