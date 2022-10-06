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
        Me.btnAlterarCor.Location = New System.Drawing.Point(99, 84)
        Me.btnAlterarCor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAlterarCor.Name = "btnAlterarCor"
        Me.btnAlterarCor.Size = New System.Drawing.Size(126, 26)
        Me.btnAlterarCor.TabIndex = 22
        Me.btnAlterarCor.Text = "Alterar"
        Me.btnAlterarCor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cor:"
        '
        'panelCor
        '
        Me.panelCor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelCor.Location = New System.Drawing.Point(56, 83)
        Me.panelCor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelCor.Name = "panelCor"
        Me.panelCor.Size = New System.Drawing.Size(35, 23)
        Me.panelCor.TabIndex = 20
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitulo.Location = New System.Drawing.Point(41, 21)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(132, 20)
        Me.lblTitulo.TabIndex = 19
        Me.lblTitulo.Text = "Nova Categoria"
        '
        'txtNomeCategoria
        '
        Me.txtNomeCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCategoria.Location = New System.Drawing.Point(70, 57)
        Me.txtNomeCategoria.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNomeCategoria.Name = "txtNomeCategoria"
        Me.txtNomeCategoria.Size = New System.Drawing.Size(154, 20)
        Me.txtNomeCategoria.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nome:"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.ForeColor = System.Drawing.Color.White
        Me.btnAdicionar.Location = New System.Drawing.Point(22, 118)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(203, 26)
        Me.btnAdicionar.TabIndex = 16
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'FormNovaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(243, 159)
        Me.Controls.Add(Me.btnAlterarCor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.panelCor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtNomeCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(259, 198)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(259, 198)
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
