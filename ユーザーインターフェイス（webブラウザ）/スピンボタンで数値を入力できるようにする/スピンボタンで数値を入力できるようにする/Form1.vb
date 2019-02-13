Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Minimum = 1
        NumericUpDown1.Maximum = 100
        NumericUpDown1.Value = 50
        NumericUpDown1.Increment = 5
    End Sub
End Class
