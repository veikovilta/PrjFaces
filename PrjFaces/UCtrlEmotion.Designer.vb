﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlEmotion
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCtrlEmotion))
        Me.pbEmotion = New System.Windows.Forms.PictureBox()
        Me.imgLoend = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbEmotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbEmotion
        '
        Me.pbEmotion.Location = New System.Drawing.Point(0, 0)
        Me.pbEmotion.Name = "pbEmotion"
        Me.pbEmotion.Size = New System.Drawing.Size(32, 32)
        Me.pbEmotion.TabIndex = 0
        Me.pbEmotion.TabStop = False
        '
        'imgLoend
        '
        Me.imgLoend.ImageStream = CType(resources.GetObject("imgLoend.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLoend.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLoend.Images.SetKeyName(0, "confused.png")
        Me.imgLoend.Images.SetKeyName(1, "cool.png")
        Me.imgLoend.Images.SetKeyName(2, "smile.png")
        Me.imgLoend.Images.SetKeyName(3, "star.png")
        Me.imgLoend.Images.SetKeyName(4, "teeth.png")
        Me.imgLoend.Images.SetKeyName(5, "yell.png")
        '
        'UCtrlEmotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbEmotion)
        Me.Name = "UCtrlEmotion"
        Me.Size = New System.Drawing.Size(205, 160)
        CType(Me.pbEmotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbEmotion As PictureBox
    Friend WithEvents imgLoend As ImageList
End Class
