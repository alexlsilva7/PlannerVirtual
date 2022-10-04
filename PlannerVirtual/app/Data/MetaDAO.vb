Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class MetaDAO
    Implements IMetaDAO

    'Constantes estaticas
    Public Shared instancia As MetaDAO
    Public Shared iniciado As Boolean

    Private Sub New()
        'construtor privado de forma a desabilitar outro a criar um objeto
    End Sub
    Friend Shared Function getSingletonObject() As MetaDAO
        If iniciado = False Then
            instancia = New MetaDAO()
            iniciado = True
            Return instancia
        Else
            Return instancia
        End If
    End Function

    Public Sub inserir(meta As Meta) Implements IMetaDAO.inserir
        Try
            consultar(meta.descricao)
            Throw New MetaExistenteException
        Catch ex As MetaNaoEncontradaException
            Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Metas (descricao , tipoMeta , estadoMeta , data) VALUES ('" & meta.descricao & "','" & meta.tipo & "','" & meta.estado & "','" & meta.data & "')"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub deletar(descricao As String) Implements IMetaDAO.deletar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Metas WHERE nome = '" & descricao & "'"
                objCommand.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using
    End Sub

    Public Function listar() As List(Of Meta) Implements IMetaDAO.listar

        Dim listaMetas As List(Of Meta) = New List(Of Meta)

        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "
                            SELECT descricao, Categorias.nome as categoriaNome, Categorias.cor as categoriaCor, tipoMeta, estadoMeta, data
                            FROM Metas, Categorias
                            WHERE Metas.categoria = Categorias.nome
                            ORDER BY descricao
                        "


            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim categoria As Categoria = New Categoria(dr("categoriaNome"), Color.FromArgb(dr("categoriaCor")))
                            Dim meta As Meta = New Meta(dr("descricao"), categoria, dr("data"), dr("tipoMeta"), dr("estadoMeta"))
                            listaMetas.Add(meta)
                        End While
                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaMetas
    End Function

    Public Function listarPorTipo(tipo As TipoMeta) As List(Of Meta) Implements IMetaDAO.listarPorTipo
        Dim listaMetas As List(Of Meta) = New List(Of Meta)

        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "
                            SELECT descricao, Categorias.nome as categoriaNome, Categorias.cor as categoriaCor, tipoMeta, estadoMeta, data
                            FROM Metas, Categorias
                            WHERE Metas.categoria = Categorias.nome AND tipoMeta = '" & tipo & "'
                            ORDER BY descricao
                        "
            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim categoria As Categoria = New Categoria(dr("categoriaNome"), Color.FromArgb(dr("categoriaCor")))
                            Dim meta As Meta = New Meta(dr("descricao"), categoria, dr("data"), dr("tipoMeta"), dr("estadoMeta"))
                            listaMetas.Add(meta)
                        End While
                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaMetas
    End Function

    Public Function consultar(descricao As String) As Meta Implements IMetaDAO.consultar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT nome,cor FROM Metas WHERE descricao = '" & descricao & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim color As Color = ColorTranslator.FromHtml("#FFFFFF")
                        Dim categoria As Categoria = New Categoria("Casa", color)
                        Dim meta As Meta = New Meta(dr("descricao"), categoria, dr("data"), dr("tipoMeta"), dr("estadoMeta"))
                        cn.Close()
                        Return Meta
                    Else
                        cn.Close()
                        Throw New MetaNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function

End Class
