﻿Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim linkTarget As String
        linkTarget = LinkLabel1.Link(0).LinkData.ToString()
        System.Diagnostics.Process.Start(linkTarget) 'リンク先を開く

        '訪問済みとしてテキストの色を変更
        LinkLabel1.LinkVisited = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LinkLabel1.Text = "秀和システムのサイトを開きます"
        LinkLabel1.Links.Add(0, 6, "shuwasystem.co.jp")

    End Sub

End Class
