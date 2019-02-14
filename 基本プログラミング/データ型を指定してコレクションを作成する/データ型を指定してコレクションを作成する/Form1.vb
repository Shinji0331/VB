Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst = New List(Of String)()
        lst.AddRange(New String() {"味噌", "醤油", "お酒"})
        Label1.Text = ""
        For i As Integer = 0 To lst.Count - 1
            Label1.Text += lst(i) + ControlChars.Lf
        Next
    End Sub
End Class
