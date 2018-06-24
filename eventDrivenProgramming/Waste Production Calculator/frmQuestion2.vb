Public Class frmQuestion2
    Public score As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdQuestionBack2.Click
        Me.Hide()           'Hides the question 2 page'
        frmQuestion.Show()  'Shows the question page'

    End Sub

    Private Sub lblQ6_Click(sender As Object, e As EventArgs) Handles lblQ6.Click

    End Sub

    Private Sub cmdSubmit2_Click(sender As Object, e As EventArgs) Handles cmdSubmit2.Click
        '-----------------------------------------'
        score = 0                       'score resets to 0'
        If txtQ6.Text <= 6 Then         'if number inputted is less than 6 then '
            score = score + 1               'add 1 to the score'
        ElseIf txtQ6.Text < 15 Then     'if number inputted is less than 15 then '
            score = score + 2               'add 2 to the score'
        Else                            'if number inputted is more than 15 then '
            score = score + 3               'add 3 to the score'
        End If
        '-----------------------------------------'
        If txtQ7.Text <= 10 Then        'if number inputted is less than 10 then '
            score = score + 1               'add 1 to the score'
        ElseIf txtQ7.Text < 20 Then     'if number inputted is less than 20 then '
            score = score + 2               'add 2 to the score'
        Else                            'if number inputted is more than 20 then '
            score = score + 3               'add 3 to the score'
        End If
        '-----------------------------------------'
        If txtQ8.Text <= 20 Then        'if number inputted is less than 20 then '
            score = score + 1               'add 1 to the score'
        ElseIf txtQ8.Text < 40 Then     'if number inputted is less than 40 then '
            score = score + 2               'add 2 to the score'
        Else                            'if number inputted is more than 40 then '
            score = score + 3               'add 3 to the score'
        End If
        '-----------------------------------------'
        If txtQ9.Text <= 5 Then         'if number inputted is less than 5 then '
            score = score + 1               'add 1 to the score'
        ElseIf txtQ9.Text < 10 Then     'if number inputted is less than 10 then '
            score = score + 2               'add 2 to the score'
        Else                            'if number inputted is mpre than 10 then '
            score = score + 3               'add 3 to the score'
        End If
        '-----------------------------------------'
        If txtQ10.Text <= 6 Then        'if number inputted is less than 6 then '
            score = score + 1               'add 1 to the score'
        ElseIf txtQ10.Text < 10 Then    'if number inputted is less than 10 then '
            score = score + 2               'add 2 to the score'
        Else                            'if number inputted is more than 10 then '
            score = score + 3               'add 3 to the score'
        End If
        '-----------------------------------------'
        If score <= 5 Then          'in the end if their overall score is less than 5 then '
            MsgBox("You need to make sure that you keep cutting your waste. Your waste score is " & score) '<-Message'
        ElseIf score <= 10 Then     'in the end if their overall score is less than 10 then '
            MsgBox("You need to be cutting your waste. Your waste score is " & score) '<-Message'
        Else                        'in the end if their overall score is more than 10 then '
            MsgBox("You need to cut your waste a lot more. Your waste score is " & score) '<-Message'
        End If
        Me.Hide()                   'hide question page 2'
        frmAgain.Show()             'Show the again page'
    End Sub

    Private Sub txtQ6_TextChanged(sender As Object, e As EventArgs) Handles txtQ6.TextChanged
        If IsNumeric(txtQ6.Text) = False Or txtQ6.Text = "" Then    'if textQ6 is a letter or blank then '
            txtQ6.Text = 0                   'Make the number automatically 0'
            txtQ6.BackColor = Color.Red      ' Background colour is red'
            txtQ6.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ6.BackColor = Color.White   'Background colour is changed back to white'
            txtQ6.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub txtQ7_TextChanged(sender As Object, e As EventArgs) Handles txtQ7.TextChanged
        If IsNumeric(txtQ7.Text) = False Or txtQ7.Text = "" Then    'if textQ7 is a letter or blank then '
            txtQ7.Text = 0                  'Make the number automatically 0'
            txtQ7.BackColor = Color.Red     ' Background colour is red'
            txtQ7.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ7.BackColor = Color.White   'Background colour is changed back to white'
            txtQ7.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub txtQ8_TextChanged(sender As Object, e As EventArgs) Handles txtQ8.TextChanged
        If IsNumeric(txtQ8.Text) = False Or txtQ8.Text = "" Then    'if textQ8 is a letter or blank then '
            txtQ8.Text = 0                  'Make the number automatically 0
            txtQ8.BackColor = Color.Red     ' Background colour is red'
            txtQ8.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ8.BackColor = Color.White   'Background colour is changed back to white'
            txtQ8.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub txtQ9_TextChanged(sender As Object, e As EventArgs) Handles txtQ9.TextChanged
        If IsNumeric(txtQ9.Text) = False Or txtQ9.Text = "" Then    'if textQ9 is a letter or blank then '
            txtQ9.Text = 0                  'Make the number automatically 0
            txtQ9.BackColor = Color.Red     ' Background colour is red'
            txtQ9.ForeColor = Color.White   'Font colour is white'
        Else
            txtQ9.BackColor = Color.White   'Background colour is changed back to white'
            txtQ9.ForeColor = Color.Black   'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub txtQ10_TextChanged(sender As Object, e As EventArgs) Handles txtQ10.TextChanged
        If IsNumeric(txtQ10.Text) = False Or txtQ10.Text = "" Then  'if textQ10 is a letter or blank then '
            txtQ10.Text = 0                 'Make the number automatically 0
            txtQ10.BackColor = Color.Red    ' Background colour is red'
            txtQ10.ForeColor = Color.White  'Font colour is white'
        Else
            txtQ10.BackColor = Color.White  'Background colour is changed back to white'
            txtQ10.ForeColor = Color.Black  'Font colour is changed is changed back to bLack'
        End If
    End Sub

    Private Sub lblQ10_Click(sender As Object, e As EventArgs) Handles lblQ10.Click

    End Sub
End Class