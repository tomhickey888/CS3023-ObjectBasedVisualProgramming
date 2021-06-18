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
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(12, 264)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(101, 55)
        Me.btnWrite.TabIndex = 0
        Me.btnWrite.Text = "Write Numbers to File"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(294, 264)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(101, 55)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read Numbers from File"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(12, 22)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(383, 212)
        Me.lstDisplay.TabIndex = 2
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(153, 264)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(101, 55)
        Me.btnAppend.TabIndex = 3
        Me.btnAppend.Text = "Append Numbers in a File"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(305, 342)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(21, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(153, 326)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(101, 55)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print the Array"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 393)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Name = "Form1"
        Me.Text = "Writing to a File"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button

End Class
