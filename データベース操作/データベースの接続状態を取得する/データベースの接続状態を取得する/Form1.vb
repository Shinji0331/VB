
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cn = New MySqlConnection("server=localhost;database=test1;user id=root;password=")

        Try
            cn.Open()
            MessageBox.Show($"接続状態　：　{cn.State}", "通知")
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        End Try
    End Sub
End Class
