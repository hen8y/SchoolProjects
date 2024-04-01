Public Class photoAlbumForm
    Private photoFolder As String
    Private currentPhotoKey As Integer
    Private photos As List(Of String)

    Private Sub BrowseFolderButtonClick(sender As Object, e As EventArgs) Handles BrowseFolderButton.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            photoFolder = folderBrowserDialog.SelectedPath
            loadPhotos()
            DisplayCurrentPhoto()
        End If
    End Sub

    Private Sub NextButtonClick(sender As Object, e As EventArgs) Handles NextButton.Click
        currentPhotoKey += 1
        If currentPhotoKey >= photos.Count Then
            currentPhotoKey = 0
        End If
        DisplayCurrentPhoto()
    End Sub

    Private Sub PreviousButtonClick(sender As Object, e As EventArgs) Handles PreviousButton.Click
        currentPhotoKey -= 1
        If currentPhotoKey < 0 Then
            currentPhotoKey = photos.Count - 1 ' Wrap around to the last photo
        End If
        DisplayCurrentPhoto()
    End Sub

    Private Sub loadPhotos()
        photos = New List(Of String)()
        If Not String.IsNullOrEmpty(photoFolder) AndAlso IO.Directory.Exists(photoFolder) Then
            photos.AddRange(IO.Directory.GetFiles(photoFolder, "*.jpg"))
            photos.AddRange(IO.Directory.GetFiles(photoFolder, "*.png"))
            photos.AddRange(IO.Directory.GetFiles(photoFolder, "*.jpeg"))
            photos.AddRange(IO.Directory.GetFiles(photoFolder, "*.webp"))
        End If
    End Sub

    Private Sub DisplayCurrentPhoto()
        If photos IsNot Nothing AndAlso photos.Count > 0 Then
            Dim photoPath As String = photos(currentPhotoKey)
            PictureBox1.ImageLocation = photoPath
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Class
