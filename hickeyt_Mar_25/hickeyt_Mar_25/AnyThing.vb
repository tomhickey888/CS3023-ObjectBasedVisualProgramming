Module AnyThing
    Public theNumbers() As Integer

    Function getValues() As Integer()
        Dim strHowMany As String
        Dim intHowMany As Integer

        Dim strNumber As String
        Dim intNumber As Integer

        strHowMany = InputBox("How many numbers?", "Get Quantity")
        While Not Integer.TryParse(strHowMany, intHowMany)
            MessageBox.Show("That is not a valid number")
            strHowMany = InputBox("How many numbers?", "Get Quantity")
        End While

        Dim intLocal(intHowMany - 1) As Integer

        For i As Integer = 0 To intHowMany - 1
            strNumber = InputBox("Enter a number", "Get Number")
            While Not Integer.TryParse(strNumber, intNumber)
                MessageBox.Show(strNumber & " is not a valid number")
                strNumber = InputBox("Enter a number", "Get Number")
            End While

            intLocal(i) = intNumber
        Next

        Return intLocal
    End Function

    Function getMin(ByVal someNumbers As Integer()) As Integer
        Dim intMin As Integer = someNumbers(0)

        For i As Integer = 1 To someNumbers.Length() - 1
            If intMin > someNumbers(i) Then
                intMin = someNumbers(i)
            End If
        Next

        Return intMin
    End Function

    Function getMax(ByVal someNumbers As Integer()) As Integer
        Dim intMax As Integer = someNumbers(0)

        For i As Integer = 1 To someNumbers.Length() - 1
            If intMax < someNumbers(i) Then
                intMax = someNumbers(i)
            End If
        Next

        Return intMax
    End Function

    Sub displayNumbers()
        Dim intNumberOfItems As Integer = theNumbers.Length - 1

        For i = 0 To intNumberOfItems
            Form1.lstDisplay.Items.Add(theNumbers(i).ToString)
        Next
    End Sub

    Function getAverage(ByVal someNumbers As Integer()) As Decimal
        Dim intAcc As Integer

        For i = 0 To someNumbers.Length - 1
            intAcc += someNumbers(i)
        Next

        Return intAcc / someNumbers.Length
    End Function

End Module
