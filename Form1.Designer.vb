<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Administrator = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login_btn = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.Administrator)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Login_btn)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 237)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Administrator
        '
        Me.Administrator.AutoSize = True
        Me.Administrator.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Administrator.Location = New System.Drawing.Point(19, 135)
        Me.Administrator.Name = "Administrator"
        Me.Administrator.Size = New System.Drawing.Size(77, 28)
        Me.Administrator.TabIndex = 6
        Me.Administrator.Text = "管理者"
        Me.Administrator.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "パスワード"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Login_btn
        '
        Me.Login_btn.Font = New System.Drawing.Font("メイリオ", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Login_btn.Location = New System.Drawing.Point(19, 190)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(225, 41)
        Me.Login_btn.TabIndex = 2
        Me.Login_btn.Text = "ログイン"
        Me.Login_btn.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.BackColor = System.Drawing.SystemColors.Window
        Me.ID.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ID.Location = New System.Drawing.Point(18, 36)
        Me.ID.Multiline = True
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(223, 33)
        Me.ID.TabIndex = 1
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.SystemColors.Window
        Me.Password.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Password.Location = New System.Drawing.Point(19, 96)
        Me.Password.Multiline = True
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(223, 33)
        Me.Password.TabIndex = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login"
        Me.Text = "ログイン"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Administrator As System.Windows.Forms.CheckBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Login_btn As System.Windows.Forms.Button

End Class
