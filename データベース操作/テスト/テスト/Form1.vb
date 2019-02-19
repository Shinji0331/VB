

Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader

        Dim connectionString As String
        Dim sqlStr As String

        '接続文字列 
        connectionString = "server=localhost;database=test1;user id=root;password="

        'コネクション生成 
        con = New MySqlConnection(connectionString)

        Try
            con.Open()
            MessageBox.Show("接続！！", "通知")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        End Try
        ''接続 
        'con.Open()

        ''SQL文 
        'sqlStr = "select * from tablename"

        ''MySQLCommand作成 
        'cmd = New MySqlCommand(sqlStr, con)

        ''SQL文実行 
        'dr = cmd.ExecuteReader

        ''結果を表示 
        'While dr.Read()
        '    Console.WriteLine(CStr(dr("id")) + "：" + dr("name"))
        'End While

        ''クローズ 
        'con.Close()

        'MessageBox.Show("接続！！", "通知")
    End Sub
End Class
