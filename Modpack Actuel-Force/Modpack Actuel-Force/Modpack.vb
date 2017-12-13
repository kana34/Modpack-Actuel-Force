Imports System.IO
Imports System.Net
Imports System.Xml

Public Class Modpack
    Dim Path_install As String
    Dim monStreamReader As StreamReader
    Dim xmlDoc As XmlDocument
    Dim configElements As XmlNodeList
    Dim Version_wot As String
    Dim client As WebClient

    Dim procID As Integer
    Dim DirDesktop As String
    Dim bytesIn As Double
    Dim totalBytes As Double
    Dim percentage As Double


    Private Sub Modpack_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Path_install = My.Settings.path_install

        '--- Vérification de la connection internet ---
        '----------------------------------------------
        If CheckForInternetConnection() = False Then
            MessageBox.Show("Une connection internet est nécéssaire !")
            Close()
        Else
        End If

        '--- Vérification du chemin d'installation ---
        '---------------------------------------------
        If My.Computer.FileSystem.FileExists(Path_install & "\WorldOfTanks.exe") Then
        Else
            Chemin_install.ShowDialog()
        End If

        '--- Récupération version modpack ---
        '------------------------------------
        client = New WebClient
        My.Settings.version_modpack = client.DownloadString(My.Settings.lien_version_modpack).Replace(Convert.ToChar(20), vbCrLf)

        '--- Récupération version jeu ---
        '--------------------------------
        monStreamReader = New StreamReader(Path_install & "\version.xml")
        xmlDoc = New XmlDocument()
        xmlDoc.Load(Path_install & "\version.xml")
        configElements = xmlDoc.GetElementsByTagName("version.xml")

        For Each noeud In configElements
            For Each noeudEnf In noeud.ChildNodes
                Select Case noeudEnf.LocalName
                    Case "version"
                        Version_wot = Mid(noeudEnf.InnerText, 4, 8)
                End Select
            Next
        Next
        My.Settings.version_jeu = Version_wot
        My.Settings.Save()

        '--- Récupération de la liste de mods ---
        '----------------------------------------
        If My.Computer.FileSystem.DirectoryExists(My.Settings.path_install & "\mods\configs") Then
            My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\mods\configs")
        End If

        client = New WebClient
        client.DownloadFileAsync(New Uri(My.Settings.lien_liste_mods), My.Settings.path_install & "\mods\configs\liste_mods.xml")

        '--- Vérification version entre modpack et jeu ---
        '-------------------------------------------------
        If My.Settings.version_jeu = My.Settings.version_modpack Then
            monStreamReader.Close()
        Else
            MessageBox.Show("Version du Modpack incompatible avec votre version de Wot !" & vbNewLine & "Veuillez attendre la mise à jour du launcher." & My.Settings.version_modpack)
            monStreamReader.Close()
            Close()
        End If
    End Sub

    '--- Onglet ---
    '--------------
    Private Sub Menu_news_Click(sender As Object, e As EventArgs) Handles Menu_news.Click
        Hide()
        News.Show()
    End Sub
    Private Sub Menu_mods_Click(sender As Object, e As EventArgs) Handles Menu_mods.Click
        Hide()
        Mods.Show()
    End Sub

    '--- Bouton ---
    '--------------
    Private Sub Bouton_close_Click(sender As Object, e As EventArgs) Handles Bouton_close.Click
        Close()
    End Sub
    Private Sub Bouton_play_Click(sender As Object, e As EventArgs) Handles Bouton_play.Click
        Try

            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = Path_install & "\WorldOfTanks.exe"
            startInfo.Arguments = "f"
            Process.Start(startInfo)

            'procID = Shell("cmd /c cd """ & Path_install & """ & Start WorldOfTanks.exe")
            MyBase.Close()
        Catch ex As Exception
            MessageBox.Show("Lancement du jeu impossible !")
        End Try
    End Sub

    Private Sub Bouton_install_ts3_Click(sender As Object, e As EventArgs) Handles Bouton_instal_ts3.Click
        DirDesktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        client = New WebClient

        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted

        If Environment.Is64BitOperatingSystem = True Then
            client.DownloadFileAsync(New Uri("http://dl.4players.de/ts/releases/3.1.6/TeamSpeak3-Client-win64-3.1.6.exe"), DirDesktop + "/teamspeak.exe")
        Else
            client.DownloadFileAsync(New Uri("http://dl.4players.de/ts/releases/3.1.6/TeamSpeak3-Client-win32-3.1.6.exe"), DirDesktop + "/teamspeak.exe")
        End If

        Download.info_install.Text = "Téléchargement"
        Download.info.Text = "Téléchargement de teamspeak 3"
        Download.ShowDialog()

        Try
            procID = Shell("cmd /c cd """ & DirDesktop & """ & Start teamspeak.exe")
        Catch ex As Exception
            MessageBox.Show("Installation arreté !")
        End Try
    End Sub

    '--- Bouton lien ---
    '-------------------
    Private Sub Bouton_lien_forum_Click(sender As Object, e As EventArgs) Handles Bouton_lien_forum.Click
        Process.Start(My.Settings.lien_site)
    End Sub
    Private Sub Bouton_lien_ts3_Click(sender As Object, e As EventArgs) Handles Bouton_lien_ts3.Click
        Process.Start("ts3server://" + My.Settings.lien_ts3)
    End Sub

    '--- Affichage de la progressbar et extraction de l'archive ---
    '--------------------------------------------------------------
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        bytesIn = Double.Parse(e.BytesReceived.ToString())
        totalBytes = Double.Parse(e.TotalBytesToReceive.ToString())
        percentage = bytesIn / totalBytes * 100

        Download.ProgressBar.Value = Integer.Parse(Math.Truncate(percentage).ToString())
        Download.pourcentage.Text = Download.ProgressBar.Value & "%"
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Download.Hide()
        Me.Show()
    End Sub

    '--- Fonction check internet ---
    '-------------------------------
    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function    
End Class
