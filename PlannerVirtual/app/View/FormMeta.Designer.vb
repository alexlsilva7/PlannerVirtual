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
        Me.listViewMetas = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'listViewMetas
        '
        Me.listViewMetas.HideSelection = False
        Me.listViewMetas.Location = New System.Drawing.Point(12, 12)
        Me.listViewMetas.Name = "listViewMetas"
        Me.listViewMetas.Size = New System.Drawing.Size(192, 278)
        Me.listViewMetas.TabIndex = 0
        Me.listViewMetas.UseCompatibleStateImageBehavior = False
        '
        'FormMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.listViewMetas)
        Me.Name = "FormMeta"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listViewMetas As ListView
End Class
