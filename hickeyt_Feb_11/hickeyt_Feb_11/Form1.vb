Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        '     Dimension integer variables for comparison
        Dim intIntA As Integer
        Dim intIntB As Integer

        '     Convert user input to integers and then compare and display appropriate message
        If Integer.TryParse(txtIntA.Text, intIntA) Then
            If Integer.TryParse(txtIntB.Text, intIntB) Then
                If intIntA > intIntB Then
                    lblDisplay.Text = "Value A is greatest."
                ElseIf intIntB > intIntA Then
                    lblDisplay.Text = "Value B is greatest."
                Else
                    lblDisplay.Text = "Value A and Value B are equal."
                End If

                '   Defensive Programming for bad input for Value B
            Else
                lblDisplay.Text = "You must enter an integer for Value B."
            End If

            '   Defensive programming for bad input for Value A
        Else
            lblDisplay.Text = "You must enter an integer for Value A."
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        '   Closes active form when clicking Exit button or pressing the escape key
        Me.Close()

    End Sub
End Class
