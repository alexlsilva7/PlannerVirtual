Public Interface IMetaDAO

    Sub inserir(ByVal meta As Meta)
    Sub deletar(ByVal id As Integer)
    Sub atualizar(meta As Meta)
    Function listar() As List(Of Meta)
    Function listarPorTipo(tipo As TipoMeta) As List(Of Meta)
    Function consultar(ByVal id As Integer) As Meta
    Function listarEntreDatas(dataInicial As Date, dataFinal As Date) As List(Of Meta)
End Interface
