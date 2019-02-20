Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row1 = {"001", "ライオン"}
        Dim row2 = {"002", "トラ"}
        Dim row3 = {"003", "ヒョウ"}
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("No", "No.")
        DataGridView1.Columns.Add("Name", "名前")
        DataGridView1.Rows.Add(row1)
        DataGridView1.Rows.Add(row2)
        DataGridView1.Rows.Add(row3)
    End Sub
End Class
