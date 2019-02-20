Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Where t.Iｄ = 1 Select t

        If q.Count() > 0 Then
            q.First().商品名 = "新商品"
        End If
        ent.SaveChanges()
        DataGridView1.DataSource = ent.商品.ToList()
    End Sub
End Class
