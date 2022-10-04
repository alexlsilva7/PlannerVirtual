Imports System.Windows.Controls

Public Class FormAdicionarTarefa
    Private _TarefaDAO As ITarefaDAO

    Private _categoriaSelecionada As Categoria

    Public tarefa As Tarefa
    Private Sub FormAdicionarTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initState()
    End Sub

    Private Sub initState()
        _TarefaDAO = TarefaDAO.getSingletonObject
        'Muda se for para editar o tarefa
        If tarefa IsNot Nothing Then
            txtDescricao.Text = tarefa.descricao
            DateTimePickerData.Value = tarefa.horarioInicio
            Label3.Text = tarefa.duracao
            ComboBox2.SelectedValue = tarefa.estado

            btnAdicionarTarefa.Text = "Atualizar"
            lblTitulo.Text = "Editar - "
        End If

        DateTimePickerData.Format = DateTimePickerFormat.Custom
        DateTimePickerData.CustomFormat = "dd/MM/yyyy"

        DateTimePickerHora.Format = DateTimePickerFormat.Custom
        DateTimePickerHora.CustomFormat = "HH:mm"
        DateTimePickerHora.ShowUpDown = True
        'inicia com timer picker desabilitado
        lblHora.Visible = False
        DateTimePickerHora.Visible = False
        'Duração padrão 30 min
        ComboBox.SelectedIndex = 0
        'Tipo Padrao 
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub btnAdicionarTarefa_Click(sender As Object, e As EventArgs) Handles btnAdicionarTarefa.Click
        Dim descricao As String = txtDescricao.Text
        Dim Data As DateTime = DateTimePickerData.Value
        Dim Hora As DateTime
        Dim indexComboBox As Integer = ComboBox.SelectedIndex
        Dim duracao As Integer = 0
        Select Case indexComboBox
            Case 0 '30 min
                Hora = DateTimePickerHora.Value
                duracao = 30
            Case 1 '1h
                Hora = DateTimePickerHora.Value
                duracao = 60
            Case 2 'De manhã (8h às 12h)
                Hora = DateTime.Parse("08:00")
                duracao = 240
            Case 3 'De tarde (13h às 17h)
                Hora = DateTime.Parse("13:00")
                duracao = 240
            Case 4 'De noite (18h às 22h)
                Hora = DateTime.Parse("18:00")
                duracao = 240
        End Select

        Dim dataFinal = New DateTime(Data.Year, Data.Month, Data.Day, Hora.Hour, Hora.Minute, 0)
        Dim estado As String = ComboBox2.SelectedIndex


        If descricao <> "" And duracao <> 0 And _categoriaSelecionada IsNot Nothing And estado <> "-1" Then
            If tarefa Is Nothing Then
                Dim novaTarefa As New Tarefa(descricao, dataFinal.ToString("dd-MM-yyyy HH:mm"), duracao, estado, _categoriaSelecionada)
                Try
                    _TarefaDAO.inserir(novaTarefa)
                    Me.Close()
                Catch ex As TarefaExistenteException
                    MsgBox("Tarefa já existente")
                Catch ex As Exception
                    MsgBox("Erro ao adicionar tarefa: " & ex.ToString)
                End Try
            Else
                Try
                    tarefa.descricao = descricao
                    tarefa.horarioInicio = dataFinal.ToString("dd-MM-yyyy HH:mm")
                    tarefa.estado = estado
                    tarefa.duracao = duracao
                    tarefa.categoria = _categoriaSelecionada
                    _TarefaDAO.atualizar(tarefa)
                    txtDescricao.ResetText()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao adicionar tarefa: " & ex.ToString)
                End Try
            End If

        Else
            MsgBox("Preencha todos os dados!")
        End If
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        Select Case ComboBox.SelectedIndex
            Case 0 '30 min
                DateTimePickerHora.Visible = True
                lblHora.Visible = True
            Case 1 '1h
                DateTimePickerHora.Visible = True
                lblHora.Visible = True
            Case 2 'De manhã (8h às 12h)
                DateTimePickerHora.Visible = False
                lblHora.Visible = False
            Case 3 'De tarde (13h às 17h)
                DateTimePickerHora.Visible = False
                lblHora.Visible = False
            Case 4 'De noite (18h às 22h)
                DateTimePickerHora.Visible = False
                lblHora.Visible = False
        End Select
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