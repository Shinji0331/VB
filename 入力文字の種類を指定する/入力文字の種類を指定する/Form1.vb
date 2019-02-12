Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.ImeMode = ImeMode.Off
        TextBox2.ImeMode = ImeMode.On
    End Sub
End Class
