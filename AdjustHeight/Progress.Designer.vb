<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Progress
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressPerc = New System.Windows.Forms.Label()
        Me.ProgressRows = New System.Windows.Forms.Label()
        Me.ProgressColumns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 13)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(346, 37)
        Me.ProgressBar1.TabIndex = 0
        '
        'ProgressPerc
        '
        Me.ProgressPerc.AutoSize = True
        Me.ProgressPerc.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPerc.Location = New System.Drawing.Point(168, 26)
        Me.ProgressPerc.Name = "ProgressPerc"
        Me.ProgressPerc.Size = New System.Drawing.Size(24, 13)
        Me.ProgressPerc.TabIndex = 1
        Me.ProgressPerc.Text = "0 %"
        Me.ProgressPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressRows
        '
        Me.ProgressRows.AutoSize = True
        Me.ProgressRows.Location = New System.Drawing.Point(10, 61)
        Me.ProgressRows.Name = "ProgressRows"
        Me.ProgressRows.Size = New System.Drawing.Size(39, 13)
        Me.ProgressRows.TabIndex = 2
        Me.ProgressRows.Text = "Label1"
        '
        'ProgressColumns
        '
        Me.ProgressColumns.AutoSize = True
        Me.ProgressColumns.Location = New System.Drawing.Point(10, 74)
        Me.ProgressColumns.Name = "ProgressColumns"
        Me.ProgressColumns.Size = New System.Drawing.Size(39, 13)
        Me.ProgressColumns.TabIndex = 3
        Me.ProgressColumns.Text = "Label2"
        '
        'Progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 99)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressColumns)
        Me.Controls.Add(Me.ProgressRows)
        Me.Controls.Add(Me.ProgressPerc)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Progress"
        Me.Text = "Formatage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressPerc As Label
    Friend WithEvents ProgressRows As Label
    Friend WithEvents ProgressColumns As Label
End Class
