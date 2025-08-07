Public Class Form5
    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click

        Me.Hide()
        Form2.Show()

        Form2.btnConfirm1.Enabled = True
        Form2.btnConfirm2.Enabled = True
        Form2.btnAb1.Enabled = True
        Form2.btnAb2.Enabled = True
        Form2.btnEarl1.Enabled = True
        Form2.btnEarl2.Enabled = True
        Form2.btnHansole1.Enabled = True
        Form2.btnHansole2.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub
End Class