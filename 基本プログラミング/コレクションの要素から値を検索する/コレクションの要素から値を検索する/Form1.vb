Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst = New List(Of String)() From {
            "東京", "品川", "新横浜"}
        For Each val As Object In ListBox1.Items
            lst.Add(val)
        Next

        Dim ret As Integer = lst.IndexOf(TextBox1.Text)
        If ret = -1 Then
            Label3.Text = "コレクション内に存在しません"
        Else
            Label3.Text = TextBox1.Text & "のインデックス：" & ret
        End If
    End Sub
End Class
