<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.lblHelpinfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHelp
        '
        resources.ApplyResources(Me.lblHelp, "lblHelp")
        Me.lblHelp.Name = "lblHelp"
        '
        'cmdBack
        '
        Me.cmdBack.FlatAppearance.BorderSize = 4
        resources.ApplyResources(Me.cmdBack, "cmdBack")
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'lblHelpinfo
        '
        resources.ApplyResources(Me.lblHelpinfo, "lblHelpinfo")
        Me.lblHelpinfo.Name = "lblHelpinfo"
        '
        'frmHelp
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHelpinfo)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.lblHelp)
        Me.Name = "frmHelp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHelp As Label
    Friend WithEvents cmdBack As Button
    Friend WithEvents lblHelpinfo As Label
End Class
