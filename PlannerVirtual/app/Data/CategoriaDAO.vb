Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class CategoriaDAO
    Implements ICategoriaDAO

    'Constantes estaticas
    Public Shared instancia As CategoriaDAO
    Public Shared iniciado As Boolean

    Private Sub New()
        'construtor privado de forma a desabilitar outro a criar um objeto
    End Sub
    Friend Shared Function getSingletonObject() As CategoriaDAO
        If iniciado = False Then
            instancia = New CategoriaDAO()
            iniciado = True
            Return instancia
        Else
            Return instancia
        End If
    End Function

    Public Sub inserir(categoria As Categoria) Implements ICategoriaDAO.inserir
        Try
            consultar(categoria.nome)
            Throw New CategoriaExistenteException
        Catch ex As CategoriaNaoEncontradaException
            Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Categorias (nome , cor) VALUES ('" & categoria.nome & "', " & categoria.cor.ToArgb & ")"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub deletar(nome As String) Implements ICategoriaDAO.deletar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Categorias WHERE nome = '" & nome & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Sub atualizar(categoria As Categoria, nomeAnterior As String) Implements ICategoriaDAO.atualizar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "UPDATE Categorias SET nome = '" & categoria.nome & "', cor = " & categoria.cor.ToArgb & " WHERE nome = '" & nomeAnterior & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function listar() As List(Of Categoria) Implements ICategoriaDAO.listar

        Dim listaCategorias As List(Of Categoria) = New List(Of Categoria)

        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT nome,cor FROM Categorias ORDER BY nome"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim categoria As Categoria = New Categoria(dr("nome"), Color.FromArgb((dr("cor"))))
                            listaCategorias.Add(categoria)
                        End While

                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaCategorias
    End Function

    Public Function consultar(nome As String) As Categoria Implements ICategoriaDAO.consultar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT nome,cor FROM Categorias WHERE nome = '" & nome & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim categoria As Categoria = New Categoria(dr("nome"), Color.FromArgb((dr("cor"))))
                        cn.Close()
                        Return categoria
                    Else
                        cn.Close()
                        Throw New CategoriaNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function

End Class
