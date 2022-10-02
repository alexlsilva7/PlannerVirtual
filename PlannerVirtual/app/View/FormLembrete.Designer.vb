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
        Me.btnAddReuniao = New System.Windows.Forms.Button()
        Me.btnAddCompra = New System.Windows.Forms.Button()
        Me.listViewLigacoes = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewReunioes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewCompras = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddLigacaoImportate = New System.Windows.Forms.Button()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(21, 24)
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
        Me.Label4.Location = New System.Drawing.Point(586, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Compras"
        '
        'btnAddReuniao
        '
        Me.btnAddReuniao.Location = New System.Drawing.Point(306, 418)
        Me.btnAddReuniao.Name = "btnAddReuniao"
        Me.btnAddReuniao.Size = New System.Drawing.Size(260, 23)
        Me.btnAddReuniao.TabIndex = 10
        Me.btnAddReuniao.Text = "Adicionar Lembrete"
        Me.btnAddReuniao.UseVisualStyleBackColor = True
        '
        'btnAddCompra
        '
        Me.btnAddCompra.Location = New System.Drawing.Point(589, 418)
        Me.btnAddCompra.Name = "btnAddCompra"
        Me.btnAddCompra.Size = New System.Drawing.Size(260, 23)
        Me.btnAddCompra.TabIndex = 11
        Me.btnAddCompra.Text = "Adicionar Lembrete"
        Me.btnAddCompra.UseVisualStyleBackColor = True
        '
        'listViewLigacoes
        '
        Me.listViewLigacoes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewLigacoes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Descricao, Me.Data})
        Me.listViewLigacoes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'Data
        '
        Me.Data.Text = "Data"
        Me.Data.Width = 72
        '
        'listViewReunioes
        '
        Me.listViewReunioes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.listViewReunioes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewReunioes.FullRowSelect = True
        Me.listViewReunioes.HideSelection = False
        Me.listViewReunioes.Location = New System.Drawing.Point(306, 99)
        Me.listViewReunioes.MultiSelect = False
        Me.listViewReunioes.Name = "listViewReunioes"
        Me.listViewReunioes.Size = New System.Drawing.Size(260, 313)
        Me.listViewReunioes.TabIndex = 13
        Me.listViewReunioes.UseCompatibleStateImageBehavior = False
        Me.listViewReunioes.View = System.Windows.Forms.View.Details
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
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data"
        Me.ColumnHeader3.Width = 72
        '
        'listViewCompras
        '
        Me.listViewCompras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.listViewCompras.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewCompras.FullRowSelect = True
        Me.listViewCompras.HideSelection = False
        Me.listViewCompras.Location = New System.Drawing.Point(589, 99)
        Me.listViewCompras.MultiSelect = False
        Me.listViewCompras.Name = "listViewCompras"
        Me.listViewCompras.Size = New System.Drawing.Size(260, 313)
        Me.listViewCompras.TabIndex = 14
        Me.listViewCompras.UseCompatibleStateImageBehavior = False
        Me.listViewCompras.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Id"
        Me.ColumnHeader4.Width = 25
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Descrição"
        Me.ColumnHeader5.Width = 159
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Data"
        Me.ColumnHeader6.Width = 72
        '
        'btnAddLigacaoImportate
        '
        Me.btnAddLigacaoImportate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAddLigacaoImportate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddLigacaoImportate.Location = New System.Drawing.Point(26, 418)
        Me.btnAddLigacaoImportate.Name = "btnAddLigacaoImportate"
        Me.btnAddLigacaoImportate.Size = New System.Drawing.Size(260, 23)
        Me.btnAddLigacaoImportate.TabIndex = 15
        Me.btnAddLigacaoImportate.Text = "Adicionar Lembrete"
        Me.btnAddLigacaoImportate.UseVisualStyleBackColor = False
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.Location = New System.Drawing.Point(588, 28)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnVoltarSemana.TabIndex = 16
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(685, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Semana"
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(650, 36)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(46, 13)
        Me.lblSemana.TabIndex = 18
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.Location = New System.Drawing.Point(814, 28)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnAvancarSemana.TabIndex = 19
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = True
        '
        'btnIrSemanaAtual
        '
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(517, 28)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(65, 23)
        Me.btnIrSemanaAtual.TabIndex = 20
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = True
        '
        'FormLembrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(872, 476)
        Me.Controls.Add(Me.btnIrSemanaAtual)
        Me.Controls.Add(Me.btnAvancarSemana)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnVoltarSemana)
        Me.Controls.Add(Me.btnAddLigacaoImportate)
        Me.Controls.Add(Me.listViewCompras)
        Me.Controls.Add(Me.listViewReunioes)
        Me.Controls.Add(Me.listViewLigacoes)
        Me.Controls.Add(Me.btnAddCompra)
        Me.Controls.Add(Me.btnAddReuniao)
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
    Friend WithEvents btnAddReuniao As Button
    Friend WithEvents btnAddCompra As Button
    Friend WithEvents listViewLigacoes As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Descricao As ColumnHeader
    Friend WithEvents Data As ColumnHeader
    Friend WithEvents listViewReunioes As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents listViewCompras As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnAddLigacaoImportate As Button
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents btnIrSemanaAtual As Button
End Class
