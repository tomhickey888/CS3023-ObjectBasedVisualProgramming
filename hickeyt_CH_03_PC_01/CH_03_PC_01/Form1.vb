Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strMiles As String
        Dim strGallons As String

        Dim intMiles As Integer
        Dim intGallons As Integer

        Dim dblMPG As Double

        strMiles = txtMiles.Text
        strGallons = txtGallons.Text

        Try
            intMiles = CInt(strMiles)
            intGallons = CInt(strGallons)

            dblMPG = intMiles / intGallons

            lblDisplay.Text = dblMPG.ToString("n2")
        Catch ex As Exception
            MessageBox.Show("Aw, common Bubba! Put in numbers", "Bubba Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            btnClear.PerformClick()

        End Try

        '    lblDisplay.Text = strMiles

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMiles.Clear()
        lblDisplay.Text = String.Empty
        txtGallons.Focus()

    End Sub
End Class
