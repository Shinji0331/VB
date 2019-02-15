Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text = TextBox1.Text
        Label1.Text = text.ToUpper()
        Label2.Text = text.ToLower()
    End Sub
End Class
