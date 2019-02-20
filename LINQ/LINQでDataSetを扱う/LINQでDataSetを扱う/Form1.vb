Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ad = New DataSet1TableAdapters.商品TableAdapter()
        Dim table = ad.GetData()
        Dim q = From t In table Select t.商品名

        ListBox1.DataSource = q.ToList()
    End Sub
End Class
