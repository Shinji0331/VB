Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\study\Desktop\a\VB\データベース操作\SampleDB.accdb;")
        cn.Open()
        Dim cmd = cn.CreateCommand()
        Dim tr = cn.BeginTransaction()
        cmd.Connection = cn
        cmd.Transaction = tr
        cmd.CommandText = "INSERT INTO 社員 VALUES(100111,'小林慎司','B-002')"
        cmd.ExecuteNonQuery()
        tr.Commit()
        MessageBox.Show("処理を終了しました", "通知")
        cn.Close()
    End Sub
End Class
