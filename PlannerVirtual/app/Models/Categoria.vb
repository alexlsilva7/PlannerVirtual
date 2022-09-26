Imports Microsoft.VisualBasic

Public Class Categoria
    Private _nome As String
    Private _cor As Color
    Private _categoriaDAO As ICategoriaDAO


    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Public Property cor() As Color
        Get
            Return _cor
        End Get
        Set(ByVal value As Color)
            _cor = value
        End Set
    End Property

    Public Sub New(ByVal nome As String, ByVal cor As Color)
        _nome = nome
        _cor = cor
        _categoriaDAO = CategoriaDAO.getSingletonObject
    End Sub
    
    Sub salvar()
        Try
            _categoriaDAO.inserir(Me)
        Catch ex As CategoriaExistenteException
            Throw ex
        End Try
    End Sub

End Class
