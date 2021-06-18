Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const dbl_PERCENT_KEEP As Double = 0.2

        Dim strAdultPrice As String
        Dim strChildPrice As String
        Dim strAdultSold As String
        Dim strChildSold As String

        Dim intAdultSold As Integer
        Dim intChildSold As Integer

        Dim dblAdultPrice As Double
        Dim dblChildPrice As Double
        Dim dblAdultSales As Double
        Dim dblChildSales As Double
        Dim dblTotalGrossSales As Double
        Dim dblNetAdultSales As Double
        Dim dblNetChildSales As Double
        Dim dblTotalNetSales As Double

        strAdultPrice = txtAdultPrice.Text
        strChildPrice = txtChildPrice.Text
        strAdultSold = txtAdultSold.Text
        strChildSold = txtChildSold.Text

        Try
            dblAdultPrice = CDbl(strAdultPrice)
            dblChildPrice = CDbl(strChildPrice)
            intAdultSold = CInt(strAdultSold)
            intChildSold = CInt(strChildSold)

            dblAdultSales = dblAdultPrice * intAdultSold
            dblChildSales = dblChildPrice * intChildSold
            dblTotalGrossSales = dblAdultSales + dblChildSales

            dblNetAdultSales = dblAdultSales * dbl_PERCENT_KEEP
            dblNetChildSales = dblChildSales * dbl_PERCENT_KEEP
            dblTotalNetSales = dblNetAdultSales + dblNetChildSales

            lblGrossAdultSales.Text = dblAdultSales.ToString("C")
            lblGrossChildSales.Text = dblChildSales.ToString("C")
            lblTotalGrossSales.Text = dblTotalGrossSales.ToString("C")
            lblNetAdultSales.Text = dblNetAdultSales.ToString("C")
            lblNetChildSales.Text = dblNetChildSales.ToString("C")
            lblTotalNetSales.Text = dblTotalNetSales.ToString("C")

        Catch ex As Exception
            MessageBox.Show("Aw, common Bubba! Put in numbers", "Bubba Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            btnClear.PerformClick()
        End Try

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdultPrice.Clear()
        txtAdultSold.Clear()
        txtChildPrice.Clear()
        txtChildPrice.Clear()
        txtChildSold.Clear()
        lblGrossAdultSales.Text = String.Empty
        lblGrossChildSales.Text = String.Empty
        lblNetAdultSales.Text = String.Empty
        lblNetChildSales.Text = String.Empty
        lblTotalGrossSales.Text = String.Empty
        lblTotalNetSales.Text = String.Empty
        txtAdultPrice.Focus()

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
