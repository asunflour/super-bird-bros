Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click

        picTitle.Visible = False
        btnInstructions.Visible = False
        btnStart.Visible = False

        btnBack.Visible = True
        lblInstructions.Visible = True

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        picTitle.Visible = True
        btnInstructions.Visible = True
        btnStart.Visible = True

        btnBack.Visible = False
        lblInstructions.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub
End Class
