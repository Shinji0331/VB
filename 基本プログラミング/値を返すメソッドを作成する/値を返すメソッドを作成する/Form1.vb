Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ret = proc(10, 20)
        Label1.Text = "取得した戻り値：" + ret.ToString()
    End Sub

    Private Function proc(x As Integer, y As Integer) As Integer
        Return x * y
    End Function
End Class
