<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHomeTarefas
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
        Me.btnMensal = New System.Windows.Forms.Button()
        Me.btnSemanal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelSelecionadoMensal = New System.Windows.Forms.Panel()
        Me.PanelSelecionadoSemanal = New System.Windows.Forms.Panel()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMensal
        '
        Me.btnMensal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMensal.BackColor = System.Drawing.Color.Transparent
        Me.btnMensal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMensal.FlatAppearance.BorderSize = 0
        Me.btnMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMensal.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnMensal.Location = New System.Drawing.Point(477, 0)
        Me.btnMensal.Name = "btnMensal"
        Me.btnMensal.Size = New System.Drawing.Size(501, 100)
        Me.btnMensal.TabIndex = 20
        Me.btnMensal.Text = "Mensal"
        Me.btnMensal.UseVisualStyleBackColor = False
        '
        'btnSemanal
        '
        Me.btnSemanal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSemanal.BackColor = System.Drawing.Color.Transparent
        Me.btnSemanal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSemanal.FlatAppearance.BorderSize = 0
        Me.btnSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemanal.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemanal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSemanal.Location = New System.Drawing.Point(0, 0)
        Me.btnSemanal.Name = "btnSemanal"
        Me.btnSemanal.Size = New System.Drawing.Size(461, 100)
        Me.btnSemanal.TabIndex = 19
        Me.btnSemanal.Text = "Semanal"
        Me.btnSemanal.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PanelSelecionadoMensal)
        Me.Panel1.Controls.Add(Me.PanelSelecionadoSemanal)
        Me.Panel1.Controls.Add(Me.btnMensal)
        Me.Panel1.Controls.Add(Me.btnSemanal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 65)
        Me.Panel1.TabIndex = 23
        '
        'PanelSelecionadoMensal
        '
        Me.PanelSelecionadoMensal.Location = New System.Drawing.Point(499, 104)
        Me.PanelSelecionadoMensal.Name = "PanelSelecionadoMensal"
        Me.PanelSelecionadoMensal.Size = New System.Drawing.Size(200, 5)
        Me.PanelSelecionadoMensal.TabIndex = 22
        '
        'PanelSelecionadoSemanal
        '
        Me.PanelSelecionadoSemanal.Location = New System.Drawing.Point(217, 104)
        Me.PanelSelecionadoSemanal.Name = "PanelSelecionadoSemanal"
        Me.PanelSelecionadoSemanal.Size = New System.Drawing.Size(200, 5)
        Me.PanelSelecionadoSemanal.TabIndex = 21
        '
        'PanelCentral
        '
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Location = New System.Drawing.Point(0, 65)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Size = New System.Drawing.Size(976, 846)
        Me.PanelCentral.TabIndex = 24
        '
        'FormHomeTarefas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 911)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormHomeTarefas"
        Me.Text = "FormHomeTarefas"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSemanal As Button
    Friend WithEvents btnMensal As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents PanelSelecionadoMensal As Panel
    Friend WithEvents PanelSelecionadoSemanal As Panel
End Class
