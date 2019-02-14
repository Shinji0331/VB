Public Class SampleClass
    Private _name As String

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Sub New(Name As String)
        _name = Name
    End Sub
End Class


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o = New SampleClass("新規お客様")
        o.Name = "山田はなこ"
        MessageBox.Show($"Nameプロパティの値：{o.Name}", "確認")
    End Sub
End Class
