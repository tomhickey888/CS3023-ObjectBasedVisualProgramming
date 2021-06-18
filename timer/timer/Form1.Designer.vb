<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblThing = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnFaster = New System.Windows.Forms.Button()
        Me.btnSlower = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblThing
        '
        Me.lblThing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThing.Location = New System.Drawing.Point(12, 9)
        Me.lblThing.Name = "lblThing"
        Me.lblThing.Size = New System.Drawing.Size(100, 23)
        Me.lblThing.TabIndex = 0
        Me.lblThing.Text = "*"
        Me.lblThing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 425)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 52)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start / Stop"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(339, 425)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 52)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(169, 425)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 52)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnFaster
        '
        Me.btnFaster.Location = New System.Drawing.Point(339, 12)
        Me.btnFaster.Name = "btnFaster"
        Me.btnFaster.Size = New System.Drawing.Size(100, 52)
        Me.btnFaster.TabIndex = 4
        Me.btnFaster.Text = "Speed Up"
        Me.btnFaster.UseVisualStyleBackColor = True
        '
        'btnSlower
        '
        Me.btnSlower.Location = New System.Drawing.Point(339, 87)
        Me.btnSlower.Name = "btnSlower"
        Me.btnSlower.Size = New System.Drawing.Size(100, 52)
        Me.btnSlower.TabIndex = 5
        Me.btnSlower.Text = "Slow Down"
        Me.btnSlower.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(339, 262)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(100, 52)
        Me.btnRight.TabIndex = 6
        Me.btnRight.Text = "More Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(339, 336)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(100, 52)
        Me.btnLeft.TabIndex = 7
        Me.btnLeft.Text = "More Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 489)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnSlower)
        Me.Controls.Add(Me.btnFaster)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblThing)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblThing As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnFaster As System.Windows.Forms.Button
    Friend WithEvents btnSlower As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button

End Class
