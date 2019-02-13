Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As Double
        d = Double.Parse(Label1.Text) + Double.Parse(Label2.Text)
        Label3.Text = d.ToString()
    End Sub
End Class
