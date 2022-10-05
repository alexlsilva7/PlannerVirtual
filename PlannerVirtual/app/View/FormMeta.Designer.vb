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
        Me.ListViewMensais = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.btnSemanaAtual = New System.Windows.Forms.Button()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.btnAnoAtual = New System.Windows.Forms.Button()
        Me.btnAvancarAno = New System.Windows.Forms.Button()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.btnVoltarAno = New System.Windows.Forms.Button()
        Me.btnMesAtual = New System.Windows.Forms.Button()
        Me.btnAvancarMes = New System.Windows.Forms.Button()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.btnVoltarMes = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listViewSemanais
        '
        Me.listViewSemanais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.Descrição, Me.Categoria, Me.Estado, Me.Data})
        Me.listViewSemanais.FullRowSelect = True
        Me.listViewSemanais.HideSelection = False
        Me.listViewSemanais.Location = New System.Drawing.Point(12, 56)
        Me.listViewSemanais.MultiSelect = False
        Me.listViewSemanais.Name = "listViewSemanais"
        Me.listViewSemanais.Size = New System.Drawing.Size(745, 200)
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
        'ListViewMensais
        '
        Me.ListViewMensais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewMensais.FullRowSelect = True
        Me.ListViewMensais.HideSelection = False
        Me.ListViewMensais.Location = New System.Drawing.Point(8, 341)
        Me.ListViewMensais.MultiSelect = False
        Me.ListViewMensais.Name = "ListViewMensais"
        Me.ListViewMensais.Size = New System.Drawing.Size(745, 200)
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
        'ListViewAnuais
        '
        Me.ListViewAnuais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListViewAnuais.FullRowSelect = True
        Me.ListViewAnuais.HideSelection = False
        Me.ListViewAnuais.Location = New System.Drawing.Point(8, 660)
        Me.ListViewAnuais.MultiSelect = False
        Me.ListViewAnuais.Name = "ListViewAnuais"
        Me.ListViewAnuais.Size = New System.Drawing.Size(745, 200)
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
        Me.ColumnHeader6.Width = 253
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Categoria"
        Me.ColumnHeader7.Width = 169
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Estado"
        Me.ColumnHeader9.Width = 128
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Data"
        Me.ColumnHeader10.Width = 129
        '
        'btnAdicionarMeta
        '
        Me.btnAdicionarMeta.Location = New System.Drawing.Point(120, 262)
        Me.btnAdicionarMeta.Name = "btnAdicionarMeta"
        Me.btnAdicionarMeta.Size = New System.Drawing.Size(107, 23)
        Me.btnAdicionarMeta.TabIndex = 7
        Me.btnAdicionarMeta.Text = "Criar"
        Me.btnAdicionarMeta.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(233, 262)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Deletar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 547)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Deletar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 547)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Atualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(116, 547)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Criar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(229, 866)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 23)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Deletar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(8, 866)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Atualizar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(116, 866)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Criar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnSemanaAtual
        '
        Me.btnSemanaAtual.Location = New System.Drawing.Point(195, 27)
        Me.btnSemanaAtual.Name = "btnSemanaAtual"
        Me.btnSemanaAtual.Size = New System.Drawing.Size(65, 23)
        Me.btnSemanaAtual.TabIndex = 35
        Me.btnSemanaAtual.Text = "Atual"
        Me.btnSemanaAtual.UseVisualStyleBackColor = True
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.Location = New System.Drawing.Point(464, 27)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnAvancarSemana.TabIndex = 34
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = True
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(321, 34)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(46, 13)
        Me.lblSemana.TabIndex = 33
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.Location = New System.Drawing.Point(280, 27)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnVoltarSemana.TabIndex = 31
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = True
        '
        'btnAnoAtual
        '
        Me.btnAnoAtual.Location = New System.Drawing.Point(195, 631)
        Me.btnAnoAtual.Name = "btnAnoAtual"
        Me.btnAnoAtual.Size = New System.Drawing.Size(65, 23)
        Me.btnAnoAtual.TabIndex = 46
        Me.btnAnoAtual.Text = "Atual"
        Me.btnAnoAtual.UseVisualStyleBackColor = True
        '
        'btnAvancarAno
        '
        Me.btnAvancarAno.Location = New System.Drawing.Point(462, 631)
        Me.btnAvancarAno.Name = "btnAvancarAno"
        Me.btnAvancarAno.Size = New System.Drawing.Size(35, 23)
        Me.btnAvancarAno.TabIndex = 45
        Me.btnAvancarAno.Text = ">"
        Me.btnAvancarAno.UseVisualStyleBackColor = True
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(317, 636)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(26, 13)
        Me.lblAno.TabIndex = 44
        Me.lblAno.Text = "Ano"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarAno
        '
        Me.btnVoltarAno.Location = New System.Drawing.Point(276, 631)
        Me.btnVoltarAno.Name = "btnVoltarAno"
        Me.btnVoltarAno.Size = New System.Drawing.Size(35, 23)
        Me.btnVoltarAno.TabIndex = 43
        Me.btnVoltarAno.Text = "<"
        Me.btnVoltarAno.UseVisualStyleBackColor = True
        '
        'btnMesAtual
        '
        Me.btnMesAtual.Location = New System.Drawing.Point(195, 312)
        Me.btnMesAtual.Name = "btnMesAtual"
        Me.btnMesAtual.Size = New System.Drawing.Size(65, 23)
        Me.btnMesAtual.TabIndex = 50
        Me.btnMesAtual.Text = "Atual"
        Me.btnMesAtual.UseVisualStyleBackColor = True
        '
        'btnAvancarMes
        '
        Me.btnAvancarMes.Location = New System.Drawing.Point(464, 312)
        Me.btnAvancarMes.Name = "btnAvancarMes"
        Me.btnAvancarMes.Size = New System.Drawing.Size(35, 23)
        Me.btnAvancarMes.TabIndex = 49
        Me.btnAvancarMes.Text = ">"
        Me.btnAvancarMes.UseVisualStyleBackColor = True
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(317, 317)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(27, 13)
        Me.lblMes.TabIndex = 48
        Me.lblMes.Text = "Mês"
        Me.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarMes
        '
        Me.btnVoltarMes.Location = New System.Drawing.Point(276, 312)
        Me.btnVoltarMes.Name = "btnVoltarMes"
        Me.btnVoltarMes.Size = New System.Drawing.Size(35, 23)
        Me.btnVoltarMes.TabIndex = 47
        Me.btnVoltarMes.Text = "<"
        Me.btnVoltarMes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(8, 633)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 24)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Metas Anuais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(8, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Metas Mensais"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Metas Semanais"
        '
        'FormMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 907)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnMesAtual)
        Me.Controls.Add(Me.btnAvancarMes)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.btnVoltarMes)
        Me.Controls.Add(Me.btnAnoAtual)
        Me.Controls.Add(Me.btnAvancarAno)
        Me.Controls.Add(Me.lblAno)
        Me.Controls.Add(Me.btnVoltarAno)
        Me.Controls.Add(Me.btnSemanaAtual)
        Me.Controls.Add(Me.btnAvancarSemana)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.btnVoltarSemana)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdicionarMeta)
        Me.Controls.Add(Me.ListViewAnuais)
        Me.Controls.Add(Me.ListViewMensais)
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
    Friend WithEvents ListViewMensais As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
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
    Friend WithEvents btnSemanaAtual As Button
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents btnAnoAtual As Button
    Friend WithEvents btnAvancarAno As Button
    Friend WithEvents lblAno As Label
    Friend WithEvents btnVoltarAno As Button
    Friend WithEvents btnMesAtual As Button
    Friend WithEvents btnAvancarMes As Button
    Friend WithEvents lblMes As Label
    Friend WithEvents btnVoltarMes As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
