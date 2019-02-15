Public Class Form1

    Private Sub onTask1()
        Dim i = 0
        While i < 10
            Me.Invoke(New Action(
                      Sub()
                          Label1.Text = $"{i}秒経過"
                      End Sub))
            System.Threading.Thread.Sleep(1000)
            i += 1
        End While
    End Sub

    Private Sub onTask2()
        Dim i = 0
        While i < 10
            Me.Invoke(New Action(
                      Sub()
                          Label2.Text = $"{i}秒経過"
                      End Sub))
            System.Threading.Thread.Sleep(1000)
            i += 1
        End While
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await Task.Run(Sub() onTask1())
        Await Task.Run(Sub() onTask2())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Task.Run(Sub() onTask1())
        Task.Run(Sub() onTask2())
    End Sub
End Class
