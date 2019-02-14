Public Class Form1

    Private o As New SampleClass

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler o.MyEvent, AddressOf o_MyEvent
    End Sub

    Private Sub o_MyEvent(s As String)
        Label1.Text = s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        o.proc()
    End Sub

End Class

Public Class SampleClass
    Public Event MyEvent As Action(Of String)
    Public Sub proc()
        Dim msg As String = DateTime.Now.ToString("HH:mm:ss")
        RaiseEvent MyEvent(msg)
    End Sub
End Class
