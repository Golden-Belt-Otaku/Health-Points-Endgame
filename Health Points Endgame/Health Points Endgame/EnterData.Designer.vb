<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WinnerName = New System.Windows.Forms.TextBox()
        Me.PrizeAmount = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.WinnerLabel = New System.Windows.Forms.Label()
        Me.PrizeLabel = New System.Windows.Forms.Label()
        Me.Health = New System.Windows.Forms.Label()
        Me.Endgame = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WinnerName
        '
        Me.WinnerName.Location = New System.Drawing.Point(297, 109)
        Me.WinnerName.Name = "WinnerName"
        Me.WinnerName.Size = New System.Drawing.Size(239, 20)
        Me.WinnerName.TabIndex = 0
        '
        'PrizeAmount
        '
        Me.PrizeAmount.Location = New System.Drawing.Point(297, 182)
        Me.PrizeAmount.Name = "PrizeAmount"
        Me.PrizeAmount.Size = New System.Drawing.Size(239, 20)
        Me.PrizeAmount.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(297, 269)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(239, 20)
        Me.TextBox3.TabIndex = 2
        '
        'WinnerLabel
        '
        Me.WinnerLabel.AutoSize = True
        Me.WinnerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinnerLabel.Location = New System.Drawing.Point(57, 94)
        Me.WinnerLabel.Name = "WinnerLabel"
        Me.WinnerLabel.Size = New System.Drawing.Size(119, 37)
        Me.WinnerLabel.TabIndex = 3
        Me.WinnerLabel.Text = "Winner"
        '
        'PrizeLabel
        '
        Me.PrizeLabel.AutoSize = True
        Me.PrizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrizeLabel.Location = New System.Drawing.Point(57, 167)
        Me.PrizeLabel.Name = "PrizeLabel"
        Me.PrizeLabel.Size = New System.Drawing.Size(210, 37)
        Me.PrizeLabel.TabIndex = 4
        Me.PrizeLabel.Text = "Prize Amount"
        '
        'Health
        '
        Me.Health.AutoSize = True
        Me.Health.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Health.Location = New System.Drawing.Point(57, 252)
        Me.Health.Name = "Health"
        Me.Health.Size = New System.Drawing.Size(109, 37)
        Me.Health.TabIndex = 5
        Me.Health.Text = "Health"
        '
        'Endgame
        '
        Me.Endgame.Location = New System.Drawing.Point(473, 323)
        Me.Endgame.Name = "Endgame"
        Me.Endgame.Size = New System.Drawing.Size(281, 103)
        Me.Endgame.TabIndex = 6
        Me.Endgame.Text = "Go to Endgame"
        Me.Endgame.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(64, 323)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(281, 103)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EnterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Endgame)
        Me.Controls.Add(Me.Health)
        Me.Controls.Add(Me.PrizeLabel)
        Me.Controls.Add(Me.WinnerLabel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PrizeAmount)
        Me.Controls.Add(Me.WinnerName)
        Me.Name = "EnterData"
        Me.Text = "Enter Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinnerName As TextBox
    Friend WithEvents PrizeAmount As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents WinnerLabel As Label
    Friend WithEvents PrizeLabel As Label
    Friend WithEvents Health As Label
    Friend WithEvents Endgame As Button
    Friend WithEvents ExitButton As Button
End Class
