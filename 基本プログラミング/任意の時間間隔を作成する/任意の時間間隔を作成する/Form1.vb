Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ts1 = New TimeSpan(20, 10, 5)
        Dim ts2 = New TimeSpan(0, 25, 20, 15)
        Dim ts3 = New TimeSpan(0, 0, 0, 0, 1001)
        Label4.Text = ts1.ToString()
        Label5.Text = ts2.ToString()
        Label6.Text = ts3.ToString()
    End Sub
End Class
