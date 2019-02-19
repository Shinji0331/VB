Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\study\Desktop\VB\データベース操作\SampleDB.accdb;")
        Dim ad = New OleDbDataAdapter("SELECT * FROM 社員", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        Dim builder = New OleDbCommandBuilder(ad)
        dt.Rows(0)("氏名") = "青木さん"
        ad.Update(dt)
        MessageBox.Show("社員テーブルを更新しました", "通知")
    End Sub
End Class
