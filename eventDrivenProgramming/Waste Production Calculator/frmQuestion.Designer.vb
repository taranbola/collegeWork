<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion))
        Me.lblQuestions = New System.Windows.Forms.Label()
        Me.cmdQuestionback = New System.Windows.Forms.Button()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.lblQ3 = New System.Windows.Forms.Label()
        Me.lblQ4 = New System.Windows.Forms.Label()
        Me.lblQ5 = New System.Windows.Forms.Label()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.txtQ1 = New System.Windows.Forms.TextBox()
        Me.txtQ2 = New System.Windows.Forms.TextBox()
        Me.txtQ3 = New System.Windows.Forms.TextBox()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.txtQ5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQuestions
        '
        Me.lblQuestions.AutoSize = True
        Me.lblQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestions.Location = New System.Drawing.Point(394, 35)
        Me.lblQuestions.Name = "lblQuestions"
        Me.lblQuestions.Size = New System.Drawing.Size(339, 46)
        Me.lblQuestions.TabIndex = 0
        Me.lblQuestions.Text = "Questions 1 to 5 "
        '
        'cmdQuestionback
        '
        Me.cmdQuestionback.FlatAppearance.BorderSize = 4
        Me.cmdQuestionback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuestionback.Font = New System.Drawing.Font("OCR A Extended", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuestionback.Location = New System.Drawing.Point(74, 35)
        Me.cmdQuestionback.Name = "cmdQuestionback"
        Me.cmdQuestionback.Size = New System.Drawing.Size(214, 101)
        Me.cmdQuestionback.TabIndex = 1
        Me.cmdQuestionback.Text = "Back"
        Me.cmdQuestionback.UseVisualStyleBackColor = True
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQ1.Font = New System.Drawing.Font("OCR A Extended", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblQ1.Location = New System.Drawing.Point(12, 175)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(719, 64)
        Me.lblQ1.TabIndex = 2
        Me.lblQ1.Text = "How many plastic bottles do you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "buy a week?"
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("OCR A Extended", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblQ2.Location = New System.Drawing.Point(12, 274)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(741, 64)
        Me.lblQ2.TabIndex = 3
        Me.lblQ2.Text = "How many times a week do you buy " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "something with packaging?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblQ3
        '
        Me.lblQ3.AutoSize = True
        Me.lblQ3.Font = New System.Drawing.Font("OCR A Extended", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblQ3.Location = New System.Drawing.Point(12, 377)
        Me.lblQ3.Name = "lblQ3"
        Me.lblQ3.Size = New System.Drawing.Size(763, 64)
        Me.lblQ3.TabIndex = 4
        Me.lblQ3.Text = "How many times a week do you waste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "food?"
        '
        'lblQ4
        '
        Me.lblQ4.AutoSize = True
        Me.lblQ4.Font = New System.Drawing.Font("OCR A Extended", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblQ4.Location = New System.Drawing.Point(12, 468)
        Me.lblQ4.Name = "lblQ4"
        Me.lblQ4.Size = New System.Drawing.Size(719, 64)
        Me.lblQ4.TabIndex = 5
        Me.lblQ4.Text = "How many times a week do you get" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "takeaway?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblQ5
        '
        Me.lblQ5.AutoSize = True
        Me.lblQ5.Font = New System.Drawing.Font("OCR A Extended", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblQ5.Location = New System.Drawing.Point(14, 574)
        Me.lblQ5.Name = "lblQ5"
        Me.lblQ5.Size = New System.Drawing.Size(741, 64)
        Me.lblQ5.TabIndex = 6
        Me.lblQ5.Text = "How many times a week do you have" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "microwave/ready meals?"
        '
        'cmdSubmit
        '
        Me.cmdSubmit.FlatAppearance.BorderSize = 4
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSubmit.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.cmdSubmit.Location = New System.Drawing.Point(767, 660)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(214, 101)
        Me.cmdSubmit.TabIndex = 7
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'txtQ1
        '
        Me.txtQ1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtQ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQ1.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.txtQ1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtQ1.Location = New System.Drawing.Point(800, 175)
        Me.txtQ1.MaxLength = 5
        Me.txtQ1.Name = "txtQ1"
        Me.txtQ1.Size = New System.Drawing.Size(142, 49)
        Me.txtQ1.TabIndex = 8
        '
        'txtQ2
        '
        Me.txtQ2.BackColor = System.Drawing.SystemColors.Menu
        Me.txtQ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQ2.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.txtQ2.Location = New System.Drawing.Point(800, 274)
        Me.txtQ2.MaxLength = 5
        Me.txtQ2.Name = "txtQ2"
        Me.txtQ2.Size = New System.Drawing.Size(142, 49)
        Me.txtQ2.TabIndex = 9
        '
        'txtQ3
        '
        Me.txtQ3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtQ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQ3.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.txtQ3.Location = New System.Drawing.Point(800, 370)
        Me.txtQ3.MaxLength = 5
        Me.txtQ3.Name = "txtQ3"
        Me.txtQ3.Size = New System.Drawing.Size(142, 49)
        Me.txtQ3.TabIndex = 10
        '
        'txtQ4
        '
        Me.txtQ4.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtQ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQ4.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.txtQ4.Location = New System.Drawing.Point(800, 468)
        Me.txtQ4.MaxLength = 5
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.Size = New System.Drawing.Size(142, 49)
        Me.txtQ4.TabIndex = 11
        '
        'txtQ5
        '
        Me.txtQ5.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtQ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQ5.Font = New System.Drawing.Font("OCR A Extended", 30.0!)
        Me.txtQ5.Location = New System.Drawing.Point(800, 567)
        Me.txtQ5.MaxLength = 5
        Me.txtQ5.Name = "txtQ5"
        Me.txtQ5.Size = New System.Drawing.Size(142, 49)
        Me.txtQ5.TabIndex = 12
        '
        'frmQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 762)
        Me.Controls.Add(Me.txtQ5)
        Me.Controls.Add(Me.txtQ4)
        Me.Controls.Add(Me.txtQ3)
        Me.Controls.Add(Me.txtQ2)
        Me.Controls.Add(Me.txtQ1)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.lblQ5)
        Me.Controls.Add(Me.lblQ4)
        Me.Controls.Add(Me.lblQ3)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.lblQ1)
        Me.Controls.Add(Me.cmdQuestionback)
        Me.Controls.Add(Me.lblQuestions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Questions 1 - 5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestions As Label
    Friend WithEvents cmdQuestionback As Button
    Friend WithEvents lblQ1 As Label
    Friend WithEvents lblQ2 As Label
    Friend WithEvents lblQ3 As Label
    Friend WithEvents lblQ4 As Label
    Friend WithEvents lblQ5 As Label
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents txtQ1 As TextBox
    Friend WithEvents txtQ2 As TextBox
    Friend WithEvents txtQ3 As TextBox
    Friend WithEvents txtQ4 As TextBox
    Friend WithEvents txtQ5 As TextBox
End Class
