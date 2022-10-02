Public Class FormLembrete
    Private _lembreteDAO As ILembreteDAO
    Dim dataInicioSemana As Date
    Dim dataFimSemana As Date

    Private Sub FormLembrete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarSemana()
        _lembreteDAO = LembreteDAO.getSingletonObject
        carregarTodosLembretes()
    End Sub

    Private Sub carregarTodosLembretes()
        carregaDadosLigacoes()
        carregaDadosReunioes()
        carregaDadosCompras()
    End Sub

    Private Sub inicializarSemana()
        Dim diaDaSemana = CInt(DateTime.Today.DayOfWeek)
        dataInicioSemana = DateTime.Today.AddDays(-1 * diaDaSemana)
        dataFimSemana = DateTime.Today.AddDays(7 - diaDaSemana).AddSeconds(-1)

        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
    End Sub

    Private Sub carregaDadosLigacoes()
        'limpar listview
        listViewLigacoes.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Lembrete) = _lembreteDAO.getLembretesByTipo(TipoLembrete.ligacoesImportantes)

        'Pega os lembretes da semana
        Dim listaSemana = lista.FindAll(
                Function(lembrete)
                    Return lembrete.data >= dataInicioSemana And lembrete.data <= dataFimSemana
                End Function
            )

        'Preencher o listview
        Try
            For Each lembrete As Lembrete In listaSemana
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
        Dim lista As List(Of Lembrete) = _lembreteDAO.getLembretesByTipo(TipoLembrete.reunioes)

        'Pega os lembretes da semana
        Dim listaSemana = lista.FindAll(
                Function(lembrete)
                    Return lembrete.data >= dataInicioSemana And lembrete.data <= dataFimSemana
                End Function
            )

        'Preencher o listview
        Try
            For Each lembrete As Lembrete In listaSemana
                Dim item = New ListViewItem({lembrete.id.ToString, lembrete.descricao, lembrete.data})
                listViewReunioes.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub carregaDadosCompras()
        'limpar listview
        listViewCompras.Items.Clear()
        'Busca os dados
        Dim lista As List(Of Lembrete) = _lembreteDAO.getLembretesByTipo(TipoLembrete.compras)

        'Pega os lembretes da semana
        Dim listaSemana = lista.FindAll(
                Function(lembrete)
                    Return lembrete.data >= dataInicioSemana And lembrete.data <= dataFimSemana
                End Function
            )

        'Preencher o listview
        Try
            For Each lembrete As Lembrete In listaSemana
                Dim item = New ListViewItem({lembrete.id.ToString, lembrete.descricao, lembrete.data})
                listViewCompras.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddReuniao_Click(sender As Object, e As EventArgs) Handles btnAddReuniao.Click
        Dim formAdicionarLembrete As New FormAdicionarLembrete
        formAdicionarLembrete.tipoLembrete = TipoLembrete.reunioes
        formAdicionarLembrete.ShowDialog()
        carregaDadosReunioes()
    End Sub



    Private Sub btnAddCompra_Click(sender As Object, e As EventArgs) Handles btnAddCompra.Click
        Dim formAdicionarLembrete As New FormAdicionarLembrete
        formAdicionarLembrete.tipoLembrete = TipoLembrete.compras
        formAdicionarLembrete.ShowDialog()
        carregaDadosCompras()
    End Sub

    Private Sub btnAddLigacaoImportate_Click(sender As Object, e As EventArgs) Handles btnAddLigacaoImportate.Click
        Dim formAdicionarLembrete As New FormAdicionarLembrete
        formAdicionarLembrete.tipoLembrete = TipoLembrete.ligacoesImportantes
        formAdicionarLembrete.ShowDialog()
        carregaDadosLigacoes()
    End Sub

    Private Sub listViewLigacoes_DoubleClick(sender As Object, e As EventArgs) Handles listViewLigacoes.DoubleClick
        If listViewLigacoes.SelectedItems.Count > 0 Then
            Dim formAdicionarLembrete = New FormAdicionarLembrete
            formAdicionarLembrete.tipoLembrete = TipoLembrete.ligacoesImportantes
            formAdicionarLembrete.lembrete = _lembreteDAO.consultar(listViewLigacoes.SelectedItems(0).SubItems(0).Text)
            formAdicionarLembrete.ShowDialog()
            carregaDadosLigacoes()
        End If
    End Sub

    Private Sub listViewReunioes_DoubleClick(sender As Object, e As EventArgs) Handles listViewReunioes.DoubleClick
        If listViewReunioes.SelectedItems.Count > 0 Then
            Dim formAdicionarLembrete = New FormAdicionarLembrete
            formAdicionarLembrete.tipoLembrete = TipoLembrete.reunioes
            formAdicionarLembrete.lembrete = _lembreteDAO.consultar(listViewReunioes.SelectedItems(0).SubItems(0).Text)
            formAdicionarLembrete.ShowDialog()
            carregaDadosReunioes()
        End If
    End Sub

    Private Sub listViewCompras_DoubleClick(sender As Object, e As EventArgs) Handles listViewCompras.DoubleClick
        If listViewCompras.SelectedItems.Count > 0 Then
            Dim formAdicionarLembrete = New FormAdicionarLembrete
            formAdicionarLembrete.tipoLembrete = TipoLembrete.compras
            formAdicionarLembrete.lembrete = _lembreteDAO.consultar(listViewCompras.SelectedItems(0).SubItems(0).Text)
            formAdicionarLembrete.ShowDialog()
            carregaDadosCompras()
        End If
    End Sub

    Private Sub btnVoltarSemana_Click(sender As Object, e As EventArgs) Handles btnVoltarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(-7)
        dataFimSemana = dataFimSemana.AddDays(-7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarTodosLembretes()
    End Sub

    Private Sub btnAvancarSemana_Click(sender As Object, e As EventArgs) Handles btnAvancarSemana.Click
        dataInicioSemana = dataInicioSemana.AddDays(7)
        dataFimSemana = dataFimSemana.AddDays(7)
        lblSemana.Text = dataInicioSemana.ToString("dd/MM/yyyy") & " - " & dataFimSemana.ToString("dd/MM/yyyy")
        carregarTodosLembretes()
    End Sub

    Private Sub btnIrSemanaAtual_Click(sender As Object, e As EventArgs) Handles btnIrSemanaAtual.Click
        inicializarSemana()
        carregarTodosLembretes()
    End Sub
End Class