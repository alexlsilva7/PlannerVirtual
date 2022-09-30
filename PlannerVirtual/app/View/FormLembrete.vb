Public Class FormLembrete
    Private _lembreteDAO As ILembreteDAO

    Private Sub FormLembrete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _lembreteDAO = LembreteDAO.getSingletonObject
    End Sub

End Class