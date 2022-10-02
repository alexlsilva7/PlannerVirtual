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
        Me.btnSelecionarCategoria = New System.Windows.Forms.Label()
        Me.listviewCategorias = New System.Windows.Forms.ListView()
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnSelecionarCategoria
        '
        Me.btnSelecionarCategoria.AutoSize = True
        Me.btnSelecionarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelecionarCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSelecionarCategoria.Location = New System.Drawing.Point(26, 10)
        Me.btnSelecionarCategoria.Name = "btnSelecionarCategoria"
        Me.btnSelecionarCategoria.Size = New System.Drawing.Size(184, 16)
        Me.btnSelecionarCategoria.TabIndex = 2
        Me.btnSelecionarCategoria.Text = "Selecione uma categoria:"
        '
        'listviewCategorias
        '
        Me.listviewCategorias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nome, Me.Cor})
        Me.listviewCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listviewCategorias.FullRowSelect = True
        Me.listviewCategorias.HideSelection = False
        Me.listviewCategorias.Location = New System.Drawing.Point(-2, 38)
        Me.listviewCategorias.MultiSelect = False
        Me.listviewCategorias.Name = "listviewCategorias"
        Me.listviewCategorias.Size = New System.Drawing.Size(242, 263)
        Me.listviewCategorias.TabIndex = 4
        Me.listviewCategorias.UseCompatibleStateImageBehavior = False
        Me.listviewCategorias.View = System.Windows.Forms.View.Details
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 140
        '
        'Cor
        '
        Me.Cor.Text = "Cor"
        Me.Cor.Width = 98
        '
        'FormSelecionarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(236, 298)
        Me.Controls.Add(Me.listviewCategorias)
        Me.Controls.Add(Me.btnSelecionarCategoria)
        Me.Name = "FormSelecionarCategoria"
        Me.Text = "SelecionarCategoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelecionarCategoria As Label
    Friend WithEvents listviewCategorias As ListView
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Cor As ColumnHeader
End Class
