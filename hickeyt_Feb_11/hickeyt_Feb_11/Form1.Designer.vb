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
        Me.txtIntA = New System.Windows.Forms.TextBox()
        Me.txtIntB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtIntA
        '
        Me.txtIntA.Location = New System.Drawing.Point(101, 101)
        Me.txtIntA.Name = "txtIntA"
        Me.txtIntA.Size = New System.Drawing.Size(100, 20)
        Me.txtIntA.TabIndex = 0
        '
        'txtIntB
        '
        Me.txtIntB.Location = New System.Drawing.Point(293, 101)
        Me.txtIntB.Name = "txtIntB"
        Me.txtIntB.Size = New System.Drawing.Size(100, 20)
        Me.txtIntB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Two Integers"
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(58, 142)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(379, 80)
        Me.lblDisplay.TabIndex = 3
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(101, 242)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(100, 33)
        Me.btnCompare.TabIndex = 4
        Me.btnCompare.Text = "&Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(293, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "A: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "B: "
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCompare
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(495, 293)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIntB)
        Me.Controls.Add(Me.txtIntA)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIntA As System.Windows.Forms.TextBox
    Friend WithEvents txtIntB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
