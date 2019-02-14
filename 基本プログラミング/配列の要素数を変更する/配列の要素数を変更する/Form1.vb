Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ary = New String() {"東京", "名古屋", "大阪"}
        Label1.Text = "配列aryの要素数：" & ary.Length & vbLf
        Label1.Text += $"ary(0)={ary(0)},ary(1)={ary(1)},ary(2)={ary(2)}"

        ary = New String(4) {}
        Label2.Text = "配列aryの要素数：" & ary.Length & vbLf
        Label2.Text += $"ary(0)={ary(0)},ary(1)={ary(1)},ary(2)={ary(2)}"

    End Sub
End Class
