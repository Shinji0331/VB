Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim genericStr = New MyGeneric(Of String)() With {
            .Value = "Visual Basic"
        }

        Dim genericInt = New MyGeneric(Of Integer)() With {
            .Value = 2017
        }

        MessageBox.Show(genericStr.Value & " " & genericInt.Value, "確認")
    End Sub
End Class

Public Class MyGeneric(Of T)
    Private _val As T

    Public Property Value() As T
        Get
            Return _val
        End Get
        Set(value As T)
            _val = value
        End Set
    End Property
End Class
