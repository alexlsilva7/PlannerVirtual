<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdicionarTarefa
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnAdicionarTarefa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SelecionarCategoria = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(12, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(111, 18)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Nova Tarefa -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(91, 56)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(314, 20)
        Me.txtDescricao.TabIndex = 8
        '
        'btnAdicionarTarefa
        '
        Me.btnAdicionarTarefa.Location = New System.Drawing.Point(66, 245)
        Me.btnAdicionarTarefa.Name = "btnAdicionarTarefa"
        Me.btnAdicionarTarefa.Size = New System.Drawing.Size(272, 23)
        Me.btnAdicionarTarefa.TabIndex = 6
        Me.btnAdicionarTarefa.Text = "Adicionar Tarefa"
        Me.btnAdicionarTarefa.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Duração:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 138)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(324, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Horário Inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Categoria"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"A Executar", "Executada", "Parcialmente Executada", "Adiada"})
        Me.ComboBox2.Location = New System.Drawing.Point(81, 171)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(324, 21)
        Me.ComboBox2.TabIndex = 21
        '
        'SelecionarCategoria
        '
        Me.SelecionarCategoria.Location = New System.Drawing.Point(85, 207)
        Me.SelecionarCategoria.Name = "SelecionarCategoria"
        Me.SelecionarCategoria.Size = New System.Drawing.Size(237, 23)
        Me.SelecionarCategoria.TabIndex = 22
        Me.SelecionarCategoria.Text = "Selecionar Categoria"
        Me.SelecionarCategoria.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 100)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(302, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'FormAdicionarTarefa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 280)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.SelecionarCategoria)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.btnAdicionarTarefa)
        Me.Name = "FormAdicionarTarefa"
        Me.Text = "FormAdicionarTarefa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents btnAdicionarTarefa As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents SelecionarCategoria As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
