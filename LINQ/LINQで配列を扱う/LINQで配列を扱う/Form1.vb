Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim persons = {
            "masuda tomoaki",
            "masuda yumi",
            "masuda kaho",
            "masuda kazuhisa",
            "shinohara hayato",
            "shinohara shouta"}

        Dim q = From p In persons
                Where p.StartsWith("masuda") Select p
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
