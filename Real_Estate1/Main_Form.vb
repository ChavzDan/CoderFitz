Imports Microsoft.Azure.Amqp.Framing

Public Class Main_Form

    Dim ownersf As New OwnersForm()
    Dim propertyF As New PropertyForm()
    Dim property_type As New PropertyTypeForm()
    Dim clientsF As New ClientsForm()
    Dim propImagesF As New PropertyImages_Form()
    Dim salesF As New Sales_Form()
    Public PropertiesListF As New PropertiesList_Form()
    Public mapF

    Public Sub ShowForm(formToShow As Form)
        ownersf.Hide()
        propertyF.Hide()
        property_type.Hide()
        propImagesF.Hide()
        salesF.Hide()
        clientsF.Hide()
        PropertiesListF.Hide()

        Try
            mapF.Hide()
        Catch ex As Exception
            Return
        Finally
            formToShow.TopLevel = False
            Me.SplitContainer1.Panel2.Controls.Add(formToShow)
            formToShow.Anchor = AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Top
            formToShow.Dock = DockStyle.Fill

            formToShow.Show()
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowForm(clientsF)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ShowForm(property_type)
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_Menu.Location = New Point(ClientSize.Width / 3 - ClientSize.Width / 4)
    End Sub

    Private Sub Button_Owner_Click(sender As Object, e As EventArgs) Handles Button_Owner.Click
        ShowForm(ownersf)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowForm(propertyF)
    End Sub

    Private Sub ButtonIMAGES_Click(sender As Object, e As EventArgs) Handles ButtonIMAGES.Click
        ShowForm(propImagesF)
    End Sub

    Private Sub SALES_Click(sender As Object, e As EventArgs) Handles SALES.Click
        ShowForm(salesF)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        ' Create a list to hold forms to close
        Dim formsToClose As New List(Of Form)

        ' Add all open forms to the list
        For Each form As Form In Application.OpenForms
            If form IsNot Me Then
                formsToClose.Add(form)
            End If
        Next

        ' Close each form from the list
        For Each form In formsToClose
            form.Close()
        Next

        ' Show the login form
        Dim loginForm As New Login_Form ' Replace LoginForm with the actual name of your login form
        loginForm.Show()

        ' Optionally close the current form
        Close()
    End Sub

End Class


