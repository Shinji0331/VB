Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Order By t.単価 Select t

        DataGridView1.DataSource = q.ToList()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Order By t.単価 Descending Select t

        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
