Public Class frmHelp
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHelp.Click

    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide() 'Hide the help page'
        frmMenu.Show() ' Open the menu page'
    End Sub

    Private Sub lblHelpinfo_Click(sender As Object, e As EventArgs) Handles lblHelpinfo.Click

    End Sub
End Class