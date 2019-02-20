Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n = Integer.Parse(TextBox1.Text)
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Order By t.Iｄ
                Skip n Take 1

        DataGridView1.DataSource = q.ToList()

    End Sub
End Class
