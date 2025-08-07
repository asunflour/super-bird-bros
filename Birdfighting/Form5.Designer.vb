<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picWinner = New System.Windows.Forms.PictureBox()
        Me.picLoser = New System.Windows.Forms.PictureBox()
        CType(Me.picWinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(144, 80)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(272, 61)
        Me.lblWinner.TabIndex = 0
        Me.lblWinner.Text = "Player 2 Wins"
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPlayAgain.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.Location = New System.Drawing.Point(205, 360)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(145, 63)
        Me.btnPlayAgain.TabIndex = 5
        Me.btnPlayAgain.Text = "play again?"
        Me.btnPlayAgain.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(205, 449)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 94)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picWinner
        '
        Me.picWinner.Location = New System.Drawing.Point(168, 144)
        Me.picWinner.Name = "picWinner"
        Me.picWinner.Size = New System.Drawing.Size(220, 188)
        Me.picWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinner.TabIndex = 1
        Me.picWinner.TabStop = False
        '
        'picLoser
        '
        Me.picLoser.Location = New System.Drawing.Point(394, 279)
        Me.picLoser.Name = "picLoser"
        Me.picLoser.Size = New System.Drawing.Size(57, 53)
        Me.picLoser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLoser.TabIndex = 11
        Me.picLoser.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 607)
        Me.Controls.Add(Me.picLoser)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.picWinner)
        Me.Controls.Add(Me.lblWinner)
        Me.Name = "Form5"
        Me.Text = "endscreen"
        CType(Me.picWinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWinner As Label
    Friend WithEvents picWinner As PictureBox
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picLoser As PictureBox
End Class
