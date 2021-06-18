Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        theNumbers = getValues()
    End Sub

    Private Sub btnMinMax_Click(sender As Object, e As EventArgs) Handles btnMinMax.Click
        lblMinMax.Text = "The min is " & getMin(theNumbers).ToString() & " and the max is " & getMax(theNumbers).ToString()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        displayNumbers()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMinMax.Text = String.Empty
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        lblMinMax.Text = "The average is " & getAverage(theNumbers).ToString
    End Sub
End Class
