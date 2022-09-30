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
        Me.dgvLigacoesImportantes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvReunioes = New System.Windows.Forms.DataGridView()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddLigacaoImportate = New System.Windows.Forms.Button()
        Me.btnAddReuniao = New System.Windows.Forms.Button()
        Me.btnAddCompra = New System.Windows.Forms.Button()
        CType(Me.dgvLigacoesImportantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReunioes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvLigacoesImportantes
        '
        Me.dgvLigacoesImportantes.AllowUserToAddRows = False
        Me.dgvLigacoesImportantes.AllowUserToDeleteRows = False
        Me.dgvLigacoesImportantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLigacoesImportantes.Location = New System.Drawing.Point(26, 99)
        Me.dgvLigacoesImportantes.Name = "dgvLigacoesImportantes"
        Me.dgvLigacoesImportantes.ReadOnly = True
        Me.dgvLigacoesImportantes.Size = New System.Drawing.Size(188, 313)
        Me.dgvLigacoesImportantes.TabIndex = 2
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
        'dgvReunioes
        '
        Me.dgvReunioes.AllowUserToAddRows = False
        Me.dgvReunioes.AllowUserToDeleteRows = False
        Me.dgvReunioes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReunioes.Location = New System.Drawing.Point(278, 99)
        Me.dgvReunioes.Name = "dgvReunioes"
        Me.dgvReunioes.ReadOnly = True
        Me.dgvReunioes.Size = New System.Drawing.Size(188, 313)
        Me.dgvReunioes.TabIndex = 5
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AllowUserToDeleteRows = False
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Location = New System.Drawing.Point(533, 99)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.ReadOnly = True
        Me.dgvCompras.Size = New System.Drawing.Size(188, 313)
        Me.dgvCompras.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(275, 66)
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
        Me.btnAddLigacaoImportate.Size = New System.Drawing.Size(188, 23)
        Me.btnAddLigacaoImportate.TabIndex = 9
        Me.btnAddLigacaoImportate.Text = "Adicionar Lembrete "
        Me.btnAddLigacaoImportate.UseVisualStyleBackColor = True
        '
        'btnAddReuniao
        '
        Me.btnAddReuniao.Location = New System.Drawing.Point(278, 418)
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
        'FormLembrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 470)
        Me.Controls.Add(Me.btnAddCompra)
        Me.Controls.Add(Me.btnAddReuniao)
        Me.Controls.Add(Me.btnAddLigacaoImportate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvCompras)
        Me.Controls.Add(Me.dgvReunioes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLigacoesImportantes)
        Me.Name = "FormLembrete"
        Me.Text = "FormLembrete"
        CType(Me.dgvLigacoesImportantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReunioes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvLigacoesImportantes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvReunioes As DataGridView
    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddLigacaoImportate As Button
    Friend WithEvents btnAddReuniao As Button
    Friend WithEvents btnAddCompra As Button
End Class
