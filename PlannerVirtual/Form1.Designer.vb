<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnTelaCategorias = New System.Windows.Forms.Button()
        Me.btnSelecionarCategoriaDialog = New System.Windows.Forms.Button()
        Me.btnTelaLembretes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTelaCategorias
        '
        Me.btnTelaCategorias.Location = New System.Drawing.Point(12, 12)
        Me.btnTelaCategorias.Name = "btnTelaCategorias"
        Me.btnTelaCategorias.Size = New System.Drawing.Size(105, 85)
        Me.btnTelaCategorias.TabIndex = 0
        Me.btnTelaCategorias.Text = "Tela de Categorias"
        Me.btnTelaCategorias.UseVisualStyleBackColor = True
        '
        'btnSelecionarCategoriaDialog
        '
        Me.btnSelecionarCategoriaDialog.Location = New System.Drawing.Point(12, 103)
        Me.btnSelecionarCategoriaDialog.Name = "btnSelecionarCategoriaDialog"
        Me.btnSelecionarCategoriaDialog.Size = New System.Drawing.Size(105, 38)
        Me.btnSelecionarCategoriaDialog.TabIndex = 1
        Me.btnSelecionarCategoriaDialog.Text = "Selecionar Categoria Dialog"
        Me.btnSelecionarCategoriaDialog.UseVisualStyleBackColor = True
        '
        'btnTelaLembretes
        '
        Me.btnTelaLembretes.Location = New System.Drawing.Point(137, 12)
        Me.btnTelaLembretes.Name = "btnTelaLembretes"
        Me.btnTelaLembretes.Size = New System.Drawing.Size(105, 85)
        Me.btnTelaLembretes.TabIndex = 2
        Me.btnTelaLembretes.Text = "Tela de Lembretes"
        Me.btnTelaLembretes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTelaLembretes)
        Me.Controls.Add(Me.btnSelecionarCategoriaDialog)
        Me.Controls.Add(Me.btnTelaCategorias)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTelaCategorias As Button
    Friend WithEvents btnSelecionarCategoriaDialog As Button
    Friend WithEvents btnTelaLembretes As Button
End Class
