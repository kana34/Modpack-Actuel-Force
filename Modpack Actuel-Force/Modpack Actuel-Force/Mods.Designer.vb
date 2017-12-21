<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mods
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mods))
        Me.Bouton_install_mods = New System.Windows.Forms.Panel()
        Me.Menu_news = New System.Windows.Forms.Panel()
        Me.Menu_home = New System.Windows.Forms.Panel()
        Me.Bouton_close = New System.Windows.Forms.Panel()
        Me.Bouton_desinstall_mods = New System.Windows.Forms.Panel()
        Me.PanelCheckboxList = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bouton_install_mods
        '
        Me.Bouton_install_mods.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_install_mods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_install_mods.Location = New System.Drawing.Point(17, 212)
        Me.Bouton_install_mods.Name = "Bouton_install_mods"
        Me.Bouton_install_mods.Size = New System.Drawing.Size(210, 82)
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
        'Bouton_desinstall_mods
        '
        Me.Bouton_desinstall_mods.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_desinstall_mods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_desinstall_mods.Location = New System.Drawing.Point(17, 322)
        Me.Bouton_desinstall_mods.Name = "Bouton_desinstall_mods"
        Me.Bouton_desinstall_mods.Size = New System.Drawing.Size(210, 78)
        Me.Bouton_desinstall_mods.TabIndex = 14
        '
        'PanelCheckboxList
        '
        Me.PanelCheckboxList.AutoScroll = True
        Me.PanelCheckboxList.BackColor = System.Drawing.Color.White
        Me.PanelCheckboxList.Location = New System.Drawing.Point(247, 92)
        Me.PanelCheckboxList.Name = "PanelCheckboxList"
        Me.PanelCheckboxList.Size = New System.Drawing.Size(226, 298)
        Me.PanelCheckboxList.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(177, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'mods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelCheckboxList)
        Me.Controls.Add(Me.Bouton_desinstall_mods)
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
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bouton_install_mods As Panel
    Friend WithEvents Menu_news As Panel
    Friend WithEvents Menu_home As Panel
    Friend WithEvents Bouton_close As Panel
    Friend WithEvents Bouton_desinstall_mods As Panel
    Friend WithEvents PanelCheckboxList As Panel
    Friend WithEvents Label1 As Label
End Class
