Public Class Form1

    Private sTime As DateTime
    Private eTime As DateTime

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sTime = DateTime.Now
        Label2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        eTime = DateTime.Now
        Dim ts = eTime.Subtract(sTime)
        If ts.Seconds = 10 Then
            Label2.Text = "Congraturations! " + ts.TotalSeconds.ToString("##.##") + "秒です。"
        Else
            Label2.Text = "残念！　" + ts.TotalSeconds.ToString("##.##") + "秒でした。"
        End If
    End Sub
End Class
