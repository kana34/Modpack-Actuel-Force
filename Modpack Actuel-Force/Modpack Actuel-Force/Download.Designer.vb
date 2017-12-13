<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download
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
        Me.info_install = New System.Windows.Forms.GroupBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.pourcentage = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        Me.info_install.SuspendLayout()
        Me.SuspendLayout()
        '
        'info_install
        '
        Me.info_install.BackColor = System.Drawing.Color.White
        Me.info_install.Controls.Add(Me.ProgressBar)
        Me.info_install.Controls.Add(Me.pourcentage)
        Me.info_install.Controls.Add(Me.info)
        Me.info_install.Location = New System.Drawing.Point(25, 70)
        Me.info_install.Name = "info_install"
        Me.info_install.Size = New System.Drawing.Size(384, 78)
        Me.info_install.TabIndex = 4
        Me.info_install.TabStop = False
        Me.info_install.Text = "info install"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(6, 44)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(372, 23)
        Me.ProgressBar.TabIndex = 0
        '
        'pourcentage
        '
        Me.pourcentage.AutoSize = True
        Me.pourcentage.Location = New System.Drawing.Point(351, 28)
        Me.pourcentage.Name = "pourcentage"
        Me.pourcentage.Size = New System.Drawing.Size(27, 13)
        Me.pourcentage.TabIndex = 2
        Me.pourcentage.Text = "90%"
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Location = New System.Drawing.Point(6, 28)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(24, 13)
        Me.info.TabIndex = 1
        Me.info.Text = "info"
        '
        'Download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 160)
        Me.Controls.Add(Me.info_install)
        Me.Name = "Download"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download"
        Me.info_install.ResumeLayout(False)
        Me.info_install.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents info_install As GroupBox
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents pourcentage As Label
    Friend WithEvents info As Label
End Class
