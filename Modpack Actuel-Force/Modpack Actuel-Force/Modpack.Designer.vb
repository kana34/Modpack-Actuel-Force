<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modpack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modpack))
        Me.Menu_news = New System.Windows.Forms.Panel()
        Me.Menu_mods = New System.Windows.Forms.Panel()
        Me.Bouton_close = New System.Windows.Forms.Panel()
        Me.Bouton_lien_forum = New System.Windows.Forms.Panel()
        Me.Bouton_lien_ts3 = New System.Windows.Forms.Panel()
        Me.Bouton_lien_aide = New System.Windows.Forms.Panel()
        Me.Bouton_play = New System.Windows.Forms.Panel()
        Me.Bouton_instal_ts3 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Menu_news
        '
        Me.Menu_news.BackColor = System.Drawing.Color.Transparent
        Me.Menu_news.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_news.Location = New System.Drawing.Point(138, 3)
        Me.Menu_news.Name = "Menu_news"
        Me.Menu_news.Size = New System.Drawing.Size(135, 59)
        Me.Menu_news.TabIndex = 2
        '
        'Menu_mods
        '
        Me.Menu_mods.BackColor = System.Drawing.Color.Transparent
        Me.Menu_mods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_mods.Location = New System.Drawing.Point(276, 3)
        Me.Menu_mods.Name = "Menu_mods"
        Me.Menu_mods.Size = New System.Drawing.Size(135, 59)
        Me.Menu_mods.TabIndex = 3
        '
        'Bouton_close
        '
        Me.Bouton_close.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_close.Location = New System.Drawing.Point(465, 33)
        Me.Bouton_close.Name = "Bouton_close"
        Me.Bouton_close.Size = New System.Drawing.Size(30, 30)
        Me.Bouton_close.TabIndex = 11
        '
        'Bouton_lien_forum
        '
        Me.Bouton_lien_forum.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_lien_forum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_lien_forum.Location = New System.Drawing.Point(353, 166)
        Me.Bouton_lien_forum.Name = "Bouton_lien_forum"
        Me.Bouton_lien_forum.Size = New System.Drawing.Size(133, 68)
        Me.Bouton_lien_forum.TabIndex = 12
        '
        'Bouton_lien_ts3
        '
        Me.Bouton_lien_ts3.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_lien_ts3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_lien_ts3.Location = New System.Drawing.Point(351, 257)
        Me.Bouton_lien_ts3.Name = "Bouton_lien_ts3"
        Me.Bouton_lien_ts3.Size = New System.Drawing.Size(133, 68)
        Me.Bouton_lien_ts3.TabIndex = 13
        '
        'Bouton_lien_aide
        '
        Me.Bouton_lien_aide.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_lien_aide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_lien_aide.Location = New System.Drawing.Point(351, 350)
        Me.Bouton_lien_aide.Name = "Bouton_lien_aide"
        Me.Bouton_lien_aide.Size = New System.Drawing.Size(133, 68)
        Me.Bouton_lien_aide.TabIndex = 14
        '
        'Bouton_play
        '
        Me.Bouton_play.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_play.Location = New System.Drawing.Point(16, 192)
        Me.Bouton_play.Name = "Bouton_play"
        Me.Bouton_play.Size = New System.Drawing.Size(299, 78)
        Me.Bouton_play.TabIndex = 15
        Me.Bouton_play.Visible = False
        '
        'Bouton_instal_ts3
        '
        Me.Bouton_instal_ts3.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_instal_ts3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_instal_ts3.Location = New System.Drawing.Point(16, 294)
        Me.Bouton_instal_ts3.Name = "Bouton_instal_ts3"
        Me.Bouton_instal_ts3.Size = New System.Drawing.Size(299, 78)
        Me.Bouton_instal_ts3.TabIndex = 16
        '
        'Modpack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Bouton_instal_ts3)
        Me.Controls.Add(Me.Bouton_play)
        Me.Controls.Add(Me.Bouton_lien_aide)
        Me.Controls.Add(Me.Bouton_lien_ts3)
        Me.Controls.Add(Me.Bouton_lien_forum)
        Me.Controls.Add(Me.Bouton_close)
        Me.Controls.Add(Me.Menu_mods)
        Me.Controls.Add(Me.Menu_news)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modpack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modpack"
        Me.TransparencyKey = System.Drawing.Color.LightCoral
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Menu_news As Panel
    Friend WithEvents Menu_mods As Panel
    Friend WithEvents Bouton_close As Panel
    Friend WithEvents Bouton_lien_forum As Panel
    Friend WithEvents Bouton_lien_ts3 As Panel
    Friend WithEvents Bouton_lien_aide As Panel
    Friend WithEvents Bouton_play As Panel
    Friend WithEvents Bouton_instal_ts3 As Panel
End Class
