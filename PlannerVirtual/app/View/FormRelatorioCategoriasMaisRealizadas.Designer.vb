<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRelatorioCategoriasMaisRealizadas
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
        Me.ListViewRelatorio = New System.Windows.Forms.ListView()
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbIntervaloTempo = New System.Windows.Forms.ComboBox()
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewRelatorio
        '
        Me.ListViewRelatorio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Categoria, Me.Quantidade})
        Me.ListViewRelatorio.HideSelection = False
        Me.ListViewRelatorio.Location = New System.Drawing.Point(0, 166)
        Me.ListViewRelatorio.Name = "ListViewRelatorio"
        Me.ListViewRelatorio.Size = New System.Drawing.Size(1003, 284)
        Me.ListViewRelatorio.TabIndex = 0
        Me.ListViewRelatorio.UseCompatibleStateImageBehavior = False
        Me.ListViewRelatorio.View = System.Windows.Forms.View.Details
        '
        'Categoria
        '
        Me.Categoria.Text = "Categoria"
        Me.Categoria.Width = 198
        '
        'Quantidade
        '
        Me.Quantidade.Text = "Quantidade"
        Me.Quantidade.Width = 223
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 68)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 36)
        Me.Panel2.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1003, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Relatório de categorias mais realizadas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbIntervaloTempo
        '
        Me.cbIntervaloTempo.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbIntervaloTempo.FormattingEnabled = True
        Me.cbIntervaloTempo.Items.AddRange(New Object() {"Semana", "Mês", "Ano"})
        Me.cbIntervaloTempo.Location = New System.Drawing.Point(0, 0)
        Me.cbIntervaloTempo.Name = "cbIntervaloTempo"
        Me.cbIntervaloTempo.Size = New System.Drawing.Size(277, 21)
        Me.cbIntervaloTempo.TabIndex = 2
        '
        'btnIrSemanaAtual
        '
        Me.btnIrSemanaAtual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(0, 27)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(277, 22)
        Me.btnIrSemanaAtual.TabIndex = 25
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = True
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAvancarSemana.Location = New System.Drawing.Point(242, 0)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnAvancarSemana.TabIndex = 24
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = True
        '
        'lblSemana
        '
        Me.lblSemana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSemana.Location = New System.Drawing.Point(35, 0)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(207, 49)
        Me.lblSemana.TabIndex = 23
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVoltarSemana.Location = New System.Drawing.Point(0, 0)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnVoltarSemana.TabIndex = 21
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1003, 100)
        Me.Panel3.TabIndex = 26
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnIrSemanaAtual)
        Me.Panel5.Controls.Add(Me.cbIntervaloTempo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(277, 49)
        Me.Panel5.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblSemana)
        Me.Panel4.Controls.Add(Me.btnAvancarSemana)
        Me.Panel4.Controls.Add(Me.btnVoltarSemana)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 49)
        Me.Panel4.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Location = New System.Drawing.Point(360, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(277, 100)
        Me.Panel6.TabIndex = 0
        '
        'FormRelatorioCategoriasMaisRealizadas
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListViewRelatorio)
        Me.Name = "FormRelatorioCategoriasMaisRealizadas"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewRelatorio As ListView
    Friend WithEvents Categoria As ColumnHeader
    Friend WithEvents Quantidade As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbIntervaloTempo As ComboBox
    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
