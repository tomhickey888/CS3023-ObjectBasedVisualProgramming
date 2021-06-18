Public Class Form1
    Const dblCConv As Double = 0.556
    Const intCConv As Integer = 32
    Const dblFConv As Double = 1.8
    Const intFConv As Integer = 32

    Private Sub btnConvertF_Click(sender As Object, e As EventArgs) Handles btnConvertF.Click
        Dim intTemp As Integer
        Dim intConvTempF As Integer

        Dim strTemp As String

        strTemp = txtTemp.Text

        Try
            intTemp = CInt(strTemp)

            intConvTempF = dblFConv * intTemp + intFConv

            lblDisplay.Text = intTemp.ToString() & " degrees Celsius converts to " & intConvTempF.ToString() & " degrees Fahrenheit."

        Catch ex As Exception
            MessageBox.Show("Aw, common Bubba... Put in whole numbers for the temperature!", "Bubba Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            btnClear.PerformClick()
        End Try

    End Sub

    Private Sub btnConvertC_Click(sender As Object, e As EventArgs) Handles btnConvertC.Click
        Dim intTemp As Integer
        Dim intConvTempC As Integer

        Dim strTemp As String

        strTemp = txtTemp.Text

        Try
            intTemp = CInt(strTemp)

            intConvTempC = (intTemp - intCConv) * dblCConv

            lblDisplay.Text = intTemp.ToString() & " degrees Fahrenheit converts to " & intConvTempC.ToString() & " degrees Celsuis."

        Catch ex As Exception
            MessageBox.Show("Aw, common Bubba... Put in whole numbers for the temperature!", "Bubba Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            btnClear.PerformClick()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTemp.Clear()
        lblDisplay.Text = String.Empty
        txtTemp.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
