<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNovaCategoria
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAlterarCor = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelCor = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNomeCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'btnAlterarCor
        '
        Me.btnAlterarCor.Location = New System.Drawing.Point(85, 84)
        Me.btnAlterarCor.Name = "btnAlterarCor"
        Me.btnAlterarCor.Size = New System.Drawing.Size(108, 23)
        Me.btnAlterarCor.TabIndex = 22
        Me.btnAlterarCor.Text = "Alterar"
        Me.btnAlterarCor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cor:"
        '
        'panelCor
        '
        Me.panelCor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelCor.Location = New System.Drawing.Point(48, 83)
        Me.panelCor.Name = "panelCor"
        Me.panelCor.Size = New System.Drawing.Size(30, 23)
        Me.panelCor.TabIndex = 20
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(35, 21)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(132, 20)
        Me.lblTitulo.TabIndex = 19
        Me.lblTitulo.Text = "Nova Categoria"
        '
        'txtNomeCategoria
        '
        Me.txtNomeCategoria.Location = New System.Drawing.Point(60, 57)
        Me.txtNomeCategoria.Name = "txtNomeCategoria"
        Me.txtNomeCategoria.Size = New System.Drawing.Size(133, 20)
        Me.txtNomeCategoria.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nome:"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(19, 118)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(174, 23)
        Me.btnAdicionar.TabIndex = 16
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'FormNovaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 153)
        Me.Controls.Add(Me.btnAlterarCor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.panelCor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtNomeCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Name = "FormNovaCategoria"
        Me.Text = "FormNovaCategoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAlterarCor As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents panelCor As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNomeCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
