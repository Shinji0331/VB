Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Label1.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class
