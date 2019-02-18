Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname = TextBox1.Text
        If fname = "" Then
            Return
        End If
        System.IO.Directory.CreateDirectory(fname)
        Label1.Text = $"{fname}を作成しました"
    End Sub
End Class
