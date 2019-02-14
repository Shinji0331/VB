Public Class Form1

    Public Structure MyMenu
        Public menuNo As Integer
        Public Menu As String
        Public price As Integer
        Public ReadOnly Property priceBig() As Integer
            Get
                Return price + 100
            End Get
        End Property
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mn As MyMenu
        mn.menuNo = 1
        mn.Menu = "仙台味噌ラーメン"
        mn.price = 750
        MessageBox.Show("◎　大盛価格 --- \" & mn.priceBig, mn.Menu)
    End Sub
End Class
