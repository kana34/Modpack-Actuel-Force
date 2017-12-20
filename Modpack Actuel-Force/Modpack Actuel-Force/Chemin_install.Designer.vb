<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chemin_install
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chemin_install))
        Me.Suivant = New System.Windows.Forms.Panel()
        Me.Parcourir = New System.Windows.Forms.Panel()
        Me.message_verif = New System.Windows.Forms.Label()
        Me.Chemin = New System.Windows.Forms.TextBox()
        Me.dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Suivant
        '
        Me.Suivant.BackColor = System.Drawing.Color.Transparent
        Me.Suivant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Suivant.Location = New System.Drawing.Point(184, 86)
        Me.Suivant.Name = "Suivant"
        Me.Suivant.Size = New System.Drawing.Size(150, 51)
        Me.Suivant.TabIndex = 9
        '
        'Parcourir
        '
        Me.Parcourir.BackColor = System.Drawing.Color.Transparent
        Me.Parcourir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Parcourir.Location = New System.Drawing.Point(12, 86)
        Me.Parcourir.Name = "Parcourir"
        Me.Parcourir.Size = New System.Drawing.Size(150, 51)
        Me.Parcourir.TabIndex = 8
        '
        'message_verif
        '
        Me.message_verif.AutoSize = True
        Me.message_verif.BackColor = System.Drawing.Color.Transparent
        Me.message_verif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_verif.ForeColor = System.Drawing.Color.White
        Me.message_verif.Location = New System.Drawing.Point(16, 41)
        Me.message_verif.Name = "message_verif"
        Me.message_verif.Size = New System.Drawing.Size(213, 13)
        Me.message_verif.TabIndex = 7
        Me.message_verif.Text = "Sélectionnez le chemin d'installation"
        '
        'Chemin
        '
        Me.Chemin.Location = New System.Drawing.Point(16, 57)
        Me.Chemin.Name = "Chemin"
        Me.Chemin.Size = New System.Drawing.Size(314, 20)
        Me.Chemin.TabIndex = 6
        '
        'Chemin_install
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(350, 157)
        Me.Controls.Add(Me.Suivant)
        Me.Controls.Add(Me.Parcourir)
        Me.Controls.Add(Me.message_verif)
        Me.Controls.Add(Me.Chemin)
        Me.Name = "Chemin_install"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dossier installation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Suivant As Panel
    Friend WithEvents Parcourir As Panel
    Friend WithEvents message_verif As Label
    Friend WithEvents Chemin As TextBox
    Friend WithEvents dialog As FolderBrowserDialog
End Class
