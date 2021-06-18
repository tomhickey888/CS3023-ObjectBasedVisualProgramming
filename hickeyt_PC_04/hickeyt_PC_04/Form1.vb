Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strRunner1, strRunner2, strRunner3 As String
        Dim strFirst, strSecond, strThird As String
        Dim intTime1, intTime2, intTime3 As Integer

        If txtRunner1.Text = String.Empty OrElse _
            txtRunner2.Text = String.Empty OrElse _
            txtRunner3.Text = String.Empty OrElse _
            txtTime1.Text = String.Empty OrElse _
            txtTime2.Text = String.Empty OrElse _
            txtTime3.Text = String.Empty Then

            MessageBox.Show("Not all fields are completed", "Input Error")

        Else
            strRunner1 = txtRunner1.Text
            strRunner2 = txtRunner2.Text
            strRunner3 = txtRunner3.Text

            If Integer.TryParse(txtTime1.Text, intTime1) AndAlso _
                intTime1 > 0 Then

                If Integer.TryParse(txtTime2.Text, intTime2) AndAlso _
                intTime2 > 0 Then

                    If Integer.TryParse(txtTime3.Text, intTime3) AndAlso _
                        intTime3 > 0 Then

                        If intTime1 < intTime2 Then
                            If intTime2 < intTime3 Then
                                strFirst = strRunner1
                                strSecond = strRunner2
                                strThird = strRunner3

                            ElseIf intTime1 < intTime3 Then
                                strFirst = strRunner1
                                strSecond = strRunner3
                                strSecond = strRunner2

                            Else
                                strFirst = strRunner3
                                strSecond = strRunner1
                                strThird = strRunner2

                            End If

                        ElseIf intTime2 < intTime1 Then
                            If intTime1 < intTime3 Then
                                strFirst = strRunner2
                                strSecond = strRunner1
                                strThird = strRunner3

                            Else
                                If intTime2 < intTime3 Then
                                    strFirst = strRunner2
                                    strSecond = strRunner3
                                    strThird = strRunner1

                                Else
                                    strFirst = strRunner3
                                    strSecond = strRunner2
                                    strThird = strRunner1

                                End If
                            End If

                        Else
                            MessageBox.Show("The time for Runner 3 must be a positive integer", "Input Error")
                            txtTime3.Text = String.Empty
                            txtTime3.Focus()

                        End If

                    Else
                        MessageBox.Show("The time for Runner 2 must be a positive integer", "Input Error")
                        txtTime2.Text = String.Empty
                        txtTime2.Focus()

                    End If

            Else
                    MessageBox.Show("The time for Runner 1 must be a positive integer", "Input Error")
                    txtTime1.Text = String.Empty
                    txtTime1.Focus()

            End If

            End If

        End If

        lblFirst.Text = strFirst
        lblSecond.Text = strSecond
        lblThird.Text = strThird

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRunner1.Text = String.Empty
        txtRunner2.Text = String.Empty
        txtRunner3.Text = String.Empty
        txtTime1.Text = String.Empty
        txtTime2.Text = String.Empty
        txtTime3.Text = String.Empty
        lblFirst.Text = String.Empty
        lblSecond.Text = String.Empty
        lblThird.text = String.Empty
        txtRunner1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
