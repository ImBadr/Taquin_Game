Public Class GameHistory

    Private ReadOnly Type As Taquin.Type
    Private CurrentIndexV As Integer

    Default Public ReadOnly Property GetValue(Index As Integer) As Integer
        Get
            Return Me.History(Me.CurrentIndex)(Index)
        End Get
    End Property
    Public Property CurrentIndex As Integer
    Public ReadOnly Property GridSize As Integer
    Public ReadOnly Property Count As Integer
        Get
            Return Me.History.Count
        End Get
    End Property
    Public ReadOnly Property History As List(Of List(Of Integer))

    Public Sub New(GridSize As Integer, TypeP As Taquin.Type)
        Me.History = New List(Of List(Of Integer))
        Me.GridSize = GridSize
        Me.Type = TypeP
        Me.CurrentIndex = 0
    End Sub

    Public Sub Add(List As List(Of Integer))
        Me.History.Add(List)
        Me.CurrentIndex += 1
    End Sub
    Public Sub Clear()
        Dim Count = Me.CurrentIndex - 1
        Dim List = New List(Of List(Of Integer))
        List.AddRange(Me.History.Where(Function(V, I)
                                           If (I <= Count) Then
                                               Return True
                                           End If
                                           Return False
                                       End Function))
        Me.History.Clear()
        Me.History.AddRange(List)
    End Sub
    Public Function GetPrevious() As GameHistory
        If (Me.CurrentIndex - 1 > 0) Then
            Return GetIndex(Me.CurrentIndex - 1)
        Else
            Return GetIndex(0)
        End If
    End Function
    Public Function GetIndex(Index As Integer) As GameHistory
        If (Index < 0 Or Index > Me.Count) Then
            Return Nothing
        End If
        Dim Tmp = Me.MemberwiseClone
        Tmp.CurrentIndex = Index
        Return Tmp
    End Function
    Public Function ToList() As List(Of Integer)
        If (Me.CurrentIndex >= Me.Count) Then
            Return Me.History(Me.Count - 1)
        ElseIf (Me.CurrentIndex <= 0) Then
            Return Me.History(0)
        Else
            Return Me.History(Me.CurrentIndex - 1)
        End If
    End Function
    Public Function GetNext() As GameHistory
        If (Me.CurrentIndex + 1 < Me.Count + 1) Then
            Return GetIndex(Me.CurrentIndex + 1)
        Else
            Return GetIndex(Me.Count)
        End If
    End Function

End Class
