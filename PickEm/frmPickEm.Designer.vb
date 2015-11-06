<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickEm
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lbScore = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.grpPick = New System.Windows.Forms.GroupBox()
        Me.radSame = New System.Windows.Forms.RadioButton()
        Me.radLower = New System.Windows.Forms.RadioButton()
        Me.radHigher = New System.Windows.Forms.RadioButton()
        Me.btnDeck = New System.Windows.Forms.Button()
        Me.lblFaceCard = New System.Windows.Forms.Label()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.lblSame = New System.Windows.Forms.Label()
        Me.txtPickSame = New System.Windows.Forms.TextBox()
        Me.txtActualSame = New System.Windows.Forms.TextBox()
        Me.lblLower = New System.Windows.Forms.Label()
        Me.txtPickLower = New System.Windows.Forms.TextBox()
        Me.txtActualLower = New System.Windows.Forms.TextBox()
        Me.lblHigher = New System.Windows.Forms.Label()
        Me.txtPickHigher = New System.Windows.Forms.TextBox()
        Me.txtActualHigher = New System.Windows.Forms.TextBox()
        Me.lblPicks = New System.Windows.Forms.Label()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.grpPick.SuspendLayout()
        Me.grpStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(17, 16)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 28)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lbScore
        '
        Me.lbScore.AutoSize = True
        Me.lbScore.Location = New System.Drawing.Point(17, 53)
        Me.lbScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbScore.Name = "lbScore"
        Me.lbScore.Size = New System.Drawing.Size(45, 17)
        Me.lbScore.TabIndex = 1
        Me.lbScore.Text = "Score"
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.SystemColors.Info
        Me.txtScore.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtScore.Location = New System.Drawing.Point(17, 74)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(99, 22)
        Me.txtScore.TabIndex = 2
        Me.txtScore.Text = "0"
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpPick
        '
        Me.grpPick.Controls.Add(Me.radSame)
        Me.grpPick.Controls.Add(Me.radLower)
        Me.grpPick.Controls.Add(Me.radHigher)
        Me.grpPick.Enabled = False
        Me.grpPick.Location = New System.Drawing.Point(127, 16)
        Me.grpPick.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPick.Name = "grpPick"
        Me.grpPick.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPick.Size = New System.Drawing.Size(129, 123)
        Me.grpPick.TabIndex = 3
        Me.grpPick.TabStop = False
        Me.grpPick.Text = "Your Pick"
        '
        'radSame
        '
        Me.radSame.AutoSize = True
        Me.radSame.Location = New System.Drawing.Point(9, 84)
        Me.radSame.Margin = New System.Windows.Forms.Padding(4)
        Me.radSame.Name = "radSame"
        Me.radSame.Size = New System.Drawing.Size(65, 21)
        Me.radSame.TabIndex = 2
        Me.radSame.TabStop = True
        Me.radSame.Text = "Same"
        Me.radSame.UseVisualStyleBackColor = True
        '
        'radLower
        '
        Me.radLower.AutoSize = True
        Me.radLower.Location = New System.Drawing.Point(9, 54)
        Me.radLower.Margin = New System.Windows.Forms.Padding(4)
        Me.radLower.Name = "radLower"
        Me.radLower.Size = New System.Drawing.Size(67, 21)
        Me.radLower.TabIndex = 1
        Me.radLower.TabStop = True
        Me.radLower.Text = "Lower"
        Me.radLower.UseVisualStyleBackColor = True
        '
        'radHigher
        '
        Me.radHigher.AutoSize = True
        Me.radHigher.Location = New System.Drawing.Point(9, 25)
        Me.radHigher.Margin = New System.Windows.Forms.Padding(4)
        Me.radHigher.Name = "radHigher"
        Me.radHigher.Size = New System.Drawing.Size(71, 21)
        Me.radHigher.TabIndex = 0
        Me.radHigher.TabStop = True
        Me.radHigher.Text = "Higher"
        Me.radHigher.UseVisualStyleBackColor = True
        '
        'btnDeck
        '
        Me.btnDeck.Enabled = False
        Me.btnDeck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeck.Location = New System.Drawing.Point(264, 15)
        Me.btnDeck.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeck.Name = "btnDeck"
        Me.btnDeck.Size = New System.Drawing.Size(100, 124)
        Me.btnDeck.TabIndex = 4
        Me.btnDeck.Text = "Click to flip card"
        Me.btnDeck.UseVisualStyleBackColor = True
        '
        'lblFaceCard
        '
        Me.lblFaceCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFaceCard.Font = New System.Drawing.Font("Symbol", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaceCard.ForeColor = System.Drawing.Color.Red
        Me.lblFaceCard.Location = New System.Drawing.Point(373, 16)
        Me.lblFaceCard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFaceCard.Name = "lblFaceCard"
        Me.lblFaceCard.Size = New System.Drawing.Size(97, 123)
        Me.lblFaceCard.TabIndex = 5
        Me.lblFaceCard.Text = "7ª©¨§"
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.lblSame)
        Me.grpStats.Controls.Add(Me.txtPickSame)
        Me.grpStats.Controls.Add(Me.txtActualSame)
        Me.grpStats.Controls.Add(Me.lblLower)
        Me.grpStats.Controls.Add(Me.txtPickLower)
        Me.grpStats.Controls.Add(Me.txtActualLower)
        Me.grpStats.Controls.Add(Me.lblHigher)
        Me.grpStats.Controls.Add(Me.txtPickHigher)
        Me.grpStats.Controls.Add(Me.txtActualHigher)
        Me.grpStats.Controls.Add(Me.lblPicks)
        Me.grpStats.Controls.Add(Me.lblActual)
        Me.grpStats.Enabled = False
        Me.grpStats.Location = New System.Drawing.Point(16, 146)
        Me.grpStats.Margin = New System.Windows.Forms.Padding(4)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Padding = New System.Windows.Forms.Padding(4)
        Me.grpStats.Size = New System.Drawing.Size(455, 174)
        Me.grpStats.TabIndex = 6
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "Stats"
        '
        'lblSame
        '
        Me.lblSame.AutoSize = True
        Me.lblSame.Location = New System.Drawing.Point(60, 113)
        Me.lblSame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSame.Name = "lblSame"
        Me.lblSame.Size = New System.Drawing.Size(44, 17)
        Me.lblSame.TabIndex = 2
        Me.lblSame.Text = "Same"
        '
        'txtPickSame
        '
        Me.txtPickSame.Location = New System.Drawing.Point(261, 110)
        Me.txtPickSame.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPickSame.Name = "txtPickSame"
        Me.txtPickSame.Size = New System.Drawing.Size(132, 22)
        Me.txtPickSame.TabIndex = 10
        Me.txtPickSame.Text = "0"
        '
        'txtActualSame
        '
        Me.txtActualSame.Location = New System.Drawing.Point(121, 113)
        Me.txtActualSame.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActualSame.Name = "txtActualSame"
        Me.txtActualSame.Size = New System.Drawing.Size(132, 22)
        Me.txtActualSame.TabIndex = 6
        Me.txtActualSame.Text = "0"
        '
        'lblLower
        '
        Me.lblLower.AutoSize = True
        Me.lblLower.Location = New System.Drawing.Point(60, 81)
        Me.lblLower.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLower.Name = "lblLower"
        Me.lblLower.Size = New System.Drawing.Size(46, 17)
        Me.lblLower.TabIndex = 1
        Me.lblLower.Text = "Lower"
        '
        'txtPickLower
        '
        Me.txtPickLower.Location = New System.Drawing.Point(261, 78)
        Me.txtPickLower.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPickLower.Name = "txtPickLower"
        Me.txtPickLower.Size = New System.Drawing.Size(132, 22)
        Me.txtPickLower.TabIndex = 9
        Me.txtPickLower.Text = "0"
        '
        'txtActualLower
        '
        Me.txtActualLower.Location = New System.Drawing.Point(120, 78)
        Me.txtActualLower.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActualLower.Name = "txtActualLower"
        Me.txtActualLower.Size = New System.Drawing.Size(132, 22)
        Me.txtActualLower.TabIndex = 5
        Me.txtActualLower.Text = "0"
        '
        'lblHigher
        '
        Me.lblHigher.AutoSize = True
        Me.lblHigher.Location = New System.Drawing.Point(60, 49)
        Me.lblHigher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHigher.Name = "lblHigher"
        Me.lblHigher.Size = New System.Drawing.Size(50, 17)
        Me.lblHigher.TabIndex = 0
        Me.lblHigher.Text = "Higher"
        '
        'txtPickHigher
        '
        Me.txtPickHigher.Location = New System.Drawing.Point(261, 46)
        Me.txtPickHigher.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPickHigher.Name = "txtPickHigher"
        Me.txtPickHigher.Size = New System.Drawing.Size(132, 22)
        Me.txtPickHigher.TabIndex = 8
        Me.txtPickHigher.Text = "0"
        '
        'txtActualHigher
        '
        Me.txtActualHigher.Location = New System.Drawing.Point(120, 46)
        Me.txtActualHigher.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActualHigher.Name = "txtActualHigher"
        Me.txtActualHigher.Size = New System.Drawing.Size(132, 22)
        Me.txtActualHigher.TabIndex = 4
        Me.txtActualHigher.Text = "0"
        '
        'lblPicks
        '
        Me.lblPicks.AutoSize = True
        Me.lblPicks.Location = New System.Drawing.Point(257, 26)
        Me.lblPicks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPicks.Name = "lblPicks"
        Me.lblPicks.Size = New System.Drawing.Size(75, 17)
        Me.lblPicks.TabIndex = 7
        Me.lblPicks.Text = "Your Picks"
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Location = New System.Drawing.Point(116, 25)
        Me.lblActual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(47, 17)
        Me.lblActual.TabIndex = 3
        Me.lblActual.Text = "Actual"
        '
        'frmPickEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 335)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.lblFaceCard)
        Me.Controls.Add(Me.btnDeck)
        Me.Controls.Add(Me.grpPick)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lbScore)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPickEm"
        Me.Text = "frmPickEm"
        Me.grpPick.ResumeLayout(False)
        Me.grpPick.PerformLayout()
        Me.grpStats.ResumeLayout(False)
        Me.grpStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lbScore As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents grpPick As System.Windows.Forms.GroupBox
    Friend WithEvents radSame As System.Windows.Forms.RadioButton
    Friend WithEvents radLower As System.Windows.Forms.RadioButton
    Friend WithEvents radHigher As System.Windows.Forms.RadioButton
    Friend WithEvents btnDeck As System.Windows.Forms.Button
    Friend WithEvents lblFaceCard As System.Windows.Forms.Label
    Friend WithEvents grpStats As System.Windows.Forms.GroupBox
    Friend WithEvents lblSame As System.Windows.Forms.Label
    Friend WithEvents txtPickSame As System.Windows.Forms.TextBox
    Friend WithEvents txtActualSame As System.Windows.Forms.TextBox
    Friend WithEvents lblLower As System.Windows.Forms.Label
    Friend WithEvents txtPickLower As System.Windows.Forms.TextBox
    Friend WithEvents txtActualLower As System.Windows.Forms.TextBox
    Friend WithEvents lblHigher As System.Windows.Forms.Label
    Friend WithEvents txtPickHigher As System.Windows.Forms.TextBox
    Friend WithEvents txtActualHigher As System.Windows.Forms.TextBox
    Friend WithEvents lblPicks As System.Windows.Forms.Label
    Friend WithEvents lblActual As System.Windows.Forms.Label
End Class
