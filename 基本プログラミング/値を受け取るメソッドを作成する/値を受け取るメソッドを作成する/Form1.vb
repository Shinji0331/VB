Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xStr As String = "Param"
        Dim yStr As String = "Param"
        xProc(xStr)
        yProc(yStr)
        Label2.Text = Convert.ToString("値渡しの結果：") & xStr
        Label3.Text = Convert.ToString("参照渡しの結果：") & yStr
    End Sub

    Private Sub xProc(xParam As String)
        xParam = "Change!"
    End Sub

    Private Sub yProc(ByRef yParam As String)
        yParam = "Change!"
    End Sub
End Class
