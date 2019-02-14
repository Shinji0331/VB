Public Class SampleClass
    Private _name As String
    Private _id As String
    Public Sub New(Name As String)
        _name = Name
        _id = DateTime.Now.ToString("yyMMddHHmm")
    End Sub
End Class


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New SampleClass("新規お客様")
        MessageBox.Show("SampleClassのインスタンスを生成しました。", "確認")
    End Sub
End Class
