Imports Microsoft.VisualBasic

Public Class Lembrete
    Private _descricao As String
    Private _tipoLembrete As TipoLembrete
    Private _data As Date
    Private _LembreteDAO As ILembreteDAO

    Public Sub New(ByVal descricao As String, ByVal data As Date, ByVal tipoLembrete As TipoLembrete)
        _descricao = descricao
        _data = data
        _tipoLembrete = tipoLembrete
        _LembreteDAO = LembreteDAO.getSingletonObject
    End Sub

    Public Property descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property

    Public Property tipoLembrete() As TipoLembrete
        Get
            Return _tipoLembrete
        End Get
        Set(ByVal value As TipoLembrete)
            _tipoLembrete = value
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

    Sub salvar()
        Try
            _LembreteDAO.inserir(Me)
        Catch ex As TarefaExistenteException
            Throw ex
        End Try
    End Sub

End Class

Public Enum TipoLembrete
    ligacoesImportantes
    reunioes
    compras
End Enum