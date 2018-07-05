Imports Microsoft.Office.Interop

Module Format

    Public Sub applyFormatting(path As String, filename As String, wsName As String)

        Dim objApp As Excel.Application
        Dim srcBook As Excel._Workbook

        Dim objBooks, srcBooks As Excel.Workbooks
        Dim objSheets, srcSheets As Excel.Sheets
        Dim objSheet, srcSheet As Excel._Worksheet

        Dim objRange, srcRange As Excel.Range
        Dim lastCol As Integer
        Dim lastRow As Integer
        Dim rng As Excel.Range
        Dim SpecifyColumn As String


        objApp = New Excel.Application()
        srcBooks = objApp.Workbooks
        srcBook = srcBooks.Open(path & "\" & filename)

        srcSheets = srcBook.Worksheets
        srcSheet = srcSheets(My.Settings.selectedSheet)

        srcSheet.Range("A1").EntireRow.Insert()

        lastCol = srcSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Column
        lastRow = srcSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row

        SpecifyColumn = InputBox("Rentrer la colonne à ajuster (A=1, B=2, ...). Laisser vide pour appliquer à la feuille complète", "Choisir colonne")


        'For i = 0 To lastRow
        'srcSheet.Rows(i).EntireRow.AutoFit
        'Next

        Progress.Show()


        Progress.ProgressRows.Text = lastRow
        Progress.ProgressColumns.Text = lastCol

        srcSheet.Range(srcSheet.Cells(1, 1), srcSheet.Cells(lastRow, lastCol)).EntireRow.AutoFit()

        If SpecifyColumn = "" Then
            Progress.ProgressBar1.Maximum = lastRow * lastCol
            For Each rng In srcSheet.Range(srcSheet.Cells(1, 1), srcSheet.Cells(lastRow, lastCol))

                If rng.MergeCells Then
                    AutoFitMergedCells(srcSheet.Range(rng.MergeArea.Address), srcSheet)
                End If

                Progress.ProgressColumns.Visible = True
                Progress.ProgressRows.Text = "Ligne " & rng.Row & " de " & lastRow
                Progress.ProgressColumns.Text = "Colonne " & rng.Column & " de " & lastCol

                Progress.ProgressBar1.Increment(1)
                Progress.ProgressPerc.Text = Math.Round(Progress.ProgressBar1.Value / Progress.ProgressBar1.Maximum * 100, 0) & " %"
            Next
        Else
            Progress.ProgressBar1.Maximum = lastRow
            For Each rng In srcSheet.Range(srcSheet.Cells(1, CInt(SpecifyColumn)), srcSheet.Cells(lastRow, CInt(SpecifyColumn)))
                If rng.MergeCells Then
                    AutoFitMergedCells(srcSheet.Range(rng.MergeArea.Address), srcSheet)
                End If

                Progress.ProgressColumns.Visible = False
                Progress.ProgressRows.Text = "Ligne " & rng.Row & " de " & lastRow

                Progress.ProgressBar1.Increment(1)
                Progress.ProgressPerc.Text = Math.Round(Progress.ProgressBar1.Value / Progress.ProgressBar1.Maximum * 100, 0) & " %"
            Next
        End If

        srcSheet.Range("A1").EntireRow.Delete()

        Progress.Hide()

        srcBook.Save()

        objApp.Quit()

        'Clean up a little.
        objRange = Nothing
        objSheet = Nothing
        objSheets = Nothing
        objBooks = Nothing
        srcRange = Nothing
        srcSheet = Nothing
        srcSheets = Nothing
        srcBooks = Nothing

        MsgBox("Formatage appliqué à la feuille " & My.Settings.selectedSheet)


    End Sub


    Public Sub AutoFitMergedCells(oRange As Excel.Range, sh As Excel.Worksheet)

        Dim iPtr As Integer
        Dim oldWidth As Single
        Dim oldZZWidth As Single
        Dim newWidth As Single
        Dim newHeight As Single



        With sh
            oldWidth = 0

            For iPtr = 1 To oRange.Columns.Count
                oldWidth = oldWidth + .Cells(1, oRange.Column + iPtr - 1).ColumnWidth
            Next iPtr

            oldWidth = .Cells(1, oRange.Column).ColumnWidth + .Cells(1, oRange.Column + 1).ColumnWidth
            oRange.MergeCells = False
            newWidth = Len(.Cells(oRange.Row, oRange.Column).Value)
            oldZZWidth = .Range("A1").ColumnWidth
            .Range("A1").Value = Left(.Cells(oRange.Row, oRange.Column).Value, newWidth)
            .Range("A1").WrapText = True
            .Columns("A").ColumnWidth = oldWidth
            .Rows("1").EntireRow.AutoFit
            newHeight = .Rows("1").RowHeight / oRange.Rows.Count
            .Rows(CStr(oRange.Row) & ":" & CStr(oRange.Row + oRange.Rows.Count - 1)).RowHeight = newHeight
            oRange.MergeCells = True
            oRange.WrapText = True
            .Range("A1").ClearContents()
            .Range("A1").ColumnWidth = oldZZWidth
        End With
    End Sub


End Module
