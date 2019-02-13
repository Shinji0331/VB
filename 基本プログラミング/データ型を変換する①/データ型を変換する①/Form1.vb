Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 30
        Dim lng As Long = i
        Dim d As Double = 123.456
        i = CInt(d)
        Label2.Text = i

        Dim o As Object = i
        o = "Visual Basic 2017"
        Dim s1 As String = DirectCast(o, String)
        Dim s2 As String = TryCast(o, String)
    End Sub
End Class
