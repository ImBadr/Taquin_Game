<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Games = New System.Windows.Forms.ListBox()
        Me.Options = New System.Windows.Forms.GroupBox()
        Me.SortScore = New System.Windows.Forms.RadioButton()
        Me.SortDate = New System.Windows.Forms.RadioButton()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ShowLost = New System.Windows.Forms.CheckBox()
        Me.ShowWin = New System.Windows.Forms.CheckBox()
        Me.SizeLabel = New System.Windows.Forms.Label()
        Me.TimeMaxLabel = New System.Windows.Forms.Label()
        Me.WinLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Win = New System.Windows.Forms.Label()
        Me.TimeMax = New System.Windows.Forms.Label()
        Me.GridSize = New System.Windows.Forms.Label()
        Me.Recap = New System.Windows.Forms.GroupBox()
        Me.Type = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.DateP = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NbWin = New System.Windows.Forms.Label()
        Me.TotalTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NbPlayed = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BestTime = New System.Windows.Forms.Label()
        Me.NbLost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Options.SuspendLayout()
        Me.Recap.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Games
        '
        Me.Games.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Games.FormattingEnabled = True
        Me.Games.Location = New System.Drawing.Point(12, 12)
        Me.Games.Name = "Games"
        Me.Games.Size = New System.Drawing.Size(233, 316)
        Me.Games.TabIndex = 0
        '
        'Options
        '
        Me.Options.Controls.Add(Me.SortScore)
        Me.Options.Controls.Add(Me.SortDate)
        Me.Options.Controls.Add(Me.ResetButton)
        Me.Options.Controls.Add(Me.ShowLost)
        Me.Options.Controls.Add(Me.ShowWin)
        Me.Options.Location = New System.Drawing.Point(12, 335)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(465, 100)
        Me.Options.TabIndex = 1
        Me.Options.TabStop = False
        Me.Options.Text = "Options"
        '
        'SortScore
        '
        Me.SortScore.AutoSize = True
        Me.SortScore.Location = New System.Drawing.Point(173, 30)
        Me.SortScore.Name = "SortScore"
        Me.SortScore.Size = New System.Drawing.Size(93, 17)
        Me.SortScore.TabIndex = 5
        Me.SortScore.Text = "Trier par score"
        Me.SortScore.UseVisualStyleBackColor = True
        '
        'SortDate
        '
        Me.SortDate.AutoSize = True
        Me.SortDate.Checked = True
        Me.SortDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.SortDate.Location = New System.Drawing.Point(6, 30)
        Me.SortDate.Name = "SortDate"
        Me.SortDate.Size = New System.Drawing.Size(161, 17)
        Me.SortDate.TabIndex = 4
        Me.SortDate.TabStop = True
        Me.SortDate.Text = "Trier par ordre chronologique"
        Me.SortDate.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(371, 57)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(88, 23)
        Me.ResetButton.TabIndex = 3
        Me.ResetButton.Text = "Réinitialiser"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ShowLost
        '
        Me.ShowLost.AutoSize = True
        Me.ShowLost.Checked = True
        Me.ShowLost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowLost.Location = New System.Drawing.Point(152, 63)
        Me.ShowLost.Name = "ShowLost"
        Me.ShowLost.Size = New System.Drawing.Size(137, 17)
        Me.ShowLost.TabIndex = 2
        Me.ShowLost.Text = "Afficher parties perdues"
        Me.ShowLost.UseVisualStyleBackColor = True
        '
        'ShowWin
        '
        Me.ShowWin.AutoSize = True
        Me.ShowWin.Checked = True
        Me.ShowWin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowWin.Location = New System.Drawing.Point(6, 63)
        Me.ShowWin.Name = "ShowWin"
        Me.ShowWin.Size = New System.Drawing.Size(140, 17)
        Me.ShowWin.TabIndex = 1
        Me.ShowWin.Text = "Afficher parties gagnées"
        Me.ShowWin.UseVisualStyleBackColor = True
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.Location = New System.Drawing.Point(6, 57)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(32, 13)
        Me.SizeLabel.TabIndex = 0
        Me.SizeLabel.Text = "Taille"
        '
        'TimeMaxLabel
        '
        Me.TimeMaxLabel.AutoSize = True
        Me.TimeMaxLabel.Location = New System.Drawing.Point(6, 97)
        Me.TimeMaxLabel.Name = "TimeMaxLabel"
        Me.TimeMaxLabel.Size = New System.Drawing.Size(85, 13)
        Me.TimeMaxLabel.TabIndex = 1
        Me.TimeMaxLabel.Text = "Temps maximum"
        '
        'WinLabel
        '
        Me.WinLabel.AutoSize = True
        Me.WinLabel.Location = New System.Drawing.Point(6, 117)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(26, 13)
        Me.WinLabel.TabIndex = 2
        Me.WinLabel.Text = "État"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(6, 137)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(74, 13)
        Me.TimeLabel.TabIndex = 3
        Me.TimeLabel.Text = "Temps écoulé"
        '
        'Time
        '
        Me.Time.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Time.Location = New System.Drawing.Point(93, 137)
        Me.Time.Name = "Time"
        Me.Time.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Time.Size = New System.Drawing.Size(127, 13)
        Me.Time.TabIndex = 7
        Me.Time.Text = "0"
        Me.Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Win
        '
        Me.Win.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Win.Location = New System.Drawing.Point(93, 117)
        Me.Win.Name = "Win"
        Me.Win.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Win.Size = New System.Drawing.Size(127, 13)
        Me.Win.TabIndex = 6
        Me.Win.Text = "0"
        Me.Win.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimeMax
        '
        Me.TimeMax.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TimeMax.Location = New System.Drawing.Point(93, 97)
        Me.TimeMax.Name = "TimeMax"
        Me.TimeMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimeMax.Size = New System.Drawing.Size(127, 13)
        Me.TimeMax.TabIndex = 5
        Me.TimeMax.Text = "0"
        Me.TimeMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridSize
        '
        Me.GridSize.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GridSize.Location = New System.Drawing.Point(93, 57)
        Me.GridSize.Name = "GridSize"
        Me.GridSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GridSize.Size = New System.Drawing.Size(127, 13)
        Me.GridSize.TabIndex = 4
        Me.GridSize.Text = "0"
        Me.GridSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Recap
        '
        Me.Recap.Controls.Add(Me.Type)
        Me.Recap.Controls.Add(Me.TypeLabel)
        Me.Recap.Controls.Add(Me.DateP)
        Me.Recap.Controls.Add(Me.DateLabel)
        Me.Recap.Controls.Add(Me.Time)
        Me.Recap.Controls.Add(Me.Win)
        Me.Recap.Controls.Add(Me.TimeMax)
        Me.Recap.Controls.Add(Me.GridSize)
        Me.Recap.Controls.Add(Me.TimeLabel)
        Me.Recap.Controls.Add(Me.WinLabel)
        Me.Recap.Controls.Add(Me.TimeMaxLabel)
        Me.Recap.Controls.Add(Me.SizeLabel)
        Me.Recap.Location = New System.Drawing.Point(251, 13)
        Me.Recap.Name = "Recap"
        Me.Recap.Size = New System.Drawing.Size(226, 164)
        Me.Recap.TabIndex = 2
        Me.Recap.TabStop = False
        Me.Recap.Text = "Récapitulatif de la partie"
        '
        'Type
        '
        Me.Type.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Type.Location = New System.Drawing.Point(93, 77)
        Me.Type.Name = "Type"
        Me.Type.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Type.Size = New System.Drawing.Size(127, 13)
        Me.Type.TabIndex = 11
        Me.Type.Text = "0"
        Me.Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(6, 77)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(31, 13)
        Me.TypeLabel.TabIndex = 10
        Me.TypeLabel.Text = "Type"
        '
        'DateP
        '
        Me.DateP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateP.Location = New System.Drawing.Point(93, 27)
        Me.DateP.Name = "DateP"
        Me.DateP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateP.Size = New System.Drawing.Size(127, 13)
        Me.DateP.TabIndex = 9
        Me.DateP.Text = "0"
        Me.DateP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(6, 27)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(30, 13)
        Me.DateLabel.TabIndex = 8
        Me.DateLabel.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NbWin)
        Me.GroupBox1.Controls.Add(Me.TotalTime)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NbPlayed)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BestTime)
        Me.GroupBox1.Controls.Add(Me.NbLost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(251, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 130)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Récapitulatif du joueur"
        '
        'NbWin
        '
        Me.NbWin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NbWin.Location = New System.Drawing.Point(93, 44)
        Me.NbWin.Name = "NbWin"
        Me.NbWin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NbWin.Size = New System.Drawing.Size(127, 13)
        Me.NbWin.TabIndex = 18
        Me.NbWin.Text = "0"
        Me.NbWin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalTime
        '
        Me.TotalTime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TotalTime.Location = New System.Drawing.Point(93, 84)
        Me.TotalTime.Name = "TotalTime"
        Me.TotalTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TotalTime.Size = New System.Drawing.Size(127, 13)
        Me.TotalTime.TabIndex = 17
        Me.TotalTime.Text = "0"
        Me.TotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Perdue(s)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NbPlayed
        '
        Me.NbPlayed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NbPlayed.Location = New System.Drawing.Point(93, 24)
        Me.NbPlayed.Name = "NbPlayed"
        Me.NbPlayed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NbPlayed.Size = New System.Drawing.Size(127, 13)
        Me.NbPlayed.TabIndex = 16
        Me.NbPlayed.Text = "0"
        Me.NbPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meilleur temps"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gagnée(s)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temps de jeu"
        '
        'BestTime
        '
        Me.BestTime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BestTime.Location = New System.Drawing.Point(93, 104)
        Me.BestTime.Name = "BestTime"
        Me.BestTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BestTime.Size = New System.Drawing.Size(127, 13)
        Me.BestTime.TabIndex = 13
        Me.BestTime.Text = "0"
        Me.BestTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NbLost
        '
        Me.NbLost.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NbLost.Location = New System.Drawing.Point(93, 64)
        Me.NbLost.Name = "NbLost"
        Me.NbLost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NbLost.Size = New System.Drawing.Size(127, 13)
        Me.NbLost.TabIndex = 12
        Me.NbLost.Text = "0"
        Me.NbLost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Partie(s) jouée(s)"
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Recap)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Games)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 490)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 490)
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        Me.Options.ResumeLayout(False)
        Me.Options.PerformLayout()
        Me.Recap.ResumeLayout(False)
        Me.Recap.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Games As ListBox
    Friend WithEvents Options As GroupBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents WinLabel As Label
    Friend WithEvents TimeMaxLabel As Label
    Friend WithEvents SizeLabel As Label
    Friend WithEvents Time As Label
    Friend WithEvents Win As Label
    Friend WithEvents TimeMax As Label
    Friend WithEvents GridSize As Label
    Friend WithEvents Recap As GroupBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents ShowLost As CheckBox
    Friend WithEvents ShowWin As CheckBox
    Friend WithEvents DateP As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents Type As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NbWin As Label
    Friend WithEvents TotalTime As Label
    Friend WithEvents NbPlayed As Label
    Friend WithEvents BestTime As Label
    Friend WithEvents NbLost As Label
    Friend WithEvents SortScore As RadioButton
    Friend WithEvents SortDate As RadioButton
End Class
