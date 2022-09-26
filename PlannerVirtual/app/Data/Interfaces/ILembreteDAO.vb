Public Interface ILembreteDAO

    Sub inserir(ByVal lembrete As Lembrete)
    Sub deletar(ByVal nome As String)
    Function listar() As List(Of Lembrete)
    Function consultar(ByVal nome As String) As Lembrete

End Interface
