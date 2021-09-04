Imports System.Net.Http
Imports DontPanic.TumblrSharp
Imports DontPanic.TumblrSharp.Client
Imports DontPanic.TumblrSharp.OAuth

Public Class FormViewPicture

    Dim tumblrClient As TumblrClient

    Dim httpClient As HttpClient

    Private runGetPicture As Boolean

    Public Sub New(consumerSecret As String, consumerKey As String, accessToken As Token)

        InitializeComponent()

        tumblrClient = New TumblrClientFactory().Create(Of TumblrClient)(consumerSecret, consumerKey, accessToken)

        httpClient = New HttpClient()

        runGetPicture = False

    End Sub

    Private Sub FormViewPicture_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        sinceId = 0

        GetPictureAsync()

    End Sub

    Private sinceId As Long

    Private Async Sub GetPictureAsync()

        If runGetPicture = False Then

            runGetPicture = True

            Dim userInfo = Await tumblrClient.GetUserInfoAsync()

            Dim blogName = userInfo.Blogs.FirstOrDefault().Name

            Dim posts = Await tumblrClient.GetDashboardPostsAsync(sinceId, DashboardOption.Before, 0, 20, PostType.Photo)

            For Each post As BasePost In posts

                If post.Type = PostType.Photo Then

                    Dim photoPost As PhotoPost = post

                    For Each photo As Photo In photoPost.PhotoSet

                        Dim imageUrl As String = photo.OriginalSize.ImageUrl

                        Dim request = Await httpClient.GetAsync(imageUrl)

                        If request.StatusCode = Net.HttpStatusCode.OK Then

                            Dim imageStream = Await request.Content.ReadAsStreamAsync()

                            Dim pb = New PictureBox()

                            pb.Height = 150
                            pb.Width = 150

                            pb.Image = New Bitmap(imageStream).GetThumbnailImage(150, 150, Nothing, Nothing)

                            PanelPicture.Controls.Add(pb)

                        End If

                    Next

                End If

            Next

            sinceId = posts.Last().Id

            runGetPicture = False

        End If

    End Sub

    Private Sub PanelPicture_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelPicture.Scroll

        GetPictureAsync()

    End Sub

    Private Sub PanelPicture_MouseWhell(sender As Object, e As MouseEventArgs) Handles PanelPicture.MouseWheel

        If runGetPicture = False Then
            GetPictureAsync()
        End If

    End Sub

    Private Sub FormViewPicture_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        httpClient.Dispose()

        tumblrClient.Dispose()

    End Sub

    Private Sub FormViewPicture_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If runGetPicture Then
            e.Cancel = True
        End If

    End Sub
End Class