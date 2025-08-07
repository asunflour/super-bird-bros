<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnWords = New System.Windows.Forms.Button()
        Me.btnBirds = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWords
        '
        Me.btnWords.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWords.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWords.Location = New System.Drawing.Point(35, 45)
        Me.btnWords.Name = "btnWords"
        Me.btnWords.Size = New System.Drawing.Size(112, 43)
        Me.btnWords.TabIndex = 4
        Me.btnWords.Text = "words"
        Me.btnWords.UseVisualStyleBackColor = False
        '
        'btnBirds
        '
        Me.btnBirds.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBirds.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBirds.Location = New System.Drawing.Point(213, 45)
        Me.btnBirds.Name = "btnBirds"
        Me.btnBirds.Size = New System.Drawing.Size(112, 43)
        Me.btnBirds.TabIndex = 5
        Me.btnBirds.Text = "Birds"
        Me.btnBirds.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Blue
        Me.btnBack.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(128, 179)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 43)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(128, 115)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(112, 43)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(286, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 55)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 267)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBirds)
        Me.Controls.Add(Me.btnWords)
        Me.Name = "Form3"
        Me.Text = "map selection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWords As Button
    Friend WithEvents btnBirds As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnExit As Button
End Class
