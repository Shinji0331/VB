Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim code = Asc("A")
        Label1.Text = code.ToString()
    End Sub
End Class
