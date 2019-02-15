Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 = Label1.Text
        Label2.Text = text1.Replace("しまりす", "シマリス")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim text1 = Label1.Text
        Label2.Text = Regex.Replace(text1, "し..す", "シマリス")
    End Sub
End Class
