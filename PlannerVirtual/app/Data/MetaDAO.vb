Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Windows.Controls

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
            consultar(meta.id)
            Throw New MetaExistenteException
        Catch ex As MetaNaoEncontradaException
            Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "INSERT INTO Metas (descricao, data , estado, tipo, categoria) VALUES ('" & meta.descricao & "','" & meta.data.ToString("dd-MM-yyyy HH:mm") & "','" & CInt(meta.estado) & "','" & meta.tipo & "','" & meta.categoria.nome & "')"
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        End Try
    End Sub

    Public Sub atualizar(meta As Meta) Implements IMetaDAO.atualizar
        Try
            Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
                cn.Open()
                Using objCommand As SQLiteCommand = cn.CreateCommand()
                    objCommand.CommandText = "UPDATE Metas SET descricao = '" & meta.descricao & "', data = '" & meta.data.ToString("dd-MM-yyyy") & "', estado = '" & meta.estado & "', tipo = '" & meta.tipo & "', categoria = '" & meta.categoria.nome & "' WHERE id = " & meta.id
                    objCommand.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        Catch ex As MetaNaoEncontradaException
            Throw New MetaNaoEncontradaException
        End Try
    End Sub

    Public Sub deletar(id As Integer) Implements IMetaDAO.deletar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Using objCommand As SQLiteCommand = cn.CreateCommand()
                objCommand.CommandText = "DELETE FROM Metas WHERE id = '" & id & "'"
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
                            SELECT id, descricao, categoria, tipo, estado, data
                            FROM Metas
                            
                        "


            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim categoria As Categoria = CategoriaDAO.getSingletonObject.consultar(dr("categoria"))
                            Dim meta As Meta = New Meta(dr("descricao"), categoria, dr("data"), dr("tipo"), dr("estado"))
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
                            SELECT id, descricao, Categorias.nome as categoriaNome, Categorias.cor as categoriaCor, tipo, estado, data
                            FROM Metas, Categorias
                            WHERE Metas.categoria = Categorias.nome
                            AND tipo = '" & tipo & "'
                            ORDER BY id
                        "
            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            Dim categoria As Categoria = New Categoria(dr("categoriaNome"), Color.FromArgb(dr("categoriaCor")))
                            Dim meta As Meta = New Meta(dr("descricao"), categoria, dr("data"), dr("tipo"), dr("estado"), dr("id"))
                            listaMetas.Add(meta)
                        End While
                    End If
                End Using
            End Using

            cn.Close()
        End Using

        Return listaMetas
    End Function

    Public Function listarEntreDatas(ByVal dataInicial As Date, ByVal dataFinal As Date) As List(Of Meta) Implements IMetaDAO.listarEntreDatas
        Dim listaMetas As List(Of Meta) = listar()

        Dim listarMetasFiltradas As List(Of Meta) = listaMetas.FindAll(Function(meta As Meta) meta.data >= dataInicial And meta.data <= dataFinal)

        Return listarMetasFiltradas
    End Function

    Function consultar(id As Integer) As Meta Implements IMetaDAO.consultar
        Using cn = New SQLiteConnection(DatabaseConfiguration.getConnectionString)
            cn.Open()
            Dim sql = "SELECT id, descricao, categoria, tipo, estado, data FROM Metas WHERE id = '" & id & "'"

            Using cmd = New SQLiteCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        Dim categoria = CategoriaDAO.getSingletonObject().consultar(dr("categoria"))
                        Dim _meta As Meta = New Meta(dr("descricao"), categoria, dr("data"), dr("tipo"), dr("estado"), dr("id"))
                        cn.Close()
                        Return _meta
                    Else
                        cn.Close()
                        Throw New MetaNaoEncontradaException
                    End If
                End Using
            End Using
        End Using
    End Function


End Class
