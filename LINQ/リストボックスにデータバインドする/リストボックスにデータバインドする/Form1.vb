Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent = New VBlessonEntities()
        Dim q = From t In ent.商品 Select t

        ListBox1.FormattingEnabled = True
        AddHandler ListBox1.Format,
            Sub(_s, _e)
                _e.Value = String.Format("{0}{1}円", DirectCast(_e.Value, 商品).商品名, DirectCast(_e.Value, 商品).単価)
            End Sub
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
