Public Interface ICategoriaDAO

    Sub inserir(ByVal categoria As Categoria)
    Sub deletar(ByVal nome As String)
   
    Function consultar(ByVal nome As String) As Categoria:Function listar() As List(Of Categoria)


End Interface
