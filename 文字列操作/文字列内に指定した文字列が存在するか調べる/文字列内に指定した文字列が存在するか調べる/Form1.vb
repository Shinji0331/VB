Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains("リス") Then
            Label1.Text = "含まれています"
        Else
            Label1.Text = "含まれていません"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Regex.IsMatch(TextBox1.Text, "ク*マ") Then
            Label1.Text = "含まれています"
        Else
            Label1.Text = "含まれていません"
        End If
    End Sub
End Class
