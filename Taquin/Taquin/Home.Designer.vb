<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SettingsGroup = New System.Windows.Forms.GroupBox()
        Me.WithTimer = New System.Windows.Forms.CheckBox()
        Me.ImageOption = New System.Windows.Forms.RadioButton()
        Me.LowerOption = New System.Windows.Forms.RadioButton()
        Me.UpperOption = New System.Windows.Forms.RadioButton()
        Me.NumericOption = New System.Windows.Forms.RadioButton()
        Me.LinesInput = New System.Windows.Forms.NumericUpDown()
        Me.RowsInput = New System.Windows.Forms.NumericUpDown()
        Me.TimerInput = New System.Windows.Forms.NumericUpDown()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.ScoresButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameList = New System.Windows.Forms.ComboBox()
        Me.PartyList = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DefaultButton = New System.Windows.Forms.Button()
        Me.SetDefaultButton = New System.Windows.Forms.Button()
        Me.SettingsGroup.SuspendLayout()
        CType(Me.LinesInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RowsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimerInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lignes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Colonnes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Temps"
        '
        'SettingsGroup
        '
        Me.SettingsGroup.Controls.Add(Me.WithTimer)
        Me.SettingsGroup.Controls.Add(Me.ImageOption)
        Me.SettingsGroup.Controls.Add(Me.LowerOption)
        Me.SettingsGroup.Controls.Add(Me.UpperOption)
        Me.SettingsGroup.Controls.Add(Me.NumericOption)
        Me.SettingsGroup.Controls.Add(Me.LinesInput)
        Me.SettingsGroup.Controls.Add(Me.RowsInput)
        Me.SettingsGroup.Controls.Add(Me.TimerInput)
        Me.SettingsGroup.Controls.Add(Me.Label1)
        Me.SettingsGroup.Controls.Add(Me.Label3)
        Me.SettingsGroup.Controls.Add(Me.Label2)
        Me.SettingsGroup.Location = New System.Drawing.Point(23, 15)
        Me.SettingsGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SettingsGroup.Name = "SettingsGroup"
        Me.SettingsGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SettingsGroup.Size = New System.Drawing.Size(203, 244)
        Me.SettingsGroup.TabIndex = 4
        Me.SettingsGroup.TabStop = False
        Me.SettingsGroup.Text = "Paramètres du taquin"
        '
        'WithTimer
        '
        Me.WithTimer.AutoSize = True
        Me.WithTimer.Checked = True
        Me.WithTimer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WithTimer.Location = New System.Drawing.Point(96, 110)
        Me.WithTimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WithTimer.Name = "WithTimer"
        Me.WithTimer.Size = New System.Drawing.Size(18, 17)
        Me.WithTimer.TabIndex = 10
        Me.WithTimer.UseVisualStyleBackColor = True
        '
        'ImageOption
        '
        Me.ImageOption.AutoSize = True
        Me.ImageOption.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ImageOption.Location = New System.Drawing.Point(117, 208)
        Me.ImageOption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImageOption.Name = "ImageOption"
        Me.ImageOption.Size = New System.Drawing.Size(67, 21)
        Me.ImageOption.TabIndex = 9
        Me.ImageOption.Text = "Image"
        Me.ImageOption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ImageOption.UseVisualStyleBackColor = True
        '
        'LowerOption
        '
        Me.LowerOption.AutoSize = True
        Me.LowerOption.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LowerOption.Location = New System.Drawing.Point(24, 208)
        Me.LowerOption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LowerOption.Name = "LowerOption"
        Me.LowerOption.Size = New System.Drawing.Size(52, 21)
        Me.LowerOption.TabIndex = 8
        Me.LowerOption.Text = "abc"
        Me.LowerOption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LowerOption.UseVisualStyleBackColor = True
        '
        'UpperOption
        '
        Me.UpperOption.AutoSize = True
        Me.UpperOption.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.UpperOption.Location = New System.Drawing.Point(117, 172)
        Me.UpperOption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UpperOption.Name = "UpperOption"
        Me.UpperOption.Size = New System.Drawing.Size(56, 21)
        Me.UpperOption.TabIndex = 7
        Me.UpperOption.Text = "ABC"
        Me.UpperOption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UpperOption.UseVisualStyleBackColor = True
        '
        'NumericOption
        '
        Me.NumericOption.AutoSize = True
        Me.NumericOption.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.NumericOption.Checked = True
        Me.NumericOption.Location = New System.Drawing.Point(24, 172)
        Me.NumericOption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumericOption.Name = "NumericOption"
        Me.NumericOption.Size = New System.Drawing.Size(53, 21)
        Me.NumericOption.TabIndex = 6
        Me.NumericOption.TabStop = True
        Me.NumericOption.Text = "123"
        Me.NumericOption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NumericOption.UseVisualStyleBackColor = True
        '
        'LinesInput
        '
        Me.LinesInput.Location = New System.Drawing.Point(117, 43)
        Me.LinesInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LinesInput.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.LinesInput.Name = "LinesInput"
        Me.LinesInput.Size = New System.Drawing.Size(71, 22)
        Me.LinesInput.TabIndex = 5
        Me.LinesInput.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'RowsInput
        '
        Me.RowsInput.Location = New System.Drawing.Point(117, 73)
        Me.RowsInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RowsInput.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.RowsInput.Name = "RowsInput"
        Me.RowsInput.Size = New System.Drawing.Size(71, 22)
        Me.RowsInput.TabIndex = 4
        Me.RowsInput.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'TimerInput
        '
        Me.TimerInput.Location = New System.Drawing.Point(117, 105)
        Me.TimerInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TimerInput.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.TimerInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimerInput.Name = "TimerInput"
        Me.TimerInput.Size = New System.Drawing.Size(71, 22)
        Me.TimerInput.TabIndex = 3
        Me.TimerInput.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(265, 169)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(111, 28)
        Me.PlayButton.TabIndex = 6
        Me.PlayButton.Text = "Jouer"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'ScoresButton
        '
        Me.ScoresButton.Location = New System.Drawing.Point(384, 169)
        Me.ScoresButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScoresButton.Name = "ScoresButton"
        Me.ScoresButton.Size = New System.Drawing.Size(117, 28)
        Me.ScoresButton.TabIndex = 7
        Me.ScoresButton.Text = "Classement"
        Me.ScoresButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(509, 169)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(100, 28)
        Me.QuitButton.TabIndex = 8
        Me.QuitButton.Text = "Quitter"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nom du joueur"
        '
        'NameList
        '
        Me.NameList.FormattingEnabled = True
        Me.NameList.Location = New System.Drawing.Point(265, 39)
        Me.NameList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameList.MaxLength = 10
        Me.NameList.Name = "NameList"
        Me.NameList.Size = New System.Drawing.Size(340, 24)
        Me.NameList.TabIndex = 5
        '
        'PartyList
        '
        Me.PartyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PartyList.Enabled = False
        Me.PartyList.FormattingEnabled = True
        Me.PartyList.Location = New System.Drawing.Point(265, 105)
        Me.PartyList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PartyList.Name = "PartyList"
        Me.PartyList.Size = New System.Drawing.Size(340, 24)
        Me.PartyList.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Charger une partie"
        '
        'DefaultButton
        '
        Me.DefaultButton.Location = New System.Drawing.Point(509, 204)
        Me.DefaultButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(100, 28)
        Me.DefaultButton.TabIndex = 11
        Me.DefaultButton.Text = "Options"
        Me.DefaultButton.UseVisualStyleBackColor = True
        '
        'SetDefaultButton
        '
        Me.SetDefaultButton.Location = New System.Drawing.Point(265, 204)
        Me.SetDefaultButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SetDefaultButton.Name = "SetDefaultButton"
        Me.SetDefaultButton.Size = New System.Drawing.Size(236, 28)
        Me.SetDefaultButton.TabIndex = 12
        Me.SetDefaultButton.Text = "Choisir les paramètres par défaut"
        Me.SetDefaultButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 262)
        Me.Controls.Add(Me.SetDefaultButton)
        Me.Controls.Add(Me.DefaultButton)
        Me.Controls.Add(Me.PartyList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ScoresButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.NameList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SettingsGroup)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(657, 309)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(657, 309)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taquin"
        Me.SettingsGroup.ResumeLayout(False)
        Me.SettingsGroup.PerformLayout()
        CType(Me.LinesInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RowsInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimerInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SettingsGroup As GroupBox
    Friend WithEvents LinesInput As NumericUpDown
    Friend WithEvents RowsInput As NumericUpDown
    Friend WithEvents TimerInput As NumericUpDown
    Friend WithEvents PlayButton As Button
    Friend WithEvents ScoresButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents LowerOption As RadioButton
    Friend WithEvents UpperOption As RadioButton
    Friend WithEvents NumericOption As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents NameList As ComboBox
    Friend WithEvents PartyList As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DefaultButton As Button
    Friend WithEvents SetDefaultButton As Button
    Friend WithEvents ImageOption As RadioButton
    Friend WithEvents WithTimer As CheckBox
End Class
