Public Interface IMetaDAO

    Sub inserir(ByVal meta As Meta)
    Sub deletar(ByVal nome As String)
    Sub atualizar(meta As Meta)
    Function listar() As List(Of Meta)
    Function listarPorTipo(tipo As TipoMeta) As List(Of Meta)
    Function consultar(ByVal id As Integer) As Meta
End Interface
