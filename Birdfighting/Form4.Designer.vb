<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picSheep = New System.Windows.Forms.PictureBox()
        Me.picWren = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.lblBoo = New System.Windows.Forms.Label()
        Me.lblRun = New System.Windows.Forms.Label()
        Me.picStick1 = New System.Windows.Forms.PictureBox()
        Me.picFork2 = New System.Windows.Forms.PictureBox()
        Me.picShinyFork = New System.Windows.Forms.PictureBox()
        Me.tmrStab = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAngry1 = New System.Windows.Forms.Timer(Me.components)
        Me.picStick2 = New System.Windows.Forms.PictureBox()
        Me.picStick3 = New System.Windows.Forms.PictureBox()
        Me.picFork1 = New System.Windows.Forms.PictureBox()
        Me.lblP1Status = New System.Windows.Forms.Label()
        Me.lblP2Status = New System.Windows.Forms.Label()
        Me.tmrAngry2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSheep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStick1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFork2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShinyFork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStick3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFork1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer2
        '
        Me.picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2.Image = Global.Birdfighting.My.Resources.Resources.abernathy
        Me.picPlayer2.Location = New System.Drawing.Point(34, 371)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(102, 98)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer2.TabIndex = 15
        Me.picPlayer2.TabStop = False
        '
        'picSheep
        '
        Me.picSheep.Image = CType(resources.GetObject("picSheep.Image"), System.Drawing.Image)
        Me.picSheep.Location = New System.Drawing.Point(612, 265)
        Me.picSheep.Name = "picSheep"
        Me.picSheep.Size = New System.Drawing.Size(170, 89)
        Me.picSheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSheep.TabIndex = 14
        Me.picSheep.TabStop = False
        '
        'picWren
        '
        Me.picWren.Image = CType(resources.GetObject("picWren.Image"), System.Drawing.Image)
        Me.picWren.Location = New System.Drawing.Point(205, 86)
        Me.picWren.Name = "picWren"
        Me.picWren.Size = New System.Drawing.Size(157, 151)
        Me.picWren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWren.TabIndex = 13
        Me.picWren.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1.Image = Global.Birdfighting.My.Resources.Resources.angry_hansole
        Me.picPlayer1.Location = New System.Drawing.Point(802, 19)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(102, 98)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 16
        Me.picPlayer1.TabStop = False
        '
        'lblBoo
        '
        Me.lblBoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBoo.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoo.Location = New System.Drawing.Point(612, 120)
        Me.lblBoo.Name = "lblBoo"
        Me.lblBoo.Size = New System.Drawing.Size(117, 48)
        Me.lblBoo.TabIndex = 17
        Me.lblBoo.Text = "b o o"
        '
        'lblRun
        '
        Me.lblRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRun.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRun.Location = New System.Drawing.Point(256, 247)
        Me.lblRun.Name = "lblRun"
        Me.lblRun.Size = New System.Drawing.Size(233, 136)
        Me.lblRun.TabIndex = 18
        Me.lblRun.Text = "run before they catch you               :)"
        '
        'picStick1
        '
        Me.picStick1.Enabled = False
        Me.picStick1.Image = Global.Birdfighting.My.Resources.Resources.stick
        Me.picStick1.Location = New System.Drawing.Point(79, 276)
        Me.picStick1.Name = "picStick1"
        Me.picStick1.Size = New System.Drawing.Size(82, 29)
        Me.picStick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStick1.TabIndex = 19
        Me.picStick1.TabStop = False
        Me.picStick1.Visible = False
        '
        'picFork2
        '
        Me.picFork2.Enabled = False
        Me.picFork2.Image = CType(resources.GetObject("picFork2.Image"), System.Drawing.Image)
        Me.picFork2.Location = New System.Drawing.Point(775, 410)
        Me.picFork2.Name = "picFork2"
        Me.picFork2.Size = New System.Drawing.Size(111, 103)
        Me.picFork2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFork2.TabIndex = 20
        Me.picFork2.TabStop = False
        Me.picFork2.Visible = False
        '
        'picShinyFork
        '
        Me.picShinyFork.Enabled = False
        Me.picShinyFork.Image = Global.Birdfighting.My.Resources.Resources.gold_fork
        Me.picShinyFork.Location = New System.Drawing.Point(502, 166)
        Me.picShinyFork.Name = "picShinyFork"
        Me.picShinyFork.Size = New System.Drawing.Size(93, 71)
        Me.picShinyFork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShinyFork.TabIndex = 21
        Me.picShinyFork.TabStop = False
        Me.picShinyFork.Visible = False
        '
        'tmrStab
        '
        Me.tmrStab.Interval = 15000
        '
        'tmrAngry1
        '
        Me.tmrAngry1.Interval = 5000
        '
        'picStick2
        '
        Me.picStick2.Enabled = False
        Me.picStick2.Image = Global.Birdfighting.My.Resources.Resources.stick
        Me.picStick2.Location = New System.Drawing.Point(270, 428)
        Me.picStick2.Name = "picStick2"
        Me.picStick2.Size = New System.Drawing.Size(82, 29)
        Me.picStick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStick2.TabIndex = 22
        Me.picStick2.TabStop = False
        Me.picStick2.Visible = False
        '
        'picStick3
        '
        Me.picStick3.Enabled = False
        Me.picStick3.Image = Global.Birdfighting.My.Resources.Resources.stick
        Me.picStick3.Location = New System.Drawing.Point(502, 428)
        Me.picStick3.Name = "picStick3"
        Me.picStick3.Size = New System.Drawing.Size(82, 29)
        Me.picStick3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStick3.TabIndex = 23
        Me.picStick3.TabStop = False
        Me.picStick3.Visible = False
        '
        'picFork1
        '
        Me.picFork1.Enabled = False
        Me.picFork1.Image = CType(resources.GetObject("picFork1.Image"), System.Drawing.Image)
        Me.picFork1.Location = New System.Drawing.Point(621, 360)
        Me.picFork1.Name = "picFork1"
        Me.picFork1.Size = New System.Drawing.Size(111, 103)
        Me.picFork1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFork1.TabIndex = 24
        Me.picFork1.TabStop = False
        Me.picFork1.Visible = False
        '
        'lblP1Status
        '
        Me.lblP1Status.AutoSize = True
        Me.lblP1Status.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Status.Location = New System.Drawing.Point(855, 2)
        Me.lblP1Status.Name = "lblP1Status"
        Me.lblP1Status.Size = New System.Drawing.Size(88, 14)
        Me.lblP1Status.TabIndex = 25
        Me.lblP1Status.Text = "Player 1: O O O"
        '
        'lblP2Status
        '
        Me.lblP2Status.AutoSize = True
        Me.lblP2Status.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Status.Location = New System.Drawing.Point(3, 498)
        Me.lblP2Status.Name = "lblP2Status"
        Me.lblP2Status.Size = New System.Drawing.Size(88, 14)
        Me.lblP2Status.TabIndex = 26
        Me.lblP2Status.Text = "Player 2: O O O"
        '
        'tmrAngry2
        '
        Me.tmrAngry2.Interval = 5000
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(945, 513)
        Me.Controls.Add(Me.lblP2Status)
        Me.Controls.Add(Me.lblP1Status)
        Me.Controls.Add(Me.picFork1)
        Me.Controls.Add(Me.picStick3)
        Me.Controls.Add(Me.picStick2)
        Me.Controls.Add(Me.picShinyFork)
        Me.Controls.Add(Me.picFork2)
        Me.Controls.Add(Me.picStick1)
        Me.Controls.Add(Me.lblRun)
        Me.Controls.Add(Me.lblBoo)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picSheep)
        Me.Controls.Add(Me.picWren)
        Me.Name = "Form4"
        Me.Text = "fight to the death"
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSheep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStick1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFork2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShinyFork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStick3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFork1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picWren As PictureBox
    Friend WithEvents picSheep As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents lblBoo As Label
    Friend WithEvents lblRun As Label
    Friend WithEvents picStick1 As PictureBox
    Friend WithEvents picFork2 As PictureBox
    Friend WithEvents picShinyFork As PictureBox
    Friend WithEvents tmrStab As Timer
    Friend WithEvents tmrAngry1 As Timer
    Friend WithEvents picStick2 As PictureBox
    Friend WithEvents picStick3 As PictureBox
    Friend WithEvents picFork1 As PictureBox
    Public WithEvents lblP1Status As Label
    Public WithEvents lblP2Status As Label
    Friend WithEvents tmrAngry2 As Timer
End Class
