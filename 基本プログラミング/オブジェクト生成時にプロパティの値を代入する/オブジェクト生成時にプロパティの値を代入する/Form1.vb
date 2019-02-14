Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As New SampleClass() With {
            .Name = "山田はなこ"
        }
        Label1.Text = o.Name
    End Sub
End Class

Public Class SampleClass
    Public Property Name As String
End Class
