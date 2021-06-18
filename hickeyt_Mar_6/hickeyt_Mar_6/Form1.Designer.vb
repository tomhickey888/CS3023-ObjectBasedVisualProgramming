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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCaclulate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.chkLube = New System.Windows.Forms.CheckBox()
        Me.chkRad = New System.Windows.Forms.CheckBox()
        Me.chkTrans = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.chkMuffler = New System.Windows.Forms.CheckBox()
        Me.chkTire = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblServicesTotal = New System.Windows.Forms.Label()
        Me.lblPartsTotal = New System.Windows.Forms.Label()
        Me.lblPartsTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkLube)
        Me.GroupBox1.Controls.Add(Me.chkOil)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil && Lube"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTrans)
        Me.GroupBox2.Controls.Add(Me.chkRad)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtParts)
        Me.GroupBox3.Controls.Add(Me.txtLabor)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(301, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parts && Labor"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblPartsTax)
        Me.GroupBox4.Controls.Add(Me.lblPartsTotal)
        Me.GroupBox4.Controls.Add(Me.lblServicesTotal)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(489, 140)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Summary"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkTire)
        Me.GroupBox5.Controls.Add(Me.chkMuffler)
        Me.GroupBox5.Controls.Add(Me.chkInspection)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Misc"
        '
        'btnCaclulate
        '
        Me.btnCaclulate.Location = New System.Drawing.Point(12, 450)
        Me.btnCaclulate.Name = "btnCaclulate"
        Me.btnCaclulate.Size = New System.Drawing.Size(92, 54)
        Me.btnCaclulate.TabIndex = 2
        Me.btnCaclulate.Text = "&Calculate Fees"
        Me.btnCaclulate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(210, 450)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 54)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(409, 450)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 54)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Location = New System.Drawing.Point(6, 19)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(120, 17)
        Me.chkOil.TabIndex = 5
        Me.chkOil.Text = "&Oil Change ($26.00)"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'chkLube
        '
        Me.chkLube.AutoSize = True
        Me.chkLube.Location = New System.Drawing.Point(6, 59)
        Me.chkLube.Name = "chkLube"
        Me.chkLube.Size = New System.Drawing.Size(112, 17)
        Me.chkLube.TabIndex = 6
        Me.chkLube.Text = "Lube &Job ($18.00)"
        Me.chkLube.UseVisualStyleBackColor = True
        '
        'chkRad
        '
        Me.chkRad.AutoSize = True
        Me.chkRad.Location = New System.Drawing.Point(6, 19)
        Me.chkRad.Name = "chkRad"
        Me.chkRad.Size = New System.Drawing.Size(136, 17)
        Me.chkRad.TabIndex = 7
        Me.chkRad.Text = "&Radiator Flush ($30.00)"
        Me.chkRad.UseVisualStyleBackColor = True
        '
        'chkTrans
        '
        Me.chkTrans.AutoSize = True
        Me.chkTrans.Location = New System.Drawing.Point(6, 59)
        Me.chkTrans.Name = "chkTrans"
        Me.chkTrans.Size = New System.Drawing.Size(157, 17)
        Me.chkTrans.TabIndex = 8
        Me.chkTrans.Text = "Transmission &Flush ($80.00)"
        Me.chkTrans.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(6, 19)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(117, 17)
        Me.chkInspection.TabIndex = 9
        Me.chkInspection.Text = "&Inspection ($15.00)"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'chkMuffler
        '
        Me.chkMuffler.AutoSize = True
        Me.chkMuffler.Location = New System.Drawing.Point(6, 42)
        Me.chkMuffler.Name = "chkMuffler"
        Me.chkMuffler.Size = New System.Drawing.Size(134, 17)
        Me.chkMuffler.TabIndex = 10
        Me.chkMuffler.Text = "Replace &Muffler ($100)"
        Me.chkMuffler.UseVisualStyleBackColor = True
        '
        'chkTire
        '
        Me.chkTire.AutoSize = True
        Me.chkTire.Location = New System.Drawing.Point(6, 65)
        Me.chkTire.Name = "chkTire"
        Me.chkTire.Size = New System.Drawing.Size(87, 17)
        Me.chkTire.TabIndex = 11
        Me.chkTire.Text = "&Tire Rotation"
        Me.chkTire.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "&Parts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "La&bor ($)"
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(63, 20)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 5
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(63, 59)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 20)
        Me.txtLabor.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Services && Labor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Parts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tax (on parts)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total Fees"
        '
        'lblServicesTotal
        '
        Me.lblServicesTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServicesTotal.Location = New System.Drawing.Point(292, 22)
        Me.lblServicesTotal.Name = "lblServicesTotal"
        Me.lblServicesTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblServicesTotal.TabIndex = 8
        '
        'lblPartsTotal
        '
        Me.lblPartsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartsTotal.Location = New System.Drawing.Point(292, 47)
        Me.lblPartsTotal.Name = "lblPartsTotal"
        Me.lblPartsTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblPartsTotal.TabIndex = 9
        '
        'lblPartsTax
        '
        Me.lblPartsTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartsTax.Location = New System.Drawing.Point(292, 73)
        Me.lblPartsTax.Name = "lblPartsTax"
        Me.lblPartsTax.Size = New System.Drawing.Size(100, 20)
        Me.lblPartsTax.TabIndex = 10
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(292, 102)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblTotal.TabIndex = 11
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCaclulate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(513, 547)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCaclulate)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Joe's Automotive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCaclulate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents chkLube As System.Windows.Forms.CheckBox
    Friend WithEvents chkOil As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrans As System.Windows.Forms.CheckBox
    Friend WithEvents chkRad As System.Windows.Forms.CheckBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkTire As System.Windows.Forms.CheckBox
    Friend WithEvents chkMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents lblPartsTotal As System.Windows.Forms.Label
    Friend WithEvents lblServicesTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPartsTax As System.Windows.Forms.Label

End Class
