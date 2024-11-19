Public Class Sales_Form
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Sales_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 1.5, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close
    End Sub
End Class