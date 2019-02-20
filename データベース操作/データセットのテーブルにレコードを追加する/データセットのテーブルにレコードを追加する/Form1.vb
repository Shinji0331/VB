Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds = New DataSet("生物")
        Dim colData = {2, "ブラキオサウルス"}
        Dim dt = ds.Tables.Add("恐竜")
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("名前", GetType(String))
        Dim row = dt.NewRow()
        row("ID") = 1
        row("名前") = "ティラノサウルス"
        dt.Rows.Add(row)
        dt.Rows.Add(colData)
        MessageBox.Show("追加したレコード：　" &
                        ds.Tables(0).Rows(0)(0) &
                        "　" &
                        ds.Tables(0).Rows(0)(1), "結果通知")
    End Sub
End Class
