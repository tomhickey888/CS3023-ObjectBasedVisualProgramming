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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnClickHere = New System.Windows.Forms.Button()
        Me.btnThenClickHere = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(200, 200)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(182, 108)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "Hello" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "World"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClickHere
        '
        Me.btnClickHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClickHere.Location = New System.Drawing.Point(225, 425)
        Me.btnClickHere.Name = "btnClickHere"
        Me.btnClickHere.Size = New System.Drawing.Size(129, 58)
        Me.btnClickHere.TabIndex = 1
        Me.btnClickHere.Text = "Click Here"
        Me.btnClickHere.UseVisualStyleBackColor = True
        '
        'btnThenClickHere
        '
        Me.btnThenClickHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThenClickHere.Location = New System.Drawing.Point(225, 509)
        Me.btnThenClickHere.Name = "btnThenClickHere"
        Me.btnThenClickHere.Size = New System.Drawing.Size(129, 58)
        Me.btnThenClickHere.TabIndex = 2
        Me.btnThenClickHere.Text = "Then Click Here"
        Me.btnThenClickHere.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(567, 612)
        Me.Controls.Add(Me.btnThenClickHere)
        Me.Controls.Add(Me.btnClickHere)
        Me.Controls.Add(Me.lblDisplay)
        Me.Name = "Form1"
        Me.Text = "My First Visual Basic Program"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnClickHere As System.Windows.Forms.Button
    Friend WithEvents btnThenClickHere As System.Windows.Forms.Button

End Class
