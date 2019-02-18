Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With SaveFileDialog1
            .RestoreDirectory = True
            .OverwritePrompt = True
            .Filter = "JPeg (*.jpg) |*.jpg|Gif (*.gif) |*.gif"
        End With

        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        Label1.Text = Path.GetFileName(SaveFileDialog1.FileName)
        Using fs = DirectCast(SaveFileDialog1.OpenFile(), FileStream)
            If SaveFileDialog1.FilterIndex = 1 Then
                PictureBox1.Image.Save(fs, Imaging.ImageFormat.Jpeg)
            Else
                PictureBox1.Image.Save(fs, Imaging.ImageFormat.Gif)
            End If
        End Using
        Label2.Text = "保存しました"
    End Sub
End Class
