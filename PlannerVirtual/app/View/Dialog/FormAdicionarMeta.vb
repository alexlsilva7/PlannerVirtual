Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormAdicionarMeta

    Private _MetaDAO As IMetaDAO

    Private _categoriaSelecionada As Categoria
    Public meta As Meta
    Public tipo As TipoMeta

    Private Sub FormAdicionarMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitState()
    End Sub

    Private Sub InitState()
        _MetaDAO = MetaDAO.getSingletonObject

        If meta IsNot Nothing Then
            txtDescricao.Text = meta.descricao
            DateTimePickerData.Value = meta.data
            ComboBoxEstado.SelectedIndex = CInt(meta.estado)
            lblTitulo.Text = "Editar Meta"
            btnAdicionarMeta.Text = "Editar"
            _categoriaSelecionada = meta.categoria
            SelecionarCategoria.Text = meta.categoria.nome
            SelecionarCategoria.ForeColor = meta.categoria.cor
        Else
            'Valor Padrao 'Não Cumprido'
            ComboBoxEstado.SelectedIndex = 1
        End If
        ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList
        DateTimePickerData.Format = DateTimePickerFormat.Custom
        DateTimePickerData.CustomFormat = "dd/MM/yyyy"

    End Sub

    Private Sub btnAdicionarMeta_Click(sender As Object, e As EventArgs) Handles btnAdicionarMeta.Click
        Dim descricao As String = txtDescricao.Text
        Dim data As DateTime = DateTimePickerData.Value

        Dim _EstadoMeta As EstadoMeta

        Dim estado As String = ComboBoxEstado.SelectedIndex


        Select Case estado
            Case 0 'Cumprida
                _EstadoMeta = EstadoMeta.cumprida
            Case 1 'Não Cumprida
                _EstadoMeta = EstadoMeta.naoCumprida
            Case 2 'Parcialmente Cumprida
                _EstadoMeta = EstadoMeta.parcialmenteCumprida
        End Select

        If (descricao <> "") And (_categoriaSelecionada IsNot Nothing) Then
            If meta Is Nothing Then
                Dim novaMeta As New Meta(descricao, _categoriaSelecionada, data.ToString("dd-MM-yyyy"), tipo, _EstadoMeta)
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