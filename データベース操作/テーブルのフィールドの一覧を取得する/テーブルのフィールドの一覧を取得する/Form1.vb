Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn = New SqlConnection("server=localhost;database=test1;user id=root;password=")
        Dim dt As Object
        Try
            cn.Open()
            dt = New SqlDataAdapter("select * from sampletables", cn)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        End Try

        For Each q In dt
            ListBox1.DataSource = q.ToList()
        Next


    End Sub
End Class
