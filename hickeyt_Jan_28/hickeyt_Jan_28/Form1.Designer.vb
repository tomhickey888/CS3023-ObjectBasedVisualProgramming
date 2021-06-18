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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.txtChildSold = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGrossAdultSales = New System.Windows.Forms.Label()
        Me.lblGrossChildSales = New System.Windows.Forms.Label()
        Me.lblTotalGrossSales = New System.Windows.Forms.Label()
        Me.lblTotalNetSales = New System.Windows.Forms.Label()
        Me.lblNetChildSales = New System.Windows.Forms.Label()
        Me.lblNetAdultSales = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price Per Ticket:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tickets Sold:"
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(150, 34)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultPrice.TabIndex = 4
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(150, 91)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultSold.TabIndex = 6
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(150, 91)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(100, 20)
        Me.txtChildSold.TabIndex = 6
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(150, 34)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtChildPrice.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tickets Sold:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price Per Ticket:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtChildSold)
        Me.GroupBox2.Controls.Add(Me.txtChildPrice)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(409, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Ticket Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Child Ticket Sales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Adult Ticket Sales:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalGrossSales)
        Me.GroupBox3.Controls.Add(Me.lblGrossChildSales)
        Me.GroupBox3.Controls.Add(Me.lblGrossAdultSales)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(37, 313)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 205)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Sales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Child Ticket Sales"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Adult Ticket Sales"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblNetAdultSales)
        Me.GroupBox4.Controls.Add(Me.lblNetChildSales)
        Me.GroupBox4.Controls.Add(Me.lblTotalNetSales)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(409, 313)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(284, 205)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Sales"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total Gross"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 26)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total Net Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Ticket Sales"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrossAdultSales
        '
        Me.lblGrossAdultSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossAdultSales.Location = New System.Drawing.Point(147, 37)
        Me.lblGrossAdultSales.Name = "lblGrossAdultSales"
        Me.lblGrossAdultSales.Size = New System.Drawing.Size(100, 20)
        Me.lblGrossAdultSales.TabIndex = 4
        '
        'lblGrossChildSales
        '
        Me.lblGrossChildSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossChildSales.Location = New System.Drawing.Point(147, 93)
        Me.lblGrossChildSales.Name = "lblGrossChildSales"
        Me.lblGrossChildSales.Size = New System.Drawing.Size(100, 20)
        Me.lblGrossChildSales.TabIndex = 8
        '
        'lblTotalGrossSales
        '
        Me.lblTotalGrossSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrossSales.Location = New System.Drawing.Point(147, 146)
        Me.lblTotalGrossSales.Name = "lblTotalGrossSales"
        Me.lblTotalGrossSales.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalGrossSales.TabIndex = 9
        '
        'lblTotalNetSales
        '
        Me.lblTotalNetSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNetSales.Location = New System.Drawing.Point(150, 146)
        Me.lblTotalNetSales.Name = "lblTotalNetSales"
        Me.lblTotalNetSales.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalNetSales.TabIndex = 8
        '
        'lblNetChildSales
        '
        Me.lblNetChildSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChildSales.Location = New System.Drawing.Point(150, 92)
        Me.lblNetChildSales.Name = "lblNetChildSales"
        Me.lblNetChildSales.Size = New System.Drawing.Size(100, 20)
        Me.lblNetChildSales.TabIndex = 9
        '
        'lblNetAdultSales
        '
        Me.lblNetAdultSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdultSales.Location = New System.Drawing.Point(150, 36)
        Me.lblNetAdultSales.Name = "lblNetAdultSales"
        Me.lblNetAdultSales.Size = New System.Drawing.Size(100, 20)
        Me.lblNetAdultSales.TabIndex = 10
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(84, 594)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 55)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Ticket " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(305, 594)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 55)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(526, 594)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 55)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 676)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdultSold As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChildSold As System.Windows.Forms.TextBox
    Friend WithEvents txtChildPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalGrossSales As System.Windows.Forms.Label
    Friend WithEvents lblGrossChildSales As System.Windows.Forms.Label
    Friend WithEvents lblGrossAdultSales As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNetAdultSales As System.Windows.Forms.Label
    Friend WithEvents lblNetChildSales As System.Windows.Forms.Label
    Friend WithEvents lblTotalNetSales As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
