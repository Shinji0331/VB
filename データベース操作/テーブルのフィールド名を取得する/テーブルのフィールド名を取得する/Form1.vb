﻿Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\study\Desktop\VB\データベース操作\SampleDB.accdb;")
        cn.Open()
        Dim cmd = New OleDbCommand("SELECT * FROM 社員", cn)
        Using dr = cmd.ExecuteReader()
            For i As Integer = 0 To dr.FieldCount - 1
                ListBox1.Items.Add($"{i + 1}番目のフィールド：{dr.GetName(i)}")
            Next
        End Using
        cn.Close()
    End Sub
End Class
