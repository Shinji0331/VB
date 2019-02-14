Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lstX = {"London", "Paris", "NewYork"}
        Dim lstY = proc(lstX)
        Label2.Text = ""
        For Each city As String In lstY
            Label2.Text += city & ControlChars.Lf
        Next
    End Sub

    Private Function proc(lst As String()) As String()
        Label1.Text = ""
        For Each city In lst
            Label1.Text += city & ControlChars.Lf
        Next
        lst(2) = "Tokyo"
        Return lst
    End Function
End Class
