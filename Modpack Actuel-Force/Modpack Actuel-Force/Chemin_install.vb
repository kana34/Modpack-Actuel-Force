Public Class Chemin_install
    Private Sub chemin_install_Load(sender As Object, e As EventArgs) Handles Me.Load
        Suivant.Enabled = False

        message_verif.Text = "Dossier d'installation non trouvé !"
        message_verif.ForeColor = Color.Gold
        Chemin.Text = My.Settings.path_install
    End Sub

    Private Sub install_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Close()
        Modpack.Close()
    End Sub
    Private Sub Parcourir_Click(sender As Object, e As EventArgs) Handles Parcourir.Click
        dialog.RootFolder = Environment.SpecialFolder.MyComputer
        dialog.SelectedPath = My.Settings.path_install
        dialog.Description = "Selection le dossier installation de World of tanks"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Chemin.Text = dialog.SelectedPath
        End If

        If My.Computer.FileSystem.FileExists(dialog.SelectedPath & "\WorldOfTanks.exe") Then
            Suivant.Enabled = True

            message_verif.Show()
            message_verif.Text = "Dossier d'installation trouvé !"
            message_verif.ForeColor = Color.Lime
        Else
            message_verif.Show()
            message_verif.Text = "Dossier d'installation non trouvé !"
            message_verif.ForeColor = Color.Gold
        End If
    End Sub

    Private Sub suivant_Click(sender As Object, e As EventArgs) Handles Suivant.Click
        My.Settings.path_install = dialog.SelectedPath
        My.Settings.Save()
        Close()
        Modpack.Show()
    End Sub
End Class