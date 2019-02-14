Public Class MyItem
    Public Property Key As String
    Public Property Text As String
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst = New List(Of MyItem)()
        lst.Add(New MyItem With {.Key = "vb", .Text = "Visual Basic"})
        lst.Add(New MyItem With {.Key = "pp", .Text = "PowerPoint"})
        lst.Add(New MyItem With {.Key = "wd", .Text = "Word"})
        lst.Add(New MyItem With {.Key = "ac", .Text = "Access"})

        ListBox1.Items.Clear()
        For Each it In lst
            ListBox1.Items.Add($"{it.Key} : {it.Text}")
        Next

        Dim item = lst.FirstOrDefault(Function(x)
                                          Return x.Key = TextBox1.Text
                                      End Function)
        If item Is Nothing Then
            Label3.Text = "なし"
        Else
            Label3.Text = item.Text
        End If


    End Sub
End Class
