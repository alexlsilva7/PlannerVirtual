Imports System.Data.SQLite

Public Class FormMeta
    Private _metaDAO As IMetaDAO
    Public metaSelecionada As Meta
    Dim dataInicioSemana As Date
    Dim dataFimSemana As Date
    Private Sub FormMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarSemana()
        _metaDAO = MetaDAO.getSingletonObject
        carregarTodasMetas()
    End Sub

    Private Sub carregarTodasMetas()
        carregarMetasSemanais()
        carregarMetasMensais()
        carregarMetasAnuais()
    End Sub

    Private Sub inicializarSemana()
        Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
        dataInicioSemana = DateTime.Today.AddDays(-1 * diaDaSemana)
        dataFimSemana = DateTime.Today.AddDays(7 - diaDaSemana).AddSeconds(-1)

        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
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
                Dim item = New ListViewItem({meta.id, meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
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
                Dim item = New ListViewItem({meta.id, meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
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
                Dim item = New ListViewItem({meta.id, meta.descricao, meta.categoria.nome, meta.estado.ToString, meta.data})
                ListViewAnuais.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdicionarMeta_Click(sender As Object, e As EventArgs) Handles btnAdicionarMeta.Click
        Dim form As New FormAdicionarMeta
        form.meta = Nothing
        form.ShowDialog()
        carregarTodasMetas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New FormAdicionarMeta()
        If listViewSemanais.SelectedItems.Count > 0 Then
            Dim id As Integer = Integer.Parse(listViewSemanais.SelectedItems(0).Text)
            metaSelecionada = _metaDAO.consultar(id)
            form.meta = metaSelecionada
            form.ShowDialog()
        ElseIf ListViewMensais.SelectedItems.Count > 0 Then
            Dim id As Integer = Integer.Parse(ListViewMensais.SelectedItems(0).Text)
            metaSelecionada = _metaDAO.consultar(id)
            form.meta = metaSelecionada
            form.ShowDialog()
        ElseIf ListViewAnuais.SelectedItems.Count > 0 Then
            Dim id As Integer = Integer.Parse(ListViewAnuais.SelectedItems(0).Text)
            metaSelecionada = _metaDAO.consultar(id)
            form.meta = metaSelecionada
            form.ShowDialog()
        Else
            MessageBox.Show("Selecione uma meta para editar")
        End If
        carregarTodasMetas()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnIrSemanaAtual_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblSemana_Click(sender As Object, e As EventArgs) Handles lblSemana.Click

    End Sub
End Class
