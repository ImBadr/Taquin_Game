Public Class Player

    Public GameList As List(Of GameConfiguration)

    Public Sub New(Name As String)
        Me.Name = Name
        Me.BestTime = 0
        Me.Played = 0
        Me.Time = 0
        Me.GameList = New List(Of GameConfiguration)
    End Sub

    Public Sub Add(Game As GameConfiguration)
        If (Game.Solved = GameConfiguration.State.WINNED And Game.Timer <> -1) Then
            If (Me.BestTime = 0) Then
                Me.BestTime = Game.Time
            ElseIf (Game.Time < Me.BestTime) Then
                Me.BestTime = Game.Time
            End If
        End If
        If (GameList.Contains(Game)) Then
            Me.Time += Me.Time - Game.Time
        Else
            Me.Played += 1
            Me.Time += Game.Time
            GameList.Add(Game)
        End If
    End Sub

    Public Sub Clear()
        Me.BestTime = 0
        Me.Played = 0
        Me.Time = 0
        GameList.Clear()
    End Sub

    Function GetGame(ID As String) As GameConfiguration
        For Each Game As GameConfiguration In GameList
            If (Game.ID = ID) Then Return Game
        Next
        Return Nothing
    End Function

    Public Function CompareByName(Player As Player) As Integer
        Return String.Compare(Me.Name, Player.Name)
    End Function

    Public Function CompareByScore(Player As Player) As Integer
        Return Me.BestTime - Player.BestTime
    End Function

    Public Property BestTime() As Integer
    Public Property Played() As Integer
    Public Property Time() As Integer
    Public ReadOnly Property Name() As String

End Class