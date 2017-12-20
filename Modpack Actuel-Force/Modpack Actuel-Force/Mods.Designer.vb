<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mods))
        Me.Bouton_install_mods = New System.Windows.Forms.Panel()
        Me.Menu_news = New System.Windows.Forms.Panel()
        Me.Menu_home = New System.Windows.Forms.Panel()
        Me.Bouton_close = New System.Windows.Forms.Panel()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Bouton_desinstall_mods = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Bouton_install_mods
        '
        Me.Bouton_install_mods.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_install_mods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_install_mods.Location = New System.Drawing.Point(16, 173)
        Me.Bouton_install_mods.Name = "Bouton_install_mods"
        Me.Bouton_install_mods.Size = New System.Drawing.Size(250, 76)
        Me.Bouton_install_mods.TabIndex = 5
        '
        'Menu_news
        '
        Me.Menu_news.BackColor = System.Drawing.Color.Transparent
        Me.Menu_news.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_news.Location = New System.Drawing.Point(139, 2)
        Me.Menu_news.Name = "Menu_news"
        Me.Menu_news.Size = New System.Drawing.Size(135, 59)
        Me.Menu_news.TabIndex = 6
        '
        'Menu_home
        '
        Me.Menu_home.BackColor = System.Drawing.Color.Transparent
        Me.Menu_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_home.Location = New System.Drawing.Point(1, 2)
        Me.Menu_home.Name = "Menu_home"
        Me.Menu_home.Size = New System.Drawing.Size(135, 59)
        Me.Menu_home.TabIndex = 7
        '
        'Bouton_close
        '
        Me.Bouton_close.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_close.Location = New System.Drawing.Point(465, 33)
        Me.Bouton_close.Name = "Bouton_close"
        Me.Bouton_close.Size = New System.Drawing.Size(30, 30)
        Me.Bouton_close.TabIndex = 12
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.White
        Me.GroupBox.Location = New System.Drawing.Point(292, 143)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(171, 263)
        Me.GroupBox.TabIndex = 13
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Mods"
        '
        'Bouton_desinstall_mods
        '
        Me.Bouton_desinstall_mods.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_desinstall_mods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_desinstall_mods.Location = New System.Drawing.Point(16, 277)
        Me.Bouton_desinstall_mods.Name = "Bouton_desinstall_mods"
        Me.Bouton_desinstall_mods.Size = New System.Drawing.Size(250, 78)
        Me.Bouton_desinstall_mods.TabIndex = 14
        '
        'mods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Bouton_desinstall_mods)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Bouton_close)
        Me.Controls.Add(Me.Menu_home)
        Me.Controls.Add(Me.Menu_news)
        Me.Controls.Add(Me.Bouton_install_mods)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mods"
        Me.TransparencyKey = System.Drawing.Color.LightCoral
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bouton_install_mods As Panel
    Friend WithEvents Menu_news As Panel
    Friend WithEvents Menu_home As Panel
    Friend WithEvents Bouton_close As Panel
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Bouton_desinstall_mods As Panel
End Class
