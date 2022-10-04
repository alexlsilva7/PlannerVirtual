<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMeta
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
        Me.listViewSemanais = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descrição = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListViewMensais = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListViewAnuais = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdicionarMeta = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewSemanais
        '
        Me.listViewSemanais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.Descrição, Me.Categoria, Me.Estado, Me.Data})
        Me.listViewSemanais.FullRowSelect = True
        Me.listViewSemanais.HideSelection = False
        Me.listViewSemanais.Location = New System.Drawing.Point(12, 159)
        Me.listViewSemanais.MultiSelect = False
        Me.listViewSemanais.Name = "listViewSemanais"
        Me.listViewSemanais.Size = New System.Drawing.Size(933, 91)
        Me.listViewSemanais.TabIndex = 1
        Me.listViewSemanais.UseCompatibleStateImageBehavior = False
        Me.listViewSemanais.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "Id"
        '
        'Descrição
        '
        Me.Descrição.Text = "Descrição"
        Me.Descrição.Width = 218
        '
        'Categoria
        '
        Me.Categoria.Text = "Categoria"
        Me.Categoria.Width = 169
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        Me.Estado.Width = 120
        '
        'Data
        '
        Me.Data.Text = "Data"
        Me.Data.Width = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Semanais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mensais"
        '
        'ListViewMensais
        '
        Me.ListViewMensais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewMensais.FullRowSelect = True
        Me.ListViewMensais.HideSelection = False
        Me.ListViewMensais.Location = New System.Drawing.Point(12, 328)
        Me.ListViewMensais.MultiSelect = False
        Me.ListViewMensais.Name = "ListViewMensais"
        Me.ListViewMensais.Size = New System.Drawing.Size(933, 84)
        Me.ListViewMensais.TabIndex = 3
        Me.ListViewMensais.UseCompatibleStateImageBehavior = False
        Me.ListViewMensais.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Id"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Descrição"
        Me.ColumnHeader1.Width = 218
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Categoria"
        Me.ColumnHeader2.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Estado"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Data"
        Me.ColumnHeader5.Width = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Anuais"
        '
        'ListViewAnuais
        '
        Me.ListViewAnuais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListViewAnuais.FullRowSelect = True
        Me.ListViewAnuais.HideSelection = False
        Me.ListViewAnuais.Location = New System.Drawing.Point(15, 488)
        Me.ListViewAnuais.MultiSelect = False
        Me.ListViewAnuais.Name = "ListViewAnuais"
        Me.ListViewAnuais.Size = New System.Drawing.Size(930, 84)
        Me.ListViewAnuais.TabIndex = 5
        Me.ListViewAnuais.UseCompatibleStateImageBehavior = False
        Me.ListViewAnuais.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Id"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Descrição"
        Me.ColumnHeader6.Width = 218
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Categoria"
        Me.ColumnHeader7.Width = 169
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Estado"
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Data"
        Me.ColumnHeader10.Width = 113
        '
        'btnAdicionarMeta
        '
        Me.btnAdicionarMeta.Location = New System.Drawing.Point(434, 269)
        Me.btnAdicionarMeta.Name = "btnAdicionarMeta"
        Me.btnAdicionarMeta.Size = New System.Drawing.Size(107, 23)
        Me.btnAdicionarMeta.TabIndex = 7
        Me.btnAdicionarMeta.Text = "Criar"
        Me.btnAdicionarMeta.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(590, 269)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Deletar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(274, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(590, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Deletar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(274, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Atualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(434, 418)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Criar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(590, 578)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 23)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Deletar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(274, 578)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Atualizar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(434, 578)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Criar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(763, 79)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(65, 23)
        Me.Button12.TabIndex = 35
        Me.Button12.Text = "Atual"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(1032, 76)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(35, 23)
        Me.Button13.TabIndex = 34
        Me.Button13.Text = ">"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(885, 84)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(46, 13)
        Me.lblSemana.TabIndex = 33
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(907, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Semana"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(844, 79)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(35, 23)
        Me.Button14.TabIndex = 31
        Me.Button14.Text = "<"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(487, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Mês"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Location = New System.Drawing.Point(155, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Ano"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(27, 79)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(65, 23)
        Me.Button9.TabIndex = 46
        Me.Button9.Text = "Atual"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(296, 76)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(35, 23)
        Me.Button10.TabIndex = 45
        Me.Button10.Text = ">"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Ano"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(108, 79)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(35, 23)
        Me.Button11.TabIndex = 43
        Me.Button11.Text = "<"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(394, 79)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(65, 23)
        Me.Button15.TabIndex = 50
        Me.Button15.Text = "Atual"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(663, 76)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(35, 23)
        Me.Button16.TabIndex = 49
        Me.Button16.Text = ">"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Mês"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(475, 79)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(35, 23)
        Me.Button17.TabIndex = 47
        Me.Button17.Text = "<"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'FormMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 648)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdicionarMeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListViewAnuais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListViewMensais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listViewSemanais)
        Me.Name = "FormMeta"
        Me.Text = "FormMeta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listViewSemanais As ListView
    Friend WithEvents Descrição As ColumnHeader
    Friend WithEvents Categoria As ColumnHeader
    Friend WithEvents Estado As ColumnHeader
    Friend WithEvents Data As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListViewMensais As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents ListViewAnuais As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnAdicionarMeta As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents id As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button17 As Button
End Class
