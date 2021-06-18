Public Class Form1

    Dim intTopIncrement As Integer = 1
    Dim intLeftIncrement As Integer = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblThing.Top = lblThing.Top + intTopIncrement
        lblThing.Left = lblThing.Left + intLeftIncrement
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblThing.Top = 12
        lblThing.Left = 9
        intLeftIncrement = 1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFaster_Click(sender As Object, e As EventArgs) Handles btnFaster.Click
        If Timer1.Interval > 11 Then
            Timer1.Interval = Timer1.Interval - 10
        Else
            Timer1.Interval = 1
        End If
    End Sub

    Private Sub btnSlower_Click(sender As Object, e As EventArgs) Handles btnSlower.Click
        If Timer1.Interval < 64766 Then
            Timer1.Interval = Timer1.Interval + 10
        Else
            Timer1.Interval = 64767
        End If
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        intLeftIncrement += 10
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        If intLeftIncrement > 11 Then
            intLeftIncrement -= 10
        Else
            intLeftIncrement = 1
        End If
    End Sub
End Class
