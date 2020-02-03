Imports System.IO

Public Class Options

    Private Sub LoadDefaults()
        Dir.Text = My.Settings.Dir
        Lines.Value = My.Settings.HomeLines
        Rows.Value = My.Settings.HomeRows
        Time.Value = My.Settings.HomeTime
        For I As Integer = 0 To TypeP.Items.Count - 1
            If (TypeP.Items(I) = GetNameOf(My.Settings.HomeType)) Then
                TypeP.SelectedIndex = I
                Exit For
            End If
        Next
        UseTimer.Checked = My.Settings.UseTimer
        NextStep.Checked = My.Settings.NextStep
        AllowBack.Checked = False
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDefaults()
        AllowBackLabel.Enabled = False
        AllowBack.Enabled = False
    End Sub
    Private Sub OpenFolder_Click(sender As Object, e As EventArgs) Handles OpenFolder.Click
        Dim Directory = GetFolder("Veuillez choisir le nouveau dossier de sauvegarde")
        If (Directory IsNot Nothing) Then
            Dir.Text = Directory.FullName
        Else
            Dir.Text = My.Settings.Dir
        End If
    End Sub
    Private Sub Dir_TextChanged(sender As Object, e As EventArgs) Handles Dir.TextChanged
        ValidateButton.Enabled = False
        If (Not String.IsNullOrWhiteSpace(Dir.Text)) Then
            Dim Directory As New DirectoryInfo(Dir.Text)
            ValidateButton.Enabled = Directory.Exists
            If (Not Directory.Exists) Then
                Dir.ForeColor = Color.Red
            Else
                Dir.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub Validate_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        My.Settings.Dir = Dir.Text
        If (My.Settings.Dir <> Home.SettingsDir.FullName) Then
            Dim Rep = ChoiceDialog("Sauvegarder", "Voulez-vous sauvegarder avant de charger les nouvelles données ?" &
                                   vbNewLine & "Vous perdrez toutes les données non enregistrées")
            If Rep = Choice.ChoiceType.OK Then
                Save(Home.SettingsDir)
            End If
            Home.SettingsDir = New DirectoryInfo(My.Settings.Dir)
            Players.Players.Clear()
            Home.Clear()
            Players.Load(Home.SettingsDir)
        End If
        My.Settings.HomeLines = Lines.Value
        My.Settings.HomeRows = Rows.Value
        My.Settings.HomeTime = Time.Value
        My.Settings.HomeType = TypeP.SelectedIndex
        My.Settings.UseTimer = UseTimer.Checked
        My.Settings.NextStep = NextStep.Checked
        'My.Settings.AllowBack = AllowBack.Checked
        My.Settings.Save()
        Close()
    End Sub
    Private Sub Options_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub

End Class