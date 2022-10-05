Imports System.Data.SQLite

Public Class FormMeta
    Private _metaDAO As IMetaDAO
    Public metaSelecionada As Meta
    'Semana
    Dim dataInicioSemana As Date
    Dim dataFimSemana As Date

    'Mes
    Dim dataInicioMes As Date
    Dim dataFimMes As Date

    'Ano
    Dim dataInicioAno As Date
    Dim dataFimAno As Date

    Private Sub FormMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarSemana()
        inicializarMes()
        inicializarAno()
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

    Private Sub inicializarMes()
        dataInicioMes = New Date(DateTime.Today.Year, DateTime.Today.Month, 1)
        dataFimMes = dataInicioMes.AddMonths(1).AddSeconds(-1)

        lblMes.Text = dataInicioMes.ToString("MMMM/yyyy")
    End Sub

    Private Sub inicializarAno()
        dataInicioAno = New Date(DateTime.Today.Year, 1, 1)
        dataFimAno = dataInicioAno.AddYears(1).AddSeconds(-1)

        lblAno.Text = dataInicioAno.ToString("yyyy")
    End Sub


    Private Sub carregarMetasSemanais()
        'limpar listview
        listViewSemanais.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.semanal).FindAll(Function(x) x.data >= dataInicioSemana And x.data <= dataFimSemana)

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
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.mensal).FindAll(Function(x) x.data >= dataInicioMes And x.data <= dataFimMes)

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
        Dim lista As List(Of Meta) = _metaDAO.listarPorTipo(TipoMeta.anual).FindAll(Function(x) x.data >= dataInicioAno And x.data <= dataFimAno)

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

    Private Sub btnSemanaAtual_Click(sender As Object, e As EventArgs) Handles btnSemanaAtual.Click
        inicializarSemana()
        carregarMetasSemanais()
    End Sub

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(-7)
        dataFimSemana = dataFimSemana.AddDays(-7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarMetasSemanais()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(7)
        dataFimSemana = dataFimSemana.AddDays(7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarMetasSemanais()
    End Sub

    Private Sub btnMesAtual_Click(sender As Object, e As EventArgs) Handles btnMesAtual.Click
        inicializarMes()
        carregarMetasMensais()
    End Sub

    Private Sub btnVoltarMes_Click(sender As Object, e As EventArgs) Handles btnVoltarMes.Click
        dataInicioMes = dataInicioMes.AddMonths(-1)
        dataFimMes = dataFimMes.AddMonths(-1)
        lblMes.Text = dataInicioMes.ToString("MMMM/yyyy")
        carregarMetasMensais()
    End Sub

    Private Sub btnAvancarMes_Click(sender As Object, e As EventArgs) Handles btnAvancarMes.Click
        dataInicioMes = dataInicioMes.AddMonths(1)
        dataFimMes = dataFimMes.AddMonths(1)
        lblMes.Text = dataInicioMes.ToString("MMMM/yyyy")
        carregarMetasMensais()
    End Sub

    Private Sub btnAnoAtual_Click(sender As Object, e As EventArgs) Handles btnAnoAtual.Click
        inicializarAno()
        carregarMetasAnuais()
    End Sub

    Private Sub btnVoltarAno_Click(sender As Object, e As EventArgs) Handles btnVoltarAno.Click
        dataInicioAno = dataInicioAno.AddYears(-1)
        dataFimAno = dataFimAno.AddYears(-1)
        lblAno.Text = dataInicioAno.ToString("yyyy")
        carregarMetasAnuais()
    End Sub

    Private Sub btnAvancarAno_Click(sender As Object, e As EventArgs) Handles btnAvancarAno.Click
        dataInicioAno = dataInicioAno.AddYears(1)
        dataFimAno = dataFimAno.AddYears(1)
        lblAno.Text = dataInicioAno.ToString("yyyy")
        carregarMetasAnuais()
    End Sub
End Class
