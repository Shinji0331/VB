Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With FontDialog1
            .ShowColor = True
            .Font = RichTextBox1.SelectionFont
            .Color = RichTextBox1.SelectionColor
        End With

        If FontDialog1.ShowDialog() = DialogResult.OK Then
            With RichTextBox1
                .SelectionFont = FontDialog1.Font
                .SelectionColor = FontDialog1.Color
            End With
        End If
    End Sub
End Class
