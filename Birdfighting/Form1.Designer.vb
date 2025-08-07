<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(222, 231)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(177, 48)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInstructions.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.Location = New System.Drawing.Point(222, 307)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(177, 48)
        Me.btnInstructions.TabIndex = 2
        Me.btnInstructions.Text = "instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(542, 338)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 55)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.Color.Transparent
        Me.picTitle.Image = Global.Birdfighting.My.Resources.Resources.super_bird_bros_title
        Me.picTitle.Location = New System.Drawing.Point(60, 26)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(511, 185)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 0
        Me.picTitle.TabStop = False
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(86, 102)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(453, 156)
        Me.lblInstructions.TabIndex = 4
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInstructions.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Blue
        Me.btnBack.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(247, 269)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(126, 46)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 394)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picTitle)
        Me.Name = "Form1"
        Me.Text = "SUPER BIRD BROS"
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picTitle As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnBack As Button
End Class
