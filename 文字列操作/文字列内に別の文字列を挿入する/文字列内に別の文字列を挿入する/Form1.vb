Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 = TextBox1.Text
        Dim text2 = TextBox2.Text

        If text1.Length < 2 Then
            Return
        End If
        Label1.Text = text1.Insert(2, text2)
    End Sub
End Class
