<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategoria
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
        Me.dgvCategorias = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeCategoria = New System.Windows.Forms.TextBox()
        Me.lblIdSelecionado = New System.Windows.Forms.Label()
        Me.btnDeletarPrimeiro = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeConsultar = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.panelCor = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAlterarCor = New System.Windows.Forms.Button()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategorias.Location = New System.Drawing.Point(24, 48)
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        Me.dgvCategorias.Size = New System.Drawing.Size(271, 347)
        Me.dgvCategorias.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categorias"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(353, 379)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(141, 23)
        Me.btnAdicionar.TabIndex = 2
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome:"
        '
        'txtNomeCategoria
        '
        Me.txtNomeCategoria.Location = New System.Drawing.Point(394, 324)
        Me.txtNomeCategoria.Name = "txtNomeCategoria"
        Me.txtNomeCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeCategoria.TabIndex = 4
        '
        'lblIdSelecionado
        '
        Me.lblIdSelecionado.AutoSize = True
        Me.lblIdSelecionado.Location = New System.Drawing.Point(23, 420)
        Me.lblIdSelecionado.Name = "lblIdSelecionado"
        Me.lblIdSelecionado.Size = New System.Drawing.Size(81, 13)
        Me.lblIdSelecionado.TabIndex = 5
        Me.lblIdSelecionado.Text = "ID selecionado:"
        '
        'btnDeletarPrimeiro
        '
        Me.btnDeletarPrimeiro.Location = New System.Drawing.Point(178, 415)
        Me.btnDeletarPrimeiro.Name = "btnDeletarPrimeiro"
        Me.btnDeletarPrimeiro.Size = New System.Drawing.Size(117, 23)
        Me.btnDeletarPrimeiro.TabIndex = 6
        Me.btnDeletarPrimeiro.Text = "Deletar o primeiro"
        Me.btnDeletarPrimeiro.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(390, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Inserir"
        '
        'txtNomeConsultar
        '
        Me.txtNomeConsultar.Location = New System.Drawing.Point(639, 327)
        Me.txtNomeConsultar.Name = "txtNomeConsultar"
        Me.txtNomeConsultar.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeConsultar.TabIndex = 8
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(586, 350)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(153, 23)
        Me.btnConsultar.TabIndex = 9
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(583, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nome:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(582, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Consultar por Nome"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(702, 32)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 65)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "FECHAR TELA"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'panelCor
        '
        Me.panelCor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelCor.Location = New System.Drawing.Point(382, 350)
        Me.panelCor.Name = "panelCor"
        Me.panelCor.Size = New System.Drawing.Size(30, 23)
        Me.panelCor.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cor:"
        '
        'btnAlterarCor
        '
        Me.btnAlterarCor.Location = New System.Drawing.Point(419, 351)
        Me.btnAlterarCor.Name = "btnAlterarCor"
        Me.btnAlterarCor.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterarCor.TabIndex = 15
        Me.btnAlterarCor.Text = "Alterar"
        Me.btnAlterarCor.UseVisualStyleBackColor = True
        '
        'FormCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAlterarCor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.panelCor)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtNomeConsultar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDeletarPrimeiro)
        Me.Controls.Add(Me.lblIdSelecionado)
        Me.Controls.Add(Me.txtNomeCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCategorias)
        Me.Name = "FormCategoria"
        Me.Text = "Form1"
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCategorias As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeCategoria As TextBox
    Friend WithEvents lblIdSelecionado As Label
    Friend WithEvents btnDeletarPrimeiro As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomeConsultar As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents panelCor As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAlterarCor As Button
End Class
