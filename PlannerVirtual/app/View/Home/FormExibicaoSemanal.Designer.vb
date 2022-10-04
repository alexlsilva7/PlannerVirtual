<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExibicaoSemanal
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
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.listViewLigacoes = New System.Windows.Forms.ListView()
        Me.Hora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView5 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView6 = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIrSemanaAtual
        '
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(30, 33)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(65, 23)
        Me.btnIrSemanaAtual.TabIndex = 29
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = True
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.Location = New System.Drawing.Point(327, 33)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnAvancarSemana.TabIndex = 28
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = True
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(163, 41)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(46, 13)
        Me.lblSemana.TabIndex = 27
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(198, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Semana"
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.Location = New System.Drawing.Point(101, 33)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 23)
        Me.btnVoltarSemana.TabIndex = 25
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnAvancarSemana)
        Me.Panel1.Controls.Add(Me.btnIrSemanaAtual)
        Me.Panel1.Controls.Add(Me.btnVoltarSemana)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblSemana)
        Me.Panel1.Location = New System.Drawing.Point(832, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 70)
        Me.Panel1.TabIndex = 30
        '
        'listViewLigacoes
        '
        Me.listViewLigacoes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewLigacoes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Hora, Me.Descricao})
        Me.listViewLigacoes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewLigacoes.FullRowSelect = True
        Me.listViewLigacoes.HideSelection = False
        Me.listViewLigacoes.Location = New System.Drawing.Point(0, 123)
        Me.listViewLigacoes.MultiSelect = False
        Me.listViewLigacoes.Name = "listViewLigacoes"
        Me.listViewLigacoes.Size = New System.Drawing.Size(230, 454)
        Me.listViewLigacoes.TabIndex = 31
        Me.listViewLigacoes.UseCompatibleStateImageBehavior = False
        Me.listViewLigacoes.View = System.Windows.Forms.View.Details
        '
        'Hora
        '
        Me.Hora.Text = "Hora"
        Me.Hora.Width = 66
        '
        'Descricao
        '
        Me.Descricao.Text = "Descrição"
        Me.Descricao.Width = 159
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1416, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 30)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Sabado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1180, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 30)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Sexta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(944, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 30)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Quinta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(708, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 30)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Quarta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(472, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 30)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Terça"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 30)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Segunda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(230, 30)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Domingo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(236, 123)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(230, 454)
        Me.ListView1.TabIndex = 40
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Hora"
        Me.ColumnHeader1.Width = 66
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 159
        '
        'ListView2
        '
        Me.ListView2.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(472, 123)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(230, 454)
        Me.ListView2.TabIndex = 41
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Hora"
        Me.ColumnHeader3.Width = 66
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descrição"
        Me.ColumnHeader4.Width = 159
        '
        'ListView3
        '
        Me.ListView3.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(708, 123)
        Me.ListView3.MultiSelect = False
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(230, 454)
        Me.ListView3.TabIndex = 42
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hora"
        Me.ColumnHeader5.Width = 66
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Descrição"
        Me.ColumnHeader6.Width = 159
        '
        'ListView4
        '
        Me.ListView4.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView4.FullRowSelect = True
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(944, 123)
        Me.ListView4.MultiSelect = False
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(230, 454)
        Me.ListView4.TabIndex = 43
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Hora"
        Me.ColumnHeader7.Width = 66
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Descrição"
        Me.ColumnHeader8.Width = 159
        '
        'ListView5
        '
        Me.ListView5.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView5.FullRowSelect = True
        Me.ListView5.HideSelection = False
        Me.ListView5.Location = New System.Drawing.Point(1180, 123)
        Me.ListView5.MultiSelect = False
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(230, 454)
        Me.ListView5.TabIndex = 44
        Me.ListView5.UseCompatibleStateImageBehavior = False
        Me.ListView5.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Hora"
        Me.ColumnHeader9.Width = 66
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Descrição"
        Me.ColumnHeader10.Width = 159
        '
        'ListView6
        '
        Me.ListView6.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView6.FullRowSelect = True
        Me.ListView6.HideSelection = False
        Me.ListView6.Location = New System.Drawing.Point(1416, 123)
        Me.ListView6.MultiSelect = False
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(230, 454)
        Me.ListView6.TabIndex = 45
        Me.ListView6.UseCompatibleStateImageBehavior = False
        Me.ListView6.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Hora"
        Me.ColumnHeader11.Width = 66
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Descrição"
        Me.ColumnHeader12.Width = 159
        '
        'FormExibicaoSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1662, 589)
        Me.Controls.Add(Me.ListView6)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.listViewLigacoes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormExibicaoSemanal"
        Me.Text = "FormExibicaoSemanal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents listViewLigacoes As ListView
    Friend WithEvents Hora As ColumnHeader
    Friend WithEvents Descricao As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ListView5 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ListView6 As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
End Class
