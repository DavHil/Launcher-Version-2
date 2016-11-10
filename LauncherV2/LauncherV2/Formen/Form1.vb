Public Class Form1

    Dim titel As String = "Launcher"

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_Schliessen As New PictureBox
    Dim PB_Minimieren As New PictureBox
    Dim PB_Einstellungen As New PictureBox
    Dim PB_Facebook As New PictureBox
    Dim PB_Twitter As New PictureBox
    Dim PB_YouTube As New PictureBox
    Dim PB_Google_Plus As New PictureBox
    Dim PB_News As New PictureBox
    Dim PB_News_Trenner As New PictureBox
    Dim PB_Spiel_Starten As New PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Verzeichnis.Spielpfad_erstellen()
        With Me
            .FormBorderStyle = FormBorderStyle.None
            .Width = Datenbank.Launcher_Breite
            .Height = Datenbank.Launcher_Höhe
            .BackColor = Datenbank.Launcher_Hintergrundfarbe
            .ForeColor = Datenbank.Launcher_Schriftfarbe
            .Text = titel
            .ControlBox = False
            .MaximizeBox = False
            .MinimizeBox = False
            .BackgroundImage = Datenbank.Launcher_Hintergrundgrafik
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Normal
            '.Icon = My.Resources
        End With
        If Datenbank.Launcher_Musik_Modus = True Then
            My.Computer.Audio.Play(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/sounds/" & Datenbank.Launcher_Titel_Song & ".wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
        init()
    End Sub

    Private Sub init()
        PB_Schliessen_Erstellen()
        PB_Minimieren_Erstellen()
        PB_Einstellungen_Erstellen()
        PB_Facebook_Erstellen()
        PB_Twitter_Erstellen()
        PB_YouTube_Erstellen()
        PB_Google_Plus_Erstellen()
        PB_News_Erstellen()
        PB_Spiel_Starten_Erstellen()
    End Sub

#Region "Launcher Überschrift"
    Private Sub Launcher_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        G = e.Graphics

        With G
            .DrawString(Datenbank.Launcher_Titel, MyFont, Brushes.White, 12, 10)
            .DrawString(Datenbank.Spiel_Version, MyFont, Brushes.White, 485, 10)
        End With

        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            .TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        End With

    End Sub
#End Region

#Region "PB_Schliessen"
    Private Sub PB_Schliessen_Erstellen()
        With PB_Schliessen
            .Location = New Point(768, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_close_op
        End With
        AddHandler PB_Schliessen.Click, AddressOf PB_Schliessen_Click
        AddHandler PB_Schliessen.MouseEnter, AddressOf PB_Schliessen_MouseEnter
        AddHandler PB_Schliessen.MouseLeave, AddressOf PB_Schliessen_MouseLeave
        Controls.Add(PB_Schliessen)
        PB_Schliessen.Parent = Me
    End Sub

    Private Sub PB_Schliessen_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub PB_Schliessen_MouseEnter(sender As Object, e As EventArgs)
        PB_Schliessen.Image = My.Resources.button_close_mp
    End Sub

    Private Sub PB_Schliessen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Schliessen.Parent = Me
        PB_Schliessen.Image = My.Resources.button_close_op
    End Sub
#End Region

#Region "PB_Mini"
    Private Sub PB_Minimieren_Erstellen()
        With PB_Minimieren
            .Location = New Point(740, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_minim_op
        End With
        AddHandler PB_Minimieren.Click, AddressOf PB_Minimieren_Click
        AddHandler PB_Minimieren.MouseEnter, AddressOf PB_Minimieren_MouseEnter
        AddHandler PB_Minimieren.MouseLeave, AddressOf PB_Minimieren_MouseLeave
        Controls.Add(PB_Minimieren)
        PB_Minimieren.Parent = Me
    End Sub

    Private Sub PB_Minimieren_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PB_Minimieren_MouseEnter(sender As Object, e As EventArgs)
        PB_Minimieren.Image = My.Resources.button_minim_mp
    End Sub

    Private Sub PB_Minimieren_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Minimieren.Parent = Me
        PB_Minimieren.Image = My.Resources.button_minim_op
    End Sub
#End Region

#Region "PB_Einstellungen"
    Private Sub PB_Einstellungen_Erstellen()
        With PB_Einstellungen
            .Location = New Point(702, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_config_op
        End With
        AddHandler PB_Einstellungen.Click, AddressOf PB_Einstellungen_Click
        AddHandler PB_Einstellungen.MouseEnter, AddressOf PB_Einstellungen_MouseEnter
        AddHandler PB_Einstellungen.MouseLeave, AddressOf PB_Einstellungen_MouseLeave
        Controls.Add(PB_Einstellungen)
        PB_Einstellungen.Parent = Me
    End Sub

    Private Sub PB_Einstellungen_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Einstellungen_MouseEnter(sender As Object, e As EventArgs)
        PB_Einstellungen.Image = My.Resources.button_config_mp
    End Sub

    Private Sub PB_Einstellungen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Einstellungen.Parent = Me
        PB_Einstellungen.Image = My.Resources.button_config_op
    End Sub
#End Region

#Region "PB_Facebook"
    Private Sub PB_Facebook_Erstellen()
        With PB_Facebook
            .Location = New Point(686, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_facebook_op
        End With
        AddHandler PB_Facebook.Click, AddressOf PB_Facebook_Click
        AddHandler PB_Facebook.MouseEnter, AddressOf PB_Facebook_MouseEnter
        AddHandler PB_Facebook.MouseLeave, AddressOf PB_Facebook_MouseLeave
        Controls.Add(PB_Facebook)
        PB_Facebook.Parent = Me
    End Sub

    Private Sub PB_Facebook_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Facebook_MouseEnter(sender As Object, e As EventArgs)
        PB_Facebook.Image = My.Resources.sbutton_facebook_mp
    End Sub

    Private Sub PB_Facebook_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Facebook.Parent = Me
        PB_Facebook.Image = My.Resources.sbutton_facebook_op
    End Sub
#End Region

#Region "PB_Twitter"
    Private Sub PB_Twitter_Erstellen()
        With PB_Twitter
            .Location = New Point(714, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_twitter_op
        End With
        AddHandler PB_Twitter.Click, AddressOf PB_Twitter_Click
        AddHandler PB_Twitter.MouseEnter, AddressOf PB_Twitter_MouseEnter
        AddHandler PB_Twitter.MouseLeave, AddressOf PB_Twitter_MouseLeave
        Controls.Add(PB_Twitter)
        PB_Twitter.Parent = Me
    End Sub

    Private Sub PB_Twitter_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Twitter_MouseEnter(sender As Object, e As EventArgs)
        PB_Twitter.Image = My.Resources.sbutton_twitter_mp
    End Sub

    Private Sub PB_Twitter_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Twitter.Parent = Me
        PB_Twitter.Image = My.Resources.sbutton_twitter_op
    End Sub
#End Region

#Region "YouTube"
    Private Sub PB_YouTube_Erstellen()
        With PB_YouTube
            .Location = New Point(742, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_youtube_op
        End With
        AddHandler PB_YouTube.Click, AddressOf PB_YouTube_Click
        AddHandler PB_YouTube.MouseEnter, AddressOf PB_YouTube_MouseEnter
        AddHandler PB_YouTube.MouseLeave, AddressOf PB_YouTube_MouseLeave
        Controls.Add(PB_YouTube)
        PB_YouTube.Parent = Me
    End Sub

    Private Sub PB_YouTube_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_YouTube_MouseEnter(sender As Object, e As EventArgs)
        PB_YouTube.Image = My.Resources.sbutton_youtube_mp
    End Sub

    Private Sub PB_YouTube_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_YouTube.Parent = Me
        PB_YouTube.Image = My.Resources.sbutton_youtube_op
    End Sub
#End Region

#Region "PB_Google+"
    Private Sub PB_Google_Plus_Erstellen()
        With PB_Google_Plus
            .Location = New Point(770, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_google_op
        End With
        AddHandler PB_Google_Plus.Click, AddressOf PB_Google_Plus_Click
        AddHandler PB_Google_Plus.MouseEnter, AddressOf PB_Google_Plus_MouseEnter
        AddHandler PB_Google_Plus.MouseLeave, AddressOf PB_Google_Plus_MouseLeave
        Controls.Add(PB_Google_Plus)
        PB_Google_Plus.Parent = Me
    End Sub

    Private Sub PB_Google_Plus_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Google_Plus_MouseEnter(sender As Object, e As EventArgs)
        PB_Google_Plus.Image = My.Resources.sbutton_google_mp
    End Sub

    Private Sub PB_Google_Plus_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Google_Plus.Parent = Me
        PB_Google_Plus.Image = My.Resources.sbutton_google_op
    End Sub
#End Region

#Region "PB_News"
    Private Sub PB_News_Erstellen()
        With PB_News
            .Location = New Point(488, 80)
            .Size = Datenbank.Launcher_News
            .Image = My.Resources.News_bg
        End With
        AddHandler PB_News.Click, AddressOf PB_News_Click
        AddHandler PB_News.MouseEnter, AddressOf PB_News_MouseEnter
        AddHandler PB_News.MouseLeave, AddressOf PB_News_MouseLeave
        Controls.Add(PB_News)
        PB_News.Parent = Me
    End Sub

    Private Sub PB_News_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_News_MouseEnter(sender As Object, e As EventArgs)
        PB_News.Image = My.Resources.News_bg
    End Sub

    Private Sub PB_News_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_News.Parent = Me
        PB_News.Image = My.Resources.News_bg
    End Sub
#End Region

#Region "PB_Spiel-Starten"
    Private Sub PB_Spiel_Starten_Erstellen()
        With PB_Spiel_Starten
            .Location = New Point(651, 533)
            .Size = Datenbank.Launcher_Spiel_Starten
            .Image = My.Resources.button_play_op
        End With
        AddHandler PB_Spiel_Starten.Click, AddressOf PB_Spiel_Starten_Click
        AddHandler PB_Spiel_Starten.MouseEnter, AddressOf PB_Spiel_Starten_MouseEnter
        AddHandler PB_Spiel_Starten.MouseLeave, AddressOf PB_Spiel_Starten_MouseLeave
        Controls.Add(PB_Spiel_Starten)
        PB_Spiel_Starten.Parent = Me
    End Sub

    Private Sub PB_Spiel_Starten_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Spiel_Starten_MouseEnter(sender As Object, e As EventArgs)
        PB_Spiel_Starten.Image = My.Resources.button_play_mp
    End Sub

    Private Sub PB_Spiel_Starten_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Spiel_Starten.Parent = Me
        PB_Spiel_Starten.Image = My.Resources.button_play_op
    End Sub
#End Region

End Class
