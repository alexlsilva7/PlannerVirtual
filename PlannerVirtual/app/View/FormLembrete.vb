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
        Dim result = editarLembrete(listViewLigacoes, TipoLembrete.ligacoesImportantes)
        If result Then carregaDadosLigacoes()
    End Sub

    Private Sub listViewReunioes_DoubleClick(sender As Object, e As EventArgs) Handles listViewReunioes.DoubleClick
        Dim result = editarLembrete(listViewReunioes, TipoLembrete.reunioes)
        If result Then carregaDadosReunioes()
    End Sub

    Private Sub listViewCompras_DoubleClick(sender As Object, e As EventArgs) Handles listViewCompras.DoubleClick
        Dim result = editarLembrete(listViewCompras, TipoLembrete.compras)
        If result Then carregaDadosCompras()
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

    Private Function editarLembrete(listview As ListView, tipoLembrete As TipoLembrete) As Boolean
        If listview.SelectedItems.Count > 0 Then
            Dim formAdicionarLembrete = New FormAdicionarLembrete
            formAdicionarLembrete.tipoLembrete = tipoLembrete
            formAdicionarLembrete.lembrete = _lembreteDAO.consultar(listview.SelectedItems(0).SubItems(0).Text)
            formAdicionarLembrete.ShowDialog()
            Return True
        Else
            MsgBox("Selecione um lembrete para editar")
        End If
        Return False
    End Function

    Private Function apagarLembrete(listview As ListView) As Boolean
        If listview.SelectedItems.Count > 0 Then
            Dim descricaoSelecionada = listview.SelectedItems(0).SubItems(1).Text
            Dim idSelecionao = Integer.Parse(listview.SelectedItems(0).SubItems(0).Text)
            Dim result As DialogResult = MessageBox.Show("Deseja apagar o lembrete: " & descricaoSelecionada & " ?", "Apagar Lembrete", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return False
            ElseIf result = DialogResult.Yes Then
                _lembreteDAO.deletar(idSelecionao)
                Return True
            End If
        Else
            MsgBox("Selecione um lembrete para apagar")
        End If
        Return False
    End Function
    'Botões de apagar
    Private Sub btnApagarLigacao_Click(sender As Object, e As EventArgs) Handles btnApagarLigacao.Click
        Dim result = apagarLembrete(listViewLigacoes)
        If result Then carregaDadosLigacoes()
    End Sub
    Private Sub btnApagarReuniao_Click(sender As Object, e As EventArgs) Handles btnApagarReuniao.Click
        Dim result = apagarLembrete(listViewReunioes)
        If result Then carregaDadosReunioes()
    End Sub

    Private Sub btnApagarCompra_Click(sender As Object, e As EventArgs) Handles btnApagarCompra.Click
        Dim result = apagarLembrete(listViewCompras)
        If result Then carregaDadosCompras()
    End Sub
    'Botões de editar
    Private Sub btnEditarLigacao_Click(sender As Object, e As EventArgs) Handles btnEditarLigacao.Click
        Dim result = editarLembrete(listViewLigacoes, TipoLembrete.ligacoesImportantes)
        If result Then carregaDadosLigacoes()
    End Sub

    Private Sub btnEditarReuniao_Click(sender As Object, e As EventArgs) Handles btnEditarReuniao.Click
        Dim result = editarLembrete(listViewReunioes, TipoLembrete.reunioes)
        If result Then carregaDadosReunioes()
    End Sub

    Private Sub btnEditarCompra_Click(sender As Object, e As EventArgs) Handles btnEditarCompra.Click
        Dim result = editarLembrete(listViewCompras, TipoLembrete.compras)
        If result Then carregaDadosCompras()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub listViewLigacoes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewLigacoes.SelectedIndexChanged

    End Sub
End Class