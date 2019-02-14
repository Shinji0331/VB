Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DateTime.Now
        Label4.Text = dt
        Label5.Text = dt.AddHours(-5)
        Label6.Text = dt.AddDays(10)
    End Sub
End Class
