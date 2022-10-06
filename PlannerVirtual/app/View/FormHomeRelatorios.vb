Public Class FormHomeRelatorios

    Private formularioAtual As Form = Nothing

    Private Sub FormHomeRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnProdutividade.Location = New Point(0, 0)
        btnProdutividade.Size = New Size(Me.Width / 3, 60)

        btnMaisRealizadas.Size = New Size(Me.Width / 3, 60)
        btnMaisRealizadas.Location = New Point(Me.Width - (btnMaisRealizadas.Size.Width * 2), 0)
        btnMaisRealizadas.ForeColor = Color.Black

        btnQuantidade.Size = New Size(Me.Width / 3, 60)
        btnQuantidade.Location = New Point(Me.Width - btnQuantidade.Size.Width, 0)
        btnQuantidade.ForeColor = Color.Black

        PanelSelecionadoProdutividade.Size = New Size(btnProdutividade.Size.Width, 5)
        PanelSelecionadoProdutividade.Location = New Point(btnProdutividade.Location.X, btnProdutividade.Location.Y + btnProdutividade.Size.Height)
        PanelSelecionadoProdutividade.BackColor = Color.FromArgb(67, 97, 238)

        PanelSelecionadoMaisRealizadas.Size = New Size(btnMaisRealizadas.Size.Width, 5)
        PanelSelecionadoMaisRealizadas.Location = New Point(btnMaisRealizadas.Location.X, btnMaisRealizadas.Location.Y + btnMaisRealizadas.Size.Height)
        PanelSelecionadoMaisRealizadas.BackColor = Color.LightGray

        PanelSelecionadoQuantidade.Size = New Size(btnQuantidade.Size.Width, 5)
        PanelSelecionadoQuantidade.Location = New Point(btnQuantidade.Location.X, btnQuantidade.Location.Y + btnQuantidade.Size.Height)
        PanelSelecionadoQuantidade.BackColor = Color.LightGray

        'loadForm(New FormRelatorio)
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

    Private Sub btnProdutividade_Click(sender As Object, e As EventArgs) Handles btnProdutividade.Click
        btnProdutividade.ForeColor = Color.FromArgb(67, 97, 238)
        btnMaisRealizadas.ForeColor = Color.Black
        btnQuantidade.ForeColor = Color.Black

        PanelSelecionadoProdutividade.BackColor = Color.FromArgb(67, 97, 238)
        PanelSelecionadoMaisRealizadas.BackColor = Color.LightGray
        PanelSelecionadoQuantidade.BackColor = Color.LightGray
        'loadForm(New FormTarefa)
    End Sub

    Private Sub btnMaisRealizadas_Click(sender As Object, e As EventArgs) Handles btnMaisRealizadas.Click
        btnMaisRealizadas.ForeColor = Color.FromArgb(67, 97, 238)
        btnProdutividade.ForeColor = Color.Black
        btnQuantidade.ForeColor = Color.Black

        PanelSelecionadoMaisRealizadas.BackColor = Color.FromArgb(67, 97, 238)
        PanelSelecionadoProdutividade.BackColor = Color.LightGray
        PanelSelecionadoQuantidade.BackColor = Color.LightGray
        'loadForm(New FormTarefa)
    End Sub

    Private Sub btnQuantidade_Click(sender As Object, e As EventArgs) Handles btnQuantidade.Click
        btnQuantidade.ForeColor = Color.FromArgb(67, 97, 238)
        btnProdutividade.ForeColor = Color.Black
        btnMaisRealizadas.ForeColor = Color.Black

        PanelSelecionadoQuantidade.BackColor = Color.FromArgb(67, 97, 238)
        PanelSelecionadoProdutividade.BackColor = Color.LightGray
        PanelSelecionadoMaisRealizadas.BackColor = Color.LightGray
        'loadForm(New FormTarefa)
    End Sub
End Class