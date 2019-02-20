Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities()
        Dim item = New 商品() With {
            .Iｄ = 9,
            .商品名 = "追加商品",
            .単価 = 900}
        ent.商品.Add(item)
        ent.SaveChanges()
        DataGridView1.DataSource = ent.商品.ToList()
    End Sub
End Class
