Public Class Form1
    Dim a1 As Integer
    Dim a2 As Integer
    Dim a3 As Integer
    Dim a4 As Integer

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            a1 = 35000
        Else
            a1 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            a2 = 40000
        Else
            a2 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            a3 = 20000
        Else
            a3 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            a4 = 15000
        Else
            a4 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")
    End Sub


End Class
