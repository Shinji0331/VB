Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.Columns.Add("ファイル名", 100)
        ListView1.Columns.Add("ファイルサイズ", 60, HorizontalAlignment.Right)
        ListView1.Columns.Add("更新日", 120)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dirInfo As System.IO.DirectoryInfo
        Dim fileList() As System.IO.FileInfo
        Dim fileInfo As System.IO.FileInfo

        ListView1.Items.Clear()

        If System.IO.Directory.Exists(TextBox1.Text) = False Then
            MessageBox.Show("フォルダが存在しません", "通知")
            Exit Sub
        End If

        dirInfo = New System.IO.DirectoryInfo(TextBox1.Text)
        fileList = dirInfo.GetFiles
        For Each fileInfo In fileList
            Dim fileItem As ListViewItem = New ListViewItem(fileInfo.Name)
            fileItem.SubItems.Add(fileInfo.Length.ToString)
            fileItem.SubItems.Add(fileInfo.LastWriteTime)
            ListView1.Items.Add(fileItem)
        Next
    End Sub


End Class
