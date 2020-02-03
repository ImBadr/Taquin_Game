<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.DirLabel = New System.Windows.Forms.Label()
        Me.LinesLabel = New System.Windows.Forms.Label()
        Me.RowsLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.UseTimerLabel = New System.Windows.Forms.Label()
        Me.AllowBackLabel = New System.Windows.Forms.Label()
        Me.TypeP = New System.Windows.Forms.ComboBox()
        Me.Dir = New System.Windows.Forms.TextBox()
        Me.Lines = New System.Windows.Forms.NumericUpDown()
        Me.Rows = New System.Windows.Forms.NumericUpDown()
        Me.Time = New System.Windows.Forms.NumericUpDown()
        Me.UseTimer = New System.Windows.Forms.CheckBox()
        Me.AllowBack = New System.Windows.Forms.CheckBox()
        Me.OpenFolder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NextStep = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NextStepLabel = New System.Windows.Forms.Label()
        Me.ValidateButton = New System.Windows.Forms.Button()
        CType(Me.Lines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DirLabel
        '
        Me.DirLabel.AutoSize = True
        Me.DirLabel.Location = New System.Drawing.Point(3, 10)
        Me.DirLabel.Name = "DirLabel"
        Me.DirLabel.Size = New System.Drawing.Size(56, 13)
        Me.DirLabel.TabIndex = 0
        Me.DirLabel.Text = "Répertoire"
        '
        'LinesLabel
        '
        Me.LinesLabel.AutoSize = True
        Me.LinesLabel.Location = New System.Drawing.Point(3, 38)
        Me.LinesLabel.Name = "LinesLabel"
        Me.LinesLabel.Size = New System.Drawing.Size(89, 13)
        Me.LinesLabel.TabIndex = 1
        Me.LinesLabel.Text = "Nombre de lignes"
        '
        'RowsLabel
        '
        Me.RowsLabel.AutoSize = True
        Me.RowsLabel.Location = New System.Drawing.Point(3, 65)
        Me.RowsLabel.Name = "RowsLabel"
        Me.RowsLabel.Size = New System.Drawing.Size(105, 13)
        Me.RowsLabel.TabIndex = 2
        Me.RowsLabel.Text = "Nombre de colonnes"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(3, 120)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(39, 13)
        Me.TimeLabel.TabIndex = 3
        Me.TimeLabel.Text = "Temps"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(3, 93)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(78, 13)
        Me.TypeLabel.TabIndex = 4
        Me.TypeLabel.Text = "Type du taquin"
        '
        'UseTimerLabel
        '
        Me.UseTimerLabel.AutoSize = True
        Me.UseTimerLabel.Location = New System.Drawing.Point(3, 145)
        Me.UseTimerLabel.Name = "UseTimerLabel"
        Me.UseTimerLabel.Size = New System.Drawing.Size(78, 13)
        Me.UseTimerLabel.TabIndex = 5
        Me.UseTimerLabel.Text = "Utiliser un timer"
        '
        'AllowBackLabel
        '
        Me.AllowBackLabel.AutoSize = True
        Me.AllowBackLabel.Location = New System.Drawing.Point(3, 188)
        Me.AllowBackLabel.Name = "AllowBackLabel"
        Me.AllowBackLabel.Size = New System.Drawing.Size(91, 13)
        Me.AllowBackLabel.TabIndex = 6
        Me.AllowBackLabel.Text = "Revenir en arrière"
        '
        'TypeP
        '
        Me.TypeP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TypeP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeP.FormattingEnabled = True
        Me.TypeP.Items.AddRange(New Object() {"Numérique", "Image", "Alphabet majuscule", "Alphabet minuscule"})
        Me.TypeP.Location = New System.Drawing.Point(73, 90)
        Me.TypeP.Name = "TypeP"
        Me.TypeP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TypeP.Size = New System.Drawing.Size(162, 21)
        Me.TypeP.TabIndex = 7
        '
        'Dir
        '
        Me.Dir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dir.Location = New System.Drawing.Point(3, 7)
        Me.Dir.Name = "Dir"
        Me.Dir.Size = New System.Drawing.Size(209, 20)
        Me.Dir.TabIndex = 8
        '
        'Lines
        '
        Me.Lines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lines.Location = New System.Drawing.Point(178, 36)
        Me.Lines.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Lines.Name = "Lines"
        Me.Lines.Size = New System.Drawing.Size(56, 20)
        Me.Lines.TabIndex = 9
        Me.Lines.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Rows
        '
        Me.Rows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rows.Location = New System.Drawing.Point(179, 63)
        Me.Rows.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Rows.Name = "Rows"
        Me.Rows.Size = New System.Drawing.Size(56, 20)
        Me.Rows.TabIndex = 10
        Me.Rows.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Time
        '
        Me.Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Time.Location = New System.Drawing.Point(179, 118)
        Me.Time.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(56, 20)
        Me.Time.TabIndex = 11
        '
        'UseTimer
        '
        Me.UseTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UseTimer.AutoSize = True
        Me.UseTimer.Location = New System.Drawing.Point(219, 145)
        Me.UseTimer.Name = "UseTimer"
        Me.UseTimer.Size = New System.Drawing.Size(15, 14)
        Me.UseTimer.TabIndex = 12
        Me.UseTimer.UseVisualStyleBackColor = True
        '
        'AllowBack
        '
        Me.AllowBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllowBack.AutoSize = True
        Me.AllowBack.Location = New System.Drawing.Point(219, 187)
        Me.AllowBack.Name = "AllowBack"
        Me.AllowBack.Size = New System.Drawing.Size(15, 14)
        Me.AllowBack.TabIndex = 13
        Me.AllowBack.UseVisualStyleBackColor = True
        '
        'OpenFolder
        '
        Me.OpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenFolder.Location = New System.Drawing.Point(214, 6)
        Me.OpenFolder.Name = "OpenFolder"
        Me.OpenFolder.Size = New System.Drawing.Size(22, 22)
        Me.OpenFolder.TabIndex = 14
        Me.OpenFolder.Text = "O"
        Me.OpenFolder.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.NextStep)
        Me.Panel1.Controls.Add(Me.TypeP)
        Me.Panel1.Controls.Add(Me.OpenFolder)
        Me.Panel1.Controls.Add(Me.Dir)
        Me.Panel1.Controls.Add(Me.AllowBack)
        Me.Panel1.Controls.Add(Me.Lines)
        Me.Panel1.Controls.Add(Me.UseTimer)
        Me.Panel1.Controls.Add(Me.Rows)
        Me.Panel1.Controls.Add(Me.Time)
        Me.Panel1.Location = New System.Drawing.Point(129, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 218)
        Me.Panel1.TabIndex = 15
        '
        'NextStep
        '
        Me.NextStep.AutoSize = True
        Me.NextStep.Location = New System.Drawing.Point(219, 166)
        Me.NextStep.Name = "NextStep"
        Me.NextStep.Size = New System.Drawing.Size(15, 14)
        Me.NextStep.TabIndex = 15
        Me.NextStep.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NextStepLabel)
        Me.Panel2.Controls.Add(Me.DirLabel)
        Me.Panel2.Controls.Add(Me.LinesLabel)
        Me.Panel2.Controls.Add(Me.AllowBackLabel)
        Me.Panel2.Controls.Add(Me.RowsLabel)
        Me.Panel2.Controls.Add(Me.UseTimerLabel)
        Me.Panel2.Controls.Add(Me.TimeLabel)
        Me.Panel2.Controls.Add(Me.TypeLabel)
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(111, 218)
        Me.Panel2.TabIndex = 16
        '
        'NextStepLabel
        '
        Me.NextStepLabel.AutoSize = True
        Me.NextStepLabel.Location = New System.Drawing.Point(3, 166)
        Me.NextStepLabel.Name = "NextStepLabel"
        Me.NextStepLabel.Size = New System.Drawing.Size(78, 13)
        Me.NextStepLabel.TabIndex = 7
        Me.NextStepLabel.Text = "Étape suivante"
        '
        'ValidateButton
        '
        Me.ValidateButton.Location = New System.Drawing.Point(290, 246)
        Me.ValidateButton.Name = "ValidateButton"
        Me.ValidateButton.Size = New System.Drawing.Size(75, 23)
        Me.ValidateButton.TabIndex = 17
        Me.ValidateButton.Text = "Valider"
        Me.ValidateButton.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 281)
        Me.Controls.Add(Me.ValidateButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(405, 320)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(393, 320)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        CType(Me.Lines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DirLabel As Label
    Friend WithEvents LinesLabel As Label
    Friend WithEvents RowsLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents UseTimerLabel As Label
    Friend WithEvents AllowBackLabel As Label
    Friend WithEvents TypeP As ComboBox
    Friend WithEvents Dir As TextBox
    Friend WithEvents Lines As NumericUpDown
    Friend WithEvents Rows As NumericUpDown
    Friend WithEvents Time As NumericUpDown
    Friend WithEvents UseTimer As CheckBox
    Friend WithEvents AllowBack As CheckBox
    Friend WithEvents OpenFolder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ValidateButton As Button
    Friend WithEvents NextStep As CheckBox
    Friend WithEvents NextStepLabel As Label
End Class
