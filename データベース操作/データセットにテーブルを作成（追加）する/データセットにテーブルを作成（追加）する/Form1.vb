Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\study\Desktop\a\VB\データベース操作\SampleDB.accdb;")
        Dim ds As New DataSet("生物")
        Dim dt = ds.Tables.Add("恐竜")
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("名前", GetType(String))
        MessageBox.Show($"{ds.Tables(0).TableName}テーブルを追加しました", "通知")
    End Sub
End Class
