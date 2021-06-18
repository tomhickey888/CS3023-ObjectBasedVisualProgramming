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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnConvertF = New System.Windows.Forms.Button()
        Me.btnConvertC = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Temperature:"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(252, 75)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp.TabIndex = 1
        Me.txtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(82, 142)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(441, 225)
        Me.lblDisplay.TabIndex = 2
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConvertF
        '
        Me.btnConvertF.Location = New System.Drawing.Point(82, 455)
        Me.btnConvertF.Name = "btnConvertF"
        Me.btnConvertF.Size = New System.Drawing.Size(92, 62)
        Me.btnConvertF.TabIndex = 3
        Me.btnConvertF.Text = "Convert" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&Farenheit"
        Me.btnConvertF.UseVisualStyleBackColor = True
        '
        'btnConvertC
        '
        Me.btnConvertC.Location = New System.Drawing.Point(198, 455)
        Me.btnConvertC.Name = "btnConvertC"
        Me.btnConvertC.Size = New System.Drawing.Size(92, 62)
        Me.btnConvertC.TabIndex = 4
        Me.btnConvertC.Text = "Convert " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&Celsius"
        Me.btnConvertC.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(314, 455)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 62)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(430, 455)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 62)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnConvertF
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(605, 600)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvertC)
        Me.Controls.Add(Me.btnConvertF)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnConvertF As System.Windows.Forms.Button
    Friend WithEvents btnConvertC As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
