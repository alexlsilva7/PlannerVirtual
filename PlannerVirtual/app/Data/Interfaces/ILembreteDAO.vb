Public Interface ILembreteDAO

    Sub inserir(ByVal lembrete As Lembrete)
    Sub deletar(ByVal id As Integer)
    Function getLembretesByTipo(tipoLembrete As TipoLembrete) As List(Of Lembrete)
    Function getAllLembretes() As List(Of Lembrete)
    Function consultar(ByVal id As Integer) As Lembrete

    Sub atualizar(ByVal lembrete As Lembrete)

End Interface
