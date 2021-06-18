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
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.dSaveFileAs = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(25, 72)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(110, 46)
        Me.btnGetData.TabIndex = 0
        Me.btnGetData.Text = "Get &Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(216, 72)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(110, 46)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(407, 72)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(110, 46)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "&Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(598, 72)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 46)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dOpenFile
        '
        Me.dOpenFile.Filter = "Text Files (*.txt)|*.txt"
        Me.dOpenFile.InitialDirectory = "E:\School\2013-2014\Spring\CS3023 - Object Based Visual Programming\Projects\hick" & _
    "eyt_3023_Test_3"
        Me.dOpenFile.Title = "Open File"
        '
        'dSaveFileAs
        '
        Me.dSaveFileAs.FileName = "output"
        Me.dSaveFileAs.Filter = "Text Files (*.txt)|*.txt"
        Me.dSaveFileAs.Title = "Save File As"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 191)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnGetData)
        Me.Name = "Form1"
        Me.Text = "CS 3023 Test 3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents dOpenFile As System.Windows.Forms.OpenFileDialog
    Public WithEvents dSaveFileAs As System.Windows.Forms.SaveFileDialog

End Class
