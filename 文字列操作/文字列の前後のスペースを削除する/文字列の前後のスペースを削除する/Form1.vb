Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t = TextBox1.Text
        If t = String.Empty Then
            Return
        End If
        Label1.Text = "「" + t.Trim() + "」"
        Label2.Text = "「" + t.TrimStart() + "」"
        Label3.Text = "「" + t.TrimEnd() + "」"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t = TextBox1.Text
        If t = String.Empty Then
            Return
        End If
        Label1.Text = "「" + Regex.Replace(t, "^\s*(.*?)\s*$" + "」", "$1")
    End Sub
End Class
