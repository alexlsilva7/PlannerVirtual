Public Interface ILembreteDAO

    Sub inserir(ByVal lembrete As Lembrete)
    Sub deletar(ByVal id As Integer)
    Function listar() As List(Of Lembrete)
    Function consultar(ByVal nome As String) As Lembrete

End Interface
