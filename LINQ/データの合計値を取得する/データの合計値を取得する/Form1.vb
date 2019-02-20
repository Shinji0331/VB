Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品
                Select t.単価
        Dim sum = q.Sum()
        TextBox1.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ent = New VBlessonEntities()
        Dim sum = ent.商品.Sum(Function(t) t.単価)
        TextBox1.Text = sum
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Select t

        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
