Public Class frmMenu
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End 'Exits the app'
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        frmHelp.Show() 'Help page is shown '
        Me.Hide() 'Hide the menu page'
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        frmQuestion.Show() 'Shows the question page'
        Me.Hide() 'Hides the menu page'
    End Sub
End Class
