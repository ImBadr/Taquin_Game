Public Class Leaderboard

    Private Current As Player

    Private Sub Sync(Index As Integer, ChangeInput As Boolean)
        Names.SelectedIndex = Index
        Scores.SelectedIndex = Index
        If ChangeInput Then
            NameInput.Text = Names.SelectedItem
            Current = GetPlayer(NameInput.SelectedItem)
        End If
    End Sub
    Public Sub FillNames()
        NameInput.Items.Clear()
        Players.Players.ForEach(Sub(P) NameInput.Items.Add(P.Name))
        Sort()
    End Sub
    Public Sub Sort()
        Me.Names.Items.Clear()
        Me.Scores.Items.Clear()

        Dim Sorted As List(Of Player) = Players.Players
        Dim After As New List(Of Player)
        If (AlphabeticalOption.Checked) Then
            Sorted.Sort(Function(x, y) x.CompareByName(y))
        ElseIf (ScoreOption.Checked) Then
            Sorted.Sort(Function(x, y) x.CompareByScore(y))
        End If
        For Each P As Player In Sorted
            If (P.BestTime <= 0) Then
                After.Add(P)
                Continue For
            End If
            Me.Names.Items.Add(P.Name)
            Me.Scores.Items.Add(FormatTime(P.BestTime))
        Next
        If (AlphabeticalOption.Checked) Then
            After.Sort(Function(x, y) x.CompareByName(y))
        ElseIf (ScoreOption.Checked) Then
            After.Sort(Function(x, y) y.CompareByScore(x))
        End If
        After.ForEach(Sub(P)
                          Me.Names.Items.Add(P.Name)
                          Me.Scores.Items.Add("")
                      End Sub)
    End Sub

    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillNames()
    End Sub
    Private Sub AlphabeticalOption_CheckedChanged(sender As Object, e As EventArgs) Handles AlphabeticalOption.CheckedChanged
        Sort()
    End Sub
    Private Sub ScoreOption_CheckedChanged(sender As Object, e As EventArgs) Handles ScoreOption.CheckedChanged
        Sort()
    End Sub
    Private Sub Names_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Names.SelectedIndexChanged
        Me.Sync(Names.SelectedIndex, True)
        Scores.TopIndex = Names.TopIndex
    End Sub
    Private Sub Scores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Scores.SelectedIndexChanged
        Me.Sync(Scores.SelectedIndex, True)
        Names.TopIndex = Scores.TopIndex
    End Sub
    Private Sub NameInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameInput.SelectedIndexChanged
        Current = GetPlayer(NameInput.SelectedItem)
        For I As Integer = 0 To Names.Items.Count - 1
            If NameInput.SelectedItem = Names.Items(I) Then
                Me.Sync(I, False)
                Names.TopIndex = Scores.TopIndex
                Exit Sub
            End If
        Next
        Names.ClearSelected()
        Scores.ClearSelected()
    End Sub
    Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click
        Dim Player = GetPlayer(NameInput.Text)
        If (Player IsNot Nothing) Then
            Dim Profile As Profile = New Profile(Current)
            Profile.Show()
        End If
    End Sub
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub
    Private Sub Leaderboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub

End Class