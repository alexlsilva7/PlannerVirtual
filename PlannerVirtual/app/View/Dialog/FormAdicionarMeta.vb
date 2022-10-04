Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormAdicionarMeta

    Private _MetaDAO As IMetaDAO

    Private _categoriaSelecionada As Categoria
    Public meta As Meta

    Private Sub FormAdicionarMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitState()
    End Sub

    Private Sub InitState()
        _MetaDAO = MetaDAO.getSingletonObject

        If meta IsNot Nothing Then
            txtDescricao.Text = meta.descricao
            DateTimePickerData.Value = meta.data
            ComboBoxTipo.SelectedIndex = CInt(meta.tipo)
            ComboBoxEstado.SelectedIndex = CInt(meta.estado)
            lblTitulo.Text = "Editar Meta"
            btnAdicionarMeta.Text = "Editar"
        Else
            ComboBoxTipo.SelectedIndex = 0
            ComboBoxEstado.SelectedIndex = 2
        End If
        ComboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList
        DateTimePickerData.Format = DateTimePickerFormat.Custom
        DateTimePickerData.CustomFormat = "dd/MM/yyyy"

    End Sub

    Private Sub btnAdicionarMeta_Click(sender As Object, e As EventArgs) Handles btnAdicionarMeta.Click
        Dim descricao As String = txtDescricao.Text
        Dim data As DateTime = DateTimePickerData.Value
        Dim _tipoMeta As TipoMeta
        Dim _EstadoMeta As EstadoMeta
        Dim tipo As String = ComboBoxTipo.SelectedIndex

        Dim estado As String = ComboBoxEstado.SelectedIndex

        Select Case tipo
            Case 0 'Semanal
                _tipoMeta = TipoMeta.semanal
            Case 1 'Mensal
                _tipoMeta = TipoMeta.mensal
            Case 2 'Anual
                _tipoMeta = TipoMeta.anual
        End Select

        Select Case estado
            Case 0 'Cumprida
                _EstadoMeta = EstadoMeta.cumprida
            Case 1 'Não Cumprida
                _EstadoMeta = EstadoMeta.naoCumprida
            Case 2 'Parcialmente Cumprida
                _EstadoMeta = EstadoMeta.parcialmenteCumprida
        End Select

        If descricao <> "" And _categoriaSelecionada IsNot Nothing And tipo <> "-1" Then
            If meta Is Nothing Then
                Dim novaMeta As New Meta(descricao, _categoriaSelecionada, data.ToString("dd-MM-yyyy"), _tipoMeta, _EstadoMeta)
                Try
                    _MetaDAO.inserir(novaMeta)
                    Me.Close()
                Catch ex As MetaExistenteException
                    MsgBox("Meta já existente")
                Catch ex As Exception
                    MsgBox("Erro ao adicionar Meta: " & ex.ToString)
                End Try
            Else
                Try
                    meta.descricao = descricao
                    meta.data = data.ToString("dd-MM-yyyy")
                    meta.categoria = _categoriaSelecionada
                    meta.tipo = _tipoMeta
                    meta.estado = _EstadoMeta
                    _MetaDAO.atualizar(meta)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao adicionar Meta: " & ex.ToString)
                End Try
            End If

        Else
            MsgBox("Preencha todos os dados!")
        End If

    End Sub

    Private Sub SelecionarCategoria_Click(sender As Object, e As EventArgs) Handles SelecionarCategoria.Click
        Dim formSelecionarCategoria As New FormSelecionarCategoria
        formSelecionarCategoria.ShowDialog()
        Dim categoria As Categoria = formSelecionarCategoria.result
        If categoria IsNot Nothing Then
            _categoriaSelecionada = categoria
            SelecionarCategoria.Text = categoria.nome
            SelecionarCategoria.ForeColor = categoria.cor
        End If
    End Sub

End Class