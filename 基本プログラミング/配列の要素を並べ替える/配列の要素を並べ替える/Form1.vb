Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim apli = New String() {"PowerPoint", "Word", "Excel", "Access"}
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        ListBox1.Items.AddRange(apli)

        Array.Sort(apli)
        ListBox2.Items.AddRange(apli)

        Array.Reverse(apli)
        ListBox3.Items.AddRange(apli)
    End Sub
End Class
