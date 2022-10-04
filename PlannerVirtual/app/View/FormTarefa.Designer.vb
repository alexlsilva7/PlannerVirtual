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
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.btnEditarTarefa = New System.Windows.Forms.Button()
        Me.btnApagarTarefa = New System.Windows.Forms.Button()
        Me.btnAddTarefa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(25, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tarefas"
        '
        'listViewTarefas
        '
        Me.listViewTarefas.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewTarefas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Descricao, Me.Horário, Me.Duração, Me.Estado, Me.Categoria})
        Me.listViewTarefas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewTarefas.FullRowSelect = True
        Me.listViewTarefas.HideSelection = False
        Me.listViewTarefas.Location = New System.Drawing.Point(29, 85)
        Me.listViewTarefas.MultiSelect = False
        Me.listViewTarefas.Name = "listViewTarefas"
        Me.listViewTarefas.Size = New System.Drawing.Size(729, 295)
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
        Me.Descricao.Width = 125
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
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(426, 52)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(65, 23)
        Me.btnIrSemanaAtual.TabIndex = 25
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = True
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.Location = New System.Drawing.Point(723, 52)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnAvancarSemana.TabIndex = 24
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = True
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(559, 60)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(46, 13)
        Me.lblSemana.TabIndex = 23
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(594, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Semana"
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.Location = New System.Drawing.Point(497, 52)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnVoltarSemana.TabIndex = 21
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = True
        '
        'btnEditarTarefa
        '
        Me.btnEditarTarefa.Location = New System.Drawing.Point(384, 415)
        Me.btnEditarTarefa.Name = "btnEditarTarefa"
        Me.btnEditarTarefa.Size = New System.Drawing.Size(221, 23)
        Me.btnEditarTarefa.TabIndex = 28
        Me.btnEditarTarefa.Text = "Editar"
        Me.btnEditarTarefa.UseVisualStyleBackColor = True
        '
        'btnApagarTarefa
        '
        Me.btnApagarTarefa.Location = New System.Drawing.Point(184, 415)
        Me.btnApagarTarefa.Name = "btnApagarTarefa"
        Me.btnApagarTarefa.Size = New System.Drawing.Size(194, 23)
        Me.btnApagarTarefa.TabIndex = 27
        Me.btnApagarTarefa.Text = "Apagar"
        Me.btnApagarTarefa.UseVisualStyleBackColor = True
        '
        'btnAddTarefa
        '
        Me.btnAddTarefa.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAddTarefa.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddTarefa.Location = New System.Drawing.Point(184, 386)
        Me.btnAddTarefa.Name = "btnAddTarefa"
        Me.btnAddTarefa.Size = New System.Drawing.Size(421, 23)
        Me.btnAddTarefa.TabIndex = 26
        Me.btnAddTarefa.Text = "Adicionar Tarefa"
        Me.btnAddTarefa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tarefas a se fazer:"
        '
        'FormTarefa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditarTarefa)
        Me.Controls.Add(Me.btnApagarTarefa)
        Me.Controls.Add(Me.btnAddTarefa)
        Me.Controls.Add(Me.btnIrSemanaAtual)
        Me.Controls.Add(Me.btnAvancarSemana)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnVoltarSemana)
        Me.Controls.Add(Me.listViewTarefas)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormTarefa"
        Me.Text = "FormTarefa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
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
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents btnEditarTarefa As Button
    Friend WithEvents btnApagarTarefa As Button
    Friend WithEvents btnAddTarefa As Button
    Friend WithEvents Label1 As Label
End Class
