Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Named constants for Overhead and Profit rates
        Const dblOverheadRate As Double = 0.6
        Const dblProfitRate As Double = 0.25

        ' Dimension variables for user input
        Dim strItem, strPrice As String

        ' Dimension variables for calculating Prices/Markups
        Dim dblPrice, dblOverheadPrice, dblProfitPrice, dblTotalMarkup, dblTotalPrice As Double

        ' Get user input for the item name
        strItem = InputBox("Please enter the name of the item:", "Item Name Entry")

        ' Defensive programming for item name input
        If strItem = String.Empty Then
            MessageBox.Show("Please enter a name for the item.", "Item Name Entry Error")
        Else
            lstDisplay.Items.Add("Item name: " & strItem)

            ' Get user input for item wholesale price
            strPrice = InputBox("Please enter the wholesale price of the item:", "Wholesale Price Entry")

            ' Defensive programming for item wholesale price
            If Double.TryParse(strPrice, dblPrice) AndAlso dblPrice > 0 Then
                lstDisplay.Items.Add("Wholesale Price of " & strItem & ": " & dblPrice.ToString("c"))

                ' Calculate the overhead markup, the profit markup, the total markup, and the total item price
                dblOverheadPrice = dblPrice * dblOverheadRate
                dblProfitPrice = dblPrice * dblProfitRate
                dblTotalMarkup = dblOverheadPrice + dblProfitPrice
                dblTotalPrice = dblPrice + dblOverheadPrice + dblProfitPrice

                ' Display the calculated markups/price
                With lstDisplay
                    .Items.Add(" ")
                    .Items.Add("Overhead Markup: " & dblOverheadPrice.ToString("c"))
                    .Items.Add("Profit Markup: " & dblProfitPrice.ToString("c"))
                    .Items.Add("Total Markup: " & dblTotalMarkup.ToString("c"))
                    .Items.Add(" ")
                    .Items.Add("Total Sales Price of " & strItem & ": " & dblTotalPrice.ToString("c"))
                End With

            Else
                MessageBox.Show("Please enter the price as a number greater than 0.", "Wholesale Price Entry Error")
                lstDisplay.Items.Clear()

            End If
            
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clears the ListBox
        lstDisplay.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Closes the form
        Me.Close()

    End Sub
End Class
