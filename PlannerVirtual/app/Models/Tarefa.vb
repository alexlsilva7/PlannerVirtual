Imports Microsoft.VisualBasic

Public Class Tarefa
    Private _id As Integer
    Private _descricao As String
    Private _horarioInicio As Date
    Private _duracao As Integer
    Private _estado As EstadoAtividade
    Private _categoria As Categoria
    Private _TarefaDAO As ITarefaDAO

    Public ReadOnly Property id() As Integer
        Get
            Return _id
        End Get
    End Property

    Public Property descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property

    Public Property horarioInicio() As Date
        Get
            Return _horarioInicio
        End Get
        Set(ByVal value As Date)
            _horarioInicio = value
        End Set
    End Property

    Public Property duracao() As Integer
        Get
            Return _duracao
        End Get
        Set(ByVal value As Integer)
            _duracao = value
        End Set
    End Property

    Public Property estado() As EstadoAtividade
        Get
            Return _estado
        End Get
        Set(ByVal value As EstadoAtividade)
            _estado = value
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

    Public Sub New(ByVal descricao As String, ByVal horarioInicio As Date, ByVal duracao As Integer, ByVal estado As EstadoAtividade, Optional ByVal id As Integer = -1)
        If (id <> -1) Then
            _id = id
        End If
        _descricao = descricao
        _horarioInicio = horarioInicio
        _duracao = duracao
        _estado = estado
        _TarefaDAO = TarefaDAO.getSingletonObject

    End Sub

    Sub alterarEstado(est As EstadoAtividade)
        _estado = est
    End Sub

    Sub salvar()
        Try
            _TarefaDAO.inserir(Me)
        Catch ex As TarefaExistenteException
            Throw ex
        End Try
    End Sub

    Sub concluir()
        _estado = EstadoAtividade.executada
    End Sub

End Class

Public Enum EstadoAtividade
    aExecutar
    executada
    parcialmenteExecutada
    adiada
End Enum


