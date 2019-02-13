Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim myPath As String = "C:\Users\study\Desktop\VB\【素材】使用する画像集"

        Dim imgFile() As String = System.IO.Directory.GetFiles(myPath, "*.jpg")
        For i = 0 To imgFile.Length - 1
            Dim myImg As Image = Image.FromFile(imgFile(i))
            ImageList1.Images.Add(myImg)
            ListView1.Items.Add(imgFile(i), i)

            myImg.Dispose()
        Next
    End Sub
End Class
