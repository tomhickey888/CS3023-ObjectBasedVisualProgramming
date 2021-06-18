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
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.txtHrsWrkd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblTotalTax = New System.Windows.Forms.Label()
        Me.lblMediCareTax = New System.Windows.Forms.Label()
        Me.lblFICATax = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCaclulate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPayRate)
        Me.GroupBox1.Controls.Add(Me.txtHrsWrkd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'txtPayRate
        '
        Me.txtPayRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayRate.Location = New System.Drawing.Point(246, 73)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(100, 31)
        Me.txtPayRate.TabIndex = 8
        '
        'txtHrsWrkd
        '
        Me.txtHrsWrkd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrsWrkd.Location = New System.Drawing.Point(246, 35)
        Me.txtHrsWrkd.Name = "txtHrsWrkd"
        Me.txtHrsWrkd.Size = New System.Drawing.Size(100, 31)
        Me.txtHrsWrkd.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pay Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours Worked:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblGrossPay)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblNetPay)
        Me.GroupBox2.Controls.Add(Me.lblTotalTax)
        Me.GroupBox2.Controls.Add(Me.lblMediCareTax)
        Me.GroupBox2.Controls.Add(Me.lblFICATax)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(53, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 233)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pay Data"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(243, 34)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(100, 31)
        Me.lblGrossPay.TabIndex = 6
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "MediCare Tax:"
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(243, 190)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(100, 31)
        Me.lblNetPay.TabIndex = 2
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalTax
        '
        Me.lblTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTax.Location = New System.Drawing.Point(243, 151)
        Me.lblTotalTax.Name = "lblTotalTax"
        Me.lblTotalTax.Size = New System.Drawing.Size(100, 31)
        Me.lblTotalTax.TabIndex = 3
        Me.lblTotalTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMediCareTax
        '
        Me.lblMediCareTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMediCareTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediCareTax.Location = New System.Drawing.Point(297, 112)
        Me.lblMediCareTax.Name = "lblMediCareTax"
        Me.lblMediCareTax.Size = New System.Drawing.Size(100, 31)
        Me.lblMediCareTax.TabIndex = 4
        Me.lblMediCareTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFICATax
        '
        Me.lblFICATax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFICATax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATax.Location = New System.Drawing.Point(297, 73)
        Me.lblFICATax.Name = "lblFICATax"
        Me.lblFICATax.Size = New System.Drawing.Size(100, 31)
        Me.lblFICATax.TabIndex = 5
        Me.lblFICATax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Net Pay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total Tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Gross Pay:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FICA Tax:"
        '
        'btnCaclulate
        '
        Me.btnCaclulate.Location = New System.Drawing.Point(55, 447)
        Me.btnCaclulate.Name = "btnCaclulate"
        Me.btnCaclulate.Size = New System.Drawing.Size(91, 36)
        Me.btnCaclulate.TabIndex = 2
        Me.btnCaclulate.Text = "&Calculate"
        Me.btnCaclulate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(207, 447)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 36)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(359, 447)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCaclulate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(508, 505)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCaclulate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Pay Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents txtHrsWrkd As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents lblTotalTax As System.Windows.Forms.Label
    Friend WithEvents lblMediCareTax As System.Windows.Forms.Label
    Friend WithEvents lblFICATax As System.Windows.Forms.Label
    Friend WithEvents btnCaclulate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
