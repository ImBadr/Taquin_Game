Imports System.IO

Module Utils

    Public ReadOnly Random As Random = New Random

    Function CheckName(Name As String) As Boolean
        Try
            Path.GetFileName(Name)
            Path.GetDirectoryName(Name)
            Return True
        Catch E As Exception
            Return False
        End Try
    End Function
    Function Base64Header(Format As Imaging.ImageFormat) As String
        Return "data:image/" & Format.ToString.ToLower & ";base64,"
    End Function
    Function GetExtension(Extension As String) As Imaging.ImageFormat
        If (Extension.ToLower = "jpg" Or Extension.ToLower = "jpeg") Then
            Return Imaging.ImageFormat.Jpeg
        Else
            Return Imaging.ImageFormat.Png
        End If
    End Function
    Function ImageToBase64(Image As Image, Format As Imaging.ImageFormat) As String
        Using MS As New MemoryStream()
            Image.Save(MS, Format)
            Dim imageBytes As Byte() = MS.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function
    Function Base64ToImage(base64String As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim ConvertedBase64Image As Image = Image.FromStream(ms, True)
        Return ConvertedBase64Image
    End Function
    Function LoadCurrentHistory(Taquin As Taquin) As List(Of Integer)
        Dim List As New List(Of Integer)
        For Y = 0 To Taquin.Conf.Lines - 1
            For X = 0 To Taquin.Conf.Rows - 1
                List.Add(Taquin.MyGrid(Y, X))
            Next
        Next
        Return List
    End Function
    Function GetNameOf(Type As Integer) As String
        If (Type = Taquin.Type.Numeric) Then
            Return "Numérique"
        ElseIf (Type = Taquin.Type.Image) Then
            Return "Image"
        ElseIf (Type = Taquin.Type.UpperCharacater) Then
            Return "Alphabet majuscule"
        Else
            Return "Alphabet miniscule"
        End If
    End Function
    Function GetFolder(Description As String) As DirectoryInfo
        Dim Dialog As New FolderBrowserDialog With {
            .Description = Description
        }

        If (Dialog.ShowDialog() = DialogResult.OK) Then Return New DirectoryInfo(Dialog.SelectedPath)
        Return Nothing
    End Function
    Function GetFile(Directory As DirectoryInfo, Optional Filter As String = "Tous les fichiers (*.*)|(*.*)") As FileInfo
        Dim Dialog As New OpenFileDialog With {
            .InitialDirectory = Directory.FullName,
            .Multiselect = False,
            .Filter = Filter
        }

        If (Dialog.ShowDialog() = DialogResult.OK) Then Return New FileInfo(Dialog.FileName)
        Return Nothing
    End Function
    Function ChoiceDialog(Title As String, Description As String, Button1 As String, Button2 As String) As Choice.ChoiceType
        Dim Choice As New Choice(Title, Description, Button1, Button2)
        Choice.Show()
        Do While Not Choice.Clicked
            Application.DoEvents()
        Loop
        Return Choice.Choice
    End Function
    Function ChoiceDialog(Title As String, Description As String) As Choice.ChoiceType
        Return ChoiceDialog(Title, Description, "Oui", "Non")
    End Function
    Function FormatTime(Seconds As Integer)
        Dim Time As TimeSpan = TimeSpan.FromSeconds(Seconds)

        Return Time.Minutes.ToString.PadLeft(2, "0"c) & ":" &
            Time.Seconds.ToString.PadLeft(2, "0"c)
    End Function

End Module
