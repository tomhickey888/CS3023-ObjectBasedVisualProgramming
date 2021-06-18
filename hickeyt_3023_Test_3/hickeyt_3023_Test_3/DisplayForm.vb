Public Class frmDisplayForm

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstDisplay.Items.Add("Tom Hickey")

        For i As Integer = 0 To intNumbers.Length - 1
            If Not intNumbers(i) = 0 Then
                lstDisplay.Items.Add(intNumbers(i))
            End If

        Next

        lstDisplay.Items.Add("The sum is " & sum())
        lstDisplay.Items.Add("The average is " & average())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class