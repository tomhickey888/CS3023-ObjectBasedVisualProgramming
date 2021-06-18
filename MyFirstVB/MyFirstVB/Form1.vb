Public Class Form1

    Private Sub btnClickHere_Click(sender As Object, e As EventArgs) Handles btnClickHere.Click
        lblDisplay.Visible = False
    End Sub

    Private Sub btnThenClickHere_Click(sender As Object, e As EventArgs) Handles btnThenClickHere.Click
        lblDisplay.Visible = True
    End Sub
End Class
