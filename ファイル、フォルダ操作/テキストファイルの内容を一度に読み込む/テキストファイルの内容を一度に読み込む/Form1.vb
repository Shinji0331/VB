Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then
            MessageBox.Show("ファイルが見つかりません", "通知")
            Return
        End If
        Using st = New StreamReader(path)
            Label1.Text = st.ReadToEnd()
        End Using
    End Sub
End Class
