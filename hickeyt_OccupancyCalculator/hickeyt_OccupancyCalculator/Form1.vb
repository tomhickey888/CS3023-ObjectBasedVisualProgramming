Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strHotelName, strRoomsPerFloor, strOccupiedPerFloor, strNumberOfFloors As String
        Dim intNumberOfFloors, intRoomsPerFloor, intOccupiedPerFloor As Integer
        Dim intTotalRooms As Integer = 0
        Dim intTotalOccupied As Integer = 0
        Dim dblFloorRate, dblOverallRate As Double

        strHotelName = InputBox("Please enter the name of the hotel", "Hotel Name")

        While strHotelName = String.Empty
            strHotelName = InputBox("The name of the hotel must have a value", "Name Error")
        End While

        lstDisplay.Items.Add("   Welcome to " & strHotelName)
        lstDisplay.Items.Add("Floor     Rooms     Occupied     Rate")

        strNumberOfFloors = InputBox("Please enter the number of floors", "Number of Floors")

        While Not Integer.TryParse(strNumberOfFloors, intNumberOfFloors) OrElse _
            intNumberOfFloors < 0 OrElse intNumberOfFloors > 25
            strNumberOfFloors = InputBox("The number of floors must be an integer between 0 and 25, inclusive", "Number of Floors Error")
        End While

        Dim floor As Integer
        For floor = 1 To intNumberOfFloors

            strRoomsPerFloor = InputBox("Please enter the number of rooms on Floor " & floor.ToString(), "Rooms on Floor " & floor.ToString())
            While Not Integer.TryParse(strRoomsPerFloor, intRoomsPerFloor) OrElse _
                intRoomsPerFloor < 0 OrElse intRoomsPerFloor > 30
                strRoomsPerFloor = InputBox("The number of rooms on Floor " & floor.ToString() & " must be an integer between 0 and 30, inclusive", "Rooms on Floor " & floor.ToString & " error")
            End While

            strOccupiedPerFloor = InputBox("How many of the " & intRoomsPerFloor.ToString() & " on Floor " & floor.ToString() & " are occupied?")
            While Not Integer.TryParse(strOccupiedPerFloor, intOccupiedPerFloor) OrElse intOccupiedPerFloor < 0 OrElse intOccupiedPerFloor > intRoomsPerFloor
                strOccupiedPerFloor = InputBox("The number of occupied rooms must be an integer between 0 and " & intRoomsPerFloor.ToString() & ", inclusive", "Occupied rooms error")
            End While

            dblFloorRate = intOccupiedPerFloor / intRoomsPerFloor

            Dim line As String = "  " & floor.ToString() & "            " & intRoomsPerFloor & "               " & intOccupiedPerFloor.ToString() & "              " & dblFloorRate.ToString("P0")

            lstDisplay.Items.Add(line)
            intTotalRooms += intRoomsPerFloor
            intTotalOccupied += intOccupiedPerFloor

        Next

        dblOverallRate = intTotalOccupied / intTotalRooms
        lblTotalRooms.Text = intTotalRooms.ToString()
        lblTotalOccupied.Text = intTotalOccupied.ToString()
        lblOverallOccupancy.Text = (dblOverallRate.ToString("P0"))

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()

        lblTotalRooms.Text = String.Empty
        lblTotalOccupied.Text = String.Empty
        lblOverallOccupancy.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
