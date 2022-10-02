Public Interface ICategoriaDAO

    Sub inserir(ByVal categoria As Categoria)
    Sub deletar(ByVal nome As String)
    Sub atualizar(ByVal categoria As Categoria)
    Function consultar(ByVal nome As String) As Categoria:Function listar() As List(Of Categoria)


End Interface
