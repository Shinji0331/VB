Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Where t.Iｄ = 0 Select t

        If q.Count() > 0 Then
            ent.商品.Remove(q.First())
        End If
        ent.SaveChanges()
        DataGridView1.DataSource = ent.商品.ToList()
    End Sub
End Class
