Imports System.IO

Public Class Profile

    Private Player As Player

    Public Sub New(Player As Player)
        Me.Player = Player
        InitializeComponent()
        Me.Text = "Profil de " & Player.Name
        GlobalLoad()
    End Sub

    Private Sub Reset()
        Me.DateP.Text = ""
        Me.GridSize.Text = ""
        Me.Type.Text = ""
        Me.TimeMax.Text = ""
        Me.Win.Text = ""
        Me.Time.Text = ""
    End Sub
    Public Sub GlobalLoad()
        Me.NbPlayed.Text = Player.Played
        Me.NbWin.Text = Player.GameList.Where(Function(Value)
                                                  If (Value.Solved = GameConfiguration.State.WINNED) Then
                                                      Return True
                                                  Else
                                                      Return False
                                                  End If
                                              End Function).Count
        Me.NbLost.Text = Player.GameList.Where(Function(Value)
                                                   If (Value.Solved <> GameConfiguration.State.WINNED) Then
                                                       Return True
                                                   Else
                                                       Return False
                                                   End If
                                               End Function).Count
        Me.TotalTime.Text = FormatTime(Player.Time)
        Me.BestTime.Text = FormatTime(Player.BestTime)
        Me.Reset()
    End Sub
    Public Sub Sort()
        Dim Sorted As New List(Of GameConfiguration)
        Dim After As New List(Of GameConfiguration)
        For Each Game As String In Me.Games.Items
            Sorted.Add(Player.GetGame(Game))
        Next
        Dim SelectedID = "-1"
        If (Games.SelectedItem IsNot Nothing) Then
            SelectedID = "" & Games.SelectedItem
        End If
        Me.Games.Items.Clear()
        If (SortDate.Checked) Then
            Sorted.Sort(Function(x, y) y.CompareByDate(x))
        ElseIf (SortScore.Checked) Then
            Sorted.Sort(Function(x, y) y.CompareByTime(x))
        End If
        For Each Game As GameConfiguration In Sorted
            If (SortScore.Checked And Game.Timer = -1) Then
                After.Add(Game)
                Continue For
            End If
            Games.Items.Add(Game.ID)
            If (Game.ID = SelectedID) Then Games.SelectedIndex = (Games.Items.Count - 1)
        Next
        If (SortScore.Checked) Then
            After.Sort(Function(x, y) y.CompareByTime(x))
            After.ForEach(Sub(Game)
                              Games.Items.Add(Game.ID)
                          End Sub)
        End If
    End Sub

    Private Sub Games_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Games.SelectedIndexChanged
        If (Games.SelectedItem Is Nothing) Then
            Me.Reset()
            Return
        End If
        Dim CurrentGame As GameConfiguration = Player.GetGame(Games.SelectedItem)
        Me.DateP.Text = CurrentGame.Date.ToString
        Me.GridSize.Text = CurrentGame.Lines & "x" & CurrentGame.Rows
        Me.Type.Text = GetNameOf(CurrentGame.TypeP)
        Me.TimeMax.Text = FormatTime(CurrentGame.Timer)
        If (CurrentGame.Solved = GameConfiguration.State.WINNED) Then
            Me.Win.Text = "Remporté"
        Else
            Me.Win.Text = "Perdu"
        End If
        Me.Time.Text = FormatTime(CurrentGame.Time)
    End Sub
    Private Sub SortDate_CheckedChanged(sender As Object, e As EventArgs) Handles SortDate.CheckedChanged, SortScore.CheckedChanged
        Me.Sort()
    End Sub
    Private Sub ShowWin_CheckedChanged(sender As Object, e As EventArgs) Handles ShowWin.CheckedChanged
        If (ShowWin.Checked) Then
            For Each Game As GameConfiguration In Me.Player.GameList
                If (Game.Solved = GameConfiguration.State.WINNED) Then
                    Games.Items.Add(Game.ID)
                    Me.Sort()
                End If
            Next
        Else
            For Each Game As GameConfiguration In Me.Player.GameList
                If (Game.Solved = GameConfiguration.State.WINNED) Then
                    If (Game.ID = Games.SelectedItem) Then Me.Games.ClearSelected()
                    Games.Items.Remove(Game.ID)
                End If
            Next
        End If
    End Sub
    Private Sub ShowLost_CheckedChanged(sender As Object, e As EventArgs) Handles ShowLost.CheckedChanged
        If (ShowLost.Checked) Then
            For Each Game As GameConfiguration In Me.Player.GameList
                If (Game.Solved <> GameConfiguration.State.WINNED) Then
                    Games.Items.Add(Game.ID)
                    Me.Sort()
                End If
            Next
        Else
            For Each Game As GameConfiguration In Me.Player.GameList
                If (Game.Solved <> GameConfiguration.State.WINNED) Then
                    If (Game.ID = Games.SelectedItem) Then Me.Games.ClearSelected()
                    Games.Items.Remove(Game.ID)
                End If
            Next
        End If
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Dim Rep = ChoiceDialog("Réinitialiser", "Réinitialiser les statistiques de " & Player.Name & " ?")
        If Rep = Choice.ChoiceType.OK Then
            Dim Directory = New DirectoryInfo(My.Settings.Dir & "/" & Player.Name)
            If (Directory.Exists) Then
                Dim Files = Directory.GetFiles
                For Each File In Files
                    File.Delete()
                Next
            End If
            Me.Games.Items.Clear()
            Player.Clear()
            Leaderboard.Sort()
            Home.LoadParties(Player)
            GlobalLoad()
            Sort()
        End If
    End Sub

End Class