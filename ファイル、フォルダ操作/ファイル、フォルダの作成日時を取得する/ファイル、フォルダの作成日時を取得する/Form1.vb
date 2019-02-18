Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname = TextBox1.Text
        If Directory.Exists(fname) = True Then
            Label1.Text = Directory.GetCreationTime(fname).ToString()
        ElseIf File.Exists(fname) = True Then
            Label1.Text = File.GetCreationTime(fname).ToString()
        Else
            Label1.Text = $"{fname}が見つかりませんでした"
        End If
    End Sub
End Class
