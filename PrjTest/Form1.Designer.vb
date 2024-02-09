<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnConfused = New System.Windows.Forms.Button()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.UCtrlEmotion = New PrjFaces.UCtrlEmotion()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConfused
        '
        Me.btnConfused.Location = New System.Drawing.Point(486, 66)
        Me.btnConfused.Name = "btnConfused"
        Me.btnConfused.Size = New System.Drawing.Size(133, 36)
        Me.btnConfused.TabIndex = 1
        Me.btnConfused.Text = "Confused "
        Me.btnConfused.UseVisualStyleBackColor = True
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(486, 108)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(133, 36)
        Me.btnCool.TabIndex = 2
        Me.btnCool.Text = "Cool"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(486, 150)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(133, 36)
        Me.btnSmile.TabIndex = 3
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnTeeth
        '
        Me.btnTeeth.Location = New System.Drawing.Point(486, 234)
        Me.btnTeeth.Name = "btnTeeth"
        Me.btnTeeth.Size = New System.Drawing.Size(133, 36)
        Me.btnTeeth.TabIndex = 4
        Me.btnTeeth.Text = "Teeth"
        Me.btnTeeth.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(486, 192)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(133, 36)
        Me.btnStar.TabIndex = 5
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnYell
        '
        Me.btnYell.Location = New System.Drawing.Point(486, 276)
        Me.btnYell.Name = "btnYell"
        Me.btnYell.Size = New System.Drawing.Size(133, 36)
        Me.btnYell.TabIndex = 6
        Me.btnYell.Text = "Yell"
        Me.btnYell.UseVisualStyleBackColor = True
        '
        'UCtrlEmotion
        '
        Me.UCtrlEmotion.Location = New System.Drawing.Point(178, 139)
        Me.UCtrlEmotion.Name = "UCtrlEmotion"
        Me.UCtrlEmotion.Size = New System.Drawing.Size(120, 103)
        Me.UCtrlEmotion.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(486, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 421)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.btnConfused)
        Me.Controls.Add(Me.UCtrlEmotion)
        Me.Name = "Test"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UCtrlEmotion As PrjFaces.UCtrlEmotion
    Friend WithEvents btnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnTeeth As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents btnClear As Button
End Class
