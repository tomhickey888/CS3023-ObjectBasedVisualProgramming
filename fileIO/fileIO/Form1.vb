Imports System.IO

Public Class Form1

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim numbersFile As StreamWriter
        Dim strNumber As String

        Try
            numbersFile = File.CreateText("numbers.txt")
            strNumber = InputBox("Enter a positive integer, use a negative one to quit", "Enter numbers for a new file")

            While CInt(strNumber) >= 0
                numbersFile.WriteLine(strNumber)
                strNumber = InputBox("Enter a positive integer, use a negative one to quit", "Enter numbers for a new file")
            End While
            numbersFile.Close()
        Catch ex As Exception
            MessageBox.Show("Could not open the file or non-integer entered", "File Write Error")
        End Try
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim numbersFile As StreamWriter
        Dim strNumber As String

        Try
            numbersFile = File.AppendText("numbers.txt")
            strNumber = InputBox("Enter a positive integer, use a negative one to quit", "Append numbers in the file")

            While CInt(strNumber) >= 0
                numbersFile.WriteLine(strNumber)
                strNumber = InputBox("Enter a positive integer, use a negative one to quit", "Append numbers in the file")
            End While
            numbersFile.Close()
        Catch ex As Exception
            MessageBox.Show("Could not open the file or non-integer entered", "File Append Error")
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim inputFile As StreamReader
        Dim strLine As String

        Try
            inputFile = File.OpenText("numbers.txt")

            Do Until inputFile.EndOfStream
                strLine = inputFile.ReadLine()
                Integer.TryParse(strLine, intTheNumbers(intCounter))
                intCounter += 1
                lstDisplay.Items.Add(strLine)
            Loop
            inputFile.Close()
        Catch ex As Exception
            MessageBox.Show("Could not open the file", "File Read Error")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        For counter = 0 To intCounter - 1
            lstDisplay.Items.Add(intTheNumbers(counter))
        Next
    End Sub
End Class
