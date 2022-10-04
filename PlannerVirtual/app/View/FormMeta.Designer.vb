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
        Me.Descrição = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Metas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListViewMensais = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListViewAnuais = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdicionarMeta = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'listViewSemanais
        '
        Me.listViewSemanais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.Descrição, Me.Categoria, Me.Estado, Me.Data})
        Me.listViewSemanais.HideSelection = False
        Me.listViewSemanais.Location = New System.Drawing.Point(12, 55)
        Me.listViewSemanais.Name = "listViewSemanais"
        Me.listViewSemanais.Size = New System.Drawing.Size(776, 91)
        Me.listViewSemanais.TabIndex = 0
        Me.listViewSemanais.UseCompatibleStateImageBehavior = False
        Me.listViewSemanais.View = System.Windows.Forms.View.Details
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
        'Metas
        '
        Me.Metas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Metas.AutoSize = True
        Me.Metas.Location = New System.Drawing.Point(392, 13)
        Me.Metas.Name = "Metas"
        Me.Metas.Size = New System.Drawing.Size(36, 13)
        Me.Metas.TabIndex = 1
        Me.Metas.Text = "Metas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Semanais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mensais"
        '
        'ListViewMensais
        '
        Me.ListViewMensais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader3})
        Me.ListViewMensais.HideSelection = False
        Me.ListViewMensais.Location = New System.Drawing.Point(12, 173)
        Me.ListViewMensais.Name = "ListViewMensais"
        Me.ListViewMensais.Size = New System.Drawing.Size(776, 84)
        Me.ListViewMensais.TabIndex = 3
        Me.ListViewMensais.UseCompatibleStateImageBehavior = False
        Me.ListViewMensais.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Descrição"
        Me.ColumnHeader1.Width = 218
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 2
        Me.ColumnHeader2.Text = "Categoria"
        Me.ColumnHeader2.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 3
        Me.ColumnHeader4.Text = "Estado"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 4
        Me.ColumnHeader5.Text = "Data"
        Me.ColumnHeader5.Width = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Anuais"
        '
        'ListViewAnuais
        '
        Me.ListViewAnuais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader8})
        Me.ListViewAnuais.HideSelection = False
        Me.ListViewAnuais.Location = New System.Drawing.Point(12, 285)
        Me.ListViewAnuais.Name = "ListViewAnuais"
        Me.ListViewAnuais.Size = New System.Drawing.Size(776, 84)
        Me.ListViewAnuais.TabIndex = 5
        Me.ListViewAnuais.UseCompatibleStateImageBehavior = False
        Me.ListViewAnuais.View = System.Windows.Forms.View.Details
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
        Me.btnAdicionarMeta.Location = New System.Drawing.Point(12, 415)
        Me.btnAdicionarMeta.Name = "btnAdicionarMeta"
        Me.btnAdicionarMeta.Size = New System.Drawing.Size(776, 23)
        Me.btnAdicionarMeta.TabIndex = 7
        Me.btnAdicionarMeta.Text = "Criar"
        Me.btnAdicionarMeta.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(251, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(537, 386)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(251, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Deletar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(269, 386)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(262, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Marcar como cumprido"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.Text = "Id"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 0
        Me.ColumnHeader3.Text = "Id"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 0
        Me.ColumnHeader8.Text = "Id"
        '
        'FormMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdicionarMeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListViewAnuais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListViewMensais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Metas)
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
    Friend WithEvents Metas As Label
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents id As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
