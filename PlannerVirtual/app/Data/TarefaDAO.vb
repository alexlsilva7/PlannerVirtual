Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class TarefaDAO
    Implements ITarefaDAO

    'Constantes estaticas
    Public Shared instancia As TarefaDAO
    Public Shared iniciado As Boolean

    Private Sub New()
        'construtor privado de forma a desabilitar outro a criar um objeto
    End Sub
    Friend Shared Function getSingletonObject() As TarefaDAO
        If iniciado = False Then
            instancia = New TarefaDAO()
            iniciado = True
            Return instancia
        Else
            Return instancia
        End If
    End Function

    Public Sub inserir(tarefa As Tarefa) Implements ITarefaDAO.inserir
        Try
            consultar(tarefa.id)
            Throw New TarefaExistenteException
        Catch ex As TarefaNaoEncontradaException
            Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Tarefas (descricao , horarioInicio , duracao , estado, categoria) VALUES ('" & tarefa.descricao & "','" & tarefa.horarioInicio.ToString("dd-MM-yyyy HH:mm") & "','" & tarefa.duracao & "','" & tarefa.estado & "','" & tarefa.categoria.nome & "')"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub deletar(id As Integer) Implements ITarefaDAO.deletar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Tarefas WHERE id = '" & id & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function listar() As List(Of Tarefa) Implements ITarefaDAO.listar

        Dim listaTarefas As List(Of Tarefa) = New List(Of Tarefa)

        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT id,descricao,categoria,horarioInicio,duracao,estado FROM Tarefas ORDER BY descricao"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim categoria = CategoriaDAO.getSingletonObject().consultar(dr("categoria"))
                            Dim tarefa As Tarefa = New Tarefa(dr("descricao"), Date.Parse(dr("horarioInicio")), dr("duracao"), dr("estado"), categoria, dr("id"))
                            listaTarefas.Add(tarefa)
                        End While

                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaTarefas.OrderBy(Function(t) t.estado).ToList()
    End Function

    Public Function listarEntreDatas(ByVal dataInicial As Date, ByVal dataFinal As Date) As List(Of Tarefa) Implements ITarefaDAO.listarEntreDatas
        Dim listaTarefas As List(Of Tarefa) = listar()

        Dim listaTarefasFiltradas As List(Of Tarefa) = listaTarefas.FindAll(Function(tarefa As Tarefa) tarefa.horarioInicio >= dataInicial And tarefa.horarioInicio <= dataFinal)

        Return listaTarefasFiltradas
    End Function
    Public Function getTarefasByEstado(estadoTarefa As EstadoAtividade) As List(Of Tarefa) Implements ITarefaDAO.getTarefasByEstado

        Dim listaTarefas As List(Of Tarefa) = New List(Of Tarefa)

        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT id,descricao,categoria,horarioInicio,duracao,estado FROM Tarefas WHERE estado = '" & estadoTarefa & "' ORDER BY id"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim categoria = CategoriaDAO.getSingletonObject().consultar(dr("categoria"))
                            Dim tarefa As Tarefa = New Tarefa(dr("descricao"), Date.Parse(dr("horarioInicio")), dr("duracao"), dr("estado"), categoria, dr("id"))
                            listaTarefas.Add(tarefa)
                        End While

                    End If
                End Using
            End Using

            cn.Close()
        End Using
        Return listaTarefas
    End Function

    Public Function consultar(id As Integer) As Tarefa Implements ITarefaDAO.consultar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT id,descricao,categoria,horarioInicio,duracao,estado FROM Tarefas WHERE id = '" & id & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim categoria = CategoriaDAO.getSingletonObject().consultar(dr("categoria"))
                        Dim tarefa As Tarefa = New Tarefa(dr("descricao"), Date.Parse(dr("horarioInicio")), dr("duracao"), dr("estado"), categoria, dr("id"))
                        cn.Close()
                        Return tarefa
                    Else
                        cn.Close()
                        Throw New TarefaNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Sub atualizar(tarefa As Tarefa) Implements ITarefaDAO.atualizar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "UPDATE Tarefas SET descricao = '" & tarefa.descricao & "', categoria = '" & tarefa.categoria.nome & "', horarioInicio = '" & tarefa.horarioInicio.ToString("dd-MM-yyyy HH:mm") & "', duracao = '" & tarefa.duracao & "', estado = '" & tarefa.estado & "' WHERE id = '" & tarefa.id & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

End Class
