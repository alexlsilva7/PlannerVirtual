Public Class FormHomePage

    Private formularioAtual As Form = Nothing

    Private Sub FormHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        loadForm(New FormHomeTarefas)
    End Sub

    Private Sub loadForm(form As Form)

        If formularioAtual IsNot Nothing Then formularioAtual.Close()

        formularioAtual = form
        formularioAtual.TopLevel = False
        formularioAtual.FormBorderStyle = FormBorderStyle.None
        formularioAtual.Dock = DockStyle.Fill

        PanelCenter.Controls.Add(formularioAtual)
        PanelCenter.Tag = formularioAtual
        formularioAtual.BringToFront()
        formularioAtual.Show()

    End Sub

    Private Sub btnTarefas_Click(sender As Object, e As EventArgs) Handles btnTarefas.Click
        loadForm(New FormHomeTarefas)
        btnTarefas.BackColor = Color.FromArgb(67, 97, 238)
        btnTarefas.ForeColor = Color.White

        btnMetas.BackColor = Color.Transparent
        btnMetas.ForeColor = Color.FromArgb(67, 97, 238)
        btnLembretes.BackColor = Color.Transparent
        btnLembretes.ForeColor = Color.FromArgb(67, 97, 238)
        btnRelatorios.BackColor = Color.Transparent
        btnRelatorios.ForeColor = Color.FromArgb(67, 97, 238)
    End Sub



    Private Sub btnMetas_Click(sender As Object, e As EventArgs) Handles btnMetas.Click
        loadForm(New FormMeta)
        btnMetas.BackColor = Color.FromArgb(67, 97, 238)
        btnMetas.ForeColor = Color.White

        btnTarefas.BackColor = Color.Transparent
        btnTarefas.ForeColor = Color.FromArgb(67, 97, 238)
        btnLembretes.BackColor = Color.Transparent
        btnLembretes.ForeColor = Color.FromArgb(67, 97, 238)
        btnRelatorios.BackColor = Color.Transparent
        btnRelatorios.ForeColor = Color.FromArgb(67, 97, 238)
    End Sub

    Private Sub btnLembretes_Click(sender As Object, e As EventArgs) Handles btnLembretes.Click
        loadForm(New FormLembrete)
        btnLembretes.BackColor = Color.FromArgb(67, 97, 238)
        btnLembretes.ForeColor = Color.White

        btnTarefas.BackColor = Color.Transparent
        btnTarefas.ForeColor = Color.FromArgb(67, 97, 238)
        btnMetas.BackColor = Color.Transparent
        btnMetas.ForeColor = Color.FromArgb(67, 97, 238)
        btnRelatorios.BackColor = Color.Transparent
        btnRelatorios.ForeColor = Color.FromArgb(67, 97, 238)
    End Sub

    Private Sub btnRelatorios_Click(sender As Object, e As EventArgs) Handles btnRelatorios.Click
        loadForm(New FormHomeRelatorios)
        btnRelatorios.BackColor = Color.FromArgb(67, 97, 238)
        btnRelatorios.ForeColor = Color.White

        btnLembretes.BackColor = Color.Transparent
        btnLembretes.ForeColor = Color.FromArgb(67, 97, 238)
        btnTarefas.BackColor = Color.Transparent
        btnTarefas.ForeColor = Color.FromArgb(67, 97, 238)
        btnMetas.BackColor = Color.Transparent
        btnMetas.ForeColor = Color.FromArgb(67, 97, 238)
    End Sub
End Class