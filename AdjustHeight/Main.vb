Imports Microsoft.Office.Interop

Public Class Main



    Private Sub FolderBrowse_Click(sender As Object, e As EventArgs) Handles FolderBrowse.Click

        FolderLocation.Text = FolderMenu(sender, e)

        getExcelFiles()

    End Sub

    Private Function FolderMenu(sender As Object, e As System.EventArgs) As String

        Dim folderbrowser As New FolderBrowserDialog

        On Error GoTo SkipPastSelectedPath

        folderbrowser.SelectedPath = My.Settings.lastPath

SkipPastSelectedPath:

        ' Show the FolderBrowserDialog.
        Dim result As DialogResult = folderbrowser.ShowDialog()

        'If ok has been pressed, set the selectedpath as user settings variable
        If (result = DialogResult.OK) Then
            My.Settings.lastPath = folderbrowser.SelectedPath
            FolderMenu = My.Settings.lastPath
        Else
            FolderMenu = My.Settings.lastPath
        End If
    End Function

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click

        Dim str As String
        str = ""

        My.Settings.selectedPath = FolderLocation.Text
        My.Settings.SelectedWorkbook = ListBox1.SelectedItem.ToString

        Sheets.Show()

        'For Each file As String In ListBox1.SelectedItems

        '    'open the selected Excel file and apply formating
        '    Format.applyFormatting(FolderLocation.Text & "\" & file)

        '    str = str & Environment.NewLine & file
        'Next

        'MsgBox("Formatting applied to: " & str)

    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub getExcelFiles()

        Dim splitFoundFile As String()

        ListBox1.Items.Clear()

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(FolderLocation.Text)

            If Strings.Right(foundFile, 4) = "xlsx" Or Strings.Right(foundFile, 3) = "xls" Then
                splitFoundFile = Split(foundFile, "\")
                ListBox1.Items.Add(splitFoundFile(UBound(splitFoundFile)))
            End If
        Next


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo SkipLoad

        FolderLocation.Text = My.Settings.lastPath

        getExcelFiles()

SkipLoad:

    End Sub


End Class