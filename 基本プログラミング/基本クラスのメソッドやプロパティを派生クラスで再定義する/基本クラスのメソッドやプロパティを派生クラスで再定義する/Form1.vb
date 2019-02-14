Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tel = New SampleClassTel("山田はなこ", "090-xxxx-xxxx")
        tel.ShowData()
    End Sub
End Class

Public Class SampleClass
    Public Property Name As String
    Public Property Id As String

    Public Sub New(name As String)
        Me.Name = name
        Me.Id = DateTime.Now.ToString("yyMMddHHmm")
    End Sub

    Public Overridable Sub ShowData()
        MessageBox.Show($"お客様氏名：{Id} - {Name}", "確認")
    End Sub
End Class

Public Class SampleClassTel
    Inherits SampleClass
    Public Property Tel As String

    Public Sub New(name As String, tel As String)
        MyBase.New(name)
        Me.Tel = tel
    End Sub

    Public Overrides Sub ShowData()
        MyBase.ShowData()
        MessageBox.Show($"お客様電話番号：{Tel}", "確認")
    End Sub
End Class
