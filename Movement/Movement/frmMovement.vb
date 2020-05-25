' Program name: Movement
' Developer:    Albert Banoy
' Date:         4 May 2020
' Purpose:      To demonstrate collision detection and WASD/Arrow Key movements

Option Strict On
Public Class frmMovement
    ' Sound integers

    Dim intSound As Integer
    Dim snd As New clsSound


    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        ' Sub - Player collision

        picPlayer.Location = FormCollision(picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height, 0, 0, Me.Width, Me.Height)
        If ObjectCollided(picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height,
                          picBarrier.Location.X, picBarrier.Location.Y, picBarrier.Width, picBarrier.Height) Then
            picPlayer.Top -= 5
        End If
        If ObjectCollided(picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height,
                  picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
            picPlayer.Left -= 5
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sub - Initializes form load
        Threading.Thread.Sleep(5000)

        Me.Size = New Size(496, 303)
        Me.CenterToScreen()
    End Sub

    Private Sub tmrBullet_Tick(sender As Object, e As EventArgs) Handles tmrBullet.Tick
        ' Timer - Moves the player's bullet

        Dim Bullets() As PictureBox = {picPlayerBullet01, picPlayerBullet02, picPlayerBullet03, picPlayerBullet04, picPlayerBullet05}
        Dim Enemies() As PictureBox = {picEnemy00, picEnemy01, picEnemy02, picEnemy03, picEnemy04, picEnemy05, picEnemy06,
                                        picEnemy07, picEnemy08, picEnemy09}
        Dim intScoreValue = Convert.ToInt32(lblScoreValue.Text)
        Dim intBossValue = Convert.ToInt32(lblMinutes.Text)

        For index = 0 To Bullets.Length - 1

            If Bullets(index).Location.X < Me.Size.Width Then
                Bullets(index).Left += 5
            Else
                Bullets(index).Left -= 5
            End If

            For secondIndex = 0 To Enemies.Length - 1
                If ObjectCollided(Bullets(index).Location.X, Bullets(index).Location.Y, Bullets(index).Width, Bullets(index).Height,
                    Enemies(secondIndex).Location.X, Enemies(secondIndex).Location.Y, Enemies(secondIndex).Width, Enemies(secondIndex).Height) Then
                    Enemies(secondIndex).Location = New Point(1500, 1500)
                    Bullets(index).Location = New Point(1600, 1600)

                    lblScoreValue.Text = Convert.ToString(intScoreValue + 10)
                ElseIf tmrRockFalling.Enabled Then
                    If ObjectCollided(Bullets(index).Location.X, Bullets(index).Location.Y, Bullets(index).Width, Bullets(index).Height,
                                        picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
                        Bullets(index).Location = New Point(1600, 1600)

                        lblScoreValue.Text = Convert.ToString(intScoreValue + 10)

                        lblMinutes.Text = Convert.ToString(intBossValue - 10)
                    End If
                End If
            Next
        Next
    End Sub

    Public Sub frmMovement_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Sub - Keyboard movements for player

        ' Key Presses
        If tmrMain.Enabled Then
            If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                tmrW.Start()
            ElseIf e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
                tmrA.Start()
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
                tmrS.Start()
            ElseIf e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
                tmrD.Start()
            ElseIf e.KeyCode = Keys.Space Then
                Bullet(1)
            End If
        End If

        If tmrBossTransitionDuration.Enabled = False Then
            If e.KeyCode = Keys.Escape Then
                PauseScreen()
            End If
        End If

    End Sub

    Private Sub PauseScreen()
        ' Sub - Pauses screen

        If mnuMovement.Visible Then
            tmrMain.Enabled = True
            tmrBullet.Enabled = True
            tmrEnemy.Enabled = True
            tmrEnemyBullet.Enabled = True
            tmrEnemyBulletMovement.Enabled = True
            tmrLevel.Enabled = True
            tmrSeconds.Enabled = True
            tmrMinutes.Enabled = True
            tmrLastSeconds.Enabled = True
            tmrLifeCheck.Enabled = True
            tmrEnemyMovement.Enabled = True
            tmrMusicTransition.Enabled = True
            tmrMusicSecondTransition.Enabled = True

            lblPaused.Visible = False
            picPauseBox.Visible = False
            picPauseBoxOutline.Visible = False
            mnuMovement.Visible = False
        Else
            tmrMain.Enabled = False
            tmrBullet.Enabled = False
            tmrW.Enabled = False
            tmrA.Enabled = False
            tmrS.Enabled = False
            tmrD.Enabled = False
            tmrCoolDown.Enabled = False
            tmrEnemy.Enabled = False
            tmrEnemyBullet.Enabled = False
            tmrEnemyBulletMovement.Enabled = False
            tmrLevel.Enabled = False
            tmrSeconds.Enabled = False
            tmrMinutes.Enabled = False
            tmrLastSeconds.Enabled = False
            tmrLifeCheck.Enabled = False
            tmrEnemyMovement.Enabled = False
            tmrMusicTransition.Enabled = False
            tmrMusicSecondTransition.Enabled = False
            tmrInvincibilityOnState.Enabled = False
            tmrInvincibilityOffState.Enabled = False
            tmrInvincibilityDuration.Enabled = False

            lblPaused.Visible = True
            picPauseBox.Visible = True
            picPauseBoxOutline.Visible = True
            mnuMovement.Visible = True
        End If
    End Sub

    Private Sub Bullet(ByVal index As Integer)
        ' Sub - Sets new bullets towards player's position

        Dim Bullets() As PictureBox = {picPlayerBullet01, picPlayerBullet02, picPlayerBullet03, picPlayerBullet04, picPlayerBullet05}
        Dim intBulletScore As Integer = Convert.ToInt32(lblBulletScore.Text)

        Static intCount As Integer


        If index = 1 Then
            If intCount < 5 Then
                intSound += 1
                With snd
                    .name = "SOUND" & intSound
                    .Play(0, False, 200)
                End With

                Bullets(intCount).Location = New Point(picPlayer.Location.X + picPlayer.Width, picPlayer.Location.Y + 25)
                intCount += 1
                lblBulletScore.Text = Convert.ToString(intBulletScore - 1)
                tmrBullet.Start()
            End If

            If intCount = 5 Then
                tmrCoolDown.Start()
            End If

        Else
            intCount = 0
            lblBulletScore.Text = Convert.ToString(5)
        End If

    End Sub

    Private Function FormCollision(ByVal Object1X As Integer, ByVal Object1Y As Integer, ByVal Object1Width As Integer, ByVal Object1Height As Integer,
                          ByVal Object2X As Integer, ByVal Object2Y As Integer, ByVal Object2Width As Integer, ByVal Object2Height As Integer) As Point
        ' Function - Player-Form Collision Detection

        Dim intFormFixX As Integer = 39
        Dim intFormFixY As Integer = 16
        Dim intFormFixTop As Integer = 5
        Dim intFormFixBottom As Integer = 94

        If Object1Y < Object2Y And Object1X < Object2X Then ' Top-Left Collision
            Return New Point(Object2X, Object2Y + intFormFixTop)
        ElseIf Object1Y < Object2Y And Object1X + Object1Width + intFormFixY > Object2Width Then ' Top-Right Collision
            Return New Point(Object2Width, Object2Y + intFormFixTop)
        ElseIf Object1Y + Object1Height + intFormFixX > Object2Height And Object1X < Object2X Then ' Bottom-Left Collision
            Return New Point(Object2X, Object2Height - intFormFixBottom)
        ElseIf Object1Y + Object1Height + intFormFixX > Object2Height And Object1X + Object1Width + intFormFixY > Object2Width Then ' Bottom-Right Collision
            Return New Point(Object2Width, Object2Height - intFormFixBottom)
        ElseIf Object1Y < Object2Y Then ' Top Collision
            Return New Point(Object1X, Object2Y)
        ElseIf Object1Y + Object1Height + intFormFixX > Object2Height Then ' Bottom Collision
            Return New Point(Object1X, Object2Height - Object1Height - intFormFixX)
        ElseIf Object1X < Object2X Then ' Left Collision
            Return New Point(Object2X, Object1Y)
        ElseIf Object1X + Object1Width + intFormFixY > Object2Width Then ' Right Collision
            Return New Point(Object2Width - Object1Width - intFormFixY, Object1Y)
        Else
            Return New Point(Object1X, Object1Y)
        End If

    End Function

    Private Function ObjectCollided(ByVal Object1X As Integer, ByVal Object1Y As Integer, ByVal Object1Width As Integer, ByVal Object1Height As Integer,
                          ByVal Object2X As Integer, ByVal Object2Y As Integer, ByVal Object2Width As Integer, ByVal Object2Height As Integer) As Boolean
        ' Function - Object-Object Collision Detection

        If Object1Y + Object1Height > Object2Y And Object1Y + Object1Height < Object2Y + Object2Height And Object1X > Object2X And Object1X + Object1Width < Object2X + Object2Width Then ' Top Collision
            Return True
        ElseIf Object1Y > Object2Y And Object1Y + Object1Height < Object2Y + Object2Height And Object1X + Object1Width > Object2X And Object1X + Object1Width < Object2X + Object2Width Then ' Left Collision
            Return True
        ElseIf Object1Y > Object2Y And Object1Y < Object2Y + Object2Height And Object1X > Object2X And Object1X + Object1Width < Object2X + Object2Width Then ' Bottom Collision
            Return True
        ElseIf Object1Y + Object1Height > Object2Y And Object1Y + Object1Height < Object2Y + Object2Height And Object1X > Object2X And Object1X < Object2X + Object2Width Then ' Right Collision
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub frmMovement_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Sub - Disables movement when a movement key is lifted

        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            tmrW.Enabled = False
        ElseIf e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            tmrA.Enabled = False
        ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            tmrS.Enabled = False
        ElseIf e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            tmrD.Enabled = False
        End If
    End Sub

    Private Sub tmrW_Tick(sender As Object, e As EventArgs) Handles tmrW.Tick
        ' Timer - Player's up movement

        picPlayer.Top -= 5
    End Sub

    Private Sub tmrA_Tick(sender As Object, e As EventArgs) Handles tmrA.Tick
        ' Timer - Player's left movement

        picPlayer.Left -= 5
    End Sub

    Private Sub tmrS_Tick(sender As Object, e As EventArgs) Handles tmrS.Tick
        ' Timer - Player's down movement

        picPlayer.Top += 5
    End Sub

    Private Sub tmrD_Tick(sender As Object, e As EventArgs) Handles tmrD.Tick
        ' Timer - Player's right movement

        picPlayer.Left += 5
    End Sub

    Private Sub tmrCoolDown_Tick(sender As Object, e As EventArgs) Handles tmrCoolDown.Tick
        ' Timer - Turns off bullet cooldown and refills player's bullets

        Bullet(2)
        tmrCoolDown.Enabled = False
    End Sub

    Private Sub tmrEnemy_Tick(sender As Object, e As EventArgs) Handles tmrEnemy.Tick
        ' Timer - Sets new sets of enemys on-screen

        Dim Enemies() As PictureBox = {picEnemy00, picEnemy01, picEnemy02, picEnemy03, picEnemy04, picEnemy05, picEnemy06,
                                        picEnemy07, picEnemy08, picEnemy09}
        Dim rn As New Random

        For index = 1 To rn.Next(1, 10) - 1

            If Enemies(index).Location.Y > Me.Height Or Enemies(index).Location.X < 0 Then
                Enemies(index).Location = New Point(rn.Next(1200, 1300), rn.Next(10, 250))


            End If

            tmrEnemyMovement.Start()
        Next
    End Sub

    Private Sub tmrEnemyBullet_Tick(sender As Object, e As EventArgs) Handles tmrEnemyBullet.Tick
        ' Timer - Sets new sets of enemy's bullet on-screen

        Dim Enemies() As PictureBox = {picEnemy00, picEnemy01, picEnemy02, picEnemy03, picEnemy04, picEnemy05, picEnemy06,
                                        picEnemy07, picEnemy08, picEnemy09}

        Dim rn As New Random

        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(0, False, 200)
        End With

        For index = 1 To Enemies.Length - 1
            If index = 1 Then

                picEnemy00Bullet00.Location = EnemyBulletSet(picEnemy00Bullet00.Location.X, picEnemy00Bullet00.Location.Y, picEnemy00Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)
            ElseIf index = 2 Then

                picEnemy01Bullet00.Location = EnemyBulletSet(picEnemy01Bullet00.Location.X, picEnemy01Bullet00.Location.Y, picEnemy01Bullet00.Width,
                                                                        Enemies(index).Location.X, Enemies(index).Location.Y)
            ElseIf index = 3 Then

                picEnemy02Bullet00.Location = EnemyBulletSet(picEnemy02Bullet00.Location.X, picEnemy02Bullet00.Location.Y, picEnemy02Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)

            ElseIf index = 4 Then

                picEnemy03Bullet00.Location = EnemyBulletSet(picEnemy03Bullet00.Location.X, picEnemy03Bullet00.Location.Y, picEnemy03Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)

            ElseIf index = 5 Then

                picEnemy04Bullet00.Location = EnemyBulletSet(picEnemy04Bullet00.Location.X, picEnemy04Bullet00.Location.Y, picEnemy04Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)

            ElseIf index = 6 Then

                picEnemy05Bullet00.Location = EnemyBulletSet(picEnemy05Bullet00.Location.X, picEnemy05Bullet00.Location.Y, picEnemy05Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)

            ElseIf index = 7 Then

                picEnemy06Bullet00.Location = EnemyBulletSet(picEnemy06Bullet00.Location.X, picEnemy06Bullet00.Location.Y, picEnemy06Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)

            ElseIf index = 8 Then

                picEnemy07Bullet00.Location = EnemyBulletSet(picEnemy07Bullet00.Location.X, picEnemy07Bullet00.Location.Y, picEnemy07Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)

            ElseIf index = 9 Then

                picEnemy08Bullet00.Location = EnemyBulletSet(picEnemy08Bullet00.Location.X, picEnemy08Bullet00.Location.Y, picEnemy08Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)

            Else

                picEnemy09Bullet00.Location = EnemyBulletSet(picEnemy09Bullet00.Location.X, picEnemy09Bullet00.Location.Y, picEnemy09Bullet00.Width,
                                                                    Enemies(index).Location.X, Enemies(index).Location.Y)


            End If


        Next

    End Sub

    Private Function EnemyBulletSet(ByVal Object1LocationX As Integer, ByVal Object1LocationY As Integer, ByVal Object1Width As Integer,
                                    ByVal Object2LocationX As Integer, ByVal Object2LocationY As Integer) As Point
        ' Function - Sets enemy's bullet towards enemy's on-screen position

        If Object1LocationY > Me.Height Or Object1LocationX + Object1Width < 0 Then
            Return New Point(Object2LocationX, Object2LocationY + 12)
        Else
            Return New Point(Object1LocationX, Object1LocationY)
        End If
    End Function

    Private Sub tmrEnemyBulletMovement_Tick(sender As Object, e As EventArgs) Handles tmrEnemyBulletMovement.Tick
        ' Timer - Checks sets of enemy bullet

        Dim Enemies() As PictureBox = {picEnemy00, picEnemy01, picEnemy02, picEnemy03, picEnemy04, picEnemy05, picEnemy06,
                                        picEnemy07, picEnemy08, picEnemy09}


        For index = 1 To Enemies.Length - 1
            If index = 1 Then

                EnemyBulletCheck(picEnemy00Bullet00.Location.X, picEnemy00Bullet00.Location.Y, picEnemy00Bullet00.Width, picEnemy00Bullet00.Height, picEnemy00Bullet00.Left)

            ElseIf index = 2 Then

                EnemyBulletCheck(picEnemy01Bullet00.Location.X, picEnemy01Bullet00.Location.Y, picEnemy01Bullet00.Width, picEnemy01Bullet00.Height, picEnemy01Bullet00.Left)

            ElseIf index = 3 Then

                EnemyBulletCheck(picEnemy02Bullet00.Location.X, picEnemy02Bullet00.Location.Y, picEnemy02Bullet00.Width, picEnemy02Bullet00.Height, picEnemy02Bullet00.Left)

            ElseIf index = 4 Then

                EnemyBulletCheck(picEnemy03Bullet00.Location.X, picEnemy03Bullet00.Location.Y, picEnemy03Bullet00.Width, picEnemy03Bullet00.Height, picEnemy03Bullet00.Left)

            ElseIf index = 5 Then

                EnemyBulletCheck(picEnemy04Bullet00.Location.X, picEnemy04Bullet00.Location.Y, picEnemy04Bullet00.Width, picEnemy04Bullet00.Height, picEnemy04Bullet00.Left)

            ElseIf index = 6 Then

                EnemyBulletCheck(picEnemy05Bullet00.Location.X, picEnemy05Bullet00.Location.Y, picEnemy05Bullet00.Width, picEnemy05Bullet00.Height, picEnemy05Bullet00.Left)

            ElseIf index = 7 Then

                EnemyBulletCheck(picEnemy06Bullet00.Location.X, picEnemy06Bullet00.Location.Y, picEnemy06Bullet00.Width, picEnemy06Bullet00.Height, picEnemy06Bullet00.Left)

            ElseIf index = 8 Then

                EnemyBulletCheck(picEnemy07Bullet00.Location.X, picEnemy07Bullet00.Location.Y, picEnemy07Bullet00.Width, picEnemy07Bullet00.Height, picEnemy07Bullet00.Left)

            ElseIf index = 9 Then

                EnemyBulletCheck(picEnemy08Bullet00.Location.X, picEnemy08Bullet00.Location.Y, picEnemy08Bullet00.Width, picEnemy08Bullet00.Height, picEnemy08Bullet00.Left)

            Else

                EnemyBulletCheck(picEnemy09Bullet00.Location.X, picEnemy09Bullet00.Location.Y, picEnemy09Bullet00.Width, picEnemy09Bullet00.Height, picEnemy09Bullet00.Left)

            End If
        Next
    End Sub

    Private Sub EnemyBulletCheck(ByVal LocationX As Integer, ByVal LocationY As Integer, ByVal Width As Integer, ByVal Height As Integer, ByRef Left As Integer)
        ' Sub - Moves the enemy bullet on-screen and checks to see if it have hit the player 

        Dim intLifeScore As Integer = Convert.ToInt32(lblLifeScore.Text)

        If LocationX + Width + 15 > 0 Then
            Left -= 7

            If ObjectCollided(LocationX, LocationY, Width, Height,
                              picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then


                Invincibility()
            End If
        Else
            Left += 7
        End If
    End Sub

    Private Sub tmrSeconds_Tick(sender As Object, e As EventArgs) Handles tmrSeconds.Tick
        ' Timer - Tick for remaining seconds

        Dim intSeconds As Integer = Convert.ToInt32(lblSeconds.Text)

        If lblSeconds.Text = "00" Then
            lblSeconds.Text = "59"
        Else
            lblSeconds.Text = Convert.ToString(intSeconds - 1)

            If lblSeconds.Text.Length = 1 Then
                lblSeconds.Text = "0" + lblSeconds.Text
            End If
        End If
    End Sub

    Private Sub tmrMinutes_Tick(sender As Object, e As EventArgs) Handles tmrMinutes.Tick
        ' Timer - Tick for remaining Minutes

        Dim intMinutes As Integer = Convert.ToInt32(lblMinutes.Text)

        If intMinutes = 0 Then
            tmrMinutes.Enabled = False
        Else
            lblMinutes.Text = Convert.ToString(intMinutes - 1)
            tmrEnemy.Interval -= 1000
            tmrEnemyBullet.Interval -= 1000
        End If

    End Sub

    Private Sub tmrLastSeconds_Tick(sender As Object, e As EventArgs) Handles tmrLastSeconds.Tick
        ' Timer - Disables any new enemy coming to screen

        tmrEnemy.Enabled = False
        tmrEnemyBullet.Enabled = False
        tmrLastSeconds.Enabled = False
    End Sub

    Private Sub tmrEnemyMovement_Tick(sender As Object, e As EventArgs) Handles tmrEnemyMovement.Tick
        ' Timer - Have the enemy be moving

        Dim Enemies() As PictureBox = {picEnemy00, picEnemy01, picEnemy02, picEnemy03, picEnemy04, picEnemy05, picEnemy06,
                                        picEnemy07, picEnemy08, picEnemy09}

        For index = 1 To Enemies.Length - 1
            Enemies(index).Left -= 2

            If Enemies(index).Width < 0 Then
                Enemies(index).Left += 2
            End If

            If ObjectCollided(Enemies(index).Location.X, Enemies(index).Location.Y, Enemies(index).Width, Enemies(index).Height,
                               picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then
                Invincibility()
            End If

        Next
    End Sub

    Private Sub tmrLifeCheck_Tick(sender As Object, e As EventArgs) Handles tmrLifeCheck.Tick
        ' Timer - Checks to see if the player is still alive

        Dim intLifeScore As Integer = Convert.ToInt32(lblLifeScore.Text)

        If intLifeScore = 0 Then

            Threading.Thread.Sleep(3000)

            HaltSound()

            intSound += 1
            With snd
                .name = "SOUND" & intSound
                .Play(8, False, 800)
            End With

            tmrMain.Enabled = False
            tmrBullet.Enabled = False
            tmrW.Enabled = False
            tmrA.Enabled = False
            tmrS.Enabled = False
            tmrD.Enabled = False
            tmrCoolDown.Enabled = False
            tmrEnemy.Enabled = False
            tmrEnemyBullet.Enabled = False
            tmrEnemyBulletMovement.Enabled = False
            tmrLevel.Enabled = False
            tmrSeconds.Enabled = False
            tmrMinutes.Enabled = False
            tmrLastSeconds.Enabled = False
            tmrLifeCheck.Enabled = False
            tmrEnemyMovement.Enabled = False
            tmrMusicTransition.Enabled = False
            tmrMusicSecondTransition.Enabled = False
            tmrInvincibilityOnState.Enabled = False
            tmrInvincibilityOffState.Enabled = False
            tmrInvincibilityDuration.Enabled = False
            tmrBossDecision.Enabled = False
            tmrRockFalling.Enabled = False
            tmrBackgroundMovement.Enabled = False
            picPlayer.Visible = False

            MsgBox("Game Over")

            Dim MsgBoxResponse = MsgBox("Would you like to try again?", MsgBoxStyle.YesNo, "Try again?")
            If MsgBoxResponse = MsgBoxResult.Yes Then
                Application.Restart()
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Invincibility()
        ' Sub - Relocates player to left and starts invincibility for the player

        Dim intLifeScore As Integer = Convert.ToInt32(lblLifeScore.Text)

        If tmrInvincibilityDuration.Enabled = False Then
            picPlayer.Location = New Point(100, Convert.ToInt32(Me.Height / 2) - 25)
            lblLifeScore.Text = Convert.ToString(intLifeScore - 1)
            picPlayer.Visible = False


            tmrInvincibilityDuration.Start()
            tmrInvincibilityOffState.Start()
        End If
    End Sub

    Private Sub tmrLevel_Tick(sender As Object, e As EventArgs) Handles tmrLevel.Tick
        ' Timer - Checks the score and decides whether to proceed to boss area or not

        Dim intScoreValue As Integer = Convert.ToInt32(lblScoreValue.Text)

        HaltSound()

        tmrMain.Enabled = False
        tmrBullet.Enabled = False
        tmrW.Enabled = False
        tmrA.Enabled = False
        tmrS.Enabled = False
        tmrD.Enabled = False
        tmrCoolDown.Enabled = False
        tmrEnemy.Enabled = False
        tmrEnemyBullet.Enabled = False
        tmrEnemyBulletMovement.Enabled = False
        tmrLevel.Enabled = False
        tmrSeconds.Enabled = False
        tmrMinutes.Enabled = False
        tmrLastSeconds.Enabled = False
        tmrLifeCheck.Enabled = False
        tmrEnemyMovement.Enabled = False
        tmrMusicTransition.Enabled = False
        tmrMusicSecondTransition.Enabled = False
        tmrInvincibilityOnState.Enabled = False
        tmrInvincibilityOffState.Enabled = False
        tmrInvincibilityDuration.Enabled = False

        If intScoreValue >= 1000 Then
            ' When the player reach 1500 scores or above
            ' Enter Boss Area

            picBoss.Location = New Point(1200, 30)

            tmrBossTransition.Start()
            tmrBossTransition2.Start()
            tmrBossTransition3.Start()
            tmrBossTransition4.Start()
            tmrBossTransition5.Start()
            tmrBossTransition6.Start()
            tmrBossTransitionDuration.Start()

        Else
            ' When the player did not reach 1500 scores or above

            MsgBox("Thanks for playing!")
            MsgBox("See if you can score 1,000 points next time.")

            Dim MsgBoxResponse = MsgBox("Would you like to try again?", MsgBoxStyle.YesNo, "Try again?")
            If MsgBoxResponse = MsgBoxResult.Yes Then
                Application.Restart()
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub HaltSound()
        ' Kills all known sounds

        For x = 0 To intSound
            snd.Kill("SOUND" & x)
        Next
    End Sub

    Private Sub tmrMusicTransition_Tick(sender As Object, e As EventArgs) Handles tmrMusicTransition.Tick
        ' Timer - Music transition: Second half of level music

        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(2, False, 300)
        End With

        tmrMusicSecondTransition.Start()
        tmrBackgroundTransition00.Start()
        tmrMusicTransition.Enabled = False
    End Sub

    Private Sub tmrMusicSecondTransition_Tick(sender As Object, e As EventArgs) Handles tmrMusicSecondTransition.Tick
        ' Timer - Music transition: The 30-seconds Music

        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(3, False, 300)
        End With

        lblTimer.ForeColor = Color.Red
        lblMinutes.ForeColor = Color.Red
        lblTimeColon.ForeColor = Color.Red
        lblSeconds.ForeColor = Color.Red
        tmrBackgroundTransition01.Start()
        tmrMusicSecondTransition.Enabled = False
    End Sub

    Private Sub tmrInvincibilityOnState_Tick(sender As Object, e As EventArgs) Handles tmrInvincibilityOnState.Tick
        ' Timer - Have player not be visible from invincibility

        picPlayer.Visible = False

        tmrInvincibilityOffState.Start()
        tmrInvincibilityOnState.Enabled = False
    End Sub

    Private Sub tmrInvincibilityOffState_Tick(sender As Object, e As EventArgs) Handles tmrInvincibilityOffState.Tick
        ' Timer - Have player be visible from invincibility

        picPlayer.Visible = True

        tmrInvincibilityOnState.Start()
        tmrInvincibilityOffState.Enabled = False
    End Sub

    Private Sub tmrInvincibilityDuration_Tick(sender As Object, e As EventArgs) Handles tmrInvincibilityDuration.Tick
        ' Timer - Ends invincibility

        tmrInvincibilityOnState.Enabled = False
        tmrInvincibilityOffState.Enabled = False

        picPlayer.Visible = True
        tmrInvincibilityDuration.Enabled = False
    End Sub

    Private Sub tmrBossTransition_Tick(sender As Object, e As EventArgs) Handles tmrBossTransition.Tick
        ' Timer - Have the boss be moves to screen

        picBoss.Left -= 1
    End Sub

    Private Sub tmrBossTransition2_Tick(sender As Object, e As EventArgs) Handles tmrBossTransition2.Tick
        ' Timer - Starts the boss' yelling

        tmrBossTransition.Enabled = False

        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(4, False, 600)
        End With

        tmrBossTransitionLeft.Start()
        tmrBossTransition2.Enabled = False
    End Sub

    Private Sub tmrBossTransition3_Tick(sender As Object, e As EventArgs) Handles tmrBossTransition3.Tick
        ' Timer - Finishes up the yell and corrects HUD location errors

        tmrBossTransitionLeft.Enabled = False
        tmrBossTransitionRight.Enabled = False

        picDeckHighlight00.Location = New Point(12, 297)
        picDeckMain00.Location = New Point(12, 301)
        picDeckLower00.Location = New Point(6, 320)

        picDeckHighlight01.Location = New Point(252, 297)
        picDeckMain01.Location = New Point(252, 301)
        picDeckLower01.Location = New Point(246, 320)

        picDeckHighlight02.Location = New Point(488, 297)
        picDeckMain02.Location = New Point(488, 301)
        picDeckLower02.Location = New Point(482, 320)

        picDeckHighlight03.Location = New Point(725, 297)
        picDeckMain03.Location = New Point(725, 301)
        picDeckLower03.Location = New Point(719, 320)

        lblScore.Location = New Point(28, 301)
        lblScoreValue.Location = New Point(128, 306)

        lblTimer.Location = New Point(261, 301)
        lblMinutes.Location = New Point(357, 306)

        ' Checks if to relocate them, based on on-going boss transition
        If tmrBossTransition4.Enabled Then
            lblTimeColon.Location = New Point(387, 306)
            lblSeconds.Location = New Point(410, 306)
        End If

        lblBullets.Location = New Point(502, 301)
        lblBulletScore.Location = New Point(627, 306)

        lblLives.Location = New Point(734, 301)
        lblLifeScore.Location = New Point(827, 306)

        tmrBossTransition3.Enabled = False
    End Sub

    Private Sub tmrBossTransitionLeft_Tick(sender As Object, e As EventArgs) Handles tmrBossTransitionLeft.Tick
        ' Timer - Part of boss' yelling; moved to the left

        picBoss.Left -= 3
        picPlayer.Left -= 3

        picDeckHighlight00.Left -= 3
        picDeckMain00.Left -= 3
        picDeckLower00.Left -= 3

        picDeckHighlight01.Left -= 3
        picDeckMain01.Left -= 3
        picDeckLower01.Left -= 3

        picDeckHighlight02.Left -= 3
        picDeckMain02.Left -= 3
        picDeckLower02.Left -= 3

        picDeckHighlight03.Left -= 3
        picDeckMain03.Left -= 3
        picDeckLower03.Left -= 3

        lblScore.Left -= 3
        lblScoreValue.Left -= 3

        lblTimer.Left -= 3
        lblMinutes.Left -= 3
        lblTimeColon.Left -= 3
        lblSeconds.Left -= 3

        lblBullets.Left -= 3
        lblBulletScore.Left -= 3

        lblLives.Left -= 3
        lblLifeScore.Left -= 3

        tmrBossTransitionRight.Start()
        tmrBossTransitionLeft.Enabled = False

    End Sub

    Private Sub tmrBossTransitionRight_Tick(sender As Object, e As EventArgs) Handles tmrBossTransitionRight.Tick
        ' Timer - Part of boss' yelling; moved to the right

        picBoss.Left += 3
        picPlayer.Left += 3

        picDeckHighlight00.Left += 3
        picDeckMain00.Left += 3
        picDeckLower00.Left += 3

        picDeckHighlight01.Left += 3
        picDeckMain01.Left += 3
        picDeckLower01.Left += 3

        picDeckHighlight02.Left += 3
        picDeckMain02.Left += 3
        picDeckLower02.Left += 3

        picDeckHighlight03.Left += 3
        picDeckMain03.Left += 3
        picDeckLower03.Left += 3

        lblScore.Left += 3
        lblScoreValue.Left += 3

        lblTimer.Left += 3
        lblMinutes.Left += 3
        lblTimeColon.Left += 3
        lblSeconds.Left += 3

        lblBullets.Left += 3
        lblBulletScore.Left += 3

        lblLives.Left += 3
        lblLifeScore.Left += 3

        tmrBossTransitionLeft.Start()
        tmrBossTransitionRight.Enabled = False
    End Sub

    Private Sub tmrBossTransition4_Tick(sender As Object, e As EventArgs) Handles tmrBossTransition4.Tick
        ' Timer - Starts the transition for timer bar to move down

        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(5, False, 800)
        End With

        picDeckTransition00.Visible = True
        picDeckTransition01.Visible = True
        picDeckTransition02.Visible = True

        tmrBossTransitionDown.Start()
        tmrBossTransition4.Enabled = False
    End Sub

    Private Sub tmrBossTransitionDown_Tick(sender As Object, e As EventArgs) Handles tmrBossTransitionDown.Tick
        ' Timer - Moves down the timer bar

        lblTimer.Top += 3
        lblMinutes.Top += 3
        lblTimeColon.Top += 3
        lblSeconds.Top += 3
        picDeckHighlight01.Top += 3
        picDeckMain01.Top += 3

    End Sub

    Private Sub tmrBossTransition5_Tick(sender As Object, e As EventArgs) Handles tmrBossTransition5.Tick
        ' Timer - Starts the upper transition and changes the timer text to boss health

        tmrBossTransitionDown.Enabled = False

        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(6, False, 800)
        End With

        lblTimer.BackColor = Color.Silver
        lblMinutes.BackColor = Color.Silver

        lblTimer.Text = "BOSS:"
        lblMinutes.Text = "1000"

        lblTimeColon.Visible = False
        lblSeconds.Visible = False

        tmrBossTransitionUp.Start()
        tmrBossTransition5.Enabled = False

    End Sub

    Private Sub tmrBossTransitionUp_Tick(sender As Object, e As EventArgs) Handles tmrBossTransitionUp.Tick
        ' Timer - Moves up the Timer (Boss Health) Bar

        lblTimer.Top -= 3
        lblMinutes.Top -= 3
        picDeckHighlight01.Top -= 3
        picDeckMain01.Top -= 3
    End Sub

    Private Sub tmrBossTransition6_Tick(sender As Object, e As EventArgs) Handles tmrBossTransition6.Tick
        ' Timer - Finishes up transition 5 and fixes any slight transition from location error

        tmrBossTransitionUp.Enabled = False
        tmrBossTransition6.Enabled = False

        picDeckTransition00.Visible = False
        picDeckTransition01.Visible = False
        picDeckTransition02.Visible = False

        If picDeckHighlight01.Location.Y <> 297 Then

            intSound += 1
            With snd
                .name = "SOUND" & intSound
                .Play(7, False, 500)
            End With

            picDeckHighlight01.Location = New Point(252, 297)
            picDeckMain01.Location = New Point(252, 301)
            lblTimer.Location = New Point(261, 301)
            lblMinutes.Location = New Point(357, 306)
            picDeckLower01.Location = New Point(246, 320)
        End If

    End Sub

    Private Sub tmrBossTransitionDuration_Tick(sender As Object, e As EventArgs) Handles tmrBossTransitionDuration.Tick
        ' Timer - Ends the transition and starts the boss battle

        tmrMain.Enabled = True
        tmrBullet.Enabled = True
        tmrLifeCheck.Enabled = True

        tmrBossTransition2.Interval = 2000
        tmrBossTransition3.Interval = 4000

        tmrBossTransition2.Start()
        tmrBossTransition3.Start()
        tmrBossCheck.Start()
        tmrBossDecision.Start()
        tmrRockFallPeriod.Start()

        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(10, True, 200)
        End With

        tmrBossTransitionDuration.Enabled = False
    End Sub

    Private Sub tmrBossDecision_Tick(sender As Object, e As EventArgs) Handles tmrBossDecision.Tick
        ' Timer - Have the boss yell at player

        tmrBossTransition2.Start()
        tmrBossTransition3.Start()


    End Sub

    Private Sub tmrRockFall_Tick(sender As Object, e As EventArgs) Handles tmrRockFall.Tick
        ' Timer - Randomly select number of rocks and point to RockSet() function

        Dim rn As New Random
        If tmrBossEndDuration.Enabled = False Then
            For index = 1 To rn.Next(1, 6)
                If index = 1 Then
                    picRockHeight00.Location = RockSet(picRockHeight00.Location.X, picRockHeight00.Location.Y)
                ElseIf index = 2 Then
                    picRockHeight01.Location = RockSet(picRockHeight01.Location.X, picRockHeight01.Location.Y)
                ElseIf index = 3 Then
                    picRockHeight02.Location = RockSet(picRockHeight02.Location.X, picRockHeight02.Location.Y)
                ElseIf index = 4 Then
                    picRockHeight03.Location = RockSet(picRockHeight03.Location.X, picRockHeight03.Location.Y)
                ElseIf index = 5 Then
                    picRockHeight04.Location = RockSet(picRockHeight04.Location.X, picRockHeight04.Location.Y)
                Else
                    picRockHeight05.Location = RockSet(picRockHeight05.Location.X, picRockHeight05.Location.Y)
                End If

            Next

            tmrRockFalling.Start()
        Else
            ' Check to see if rocks are still falling during the Boss' defeat
            If picRockHeight00.Location.Y > Me.Height Then
                If picRockHeight01.Location.Y > Me.Height Then
                    If picRockHeight02.Location.Y > Me.Height Then
                        If picRockHeight03.Location.Y > Me.Height Then
                            If picRockHeight04.Location.Y > Me.Height Then
                                If picRockHeight05.Location.Y > Me.Height Then
                                    tmrRockFall.Enabled = False
                                    tmrRockFalling.Enabled = False
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function RockSet(ByVal LocationX As Integer, ByVal LocationY As Integer) As Point
        ' Function - Return a new location off-screen if they are off-screen

        Dim rn As New Random

        If LocationY > Me.Height Then
            Return New Point(rn.Next(10, 900))
        Else
            Return New Point(LocationX, LocationY)
        End If
    End Function

    Private Sub tmrRockFallPeriod_Tick(sender As Object, e As EventArgs) Handles tmrRockFallPeriod.Tick
        ' Timer - ends the wait period and have rocks start falling

        tmrRockFall.Start()
        tmrRockFallPeriod.Enabled = False

    End Sub

    Private Sub tmrRockFalling_Tick(sender As Object, e As EventArgs) Handles tmrRockFalling.Tick
        ' Timer - Check if collision as happened mainly from falling rocks

        Dim Bullets() As PictureBox = {picPlayerBullet01, picPlayerBullet02, picPlayerBullet03, picPlayerBullet04, picPlayerBullet05}
        Dim intBossValue As Integer = Convert.ToInt32(lblMinutes.Text)
        Dim rn As New Random

        For index = 1 To 6
            If index = 1 Then
                picRockHeight00.Top += 5


                If ObjectCollided(picRockHeight00.Location.X, picRockHeight00.Location.Y, picRockHeight00.Width, picRockHeight00.Height,
                                  picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then
                    Invincibility()

                ElseIf ObjectCollided(picRockHeight00.Location.X, picRockHeight00.Location.Y, picRockHeight00.Width, picRockHeight00.Height,
                                      picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
                    lblMinutes.Text = Convert.ToString(intBossValue - 100)
                    picRockHeight00.Location = New Point(picRockHeight00.Location.X, 400)
                End If

                For innerIndex = 1 To Bullets.Length - 1
                    If ObjectCollided(Bullets(innerIndex).Location.X, Bullets(innerIndex).Location.Y, Bullets(innerIndex).Width, Bullets(innerIndex).Height,
                                      picRockHeight00.Location.X, picRockHeight00.Location.Y, picRockHeight00.Width, picRockHeight00.Height) Then
                        Bullets(innerIndex).Location = New Point(1600, 1600)
                    End If
                Next

            ElseIf index = 2 Then
                picRockHeight01.Top += 5


                If ObjectCollided(picRockHeight01.Location.X, picRockHeight01.Location.Y, picRockHeight01.Width, picRockHeight01.Height,
                                  picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then
                    Invincibility()
                ElseIf ObjectCollided(picRockHeight01.Location.X, picRockHeight01.Location.Y, picRockHeight01.Width, picRockHeight01.Height,
                  picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
                    lblMinutes.Text = Convert.ToString(intBossValue - 100)
                    picRockHeight01.Location = New Point(picRockHeight01.Location.X, 400)
                End If

                For innerIndex = 1 To Bullets.Length - 1
                    If ObjectCollided(Bullets(innerIndex).Location.X, Bullets(innerIndex).Location.Y, Bullets(innerIndex).Width, Bullets(innerIndex).Height,
                                      picRockHeight01.Location.X, picRockHeight01.Location.Y, picRockHeight01.Width, picRockHeight01.Height) Then
                        Bullets(innerIndex).Location = New Point(1600, 1600)
                    End If
                Next

            ElseIf index = 3 Then
                picRockHeight02.Top += 5


                If ObjectCollided(picRockHeight02.Location.X, picRockHeight02.Location.Y, picRockHeight02.Width, picRockHeight02.Height,
                                  picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then
                    Invincibility()
                ElseIf ObjectCollided(picRockHeight02.Location.X, picRockHeight02.Location.Y, picRockHeight02.Width, picRockHeight02.Height,
                  picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
                    lblMinutes.Text = Convert.ToString(intBossValue - 100)
                    picRockHeight02.Location = New Point(picRockHeight02.Location.X, 400)
                End If

                For innerIndex = 1 To Bullets.Length - 1
                    If ObjectCollided(Bullets(innerIndex).Location.X, Bullets(innerIndex).Location.Y, Bullets(innerIndex).Width, Bullets(innerIndex).Height,
                                      picRockHeight02.Location.X, picRockHeight02.Location.Y, picRockHeight02.Width, picRockHeight02.Height) Then
                        Bullets(innerIndex).Location = New Point(1600, 1600)
                    End If
                Next

            ElseIf index = 4 Then
                picRockHeight03.Top += 5


                If ObjectCollided(picRockHeight03.Location.X, picRockHeight03.Location.Y, picRockHeight03.Width, picRockHeight03.Height,
                                  picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then
                    Invincibility()
                ElseIf ObjectCollided(picRockHeight03.Location.X, picRockHeight03.Location.Y, picRockHeight03.Width, picRockHeight03.Height,
                  picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
                    lblMinutes.Text = Convert.ToString(intBossValue - 100)
                    picRockHeight03.Location = New Point(picRockHeight03.Location.X, 400)
                End If

                For innerIndex = 1 To Bullets.Length - 1
                    If ObjectCollided(Bullets(innerIndex).Location.X, Bullets(innerIndex).Location.Y, Bullets(innerIndex).Width, Bullets(innerIndex).Height,
                                      picRockHeight03.Location.X, picRockHeight03.Location.Y, picRockHeight03.Width, picRockHeight03.Height) Then
                        Bullets(innerIndex).Location = New Point(1600, 1600)
                    End If
                Next

            ElseIf index = 5 Then
                picRockHeight04.Top += 5


                If ObjectCollided(picRockHeight04.Location.X, picRockHeight04.Location.Y, picRockHeight04.Width, picRockHeight04.Height,
                                  picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then
                    Invincibility()
                ElseIf ObjectCollided(picRockHeight04.Location.X, picRockHeight04.Location.Y, picRockHeight04.Width, picRockHeight04.Height,
                  picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
                    lblMinutes.Text = Convert.ToString(intBossValue - 100)
                    picRockHeight04.Location = New Point(picRockHeight04.Location.X, 400)
                End If

                For innerIndex = 1 To Bullets.Length - 1
                    If ObjectCollided(Bullets(innerIndex).Location.X, Bullets(innerIndex).Location.Y, Bullets(innerIndex).Width, Bullets(innerIndex).Height,
                                      picRockHeight04.Location.X, picRockHeight04.Location.Y, picRockHeight04.Width, picRockHeight04.Height) Then
                        Bullets(innerIndex).Location = New Point(1600, 1600)
                    End If
                Next

            Else
                picRockHeight05.Top += 5


                If ObjectCollided(picRockHeight05.Location.X, picRockHeight05.Location.Y, picRockHeight05.Width, picRockHeight05.Height,
                                  picPlayer.Location.X, picPlayer.Location.Y, picPlayer.Width, picPlayer.Height) Then
                    Invincibility()
                ElseIf ObjectCollided(picRockHeight05.Location.X, picRockHeight05.Location.Y, picRockHeight05.Width, picRockHeight05.Height,
                  picBoss.Location.X, picBoss.Location.Y, picBoss.Width, picBoss.Height) Then
                    lblMinutes.Text = Convert.ToString(intBossValue - 100)
                    picRockHeight05.Location = New Point(picRockHeight05.Location.X, 400)
                End If

                For innerIndex = 1 To Bullets.Length - 1
                    If ObjectCollided(Bullets(innerIndex).Location.X, Bullets(innerIndex).Location.Y, Bullets(innerIndex).Width, Bullets(innerIndex).Height,
                                      picRockHeight05.Location.X, picRockHeight05.Location.Y, picRockHeight05.Width, picRockHeight05.Height) Then
                        Bullets(innerIndex).Location = New Point(1600, 1600)
                    End If
                Next

            End If
        Next
    End Sub

    Private Sub tmrBossCheck_Tick(sender As Object, e As EventArgs) Handles tmrBossCheck.Tick
        ' Timer - Check to see if boss' health reach zero

        Dim intBossHealth As Integer = Convert.ToInt32(lblMinutes.Text)



        If intBossHealth <= 0 Then
            ' Start Transition
            Dim Bullets() As PictureBox = {picPlayerBullet01, picPlayerBullet02, picPlayerBullet03, picPlayerBullet04, picPlayerBullet05}

            For index = 1 To Bullets.Length - 1
                Bullets(index).Visible = False
            Next

            HaltSound()

            With snd
                .name = "SOUND" & intSound
                .Play(4, False, 800)
            End With
            tmrBossDecision.Enabled = False
            tmrMain.Enabled = False
            tmrW.Enabled = False
            tmrA.Enabled = False
            tmrS.Enabled = False
            tmrD.Enabled = False

            tmrBossEndLeft.Start()
            tmrBossEndDuration.Start()
            tmrBossEndLeave.Start()
            tmrBossCheck.Enabled = False

        End If
    End Sub

    Private Sub tmrBossEndLeft_Tick(sender As Object, e As EventArgs) Handles tmrBossEndLeft.Tick
        ' Time - Have boss shake left
        picBoss.Left -= 3
        tmrBossEndRight.Start()
        tmrBossEndLeft.Enabled = False
    End Sub

    Private Sub tmrBossEndRight_Tick(sender As Object, e As EventArgs) Handles tmrBossEndRight.Tick
        ' Timer - Have boss shake right
        picBoss.Left += 3
        tmrBossEndLeft.Start()
        tmrBossEndRight.Enabled = False
    End Sub

    Private Sub tmrBossEndDuration_Tick(sender As Object, e As EventArgs) Handles tmrBossEndDuration.Tick
        ' Timer - Plays win sounds and congratulates player
        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(9, False, 800)
        End With


        tmrBossEndDuration.Enabled = False

        MsgBox("Congratulations! You beat the game!",, "Win")
        MsgBox("Thanks for playing!",, "Win")

        Dim MsgBoxResponse = MsgBox("Would you like to try again?", MsgBoxStyle.YesNo, "Try again?")
        If MsgBoxResponse = MsgBoxResult.Yes Then
            Application.Restart()
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub tmrBossEndLeave_Tick(sender As Object, e As EventArgs) Handles tmrBossEndLeave.Tick
        ' Timer - Starts the boss transition to off-screen
        tmrBossEndLeft.Enabled = False
        tmrBossEndRight.Enabled = False

        tmrBossLeaving.Start()
        tmrBossEndLeave.Enabled = False
    End Sub

    Private Sub tmrBossLeaving_Tick(sender As Object, e As EventArgs) Handles tmrBossLeaving.Tick
        ' Timer - Have the boss leave the screen

        picBoss.Left += 3
    End Sub

    Private Sub tmrBackgroundMovement_Tick(sender As Object, e As EventArgs) Handles tmrBackgroundMovement.Tick
        ' Timer - Moves the background images

        Dim GrassBackground() As PictureBox = {picBackgroundGrass00, picBackgroundGrass01, picBackgroundGrass02, picBackgroundGrass03, picBackgroundGrass04, picBackgroundGrass05}
        Dim Mountain() As PictureBox = {picBackgroundMountain00, picBackgroundMountain01, picBackgroundMountain02, picBackgroundMountain03, picBackgroundMountain04, picBackgroundMountain05}

        For index = 1 To 5
            If (GrassBackground(index).Location.X + GrassBackground(index).Width) <= 0 Then
                GrassBackground(index).Location = New Point(Me.Width, GrassBackground(index).Location.Y)
            End If
            If (Mountain(index).Location.X + Mountain(index).Width) <= 0 Then
                Mountain(index).Location = New Point(Me.Width, Mountain(index).Location.Y)
            End If

            GrassBackground(index).Left -= 5
            Mountain(index).Left -= 1
        Next
    End Sub

    Private Sub tmrBackgroundTransition00_Tick(sender As Object, e As EventArgs) Handles tmrBackgroundTransition00.Tick
        ' Timer - Changes sky from day to dusk

        Dim intRed As Integer = Me.BackColor.R
        Dim intGreen As Integer = Me.BackColor.G
        Dim intBlue As Integer = Me.BackColor.B

        If intRed = 255 And intGreen = 128 And intBlue = 128 Then
            tmrBackgroundTransition00.Enabled = False
        Else
            If intRed <> 255 Then
                intRed += 1
            ElseIf intGreen <> 128 Then
                intGreen -= 1
            Else
                intBlue -= 1
            End If

            Me.BackColor = Color.FromArgb(intRed, intGreen, intBlue)
        End If
    End Sub

    Private Sub tmrBackgroundTransition01_Tick(sender As Object, e As EventArgs) Handles tmrBackgroundTransition01.Tick
        ' Timer - Changes sky from dusk to night

        Dim intRed As Integer = Me.BackColor.R
        Dim intGreen As Integer = Me.BackColor.G
        Dim intBlue As Integer = Me.BackColor.B

        If intRed = 0 And intGreen = 0 And intBlue = 100 Then
            tmrBackgroundTransition01.Enabled = False
        Else
            If intRed <> 0 Then
                intRed -= 1
            ElseIf intGreen <> 0 Then
                intGreen -= 1
            Else
                intBlue -= 1
            End If

            Me.BackColor = Color.FromArgb(intRed, intGreen, intBlue)
        End If
    End Sub

    Private Sub mnuHowToPlay_Click(sender As Object, e As EventArgs) Handles mnuHowToPlay.Click
        ' Menu Strip Item - Shows how to play
        Dim blnCanProceed As Boolean

        Do
            MsgBox("Use WASD or Arrow Keys to move.", MsgBoxStyle.Information, "Introduction")
            MsgBox("Use Spacebar to shoot a bullet.", MsgBoxStyle.Information, "Introduction")
            MsgBox("You have 5 bullets with you. Use them all and you will have to wait for another sets of ammos.", MsgBoxStyle.Information, "Introduction")
            MsgBox("Your goal is to score 1,000 points and beat the boss.", MsgBoxStyle.Information, "Introduction")
            MsgBox("Not scoring 1500 of them will result in a simple thanks.", MsgBoxStyle.Information, "Introduction")
            MsgBox("To score, you will have to shoot enemies within the 5 minute timer.", MsgBoxStyle.Information, "Introduction")
            MsgBox("You also have 5 lives. Lose them all and it is game over!", MsgBoxStyle.Information, "Introduction")
            MsgBox("Enemy's also shoot faster for each minute has passed. They also no longer appear within the last five seconds of the 5 minute timer.", MsgBoxStyle.Information, "Introduction")

            Dim MsgBoxResponse = MsgBox("Would you like to repeat this introduction?", MsgBoxStyle.YesNo, "Introduction")
            If MsgBoxResponse = MsgBoxResult.No Then
                blnCanProceed = True
            End If
        Loop Until blnCanProceed
    End Sub

    Private Sub mnuStart_Click(sender As Object, e As EventArgs) Handles mnuStart.Click
        ' Menu Strip Item - Starts the movement



        mnuStart.Enabled = False
        mnuRestart.Enabled = False
        lblMovement.Visible = False
        mnuMovement.Visible = False
        mnuRestart.Enabled = True

        MsgBox("Good luck!", MsgBoxStyle.Information, "Introduction")

        picPlayer.Visible = True
        Me.Size = New Size(1200, 400)
        Me.CenterToScreen()

        tmrMain.Start()
        tmrEnemy.Start()
        tmrEnemyBullet.Start()
        tmrEnemyBulletMovement.Start()
        tmrLevel.Start()
        tmrSeconds.Start()
        tmrMinutes.Start()
        tmrLastSeconds.Start()
        tmrLifeCheck.Start()
        tmrMusicTransition.Start()
        tmrBackgroundMovement.Start()



        intSound += 1
        With snd
            .name = "SOUND" & intSound
            .Play(1, False, 300)
        End With
    End Sub

    Private Sub mnuRestart_Click(sender As Object, e As EventArgs) Handles mnuRestart.Click
        ' Menu Strip Item - Restarts the program

        Dim MsgBoxResponse = MsgBox("Are you sure that you want to restart?", MsgBoxStyle.YesNo, "Restart")
        If MsgBoxResponse = MsgBoxResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Menu Strip Item - Restarts the program

        Dim MsgBoxResponse = MsgBox("Are you sure that you want to exit?", MsgBoxStyle.YesNo, "Exit")
        If MsgBoxResponse = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class

Public Class clsSound
    ' Class that supports multiple sound plays

    ' Gathering winmm.dll (Windows Multi-Media)
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String,
                                                                                  ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private oName As String = Nothing

    ' Gather the name
    Public Property name As String
        Set(value As String)
            oName = value

        End Set
        Get
            Return oName
        End Get
    End Property


    Public Sub Play(ByVal id As Integer, ByVal repeat As Boolean, Optional ByVal vol As Integer = 1000)
        ' Check if repeat is true
        If repeat Then
            mciSendString("Open " & GetFile(id) & " alias " & oName, "0", 0, 0)
            mciSendString("play " & oName & " repeat ", "0", 0, 0)
        Else
            mciSendString("Open " & GetFile(id) & " alias " & oName, "0", 0, 0)
            mciSendString("play " & oName, "0", 0, 0)
        End If

        ' Set Sound Audio
        mciSendString("setaudio " & oName & " volume to " & vol, "0", 0, 0)
    End Sub

    ' End all currently known sounds that is playing
    Public Sub Kill(ByVal song As String)
        mciSendString("close " & song, "0", 0, 0)
    End Sub

    ' Sound Libary Selection
    Private Function GetFile(ByVal id As Integer) As String
        Dim path As String

        Select Case id
            Case 0
                path = Application.StartupPath + "\Sounds\lasergun.mp3"
            Case 1
                path = Application.StartupPath + "\Sounds\level.mp3"
            Case 2
                path = Application.StartupPath + "\Sounds\levelSecond.mp3"
            Case 3
                path = Application.StartupPath + "\Sounds\levelLast.mp3"
            Case 4
                path = Application.StartupPath + "\Sounds\roar.mp3"
            Case 5
                path = Application.StartupPath + "\Sounds\deckTransition00.mp3"
            Case 6
                path = Application.StartupPath + "\Sounds\deckTransition01.mp3"
            Case 7
                path = Application.StartupPath + "\Sounds\pop.mp3"
            Case 8
                path = Application.StartupPath + "\Sounds\gameOver.mp3"
            Case 9
                path = Application.StartupPath + "\Sounds\win.mp3"
            Case 10
                path = Application.StartupPath + "\Sounds\bossMusic.mp3"
        End Select

        path = Chr(34) & path & Chr(34)

        Return path
    End Function
End Class