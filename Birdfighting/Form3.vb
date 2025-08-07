Public Class Form3

    Private Sub btnWords_Click(sender As Object, e As EventArgs) Handles btnWords.Click

        Form4.lblBoo.Visible = True
        Form4.lblRun.Visible = True
        Form4.lblBoo.Enabled = True
        Form4.lblRun.Enabled = True
        Form4.picWren.Enabled = False
        Form4.picSheep.Enabled = False
        Form4.picWren.Visible = False
        Form4.picSheep.Visible = False
        btnConfirm.Enabled = True

    End Sub

    Private Sub btnBirds_Click(sender As Object, e As EventArgs) Handles btnBirds.Click

        Form4.lblBoo.Visible = False
        Form4.lblRun.Visible = False
        Form4.lblBoo.Enabled = False
        Form4.lblRun.Enabled = False
        Form4.picWren.Enabled = True
        Form4.picSheep.Enabled = True
        Form4.picWren.Visible = True
        Form4.picSheep.Visible = True
        btnConfirm.Enabled = True

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Form2.btnConfirm1.Enabled = True
        Form2.btnConfirm2.Enabled = True
        Form2.btnAb1.Enabled = True
        Form2.btnAb2.Enabled = True
        Form2.btnEarl1.Enabled = True
        Form2.btnEarl2.Enabled = True
        Form2.btnHansole1.Enabled = True
        Form2.btnHansole2.Enabled = True

        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub
End Class