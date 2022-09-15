Public Interface ICategoriaDAO

    Sub inserir(ByVal categoria As Categoria)
    Sub deletar(ByVal nome As String)
    Function listar() As List(Of Categoria)
    Function consultar(ByVal nome As String) As Categoria

End Interface
