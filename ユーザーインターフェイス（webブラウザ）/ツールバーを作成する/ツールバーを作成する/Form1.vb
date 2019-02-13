Public Class Form1
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim obj As Object
        For Each obj In Me.Controls
            ''オブジェクトがテキストボックスで、それにフォーカスがあるときに太字にする
            If TypeOf obj Is TextBox AndAlso TryCast(obj, TextBox).Focused Then
                Dim objText = TryCast(obj, TextBox)
                objText.Font = New Font(objText.Font, FontStyle.Bold)
            End If
        Next
    End Sub
End Class
