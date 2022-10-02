Imports System.Windows.Controls

Public Class FormAdicionarTarefa
    Private _TarefaDAO As ITarefaDAO

    Public tarefa As Tarefa
    Private Sub FormAdicionarTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initState()
    End Sub

    Private Sub initState()
        _TarefaDAO = TarefaDAO.getSingletonObject
        'Muda se for para editar o tarefa
        If tarefa IsNot Nothing Then
            txtDescricao.Text = tarefa.descricao
            DateTimePicker1.Value = tarefa.horarioInicio
            Label3.Text = tarefa.duracao
            ComboBox2.SelectedValue = tarefa.estado
        End If

    End Sub

    Private Sub btnAdicionarTarefa_Click(sender As Object, e As EventArgs) Handles btnAdicionarTarefa.Click
        Dim descricao As String = txtDescricao.Text
        Dim horarioInicio As Date = tarefa.horarioInicio
        Dim estadoAtividade As EstadoAtividade = tarefa.estado
        Dim duracao As Integer = tarefa.duracao


        If descricao <> "" Then
            If tarefa Is Nothing Then
                Dim novaTarefa As New Tarefa(descricao, horarioInicio, duracao, estadoAtividade)
                Try
                    _TarefaDAO.inserir(novaTarefa)
                    txtDescricao.ResetText()
                    Me.Close()
                Catch ex As TarefaExistenteException
                    MsgBox("Tarefa já existente")
                Catch ex As Exception
                    MsgBox("Erro ao adicionar tarefa: " & ex.ToString)
                End Try
            Else
                Try

                    tarefa.descricao = descricao
                    tarefa.horarioInicio = horarioInicio
                    tarefa.estado = estadoAtividade
                    tarefa.duracao = duracao
                    txtDescricao.ResetText()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao adicionar tarefa: " & ex.ToString)
                End Try

            End If

        Else
            MsgBox("Digite uma descrição para o tarefa para poder salvar!")
        End If
    End Sub

    Private Sub Button1SelecionarCategoria_Click(sender As Object, e As EventArgs) Handles SelecionarCategoria.Click
        Dim formSelecionarCategoria As FormSelecionarCategoria = New FormSelecionarCategoria()
        formSelecionarCategoria.ShowDialog()
        Dim resultado = formSelecionarCategoria.result
        If IsNothing(resultado) Then
            MsgBox("Resultado do dialog: NOTHING")
        Else
            MsgBox("Resultado do dialog: Categoria: " + resultado.nome)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class