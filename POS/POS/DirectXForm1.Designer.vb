<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirectXForm1
    Inherits DevExpress.XtraEditors.DirectXForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DirectXFormContainerControl1 = New DevExpress.XtraEditors.DirectXFormContainerControl()
        Me.SuspendLayout()
        '
        'DirectXFormContainerControl1
        '
        Me.DirectXFormContainerControl1.Location = New System.Drawing.Point(1, 31)
        Me.DirectXFormContainerControl1.Name = "DirectXFormContainerControl1"
        Me.DirectXFormContainerControl1.Size = New System.Drawing.Size(630, 246)
        Me.DirectXFormContainerControl1.TabIndex = 0
        ' 
        ' $MainFormClassName$
        ' 
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New Size(632, 278)
        Me.Controls.Add(Me.DirectXFormContainerControl1)
        Me.Text = "DirectXForm1"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents DirectXFormContainerControl1 As DevExpress.XtraEditors.DirectXFormContainerControl

End Class
