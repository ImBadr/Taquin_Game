<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Taquin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Grid = New System.Windows.Forms.GroupBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.Infos = New System.Windows.Forms.GroupBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.FinalImage = New System.Windows.Forms.PictureBox()
        Me.Infos.SuspendLayout()
        CType(Me.FinalImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(200, 100)
        Me.Grid.TabIndex = 0
        Me.Grid.TabStop = False
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(10, 25)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 2
        Me.Username.Text = "Username"
        '
        'TimerLabel
        '
        Me.TimerLabel.Location = New System.Drawing.Point(0, 0)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(100, 23)
        Me.TimerLabel.TabIndex = 3
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(0, 0)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 0
        Me.QuitButton.Text = "Abandonner"
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(0, 0)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 1
        Me.NextButton.Text = "Après"
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(0, 0)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(75, 23)
        Me.PrevButton.TabIndex = 2
        Me.PrevButton.Text = "Avant"
        '
        'Infos
        '
        Me.Infos.Controls.Add(Me.QuitButton)
        Me.Infos.Controls.Add(Me.NextButton)
        Me.Infos.Controls.Add(Me.PrevButton)
        Me.Infos.Controls.Add(Me.TimerLabel)
        Me.Infos.Controls.Add(Me.Username)
        Me.Infos.Location = New System.Drawing.Point(10, 15)
        Me.Infos.Name = "Infos"
        Me.Infos.Size = New System.Drawing.Size(200, 100)
        Me.Infos.TabIndex = 1
        Me.Infos.TabStop = False
        Me.Infos.Text = "Infos"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'FinalImage
        '
        Me.FinalImage.Location = New System.Drawing.Point(12, 12)
        Me.FinalImage.Name = "FinalImage"
        Me.FinalImage.Size = New System.Drawing.Size(260, 237)
        Me.FinalImage.TabIndex = 0
        Me.FinalImage.TabStop = False
        Me.FinalImage.Visible = False
        '
        'Taquin
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.FinalImage)
        Me.Name = "Taquin"
        Me.Infos.ResumeLayout(False)
        Me.Infos.PerformLayout()
        CType(Me.FinalImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Infos As GroupBox
    Friend WithEvents Grid As GroupBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents PrevButton As Button
    Friend WithEvents TimerLabel As Label
    Friend WithEvents Username As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents FinalImage As PictureBox
End Class
