Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then
            MessageBox.Show("ファイルがみつかりません", "通知")
        End If
        ListBox1.Items.Clear()
        Using st = New StreamReader(path)
            Dim ch As Integer = st.Read()
            While ch <> -1
                ListBox1.Items.Add(Char.ConvertFromUtf32(ch))
                ch = st.Read()
            End While
        End Using
    End Sub
End Class
