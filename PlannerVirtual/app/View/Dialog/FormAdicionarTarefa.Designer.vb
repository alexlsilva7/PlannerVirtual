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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SelecionarCategoria = New System.Windows.Forms.Button()
        Me.DateTimePickerData = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerHora = New System.Windows.Forms.DateTimePicker()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
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
        Me.btnAdicionarTarefa.Location = New System.Drawing.Point(72, 254)
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
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Duração:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Data:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Categoria"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"A Executar", "Executada", "Parcialmente Executada", "Adiada"})
        Me.ComboBox2.Location = New System.Drawing.Point(82, 177)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(308, 21)
        Me.ComboBox2.TabIndex = 21
        '
        'SelecionarCategoria
        '
        Me.SelecionarCategoria.Location = New System.Drawing.Point(86, 213)
        Me.SelecionarCategoria.Name = "SelecionarCategoria"
        Me.SelecionarCategoria.Size = New System.Drawing.Size(237, 23)
        Me.SelecionarCategoria.TabIndex = 22
        Me.SelecionarCategoria.Text = "Selecionar Categoria"
        Me.SelecionarCategoria.UseVisualStyleBackColor = True
        '
        'DateTimePickerData
        '
        Me.DateTimePickerData.Location = New System.Drawing.Point(57, 96)
        Me.DateTimePickerData.Name = "DateTimePickerData"
        Me.DateTimePickerData.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePickerData.TabIndex = 23
        '
        'DateTimePickerHora
        '
        Me.DateTimePickerHora.Location = New System.Drawing.Point(302, 139)
        Me.DateTimePickerHora.Name = "DateTimePickerHora"
        Me.DateTimePickerHora.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePickerHora.TabIndex = 24
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(255, 143)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(41, 16)
        Me.lblHora.TabIndex = 25
        Me.lblHora.Text = "Inicio:"
        '
        'ComboBox
        '
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Items.AddRange(New Object() {"30 min", "1 h", "De manhã (8h às 12h)", "De tarde (13h às 17h)", "De noite (18h às 22h)"})
        Me.ComboBox.Location = New System.Drawing.Point(80, 138)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(163, 21)
        Me.ComboBox.TabIndex = 26
        '
        'FormAdicionarTarefa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 301)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.DateTimePickerHora)
        Me.Controls.Add(Me.DateTimePickerData)
        Me.Controls.Add(Me.SelecionarCategoria)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents SelecionarCategoria As Button
    Friend WithEvents DateTimePickerData As DateTimePicker
    Friend WithEvents DateTimePickerHora As DateTimePicker
    Friend WithEvents lblHora As Label
    Friend WithEvents ComboBox As ComboBox
End Class
