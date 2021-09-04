Imports Microsoft.Web.WebView2.Core

Public Class FormWebView

    Dim callbackUrl As String

    Public Sub New(url As Uri, callbackUrl As String)
        InitializeComponent()

        Init()

        Me.Url = url
        Me.callbackUrl = callbackUrl


        WebView21.Source = url
    End Sub

    Public Property Result As Uri

    Public ReadOnly Property Url As Uri

    Private Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted

        Dim url As Uri = WebView21.Source

        If url.OriginalString.StartsWith(callbackUrl) Then
            Result = url
            Close()
        End If

    End Sub

    Private Async Sub Init()
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Sub

End Class