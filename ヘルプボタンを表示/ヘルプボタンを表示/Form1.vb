Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button1_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Button1.HelpRequested
        MessageBox.Show("ボタンをクリックすると終了します。")
    End Sub
End Class
