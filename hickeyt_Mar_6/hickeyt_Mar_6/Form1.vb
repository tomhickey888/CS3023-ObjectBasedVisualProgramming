Public Class Form1
    Const decOIL_CHANGE As Decimal = 26
    Const decLUBE_JOB As Decimal = 18
    Const decRADIATOR_FLUSH As Decimal = 30
    Const decTRANSMISSION_FLUSH As Decimal = 80
    Const decINSPECTION As Decimal = 15
    Const decMUFFLER_REPLACEMENT As Decimal = 100
    Const decTIRE_ROTATION As Decimal = 20
    Const decTAX_RATE As Decimal = 0.06

    Function OilLubeCharges() As Decimal
        Dim charges As Decimal

        If chkOil.Checked Then
            charges += decOIL_CHANGE
        End If

        If chkLube.Checked Then
            charges += decLUBE_JOB
        End If

        Return charges

    End Function

    Function FlushCharges() As Decimal
        Dim charges As Decimal

        If chkRad.Checked Then
            charges += decRADIATOR_FLUSH
        End If

        If chkTrans.Checked Then
            charges += decTRANSMISSION_FLUSH
        End If

        Return charges

    End Function

    Function MiscCharges() As Decimal
        Dim charges As Decimal

        If chkInspection.Checked Then
            charges += decINSPECTION
        End If

        If chkMuffler.Checked Then
            charges += decMUFFLER_REPLACEMENT
        End If

        If chkTire.Checked Then
            charges += decTIRE_ROTATION
        End If

        Return charges

    End Function

    Function OtherCharges() As Decimal
        Dim strParts As String
        Dim strLabor As String
        Dim decParts As Decimal
        Dim decLabor As Decimal

        strParts = txtParts.Text
        If Not Decimal.TryParse(strParts, decParts) Then
            MessageBox.Show("The parts must be a non-negative numeric value", "PARTS ERROR")
            txtParts.Clear()
            txtParts.Focus()
        End If

        strLabor = txtLabor.Text
        If Not Decimal.TryParse(strLabor, decLabor) Then
            MessageBox.Show("The labor must be a non-negative numeric value", "LABOR ERROR")
            txtLabor.Clear()
            txtParts.Focus()
        End If

        Return decParts + decLabor

    End Function

    Private Sub btnCaclulate_Click(sender As Object, e As EventArgs) Handles btnCaclulate.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        chkO()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
