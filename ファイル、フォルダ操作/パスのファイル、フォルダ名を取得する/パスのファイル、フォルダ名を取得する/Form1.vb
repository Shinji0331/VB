Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        Label1.Text = System.IO.Path.GetDirectoryName(path)
        Label2.Text = System.IO.Path.GetFileName(path)
    End Sub
End Class
