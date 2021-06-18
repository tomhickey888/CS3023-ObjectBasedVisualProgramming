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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnMinMax = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblMinMax = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 12)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(151, 48)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Step 1: Input the Integers"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnMinMax
        '
        Me.btnMinMax.Location = New System.Drawing.Point(12, 81)
        Me.btnMinMax.Name = "btnMinMax"
        Me.btnMinMax.Size = New System.Drawing.Size(151, 48)
        Me.btnMinMax.TabIndex = 1
        Me.btnMinMax.Text = "Step 2: Display Min && Max"
        Me.btnMinMax.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 150)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(151, 48)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Step 3: Display all Numbers"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblMinMax
        '
        Me.lblMinMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinMax.Location = New System.Drawing.Point(12, 430)
        Me.lblMinMax.Name = "lblMinMax"
        Me.lblMinMax.Size = New System.Drawing.Size(333, 59)
        Me.lblMinMax.TabIndex = 3
        Me.lblMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(194, 12)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(151, 355)
        Me.lstDisplay.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 288)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 48)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 48)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(12, 219)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(151, 48)
        Me.btnAverage.TabIndex = 7
        Me.btnAverage.Text = "Step 4: Display the Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 498)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblMinMax)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnMinMax)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "Form1"
        Me.Text = "Largest/Smallest Values"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnMinMax As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lblMinMax As System.Windows.Forms.Label
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAverage As System.Windows.Forms.Button

End Class
