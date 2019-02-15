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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(27, 101)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 88)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 19)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "指定区切り文字で分割１"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "「/」で分割し配列に取得、各要素をリストボックスに表示"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(213, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "指定区切り文字で分割2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(27, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(213, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "正規表現で分割"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 293)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
