<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLembrete
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddLigacaoImportate = New System.Windows.Forms.Button()
        Me.btnAddReuniao = New System.Windows.Forms.Button()
        Me.btnAddCompra = New System.Windows.Forms.Button()
        Me.listViewLigacoes = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lembretes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ligações importantes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Reuniões"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(530, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Compras"
        '
        'btnAddLigacaoImportate
        '
        Me.btnAddLigacaoImportate.Location = New System.Drawing.Point(26, 418)
        Me.btnAddLigacaoImportate.Name = "btnAddLigacaoImportate"
        Me.btnAddLigacaoImportate.Size = New System.Drawing.Size(260, 23)
        Me.btnAddLigacaoImportate.TabIndex = 9
        Me.btnAddLigacaoImportate.Text = "Adicionar Lembrete "
        Me.btnAddLigacaoImportate.UseVisualStyleBackColor = True
        '
        'btnAddReuniao
        '
        Me.btnAddReuniao.Location = New System.Drawing.Point(306, 418)
        Me.btnAddReuniao.Name = "btnAddReuniao"
        Me.btnAddReuniao.Size = New System.Drawing.Size(188, 23)
        Me.btnAddReuniao.TabIndex = 10
        Me.btnAddReuniao.Text = "Adicionar Lembrete"
        Me.btnAddReuniao.UseVisualStyleBackColor = True
        '
        'btnAddCompra
        '
        Me.btnAddCompra.Location = New System.Drawing.Point(533, 418)
        Me.btnAddCompra.Name = "btnAddCompra"
        Me.btnAddCompra.Size = New System.Drawing.Size(188, 23)
        Me.btnAddCompra.TabIndex = 11
        Me.btnAddCompra.Text = "Adicionar Lembrete"
        Me.btnAddCompra.UseVisualStyleBackColor = True
        '
        'listViewLigacoes
        '
        Me.listViewLigacoes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Descricao, Me.Data})
        Me.listViewLigacoes.FullRowSelect = True
        Me.listViewLigacoes.HideSelection = False
        Me.listViewLigacoes.Location = New System.Drawing.Point(26, 99)
        Me.listViewLigacoes.MultiSelect = False
        Me.listViewLigacoes.Name = "listViewLigacoes"
        Me.listViewLigacoes.Size = New System.Drawing.Size(260, 313)
        Me.listViewLigacoes.TabIndex = 12
        Me.listViewLigacoes.UseCompatibleStateImageBehavior = False
        Me.listViewLigacoes.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "Id"
        Me.Id.Width = 25
        '
        'Descricao
        '
        Me.Descricao.Text = "Descrição"
        Me.Descricao.Width = 159
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(306, 99)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(188, 313)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 25
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 159
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(533, 99)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(188, 313)
        Me.ListView2.TabIndex = 14
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Id"
        Me.ColumnHeader3.Width = 25
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descrição"
        Me.ColumnHeader4.Width = 159
        '
        'Data
        '
        Me.Data.Text = "Data"
        Me.Data.Width = 72
        '
        'FormLembrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 470)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.listViewLigacoes)
        Me.Controls.Add(Me.btnAddCompra)
        Me.Controls.Add(Me.btnAddReuniao)
        Me.Controls.Add(Me.btnAddLigacaoImportate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLembrete"
        Me.Text = "FormLembrete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddLigacaoImportate As Button
    Friend WithEvents btnAddReuniao As Button
    Friend WithEvents btnAddCompra As Button
    Friend WithEvents listViewLigacoes As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Descricao As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Data As ColumnHeader
End Class
