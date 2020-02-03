Imports System.ComponentModel
Imports Taquin

Public Class Choice

    Public Enum ChoiceType
        ABORT = -1
        OK = 1
        KO = 0
    End Enum

    Public Property Choice As ChoiceType
    Public Property Clicked As Boolean

    Public Sub New(Title As String, Description As String, Button1 As String, Button2 As String)
        InitializeComponent()
        Me.Label1.Text = Description
        Dim NewWidth = Me.Label1.Width + (Me.Label1.Location.X * 2)
        If (NewWidth > Me.Width) Then
            Me.MaximumSize = New Size(NewWidth, Me.Height)
            Me.MinimumSize = New Size(NewWidth, Me.Height)
            Me.Size = New Size(NewWidth, Me.Height)
        End If
        Me.Label1.Location = New Point((Me.Width - Me.Label1.Width - Me.Label1.Location.X) / 2, 15)
        Me.Button1.Text = Button1
        Me.Button2.Text = Button2
        Me.Text = Title
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Clicked = False
    End Sub

    Private Sub ChoiceTrue(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Clicked = True
        Me.Choice = ChoiceType.OK
        Me.Close()
    End Sub
    Private Sub ChoiceFalse(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Clicked = True
        Me.Choice = ChoiceType.KO
        Me.Close()
    End Sub
    Private Sub CloseFalse(sender As Object, e As EventArgs) Handles Me.FormClosing
        If Not Me.Clicked Then
            Me.Choice = ChoiceType.ABORT
            Me.Clicked = True
        End If
    End Sub

End Class