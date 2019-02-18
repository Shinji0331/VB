Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.Description = "フォルダを選択してください"
        FolderBrowserDialog1.ShowNewFolderButton = False
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Label1.Text = FolderBrowserDialog1.SelectedPath
        Else
            Label1.Text = ""
        End If
    End Sub
End Class
