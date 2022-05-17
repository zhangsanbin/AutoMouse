<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txty = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lbh = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(27, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Mouse Location(x,y)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "After 10 seconds"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(27, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 48)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Start Auto Mouse Control"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(150, 104)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(44, 21)
        Me.txtTime.TabIndex = 5
        Me.txtTime.Text = "30"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Start countdown(s):"
        '
        'txtx
        '
        Me.txtx.Location = New System.Drawing.Point(150, 77)
        Me.txtx.Name = "txtx"
        Me.txtx.Size = New System.Drawing.Size(44, 21)
        Me.txtx.TabIndex = 2
        Me.txtx.Text = "916"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mouse Location(x,y)"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'txty
        '
        Me.txty.Location = New System.Drawing.Point(200, 77)
        Me.txty.Name = "txty"
        Me.txty.Size = New System.Drawing.Size(44, 21)
        Me.txty.TabIndex = 3
        Me.txty.Text = "618"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(27, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 53)
        Me.Panel1.TabIndex = 8
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 29)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(197, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Right-click(Right Mouse Down)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 7)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(185, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Left-click(Left Mouse Down)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        '
        'lbh
        '
        Me.lbh.AutoSize = True
        Me.lbh.Location = New System.Drawing.Point(200, 108)
        Me.lbh.Name = "lbh"
        Me.lbh.Size = New System.Drawing.Size(41, 12)
        Me.lbh.TabIndex = 6
        Me.lbh.Text = "Second"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(27, 244)
        Me.ProgressBar1.Maximum = 100000000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(217, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 286)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txty)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Mouse Control"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtx As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txty As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lbh As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer4 As System.Windows.Forms.Timer

End Class
