Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DateTime.Now
        Label3.Text = dt.ToLongDateString()
        Label4.Text = dt.ToLongTimeString()
        Label7.Text = dt.Year
        Label5.Text = dt.Month
        Label9.Text = dt.Day
        Label13.Text = dt.Hour
        Label15.Text = dt.Minute
        Label11.Text = dt.Second
    End Sub
End Class
