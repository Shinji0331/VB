﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ary = {"東京", "名古屋", "大阪"}
        Label3.Text = $"ary(0)={ary(0)},ary(1)={ary(1)},ary(2)={ary(2)}"
        Array.Clear(ary, 1, 2)
        Label4.Text = $"ary(0)={ary(0)},ary(1)={ary(1)},ary(2)={ary(2)}"
    End Sub
End Class
