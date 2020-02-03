Imports System.IO

Public Class Taquin

    Public Enum Type
        Numeric = 0
        Image = 1
        UpperCharacater = 64
        LowerCharacater = 96
    End Enum

    Structure Position
        Public Property X As Integer
        Public Property Y As Integer
        Public Property Value As Integer
    End Structure

    Public Property Conf As GameConfiguration
    Private ReadOnly Player As Player
    Private ReadOnly GridSize As Integer
    Private ReadOnly MWidth As Integer
    Private ReadOnly MHeight As Integer

    Public Explore As Boolean
    Private TimeV As Integer
    Private ForceGiveUp As Boolean
    Private FreeCell As Button

    Public Property History As GameHistory
    Public Property MyGrid As Integer(,)
    Public Property Time As Integer
        Get
            Return TimeV
        End Get
        Set(value As Integer)
            Me.TimerLabel.Text = FormatTime(Conf.Timer - value)
            Me.TimeV = value
        End Set
    End Property

    Public Sub New(P As Player, Conf As GameConfiguration)
        Me.Conf = Conf
        Me.Player = P
        Me.GridSize = Conf.Rows * Conf.Lines

        Me.Explore = False
        Me.History = New GameHistory(GridSize, Conf.TypeP)
        Me.ForceGiveUp = False

        Dim X As Integer = 5
        Dim Y As Integer = 5
        Dim XMargin As Integer = 13
        Dim YMargin As Integer = 13

        If (Conf.TypeP = Type.Image) Then
            Me.MWidth = 2 * XMargin + Conf.Image.Get.Width
            Me.MHeight = 2 * YMargin + Conf.Image.Get.Height
        Else
            Me.MWidth = 2 * XMargin + (Conf.Rows * 50) + ((Conf.Rows - 1) * X)
            Me.MHeight = 2 * YMargin + (Conf.Lines * 50) + ((Conf.Lines - 1) * Y)
        End If

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        Me.Grid.Controls.Add(Me.FinalImage)
        Me.TimerLabel.Location = New Point(10, Me.Username.Top + Me.Username.Height + 5)
        Me.QuitButton.Location = New Point(10, Me.TimerLabel.Top + Me.TimerLabel.Height + 5)
        Me.NextButton.Location = New Point(Me.MWidth - Me.NextButton.Width - 10, 25)
        Me.PrevButton.Location = New Point(Me.MWidth - Me.PrevButton.Width - 10, Me.NextButton.Top + Me.NextButton.Height + 5)
        Me.Infos.Size = New Size(Me.MWidth, 100)

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.Time = 0
        Me.Username.Text = P.Name
        If (Me.Conf.Timer > -1) Then
            Me.TimerLabel.Text = FormatTime(Conf.Timer)
        Else
            Me.TimerLabel.Visible = False
        End If

        AddHandler QuitButton.Click, AddressOf Me.Button_GiveUp
        AddHandler NextButton.Click, AddressOf Me.Button_Next
        AddHandler PrevButton.Click, AddressOf Me.Button_Prev
        '
        'Grille
        '
        Me.Grid.Location = New Point(10, Me.Infos.Height + Me.Infos.Top + 10)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New Size(MWidth, MHeight)
        Me.Grid.TabIndex = 0
        Me.Grid.TabStop = False
        Me.Grid.Text = "Grille"

        '
        'Taquin
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ControlBox = False
        Me.ClientSize = New Size(MWidth + XMargin + 10, MHeight + Me.Infos.Height + 50)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Controls.Add(Me.Infos)
        Me.Controls.Add(Me.Grid)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Name = "Taquin"
        Me.Text = Me.Conf.ID

        Dim CptL As List(Of Integer) = New List(Of Integer)
        If (Conf.TypeP = Type.Numeric Or Conf.TypeP = Type.Image) Then
            For I As Integer = 1 To Me.GridSize
                CptL.Add(I)
            Next
        Else
            For I As Integer = 1 To Me.GridSize
                CptL.Add(Conf.TypeP + I)
            Next
        End If

        ReDim MyGrid(0 To Conf.Lines, 0 To Conf.Rows)
        Me.GenerateGrid(CptL, X, Y, XMargin, YMargin)
        'Solve()

        Me.Grid.ResumeLayout(False)
        Me.Infos.ResumeLayout(False)
        Me.Infos.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Private Function Sort(From As List(Of Integer)) As Integer
        Dim Cpt = 0
        Dim L As New List(Of Integer)
        L.AddRange(From)
        Dim Sorted As Boolean
        Dim Tmp As Integer
        Dim I = From.Count - 1
        While I > 1
            Sorted = True
            For J As Integer = 0 To I - 1
                If (L(J + 1) < L(J)) Then
                    Tmp = L(J)
                    L(J) = L(J + 1)
                    L(J + 1) = Tmp
                    Cpt += 1
                    Sorted = False
                End If
            Next
            I -= 1
            If (Sorted) Then Exit While
        End While
        Return Cpt
    End Function
    Private Function Pick(Item As List(Of Integer)) As Integer
        Dim Value = Item(Random.Next(0, Item.Count - 1))
        Item.Remove(Value)
        Return Value
    End Function
    Private Function GetPosition(FromBtn As Button) As Position
        Return GetPosition(GetValue(FromBtn.Tag))
    End Function
    Private Function GetPosition(Value As Integer) As Position
        For CY = 0 To Me.Conf.Lines - 1
            For CX = 0 To Me.Conf.Rows - 1
                If (MyGrid(CY, CX) = Value) Then
                    Return New Position With {
                        .X = CX,
                        .Y = CY,
                        .Value = Value
                    }
                End If
            Next
        Next
        Return Nothing
    End Function
    Private Sub Swap(FromBtn As Button, ToBtn As Button, Move As Boolean)
        'Grid
        If (Move) Then
            Dim FromPos = GetPosition(FromBtn)
            Dim ToPos = GetPosition(ToBtn)
            Dim Tmp = MyGrid(FromPos.Y, FromPos.X)
            MyGrid(FromPos.Y, FromPos.X) = MyGrid(ToPos.Y, ToPos.X)
            MyGrid(ToPos.Y, ToPos.X) = Tmp
        End If
        ' Display
        Dim TmpLocation = FromBtn.Location
        Dim TmpName = FromBtn.Name
        FromBtn.Name = ToBtn.Name
        FromBtn.Location = ToBtn.Location
        ToBtn.Name = TmpName
        ToBtn.Location = TmpLocation
        'FreeCell = GetButtonOf(Me.History.ToList.Max)
    End Sub
    Private Function GiveUp() As Boolean
        Me.Timer.Stop()
        Dim Rep As Choice.ChoiceType = ChoiceDialog("Abandonner", "Veux-tu vraiment abandonner ?")
        If Rep = Choice.ChoiceType.OK Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function GetButtonBy(Y As Integer, X As Integer) As Button
        If (X < 0 Or X > Conf.Rows Or Y < 0 Or Y > Conf.Lines) Then
            Return Nothing
        End If
        Return GetButtonOf(Me.MyGrid(Y, X))
    End Function
    Private Function GetButtonOf(Text As Integer) As Button
        For I = 1 To Me.GridSize
            Dim Btn As Button = Me.Grid.Controls("Btn" & I)
            If (GetValue(Btn.Tag) = Text) Then Return Btn
        Next
        Return Nothing
    End Function
    Private Function GetCells(Button As Button)
        Dim Cells(3) As Button
        Dim Position = GetPosition(Button)
        Dim X = Position.X
        Dim Y = Position.Y
        Cells(0) = GetButtonBy(Y - 1, X)
        If (X + 1 = Conf.Rows()) Then
            Cells(1) = GetButtonBy(Y, 0)
        Else
            Cells(1) = GetButtonBy(Y, X + 1)
        End If
        Cells(2) = GetButtonBy(Y + 1, X)
        If (X = 0) Then
            Cells(3) = GetButtonBy(Y, Conf.Rows() - 1)
        Else
            Cells(3) = GetButtonBy(Y, X - 1)
        End If
        Return Cells
    End Function
    Private Function CheckSorted()
        Dim Pos1 = GetPosition(1)
        Dim Should = Me.History.ToList.Min

        For I = Pos1.X To Conf.Lines - 1
            If (Me.MyGrid(Pos1.Y, I) <> Should) Then
                Return False
            End If
            Should += 1
        Next
        For I = 0 To Pos1.X - 1
            If (Me.MyGrid(Pos1.Y, I) <> Should) Then
                Return False
            End If
            Should += 1
        Next
        Return True
    End Function
    Private Function CheckWin()
        Dim Position = GetPosition(1)
        If (Conf.TypeP = Type.Numeric Or Conf.TypeP = Type.Image) Then
            Position = GetPosition(Conf.TypeP + 1)
        End If
        If (Position.Y = 0 And GetPosition(History.ToList.Max).Y = Conf.Lines - 1) Then
            If (Not CheckSorted()) Then Return False
            For I As Integer = 1 To Me.GridSize - Conf.Rows
                Dim Current = Me.Grid.Controls("Btn" & I)
                Dim Under = Me.Grid.Controls("Btn" & I + Conf.Rows)

                If (GetValue(Current.Tag) + Conf.Rows <> GetValue(Under.Tag)) Then
                    Return False
                End If
            Next
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub GenerateGrid(List As List(Of Integer), X As Integer, Y As Integer, XMargin As Integer, YMargin As Integer)
        Dim A As New List(Of Integer)
        For CY = 0 To Me.Conf.Lines - 1
            For CX = 0 To Me.Conf.Rows - 1
                MyGrid(CY, CX) = Pick(List)
                A.Add(MyGrid(CY, CX))
            Next
        Next
        If Sort(A) Mod 2 <> 0 Then
            Dim Rnd = Random.Next(A.Min, A.Max)
            Dim FromPos = GetPosition(Rnd)
            Dim ToPos
            Rnd = Random.Next(A.Min, A.Max)
            While (Rnd = FromPos.Value)
                Rnd = Random.Next(A.Min, A.Max)
            End While
            ToPos = GetPosition(Rnd)
            Me.MyGrid(FromPos.Y, FromPos.X) = ToPos.Value
            Me.MyGrid(ToPos.Y, ToPos.X) = FromPos.Value
        End If
        Dim XX = 50
        Dim YY = 50
        If (Conf.TypeP = Type.Image) Then
            Me.FinalImage.Location = New Point(X + XMargin, Y + YMargin)
            Me.FinalImage.Size = New Size(Me.Conf.Image.Get.Width, Me.Conf.Image.Get.Height)
            XX = Conf.Image.Get.Width / Conf.Rows
            YY = Conf.Image.Get.Height / Conf.Lines
        End If
        Dim Cpt As Integer = 1
        For CptY As Integer = 1 To Conf.Lines
            For CptX As Integer = 1 To Conf.Rows
                DrawButton(Cpt, MyGrid(CptY - 1, CptX - 1), XMargin + X, 1.5 * YMargin + Y)
                Cpt += 1
                X += XX
            Next
            X = 5
            Y += YY
        Next
        If (Me.History.History.Count = 0) Then
            Me.History.Add(LoadCurrentHistory(Me).ToList)
        End If
        FreeCell = Me.Grid.Controls("Btn" & Me.GridSize)
        FreeCell.Hide()
    End Sub
    Private Sub DrawButton(Cpt As Integer, Text As Integer, X As Integer, Y As Integer)
        Dim Btn As Button = New Button()
        Me.Grid.Controls.Add(Btn)

        If (Conf.TypeP = Type.Image) Then
            Btn.Size = New Size(Conf.Image.Get.Width / Conf.Rows, Conf.Image.Get.Height / Conf.Lines)
        Else
            Btn.Size = New Size(50, 50)
        End If
        Btn.Location = New Point(X, Y)
        Btn.Name = "Btn" & Cpt
        Btn.TabIndex = 100 + Cpt
        Btn.Tag = GetText(Text)
        Btn.Text = GetText(Text)
        Btn.UseVisualStyleBackColor = True
        AddHandler Btn.Click, AddressOf Me.Button_Click
    End Sub
    Private Sub CropImage()
        Dim W = Conf.Image.Get.Width / Conf.Rows
        Dim H = Conf.Image.Get.Height / Conf.Lines
        Dim X = 0
        Dim Y = 0
        For CptX As Integer = 1 To Conf.Lines
            For CptY As Integer = 1 To Conf.Rows
                Dim CropRect As New Rectangle(X, Y, W, H)
                Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
                Using Graphic = Graphics.FromImage(CropImage)
                    Graphic.DrawImage(Conf.Image.Get, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
                    Conf.Image.Images.Add(CropImage)
                End Using
                X += W
            Next
            X = 0
            Y += H
        Next
        For Cpt = 1 To Me.GridSize
            Dim Btn = GetButtonOf(Cpt)
            Btn.BackgroundImage = Conf.Image.Images(Cpt - 1)
            Btn.Text = ""
        Next
    End Sub
    Private Sub Quit(Solved As GameConfiguration.State)
        Me.Conf.Solved = Solved
        Me.Conf.Time = Me.Time
        Me.Conf.History = History
        Me.Player.Add(Me.Conf)
        Leaderboard.Sort()
        Home.LoadParties(Player)
        Me.Close()
        Home.Show()
    End Sub
    Private Sub Win()
        If (Me.Conf.TypeP = Type.Image) Then
            For Each Btn In Me.Grid.Controls.OfType(Of Button)
                Btn.Visible = False
            Next
            Me.FinalImage.Visible = True
        End If
        Me.Timer.Stop()
        Dim Rep As Integer = MsgBox("Tu as gagné !", vbOKOnly + vbInformation, "Partie gagnée")
        If Rep = vbOK Then
            Me.ForceGiveUp = True
            Me.Quit(GameConfiguration.State.WINNED)
        End If
    End Sub
    Private Sub ShowGrid()
        For Y = 0 To Me.Conf.Lines - 1
            For X = 0 To Me.Conf.Rows - 1
                Console.Write(GetText(Me.MyGrid(Y, X)) & " ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
    End Sub

    Public Function GetText(Text As Integer) As String
        If (Me.Conf.TypeP = Type.Numeric Or Me.Conf.TypeP = Type.Image) Then
            Return Text
        Else
            Return Chr(Text)
        End If
    End Function
    Public Function GetValue(Text As String) As Integer
        If (Me.Conf.TypeP = Type.Numeric Or Me.Conf.TypeP = Type.Image) Then
            Return Text
        Else
            Return Asc(Text)
        End If
    End Function
    Public Sub LoadGrid(List As List(Of Integer), Optional Move As Boolean = False)
        Dim Value As Integer
        Dim Btn As Button
        Dim Max = List.Max
        Dim Cpt = 0

        For Y = 0 To Me.Conf.Lines - 1
            For X = 0 To Me.Conf.Rows - 1
                Me.MyGrid(Y, X) = List(Cpt)
                Cpt += 1
            Next
        Next

        For I = 1 To Me.GridSize
            Btn = Me.Grid.Controls("Btn" & I)
            Value = List(I - 1)
            If (Value = Max) Then
                Swap(FreeCell, Btn, Move)
                FreeCell.Tag = Max
            Else
                Btn.Tag = Value
                'Btn.Text = GetText(Value)
            End If
        Next
    End Sub
    Public Sub LoadImages(List As List(Of Image))
        For Cpt = 1 To Me.GridSize
            Dim Btn = GetButtonOf(Cpt)
            Btn.BackgroundImage = List(Cpt - 1)
            Btn.Text = ""
        Next
    End Sub

    Private Sub Taquin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not Explore) Then
            If (Conf.TypeP = Type.Image) Then
                Me.FinalImage.Image = Me.Conf.Image.Get
                Me.CropImage()
            End If
            If (Not My.Settings.NextStep) Then
                NextButton.Visible = False
            End If
            If (Not My.Settings.AllowBack) Then
                PrevButton.Visible = False
            End If
            If (Me.Conf.Timer <> -1) Then
                Me.Timer.Start()
            End If
        Else
            Me.QuitButton.Text = "Quitter"

            RemoveHandler QuitButton.Click, AddressOf Me.Button_GiveUp
            AddHandler QuitButton.Click, AddressOf Me.Button_Quit
            For Each Btn In Me.Grid.Controls.OfType(Of Button)
                RemoveHandler Btn.Click, AddressOf Me.Button_Click
            Next
        End If
        Me.QuitButton.Focus()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.Time += 1
        If (Me.Time = Conf.Timer) Then
            Me.Timer.Stop()
            Dim Rep As Integer = MsgBox("Le temps est écoulé !", vbOKOnly + vbInformation, "Partie perdue")
            If Rep = vbOK Then
                Me.ForceGiveUp = True
                Me.Quit(GameConfiguration.State.LOSTED)
            End If
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs)
        Me.QuitButton.Focus()
        Dim Btn As Button = sender
        Dim Buttons() As Button = GetCells(Btn)
        If (Buttons.Contains(FreeCell)) Then
            Swap(Btn, FreeCell, True)
            If (Me.History.Count > 1) Then
                If (Me.History.CurrentIndex < Me.History.Count) Then
                    Me.History.Clear()
                End If
            End If
            Me.History.Add(LoadCurrentHistory(Me))
            If (CheckWin()) Then
                Win()
            End If
        End If
    End Sub
    Private Sub Button_GiveUp(sender As Object, e As EventArgs)
        If (Me.GiveUp) Then
            Me.ForceGiveUp = True
            Me.Quit(GameConfiguration.State.ABANDONNED)
        Else
            Me.Timer.Start()
        End If
    End Sub
    Private Sub Button_Quit(sender As Object, e As EventArgs)
        Me.ForceGiveUp = True
        Me.Close()
    End Sub
    Private Sub Button_Next(sender As Object, e As EventArgs)
        Dim [Next] = Me.History.GetNext
        If (Explore And Not [Next].ToList.Equals(Me.History.ToList)) Then
            LoadGrid([Next].ToList)
            Me.History = [Next]
        ElseIf (Not Explore) Then
            Dim NextStep = Solve()
            If (NextStep Is Nothing) Then
                Exit Sub
            End If
            Me.History.Add(NextStep)
            LoadGrid(Me.History.ToList)
            If (CheckWin()) Then
                Win()
            End If
        End If
    End Sub
    Private Sub Button_Prev(sender As Object, e As EventArgs)
        Dim Prev = Me.History.GetPrevious
        If (Not Prev.ToList.Equals(Me.History.ToList)) Then
            LoadGrid(Prev.ToList)
            Me.History = Prev
        End If
    End Sub
    Private Sub Taquin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ForceGiveUp) Then
            e.Cancel = Not Me.GiveUp()
        End If
    End Sub

    Private Function Solve() As List(Of Integer)
        Dim Solver As New FileInfo(Home.SettingsDir.FullName & "/Taquin.exe")
        If (Not Solver.Exists) Then
            Solver = GetFile(Home.SettingsDir, "Fichier exécutable (*.exe)|*.exe")
            If (Solver Is Nothing) Then
                Return Nothing
            End If
        End If
        Dim Command As String = Conf.Lines & " " & Conf.Rows
        Dim I As Integer

        For I = 1 To Me.GridSize
            If ((I - 1) Mod Conf.Rows = 0) Then
                Command &= vbNewLine
            End If
            Dim Btn = Me.Grid.Controls("Btn" & I)
            If (Btn.Tag = FreeCell.Tag) Then
                Command &= "# "
            Else
                Command &= GetValue(Btn.Tag) & " "
            End If
        Next

        Dim List As New List(Of Integer)
        Using SolvingProcess As New Process()
            SolvingProcess.StartInfo.FileName = Solver.FullName
            SolvingProcess.StartInfo.UseShellExecute = False
            SolvingProcess.StartInfo.RedirectStandardInput = True
            SolvingProcess.StartInfo.RedirectStandardOutput = True
            SolvingProcess.StartInfo.CreateNoWindow = True

            SolvingProcess.Start()

            Dim Writer As StreamWriter = SolvingProcess.StandardInput
            Writer.WriteLine(Command)
            Writer.Flush()
            Writer.Close()

            Dim Reader As StreamReader = SolvingProcess.StandardOutput
            Dim Line As String
            Reader.ReadLine()
            Reader.ReadLine()

            For Y = 0 To Conf.Lines - 1
                Line = Reader.ReadLine
            Next
            Reader.ReadLine()
            While Not Reader.EndOfStream
                For Y = 0 To Conf.Lines - 1
                    Line = Reader.ReadLine
                    Dim V = Line.Trim.Replace("  ", "./").Replace(".", "").Replace("#", FreeCell.Tag).Split("/")
                    For X = 0 To Conf.Rows - 1
                        List.Add(GetValue(V(X)))
                    Next
                Next
                Exit While
            End While
            Reader.Close()
            SolvingProcess.Close()
        End Using
        Return List
    End Function

End Class