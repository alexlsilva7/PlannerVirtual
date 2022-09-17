<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelecionarCategoria
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
        Me.btnSelecionarCategoria = New System.Windows.Forms.Label()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategorias.Location = New System.Drawing.Point(-2, 29)
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        Me.dgvCategorias.Size = New System.Drawing.Size(246, 325)
        Me.dgvCategorias.TabIndex = 1
        '
        'btnSelecionarCategoria
        '
        Me.btnSelecionarCategoria.AutoSize = True
        Me.btnSelecionarCategoria.Location = New System.Drawing.Point(26, 10)
        Me.btnSelecionarCategoria.Name = "btnSelecionarCategoria"
        Me.btnSelecionarCategoria.Size = New System.Drawing.Size(127, 13)
        Me.btnSelecionarCategoria.TabIndex = 2
        Me.btnSelecionarCategoria.Text = "Selecione uma categoria:"
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(-2, 360)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(246, 23)
        Me.btnSelecionar.TabIndex = 3
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'FormSelecionarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 382)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.btnSelecionarCategoria)
        Me.Controls.Add(Me.dgvCategorias)
        Me.Name = "FormSelecionarCategoria"
        Me.Text = "SelecionarCategoria"
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCategorias As DataGridView
    Friend WithEvents btnSelecionarCategoria As Label
    Friend WithEvents btnSelecionar As Button
End Class
