Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dname = Directory.GetCurrentDirectory()
        MessageBox.Show($"カレントフォルダは{dname}です", "通知")
        Directory.SetCurrentDirectory("C:\")
        MessageBox.Show("カレントフォルダをC:\に変更しました" & vbLf & "[OK]をクリックするともとに戻します", "通知")
    End Sub
End Class
