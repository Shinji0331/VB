Public Class Form1

    Public Structure Point
        Public X As Integer
        Public Y As Integer
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pt As Point
        pt = twicePoint(100, 200)
        MessageBox.Show("xの位置　：　" & pt.X & vbLf &
                        "yの位置　：　" & pt.Y, "戻り値の構造体の値")
    End Sub

    Private Function twicePoint(x As Integer, y As Integer) As Point
        Dim pt As Point
        pt.X = x * 2
        pt.Y = y * 2
        Return pt
    End Function
End Class
