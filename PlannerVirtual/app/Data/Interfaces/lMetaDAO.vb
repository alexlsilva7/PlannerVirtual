Public Interface IMetaDAO

    Sub inserir(ByVal meta As Meta)
    Sub deletar(ByVal nome As String)
    Function listar() As List(Of Meta)
    Function consultar(ByVal nome As String) As Meta

End Interface
