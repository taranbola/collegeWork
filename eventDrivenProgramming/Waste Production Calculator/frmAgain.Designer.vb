<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgain))
        Me.lblAgain = New System.Windows.Forms.Label()
        Me.cmdAgainBack = New System.Windows.Forms.Button()
        Me.cmdExit2 = New System.Windows.Forms.Button()
        Me.cmdPlayAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAgain
        '
        Me.lblAgain.AutoSize = True
        Me.lblAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblAgain.Location = New System.Drawing.Point(394, 35)
        Me.lblAgain.Name = "lblAgain"
        Me.lblAgain.Size = New System.Drawing.Size(378, 46)
        Me.lblAgain.TabIndex = 0
        Me.lblAgain.Text = "Play Again or Exit?"
        '
        'cmdAgainBack
        '
        Me.cmdAgainBack.FlatAppearance.BorderSize = 4
        Me.cmdAgainBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgainBack.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.cmdAgainBack.Location = New System.Drawing.Point(74, 35)
        Me.cmdAgainBack.Name = "cmdAgainBack"
        Me.cmdAgainBack.Size = New System.Drawing.Size(214, 101)
        Me.cmdAgainBack.TabIndex = 1
        Me.cmdAgainBack.Text = "Back"
        Me.cmdAgainBack.UseVisualStyleBackColor = True
        '
        'cmdExit2
        '
        Me.cmdExit2.FlatAppearance.BorderSize = 4
        Me.cmdExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit2.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.cmdExit2.Location = New System.Drawing.Point(591, 383)
        Me.cmdExit2.Name = "cmdExit2"
        Me.cmdExit2.Size = New System.Drawing.Size(275, 124)
        Me.cmdExit2.TabIndex = 2
        Me.cmdExit2.Text = "EXIT"
        Me.cmdExit2.UseVisualStyleBackColor = True
        '
        'cmdPlayAgain
        '
        Me.cmdPlayAgain.FlatAppearance.BorderSize = 4
        Me.cmdPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPlayAgain.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.cmdPlayAgain.Location = New System.Drawing.Point(120, 383)
        Me.cmdPlayAgain.Name = "cmdPlayAgain"
        Me.cmdPlayAgain.Size = New System.Drawing.Size(275, 124)
        Me.cmdPlayAgain.TabIndex = 3
        Me.cmdPlayAgain.Text = "PLAY AGAIN"
        Me.cmdPlayAgain.UseVisualStyleBackColor = True
        '
        'frmAgain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 733)
        Me.Controls.Add(Me.cmdPlayAgain)
        Me.Controls.Add(Me.cmdExit2)
        Me.Controls.Add(Me.cmdAgainBack)
        Me.Controls.Add(Me.lblAgain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Play Again"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAgain As System.Windows.Forms.Label
    Friend WithEvents cmdAgainBack As System.Windows.Forms.Button
    Friend WithEvents cmdExit2 As System.Windows.Forms.Button
    Friend WithEvents cmdPlayAgain As System.Windows.Forms.Button
End Class
