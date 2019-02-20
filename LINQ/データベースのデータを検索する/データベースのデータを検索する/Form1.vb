Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities1()
        Dim q = From t In ent.商品 Where t.単価 >= 200 Select t

        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
