<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.FolderLocation = New System.Windows.Forms.TextBox()
        Me.FolderBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FolderLocation
        '
        Me.FolderLocation.Location = New System.Drawing.Point(12, 12)
        Me.FolderLocation.Name = "FolderLocation"
        Me.FolderLocation.Size = New System.Drawing.Size(408, 20)
        Me.FolderLocation.TabIndex = 0
        '
        'FolderBrowse
        '
        Me.FolderBrowse.Location = New System.Drawing.Point(426, 10)
        Me.FolderBrowse.Name = "FolderBrowse"
        Me.FolderBrowse.Size = New System.Drawing.Size(75, 23)
        Me.FolderBrowse.TabIndex = 1
        Me.FolderBrowse.Text = "Browse"
        Me.FolderBrowse.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(407, 225)
        Me.ListBox1.TabIndex = 2
        '
        'Apply
        '
        Me.Apply.Location = New System.Drawing.Point(427, 169)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(75, 66)
        Me.Apply.TabIndex = 3
        Me.Apply.Text = "Apply Formating"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(426, 241)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Close"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 274)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.FolderBrowse)
        Me.Controls.Add(Me.FolderLocation)
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderLocation As TextBox
    Friend WithEvents FolderBrowse As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Apply As Button
    Friend WithEvents Cancel As Button
End Class
