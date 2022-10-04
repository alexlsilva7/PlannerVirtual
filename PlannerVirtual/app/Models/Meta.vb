Imports Microsoft.VisualBasic

Public Class Meta
    Private _id As Integer
    Private _descricao As String
    Private _categoria As Categoria
    Private _tipo As TipoMeta
    Private _estado As EstadoMeta
    Private _data As Date
    Private _MetaDAO As IMetaDAO

    Public Sub New(ByVal descricao As String, ByVal categoria As Categoria, ByVal data As Date, ByVal tipo As TipoMeta, ByVal estado As EstadoMeta, Optional ByVal id As Integer = -1)
        If id <> -1 Then
            _id = id
        End If
        _descricao = descricao
        _data = data
        _tipo = tipo
        _categoria = categoria
        _estado = EstadoMeta.naoCumprida
        _MetaDAO = MetaDAO.getSingletonObject
    End Sub

    Public Property descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property

    Public Property estado() As EstadoMeta
        Get
            Return _estado
        End Get
        Set(ByVal value As EstadoMeta)
            _estado = value
        End Set
    End Property

    Public Property tipo() As TipoMeta
        Get
            Return _tipo
        End Get
        Set(ByVal value As TipoMeta)
            _tipo = value
        End Set
    End Property

    Public Property categoria() As Categoria
        Get
            Return _categoria
        End Get
        Set(ByVal value As Categoria)
            _categoria = value
        End Set
    End Property

    Public Property data() As Date
        Get
            Return _data
        End Get
        Set(ByVal value As Date)
            _data = value
        End Set
    End Property

    Sub alterarEstado(est As EstadoMeta)
        _estado = est
    End Sub

    Sub salvar()
        Try
            _MetaDAO.inserir(Me)
        Catch ex As MetaExistenteException
            Throw ex
        End Try
    End Sub

    Sub concluir()
        _estado = EstadoMeta.cumprida
    End Sub
End Class

Public Enum TipoMeta
    semanal
    mensal
    anual
End Enum

Public Enum EstadoMeta
    cumprida
    naoCumprida
    parcialmenteCumprida
End Enum