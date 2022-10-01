Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class LembreteDAO
    Implements ILembreteDAO

    'Constantes estaticas
    Public Shared instancia As LembreteDAO
    Public Shared iniciado As Boolean

    Private Sub New()
        'construtor privado de forma a desabilitar outro a criar um objeto
    End Sub
    Friend Shared Function getSingletonObject() As LembreteDAO
        If iniciado = False Then
            instancia = New LembreteDAO()
            iniciado = True
            Return instancia
        Else
            Return instancia
        End If
    End Function


    Public Sub inserir(lembrete As Lembrete) Implements ILembreteDAO.inserir
        Try
            consultar(lembrete.descricao)
            Throw New LembreteExistenteException
        Catch ex As LembreteNaoEncontradaException
            Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Lembretes (descricao, tipoLembrete, data) VALUES ('" & lembrete.descricao & "', '" & lembrete.tipoLembrete & "', '" & lembrete.data & "')"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub deletar(id As Integer) Implements ILembreteDAO.deletar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Lembretes WHERE id = '" & id & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function listar(tipoLembrete As TipoLembrete) As List(Of Lembrete) Implements ILembreteDAO.listar

        Dim listaLembretes As List(Of Lembrete) = New List(Of Lembrete)

        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT id, descricao, tipoLembrete, data FROM Lembretes WHERE tipoLembrete = '" & tipoLembrete & "' ORDER BY id"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim data = DataHelpers.stringToData(dr("data"))
                            Dim tipo As TipoLembrete = dr("tipoLembrete")
                            Dim lembrete As Lembrete = New Lembrete(dr("descricao"), data, tipoLembrete, dr("id"))
                            listaLembretes.Add(lembrete)
                        End While

                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaLembretes
    End Function

    Public Function consultar(id As Integer) As Lembrete Implements ILembreteDAO.consultar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT id, descricao, tipoLembrete, data FROM Lembretes WHERE id = '" & id & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim data = DataHelpers.stringToData(dr("data"))
                        Dim tipo As TipoLembrete = dr("tipoLembrete")
                        Dim lembrete As Lembrete = New Lembrete(dr("descricao"), data, tipo, dr("id"))
                        cn.Close()
                        Return lembrete
                    Else
                        cn.Close()
                        Throw New LembreteNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Sub atualizar(lembrete As Lembrete) Implements ILembreteDAO.atualizar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "UPDATE Lembretes SET descricao = '" & lembrete.descricao & "', tipoLembrete = '" & lembrete.tipoLembrete & "', data = '" & lembrete.data & "' WHERE id = '" & lembrete.id & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

End Class
