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
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.btnApagarLigacao = New System.Windows.Forms.Button()
        Me.btnEditarLigacao = New System.Windows.Forms.Button()
        Me.btnEditarReuniao = New System.Windows.Forms.Button()
        Me.btnApagarReuniao = New System.Windows.Forms.Button()
        Me.btnEditarCompra = New System.Windows.Forms.Button()
        Me.btnApagarCompra = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ligações importantes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(330, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Reuniões"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(649, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Compras"
        '
        'btnAddReuniao
        '
        Me.btnAddReuniao.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAddReuniao.FlatAppearance.BorderSize = 0
        Me.btnAddReuniao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddReuniao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddReuniao.ForeColor = System.Drawing.Color.White
        Me.btnAddReuniao.Location = New System.Drawing.Point(333, 840)
        Me.btnAddReuniao.Name = "btnAddReuniao"
        Me.btnAddReuniao.Size = New System.Drawing.Size(312, 23)
        Me.btnAddReuniao.TabIndex = 10
        Me.btnAddReuniao.Text = "Adicionar Lembrete"
        Me.btnAddReuniao.UseVisualStyleBackColor = False
        '
        'btnAddCompra
        '
        Me.btnAddCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAddCompra.FlatAppearance.BorderSize = 0
        Me.btnAddCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCompra.ForeColor = System.Drawing.Color.White
        Me.btnAddCompra.Location = New System.Drawing.Point(652, 840)
        Me.btnAddCompra.Name = "btnAddCompra"
        Me.btnAddCompra.Size = New System.Drawing.Size(312, 23)
        Me.btnAddCompra.TabIndex = 11
        Me.btnAddCompra.Text = "Adicionar Lembrete"
        Me.btnAddCompra.UseVisualStyleBackColor = False
        '
        'listViewLigacoes
        '
        Me.listViewLigacoes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewLigacoes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Descricao, Me.Data})
        Me.listViewLigacoes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewLigacoes.FullRowSelect = True
        Me.listViewLigacoes.HideSelection = False
        Me.listViewLigacoes.Location = New System.Drawing.Point(12, 99)
        Me.listViewLigacoes.MultiSelect = False
        Me.listViewLigacoes.Name = "listViewLigacoes"
        Me.listViewLigacoes.Size = New System.Drawing.Size(312, 735)
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
        Me.Descricao.Width = 190
        '
        'Data
        '
        Me.Data.Text = "Data"
        Me.Data.Width = 93
        '
        'listViewReunioes
        '
        Me.listViewReunioes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.listViewReunioes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewReunioes.FullRowSelect = True
        Me.listViewReunioes.HideSelection = False
        Me.listViewReunioes.Location = New System.Drawing.Point(333, 99)
        Me.listViewReunioes.MultiSelect = False
        Me.listViewReunioes.Name = "listViewReunioes"
        Me.listViewReunioes.Size = New System.Drawing.Size(312, 735)
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
        Me.ColumnHeader2.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data"
        Me.ColumnHeader3.Width = 93
        '
        'listViewCompras
        '
        Me.listViewCompras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.listViewCompras.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewCompras.FullRowSelect = True
        Me.listViewCompras.HideSelection = False
        Me.listViewCompras.Location = New System.Drawing.Point(652, 99)
        Me.listViewCompras.MultiSelect = False
        Me.listViewCompras.Name = "listViewCompras"
        Me.listViewCompras.Size = New System.Drawing.Size(312, 735)
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
        Me.ColumnHeader5.Width = 190
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Data"
        Me.ColumnHeader6.Width = 93
        '
        'btnAddLigacaoImportate
        '
        Me.btnAddLigacaoImportate.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAddLigacaoImportate.FlatAppearance.BorderSize = 0
        Me.btnAddLigacaoImportate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLigacaoImportate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLigacaoImportate.ForeColor = System.Drawing.Color.White
        Me.btnAddLigacaoImportate.Location = New System.Drawing.Point(12, 840)
        Me.btnAddLigacaoImportate.Name = "btnAddLigacaoImportate"
        Me.btnAddLigacaoImportate.Size = New System.Drawing.Size(312, 23)
        Me.btnAddLigacaoImportate.TabIndex = 15
        Me.btnAddLigacaoImportate.Text = "Adicionar Lembrete"
        Me.btnAddLigacaoImportate.UseVisualStyleBackColor = False
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVoltarSemana.FlatAppearance.BorderSize = 0
        Me.btnVoltarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltarSemana.Location = New System.Drawing.Point(674, 22)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnVoltarSemana.TabIndex = 16
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = False
        '
        'btnIrSemanaAtual
        '
        Me.btnIrSemanaAtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnIrSemanaAtual.FlatAppearance.BorderSize = 0
        Me.btnIrSemanaAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrSemanaAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(603, 22)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(65, 23)
        Me.btnIrSemanaAtual.TabIndex = 20
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = False
        '
        'btnApagarLigacao
        '
        Me.btnApagarLigacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagarLigacao.FlatAppearance.BorderSize = 0
        Me.btnApagarLigacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarLigacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarLigacao.Location = New System.Drawing.Point(12, 869)
        Me.btnApagarLigacao.Name = "btnApagarLigacao"
        Me.btnApagarLigacao.Size = New System.Drawing.Size(153, 23)
        Me.btnApagarLigacao.TabIndex = 21
        Me.btnApagarLigacao.Text = "Apagar"
        Me.btnApagarLigacao.UseVisualStyleBackColor = False
        '
        'btnEditarLigacao
        '
        Me.btnEditarLigacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditarLigacao.FlatAppearance.BorderSize = 0
        Me.btnEditarLigacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarLigacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarLigacao.Location = New System.Drawing.Point(171, 869)
        Me.btnEditarLigacao.Name = "btnEditarLigacao"
        Me.btnEditarLigacao.Size = New System.Drawing.Size(153, 23)
        Me.btnEditarLigacao.TabIndex = 22
        Me.btnEditarLigacao.Text = "Editar"
        Me.btnEditarLigacao.UseVisualStyleBackColor = False
        '
        'btnEditarReuniao
        '
        Me.btnEditarReuniao.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditarReuniao.FlatAppearance.BorderSize = 0
        Me.btnEditarReuniao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarReuniao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarReuniao.Location = New System.Drawing.Point(492, 869)
        Me.btnEditarReuniao.Name = "btnEditarReuniao"
        Me.btnEditarReuniao.Size = New System.Drawing.Size(153, 23)
        Me.btnEditarReuniao.TabIndex = 24
        Me.btnEditarReuniao.Text = "Editar"
        Me.btnEditarReuniao.UseVisualStyleBackColor = False
        '
        'btnApagarReuniao
        '
        Me.btnApagarReuniao.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagarReuniao.FlatAppearance.BorderSize = 0
        Me.btnApagarReuniao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarReuniao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarReuniao.Location = New System.Drawing.Point(333, 869)
        Me.btnApagarReuniao.Name = "btnApagarReuniao"
        Me.btnApagarReuniao.Size = New System.Drawing.Size(153, 23)
        Me.btnApagarReuniao.TabIndex = 23
        Me.btnApagarReuniao.Text = "Apagar"
        Me.btnApagarReuniao.UseVisualStyleBackColor = False
        '
        'btnEditarCompra
        '
        Me.btnEditarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditarCompra.FlatAppearance.BorderSize = 0
        Me.btnEditarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCompra.Location = New System.Drawing.Point(811, 869)
        Me.btnEditarCompra.Name = "btnEditarCompra"
        Me.btnEditarCompra.Size = New System.Drawing.Size(153, 23)
        Me.btnEditarCompra.TabIndex = 26
        Me.btnEditarCompra.Text = "Editar"
        Me.btnEditarCompra.UseVisualStyleBackColor = False
        '
        'btnApagarCompra
        '
        Me.btnApagarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagarCompra.FlatAppearance.BorderSize = 0
        Me.btnApagarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarCompra.Location = New System.Drawing.Point(652, 869)
        Me.btnApagarCompra.Name = "btnApagarCompra"
        Me.btnApagarCompra.Size = New System.Drawing.Size(153, 23)
        Me.btnApagarCompra.TabIndex = 25
        Me.btnApagarCompra.Text = "Apagar"
        Me.btnApagarCompra.UseVisualStyleBackColor = False
        '
        'lblSemana
        '
        Me.lblSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemana.Location = New System.Drawing.Point(715, 22)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(208, 23)
        Me.lblSemana.TabIndex = 18
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvancarSemana.FlatAppearance.BorderSize = 0
        Me.btnAvancarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvancarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvancarSemana.Location = New System.Drawing.Point(929, 22)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnAvancarSemana.TabIndex = 19
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = False
        '
        'FormLembrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 911)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEditarCompra)
        Me.Controls.Add(Me.btnApagarCompra)
        Me.Controls.Add(Me.btnEditarReuniao)
        Me.Controls.Add(Me.btnApagarReuniao)
        Me.Controls.Add(Me.btnEditarLigacao)
        Me.Controls.Add(Me.btnApagarLigacao)
        Me.Controls.Add(Me.btnIrSemanaAtual)
        Me.Controls.Add(Me.btnAvancarSemana)
        Me.Controls.Add(Me.lblSemana)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLembrete"
        Me.Text = "FormLembrete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents btnApagarLigacao As Button
    Friend WithEvents btnEditarLigacao As Button
    Friend WithEvents btnEditarReuniao As Button
    Friend WithEvents btnApagarReuniao As Button
    Friend WithEvents btnEditarCompra As Button
    Friend WithEvents btnApagarCompra As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnAvancarSemana As Button
End Class
