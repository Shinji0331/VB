Public Class Form1
    Private _task As Task
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _task = New Task(
            Sub()
                For i As Integer = 0 To 59
                    Me.Invoke(New Action(
                              Sub()
                                  Label1.Text = DateTime.Now.ToString("HH:MM:ss")
                              End Sub))
                    System.Threading.Thread.Sleep(1000)
                Next
            End Sub)
        _task.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _task = New Task(AddressOf OnWork)
        _task.Start()
    End Sub

    Private Sub OnWork()
        For i As Integer = 0 To 59
            Me.Invoke(New Action(
                       Sub()
                           Label1.Text = DateTime.Now.ToString("HH:MM:ss")
                       End Sub))
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub
End Class
