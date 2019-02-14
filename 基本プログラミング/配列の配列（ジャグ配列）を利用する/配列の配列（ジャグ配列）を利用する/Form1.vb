Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student = New Integer(2)() {}
        student(0) = New Integer(2) {37, 35, 34}
        student(1) = New Integer(1) {41, 43}
        student(2) = New Integer(3) {33, 34, 33, 35}

        ListBox1.Items.Clear()
        For i = 0 To student.Length - 1
            ListBox1.Items.Add($"{i + 1}年")
            For j = 0 To student(i).Length - 1
                ListBox1.Items.Add($"  {j + 1}組：{student(i)(j)}")
            Next
        Next
    End Sub
End Class
