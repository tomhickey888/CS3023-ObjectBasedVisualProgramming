Imports System.IO

Public Class Form1
    Private strFileName As String = String.Empty
    Dim blnIsChanged As Boolean = False

    Sub ClearDocument()

    End Sub

    Sub OpenDocument()
        Dim inputFile As StreamReader

    End Sub

    Sub SaveDocument()
        Dim outputFile As StreamWriter
        Try
            outputFile = FileAttr.CreateText(strFileName)
            outputFile.Write(txtDisplay.Text)
            outputFile.Close()
            blnIsChanged = False
        Catch ex As Exception
            MessageBox.Show("Error saving file")
        End Try
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        If strFileName = String.Empty Then
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFileName = sfdSaveFile.Filename
                SaveDocument()
            End If
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Simple Text Editor version 1.0")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If blnIsChanged Then
            If MessageBox.Show("The current document is not saved. " &
                               "Do you want to discard your changes?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click

    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click

    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click

    End Sub
End Class
