Public Class Form1

    Dim myLabel As New Label()
    Dim myTextBox As New TextBox()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myLabel.Text = "今日の日付"
        myLabel.Location = New Point(25, 60)

        myTextBox.Text = Now.ToLongDateString
        myTextBox.Location = New Point(25, 90)
        myTextBox.Size = New Size(200, 20)

        Me.Controls.Add(myLabel)
        Me.Controls.Add(myTextBox)

        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Controls.Remove(myLabel)
        Me.Controls.Remove(myTextBox)
        Button1.Visible = True
        Button2.Visible = False
    End Sub
End Class
