
Module MouseModule
    Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Const MOUSEEVENTF_LEFTDOWN As Long = &H2    '模拟鼠标左键按下
    Public Const MOUSEEVENTF_LEFTUP As Long = &H4      '模拟鼠标左键释放
    Public Const MOUSEEVENTF_MIDDLEDOWN As Long = &H20 '模拟鼠标中间键按下
    Public Const MOUSEEVENTF_MIDDLEUP As Long = &H40   '模拟鼠标中间键释放
    Public Const MOUSEEVENTF_RIGHTDOWN As Long = &H8   '模拟鼠标右键按下
    Public Const MOUSEEVENTF_RIGHTUP As Long = &H10    '模拟鼠标右键释放
    Public Const MOUSEEVENTF_MOVE As Long = &H1        '模拟鼠标指针移动
    Public Sub MouseAction(ByVal MouseMsg As String)
        Select Case MouseMsg
            Case "LeftMouseDown"   '执行鼠标左键按下
                mouse_event(MOUSEEVENTF_LEFTDOWN, Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0)
            Case "LeftMouseUp"     '执行鼠标左键弹起
                mouse_event(MOUSEEVENTF_LEFTUP, Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0)
            Case "MiddleMouseDown" '执行鼠标中键按下
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0)
            Case "MiddleMouseUp"   '执行鼠标中键弹起
                mouse_event(MOUSEEVENTF_MIDDLEUP, Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0)
            Case "RightMouseDown"  '执行鼠标右键按下
                mouse_event(MOUSEEVENTF_RIGHTDOWN, Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0)
            Case "RightMouseUp"    '执行鼠标右键弹起
                mouse_event(MOUSEEVENTF_RIGHTUP, Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0)
        End Select
    End Sub
End Module