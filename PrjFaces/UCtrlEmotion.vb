﻿Public Class UCtrlEmotion

    Private Sub selectMood(ByVal intMood As Integer)
        pbEmotion.Image = imgLoend.Images(intMood)
    End Sub

    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "confused"
                Me.selectMood(0)
            Case "cool"
                Me.selectMood(1)
            Case "smile"
                Me.selectMood(2)
            Case "star"
                Me.selectMood(3)
            Case "teeth"
                Me.selectMood(4)
            Case "yell"
                Me.selectMood(5)
            Case "clear"
                pbEmotion.Image.Dispose()
                pbEmotion.Image = Nothing
            Case Else
                Me.selectMood(0)
        End Select
    End Sub
End Class
