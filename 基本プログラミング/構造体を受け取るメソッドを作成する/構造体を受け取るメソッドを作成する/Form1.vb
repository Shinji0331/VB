Public Class Form1

    Public Structure StructMenu
        Public MenuNo As Integer
        Public Menu As String
        Public Price As Integer
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mn As StructMenu
        mn.MenuNo = 1
        mn.Menu = "仙台味噌ラーメン"
        mn.Price = 750
        showData(mn)
    End Sub

    Private Sub showData(nMenu As StructMenu)
        MessageBox.Show(nMenu.Menu + " : " + nMenu.Price.ToString("0円"), "確認")
    End Sub
End Class
