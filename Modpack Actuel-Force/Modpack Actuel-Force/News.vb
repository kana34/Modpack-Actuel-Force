Public Class News
    Private Sub News_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://actuel-force.ovh/jeux/wot/modpack/news/news.php")
    End Sub
    '--- Onglet ---
    '--------------
    Private Sub Menu_home_Click(sender As Object, e As EventArgs) Handles Menu_home.Click
        Close()
        Modpack.Show()
    End Sub
    Private Sub Menu_mods_Click(sender As Object, e As EventArgs) Handles Menu_mods.Click
        Close()
        mods.Show()
    End Sub

    '--- Bouton ---
    '--------------
    Private Sub Bouton_close_Click(sender As Object, e As EventArgs) Handles Bouton_close.Click
        Modpack.Close()
    End Sub
End Class