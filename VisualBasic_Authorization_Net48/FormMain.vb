Imports DontPanic.TumblrSharp.OAuth

Public Class FormMain

    Dim oAuthClient As OAuthClient

    Dim requestToken As Token

    Dim accessToken As Token


    Private Sub Button1_ClickAsync(sender As Object, e As EventArgs) Handles Button1.Click

        Authorization()

    End Sub

    Private Async Sub Authorization()

        oAuthClient = New OAuthClientFactory().Create(TBConsumerKey.Text, TBConsumerSecret.Text)

        requestToken = Await oAuthClient.GetRequestTokenAsync("https://github.com/piedoom/TumblrSharp")

        Dim url As Uri = oAuthClient.GetAuthorizeUrl(requestToken)

        Dim frWebView As New FormWebView(url, "https://github.com/piedoom/TumblrSharp")

        frWebView.ShowDialog()

        Dim verifierUrl As Uri = frWebView.Result

        accessToken = Await oAuthClient.GetAccessTokenAsync(requestToken, verifierUrl.OriginalString)

        BtnViewPicture.Enabled = True

    End Sub

    Private Sub BtnViewPicture_Click(sender As Object, e As EventArgs) Handles BtnViewPicture.Click
        Dim dlg = New FormViewPicture(TBConsumerKey.Text, TBConsumerSecret.Text, accessToken)
        dlg.ShowDialog()
    End Sub
End Class
