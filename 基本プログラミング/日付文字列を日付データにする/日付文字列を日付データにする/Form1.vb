Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As DateTime
        Dim ret = DateTime.TryParse(TextBox1.Text, dt)
        If ret Then
            Label3.Text = dt
        Else
            Label3.Text = "DateTime型の値に変換できません。"
        End If
    End Sub
End Class
