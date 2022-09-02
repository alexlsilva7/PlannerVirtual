Imports Microsoft.VisualBasic

Public Class Tarefa
    Private _descricao As String
    Private _horarioInicio As Date
    Private _horarioFim As Date
    Private _estado As EstadoAtividade
    Private _categoria As Categoria

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

    Public Property horarioFim() As Date
        Get
            Return _horarioFim
        End Get
        Set(ByVal value As Date)
            _horarioFim = value
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

    Public Sub New(ByVal descricao As String, ByVal horarioInicio Date, ByVal horarioFim As Date)
        _descricao = descricao
        _horarioInicio = horarioInicio
        _horarioFim = _horarioFim
        _estado = EstadoAtividade.aExecutar
    End Sub

    Sub alterarEstado(est As EstadoAtividade)
        _estado = est
    End Sub

End Class

Public Enum EstadoAtividade
    aExecutar
    executada
    parcialmenteExecutada
    adiada
End Enum


