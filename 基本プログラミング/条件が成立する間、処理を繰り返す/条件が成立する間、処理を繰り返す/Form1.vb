Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        ListBox1.Items.Clear()
        While i < 11
            ListBox1.Items.Add("No." & i)
            i += 1
        End While
    End Sub
End Class
