Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim persons = XElement.Load("C:\Users\study\Desktop\VB\LINQ\LINQでXMLを扱う\LINQでXMLを扱う\persons.xml")
        Dim q = From p In persons.Descendants("person")
                Where p.Element("name").Value.StartsWith("masuda")
                Select p.Element("name").Value

        ListBox1.DataSource = q.ToList()
    End Sub
End Class
