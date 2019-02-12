Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Location = New Point(0, 0)
        newForm.Show()
    End Sub
End Class
