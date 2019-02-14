Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        proc("1月")
        proc(2)
    End Sub

    Private Sub proc(nextMonth As String)
        MessageBox.Show("次回の放送は　" & nextMonth & "です。", "通知")
    End Sub

    Private Sub proc(nextMonth As Integer)
        proc(nextMonth & "月")
    End Sub
End Class
