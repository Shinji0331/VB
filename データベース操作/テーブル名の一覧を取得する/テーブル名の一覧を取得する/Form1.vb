Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\study\Desktop\VB\データベース操作\SampleDB.accdb;")
        cn.Open()
        Dim dt = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, {Nothing, Nothing, Nothing, "TABLE"})
        cn.Close()
        ListBox1.Items.Clear()
        For Each dr As DataRow In dt.Rows
            ListBox1.Items.Add(dr(2))
        Next
    End Sub
End Class
