Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ret = Await Task.Factory.StartNew(
            Function()
                Dim i = 0
                While i < 10
                    Me.Invoke(New Action(
                              Sub()
                                  Label1.Text = $"{i}秒経過"
                              End Sub))
                    System.Threading.Thread.Sleep(1000)
                    i += 1
                End While
                Return DateTime.Now
            End Function)
        Label1.Text = $"最終時刻：{ret}"
    End Sub
End Class
