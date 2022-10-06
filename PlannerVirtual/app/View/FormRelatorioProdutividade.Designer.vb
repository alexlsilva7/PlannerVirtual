<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRelatorioProdutividade
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartTurnos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnIrSemanaAtual = New System.Windows.Forms.Button()
        Me.cbIntervaloTempo = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.btnAvancarSemana = New System.Windows.Forms.Button()
        Me.btnVoltarSemana = New System.Windows.Forms.Button()
        Me.ChartSemanas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ChartTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ChartSemanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartTurnos
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartTurnos.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Turnos"
        Me.ChartTurnos.Legends.Add(Legend1)
        Me.ChartTurnos.Location = New System.Drawing.Point(12, 138)
        Me.ChartTurnos.Name = "ChartTurnos"
        Me.ChartTurnos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ChartTurnos.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(235, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Turnos"
        Series1.Name = "Turnos"
        Series1.YValuesPerPoint = 4
        Me.ChartTurnos.Series.Add(Series1)
        Me.ChartTurnos.Size = New System.Drawing.Size(300, 300)
        Me.ChartTurnos.TabIndex = 0
        Me.ChartTurnos.Text = "Chart1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(876, 100)
        Me.Panel3.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Location = New System.Drawing.Point(360, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(150, 100)
        Me.Panel6.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnIrSemanaAtual)
        Me.Panel5.Controls.Add(Me.cbIntervaloTempo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(150, 49)
        Me.Panel5.TabIndex = 27
        '
        'btnIrSemanaAtual
        '
        Me.btnIrSemanaAtual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnIrSemanaAtual.Location = New System.Drawing.Point(0, 27)
        Me.btnIrSemanaAtual.Name = "btnIrSemanaAtual"
        Me.btnIrSemanaAtual.Size = New System.Drawing.Size(150, 22)
        Me.btnIrSemanaAtual.TabIndex = 25
        Me.btnIrSemanaAtual.Text = "Atual"
        Me.btnIrSemanaAtual.UseVisualStyleBackColor = True
        '
        'cbIntervaloTempo
        '
        Me.cbIntervaloTempo.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbIntervaloTempo.FormattingEnabled = True
        Me.cbIntervaloTempo.Items.AddRange(New Object() {"Semana", "Mês", "Ano"})
        Me.cbIntervaloTempo.Location = New System.Drawing.Point(0, 0)
        Me.cbIntervaloTempo.Name = "cbIntervaloTempo"
        Me.cbIntervaloTempo.Size = New System.Drawing.Size(150, 21)
        Me.cbIntervaloTempo.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblSemana)
        Me.Panel4.Controls.Add(Me.btnAvancarSemana)
        Me.Panel4.Controls.Add(Me.btnVoltarSemana)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 49)
        Me.Panel4.TabIndex = 26
        '
        'lblSemana
        '
        Me.lblSemana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSemana.Location = New System.Drawing.Point(35, 0)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(80, 49)
        Me.lblSemana.TabIndex = 23
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAvancarSemana
        '
        Me.btnAvancarSemana.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAvancarSemana.Location = New System.Drawing.Point(115, 0)
        Me.btnAvancarSemana.Name = "btnAvancarSemana"
        Me.btnAvancarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnAvancarSemana.TabIndex = 24
        Me.btnAvancarSemana.Text = ">"
        Me.btnAvancarSemana.UseVisualStyleBackColor = True
        '
        'btnVoltarSemana
        '
        Me.btnVoltarSemana.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVoltarSemana.Location = New System.Drawing.Point(0, 0)
        Me.btnVoltarSemana.Name = "btnVoltarSemana"
        Me.btnVoltarSemana.Size = New System.Drawing.Size(35, 49)
        Me.btnVoltarSemana.TabIndex = 21
        Me.btnVoltarSemana.Text = "<"
        Me.btnVoltarSemana.UseVisualStyleBackColor = True
        '
        'ChartSemanas
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartSemanas.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartSemanas.Legends.Add(Legend2)
        Me.ChartSemanas.Location = New System.Drawing.Point(360, 138)
        Me.ChartSemanas.Name = "ChartSemanas"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.Legend = "Legend1"
        Series2.Name = "Semanas"
        Me.ChartSemanas.Series.Add(Series2)
        Me.ChartSemanas.Size = New System.Drawing.Size(459, 327)
        Me.ChartSemanas.TabIndex = 28
        Me.ChartSemanas.Text = "Chart1"
        '
        'FormRelatorioProdutividade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 492)
        Me.Controls.Add(Me.ChartSemanas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ChartTurnos)
        Me.Name = "FormRelatorioProdutividade"
        Me.Text = "FormRelatorioProdutividade"
        CType(Me.ChartTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.ChartSemanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartTurnos As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnIrSemanaAtual As Button
    Friend WithEvents cbIntervaloTempo As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSemana As Label
    Friend WithEvents btnAvancarSemana As Button
    Friend WithEvents btnVoltarSemana As Button
    Friend WithEvents ChartSemanas As DataVisualization.Charting.Chart
End Class
