Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ary1 = {10, 20, 30}
        Dim ary2 = {6, 7, 8, 9, 0}
        Dim ary3 = DirectCast(ary1.Clone(), Integer())
        Dim ary4 = ary1
        ary1.CopyTo(ary2, 2)
        ary1(0) = 99

        Label5.Text = "ary1 = "
        Label6.Text = "ary2 = "
        Label7.Text = "ary3 = "
        Label8.Text = "ary4 = "

        For i = 0 To ary1.Length - 1
            Label5.Text += ary1(i) & " "
        Next
        For i = 0 To ary2.Length - 1
            Label6.Text += ary2(i) & " "
        Next
        For i = 0 To ary3.Length - 1
            Label7.Text += ary1(i) & " "
        Next
        For i = 0 To ary4.Length - 1
            Label8.Text += ary1(i) & " "
        Next
    End Sub
End Class
