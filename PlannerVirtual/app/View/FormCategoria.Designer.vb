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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listviewCategorias = New System.Windows.Forms.ListView()
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnConsultarCategoria = New FontAwesome.Sharp.IconButton()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.btnNovaCategoria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categorias"
        '
        'listviewCategorias
        '
        Me.listviewCategorias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nome, Me.Cor})
        Me.listviewCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listviewCategorias.FullRowSelect = True
        Me.listviewCategorias.HideSelection = False
        Me.listviewCategorias.Location = New System.Drawing.Point(24, 47)
        Me.listviewCategorias.Name = "listviewCategorias"
        Me.listviewCategorias.Size = New System.Drawing.Size(242, 304)
        Me.listviewCategorias.TabIndex = 16
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
        'btnConsultarCategoria
        '
        Me.btnConsultarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnConsultarCategoria.FlatAppearance.BorderSize = 0
        Me.btnConsultarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarCategoria.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnConsultarCategoria.IconColor = System.Drawing.Color.Black
        Me.btnConsultarCategoria.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnConsultarCategoria.IconSize = 30
        Me.btnConsultarCategoria.Location = New System.Drawing.Point(222, 8)
        Me.btnConsultarCategoria.Name = "btnConsultarCategoria"
        Me.btnConsultarCategoria.Size = New System.Drawing.Size(44, 33)
        Me.btnConsultarCategoria.TabIndex = 18
        Me.btnConsultarCategoria.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(152, 389)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 26)
        Me.btnEditar.TabIndex = 24
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnApagar
        '
        Me.btnApagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagar.FlatAppearance.BorderSize = 0
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagar.Location = New System.Drawing.Point(24, 389)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(114, 26)
        Me.btnApagar.TabIndex = 23
        Me.btnApagar.Text = "Apagar"
        Me.btnApagar.UseVisualStyleBackColor = False
        '
        'btnNovaCategoria
        '
        Me.btnNovaCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnNovaCategoria.FlatAppearance.BorderSize = 0
        Me.btnNovaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovaCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovaCategoria.ForeColor = System.Drawing.Color.White
        Me.btnNovaCategoria.Location = New System.Drawing.Point(24, 357)
        Me.btnNovaCategoria.Name = "btnNovaCategoria"
        Me.btnNovaCategoria.Size = New System.Drawing.Size(242, 26)
        Me.btnNovaCategoria.TabIndex = 25
        Me.btnNovaCategoria.Text = "Adicionar"
        Me.btnNovaCategoria.UseVisualStyleBackColor = False
        '
        'FormCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(289, 437)
        Me.Controls.Add(Me.btnNovaCategoria)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnApagar)
        Me.Controls.Add(Me.btnConsultarCategoria)
        Me.Controls.Add(Me.listviewCategorias)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCategoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents listviewCategorias As ListView
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Cor As ColumnHeader
    Friend WithEvents btnConsultarCategoria As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnApagar As Button
    Friend WithEvents btnNovaCategoria As Button
End Class
