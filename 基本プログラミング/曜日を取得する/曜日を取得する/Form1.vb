Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DateTime.Today
        Select Case dt.DayOfWeek
            Case DayOfWeek.Sunday
                Label3.Text = "日曜日"
            Case DayOfWeek.Monday
                Label3.Text = "月曜日"
            Case DayOfWeek.Tuesday
                Label3.Text = "火曜日"
            Case DayOfWeek.Wednesday
                Label3.Text = "水曜日"
            Case DayOfWeek.Thursday
                Label3.Text = "木曜日"
            Case DayOfWeek.Friday
                Label3.Text = "金曜日"
            Case DayOfWeek.Saturday
                Label3.Text = "土曜日"
        End Select
    End Sub
End Class
