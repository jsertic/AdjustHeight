<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sheets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SelectSheet = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(459, 225)
        Me.ListBox1.TabIndex = 0
        '
        'SelectSheet
        '
        Me.SelectSheet.Location = New System.Drawing.Point(479, 138)
        Me.SelectSheet.Name = "SelectSheet"
        Me.SelectSheet.Size = New System.Drawing.Size(91, 54)
        Me.SelectSheet.TabIndex = 1
        Me.SelectSheet.Text = "Sélectionner feuille"
        Me.SelectSheet.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(479, 199)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(91, 39)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Annuler"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Sheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 262)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.SelectSheet)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Sheets"
        Me.Text = "Choisir la feuille"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SelectSheet As Button
    Friend WithEvents Cancel As Button
End Class
