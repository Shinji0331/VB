﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはテンプレートから生成されました。
'
'     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
'     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class VBlessonEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=VBlessonEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property 商品() As DbSet(Of 商品)

End Class
