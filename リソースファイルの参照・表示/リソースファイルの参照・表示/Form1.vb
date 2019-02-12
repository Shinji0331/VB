Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = My.Resources.String1
        PictureBox1.Image = My.Resources.myPic01
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class
