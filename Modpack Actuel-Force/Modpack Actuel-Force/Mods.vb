Imports System.Net
Imports System.IO.Compression
Imports System.Xml

Public Class mods
    Dim ctrl As Control
    Dim chkbx As CheckBox
    Dim client As WebClient
    Dim XmlDoc As XmlDocument
    Dim liste_mods_xml As XmlNodeList
    Dim noeud, noeudEnf As XmlNode
    Dim ConfirmSuppMods, InstallPropre As DialogResult
    Dim msg As MessageBox

    Dim bytesIn, totalBytes, percentage, marge_checkbox As Double
    Dim adresse, chaine, zipPath, extractPath, DirDesktop, NomMods, LabelMods, EnableMods As String

    Dim GroupCheckboxMinimum, GroupCheckboxXvm, GroupCheckboxCrosshair, GroupCheckboxGraphic, GroupCheckboxMods As New Label

    Dim procID As Integer

    Private Sub Mods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '--- Récupération du fichier liste_mods.xml ---
        '----------------------------------------------
        XmlDoc = New XmlDocument()
        XmlDoc.Load(My.Settings.path_install & "\mods\configs\liste_mods.xml")
        marge_checkbox = 35

        '--- Groupe MINIMUM ---
        '----------------------
        GroupCheckboxMinimum.Location = New Point(10, 15)
        GroupCheckboxMinimum.Text = "--- Minimum ---"
        GroupCheckboxMinimum.Name = "minimum"
        PanelCheckboxList.Controls.Add(GroupCheckboxMinimum)

        liste_mods_xml = XmlDoc.DocumentElement.GetElementsByTagName("MINIMUM")
        '--- Récupération des mod ---
        '----------------------------
        For Each noeud In liste_mods_xml
            For Each noeudEnf In noeud.ChildNodes
                If noeudEnf.LocalName = "NOM" Then
                    NomMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "ENABLE" Then
                    EnableMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "LABEL" Then
                    LabelMods = noeudEnf.InnerText
                End If
            Next
            '--- Ajout de la checkbox ---
            '----------------------------
            If EnableMods = "true" Then
                Dim CheckBox As New CheckBox()
                CheckBox.Location = New Point(30, marge_checkbox)
                CheckBox.Text = LabelMods
                CheckBox.Name = NomMods
                CheckBox.Checked = True
                CheckBox.Enabled = False

                PanelCheckboxList.Controls.Add(CheckBox)

                marge_checkbox = marge_checkbox + 25
            End If
        Next

        '--- Groupe XVM ---
        '------------------
        GroupCheckboxXvm.Location = New Point(10, marge_checkbox)
        GroupCheckboxXvm.Text = "--- Xvm ---"
        GroupCheckboxXvm.Name = "xvm"
        PanelCheckboxList.Controls.Add(GroupCheckboxXvm)

        marge_checkbox = marge_checkbox + 20

        liste_mods_xml = XmlDoc.DocumentElement.GetElementsByTagName("XVM")
        '--- Récupération des mod ---
        '----------------------------
        For Each noeud In liste_mods_xml
            For Each noeudEnf In noeud.ChildNodes
                If noeudEnf.LocalName = "NOM" Then
                    NomMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "ENABLE" Then
                    EnableMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "LABEL" Then
                    LabelMods = noeudEnf.InnerText
                End If
            Next
            '--- Ajout de la checkbox ---
            '----------------------------
            If EnableMods = "true" Then
                Dim CheckBox As New CheckBox()
                CheckBox.Location = New Point(30, marge_checkbox)
                CheckBox.Text = LabelMods
                CheckBox.Name = NomMods

                PanelCheckboxList.Controls.Add(CheckBox)

                marge_checkbox = marge_checkbox + 25
            End If
        Next

        '--- Groupe CROSSHAIR ---
        '------------------------
        GroupCheckboxCrosshair.Location = New Point(10, marge_checkbox)
        GroupCheckboxCrosshair.Text = "--- Crosshair ---"
        GroupCheckboxCrosshair.Name = "crosshair"
        PanelCheckboxList.Controls.Add(GroupCheckboxCrosshair)

        marge_checkbox = marge_checkbox + 20

        liste_mods_xml = XmlDoc.DocumentElement.GetElementsByTagName("CROSSHAIR")
        '--- Récupération des mod ---
        '----------------------------
        For Each noeud In liste_mods_xml
            For Each noeudEnf In noeud.ChildNodes
                If noeudEnf.LocalName = "NOM" Then
                    NomMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "ENABLE" Then
                    EnableMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "LABEL" Then
                    LabelMods = noeudEnf.InnerText
                End If
            Next
            '--- Ajout de la checkbox ---
            '----------------------------
            If EnableMods = "true" Then
                Dim CheckBox As New CheckBox()
                CheckBox.Location = New Point(30, marge_checkbox)
                CheckBox.Text = LabelMods
                CheckBox.Name = NomMods

                PanelCheckboxList.Controls.Add(CheckBox)

                marge_checkbox = marge_checkbox + 25
            End If
        Next

        '--- Groupe GRAPHIC ---
        '----------------------
        GroupCheckboxGraphic.Location = New Point(10, marge_checkbox)
        GroupCheckboxGraphic.Text = "--- Graphic ---"
        GroupCheckboxGraphic.Name = "Graphic"
        PanelCheckboxList.Controls.Add(GroupCheckboxGraphic)

        marge_checkbox = marge_checkbox + 20

        liste_mods_xml = XmlDoc.DocumentElement.GetElementsByTagName("GRAPHIC")
        '--- Récupération des mod ---
        '----------------------------
        For Each noeud In liste_mods_xml
            For Each noeudEnf In noeud.ChildNodes
                If noeudEnf.LocalName = "NOM" Then
                    NomMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "ENABLE" Then
                    EnableMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "LABEL" Then
                    LabelMods = noeudEnf.InnerText
                End If
            Next
            '--- Ajout de la checkbox ---
            '----------------------------
            If EnableMods = "true" Then
                Dim CheckBox As New CheckBox()
                CheckBox.Location = New Point(30, marge_checkbox)
                CheckBox.Text = LabelMods
                CheckBox.Name = NomMods

                PanelCheckboxList.Controls.Add(CheckBox)

                marge_checkbox = marge_checkbox + 25
            End If
        Next

        '--- Groupe MODS ---
        '-------------------
        GroupCheckboxMods.Location = New Point(10, marge_checkbox)
        GroupCheckboxMods.Text = "--- Mods ---"
        GroupCheckboxMods.Name = "mods"
        PanelCheckboxList.Controls.Add(GroupCheckboxMods)

        marge_checkbox = marge_checkbox + 20

        liste_mods_xml = XmlDoc.DocumentElement.GetElementsByTagName("MODS")
        '--- Récupération des mod ---
        '----------------------------
        For Each noeud In liste_mods_xml
            For Each noeudEnf In noeud.ChildNodes
                If noeudEnf.LocalName = "NOM" Then
                    NomMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "ENABLE" Then
                    EnableMods = noeudEnf.InnerText
                ElseIf noeudEnf.LocalName = "LABEL" Then
                    LabelMods = noeudEnf.InnerText
                End If
            Next
            '--- Ajout de la checkbox ---
            '----------------------------
            If EnableMods = "true" Then
                Dim CheckBox As New CheckBox()
                CheckBox.Location = New Point(30, marge_checkbox)
                CheckBox.Text = LabelMods
                CheckBox.Name = NomMods

                PanelCheckboxList.Controls.Add(CheckBox)

                marge_checkbox = marge_checkbox + 25
            End If
        Next

        For Each ctrl In PanelCheckboxList.Controls
            If (ctrl.GetType() Is GetType(CheckBox)) Then
                chkbx = CType(ctrl, CheckBox)
                AddHandler ctrl.MouseDown, AddressOf ClicDroitCheckbox
            End If
        Next
    End Sub

    '--- Onglet ---
    '--------------
    Private Sub Menu_home_Click(sender As Object, e As EventArgs) Handles Menu_home.Click
        Close()
        Modpack.Show()
    End Sub
    Private Sub Menu_news_Click(sender As Object, e As EventArgs) Handles Menu_news.Click
        Close()
        News.Show()
    End Sub

    '--- Bouton ---
    '--------------
    Private Sub Bouton_install_mods_Click(sender As Object, e As EventArgs) Handles Bouton_install_mods.Click

        '--- Téléchargement des mods sélectionnés ---
        '--------------------------------------------
        InstallPropre = MessageBox.Show("Voulez vous netoyer vos dossiers 'mods/' et 'res_mods/' pour une installation propre ?" & vbCrLf & "Attention tous vos anciens mods seront supprimés !", "Installation Propre", MessageBoxButtons.YesNo)
        If InstallPropre = DialogResult.No Then

        ElseIf InstallPropre = DialogResult.Yes Then
            supp_mods_client()
        End If

        For Each ctrl In PanelCheckboxList.Controls
            If (ctrl.GetType() Is GetType(CheckBox)) Then
                chkbx = CType(ctrl, CheckBox)
                If chkbx.Checked Then
                    Try
                        download_mods_client(My.Settings.lien_mods & ctrl.Name & ".zip", ctrl.Name)
                    Catch
                        MessageBox.Show("Une erreur est survenue !")
                    End Try
                End If
            End If
        Next

        '--- Mise à jour de la version des mods ---
        '------------------------------------------
        Try
            client = New WebClient
            client.DownloadFileAsync(New Uri(My.Settings.lien_version_mods), My.Settings.path_install & "\mods\configs\version_mods.txt")
        Catch
            MessageBox.Show("Une erreur est survenue !")
        End Try

        MessageBox.Show("Installation terminé !")
    End Sub
    Private Sub Bouton_desinstall_mods_Click(sender As Object, e As EventArgs) Handles Bouton_desinstall_mods.Click
        supp_mods_client()
    End Sub
    Private Sub Bouton_close_Click(sender As Object, e As EventArgs) Handles Bouton_close.Click
        Modpack.Close()
    End Sub

    '--- Affichage de la progressbar et extraction des mods ---
    '----------------------------------------------------------
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        bytesIn = Double.Parse(e.BytesReceived.ToString())
        totalBytes = Double.Parse(e.TotalBytesToReceive.ToString())
        percentage = bytesIn / totalBytes * 100

        Download.ProgressBar.Value = Integer.Parse(Math.Truncate(percentage).ToString())
        Download.pourcentage.Text = Download.ProgressBar.Value & "%"
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        zipPath = My.Settings.path_install & "\" & ctrl.Name & ".zip"

        extractPath = My.Settings.path_install

        ZipFile.ExtractToDirectory(zipPath, extractPath)

        My.Computer.FileSystem.CopyDirectory(extractPath & "\" & ctrl.Name, extractPath, True)
        My.Computer.FileSystem.DeleteDirectory(extractPath & "\" & ctrl.Name & "\", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)

        My.Computer.FileSystem.DeleteFile(zipPath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)

        Download.Close()
    End Sub

    '--- Fonction suppresion mods ---
    '--------------------------------
    Private Sub supp_mods_client()

        ConfirmSuppMods = MessageBox.Show("Voulez vous supprimer tous vos mods?", "Suppresion mods", MessageBoxButtons.YesNo)
        If ConfirmSuppMods = DialogResult.No Then
            MessageBox.Show("Suppression annulé !")
        ElseIf ConfirmSuppMods = DialogResult.Yes Then
            '--- Suppression du dossier mods ---
            '-----------------------------------
            If My.Computer.FileSystem.DirectoryExists(My.Settings.path_install & "\mods") Then
                My.Computer.FileSystem.DeleteDirectory(My.Settings.path_install & "\mods", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
                My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\mods\" & My.Settings.version_jeu)
                My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\mods\configs")
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\mods\" & My.Settings.version_jeu)
                My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\mods\configs")
            End If
            '--- Téléchargement liste mods ---
            '---------------------------------
            client = New WebClient
            client.DownloadFileAsync(New Uri(My.Settings.lien_liste_mods), My.Settings.path_install & "\mods\configs\liste_mods.xml")
            '--- Suppression du dossier res_mods ---
            '---------------------------------------
            If My.Computer.FileSystem.DirectoryExists(My.Settings.path_install & "\res_mods") Then
                My.Computer.FileSystem.DeleteDirectory(My.Settings.path_install & "\res_mods", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
                My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\res_mods\" & My.Settings.version_jeu)
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\res_mods\" & My.Settings.version_jeu)
            End If

            MessageBox.Show("Désinstallation des mods terminé !")
        End If
    End Sub
    Private Sub download_mods_client(url_mods As String, name_mods As String)
        client = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        client.DownloadFileAsync(New Uri(url_mods), My.Settings.path_install & "\" & name_mods & ".zip")

        Download.info_install.Text = "Installation de: " & name_mods
        Download.info.Text = "Téléchargement de: " & name_mods
        Download.ShowDialog()
    End Sub
    Private Sub ClicDroitCheckbox(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim chkbx2 As CheckBox = CType(sender, CheckBox)
            My.Settings.nom_checkbox = chkbx2.Name
            My.Settings.Save()
            InfoMods.Close()
            InfoMods.Show()
        End If
    End Sub
End Class