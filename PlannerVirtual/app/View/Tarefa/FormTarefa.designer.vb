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
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFiltroCategoria = New System.Windows.Forms.ComboBox()
        Me.cbFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddTarefa = New System.Windows.Forms.Button()
        Me.listViewSabado = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewSexta = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewQuinta = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewQuarta = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewTerca = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewSegunda = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewDomingo = New System.Windows.Forms.ListView()
        Me.Descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDay7 = New System.Windows.Forms.Label()
        Me.lblDay6 = New System.Windows.Forms.Label()
        Me.lblDay5 = New System.Windows.Forms.Label()
        Me.lblDay4 = New System.Windows.Forms.Label()
        Me.lblDay3 = New System.Windows.Forms.Label()
        Me.lblDay2 = New System.Windows.Forms.Label()
        Me.lblDay1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.btnAddTarefa.Location = New System.Drawing.Point(12, 809)
        Me.btnAddTarefa.Name = "btnAddTarefa"
        Me.btnAddTarefa.Size = New System.Drawing.Size(952, 28)
        Me.btnAddTarefa.TabIndex = 33
        Me.btnAddTarefa.Text = "Adicionar"
        Me.btnAddTarefa.UseVisualStyleBackColor = False
        '
        'listViewSabado
        '
        Me.listViewSabado.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewSabado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12})
        Me.listViewSabado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewSabado.FullRowSelect = True
        Me.listViewSabado.HideSelection = False
        Me.listViewSabado.Location = New System.Drawing.Point(836, 130)
        Me.listViewSabado.MultiSelect = False
        Me.listViewSabado.Name = "listViewSabado"
        Me.listViewSabado.Size = New System.Drawing.Size(139, 662)
        Me.listViewSabado.TabIndex = 52
        Me.listViewSabado.UseCompatibleStateImageBehavior = False
        Me.listViewSabado.View = System.Windows.Forms.View.List
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Descrição"
        Me.ColumnHeader12.Width = 139
        '
        'listViewSexta
        '
        Me.listViewSexta.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewSexta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10})
        Me.listViewSexta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewSexta.FullRowSelect = True
        Me.listViewSexta.HideSelection = False
        Me.listViewSexta.Location = New System.Drawing.Point(697, 130)
        Me.listViewSexta.MultiSelect = False
        Me.listViewSexta.Name = "listViewSexta"
        Me.listViewSexta.Size = New System.Drawing.Size(139, 662)
        Me.listViewSexta.TabIndex = 51
        Me.listViewSexta.UseCompatibleStateImageBehavior = False
        Me.listViewSexta.View = System.Windows.Forms.View.List
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Descrição"
        Me.ColumnHeader10.Width = 139
        '
        'listViewQuinta
        '
        Me.listViewQuinta.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewQuinta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.listViewQuinta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewQuinta.FullRowSelect = True
        Me.listViewQuinta.HideSelection = False
        Me.listViewQuinta.Location = New System.Drawing.Point(558, 130)
        Me.listViewQuinta.MultiSelect = False
        Me.listViewQuinta.Name = "listViewQuinta"
        Me.listViewQuinta.Size = New System.Drawing.Size(139, 662)
        Me.listViewQuinta.TabIndex = 50
        Me.listViewQuinta.UseCompatibleStateImageBehavior = False
        Me.listViewQuinta.View = System.Windows.Forms.View.List
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Descrição"
        Me.ColumnHeader8.Width = 139
        '
        'listViewQuarta
        '
        Me.listViewQuarta.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewQuarta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6})
        Me.listViewQuarta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewQuarta.FullRowSelect = True
        Me.listViewQuarta.HideSelection = False
        Me.listViewQuarta.Location = New System.Drawing.Point(419, 130)
        Me.listViewQuarta.MultiSelect = False
        Me.listViewQuarta.Name = "listViewQuarta"
        Me.listViewQuarta.Size = New System.Drawing.Size(139, 662)
        Me.listViewQuarta.TabIndex = 49
        Me.listViewQuarta.UseCompatibleStateImageBehavior = False
        Me.listViewQuarta.View = System.Windows.Forms.View.List
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Descrição"
        Me.ColumnHeader6.Width = 139
        '
        'listViewTerca
        '
        Me.listViewTerca.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewTerca.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.listViewTerca.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewTerca.FullRowSelect = True
        Me.listViewTerca.HideSelection = False
        Me.listViewTerca.Location = New System.Drawing.Point(280, 130)
        Me.listViewTerca.MultiSelect = False
        Me.listViewTerca.Name = "listViewTerca"
        Me.listViewTerca.Size = New System.Drawing.Size(139, 662)
        Me.listViewTerca.TabIndex = 48
        Me.listViewTerca.UseCompatibleStateImageBehavior = False
        Me.listViewTerca.View = System.Windows.Forms.View.List
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descrição"
        Me.ColumnHeader4.Width = 139
        '
        'listViewSegunda
        '
        Me.listViewSegunda.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listViewSegunda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.listViewSegunda.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewSegunda.FullRowSelect = True
        Me.listViewSegunda.HideSelection = False
        Me.listViewSegunda.Location = New System.Drawing.Point(141, 130)
        Me.listViewSegunda.MultiSelect = False
        Me.listViewSegunda.Name = "listViewSegunda"
        Me.listViewSegunda.Size = New System.Drawing.Size(139, 662)
        Me.listViewSegunda.TabIndex = 47
        Me.listViewSegunda.UseCompatibleStateImageBehavior = False
        Me.listViewSegunda.View = System.Windows.Forms.View.List
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 139
        '
        'listViewDomingo
        '
        Me.listViewDomingo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Descricao})
        Me.listViewDomingo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewDomingo.FullRowSelect = True
        Me.listViewDomingo.HideSelection = False
        Me.listViewDomingo.Location = New System.Drawing.Point(2, 130)
        Me.listViewDomingo.MultiSelect = False
        Me.listViewDomingo.Name = "listViewDomingo"
        Me.listViewDomingo.Size = New System.Drawing.Size(139, 662)
        Me.listViewDomingo.TabIndex = 46
        Me.listViewDomingo.UseCompatibleStateImageBehavior = False
        Me.listViewDomingo.View = System.Windows.Forms.View.List
        '
        'Descricao
        '
        Me.Descricao.Text = "Descrição"
        Me.Descricao.Width = 139
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(836, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 30)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Sabado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(689, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 30)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Sexta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(558, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 30)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Quinta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(419, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 30)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Quarta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 30)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Terça"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 30)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Segunda"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 30)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Domingo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay7
        '
        Me.lblDay7.BackColor = System.Drawing.Color.White
        Me.lblDay7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay7.Location = New System.Drawing.Point(836, 102)
        Me.lblDay7.Name = "lblDay7"
        Me.lblDay7.Size = New System.Drawing.Size(139, 25)
        Me.lblDay7.TabIndex = 66
        Me.lblDay7.Text = "Sabado"
        Me.lblDay7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay6
        '
        Me.lblDay6.BackColor = System.Drawing.Color.White
        Me.lblDay6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay6.Location = New System.Drawing.Point(689, 102)
        Me.lblDay6.Name = "lblDay6"
        Me.lblDay6.Size = New System.Drawing.Size(147, 25)
        Me.lblDay6.TabIndex = 65
        Me.lblDay6.Text = "Sexta"
        Me.lblDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay5
        '
        Me.lblDay5.BackColor = System.Drawing.Color.White
        Me.lblDay5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay5.Location = New System.Drawing.Point(558, 102)
        Me.lblDay5.Name = "lblDay5"
        Me.lblDay5.Size = New System.Drawing.Size(139, 25)
        Me.lblDay5.TabIndex = 64
        Me.lblDay5.Text = "Quinta"
        Me.lblDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay4
        '
        Me.lblDay4.BackColor = System.Drawing.Color.White
        Me.lblDay4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay4.Location = New System.Drawing.Point(419, 102)
        Me.lblDay4.Name = "lblDay4"
        Me.lblDay4.Size = New System.Drawing.Size(139, 25)
        Me.lblDay4.TabIndex = 63
        Me.lblDay4.Text = "Quarta"
        Me.lblDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay3
        '
        Me.lblDay3.BackColor = System.Drawing.Color.White
        Me.lblDay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay3.Location = New System.Drawing.Point(280, 102)
        Me.lblDay3.Name = "lblDay3"
        Me.lblDay3.Size = New System.Drawing.Size(139, 25)
        Me.lblDay3.TabIndex = 62
        Me.lblDay3.Text = "Terça"
        Me.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay2
        '
        Me.lblDay2.BackColor = System.Drawing.Color.White
        Me.lblDay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay2.Location = New System.Drawing.Point(141, 102)
        Me.lblDay2.Name = "lblDay2"
        Me.lblDay2.Size = New System.Drawing.Size(139, 25)
        Me.lblDay2.TabIndex = 61
        Me.lblDay2.Text = "Segunda"
        Me.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay1
        '
        Me.lblDay1.BackColor = System.Drawing.Color.White
        Me.lblDay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay1.Location = New System.Drawing.Point(3, 102)
        Me.lblDay1.Name = "lblDay1"
        Me.lblDay1.Size = New System.Drawing.Size(138, 25)
        Me.lblDay1.TabIndex = 60
        Me.lblDay1.Text = "Domingo"
        Me.lblDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormTarefa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 851)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDay7)
        Me.Controls.Add(Me.lblDay6)
        Me.Controls.Add(Me.lblDay5)
        Me.Controls.Add(Me.lblDay4)
        Me.Controls.Add(Me.lblDay3)
        Me.Controls.Add(Me.lblDay2)
        Me.Controls.Add(Me.lblDay1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.listViewSabado)
        Me.Controls.Add(Me.listViewSexta)
        Me.Controls.Add(Me.listViewQuinta)
        Me.Controls.Add(Me.listViewQuarta)
        Me.Controls.Add(Me.listViewTerca)
        Me.Controls.Add(Me.listViewSegunda)
        Me.Controls.Add(Me.listViewDomingo)
        Me.Controls.Add(Me.btnAddTarefa)
        Me.Controls.Add(Me.cbFiltroEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbFiltroCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIrSemanaAtual)
        Me.Controls.Add(Me.btnAvancarSemana)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.btnVoltarSemana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTarefa"
        Me.Text = "FormTarefa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFiltroCategoria As ComboBox
    Friend WithEvents cbFiltroEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddTarefa As Button
    Friend WithEvents listViewSabado As ListView
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents listViewSexta As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents listViewQuinta As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents listViewQuarta As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents listViewTerca As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents listViewSegunda As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents listViewDomingo As ListView
    Friend WithEvents Descricao As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDay7 As Label
    Friend WithEvents lblDay6 As Label
    Friend WithEvents lblDay5 As Label
    Friend WithEvents lblDay4 As Label
    Friend WithEvents lblDay3 As Label
    Friend WithEvents lblDay2 As Label
    Friend WithEvents lblDay1 As Label
End Class
