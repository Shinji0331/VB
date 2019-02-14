Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As DateTime
        If TextBox1.Text = "" Then
            Label2.Text = "入力されていません"
        ElseIf DateTime.TryParse(TextBox1.Text, dt) Then
            Label2.Text = "入力された日付：" + dt
        Else
            Label2.Text = "正しい日付を入力してください"
        End If
    End Sub
End Class
