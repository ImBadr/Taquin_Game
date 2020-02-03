Imports System.IO

Public Class Home

    Public SettingsDir As DirectoryInfo

    Private Sub LoadDefaults()
        ResetParties()
        Me.LinesInput.Value = My.Settings.HomeLines
        Me.RowsInput.Value = My.Settings.HomeRows
        Me.WithTimer.Checked = My.Settings.UseTimer
        Me.TimerInput.Value = My.Settings.HomeTime
        If (My.Settings.HomeType = Taquin.Type.Numeric) Then
            Me.NumericOption.Checked = True
        ElseIf (My.Settings.HomeType = Taquin.Type.Image) Then
            Me.ImageOption.Checked = True
        ElseIf (My.Settings.HomeType = Taquin.Type.UpperCharacater) Then
            Me.UpperOption.Checked = True
        Else
            Me.LowerOption.Checked = True
        End If
    End Sub
    Private Sub ResetParties()
        If (PartyList.SelectedIndex <> -1) Then
            Me.PartyList.SelectedIndex = 0
        End If
        Me.SettingsGroup.Enabled = True
        Me.PlayButton.Text = "Jouer"
    End Sub
    Public Sub LoadSettings()
        If (String.IsNullOrWhiteSpace(My.Settings.Dir)) Then
            SettingsDir = GetFolder("Veuillez choisir le dossier de sauvegarde")
            If (SettingsDir Is Nothing) Then
                SettingsDir = New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "/Taquin")
                If (Not SettingsDir.Exists) Then
                    SettingsDir.Create()
                End If
            End If
            My.Settings.Dir = SettingsDir.FullName
            My.Settings.Save()
        Else
            SettingsDir = New DirectoryInfo(My.Settings.Dir)
            If (Not SettingsDir.Exists) Then
                SettingsDir.Create()
            End If
        End If

        Players.Load(SettingsDir)
    End Sub
    Public Sub LoadParties(Player As Player)
        PartyList.Items.Clear()
        Me.SettingsGroup.Enabled = True
        If (Player.Played > 0) Then
            PartyList.Enabled = True
            PartyList.Items.Add("")
            For Each Game As GameConfiguration In Player.GameList
                PartyList.Items.Add(Game.ID)
            Next
            PartyList.SelectedIndex = 0
        Else
            ResetParties()
            PartyList.Enabled = False
        End If
    End Sub
    Public Sub Clear()
        NameList.Items.Clear()
        NameList.Text = ""
        PartyList.Items.Clear()
        PartyList.Enabled = False
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadSettings()
        Me.LoadDefaults()
    End Sub
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If (String.IsNullOrWhiteSpace(NameList.Text)) Then
            Exit Sub
        End If
        Dim TypeP As Taquin.Type
        If (NumericOption.Checked) Then
            TypeP = Taquin.Type.Numeric
        ElseIf (ImageOption.Checked) Then
            TypeP = Taquin.Type.Image
        ElseIf (UpperOption.Checked) Then
            TypeP = Taquin.Type.UpperCharacater
        Else
            TypeP = Taquin.Type.LowerCharacater
        End If
        'If (TypeP = Taquin.Type.UpperCharacater Or TypeP = Taquin.Type.LowerCharacater) Then
        'Console.WriteLine(RowsInput.Value & "/" & LinesInput.Value)
        If (RowsInput.Value * LinesInput.Value > 30) Then
            MsgBox("La grille est trop grande pour un taquin ", vbOK + vbInformation, "Erreur")
            Exit Sub
        End If
        'End If
        'Me.Hide()
        Dim Form As Taquin
        If (PartyList.Enabled And PartyList.SelectedIndex > 0) Then
            Dim Player = GetPlayer(NameList.Text)
            Dim GameInfo = Player.GetGame(PartyList.SelectedItem)

            If (GameInfo.Solved = GameConfiguration.State.WINNED Or GameInfo.Solved = GameConfiguration.State.LOSTED) Then
                Form = GameInfo.Create(Player)
            Else
                Dim Rep = ChoiceDialog("Reprendre une partie", "Voulez-vous reprendre la partie ?")
                If Rep = Choice.ChoiceType.OK Then
                    Form = GameInfo.Create(Player, GameInfo.History.History.Count)
                Else
                    Exit Sub
                End If
            End If
        Else
            Dim Time = Me.TimerInput.Value
            If (Not Me.TimerInput.Enabled) Then
                Time = -1
            End If

            If (ImageOption.Checked) Then
                Dim File = GetFile(New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)),
                              "JPEG images|*.jpg; *.jpeg|PNG images|*.png")
                If (File Is Nothing) Then
                    Exit Sub
                End If
                Dim Img = Image.FromFile(File.FullName)
                If (Img.Height > My.Computer.Screen.WorkingArea.Height Or Img.Width > My.Computer.Screen.WorkingArea.Width) Then
                    MsgBox("L'image choisie est trop grande pour être affichée.", vbOKOnly + vbInformation, "Erreur")
                    Exit Sub
                End If
                Dim GameImage As New GameConfiguration.GameImage() With {
                    .[Get] = Img,
                    .Extension = GetExtension(File.Extension),
                    .Images = New List(Of Image)
                }
                Form = New Taquin(GetPlayer(NameList.Text, True), New GameConfiguration(LinesInput.Value, RowsInput.Value, TypeP, Time) With {.Image = GameImage})
            Else
                Form = New Taquin(GetPlayer(NameList.Text, True), New GameConfiguration(LinesInput.Value, RowsInput.Value, TypeP, Time))
            End If
        End If
        Form.Show()
    End Sub
    Private Sub ScoresButton_Click(sender As Object, e As EventArgs) Handles ScoresButton.Click
        Me.Hide()
        Leaderboard.Show()
    End Sub
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub
    Private Sub SetDefaultButton_Click(sender As Object, e As EventArgs) Handles SetDefaultButton.Click
        Me.LoadDefaults()
    End Sub
    Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        Me.Hide()
        Options.Show()
    End Sub
    Private Sub WithTimer_CheckedChanged(sender As Object, e As EventArgs) Handles WithTimer.CheckedChanged
        Me.TimerInput.Enabled = WithTimer.Checked
    End Sub
    Private Sub NameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameList.SelectedIndexChanged
        Me.LoadParties(GetPlayer(NameList.Text))
    End Sub
    Private Sub NameList_TextUpdate(sender As Object, e As EventArgs) Handles NameList.TextUpdate
        Dim Player = GetPlayer(NameList.Text)
        If (Player IsNot Nothing) Then
            Me.LoadParties(Player)
        Else
            PartyList.Items.Clear()
            'LoadDefaults()
            ResetParties()
            PartyList.Enabled = False
        End If
    End Sub
    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Rep = ChoiceDialog("Quitter", "Sauvegarder les parties ?")
        If Rep = Choice.ChoiceType.OK Then
            Save(SettingsDir)
        ElseIf Rep = Choice.ChoiceType.ABORT Then
            e.Cancel = True
        End If
    End Sub
    Private Sub PartyList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PartyList.SelectedIndexChanged
        If (Not PartyList.Enabled Or PartyList.SelectedIndex = 0) Then
            ResetParties()
            Exit Sub
        End If
        Dim Player = GetPlayer(NameList.Text)
        Dim Game = Player.GetGame(PartyList.SelectedItem)
        If (Game.Solved = GameConfiguration.State.WINNED Or Game.Solved = GameConfiguration.State.LOSTED) Then
            Me.PlayButton.Text = "Explorer"
        Else
            Me.PlayButton.Text = "Reprendre"
        End If
        Me.LinesInput.Value = Game.Lines
        Me.RowsInput.Value = Game.Rows
        If (Game.Timer = -1) Then
            Me.WithTimer.Checked = True
        Else
            Me.TimerInput.Value = Game.Timer
        End If
        If (Game.TypeP = Taquin.Type.Numeric) Then
            Me.NumericOption.Checked = True
        ElseIf (Game.TypeP = Taquin.Type.Image) Then
            Me.ImageOption.Checked = True
        ElseIf (Game.TypeP = Taquin.Type.UpperCharacater) Then
            Me.UpperOption.Checked = True
        Else
            Me.LowerOption.Checked = True
        End If
        Me.SettingsGroup.Enabled = False
    End Sub

End Class