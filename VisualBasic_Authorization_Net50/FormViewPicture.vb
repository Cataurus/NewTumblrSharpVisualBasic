Imports System.Net.Http
Imports DontPanic.TumblrSharp
Imports DontPanic.TumblrSharp.Client
Imports DontPanic.TumblrSharp.OAuth

Public Class FormViewPicture

    Private tumblrClient As TumblrClient

    Private httpClient As HttpClient

    Private sinceId As Long

    Private Async Sub GetPictureAsync()

        Dim userInfo = Await tumblrClient.GetUserInfoAsync()

        Dim blogName = userInfo.Blogs.FirstOrDefault().Name

        Dim Posts = Await tumblrClient.GetDashboardPostsAsync(sinceId, DashboardOption.Before, 0, 20, PostType.Photo)

        For Each post As BasePost In Posts

            Dim photoPost As PhotoPost = post

            For Each photo As Photo In photoPost.PhotoSet

                Dim imageUrl As String = photo.OriginalSize.ImageUrl

                Dim request = Await httpClient.GetAsync(imageUrl)

                If request.StatusCode = Net.HttpStatusCode.OK Then

                    Dim imageStream = Await request.Content.ReadAsStreamAsync()

                    Dim pb = New PictureBox()

                    pb.Height = 150
                    pb.Width = 150

                    pb.Image = (New Bitmap(imageStream)).GetThumbnailImage(150, 150, Nothing, Nothing)

                    PanelPicture.Controls.Add(pb)

                End If

            Next

        Next

        sinceId = Posts.Last().Id
    End Sub

    Public Sub New(consumerSecret As String, consumerKey As String, accessToken As Token)

        InitializeComponent()

        tumblrClient = New TumblrClientFactory().Create(Of TumblrClient)(consumerSecret, consumerKey, accessToken)

        httpClient = New HttpClient()

    End Sub

    Private Sub FormViewPicture_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        sinceId = 0

        GetPictureAsync()

    End Sub

    Private Sub FormViewPicture_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        httpClient.Dispose()

        tumblrClient.Dispose()

    End Sub

    Private Sub PanelPicture_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelPicture.Scroll

        GetPictureAsync()

    End Sub

    Private Sub PanelPicture_MouseWhell(sender As Object, e As MouseEventArgs) Handles PanelPicture.MouseWheel

        GetPictureAsync()

    End Sub

End Class