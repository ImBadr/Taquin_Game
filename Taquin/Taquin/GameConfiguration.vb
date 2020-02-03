Imports Taquin

Public Class GameConfiguration

    Public Structure GameImage
        Public Property [Get] As Image
        Public Property Extension As Imaging.ImageFormat
        Public Images As List(Of Image)
    End Structure
    Public Enum State
        WINNED = 1
        ABANDONNED = 0
        LOSTED = -1
    End Enum

    Public ReadOnly Property ID As String
    Public ReadOnly Property Lines As Integer
    Public ReadOnly Property Rows As Integer
    Public ReadOnly Property [Date] As DateTime
    Public ReadOnly Property TypeP As Taquin.Type
    Public ReadOnly Property Timer As Integer
    Public Property Image As GameImage
    Public Property History As GameHistory
    Public Property Time As Integer
    Public Property Solved As State

    Public Sub New(ID As String, DateP As DateTime, Lines As Integer, Rows As Integer, Type As Taquin.Type, Timer As Integer)
        Me.ID = ID
        Me.Date = DateP
        Me.Lines = Lines
        Me.Rows = Rows
        Me.TypeP = Type
        Me.Timer = Timer
    End Sub

    Public Sub New(Lines As Integer, Rows As Integer, Type As Taquin.Type, Timer As Integer)
        Me.New(Lines & "x" & Rows & "-" & Guid.NewGuid().ToString().Split("-")(0), DateTime.Now, Lines, Rows, Type, Timer)
        Me.History = New GameHistory(Rows * Lines, Type)
    End Sub

    Public Function Create(Player As Player, Optional Index As Integer = -1) As Taquin
        Dim Taquin As Taquin = New Taquin(Player, Me)
        Dim List As List(Of Integer)
        If (Me.Solved <> State.ABANDONNED) Then
            List = Me.History().ToList
            Taquin.Explore = Me.Solved
        ElseIf (Index >= 0 Or Index < Me.History.History().Count) Then
            List = Me.History().GetIndex(Index).ToList
        Else Return Nothing
        End If
        Taquin.Time = Me.Time
        Taquin.History = Me.History
        Taquin.LoadGrid(List)
        If (Me.TypeP = Taquin.Type.Image) Then
            Taquin.LoadImages(Image.Images)
        End If
        Return Taquin
    End Function
    Public Function CompareByDate(Game As GameConfiguration) As Integer
        Return Me.Date.CompareTo(Game.Date)
    End Function
    Public Function CompareByTime(Game As GameConfiguration) As Integer
        Return Me.Time.CompareTo(Game.Time)
    End Function

End Class
