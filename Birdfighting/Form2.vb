Public Class Form2
    Private Sub btnAb1_Click(sender As Object, e As EventArgs) Handles btnAb1.Click

        Form4.picPlayer1.Image = My.Resources.abernathy
        Form4.picPlayer1.Width = 132
        Form4.picPlayer1.Height = 128

        Form4.player1 = 1
        Form4.p1stock = 3
        Form4.lblP1Status.Text = "Player 1: O O O"

        btnConfirm1.Enabled = True

    End Sub

    Private Sub btnEarl1_Click(sender As Object, e As EventArgs) Handles btnEarl1.Click

        Form4.picPlayer1.Image = My.Resources.earl
        Form4.picPlayer1.Width = 122
        Form4.picPlayer1.Height = 118

        Form4.player1 = 2
        Form4.p1stock = 3
        Form4.lblP1Status.Text = "Player 1: O O O"

        btnConfirm1.Enabled = True

    End Sub

    Private Sub btnHansole1_Click(sender As Object, e As EventArgs) Handles btnHansole1.Click

        'could've probably turned this into a preset but i'm lazy and have approximately 5 hours
        Form4.picPlayer1.Image = My.Resources.hansole
        Form4.picPlayer1.Width = 102
        Form4.picPlayer1.Height = 98

        Form4.player1 = 3
        Form4.p1stock = 2
        Form4.lblP1Status.Text = "Player 1: O O"

        btnConfirm1.Enabled = True

    End Sub

    Private Sub btnConfirm1_Click(sender As Object, e As EventArgs) Handles btnConfirm1.Click

        btnAb1.Enabled = False
        btnEarl1.Enabled = False
        btnHansole1.Enabled = False
        btnConfirm1.Enabled = False

    End Sub

    Private Sub btnAb2_Click(sender As Object, e As EventArgs) Handles btnAb2.Click

        Form4.picPlayer2.Image = My.Resources.abernathy
        Form4.picPlayer2.Width = 132
        Form4.picPlayer2.Height = 128

        Form4.player2 = 1
        Form4.p2stock = 3
        Form4.lblP2Status.Text = "Player 2: O O O"

        btnConfirm2.Enabled = True

    End Sub

    Private Sub btnEarl2_Click(sender As Object, e As EventArgs) Handles btnEarl2.Click

        Form4.picPlayer2.Image = My.Resources.earl
        Form4.picPlayer2.Width = 122
        Form4.picPlayer2.Height = 118

        Form4.player2 = 2
        Form4.p2stock = 3
        Form4.lblP2Status.Text = "Player 2: O O O"

        btnConfirm2.Enabled = True

    End Sub

    Private Sub btnHansole2_Click(sender As Object, e As EventArgs) Handles btnHansole2.Click

        Form4.picPlayer2.Image = My.Resources.hansole
        Form4.picPlayer2.Width = 102
        Form4.picPlayer2.Height = 98

        Form4.player2 = 3
        Form4.p2stock = 2
        Form4.lblP2Status.Text = "Player 2: O O"

        btnConfirm2.Enabled = True

    End Sub

    Private Sub btnConfirm2_Click(sender As Object, e As EventArgs) Handles btnConfirm2.Click

        btnAb2.Enabled = False
        btnEarl2.Enabled = False
        btnHansole2.Enabled = False
        btnConfirm2.Enabled = False

        If btnConfirm1.Enabled = False And btnConfirm2.Enabled = False Then

            Me.Hide()
            Form3.Show()

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub

End Class