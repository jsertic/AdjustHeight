Imports Microsoft.Office.Interop

Public Class Sheets
    Private Sub SelectSheet_Click(sender As Object, e As EventArgs) Handles SelectSheet.Click

        'For Each ws As String In ListBox1.SelectedItems

        My.Settings.selectedSheet = ListBox1.SelectedItem

        'Next

        Format.applyFormatting(My.Settings.selectedPath, My.Settings.SelectedWorkbook, My.Settings.selectedSheet)

        Me.Hide()

    End Sub

    Private Sub Sheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getSheets(My.Settings.selectedPath, My.Settings.SelectedWorkbook)

    End Sub


    Private Sub getSheets(path As String, filename As String)

        Dim objApp As Excel.Application
        Dim srcBook As Excel._Workbook
        Dim srcBooks As Excel.Workbooks

        objApp = New Excel.Application()
        srcBooks = objApp.Workbooks
        srcBook = srcBooks.Open(path & "\" & filename)

        Dim ws As Excel.Worksheet

        For Each ws In srcBook.Worksheets

            ListBox1.Items.Add(ws.Name)

        Next

        objApp.Quit()

    End Sub

End Class