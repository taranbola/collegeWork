Public Class frmAgain
    Public score As Integer
    Private Sub cmdAgainBack_Click(sender As Object, e As EventArgs) Handles cmdAgainBack.Click
        Me.Hide() 'Hides the again page'
        frmQuestion2.Show() 'Goes back to the Question 2 page'
    End Sub

    Private Sub cmdExit2_Click(sender As Object, e As EventArgs) Handles cmdExit2.Click
        End 'Ends the program'
    End Sub

    Private Sub cmdPlayAgain_Click(sender As Object, e As EventArgs) Handles cmdPlayAgain.Click
        score = 0 'Makes the score 0, when it reset' 
        Me.Hide() ' hides the again page'
        frmMenu.Show() 'Goes to the menu'
    End Sub
End Class