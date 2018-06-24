Public Class frmQuestion
    Public score As Integer

    Private Sub cmdQuestionback_Click(sender As Object, e As EventArgs) Handles cmdQuestionback.Click
        frmMenu.Show() 'Shows the menu page'
        Me.Hide() 'Hides the question page'
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblQ2.Click

    End Sub

    Private Sub frmQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblQ4_Click(sender As Object, e As EventArgs) Handles lblQ4.Click

    End Sub

    Private Sub lblQ3_Click(sender As Object, e As EventArgs) Handles lblQ3.Click

    End Sub

    Private Sub txtQ1_TextChanged(sender As Object, e As EventArgs) Handles txtQ1.TextChanged
        If IsNumeric(txtQ1.Text) = False Or txtQ1.Text = "" Then 'If it's not a number OR the text is empty then it will'
            txtQ1.Text = 0 'Make the number automatically 0'
            txtQ1.BackColor = Color.Red ' Background colour is red'
            txtQ1.ForeColor = Color.White 'Font colour is white'
        Else
            txtQ1.BackColor = Color.White 'Background colour is changed back to white'
            txtQ1.ForeColor = Color.Black 'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        '-----------------------------------------'
        If txtQ1.Text <= 10 Then    'if number inputted is less than 10 then '
            score = score + 1           'add 1 to the score'
        ElseIf txtQ1.Text < 20 Then 'if number inputted is less than 20 then'
            score = score + 2           'add 2 to the score'
        Else                        'if number inputted is more than 20 then'
            score = score + 3           'add 3 to the score' 
        End If
        '-----------------------------------------'
        If txtQ2.Text <= 20 Then    'if number inputted is less than 20 then'
            score = score + 1           'add 1 to the score'
        ElseIf txtQ2.Text < 35 Then 'if number inputted is less than 35 then'
            score = score + 2           'add 2 to the score'
        Else                        'if number inputted is more than than 35 then'
            score = score + 3           'add 3 to the score'
        End If
        '-----------------------------------------'
        If txtQ3.Text <= 5 Then     'if number inputted is less than 5 then'
            score = score + 1           'add 1 to the score'
        ElseIf txtQ3.Text < 15 Then 'if number inputted is less than 15 then'
            score = score + 2           'add 2 to the score'
        Else                        'if number inputted is more than 15 then'
            score = score + 3           'add 3 to the score'
        End If
        '-----------------------------------------'
        If txtQ4.Text <= 1 Then     'if number inputted is less than 1 then'
            score = score + 1           'add 1 to the score'
        ElseIf txtQ4.Text < 2 Then  'if number inputted is less than 2 then'
            score = score + 2           'add 2 to the score'
        Else                        'if number inputted is more than 2 then'
            score = score + 3           'add 3 to the score'
        End If
        '-----------------------------------------'
        If txtQ5.Text <= 4 Then     'if number inputted is less than 4 then'
            score = score + 1           'add 1 to the score'
        ElseIf txtQ5.Text < 7 Then  'if number inputted is less than 7 then'
            score = score + 2           'add 2 to the score'
        Else                        'if number inputted is more than 7 then'
            score = score + 3           'add 3 to the score'
        End If
        '-----------------------------------------'
        Me.Hide()               'Closes the question page'
        frmQuestion2.Show()     'Opens question page 2'
    End Sub

    Private Sub lblQ1_Click(sender As Object, e As EventArgs) Handles lblQ1.Click

    End Sub

    Private Sub txtQ2_TextChanged(sender As Object, e As EventArgs) Handles txtQ2.TextChanged
        If IsNumeric(txtQ2.Text) = False Or txtQ2.Text = "" Then    'if textQ2 is a letter or blank then '
            txtQ2.Text = 0                  'Make the number automatically 0'
            txtQ2.BackColor = Color.Red     ' Background colour is red'
            txtQ2.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ2.BackColor = Color.White   'Background colour is changed back to white'
            txtQ2.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub txtQ3_TextChanged(sender As Object, e As EventArgs) Handles txtQ3.TextChanged
        If IsNumeric(txtQ3.Text) = False Or txtQ3.Text = "" Then    'if textQ3 is a letter or blank then '
            txtQ3.Text = 0                  'Make the number automatically 0'
            txtQ3.BackColor = Color.Red     ' Background colour is red'
            txtQ3.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ3.BackColor = Color.White   'Background colour is changed back to white'
            txtQ3.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub txtQ4_TextChanged(sender As Object, e As EventArgs) Handles txtQ4.TextChanged
        If IsNumeric(txtQ4.Text) = False Or txtQ4.Text = "" Then    'if textQ4 is a letter or blank then '
            txtQ4.Text = 0                  'Make the number automatically 0'
            txtQ4.BackColor = Color.Red     ' Background colour is red'
            txtQ4.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ4.BackColor = Color.White   'Background colour is changed back to white'
            txtQ4.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'

        End If
    End Sub

    Private Sub txtQ5_TextChanged(sender As Object, e As EventArgs) Handles txtQ5.TextChanged
        If IsNumeric(txtQ5.Text) = False Or txtQ5.Text = "" Then    'if textQ5 is a letter or blank then '
            txtQ5.Text = 0                  'Make the number automatically 0'
            txtQ5.BackColor = Color.Red     ' Background colour is red'
            txtQ5.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ5.BackColor = Color.White   'Background colour is changed back to white'
            txtQ5.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'
        End If
    End Sub
End Class