Public Class Form1

    ' Creating global named constants
    Const dblFICA As Double = 0.062
    Const dblMediCare As Double = 0.0145

    ' Event Handler for the Calculate button
    Private Sub btnCaclulate_Click(sender As Object, e As EventArgs) Handles btnCaclulate.Click

        ' Dimensioning variables
        Dim strHoursWorked As String
        Dim strPayRate As String
        Dim intHoursWorked As Integer
        Dim dblPayRate As Double
        Dim dblGrossPay As Double
        Dim dblFICATax As Double
        Dim dblMediCareTax As Double
        Dim dblTotalTax As Double
        Dim dblNetPay As Double

        ' Stores user text input in variables
        strHoursWorked = txtHrsWrkd.Text
        strPayRate = txtPayRate.Text

        ' Begin defensive programming
        Try

            ' Converts text data to numeric values and stores in correct variables for calculation
            intHoursWorked = CInt(strHoursWorked)
            dblPayRate = CDbl(strPayRate)

            ' Calculates Pay Data and stores in variables
            dblGrossPay = intHoursWorked * dblPayRate
            dblFICATax = dblGrossPay * dblFICA
            dblMediCareTax = dblGrossPay * dblMediCare
            dblTotalTax = dblFICATax + dblMediCareTax
            dblNetPay = dblGrossPay - dblTotalTax

            ' Displays the calculated pay data
            lblGrossPay.Text = dblGrossPay.ToString("C")
            lblFICATax.Text = dblFICATax.ToString("C")
            lblMediCareTax.Text = dblMediCareTax.ToString("C")
            lblTotalTax.Text = dblTotalTax.ToString("C")
            lblNetPay.Text = dblNetPay.ToString("C")

            ' Error message for bad user input
        Catch ex As Exception
            MessageBox.Show("Please be sure and put in numbers for both hours worked and pay rate before attempting to calculate.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            ' Clears bad data and refocuses
            btnClear.PerformClick()
        End Try

    End Sub

    ' Event handler for the Clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clears out text boxes
        txtHrsWrkd.Clear()
        txtPayRate.Clear()

        ' Clears out labels
        lblGrossPay.Text = String.Empty
        lblFICATax.Text = String.Empty
        lblMediCareTax.Text = String.Empty
        lblTotalTax.Text = String.Empty
        lblNetPay.Text = String.Empty

        ' Resets focus on Hours Worked
        txtHrsWrkd.Focus()

    End Sub

    ' Event handler for the Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Closes active form
        Me.Close()

    End Sub

End Class
