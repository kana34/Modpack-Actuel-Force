Public Class InfoMods
    Dim nom As String

    Private Sub InfoMods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nom = My.Settings.nom_checkbox
        WebBrowser1.Navigate("http://actuel-force.ovh/jeux/wot/modpack/mods/info_mods/Info_mods.php?nom=" & nom)
    End Sub
End Class