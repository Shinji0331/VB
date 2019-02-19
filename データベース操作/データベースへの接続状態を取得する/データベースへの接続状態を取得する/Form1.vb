Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\study\Desktop\VB\データベース操作\SampleDB.accdb;")
        Try
            cn.Open()
            MessageBox.Show($"接続状態　：　{cn.State}", "通知")
            cn.Close()
            MessageBox.Show($"接続状態　：　{cn.State}", "通知")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        End Try
    End Sub
End Class
