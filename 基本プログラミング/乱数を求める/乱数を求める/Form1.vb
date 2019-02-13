Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnd = New Random()
        Label3.Text = rnd.Next(100)
        Label4.Text = rnd.Next(100, 1001)
    End Sub
End Class
