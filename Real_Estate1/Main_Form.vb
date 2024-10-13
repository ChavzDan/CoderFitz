﻿Public Class Main_Form

    Dim ownersf As New OwnersForm()
    Dim propertyF As New PropertyForm()
    Dim property_type As New PropertyTypeForm()
    Dim clientsF As New ClientsForm()
    Dim propImagesF As New PropertyImages_Form()
    Dim salesF As New Sales_Form()

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Menu.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()

        clientsF.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()

        property_type.Show()
    End Sub



    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Center the panel in the form
        Panel_Menu.Location = New Point(ClientSize.Width / 3 - ClientSize.Width / 4)

        'Make the panel right/left full height
        PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        PanelRight.Location = New Point(ClientSize.Width - 5, 0)

        'Button close (upper right)
        'ButtonClose.Location = New Point(ClientSize.Width - (PanelRight.Width + ButtonClose.Width + 10), 10)

    End Sub

    Private Sub Panel_1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub Button_Owner_Click(sender As Object, e As EventArgs) Handles Button_Owner.Click
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()

        ownersf.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()

        propertyF.Show()
    End Sub

    Private Sub ButtonIMAGES_Click(sender As Object, e As EventArgs) Handles ButtonIMAGES.Click
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()

        propImagesF.Show()
    End Sub

    Private Sub SALES_Click(sender As Object, e As EventArgs) Handles SALES.Click
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()

        salesF.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Create a list to hold forms to close
        Dim formsToClose As New List(Of Form)

        ' Add all open forms to the list
        For Each form As Form In Application.OpenForms
            If form IsNot Me Then
                formsToClose.Add(form)
            End If
        Next

        ' Close each form from the list
        For Each form As Form In formsToClose
            form.Close()
        Next

        ' Show the login form
        Dim loginForm As New Login_Form() ' Replace LoginForm with the actual name of your login form
        loginForm.Show()

        ' Optionally close the current form
        Close()
    End Sub



End Class


