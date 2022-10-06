Public Class FormHomeTarefas

    Private formularioAtual As Form = Nothing

    Private Sub FormHomeTarefas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSemanal.Location = New Point(0, 0)
        btnSemanal.Size = New Size(Me.Width / 2, 60)

        btnMensal.Size = New Size(Me.Width / 2, 60)
        btnMensal.Location = New Point(Me.Width - btnMensal.Size.Width, 0)
        btnMensal.ForeColor = Color.Black

        PanelSelecionadoSemanal.Size = New Size(btnSemanal.Size.Width, 5)
        PanelSelecionadoSemanal.Location = New Point(btnSemanal.Location.X, btnSemanal.Location.Y + btnSemanal.Size.Height)
        PanelSelecionadoSemanal.BackColor = Color.FromArgb(67, 97, 238)

        PanelSelecionadoMensal.Size = New Size(btnMensal.Size.Width, 5)
        PanelSelecionadoMensal.Location = New Point(btnMensal.Location.X, btnMensal.Location.Y + btnMensal.Size.Height)
        PanelSelecionadoMensal.BackColor = Color.LightGray

        loadForm(New FormTarefa)
    End Sub


    Private Sub loadForm(form As Form)

        If formularioAtual IsNot Nothing Then formularioAtual.Close()

        formularioAtual = form
        formularioAtual.TopLevel = False
        formularioAtual.FormBorderStyle = FormBorderStyle.None
        formularioAtual.Dock = DockStyle.Fill

        PanelCentral.Controls.Add(formularioAtual)
        PanelCentral.Tag = formularioAtual
        formularioAtual.BringToFront()
        formularioAtual.Show()

    End Sub

    Private Sub btnSemanal_Click(sender As Object, e As EventArgs) Handles btnSemanal.Click
        btnSemanal.ForeColor = Color.FromArgb(67, 97, 238)
        btnMensal.ForeColor = Color.Black

        PanelSelecionadoSemanal.BackColor = Color.FromArgb(67, 97, 238)
        PanelSelecionadoMensal.BackColor = Color.LightGray
        loadForm(New FormTarefa)
    End Sub

    Private Sub btnMensal_Click(sender As Object, e As EventArgs) Handles btnMensal.Click
        btnMensal.ForeColor = Color.FromArgb(67, 97, 238)
        btnSemanal.ForeColor = Color.Black

        PanelSelecionadoMensal.BackColor = Color.FromArgb(67, 97, 238)
        PanelSelecionadoSemanal.BackColor = Color.LightGray
        loadForm(New FormExibirMensal)
    End Sub

End Class