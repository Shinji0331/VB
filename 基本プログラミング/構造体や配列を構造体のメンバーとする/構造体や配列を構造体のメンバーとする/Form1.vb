Public Class Form1

    Public Structure BurgerSet
        Public Drink As Drink
        Public Burger As String
    End Structure

    Public Structure Drink
        Public Name As String
        Public Size As String()
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bs As BurgerSet
        Dim setSize = {"S", "M", "L"}

        bs.Burger = "ベーコンレタスバーガー"
        bs.Drink.Name = "オレンジジュース"
        bs.Drink.Size = setSize

        MessageBox.Show("バーガー名：　" + bs.Burger + vbLf &
                        "ドリンク名：　" + bs.Drink.Name + vbLf &
                        "ドリンクサイズ：　" + bs.Drink.Size(1), "確認")
    End Sub
End Class
