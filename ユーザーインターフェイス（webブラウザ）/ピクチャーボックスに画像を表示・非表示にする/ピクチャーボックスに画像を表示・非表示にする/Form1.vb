Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\study\Desktop\VB\【素材】使用する画像集\himeji.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
