Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await Task.Factory.StartNew(Sub()
                                        For i As Integer = 1 To 60
                                            Me.Invoke(New Action(
                                                      Sub()
                                                          Label1.Text = DateTime.Now.ToString("HH:MM:ss")
                                                      End Sub))
                                            System.Threading.Thread.Sleep(1000)
                                        Next
                                    End Sub)
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim task1 As New Task(
            Sub()
                For i = 1 To 60
                    Me.Invoke(New Action(
                              Sub()
                                  Label1.Text = DateTime.Now.ToString("HH:MM:ss")
                              End Sub))
                    System.Threading.Thread.Sleep(1000)
                Next
            End Sub)
        Await Task.Delay(5000)
        task1.Start()
    End Sub
End Class
