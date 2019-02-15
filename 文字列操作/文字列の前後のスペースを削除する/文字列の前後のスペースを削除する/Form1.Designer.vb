<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 19)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(155, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 23)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(155, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 23)
        Me.Label2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(155, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 23)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "前後の空白を削除"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "先頭の空白を削除"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "末尾の空白を削除"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(314, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "文字列の前後のスペースを削除"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(314, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "正規表現で文字列の前後のスペースを削除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 266)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
