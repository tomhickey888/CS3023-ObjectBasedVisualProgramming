Public Class Form1

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        lblName.Visible = True
        lblStreet.Visible = True
        lblCityStateZip.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
