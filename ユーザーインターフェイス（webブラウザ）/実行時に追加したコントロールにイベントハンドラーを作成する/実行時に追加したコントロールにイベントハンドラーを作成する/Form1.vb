Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myButton As New Button
        myButton.Text = "追加ボタン"
        myButton.Size = New Size(110, 35)
        myButton.Location = New Point(85, 80)
        Controls.Add(myButton)

        AddHandler myButton.Click, AddressOf myButton_Click
    End Sub

    Private Sub myButton_Click(sender As Object, e As EventArgs)
        MessageBox.Show("追加ボタンがクリックされました", "結果")
    End Sub
End Class
