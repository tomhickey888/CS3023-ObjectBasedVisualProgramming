Public Class GradeCalculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strName, strScores, strGrades As String
        Dim intScores, intGrades, intAcc As Integer
        Dim decAverage As Decimal
        Dim charGrade As Char

        strName = InputBox("Enter the student's name", "Student Name")

        If strName = String.Empty Then
            MessageBox.Show("Name was empty, please try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            lstDisplay.Items.Add(strName)

            strScores = InputBox("Enter the number of scores to average for " & strName, "Number of Scores")

            If Integer.TryParse(strScores, intScores) AndAlso intScores > 0 Then
                Dim intCounter As Integer

                For intCounter = 1 To intScores
                    strGrades = InputBox("Enter grade " & intCounter.ToString & " for " & strName, "Grade " & intCounter.ToString & " Entry")

                    While Not Integer.TryParse(strGrades, intGrades) OrElse intGrades < 0 OrElse intGrades > 100
                        strGrades = InputBox("Scores must be integers between 0 and 100 inclusive")
                    End While

                    lstDisplay.Items.Add("Score " & intCounter.ToString & ":  " & intGrades.ToString)

                    intAcc += intGrades

                Next
                lstDisplay.Items.Add(" ")
                lstDisplay.Items.Add("Total Points: " & intAcc.ToString)
                lstDisplay.Items.Add("Total Points Possible: " & (intAcc * 100).ToString)
                lstDisplay.Items.Add(" ")

                decAverage = intAcc / intScores

                lstDisplay.Items.Add("Final point average:  " & decAverage.ToString("n2"))

                If decAverage >= 90 Then
                    charGrade = "A"

                ElseIf decAverage >= 80 Then
                    charGrade = "B"

                ElseIf decAverage >= 70 Then
                    charGrade = "C"

                ElseIf decAverage >= 60 Then
                    charGrade = "D"

                Else
                    charGrade = "F"

                End If

                lstDisplay.Items.Add("Final grade:  " & charGrade)
                lstDisplay.Items.Add(" ")
                lstDisplay.Items.Add(" ")

            Else
                MessageBox.Show("The number of scores must be an integer greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lstDisplay.Items.Clear()

            End If





        End If



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
