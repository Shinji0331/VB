Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\study\Desktop\a\VB\データベース操作\SampleDB.accdb;")
        cn.Open()
        Dim cmd = New OleDbCommand("INSERT INTO 社員 VALUES(100112,'小林忍','B-011')", cn)
        Dim tr = cn.BeginTransaction()
        cmd.Transaction = tr
        Try
            cmd.ExecuteNonQuery()
            tr.Commit()
            MessageBox.Show("終了しました", "通知")
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show(ex.Message, "エラー")
            MessageBox.Show("ロールバックされました。", "通知")
        End Try
        cn.Close()
    End Sub
End Class
