Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst = New SortedList(Of String, String)()
        lst("vb") = "visual basic"
        lst("pp") = "PowerPoint"
        lst.Add("wd", "Word")
        lst.Add("ac", "Access")

        ListBox1.Items.Clear()
        Dim i = 0
        For Each it In lst
            ListBox1.Items.Add($"{i} : {it.Key} : {it.Value}")
            i += 1
        Next

        lst.Add("ex", "Excel")
        ListBox2.Items.Clear()
        i = 0
        For Each it In lst
            ListBox2.Items.Add($"{i} : {it.Key} : {it.Value}")
            i += 1
        Next
    End Sub
End Class
