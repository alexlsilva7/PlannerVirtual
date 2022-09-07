Public Interface ICategoriaDAO

    Sub inserir(ByVal categoria As Categoria)
    Sub deletar(ByVal id As String)
    Function listar() As List(Of Categoria)
    Function consultar(ByVal id As String) As Categoria

End Interface
