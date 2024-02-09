Public Class USwitch

    Dim state As Integer = 0

    Public Event SwitchStateChanged(state As Integer)

    Private Sub selectSwState(ByVal intstate As Integer)
        pbSwitch.Image = imgSwitches.Images(intstate)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click

        If state = 0 Then
            setSwitch("on")
            state = 1
        Else
            setSwitch("off")
            state = 0
        End If

        RaiseEvent SwitchStateChanged(state)

    End Sub

    Public Sub setSwitch(ByVal state As String)
        If state = "on" Then
            Me.selectSwState(0)
        ElseIf state = "off" Then
            Me.selectSwState(1)
        Else
            Me.selectSwState(1)
        End If
    End Sub

End Class
