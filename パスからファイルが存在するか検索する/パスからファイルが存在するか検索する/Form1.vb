Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Directory.Exists(TextBox1.Text) = True Then
            Label2.Text = "フォルダが見つかりました"
        Else
            Label2.Text = "フォルダが見つかりません"
        End If
    End Sub
End Class
