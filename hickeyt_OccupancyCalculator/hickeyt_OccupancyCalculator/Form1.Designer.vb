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
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalRooms = New System.Windows.Forms.Label()
        Me.lblTotalOccupied = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOverallOccupancy = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(12, 12)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(607, 264)
        Me.lstDisplay.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Rooms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'lblTotalRooms
        '
        Me.lblTotalRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRooms.Location = New System.Drawing.Point(142, 298)
        Me.lblTotalRooms.Name = "lblTotalRooms"
        Me.lblTotalRooms.Size = New System.Drawing.Size(27, 15)
        Me.lblTotalRooms.TabIndex = 3
        '
        'lblTotalOccupied
        '
        Me.lblTotalOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOccupied.Location = New System.Drawing.Point(457, 297)
        Me.lblTotalOccupied.Name = "lblTotalOccupied"
        Me.lblTotalOccupied.Size = New System.Drawing.Size(27, 15)
        Me.lblTotalOccupied.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Occupied"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Overall Occupancy Rate"
        '
        'lblOverallOccupancy
        '
        Me.lblOverallOccupancy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallOccupancy.Location = New System.Drawing.Point(330, 344)
        Me.lblOverallOccupancy.Name = "lblOverallOccupancy"
        Me.lblOverallOccupancy.Size = New System.Drawing.Size(35, 15)
        Me.lblOverallOccupancy.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(72, 394)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(102, 53)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(262, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 53)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(455, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 53)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(631, 459)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOverallOccupancy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalOccupied)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalRooms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDisplay)
        Me.Name = "Form1"
        Me.Text = "Occupancy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRooms As System.Windows.Forms.Label
    Friend WithEvents lblTotalOccupied As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOverallOccupancy As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
