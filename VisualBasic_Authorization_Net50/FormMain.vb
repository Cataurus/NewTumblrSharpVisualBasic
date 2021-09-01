Imports DontPanic.TumblrSharp.OAuth

Public Class FormMain

    Dim oAuthClient As OAuthClient

    Dim requestToken As Token

    Dim accessToken As Token

    Private Sub BtnAuthorization_Click(sender As Object, e As EventArgs) Handles BtnAuthorization.Click

        Authorization()

    End Sub

    Private Async Sub Authorization()

        oAuthClient = New OAuthClientFactory().Create(TbConsumerKey.Text, TbConsumerSecret.Text)

        requestToken = Await oAuthClient.GetRequestTokenAsync("https://github.com/piedoom/TumblrSharp")

        Dim url As Uri = oAuthClient.GetAuthorizeUrl(requestToken)

        Dim frWebView As New FormWebView(url, "https://github.com/piedoom/TumblrSharp")

        frWebView.ShowDialog()

        Dim verifierUrl As Uri = frWebView.Result

        accessToken = Await oAuthClient.GetAccessTokenAsync(requestToken, verifierUrl.OriginalString)

        BtnViewDrashboard.Enabled = True

    End Sub

    Private Sub BtnViewDrashboard_Click(sender As Object, e As EventArgs) Handles BtnViewDrashboard.Click

        Dim dlg = New FormViewPicture(TbConsumerKey.Text, TbConsumerSecret.Text, accessToken)

        dlg.ShowDialog()

    End Sub
End Class
