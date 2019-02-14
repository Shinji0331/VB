Public Class Form1

    Public Structure MyStruct
        Public CourseNo As String
        Public CourseName As String
        Public Num As Integer
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mc = New MyStruct(2) {}
        ListBox1.Items.Clear()
        For i As Integer = 0 To 2
            mc(i).CourseNo = (i + 1).ToString("00")
            mc(i).CourseName = "コース名未定"
            mc(i).Num = 20
            ListBox1.Items.Add($"{mc(i).CourseNo}-{mc(i).CourseName}-{mc(i).Num}名")
        Next
    End Sub
End Class
