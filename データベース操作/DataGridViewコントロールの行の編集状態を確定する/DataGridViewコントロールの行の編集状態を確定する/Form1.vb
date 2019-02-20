Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DirectCast(DataGridView1.DataSource, DataTable)
        For Each dRow As DataRow In dt.Rows
            If dRow.RowState <> DataRowState.Unchanged Then
                dRow.AcceptChanges()
            End If
        Next
        For i As Integer = 0 To dt.Rows.Count - 1
            System.Diagnostics.Debug.WriteLine(
                i & "行目：" & dt.Rows(i).RowState)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\study\Desktop\a\VB\データベース操作\SampleDB.accdb;")
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        Me.DataGridView1.DataSource = dt
    End Sub
End Class
