Imports System.IO

Public Class Form1
    Public strFileName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        If dOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFileName = dOpenFile.FileName
            GetData(strFileName)
        Else
            MessageBox.Show("You did not select a file to read from.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        frmDisplayForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        If dSaveFileAs.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFileName = dSaveFileAs.FileName
            WriteData(strFileName)
        Else
            MessageBox.Show("You did not select a file to write to.")
        End If
    End Sub
End Class
