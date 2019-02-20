Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Select t

        Dim cnt = q.Count()
        TextBox1.Text = cnt
        DataGridView1.DataSource = q.ToList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ent = New VBlessonEntities()
        Dim cnt = ent.商品.Count(Function(t) t.単価 >= 200)
        TextBox1.Text = cnt
    End Sub
End Class
