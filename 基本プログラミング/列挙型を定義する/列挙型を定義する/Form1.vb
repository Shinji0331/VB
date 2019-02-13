Public Class Form1

    Private Enum ClassType
        Special
        Standard
        Basic
    End Enum

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test As ClassType
        Select Case ComboBox1.SelectedIndex
            Case CInt(ClassType.Special)
                test = ClassType.Special
            Case CInt(ClassType.Standard)
                test = ClassType.Standard
            Case Else
                test = ClassType.Basic
        End Select
        Label3.Text = test.ToString()
    End Sub
End Class
