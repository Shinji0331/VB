Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then
            MessageBox.Show("ファイルがみつかりません", "通知")
            Return
        End If

        Dim rs = File.OpenRead(path)
        MessageBox.Show("ファイルを開きました", "通知")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim path = TextBox1.Text
        If path = "" Then
            Return
        End If
        Dim ws = New StreamWriter(path, True, System.Text.Encoding.Default)
        MessageBox.Show("ファイルを開きました", "通知")
        ws.Close()
    End Sub
End Class
