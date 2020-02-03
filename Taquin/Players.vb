Imports System.IO
Module Players

    Public Players As New List(Of Player)

    Function GetPlayer(Name As String) As Player
        For Each Player As Player In Players
            If (Player.Name = Name) Then Return Player
        Next
        Return Nothing
    End Function
    Function GetPlayer(Name As String, Add As Boolean) As Player
        Dim NewPlayer As Player = GetPlayer(Name)
        If (NewPlayer Is Nothing) Then
            NewPlayer = New Player(Name)
            If (Add) Then
                Players.Add(NewPlayer)
                Home.NameList.Items.Add(NewPlayer.Name)
                Leaderboard.NameInput.Items.Add(NewPlayer.Name)
            End If
        End If
        Return NewPlayer
    End Function
    Sub Save(Directory As DirectoryInfo)
        Dim Writer As StreamWriter
        For Each Player As Player In Players
            Dim DirInfo As New DirectoryInfo(Directory.FullName & "/" & Player.Name)
            If (Not DirInfo.Exists) Then
                DirInfo.Create()
            End If
            For Each Game As GameConfiguration In Player.GameList
                Dim FileInfo As New FileInfo(DirInfo.FullName & "/" & Game.ID + ".txt")
                If (FileInfo.Exists) Then
                    Continue For
                Else
                    Writer = FileInfo.CreateText
                    Writer.WriteLine(Game.ID)
                    Writer.WriteLine(Game.Date)
                    Writer.WriteLine(Game.Lines & "x" & Game.Rows)
                    Writer.WriteLine(Game.TypeP)
                    Writer.WriteLine(Game.Timer)
                    Writer.WriteLine(Game.Solved)
                    Writer.WriteLine(Game.Time)
                    Writer.WriteLine(Game.History.History.Count)
                    Game.History.History.ForEach(Sub(L) Writer.WriteLine(String.Join(";", L)))
                    If (Game.TypeP = Taquin.Type.Image) Then
                        Writer.WriteLine(Game.Image.Extension)
                        Writer.WriteLine(Base64Header(Game.Image.Extension) & ImageToBase64(Game.Image.Get, Game.Image.Extension))
                        Game.Image.Images.ForEach(Sub(I)
                                                      Writer.WriteLine(Base64Header(Game.Image.Extension) & ImageToBase64(I, Game.Image.Extension))
                                                  End Sub)
                    End If
                    Writer.Flush()
                    Writer.Close()
                End If
            Next
        Next
    End Sub
    Sub Load(Directory As DirectoryInfo)
        Dim Dirs = Directory.EnumerateDirectories()

        For Each Dir As DirectoryInfo In Dirs
            Dim Player As New Player(Dir.Name)
            Dim Files = Dir.EnumerateFiles("*.txt")
            For Each File As FileInfo In Files
                Dim Reader As New StreamReader(File.FullName)
                Try
                    Dim ID = Reader.ReadLine
                    Dim DateP = Convert.ToDateTime(Reader.ReadLine)
                    Dim Grid() As String = Reader.ReadLine.Split("x")
                    Dim Lines = Integer.Parse(Grid(0))
                    Dim Rows = Integer.Parse(Grid(1))
                    Dim Type = Integer.Parse(Reader.ReadLine)
                    Dim Timer = Integer.Parse(Reader.ReadLine)
                    Dim Solved = Integer.Parse(Reader.ReadLine)
                    Dim Time = Integer.Parse(Reader.ReadLine)

                    Dim Tries = Integer.Parse(Reader.ReadLine)
                    Dim History As New GameHistory(Rows * Lines, Type)
                    Dim List As List(Of Integer)
                    Dim Values As List(Of String)
                    While Tries <> 0
                        List = New List(Of Integer)
                        Values = New List(Of String)(Reader.ReadLine.Split(";"))
                        Values.ForEach(Sub(L) List.Add(Integer.Parse(L)))
                        History.Add(List)
                        Tries -= 1
                    End While
                    Dim GameImage As New GameConfiguration.GameImage()
                    If (Type = Taquin.Type.Image) Then
                        GameImage.Extension = GetExtension(Reader.ReadLine())
                        GameImage.[Get] = Base64ToImage(Reader.ReadLine.Replace(Base64Header(GameImage.Extension), ""))
                        GameImage.Images = New List(Of Image)
                        While Reader.Peek <> -1
                            GameImage.Images.Add(Base64ToImage(Reader.ReadLine.Replace(Base64Header(GameImage.Extension), "")))
                        End While
                    End If
                    Reader.Close()
                    Player.Add(New GameConfiguration(ID, DateP, Lines, Rows, Type, Timer) With {
                        .Image = GameImage,
                        .History = History,
                        .Solved = Solved,
                        .Time = Time
                    })
                Catch Exception As Exception
                    Reader.Close()
                    Continue For
                End Try
            Next
            Home.NameList.Items.Add(Player.Name)
            Players.Add(Player)
        Next
    End Sub

End Module
