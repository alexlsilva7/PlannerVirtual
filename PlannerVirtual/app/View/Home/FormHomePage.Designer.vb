<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHomePage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRelatorios = New System.Windows.Forms.Button()
        Me.btnLembretes = New System.Windows.Forms.Button()
        Me.btnMetas = New System.Windows.Forms.Button()
        Me.btnTarefas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCenter = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRelatorios)
        Me.Panel1.Controls.Add(Me.btnLembretes)
        Me.Panel1.Controls.Add(Me.btnMetas)
        Me.Panel1.Controls.Add(Me.btnTarefas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 911)
        Me.Panel1.TabIndex = 0
        '
        'btnRelatorios
        '
        Me.btnRelatorios.BackColor = System.Drawing.Color.Transparent
        Me.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelatorios.FlatAppearance.BorderSize = 0
        Me.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorios.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRelatorios.Location = New System.Drawing.Point(3, 228)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(227, 47)
        Me.btnRelatorios.TabIndex = 18
        Me.btnRelatorios.Text = "Relatorios"
        Me.btnRelatorios.UseVisualStyleBackColor = False
        '
        'btnLembretes
        '
        Me.btnLembretes.BackColor = System.Drawing.Color.Transparent
        Me.btnLembretes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLembretes.FlatAppearance.BorderSize = 0
        Me.btnLembretes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLembretes.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLembretes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnLembretes.Location = New System.Drawing.Point(0, 175)
        Me.btnLembretes.Name = "btnLembretes"
        Me.btnLembretes.Size = New System.Drawing.Size(227, 47)
        Me.btnLembretes.TabIndex = 17
        Me.btnLembretes.Text = "Lembretes"
        Me.btnLembretes.UseVisualStyleBackColor = False
        '
        'btnMetas
        '
        Me.btnMetas.BackColor = System.Drawing.Color.Transparent
        Me.btnMetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMetas.FlatAppearance.BorderSize = 0
        Me.btnMetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMetas.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMetas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnMetas.Location = New System.Drawing.Point(0, 122)
        Me.btnMetas.Name = "btnMetas"
        Me.btnMetas.Size = New System.Drawing.Size(227, 47)
        Me.btnMetas.TabIndex = 16
        Me.btnMetas.Text = "Metas"
        Me.btnMetas.UseVisualStyleBackColor = False
        '
        'btnTarefas
        '
        Me.btnTarefas.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnTarefas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTarefas.FlatAppearance.BorderSize = 0
        Me.btnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarefas.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarefas.ForeColor = System.Drawing.Color.White
        Me.btnTarefas.Location = New System.Drawing.Point(0, 69)
        Me.btnTarefas.Name = "btnTarefas"
        Me.btnTarefas.Size = New System.Drawing.Size(227, 47)
        Me.btnTarefas.TabIndex = 15
        Me.btnTarefas.Text = "Tarefas"
        Me.btnTarefas.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Source Code Pro Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(53, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 44)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Planner"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Source Code Pro Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(8, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 44)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "PL"
        '
        'PanelCenter
        '
        Me.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCenter.Location = New System.Drawing.Point(236, 0)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(976, 911)
        Me.PanelCenter.TabIndex = 1
        '
        'FormHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1212, 911)
        Me.Controls.Add(Me.PanelCenter)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1228, 950)
        Me.MinimumSize = New System.Drawing.Size(1228, 950)
        Me.Name = "FormHomePage"
        Me.Text = "FormHomePage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTarefas As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLembretes As Button
    Friend WithEvents btnMetas As Button
    Friend WithEvents PanelCenter As Panel
    Friend WithEvents btnRelatorios As Button
End Class
