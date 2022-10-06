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
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descrição = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewMensais = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewAnuais = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdicionarMetaSemanal = New System.Windows.Forms.Button()
        Me.btnApagarSemanal = New System.Windows.Forms.Button()
        Me.btnEditarSemanal = New System.Windows.Forms.Button()
        Me.btnApagarMensal = New System.Windows.Forms.Button()
        Me.btnEditarMensal = New System.Windows.Forms.Button()
        Me.btnAdicionarMetaMensal = New System.Windows.Forms.Button()
        Me.btnApagarAnual = New System.Windows.Forms.Button()
        Me.btnEditarAnual = New System.Windows.Forms.Button()
        Me.btnAdicionarMetaAnual = New System.Windows.Forms.Button()
        Me.btnSemanaAtual = New System.Windows.Forms.Button()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.btnAnoAtual = New System.Windows.Forms.Button()
        Me.btnAvancarAno = New System.Windows.Forms.Button()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.btnVoltarAno = New System.Windows.Forms.Button()
        Me.btnMesAtual = New System.Windows.Forms.Button()
        Me.btnAvancarMes = New System.Windows.Forms.Button()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.btnVoltarMes = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFiltroEstadoSemanal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFiltroEstadoMensal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbFiltroEstadoAnual = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listViewSemanais
        '
        Me.listViewSemanais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.Descrição, Me.Categoria, Me.Estado, Me.Data})
        Me.listViewSemanais.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.listViewSemanais.FullRowSelect = True
        Me.listViewSemanais.HideSelection = False
        Me.listViewSemanais.Location = New System.Drawing.Point(9, 49)
        Me.listViewSemanais.Margin = New System.Windows.Forms.Padding(4)
        Me.listViewSemanais.MultiSelect = False
        Me.listViewSemanais.Name = "listViewSemanais"
        Me.listViewSemanais.Size = New System.Drawing.Size(954, 200)
        Me.listViewSemanais.TabIndex = 1
        Me.listViewSemanais.UseCompatibleStateImageBehavior = False
        Me.listViewSemanais.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "Id"
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
        'ListViewMensais
        '
        Me.ListViewMensais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewMensais.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ListViewMensais.FullRowSelect = True
        Me.ListViewMensais.HideSelection = False
        Me.ListViewMensais.Location = New System.Drawing.Point(9, 351)
        Me.ListViewMensais.Margin = New System.Windows.Forms.Padding(4)
        Me.ListViewMensais.MultiSelect = False
        Me.ListViewMensais.Name = "ListViewMensais"
        Me.ListViewMensais.Size = New System.Drawing.Size(954, 200)
        Me.ListViewMensais.TabIndex = 3
        Me.ListViewMensais.UseCompatibleStateImageBehavior = False
        Me.ListViewMensais.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Id"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Descrição"
        Me.ColumnHeader1.Width = 218
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Categoria"
        Me.ColumnHeader2.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Estado"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Data"
        Me.ColumnHeader5.Width = 113
        '
        'ListViewAnuais
        '
        Me.ListViewAnuais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListViewAnuais.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ListViewAnuais.FullRowSelect = True
        Me.ListViewAnuais.HideSelection = False
        Me.ListViewAnuais.Location = New System.Drawing.Point(9, 644)
        Me.ListViewAnuais.Margin = New System.Windows.Forms.Padding(4)
        Me.ListViewAnuais.MultiSelect = False
        Me.ListViewAnuais.Name = "ListViewAnuais"
        Me.ListViewAnuais.Size = New System.Drawing.Size(954, 200)
        Me.ListViewAnuais.TabIndex = 5
        Me.ListViewAnuais.UseCompatibleStateImageBehavior = False
        Me.ListViewAnuais.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Id"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Descrição"
        Me.ColumnHeader6.Width = 253
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Categoria"
        Me.ColumnHeader7.Width = 169
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Estado"
        Me.ColumnHeader9.Width = 128
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Data"
        Me.ColumnHeader10.Width = 129
        '
        'btnAdicionarMetaSemanal
        '
        Me.btnAdicionarMetaSemanal.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAdicionarMetaSemanal.FlatAppearance.BorderSize = 0
        Me.btnAdicionarMetaSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarMetaSemanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarMetaSemanal.ForeColor = System.Drawing.Color.White
        Me.btnAdicionarMetaSemanal.Location = New System.Drawing.Point(11, 257)
        Me.btnAdicionarMetaSemanal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionarMetaSemanal.Name = "btnAdicionarMetaSemanal"
        Me.btnAdicionarMetaSemanal.Size = New System.Drawing.Size(160, 28)
        Me.btnAdicionarMetaSemanal.TabIndex = 7
        Me.btnAdicionarMetaSemanal.Text = "Adicionar"
        Me.btnAdicionarMetaSemanal.UseVisualStyleBackColor = False
        '
        'btnApagarSemanal
        '
        Me.btnApagarSemanal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagarSemanal.FlatAppearance.BorderSize = 0
        Me.btnApagarSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarSemanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarSemanal.Location = New System.Drawing.Point(343, 257)
        Me.btnApagarSemanal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApagarSemanal.Name = "btnApagarSemanal"
        Me.btnApagarSemanal.Size = New System.Drawing.Size(232, 28)
        Me.btnApagarSemanal.TabIndex = 10
        Me.btnApagarSemanal.Text = "Apagar"
        Me.btnApagarSemanal.UseVisualStyleBackColor = False
        '
        'btnEditarSemanal
        '
        Me.btnEditarSemanal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditarSemanal.FlatAppearance.BorderSize = 0
        Me.btnEditarSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarSemanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarSemanal.Location = New System.Drawing.Point(181, 257)
        Me.btnEditarSemanal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarSemanal.Name = "btnEditarSemanal"
        Me.btnEditarSemanal.Size = New System.Drawing.Size(153, 28)
        Me.btnEditarSemanal.TabIndex = 8
        Me.btnEditarSemanal.Text = "Editar"
        Me.btnEditarSemanal.UseVisualStyleBackColor = False
        '
        'btnApagarMensal
        '
        Me.btnApagarMensal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagarMensal.FlatAppearance.BorderSize = 0
        Me.btnApagarMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarMensal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarMensal.Location = New System.Drawing.Point(343, 559)
        Me.btnApagarMensal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApagarMensal.Name = "btnApagarMensal"
        Me.btnApagarMensal.Size = New System.Drawing.Size(232, 28)
        Me.btnApagarMensal.TabIndex = 13
        Me.btnApagarMensal.Text = "Apagar"
        Me.btnApagarMensal.UseVisualStyleBackColor = False
        '
        'btnEditarMensal
        '
        Me.btnEditarMensal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditarMensal.FlatAppearance.BorderSize = 0
        Me.btnEditarMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarMensal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarMensal.Location = New System.Drawing.Point(179, 559)
        Me.btnEditarMensal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarMensal.Name = "btnEditarMensal"
        Me.btnEditarMensal.Size = New System.Drawing.Size(153, 28)
        Me.btnEditarMensal.TabIndex = 12
        Me.btnEditarMensal.Text = "Editar"
        Me.btnEditarMensal.UseVisualStyleBackColor = False
        '
        'btnAdicionarMetaMensal
        '
        Me.btnAdicionarMetaMensal.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAdicionarMetaMensal.FlatAppearance.BorderSize = 0
        Me.btnAdicionarMetaMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarMetaMensal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarMetaMensal.ForeColor = System.Drawing.Color.White
        Me.btnAdicionarMetaMensal.Location = New System.Drawing.Point(9, 559)
        Me.btnAdicionarMetaMensal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionarMetaMensal.Name = "btnAdicionarMetaMensal"
        Me.btnAdicionarMetaMensal.Size = New System.Drawing.Size(160, 28)
        Me.btnAdicionarMetaMensal.TabIndex = 11
        Me.btnAdicionarMetaMensal.Text = "Adicionar"
        Me.btnAdicionarMetaMensal.UseVisualStyleBackColor = False
        '
        'btnApagarAnual
        '
        Me.btnApagarAnual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnApagarAnual.FlatAppearance.BorderSize = 0
        Me.btnApagarAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagarAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarAnual.Location = New System.Drawing.Point(341, 852)
        Me.btnApagarAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApagarAnual.Name = "btnApagarAnual"
        Me.btnApagarAnual.Size = New System.Drawing.Size(232, 28)
        Me.btnApagarAnual.TabIndex = 16
        Me.btnApagarAnual.Text = "Apagar"
        Me.btnApagarAnual.UseVisualStyleBackColor = False
        '
        'btnEditarAnual
        '
        Me.btnEditarAnual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnEditarAnual.FlatAppearance.BorderSize = 0
        Me.btnEditarAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarAnual.Location = New System.Drawing.Point(179, 852)
        Me.btnEditarAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarAnual.Name = "btnEditarAnual"
        Me.btnEditarAnual.Size = New System.Drawing.Size(153, 28)
        Me.btnEditarAnual.TabIndex = 15
        Me.btnEditarAnual.Text = "Editar"
        Me.btnEditarAnual.UseVisualStyleBackColor = False
        '
        'btnAdicionarMetaAnual
        '
        Me.btnAdicionarMetaAnual.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAdicionarMetaAnual.FlatAppearance.BorderSize = 0
        Me.btnAdicionarMetaAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarMetaAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarMetaAnual.ForeColor = System.Drawing.Color.White
        Me.btnAdicionarMetaAnual.Location = New System.Drawing.Point(9, 852)
        Me.btnAdicionarMetaAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionarMetaAnual.Name = "btnAdicionarMetaAnual"
        Me.btnAdicionarMetaAnual.Size = New System.Drawing.Size(160, 28)
        Me.btnAdicionarMetaAnual.TabIndex = 14
        Me.btnAdicionarMetaAnual.Text = "Adicionar"
        Me.btnAdicionarMetaAnual.UseVisualStyleBackColor = False
        '
        'btnSemanaAtual
        '
        Me.btnSemanaAtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSemanaAtual.FlatAppearance.BorderSize = 0
        Me.btnSemanaAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemanaAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemanaAtual.Location = New System.Drawing.Point(510, 13)
        Me.btnSemanaAtual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSemanaAtual.Name = "btnSemanaAtual"
        Me.btnSemanaAtual.Size = New System.Drawing.Size(98, 28)
        Me.btnSemanaAtual.TabIndex = 35
        Me.btnSemanaAtual.Text = "Atual"
        Me.btnSemanaAtual.UseVisualStyleBackColor = False
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvancarSemana.FlatAppearance.BorderSize = 0
        Me.btnAvancarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvancarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvancarSemana.Location = New System.Drawing.Point(911, 13)
        Me.btnAvancarSemana.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(52, 28)
        Me.btnAvancarSemana.TabIndex = 34
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = False
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemana.Location = New System.Drawing.Point(691, 21)
        Me.lblSemana.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(64, 16)
        Me.lblSemana.TabIndex = 33
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVoltarSemana.FlatAppearance.BorderSize = 0
        Me.btnVoltarSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltarSemana.Location = New System.Drawing.Point(629, 13)
        Me.btnVoltarSemana.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(52, 28)
        Me.btnVoltarSemana.TabIndex = 31
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = False
        '
        'btnAnoAtual
        '
        Me.btnAnoAtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAnoAtual.FlatAppearance.BorderSize = 0
        Me.btnAnoAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnoAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnoAtual.Location = New System.Drawing.Point(510, 609)
        Me.btnAnoAtual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnoAtual.Name = "btnAnoAtual"
        Me.btnAnoAtual.Size = New System.Drawing.Size(98, 28)
        Me.btnAnoAtual.TabIndex = 46
        Me.btnAnoAtual.Text = "Atual"
        Me.btnAnoAtual.UseVisualStyleBackColor = False
        '
        'btnAvancarAno
        '
        Me.btnAvancarAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvancarAno.FlatAppearance.BorderSize = 0
        Me.btnAvancarAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvancarAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvancarAno.Location = New System.Drawing.Point(911, 609)
        Me.btnAvancarAno.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAvancarAno.Name = "btnAvancarAno"
        Me.btnAvancarAno.Size = New System.Drawing.Size(52, 28)
        Me.btnAvancarAno.TabIndex = 45
        Me.btnAvancarAno.Text = ">"
        Me.btnAvancarAno.UseVisualStyleBackColor = False
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(691, 617)
        Me.lblAno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(34, 16)
        Me.lblAno.TabIndex = 44
        Me.lblAno.Text = "Ano"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarAno
        '
        Me.btnVoltarAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVoltarAno.FlatAppearance.BorderSize = 0
        Me.btnVoltarAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltarAno.Location = New System.Drawing.Point(629, 609)
        Me.btnVoltarAno.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVoltarAno.Name = "btnVoltarAno"
        Me.btnVoltarAno.Size = New System.Drawing.Size(52, 28)
        Me.btnVoltarAno.TabIndex = 43
        Me.btnVoltarAno.Text = "<"
        Me.btnVoltarAno.UseVisualStyleBackColor = False
        '
        'btnMesAtual
        '
        Me.btnMesAtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnMesAtual.FlatAppearance.BorderSize = 0
        Me.btnMesAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMesAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesAtual.Location = New System.Drawing.Point(510, 315)
        Me.btnMesAtual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMesAtual.Name = "btnMesAtual"
        Me.btnMesAtual.Size = New System.Drawing.Size(98, 28)
        Me.btnMesAtual.TabIndex = 50
        Me.btnMesAtual.Text = "Atual"
        Me.btnMesAtual.UseVisualStyleBackColor = False
        '
        'btnAvancarMes
        '
        Me.btnAvancarMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvancarMes.FlatAppearance.BorderSize = 0
        Me.btnAvancarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvancarMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvancarMes.Location = New System.Drawing.Point(911, 315)
        Me.btnAvancarMes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAvancarMes.Name = "btnAvancarMes"
        Me.btnAvancarMes.Size = New System.Drawing.Size(52, 28)
        Me.btnAvancarMes.TabIndex = 49
        Me.btnAvancarMes.Text = ">"
        Me.btnAvancarMes.UseVisualStyleBackColor = False
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(691, 321)
        Me.lblMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(36, 16)
        Me.lblMes.TabIndex = 48
        Me.lblMes.Text = "Mês"
        Me.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltarMes
        '
        Me.btnVoltarMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnVoltarMes.FlatAppearance.BorderSize = 0
        Me.btnVoltarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltarMes.Location = New System.Drawing.Point(629, 315)
        Me.btnVoltarMes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVoltarMes.Name = "btnVoltarMes"
        Me.btnVoltarMes.Size = New System.Drawing.Size(52, 28)
        Me.btnVoltarMes.TabIndex = 47
        Me.btnVoltarMes.Text = "<"
        Me.btnVoltarMes.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(5, 609)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 24)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Metas Anuais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(5, 315)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Metas Mensais"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Metas Semanais"
        '
        'cbFiltroEstadoSemanal
        '
        Me.cbFiltroEstadoSemanal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbFiltroEstadoSemanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroEstadoSemanal.FormattingEnabled = True
        Me.cbFiltroEstadoSemanal.Items.AddRange(New Object() {"Todas", "Cumprida", "Não cumprida", "Parcialmente cumprida"})
        Me.cbFiltroEstadoSemanal.Location = New System.Drawing.Point(298, 16)
        Me.cbFiltroEstadoSemanal.Name = "cbFiltroEstadoSemanal"
        Me.cbFiltroEstadoSemanal.Size = New System.Drawing.Size(176, 24)
        Me.cbFiltroEstadoSemanal.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Estado:"
        '
        'cbFiltroEstadoMensal
        '
        Me.cbFiltroEstadoMensal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbFiltroEstadoMensal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroEstadoMensal.FormattingEnabled = True
        Me.cbFiltroEstadoMensal.Items.AddRange(New Object() {"Todas", "Cumprida", "Não cumprida", "Parcialmente cumprida"})
        Me.cbFiltroEstadoMensal.Location = New System.Drawing.Point(298, 316)
        Me.cbFiltroEstadoMensal.Name = "cbFiltroEstadoMensal"
        Me.cbFiltroEstadoMensal.Size = New System.Drawing.Size(176, 24)
        Me.cbFiltroEstadoMensal.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Estado:"
        '
        'cbFiltroEstadoAnual
        '
        Me.cbFiltroEstadoAnual.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbFiltroEstadoAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroEstadoAnual.FormattingEnabled = True
        Me.cbFiltroEstadoAnual.Items.AddRange(New Object() {"Todas", "Cumprida", "Não cumprida", "Parcialmente cumprida"})
        Me.cbFiltroEstadoAnual.Location = New System.Drawing.Point(298, 610)
        Me.cbFiltroEstadoAnual.Name = "cbFiltroEstadoAnual"
        Me.cbFiltroEstadoAnual.Size = New System.Drawing.Size(176, 24)
        Me.cbFiltroEstadoAnual.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 615)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Estado:"
        '
        'FormMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 911)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbFiltroEstadoAnual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbFiltroEstadoMensal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbFiltroEstadoSemanal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnMesAtual)
        Me.Controls.Add(Me.btnAvancarMes)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.btnVoltarMes)
        Me.Controls.Add(Me.btnAnoAtual)
        Me.Controls.Add(Me.btnAvancarAno)
        Me.Controls.Add(Me.lblAno)
        Me.Controls.Add(Me.btnVoltarAno)
        Me.Controls.Add(Me.btnSemanaAtual)
        Me.Controls.Add(Me.btnAvancarSemana)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.btnVoltarSemana)
        Me.Controls.Add(Me.btnApagarAnual)
        Me.Controls.Add(Me.btnEditarAnual)
        Me.Controls.Add(Me.btnAdicionarMetaAnual)
        Me.Controls.Add(Me.btnApagarMensal)
        Me.Controls.Add(Me.btnEditarMensal)
        Me.Controls.Add(Me.btnAdicionarMetaMensal)
        Me.Controls.Add(Me.btnApagarSemanal)
        Me.Controls.Add(Me.btnEditarSemanal)
        Me.Controls.Add(Me.btnAdicionarMetaSemanal)
        Me.Controls.Add(Me.ListViewAnuais)
        Me.Controls.Add(Me.ListViewMensais)
        Me.Controls.Add(Me.listViewSemanais)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents ListViewMensais As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ListViewAnuais As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnAdicionarMetaSemanal As Button
    Friend WithEvents btnApagarSemanal As Button
    Friend WithEvents id As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnEditarSemanal As Button
    Friend WithEvents btnApagarMensal As Button
    Friend WithEvents btnEditarMensal As Button
    Friend WithEvents btnAdicionarMetaMensal As Button
    Friend WithEvents btnApagarAnual As Button
    Friend WithEvents btnEditarAnual As Button
    Friend WithEvents btnAdicionarMetaAnual As Button
    Friend WithEvents btnSemanaAtual As Button
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents btnAnoAtual As Button
    Friend WithEvents btnAvancarAno As Button
    Friend WithEvents lblAno As Label
    Friend WithEvents btnVoltarAno As Button
    Friend WithEvents btnMesAtual As Button
    Friend WithEvents btnAvancarMes As Button
    Friend WithEvents lblMes As Label
    Friend WithEvents btnVoltarMes As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFiltroEstadoSemanal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFiltroEstadoMensal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbFiltroEstadoAnual As ComboBox
    Friend WithEvents Label5 As Label
End Class
