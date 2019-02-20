Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DirectCast(Me.DataGridView1.DataSource, DataTable)
        '行の編集状態をイミディエイトウィンドウに出力する
        For i As Integer = 0 To dt.Rows.Count - 1
            System.Diagnostics.Debug.WriteLine(
                i.ToString() + vbTab + dt.Rows(i).RowState.ToString())
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
