Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Title = "画像ファイルの選択"
            .CheckFileExists = True
            .RestoreDirectory = True
            .Filter = "イメージファイル|*.bmp;*.jpg;*.gif"
        End With

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Label1.Text = OpenFileDialog1.FileName
            Label3.Text = OpenFileDialog1.SafeFileName
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            Label1.Text = ""
            Label3.Text = ""
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
