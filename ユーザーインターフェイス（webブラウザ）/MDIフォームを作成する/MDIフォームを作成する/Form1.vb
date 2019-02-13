Public Class Form1
    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 新規作成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新規作成ToolStripMenuItem.Click
        Dim myForm As New Form
        Dim myRichTextBox As New RichTextBox()

        myRichTextBox.Dock = DockStyle.Fill

        myForm.MdiParent = Me
        myForm.Text = "文書" & MdiChildren.Length
        myForm.Size = New Size(250, 250)
        myForm.Controls.Add(myRichTextBox)
        myForm.Show()
    End Sub

    Private Sub 左右に整列ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 左右に整列ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub 上下に整列ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上下に整列ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub 重ねて整列ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重ねて整列ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub 閉じるToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 閉じるToolStripMenuItem.Click
        Dim myForm As Form = Me.ActiveMdiChild
        If myForm Is Nothing Then
            Exit Sub
        End If
        DirectCast(myForm.Controls(0), RichTextBox).
            SaveFile("C:\Users\study\Desktop\VB\ユーザーインターフェイス（webブラウザ）\MDIフォームを作成する" & myForm.Text & ".rtf")
        myForm.Close()
    End Sub
End Class
