Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans As Integer
        Label1.Text = RichTextBox1.UndoActionName
        ans = MessageBox.Show("処理を戻しますか？", "確認", MessageBoxButtons.YesNo)

        If ans = DialogResult.Yes Then
            RichTextBox1.Undo()
        End If
        Label1.Text = ""
    End Sub
End Class
