
Public Class UBulb

    Private Sub selectMode(ByVal intMode As Integer)
        pbBulb.Image = imgBulb.Images(intMode)
    End Sub

    Public Sub setMode(ByVal mode As String)
        If mode = "on" Then
            Me.selectMode(0)
        ElseIf mode = "off" Then
            Me.selectMode(1)
        Else
            Me.selectMode(1)
        End If
    End Sub

End Class
