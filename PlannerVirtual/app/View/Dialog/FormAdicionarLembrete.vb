Public Class FormAdicionarLembrete
    Public tipoLembrete As TipoLembrete
    Private _lembreteDAO As ILembreteDAO

    Public lembrete As Lembrete

    Private Sub FormAdicionarLembrete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initState()
    End Sub

    Private Sub initState()
        _lembreteDAO = LembreteDAO.getSingletonObject
        If (tipoLembrete = TipoLembrete.ligacoesImportantes) Then
            lblTipoLembrete.Text = "Ligação Importante"
        ElseIf (tipoLembrete = TipoLembrete.reunioes) Then
            lblTipoLembrete.Text = "Reunião"
        ElseIf (tipoLembrete = TipoLembrete.compras) Then
            lblTipoLembrete.Text = "Compras"
        End If

        If lembrete IsNot Nothing Then
            txtDescricao.Text = lembrete.descricao
            DatePicker.Value = lembrete.data

            btnAdicionarLembrete.Text = "Atualizar"
        End If
    End Sub

    Private Sub btnAdicionarLembrete_Click(sender As Object, e As EventArgs) Handles btnAdicionarLembrete.Click
        Dim descricao As String = txtDescricao.Text
        Dim data As Date = DatePicker.Value

        If descricao <> "" Then
            If lembrete Is Nothing Then
                Dim novoLembrete As New Lembrete(descricao, data, tipoLembrete)
                Try
                    _lembreteDAO.inserir(novoLembrete)
                    txtDescricao.ResetText()
                    Me.Close()
                Catch ex As LembreteExistenteException
                    MsgBox("Lembrete já existente")
                Catch ex As Exception
                    MsgBox("Erro ao adicionar lembrete: " & ex.ToString)
                End Try
            Else
                Try
                    lembrete.descricao = descricao
                    lembrete.data = data
                    _lembreteDAO.atualizar(lembrete)
                    txtDescricao.ResetText()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao adicionar lembrete: " & ex.ToString)
                End Try

            End If

        Else
            MsgBox("Digite uma descrição para o lembrete para poder salvar!")
        End If
    End Sub
End Class