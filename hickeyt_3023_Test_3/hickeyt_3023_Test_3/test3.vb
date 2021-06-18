Imports System.IO
Module test3
    Public Const MAX_ARRAY As Integer = 50
    Public intNumbers(MAX_ARRAY) As Integer
    Public intCounter As Integer = 0


    Sub GetData(strFileName)
        Dim strNumber As String
        Dim inputFile As StreamReader

        Try
            inputFile = File.OpenText(strFileName)

            For i As Integer = 0 To MAX_ARRAY
                If Not inputFile.Peek = -1 Then
                    strNumber = inputFile.ReadLine
                    intNumbers(i) = CInt(strNumber)
                    intCounter = intCounter + 1

                End If
            Next

            inputFile.Close()

        Catch ex As Exception
            MessageBox.Show("Error opening the file.")
        End Try

    End Sub

    Sub WriteData(strFileName)
        Dim outputFile As StreamWriter

        Try
            outputFile = File.CreateText(strFileName)

            outputFile.WriteLine("Tom Hickey")
            outputFile.WriteLine("The sum is " & sum())
            outputFile.WriteLine("The average is " & average())

            For i As Integer = intCounter - 1 To 0 Step -1
                outputFile.WriteLine(intNumbers(i))
            Next

            outputFile.Close()

        Catch ex As Exception
            MessageBox.Show("Error creating the file.")
        End Try

    End Sub

    Function sum() As Integer
        Dim intAcc As Integer

        For i As Integer = 0 To intNumbers.Length - 1
            intAcc = intAcc + intNumbers(i)
        Next

        Return intAcc

    End Function

    Function average() As Single
        Dim dblAvg As Double

        dblAvg = sum() / intCounter

        Return dblAvg

    End Function
End Module
