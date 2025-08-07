Public Class Form4

    Public p1stock As Integer = 3
    Public p2stock As Integer = 3
    Public player1 As Integer
    Public player2 As Integer
    Public stabenablednum As Integer
    Dim weaponvalue1 As Integer = 0
    Dim weaponvalue2 As Integer = 0

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load

        tmrStab.Start()

    End Sub

    Private Sub tmrStab_Tick() Handles tmrStab.Tick

        If stabenablednum < 6 Then

            Dim stab As Integer = Int(6 * Rnd() + 1)

            If picSheep.Enabled = True And picWren.Enabled = True Then

                Select Case stab

                    Case 1

                        picStick1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picStick1.Bounds.IntersectsWith(picSheep.Bounds) Or picStick1.Bounds.IntersectsWith(picWren.Bounds) Then

                            Do
                                picStick1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picStick1.Bounds.IntersectsWith(picSheep.Bounds) = False And picStick1.Bounds.IntersectsWith(picWren.Bounds) = False

                        End If

                        picStick1.Visible = True
                        picStick1.Enabled = True

                        stabenablednum += 1

                    Case 2

                        picStick1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picStick2.Bounds.IntersectsWith(picSheep.Bounds) Or picStick2.Bounds.IntersectsWith(picWren.Bounds) Then

                            Do
                                picStick2.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picStick2.Bounds.IntersectsWith(picSheep.Bounds) = False And picStick2.Bounds.IntersectsWith(picWren.Bounds) = False

                        End If

                        picStick2.Visible = True
                        picStick2.Enabled = True

                        stabenablednum += 1

                    Case 3

                        picStick3.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picStick3.Bounds.IntersectsWith(picSheep.Bounds) Or picStick3.Bounds.IntersectsWith(picWren.Bounds) Then

                            Do
                                picStick3.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picStick3.Bounds.IntersectsWith(picSheep.Bounds) = False And picStick3.Bounds.IntersectsWith(picWren.Bounds) = False

                        End If

                        picStick3.Visible = True
                        picStick3.Enabled = True

                        stabenablednum += 1

                    Case 4

                        picFork1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picFork1.Bounds.IntersectsWith(picSheep.Bounds) Or picFork1.Bounds.IntersectsWith(picWren.Bounds) Then

                            Do
                                picFork1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picFork1.Bounds.IntersectsWith(picSheep.Bounds) = False And picFork1.Bounds.IntersectsWith(picWren.Bounds) = False

                        End If

                        picFork1.Visible = True
                        picFork1.Enabled = True

                        stabenablednum += 1

                    Case 5

                        picFork2.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picFork2.Bounds.IntersectsWith(picSheep.Bounds) Or picFork2.Bounds.IntersectsWith(picWren.Bounds) Then

                            Do
                                picFork2.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picFork2.Bounds.IntersectsWith(picSheep.Bounds) = False And picFork2.Bounds.IntersectsWith(picWren.Bounds) = False

                        End If

                        picFork2.Visible = True
                        picFork2.Enabled = True

                        stabenablednum += 1

                    Case 6

                        picShinyFork.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picShinyFork.Bounds.IntersectsWith(picSheep.Bounds) Or picShinyFork.Bounds.IntersectsWith(picWren.Bounds) Then

                            Do
                                picShinyFork.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picShinyFork.Bounds.IntersectsWith(picSheep.Bounds) = False And picShinyFork.Bounds.IntersectsWith(picWren.Bounds) = False

                        End If

                        picShinyFork.Visible = True
                        picShinyFork.Enabled = True

                        stabenablednum += 1

                End Select

            ElseIf lblBoo.Enabled = True And lblRun.Enabled = True Then

                Select Case stab

                    Case 1

                        picStick1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picStick1.Bounds.IntersectsWith(lblBoo.Bounds) Or picStick1.Bounds.IntersectsWith(lblRun.Bounds) Then

                            Do
                                picStick1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picStick1.Bounds.IntersectsWith(lblBoo.Bounds) = False And picStick1.Bounds.IntersectsWith(lblRun.Bounds) = False

                        End If

                        picStick1.Visible = True
                        picStick1.Enabled = True

                        stabenablednum += 1

                    Case 2

                        picStick1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picStick2.Bounds.IntersectsWith(lblBoo.Bounds) Or picStick2.Bounds.IntersectsWith(lblRun.Bounds) Then

                            Do
                                picStick2.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picStick2.Bounds.IntersectsWith(lblBoo.Bounds) = False And picStick2.Bounds.IntersectsWith(lblRun.Bounds) = False

                        End If

                        picStick2.Visible = True
                        picStick2.Enabled = True

                        stabenablednum += 1

                    Case 3

                        picStick3.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picStick3.Bounds.IntersectsWith(lblBoo.Bounds) Or picStick3.Bounds.IntersectsWith(lblRun.Bounds) Then

                            Do
                                picStick3.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picStick3.Bounds.IntersectsWith(lblBoo.Bounds) = False And picStick3.Bounds.IntersectsWith(lblRun.Bounds) = False

                        End If

                        picStick3.Visible = True
                        picStick3.Enabled = True

                        stabenablednum += 1

                    Case 4

                        picFork1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picFork1.Bounds.IntersectsWith(lblBoo.Bounds) Or picFork1.Bounds.IntersectsWith(lblRun.Bounds) Then

                            Do
                                picFork1.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picFork1.Bounds.IntersectsWith(lblBoo.Bounds) = False And picFork1.Bounds.IntersectsWith(lblRun.Bounds) = False

                        End If

                        picFork1.Visible = True
                        picFork1.Enabled = True

                        stabenablednum += 1

                    Case 5

                        picFork2.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picFork2.Bounds.IntersectsWith(lblBoo.Bounds) Or picFork2.Bounds.IntersectsWith(lblRun.Bounds) Then

                            Do
                                picFork2.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picFork2.Bounds.IntersectsWith(lblBoo.Bounds) = False And picFork2.Bounds.IntersectsWith(lblRun.Bounds) = False

                        End If

                        picFork2.Visible = True
                        picFork2.Enabled = True

                        stabenablednum += 1

                    Case 6

                        picShinyFork.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))

                        If picShinyFork.Bounds.IntersectsWith(lblBoo.Bounds) Or picShinyFork.Bounds.IntersectsWith(lblRun.Bounds) Then

                            Do
                                picShinyFork.Location = New Point(Int((879 - 0 + 1) * Rnd() + 0))
                            Loop Until picShinyFork.Bounds.IntersectsWith(lblBoo.Bounds) = False And picShinyFork.Bounds.IntersectsWith(lblRun.Bounds) = False

                        End If

                        picShinyFork.Visible = True
                        picShinyFork.Enabled = True

                        stabenablednum += 1

                End Select

            End If

        End If

    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.A

                If player1 = 3 Then
                    picPlayer1.Left -= 5
                Else
                    picPlayer1.Left -= 2
                End If

            Case Keys.W

                If player1 = 3 Then
                    picPlayer1.Top -= 5
                Else
                    picPlayer1.Top -= 2
                End If

            Case Keys.D

                If player1 = 3 Then
                    picPlayer1.Left += 5
                Else
                    picPlayer1.Left += 2
                End If

            Case Keys.S

                If player1 = 3 Then
                    picPlayer1.Top += 5
                Else
                    picPlayer1.Top += 2
                End If

            Case Keys.Left

                If player2 = 3 Then
                    picPlayer2.Left -= 5
                Else
                    picPlayer2.Left -= 2
                End If

            Case Keys.Up

                If player2 = 3 Then
                    picPlayer2.Top -= 5
                Else
                    picPlayer2.Top -= 2
                End If

            Case Keys.Right

                If player2 = 3 Then
                    picPlayer2.Left += 5
                Else
                    picPlayer2.Left += 2
                End If

            Case Keys.Down

                If player2 = 3 Then
                    picPlayer2.Top += 5
                Else
                    picPlayer2.Top += 2
                End If

            Case Keys.B
                End

        End Select

        If picPlayer1.Left < 0 Then picPlayer1.Location = New Point(0, picPlayer1.Top)
        If picPlayer1.Left > (961 - picPlayer1.Width) Then picPlayer1.Location = New Point(961 - picPlayer1.Width, picPlayer1.Top)
        If picPlayer1.Top < 0 Then picPlayer1.Location = New Point(picPlayer1.Left, 0)
        If picPlayer1.Top > (552 - picPlayer1.Height) Then picPlayer1.Location = New Point(picPlayer1.Left, 552 - picPlayer1.Height)

        If picPlayer2.Left < 0 Then picPlayer2.Location = New Point(0, picPlayer2.Top)
        If picPlayer2.Left > (961 - picPlayer2.Width) Then picPlayer2.Location = New Point(961 - picPlayer2.Width, picPlayer2.Top)
        If picPlayer2.Top < 0 Then picPlayer2.Location = New Point(picPlayer2.Left, 0)
        If picPlayer2.Top > (552 - picPlayer2.Height) Then picPlayer2.Location = New Point(picPlayer2.Left, 552 - picPlayer2.Height)

        If picPlayer1.Bounds.IntersectsWith(picStick1.Bounds) Then

            weaponvalue1 = 1

            picStick1.Visible = False
            picStick1.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer1.Bounds.IntersectsWith(picStick2.Bounds) Then

            weaponvalue1 = 1

            picStick2.Visible = False
            picStick2.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer1.Bounds.IntersectsWith(picStick3.Bounds) Then

            weaponvalue1 = 1

            picStick3.Visible = False
            picStick3.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer1.Bounds.IntersectsWith(picFork1.Bounds) Then

            weaponvalue1 = 2

            picFork1.Visible = False
            picFork1.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer1.Bounds.IntersectsWith(picFork2.Bounds) Then

            weaponvalue1 = 2

            picFork2.Visible = False
            picFork2.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer1.Bounds.IntersectsWith(picShinyFork.Bounds) Then

            weaponvalue1 = 3

            picShinyFork.Visible = False
            picShinyFork.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer2.Bounds.IntersectsWith(picStick1.Bounds) Then

            weaponvalue2 = 1

            picStick1.Visible = False
            picStick1.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer2.Bounds.IntersectsWith(picStick2.Bounds) Then

            weaponvalue2 = 1

            picStick2.Visible = False
            picStick2.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer2.Bounds.IntersectsWith(picStick3.Bounds) Then

            weaponvalue2 = 1

            picStick3.Visible = False
            picStick3.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer2.Bounds.IntersectsWith(picFork1.Bounds) Then

            weaponvalue2 = 2

            picFork1.Visible = False
            picFork1.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer2.Bounds.IntersectsWith(picFork2.Bounds) Then

            weaponvalue2 = 2

            picFork2.Visible = False
            picFork2.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer2.Bounds.IntersectsWith(picShinyFork.Bounds) Then

            weaponvalue2 = 3

            picShinyFork.Visible = False
            picShinyFork.Enabled = False

            stabenablednum -= 1

        End If

        If picPlayer1.Bounds.IntersectsWith(picPlayer2.Bounds) Or picPlayer2.Bounds.IntersectsWith(picPlayer1.Bounds) Then

            If weaponvalue1 > weaponvalue2 Then

                p2stock -= 1
                weaponvalue1 = 0S
                weaponvalue2 = 0

                Select Case p2stock
                    Case 0
                        lblP2Status.Text = "Player 2: dead lol"

                        Form5.lblWinner.Text = "Player 1 Wins"

                        Select Case player2
                            Case 1
                                Form5.picLoser.Image = My.Resources.dying_abernathy
                            Case 2
                                Form5.picLoser.Image = My.Resources.angry_earl
                            Case 3
                                Form5.picLoser.Image = My.Resources.angry_hansole
                        End Select

                        Select Case player1
                            Case 1
                                Form5.picWinner.Image = My.Resources.abernathy
                            Case 2
                                Form5.picWinner.Image = My.Resources.earl
                            Case 3
                                Form5.picWinner.Image = My.Resources.hansole
                        End Select

                        Me.Hide()
                        Form5.Show()

                    Case 1
                        lblP2Status.Text = "Player 2: O"
                    Case 2
                        lblP2Status.Text = "Player 2: O O"
                End Select

                picPlayer2.Location = New Point(34, 378)

                tmrAngry2.Start()

                Select Case player2
                    Case 1
                        picPlayer2.Image = My.Resources.dying_abernathy
                    Case 2
                        picPlayer2.Image = My.Resources.angry_earl
                    Case 3
                        picPlayer2.Image = My.Resources.angry_hansole
                End Select

            ElseIf weaponvalue1 < weaponvalue2 Then

                p1stock -= 1
                weaponvalue1 = 0
                weaponvalue2 = 0

                Select Case p1stock
                    Case 0
                        lblP1Status.Text = "Player 1: dead lol"

                        Form5.lblWinner.Text = "Player 2 Wins"

                        Select Case player2
                            Case 1
                                Form5.picWinner.Image = My.Resources.abernathy
                            Case 2
                                Form5.picWinner.Image = My.Resources.earl
                            Case 3
                                Form5.picWinner.Image = My.Resources.hansole
                        End Select

                        Select Case player1
                            Case 1
                                Form5.picLoser.Image = My.Resources.dying_abernathy
                            Case 2
                                Form5.picLoser.Image = My.Resources.angry_earl
                            Case 3
                                Form5.picLoser.Image = My.Resources.angry_hansole
                        End Select

                        Me.Hide()
                        Form5.Show()

                    Case 1
                        lblP1Status.Text = "Player 1: O"
                    Case 2
                        lblP1Status.Text = "Player 1: O O"
                End Select

                picPlayer1.Location = New Point(784, 12)

                tmrAngry1.Start()

                Select Case player1
                    Case 1
                        picPlayer1.Image = My.Resources.dying_abernathy
                    Case 2
                        picPlayer1.Image = My.Resources.angry_earl
                    Case 3
                        picPlayer1.Image = My.Resources.angry_hansole
                End Select

            ElseIf weaponvalue1 = weaponvalue2 Then

                weaponvalue1 = 0
                weaponvalue2 = 0

                picPlayer1.Location = New Point(picPlayer1.Left - 10, picPlayer1.Top)
                picPlayer2.Location = New Point(picPlayer2.Left + 10, picPlayer2.Top)

                tmrAngry1.Start()
                tmrAngry2.Start()

                Select Case player1
                    Case 1
                        picPlayer1.Image = My.Resources.dying_abernathy
                    Case 2
                        picPlayer1.Image = My.Resources.angry_earl
                    Case 3
                        picPlayer1.Image = My.Resources.angry_hansole
                End Select

                Select Case player2
                    Case 1
                        picPlayer2.Image = My.Resources.dying_abernathy
                    Case 2
                        picPlayer2.Image = My.Resources.angry_earl
                    Case 3
                        picPlayer2.Image = My.Resources.angry_hansole
                End Select

            End If

        End If

        If picSheep.Enabled = True And picWren.Enabled = True Then

            If picPlayer1.Bounds.IntersectsWith(picSheep.Bounds) Or picPlayer1.Bounds.IntersectsWith(picWren.Bounds) Then picPlayer1.Location = New Point(784, 12)
            If picPlayer2.Bounds.IntersectsWith(picSheep.Bounds) Or picPlayer2.Bounds.IntersectsWith(picWren.Bounds) Then picPlayer2.Location = New Point(34, 378)

        ElseIf lblBoo.Enabled = True And lblRun.Enabled = True Then

            If picPlayer1.Bounds.IntersectsWith(lblBoo.Bounds) Or picPlayer1.Bounds.IntersectsWith(lblRun.Bounds) Then picPlayer1.Location = New Point(784, 12)
            If picPlayer2.Bounds.IntersectsWith(lblBoo.Bounds) Or picPlayer2.Bounds.IntersectsWith(lblRun.Bounds) Then picPlayer2.Location = New Point(34, 378)

        End If

    End Sub

    Private Sub tmrAngry1_Tick() Handles tmrAngry1.Tick

        tmrAngry1.Stop()

        Select Case player1
            Case 1
                picPlayer1.Image = My.Resources.abernathy
            Case 2
                picPlayer1.Image = My.Resources.earl
            Case 3
                picPlayer1.Image = My.Resources.hansole
        End Select

    End Sub

    Private Sub tmrAngry2_tick() Handles tmrAngry2.Tick

        tmrAngry2.Stop()

        Select Case player2
            Case 1
                picPlayer2.Image = My.Resources.abernathy
            Case 2
                picPlayer2.Image = My.Resources.earl
            Case 3
                picPlayer2.Image = My.Resources.hansole
        End Select

    End Sub

End Class