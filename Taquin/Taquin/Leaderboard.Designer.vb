<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Me.Names = New System.Windows.Forms.ListBox()
        Me.Scores = New System.Windows.Forms.ListBox()
        Me.Options = New System.Windows.Forms.GroupBox()
        Me.NameInput = New System.Windows.Forms.ComboBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ProfileButton = New System.Windows.Forms.Button()
        Me.ScoreOption = New System.Windows.Forms.RadioButton()
        Me.AlphabeticalOption = New System.Windows.Forms.RadioButton()
        Me.Options.SuspendLayout()
        Me.SuspendLayout()
        '
        'Names
        '
        Me.Names.FormattingEnabled = True
        Me.Names.Location = New System.Drawing.Point(12, 12)
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(245, 290)
        Me.Names.TabIndex = 0
        '
        'Scores
        '
        Me.Scores.FormattingEnabled = True
        Me.Scores.Location = New System.Drawing.Point(263, 12)
        Me.Scores.Name = "Scores"
        Me.Scores.Size = New System.Drawing.Size(256, 290)
        Me.Scores.TabIndex = 1
        '
        'Options
        '
        Me.Options.Controls.Add(Me.NameInput)
        Me.Options.Controls.Add(Me.NameLabel)
        Me.Options.Controls.Add(Me.QuitButton)
        Me.Options.Controls.Add(Me.ProfileButton)
        Me.Options.Controls.Add(Me.ScoreOption)
        Me.Options.Controls.Add(Me.AlphabeticalOption)
        Me.Options.Location = New System.Drawing.Point(13, 323)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(506, 91)
        Me.Options.TabIndex = 2
        Me.Options.TabStop = False
        Me.Options.Text = "Options"
        '
        'NameInput
        '
        Me.NameInput.FormattingEnabled = True
        Me.NameInput.Location = New System.Drawing.Point(88, 26)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(154, 21)
        Me.NameInput.TabIndex = 5
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 31)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(76, 13)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Nom du joueur"
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(409, 59)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "Retour"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ProfileButton
        '
        Me.ProfileButton.Location = New System.Drawing.Point(409, 26)
        Me.ProfileButton.Name = "ProfileButton"
        Me.ProfileButton.Size = New System.Drawing.Size(75, 23)
        Me.ProfileButton.TabIndex = 2
        Me.ProfileButton.Text = "Voir le profil"
        Me.ProfileButton.UseVisualStyleBackColor = True
        '
        'ScoreOption
        '
        Me.ScoreOption.AutoSize = True
        Me.ScoreOption.Location = New System.Drawing.Point(158, 62)
        Me.ScoreOption.Name = "ScoreOption"
        Me.ScoreOption.Size = New System.Drawing.Size(84, 17)
        Me.ScoreOption.TabIndex = 1
        Me.ScoreOption.TabStop = True
        Me.ScoreOption.Text = "Tri par score"
        Me.ScoreOption.UseVisualStyleBackColor = True
        '
        'AlphabeticalOption
        '
        Me.AlphabeticalOption.AutoSize = True
        Me.AlphabeticalOption.Checked = True
        Me.AlphabeticalOption.Location = New System.Drawing.Point(6, 62)
        Me.AlphabeticalOption.Name = "AlphabeticalOption"
        Me.AlphabeticalOption.Size = New System.Drawing.Size(146, 17)
        Me.AlphabeticalOption.TabIndex = 0
        Me.AlphabeticalOption.TabStop = True
        Me.AlphabeticalOption.Text = "Tri par ordre aplhabétique"
        Me.AlphabeticalOption.UseVisualStyleBackColor = True
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 426)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Scores)
        Me.Controls.Add(Me.Names)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(547, 465)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(547, 465)
        Me.Name = "Leaderboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaderboard"
        Me.Options.ResumeLayout(False)
        Me.Options.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Names As ListBox
    Friend WithEvents Scores As ListBox
    Friend WithEvents Options As GroupBox
    Friend WithEvents ProfileButton As Button
    Friend WithEvents ScoreOption As RadioButton
    Friend WithEvents AlphabeticalOption As RadioButton
    Friend WithEvents QuitButton As Button
    Friend WithEvents NameInput As ComboBox
    Friend WithEvents NameLabel As Label
End Class
