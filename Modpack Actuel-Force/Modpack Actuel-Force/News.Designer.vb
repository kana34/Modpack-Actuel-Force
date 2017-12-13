<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class News
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(News))
        Me.Menu_home = New System.Windows.Forms.Panel()
        Me.Menu_mods = New System.Windows.Forms.Panel()
        Me.Bouton_close = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Menu_home
        '
        Me.Menu_home.BackColor = System.Drawing.Color.Transparent
        Me.Menu_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_home.Location = New System.Drawing.Point(1, 2)
        Me.Menu_home.Name = "Menu_home"
        Me.Menu_home.Size = New System.Drawing.Size(135, 59)
        Me.Menu_home.TabIndex = 3
        '
        'Menu_mods
        '
        Me.Menu_mods.BackColor = System.Drawing.Color.Transparent
        Me.Menu_mods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_mods.Location = New System.Drawing.Point(275, 2)
        Me.Menu_mods.Name = "Menu_mods"
        Me.Menu_mods.Size = New System.Drawing.Size(135, 59)
        Me.Menu_mods.TabIndex = 4
        '
        'Bouton_close
        '
        Me.Bouton_close.BackColor = System.Drawing.Color.Transparent
        Me.Bouton_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_close.Location = New System.Drawing.Point(464, 33)
        Me.Bouton_close.Name = "Bouton_close"
        Me.Bouton_close.Size = New System.Drawing.Size(30, 30)
        Me.Bouton_close.TabIndex = 12
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 96)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(476, 303)
        Me.WebBrowser1.TabIndex = 13
        '
        'News
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Bouton_close)
        Me.Controls.Add(Me.Menu_mods)
        Me.Controls.Add(Me.Menu_home)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "News"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "News"
        Me.TransparencyKey = System.Drawing.Color.LightCoral
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Menu_home As Panel
    Friend WithEvents Menu_mods As Panel
    Friend WithEvents Bouton_close As Panel
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
