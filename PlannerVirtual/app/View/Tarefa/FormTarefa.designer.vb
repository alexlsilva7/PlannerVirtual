<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTarefa
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
        Me.listViewTarefas = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Horário = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Duração = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.btnEditarTarefa = New System.Windows.Forms.Button()
        Me.btnApagarTarefa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFiltroCategoria = New System.Windows.Forms.ComboBox()
        Me.cbFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddTarefa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewTarefas
        '
        Me.listViewTarefas.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewTarefas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listViewTarefas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Descricao, Me.Horário, Me.Duração, Me.Estado, Me.Categoria})
        Me.listViewTarefas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewTarefas.FullRowSelect = True
        Me.listViewTarefas.HideSelection = False
        Me.listViewTarefas.Location = New System.Drawing.Point(29, 56)
        Me.listViewTarefas.MultiSelect = False
        Me.listViewTarefas.Name = "listViewTarefas"
        Me.listViewTarefas.Size = New System.Drawing.Size(925, 749)
        Me.listViewTarefas.TabIndex = 13
        Me.listViewTarefas.UseCompatibleStateImageBehavior = False
        Me.listViewTarefas.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "Id"
        Me.Id.Width = 25
        '
        'Descricao
        '
        Me.Descricao.Text = "Descrição"
        Me.Descricao.Width = 320
        '
        'Horário
        '
        Me.Horário.Text = "Horário Inicio"
        Me.Horário.Width = 142
        '
        'Duração
        '
        Me.Duração.Text = "Duração"
        Me.Duração.Width = 118
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        Me.Estado.Width = 136
        '
        'Categoria
        '
        Me.Categoria.Text = "Categoria"
        Me.Categoria.Width = 179
        '
        'btnIrSemanaAtual
        '
        Me.btnIrSemanaAtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnIrSemanaAtual.FlatAppearance.BorderSize = 0
        Me.btnIrSemanaAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrSemanaAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(548, 16)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(65, 33)
        Me.btnIrSemanaAtual.TabIndex = 25
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = False
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvancarSemana.FlatAppearance.BorderSize = 0
        Me.btnAvancarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvancarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvancarSemana.Location = New System.Drawing.Point(919, 16)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 33)
        Me.btnAvancarSemana.TabIndex = 24
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = False
        '
        'lblSemana
        '
        Me.lblSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemana.Location = New System.Drawing.Point(660, 16)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(253, 33)
        Me.lblSemana.TabIndex = 23
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVoltarSemana.FlatAppearance.BorderSize = 0
        Me.btnVoltarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltarSemana.Location = New System.Drawing.Point(619, 16)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 33)
        Me.btnVoltarSemana.TabIndex = 21
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = False
        '
        'btnEditarTarefa
        '
        Me.btnEditarTarefa.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditarTarefa.FlatAppearance.BorderSize = 0
        Me.btnEditarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarTarefa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarTarefa.Location = New System.Drawing.Point(518, 811)
        Me.btnEditarTarefa.Name = "btnEditarTarefa"
        Me.btnEditarTarefa.Size = New System.Drawing.Size(221, 28)
        Me.btnEditarTarefa.TabIndex = 28
        Me.btnEditarTarefa.Text = "Editar"
        Me.btnEditarTarefa.UseVisualStyleBackColor = False
        '
        'btnApagarTarefa
        '
        Me.btnApagarTarefa.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagarTarefa.FlatAppearance.BorderSize = 0
        Me.btnApagarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarTarefa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarTarefa.Location = New System.Drawing.Point(745, 811)
        Me.btnApagarTarefa.Name = "btnApagarTarefa"
        Me.btnApagarTarefa.Size = New System.Drawing.Size(209, 28)
        Me.btnApagarTarefa.TabIndex = 27
        Me.btnApagarTarefa.Text = "Apagar"
        Me.btnApagarTarefa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Categoria:"
        '
        'cbFiltroCategoria
        '
        Me.cbFiltroCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbFiltroCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroCategoria.FormattingEnabled = True
        Me.cbFiltroCategoria.Location = New System.Drawing.Point(111, 21)
        Me.cbFiltroCategoria.Name = "cbFiltroCategoria"
        Me.cbFiltroCategoria.Size = New System.Drawing.Size(121, 24)
        Me.cbFiltroCategoria.TabIndex = 30
        '
        'cbFiltroEstado
        '
        Me.cbFiltroEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroEstado.FormattingEnabled = True
        Me.cbFiltroEstado.Location = New System.Drawing.Point(335, 21)
        Me.cbFiltroEstado.Name = "cbFiltroEstado"
        Me.cbFiltroEstado.Size = New System.Drawing.Size(164, 24)
        Me.cbFiltroEstado.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Estado:"
        '
        'btnAddTarefa
        '
        Me.btnAddTarefa.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAddTarefa.FlatAppearance.BorderSize = 0
        Me.btnAddTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTarefa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTarefa.ForeColor = System.Drawing.Color.White
        Me.btnAddTarefa.Location = New System.Drawing.Point(29, 811)
        Me.btnAddTarefa.Name = "btnAddTarefa"
        Me.btnAddTarefa.Size = New System.Drawing.Size(483, 28)
        Me.btnAddTarefa.TabIndex = 33
        Me.btnAddTarefa.Text = "Adicionar"
        Me.btnAddTarefa.UseVisualStyleBackColor = False
        '
        'FormTarefa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 851)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAddTarefa)
        Me.Controls.Add(Me.cbFiltroEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbFiltroCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditarTarefa)
        Me.Controls.Add(Me.btnApagarTarefa)
        Me.Controls.Add(Me.btnIrSemanaAtual)
        Me.Controls.Add(Me.btnAvancarSemana)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.btnVoltarSemana)
        Me.Controls.Add(Me.listViewTarefas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTarefa"
        Me.Text = "FormTarefa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listViewTarefas As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Descricao As ColumnHeader
    Friend WithEvents Horário As ColumnHeader
    Friend WithEvents Duração As ColumnHeader
    Friend WithEvents Estado As ColumnHeader
    Friend WithEvents Categoria As ColumnHeader
    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents btnEditarTarefa As Button
    Friend WithEvents btnApagarTarefa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFiltroCategoria As ComboBox
    Friend WithEvents cbFiltroEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddTarefa As Button
End Class
