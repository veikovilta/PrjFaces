Imports PrjSwitch

Public Class Test
    Private Sub btnConfused_Click(sender As Object, e As EventArgs) Handles btnConfused.Click
        UCtrlEmotion.setMood("confused")
    End Sub

    Private Sub btnCool_Click(sender As Object, e As EventArgs) Handles btnCool.Click
        UCtrlEmotion.setMood("cool")
    End Sub

    Private Sub btnSmile_Click(sender As Object, e As EventArgs) Handles btnSmile.Click
        UCtrlEmotion.setMood("smile")
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) Handles btnStar.Click
        UCtrlEmotion.setMood("star")
    End Sub

    Private Sub btnTeeth_Click(sender As Object, e As EventArgs) Handles btnTeeth.Click
        UCtrlEmotion.setMood("teeth")
    End Sub

    Private Sub btnYell_Click(sender As Object, e As EventArgs) Handles btnYell.Click
        UCtrlEmotion.setMood("yell")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        UCtrlEmotion.setMood("clear")
    End Sub

    Private Sub UBulb_Load(sender As Object, e As EventArgs) Handles UBulb.Load
        UBulb.setMode("off")
    End Sub

    Private Sub USwitch1_Load(sender As Object, e As EventArgs) Handles USwitch.Load
        USwitch.setSwitch("off")
    End Sub

    Private Sub USwitch1_SwitchStateChanged(state As Integer) Handles USwitch.SwitchStateChanged
        If state = 1 Then
            UBulb.setMode("on")
        ElseIf state = 0 Then
            UBulb.setMode("off")
        End If
    End Sub
End Class
