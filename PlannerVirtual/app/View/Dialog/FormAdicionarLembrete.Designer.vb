<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdicionarLembrete
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdicionarLembrete = New System.Windows.Forms.Button()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdicionarLembrete
        '
        Me.btnAdicionarLembrete.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAdicionarLembrete.FlatAppearance.BorderSize = 0
        Me.btnAdicionarLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarLembrete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarLembrete.ForeColor = System.Drawing.Color.White
        Me.btnAdicionarLembrete.Location = New System.Drawing.Point(26, 161)
        Me.btnAdicionarLembrete.Name = "btnAdicionarLembrete"
        Me.btnAdicionarLembrete.Size = New System.Drawing.Size(272, 26)
        Me.btnAdicionarLembrete.TabIndex = 0
        Me.btnAdicionarLembrete.Text = "Adicionar Lembrete"
        Me.btnAdicionarLembrete.UseVisualStyleBackColor = False
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(73, 120)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(230, 20)
        Me.DatePicker.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(111, 74)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(192, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descrição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitulo.Location = New System.Drawing.Point(22, 26)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(139, 18)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Novo Lembrete - "
        '
        'FormAdicionarLembrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(323, 199)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.btnAdicionarLembrete)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(339, 238)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(339, 238)
        Me.Name = "FormAdicionarLembrete"
        Me.Text = "FormAdicionarLembrete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdicionarLembrete As Button
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitulo As Label
End Class
