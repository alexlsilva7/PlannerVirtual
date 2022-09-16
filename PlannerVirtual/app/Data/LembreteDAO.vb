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


    Private sConnectionString As String = "Data Source= C:\Users\danie\OneDrive\Área de Trabalho\PlannerVirtual\PlannerVirtual\database.db; Version=3; New=True; Compress=True;"

    Public Sub inserir(lembrete As Lembrete) Implements ILembreteDAO.inserir
        Try
            consultar(lembrete.nome)
            Throw New CategoriaExistenteException
        Catch ex As CategoriaNaoEncontradaException
            Using cn = New SQLiteConnection(sConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Categorias (nome , cor) VALUES ('" & categoria.nome & "', " & Color.Red.ToArgb & ")"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub deletar(nome As String) Implements ILembreteDAO.deletar
        Using cn = New SQLiteConnection(sConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Categorias WHERE nome = '" & nome & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function listar() As List(Of Lembrete) Implements ILembreteDAO.listar

        Dim listaCategorias As List(Of Lembrete) = New List(Of Lembrete)

        Using cn = New SQLiteConnection(sConnectionString)
            cn.Open()
            Dim sql = "SELECT nome,cor FROM Categorias ORDER BY nome"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim lembrete As Lembrete = New Lembrete(dr("nome"), Color.FromArgb((dr("cor"))))
                            listaLembretes.Add(lembrete)
                        End While

                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaCategorias
    End Function

    Public Function consultar(nome As String) As Categoria Implements ILembreteDAO.consultar
        Using cn = New SQLiteConnection(sConnectionString)
            cn.Open()
            Dim sql = "SELECT nome,cor FROM Categorias WHERE nome = '" & nome & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim lembrete As Lembrete = New Lembrete(dr("nome"), Color.FromArgb((dr("cor"))))
                        cn.Close()
                        Return lembrete
                    Else
                        cn.Close()
                        Throw New CategoriaNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function

End Class
