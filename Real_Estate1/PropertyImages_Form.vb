Public Class PropertyImages_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub PropertyImages_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Center the panel in the form
        ' Panel_Menu.Location = New Point(ClientSize.Width / 3 - ClientSize.Width / 4)
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 1.5, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        'Make the panel right/left full height
        '  PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        ' PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        ' PanelRight.Location = New Point(ClientSize.Width - 5, 0)

        'Button close (upper right)
        ' ButtonClose.Location = New Point(ClientSize.Width - (PanelRight.Width + ButtonClose.Width + 10), 10)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button_ShowProperty_Click(sender As Object, e As EventArgs) Handles Button_ShowProperty.Click

    End Sub

    Private Sub Panel_Menu_Paint(sender As Object, e As PaintEventArgs)
        Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 1.5, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2)

    End Sub

    Private Sub Button_SelectImage_Click(sender As Object, e As EventArgs) Handles Button_SelectImage.Click

    End Sub
End Class