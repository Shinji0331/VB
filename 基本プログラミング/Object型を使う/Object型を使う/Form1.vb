Public Class Form1

    Private Function sampleMethod(x As Object) As Object
        If TypeOf x Is String Then
            Return 365
        Else
            Return "文字列を返す"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As Object
        o = sampleMethod("Sample")
        Label3.Text = o.ToString()
        o = sampleMethod(15)
        Label4.Text = o
    End Sub
End Class
