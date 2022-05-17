
Public Class Form1

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        Dim s2 As Integer
        Try
            s2 = txtTime.Text
        Catch ex As Exception
            s2 = 0
        End Try

        If s2 < 3600 Then
            lbh.Text = Math.Round(s2 / 60, 1) & " Min"
        Else
            lbh.Text = Math.Round(s2 / 60 / 60, 1) & " Hour"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True
        Timer4.Enabled = True
        s0 = 10
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Timer4.Enabled = False

        txtx.Text = System.Windows.Forms.Cursor.Position.X
        txty.Text = System.Windows.Forms.Cursor.Position.Y

        If txtx.ForeColor = Color.Red Then txtx.ForeColor = Color.Blue Else txtx.ForeColor = Color.Red
        If txty.ForeColor = Color.Red Then txty.ForeColor = Color.Blue Else txty.ForeColor = Color.Red

        Button1.BackColor = Color.Gainsboro
        Button1.Text = "Get Mouse Location(x,y)" & vbCrLf & "After 10 seconds"
    End Sub

    Dim s0 As Integer
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        s0 = s0 - 1
        Button1.Text = "Get Mouse Location(x,y)" & vbCrLf & "After " & s0 & " seconds"
        If Button1.BackColor = Color.Red Then
            Button1.BackColor = Color.Yellow
        Else
            Button1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtTime.Text = "" Then
            txtTime.Text = 30
        End If

        s = txtTime.Text

        ProgressBar1.Maximum = s

        If s < 3600 Then
            lbh.Text = Math.Round(s / 60, 1) & " Min"
        Else
            lbh.Text = Math.Round(s / 60 / 60, 1) & " Hour"
        End If

        Timer3.Interval = 1000
        Timer3.Enabled = True
    End Sub

    Dim s As Integer
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        s = s - 1
        Button2.Text = "Start Auto Mouse Control" & vbCrLf & "After " & s & " seconds"
        If Button2.BackColor = Color.Red Then
            Button2.BackColor = Color.Yellow
        Else
            Button2.BackColor = Color.Red
        End If

        Try
            ProgressBar1.Value = txtTime.Text - s
        Catch ex As Exception
            ProgressBar1.Value = ProgressBar1.Maximum
        End Try

        If s = 0 Then
            Timer3.Enabled = False

            ProgressBar1.Value = txtTime.Text

            MouseMoveWork(txtx.Text, txty.Text)

            System.Threading.Thread.Sleep(1000)

            'if Mouse Location is true then go
            Dim mMouseLocationTrue As Boolean
            While Not mMouseLocationTrue
                If System.Windows.Forms.Cursor.Position.X = txtx.Text And System.Windows.Forms.Cursor.Position.Y = txty.Text Then
                    mMouseLocationTrue = True
                Else
                    MouseMoveWork(txtx.Text, txty.Text)
                End If
            End While

            If RadioButton1.Checked Then
                MouseModule.MouseAction("LeftMouseDown")
                System.Threading.Thread.Sleep(500)
                MouseModule.MouseAction("LeftMouseUp")
            Else
                MouseModule.MouseAction("RightMouseDown")
                System.Threading.Thread.Sleep(500)
                MouseModule.MouseAction("RightMouseUp")
            End If

            Button2.BackColor = Color.Gainsboro
            Button2.Text = "Start Auto Mouse Control"
        End If
    End Sub

    ''' <summary>
    ''' 控制鼠标坐标
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <remarks></remarks>
    Public Sub MouseMoveWork(ByVal x As Integer, ByVal y As Integer)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = True
        Me.TopMost = True
    End Sub

End Class
