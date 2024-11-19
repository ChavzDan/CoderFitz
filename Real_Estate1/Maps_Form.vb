
Imports System.Net
Public Class Maps_Form

    Private _url As String

    ' Constructor that accepts a URL
    Public Sub New(Optional address As String = "")
        InitializeComponent()
        _url = FormatAddressToUrl(address) ' Format the address to a URL
    End Sub

    ' Method to format the address into a URL
    Private Function FormatAddressToUrl(address As String) As String
        Return "https://www.google.com/maps/search/?api=1&query=" & Uri.EscapeDataString(address)
    End Function

    Private Sub frmWebView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWebPage()
    End Sub

    ' Method to load the web page
    Private Sub LoadWebPage()
        Try
            WebView21.Source = New Uri(_url)
        Catch ex As UriFormatException
            MessageBox.Show("The URL must be fully styled, such as the prefix. http[s]://")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

End Class