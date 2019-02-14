Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dic = New Dictionary(Of String, String)
        dic("ex") = "Excel"
        dic("pp") = "PowerPoint"
        dic.Add("wd", "Word")
        dic.Add("ac", "Access")

        Label2.Text = dic("wd")

        ListBox1.Items.Clear()
        For Each mykey As String In dic.Keys
            ListBox1.Items.Add(mykey)
        Next

        ListBox2.Items.Clear()
        For Each myVal As String In dic.Values
            ListBox2.Items.Add(myVal)
        Next

        ListBox3.Items.Clear()
        For Each myPair In dic
            ListBox3.Items.Add(myPair.Key & ControlChars.Tab & myPair.Value)
        Next
    End Sub
End Class
