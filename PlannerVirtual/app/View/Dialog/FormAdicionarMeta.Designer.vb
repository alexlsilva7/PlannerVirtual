<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdicionarMeta
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
        Me.DateTimePickerData = New System.Windows.Forms.DateTimePicker()
        Me.SelecionarCategoria = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdicionarMeta = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DateTimePickerData
        '
        Me.DateTimePickerData.Location = New System.Drawing.Point(74, 55)
        Me.DateTimePickerData.Name = "DateTimePickerData"
        Me.DateTimePickerData.Size = New System.Drawing.Size(259, 20)
        Me.DateTimePickerData.TabIndex = 37
        '
        'SelecionarCategoria
        '
        Me.SelecionarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelecionarCategoria.Location = New System.Drawing.Point(106, 132)
        Me.SelecionarCategoria.Name = "SelecionarCategoria"
        Me.SelecionarCategoria.Size = New System.Drawing.Size(227, 26)
        Me.SelecionarCategoria.TabIndex = 36
        Me.SelecionarCategoria.Text = "Selecionar Categoria"
        Me.SelecionarCategoria.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Data:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitulo.Location = New System.Drawing.Point(24, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(89, 18)
        Me.lblTitulo.TabIndex = 30
        Me.lblTitulo.Text = "Nova Meta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Descrição:"
        '
        'btnAdicionarMeta
        '
        Me.btnAdicionarMeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAdicionarMeta.FlatAppearance.BorderSize = 0
        Me.btnAdicionarMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarMeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarMeta.ForeColor = System.Drawing.Color.White
        Me.btnAdicionarMeta.Location = New System.Drawing.Point(24, 252)
        Me.btnAdicionarMeta.Name = "btnAdicionarMeta"
        Me.btnAdicionarMeta.Size = New System.Drawing.Size(309, 26)
        Me.btnAdicionarMeta.TabIndex = 27
        Me.btnAdicionarMeta.Text = "Adicionar Meta"
        Me.btnAdicionarMeta.UseVisualStyleBackColor = False
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(109, 172)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(227, 54)
        Me.txtDescricao.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Estado:"
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Items.AddRange(New Object() {"Cumprida", "Não Cumprido", "Parcialmente Cumprido"})
        Me.ComboBoxEstado.Location = New System.Drawing.Point(91, 97)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(242, 21)
        Me.ComboBoxEstado.TabIndex = 42
        '
        'FormAdicionarMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 293)
        Me.Controls.Add(Me.ComboBoxEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerData)
        Me.Controls.Add(Me.SelecionarCategoria)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.btnAdicionarMeta)
        Me.Location = New System.Drawing.Point(366, 332)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(366, 332)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(366, 332)
        Me.Name = "FormAdicionarMeta"
        Me.Text = "FormAdicionarMeta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePickerData As DateTimePicker
    Friend WithEvents SelecionarCategoria As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdicionarMeta As Button
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxEstado As ComboBox
End Class
