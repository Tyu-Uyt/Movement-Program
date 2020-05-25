<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovement
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovement))
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.tmrW = New System.Windows.Forms.Timer(Me.components)
        Me.tmrA = New System.Windows.Forms.Timer(Me.components)
        Me.tmrS = New System.Windows.Forms.Timer(Me.components)
        Me.tmrD = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCoolDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemyBullet = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemyBulletMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLevel = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreValue = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.tmrSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeColon = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.tmrMinutes = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLastSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemyMovement = New System.Windows.Forms.Timer(Me.components)
        Me.lblBullets = New System.Windows.Forms.Label()
        Me.lblBulletScore = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblLifeScore = New System.Windows.Forms.Label()
        Me.tmrLifeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMusicTransition = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMusicSecondTransition = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInvincibilityOnState = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInvincibilityOffState = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInvincibilityDuration = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransition = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransition2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransition3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransitionLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransitionRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransition4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransitionDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransition5 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransitionUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransition6 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossTransitionDuration = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossDecision = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRockFall = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRockFallPeriod = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRockFalling = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossEndLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossEndRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossEndDuration = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossEndLeave = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossLeaving = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBackgroundMovement = New System.Windows.Forms.Timer(Me.components)
        Me.picDeckTransition02 = New System.Windows.Forms.PictureBox()
        Me.picDeckTransition01 = New System.Windows.Forms.PictureBox()
        Me.picDeckTransition00 = New System.Windows.Forms.PictureBox()
        Me.picDeckMain03 = New System.Windows.Forms.PictureBox()
        Me.picDeckMain02 = New System.Windows.Forms.PictureBox()
        Me.picDeckMain01 = New System.Windows.Forms.PictureBox()
        Me.picDeckMain00 = New System.Windows.Forms.PictureBox()
        Me.picDeckHighlight03 = New System.Windows.Forms.PictureBox()
        Me.picDeckHighlight02 = New System.Windows.Forms.PictureBox()
        Me.picDeckLower03 = New System.Windows.Forms.PictureBox()
        Me.picDeckHighlight00 = New System.Windows.Forms.PictureBox()
        Me.picDeckLower02 = New System.Windows.Forms.PictureBox()
        Me.picDeckHighlight01 = New System.Windows.Forms.PictureBox()
        Me.picDeckLower01 = New System.Windows.Forms.PictureBox()
        Me.picDeckLower00 = New System.Windows.Forms.PictureBox()
        Me.picBoard = New System.Windows.Forms.PictureBox()
        Me.picBoardHighlight = New System.Windows.Forms.PictureBox()
        Me.picBoardLower = New System.Windows.Forms.PictureBox()
        Me.picEnemy09Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy08Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy07Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy06Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy05Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy04Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy03Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy02Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy01Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy00Bullet00 = New System.Windows.Forms.PictureBox()
        Me.picRockHeight05 = New System.Windows.Forms.PictureBox()
        Me.picRockHeight04 = New System.Windows.Forms.PictureBox()
        Me.picRockHeight03 = New System.Windows.Forms.PictureBox()
        Me.picRockHeight02 = New System.Windows.Forms.PictureBox()
        Me.picRockHeight01 = New System.Windows.Forms.PictureBox()
        Me.picRockHeight00 = New System.Windows.Forms.PictureBox()
        Me.picEnemy09 = New System.Windows.Forms.PictureBox()
        Me.picEnemy08 = New System.Windows.Forms.PictureBox()
        Me.picEnemy04 = New System.Windows.Forms.PictureBox()
        Me.picEnemy07 = New System.Windows.Forms.PictureBox()
        Me.picEnemy03 = New System.Windows.Forms.PictureBox()
        Me.picEnemy06 = New System.Windows.Forms.PictureBox()
        Me.picEnemy02 = New System.Windows.Forms.PictureBox()
        Me.picEnemy05 = New System.Windows.Forms.PictureBox()
        Me.picEnemy01 = New System.Windows.Forms.PictureBox()
        Me.picEnemy00 = New System.Windows.Forms.PictureBox()
        Me.picBoss = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picPlayerBullet05 = New System.Windows.Forms.PictureBox()
        Me.picPlayerBullet04 = New System.Windows.Forms.PictureBox()
        Me.picPlayerBullet03 = New System.Windows.Forms.PictureBox()
        Me.picPlayerBullet02 = New System.Windows.Forms.PictureBox()
        Me.picPlayerBullet01 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundGrass03 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundGrass05 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundGrass04 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundGrass00 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundGrass01 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundGrass02 = New System.Windows.Forms.PictureBox()
        Me.picBarrier = New System.Windows.Forms.PictureBox()
        Me.picBackgroundMountain00 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundMountain05 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundMountain04 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundMountain03 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundMountain02 = New System.Windows.Forms.PictureBox()
        Me.picBackgroundMountain01 = New System.Windows.Forms.PictureBox()
        Me.tmrBackgroundTransition00 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBackgroundTransition01 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMovement = New System.Windows.Forms.MenuStrip()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHowToPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMovement = New System.Windows.Forms.Label()
        Me.lblPaused = New System.Windows.Forms.Label()
        Me.picPauseBoxOutline = New System.Windows.Forms.PictureBox()
        Me.picPauseBox = New System.Windows.Forms.PictureBox()
        CType(Me.picDeckTransition02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckTransition01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckTransition00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckMain03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckMain02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckMain01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckMain00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckHighlight03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckHighlight02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckLower03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckHighlight00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckLower02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckHighlight01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckLower01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeckLower00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoardHighlight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoardLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy09Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy08Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy07Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy06Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy05Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy04Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy03Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy02Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy01Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy00Bullet00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockHeight05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockHeight04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockHeight03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockHeight02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockHeight01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockHeight00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerBullet05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerBullet04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerBullet03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerBullet02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerBullet01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundGrass03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundGrass05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundGrass04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundGrass00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundGrass01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundGrass02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarrier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundMountain00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundMountain05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundMountain04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundMountain03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundMountain02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundMountain01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMovement.SuspendLayout()
        CType(Me.picPauseBoxOutline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPauseBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 10
        '
        'tmrBullet
        '
        Me.tmrBullet.Interval = 10
        '
        'tmrW
        '
        Me.tmrW.Interval = 10
        '
        'tmrA
        '
        Me.tmrA.Interval = 10
        '
        'tmrS
        '
        Me.tmrS.Interval = 10
        '
        'tmrD
        '
        Me.tmrD.Interval = 10
        '
        'tmrCoolDown
        '
        Me.tmrCoolDown.Interval = 2700
        '
        'tmrEnemy
        '
        Me.tmrEnemy.Interval = 5000
        '
        'tmrEnemyBullet
        '
        Me.tmrEnemyBullet.Interval = 5000
        '
        'tmrEnemyBulletMovement
        '
        Me.tmrEnemyBulletMovement.Interval = 10
        '
        'tmrLevel
        '
        Me.tmrLevel.Interval = 300000
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Silver
        Me.lblScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblScore.Location = New System.Drawing.Point(28, 301)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(109, 31)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "SCORE: "
        '
        'lblScoreValue
        '
        Me.lblScoreValue.AutoSize = True
        Me.lblScoreValue.BackColor = System.Drawing.Color.Silver
        Me.lblScoreValue.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblScoreValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblScoreValue.Location = New System.Drawing.Point(128, 306)
        Me.lblScoreValue.Name = "lblScoreValue"
        Me.lblScoreValue.Size = New System.Drawing.Size(24, 26)
        Me.lblScoreValue.TabIndex = 5
        Me.lblScoreValue.Text = "0"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Silver
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTimer.Location = New System.Drawing.Point(261, 301)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(90, 31)
        Me.lblTimer.TabIndex = 4
        Me.lblTimer.Text = "TIME: "
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.BackColor = System.Drawing.Color.Silver
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMinutes.Location = New System.Drawing.Point(357, 306)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(24, 26)
        Me.lblMinutes.TabIndex = 5
        Me.lblMinutes.Text = "4"
        '
        'tmrSeconds
        '
        Me.tmrSeconds.Interval = 1000
        '
        'lblTimeColon
        '
        Me.lblTimeColon.AutoSize = True
        Me.lblTimeColon.BackColor = System.Drawing.Color.Silver
        Me.lblTimeColon.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeColon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTimeColon.Location = New System.Drawing.Point(387, 306)
        Me.lblTimeColon.Name = "lblTimeColon"
        Me.lblTimeColon.Size = New System.Drawing.Size(17, 26)
        Me.lblTimeColon.TabIndex = 5
        Me.lblTimeColon.Text = ":"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.BackColor = System.Drawing.Color.Silver
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSeconds.Location = New System.Drawing.Point(410, 306)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(36, 26)
        Me.lblSeconds.TabIndex = 5
        Me.lblSeconds.Text = "59"
        '
        'tmrMinutes
        '
        Me.tmrMinutes.Interval = 60000
        '
        'tmrLastSeconds
        '
        Me.tmrLastSeconds.Interval = 290000
        '
        'tmrEnemyMovement
        '
        Me.tmrEnemyMovement.Interval = 10
        '
        'lblBullets
        '
        Me.lblBullets.AutoSize = True
        Me.lblBullets.BackColor = System.Drawing.Color.Silver
        Me.lblBullets.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBullets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBullets.Location = New System.Drawing.Point(502, 301)
        Me.lblBullets.Name = "lblBullets"
        Me.lblBullets.Size = New System.Drawing.Size(132, 31)
        Me.lblBullets.TabIndex = 4
        Me.lblBullets.Text = "BULLETS: "
        '
        'lblBulletScore
        '
        Me.lblBulletScore.AutoSize = True
        Me.lblBulletScore.BackColor = System.Drawing.Color.Silver
        Me.lblBulletScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblBulletScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBulletScore.Location = New System.Drawing.Point(627, 306)
        Me.lblBulletScore.Name = "lblBulletScore"
        Me.lblBulletScore.Size = New System.Drawing.Size(24, 26)
        Me.lblBulletScore.TabIndex = 5
        Me.lblBulletScore.Text = "5"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.BackColor = System.Drawing.Color.Silver
        Me.lblLives.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLives.Location = New System.Drawing.Point(734, 301)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(87, 31)
        Me.lblLives.TabIndex = 4
        Me.lblLives.Text = "LIVES:"
        '
        'lblLifeScore
        '
        Me.lblLifeScore.AutoSize = True
        Me.lblLifeScore.BackColor = System.Drawing.Color.Silver
        Me.lblLifeScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblLifeScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLifeScore.Location = New System.Drawing.Point(827, 306)
        Me.lblLifeScore.Name = "lblLifeScore"
        Me.lblLifeScore.Size = New System.Drawing.Size(24, 26)
        Me.lblLifeScore.TabIndex = 5
        Me.lblLifeScore.Text = "5"
        '
        'tmrLifeCheck
        '
        Me.tmrLifeCheck.Interval = 10
        '
        'tmrMusicTransition
        '
        Me.tmrMusicTransition.Interval = 130000
        '
        'tmrMusicSecondTransition
        '
        Me.tmrMusicSecondTransition.Interval = 140000
        '
        'tmrInvincibilityOnState
        '
        '
        'tmrInvincibilityOffState
        '
        '
        'tmrInvincibilityDuration
        '
        Me.tmrInvincibilityDuration.Interval = 3000
        '
        'tmrBossTransition
        '
        Me.tmrBossTransition.Interval = 10
        '
        'tmrBossTransition2
        '
        Me.tmrBossTransition2.Interval = 5000
        '
        'tmrBossTransition3
        '
        Me.tmrBossTransition3.Interval = 9000
        '
        'tmrBossTransitionLeft
        '
        Me.tmrBossTransitionLeft.Interval = 10
        '
        'tmrBossTransitionRight
        '
        Me.tmrBossTransitionRight.Interval = 10
        '
        'tmrBossTransition4
        '
        Me.tmrBossTransition4.Interval = 11000
        '
        'tmrBossTransitionDown
        '
        Me.tmrBossTransitionDown.Interval = 10
        '
        'tmrBossTransition5
        '
        Me.tmrBossTransition5.Interval = 12000
        '
        'tmrBossTransitionUp
        '
        Me.tmrBossTransitionUp.Interval = 10
        '
        'tmrBossTransition6
        '
        Me.tmrBossTransition6.Interval = 13000
        '
        'tmrBossTransitionDuration
        '
        Me.tmrBossTransitionDuration.Interval = 16000
        '
        'tmrBossDecision
        '
        Me.tmrBossDecision.Interval = 10000
        '
        'tmrRockFall
        '
        '
        'tmrRockFallPeriod
        '
        Me.tmrRockFallPeriod.Interval = 3000
        '
        'tmrRockFalling
        '
        Me.tmrRockFalling.Interval = 10
        '
        'tmrBossCheck
        '
        Me.tmrBossCheck.Interval = 10
        '
        'tmrBossEndLeft
        '
        '
        'tmrBossEndRight
        '
        '
        'tmrBossEndDuration
        '
        Me.tmrBossEndDuration.Interval = 7000
        '
        'tmrBossEndLeave
        '
        Me.tmrBossEndLeave.Interval = 3000
        '
        'tmrBossLeaving
        '
        Me.tmrBossLeaving.Interval = 10
        '
        'tmrBackgroundMovement
        '
        Me.tmrBackgroundMovement.Interval = 10
        '
        'picDeckTransition02
        '
        Me.picDeckTransition02.BackColor = System.Drawing.Color.Gray
        Me.picDeckTransition02.Location = New System.Drawing.Point(246, 352)
        Me.picDeckTransition02.Name = "picDeckTransition02"
        Me.picDeckTransition02.Size = New System.Drawing.Size(210, 12)
        Me.picDeckTransition02.TabIndex = 8
        Me.picDeckTransition02.TabStop = False
        Me.picDeckTransition02.Visible = False
        '
        'picDeckTransition01
        '
        Me.picDeckTransition01.BackColor = System.Drawing.Color.Silver
        Me.picDeckTransition01.Location = New System.Drawing.Point(246, 344)
        Me.picDeckTransition01.Name = "picDeckTransition01"
        Me.picDeckTransition01.Size = New System.Drawing.Size(210, 8)
        Me.picDeckTransition01.TabIndex = 8
        Me.picDeckTransition01.TabStop = False
        Me.picDeckTransition01.Visible = False
        '
        'picDeckTransition00
        '
        Me.picDeckTransition00.BackColor = System.Drawing.Color.Gray
        Me.picDeckTransition00.Location = New System.Drawing.Point(247, 334)
        Me.picDeckTransition00.Name = "picDeckTransition00"
        Me.picDeckTransition00.Size = New System.Drawing.Size(208, 10)
        Me.picDeckTransition00.TabIndex = 8
        Me.picDeckTransition00.TabStop = False
        Me.picDeckTransition00.Visible = False
        '
        'picDeckMain03
        '
        Me.picDeckMain03.BackColor = System.Drawing.Color.Silver
        Me.picDeckMain03.Location = New System.Drawing.Point(725, 301)
        Me.picDeckMain03.Name = "picDeckMain03"
        Me.picDeckMain03.Size = New System.Drawing.Size(197, 33)
        Me.picDeckMain03.TabIndex = 7
        Me.picDeckMain03.TabStop = False
        '
        'picDeckMain02
        '
        Me.picDeckMain02.BackColor = System.Drawing.Color.Silver
        Me.picDeckMain02.Location = New System.Drawing.Point(488, 301)
        Me.picDeckMain02.Name = "picDeckMain02"
        Me.picDeckMain02.Size = New System.Drawing.Size(197, 33)
        Me.picDeckMain02.TabIndex = 7
        Me.picDeckMain02.TabStop = False
        '
        'picDeckMain01
        '
        Me.picDeckMain01.BackColor = System.Drawing.Color.Silver
        Me.picDeckMain01.Location = New System.Drawing.Point(252, 301)
        Me.picDeckMain01.Name = "picDeckMain01"
        Me.picDeckMain01.Size = New System.Drawing.Size(197, 33)
        Me.picDeckMain01.TabIndex = 7
        Me.picDeckMain01.TabStop = False
        '
        'picDeckMain00
        '
        Me.picDeckMain00.BackColor = System.Drawing.Color.Silver
        Me.picDeckMain00.Location = New System.Drawing.Point(12, 301)
        Me.picDeckMain00.Name = "picDeckMain00"
        Me.picDeckMain00.Size = New System.Drawing.Size(197, 33)
        Me.picDeckMain00.TabIndex = 7
        Me.picDeckMain00.TabStop = False
        '
        'picDeckHighlight03
        '
        Me.picDeckHighlight03.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picDeckHighlight03.Location = New System.Drawing.Point(725, 297)
        Me.picDeckHighlight03.Name = "picDeckHighlight03"
        Me.picDeckHighlight03.Size = New System.Drawing.Size(197, 37)
        Me.picDeckHighlight03.TabIndex = 7
        Me.picDeckHighlight03.TabStop = False
        '
        'picDeckHighlight02
        '
        Me.picDeckHighlight02.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picDeckHighlight02.Location = New System.Drawing.Point(488, 297)
        Me.picDeckHighlight02.Name = "picDeckHighlight02"
        Me.picDeckHighlight02.Size = New System.Drawing.Size(197, 37)
        Me.picDeckHighlight02.TabIndex = 7
        Me.picDeckHighlight02.TabStop = False
        '
        'picDeckLower03
        '
        Me.picDeckLower03.BackColor = System.Drawing.Color.Gray
        Me.picDeckLower03.Location = New System.Drawing.Point(719, 320)
        Me.picDeckLower03.Name = "picDeckLower03"
        Me.picDeckLower03.Size = New System.Drawing.Size(210, 24)
        Me.picDeckLower03.TabIndex = 8
        Me.picDeckLower03.TabStop = False
        '
        'picDeckHighlight00
        '
        Me.picDeckHighlight00.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picDeckHighlight00.Location = New System.Drawing.Point(12, 297)
        Me.picDeckHighlight00.Name = "picDeckHighlight00"
        Me.picDeckHighlight00.Size = New System.Drawing.Size(197, 37)
        Me.picDeckHighlight00.TabIndex = 7
        Me.picDeckHighlight00.TabStop = False
        '
        'picDeckLower02
        '
        Me.picDeckLower02.BackColor = System.Drawing.Color.Gray
        Me.picDeckLower02.Location = New System.Drawing.Point(482, 320)
        Me.picDeckLower02.Name = "picDeckLower02"
        Me.picDeckLower02.Size = New System.Drawing.Size(210, 24)
        Me.picDeckLower02.TabIndex = 8
        Me.picDeckLower02.TabStop = False
        '
        'picDeckHighlight01
        '
        Me.picDeckHighlight01.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picDeckHighlight01.Location = New System.Drawing.Point(252, 297)
        Me.picDeckHighlight01.Name = "picDeckHighlight01"
        Me.picDeckHighlight01.Size = New System.Drawing.Size(197, 37)
        Me.picDeckHighlight01.TabIndex = 7
        Me.picDeckHighlight01.TabStop = False
        '
        'picDeckLower01
        '
        Me.picDeckLower01.BackColor = System.Drawing.Color.Gray
        Me.picDeckLower01.Location = New System.Drawing.Point(246, 320)
        Me.picDeckLower01.Name = "picDeckLower01"
        Me.picDeckLower01.Size = New System.Drawing.Size(210, 24)
        Me.picDeckLower01.TabIndex = 8
        Me.picDeckLower01.TabStop = False
        '
        'picDeckLower00
        '
        Me.picDeckLower00.BackColor = System.Drawing.Color.Gray
        Me.picDeckLower00.Location = New System.Drawing.Point(6, 320)
        Me.picDeckLower00.Name = "picDeckLower00"
        Me.picDeckLower00.Size = New System.Drawing.Size(210, 24)
        Me.picDeckLower00.TabIndex = 8
        Me.picDeckLower00.TabStop = False
        '
        'picBoard
        '
        Me.picBoard.BackColor = System.Drawing.Color.Silver
        Me.picBoard.Location = New System.Drawing.Point(-5, 312)
        Me.picBoard.Name = "picBoard"
        Me.picBoard.Size = New System.Drawing.Size(1620, 40)
        Me.picBoard.TabIndex = 6
        Me.picBoard.TabStop = False
        '
        'picBoardHighlight
        '
        Me.picBoardHighlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picBoardHighlight.Location = New System.Drawing.Point(-5, 308)
        Me.picBoardHighlight.Name = "picBoardHighlight"
        Me.picBoardHighlight.Size = New System.Drawing.Size(1620, 40)
        Me.picBoardHighlight.TabIndex = 6
        Me.picBoardHighlight.TabStop = False
        '
        'picBoardLower
        '
        Me.picBoardLower.BackColor = System.Drawing.Color.Gray
        Me.picBoardLower.Location = New System.Drawing.Point(-5, 312)
        Me.picBoardLower.Name = "picBoardLower"
        Me.picBoardLower.Size = New System.Drawing.Size(1642, 50)
        Me.picBoardLower.TabIndex = 6
        Me.picBoardLower.TabStop = False
        '
        'picEnemy09Bullet00
        '
        Me.picEnemy09Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy09Bullet00.Location = New System.Drawing.Point(694, 548)
        Me.picEnemy09Bullet00.Name = "picEnemy09Bullet00"
        Me.picEnemy09Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy09Bullet00.TabIndex = 3
        Me.picEnemy09Bullet00.TabStop = False
        '
        'picEnemy08Bullet00
        '
        Me.picEnemy08Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy08Bullet00.Location = New System.Drawing.Point(663, 548)
        Me.picEnemy08Bullet00.Name = "picEnemy08Bullet00"
        Me.picEnemy08Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy08Bullet00.TabIndex = 3
        Me.picEnemy08Bullet00.TabStop = False
        '
        'picEnemy07Bullet00
        '
        Me.picEnemy07Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy07Bullet00.Location = New System.Drawing.Point(632, 548)
        Me.picEnemy07Bullet00.Name = "picEnemy07Bullet00"
        Me.picEnemy07Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy07Bullet00.TabIndex = 3
        Me.picEnemy07Bullet00.TabStop = False
        '
        'picEnemy06Bullet00
        '
        Me.picEnemy06Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy06Bullet00.Location = New System.Drawing.Point(601, 548)
        Me.picEnemy06Bullet00.Name = "picEnemy06Bullet00"
        Me.picEnemy06Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy06Bullet00.TabIndex = 3
        Me.picEnemy06Bullet00.TabStop = False
        '
        'picEnemy05Bullet00
        '
        Me.picEnemy05Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy05Bullet00.Location = New System.Drawing.Point(570, 548)
        Me.picEnemy05Bullet00.Name = "picEnemy05Bullet00"
        Me.picEnemy05Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy05Bullet00.TabIndex = 3
        Me.picEnemy05Bullet00.TabStop = False
        '
        'picEnemy04Bullet00
        '
        Me.picEnemy04Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy04Bullet00.Location = New System.Drawing.Point(539, 548)
        Me.picEnemy04Bullet00.Name = "picEnemy04Bullet00"
        Me.picEnemy04Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy04Bullet00.TabIndex = 3
        Me.picEnemy04Bullet00.TabStop = False
        '
        'picEnemy03Bullet00
        '
        Me.picEnemy03Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy03Bullet00.Location = New System.Drawing.Point(508, 548)
        Me.picEnemy03Bullet00.Name = "picEnemy03Bullet00"
        Me.picEnemy03Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy03Bullet00.TabIndex = 3
        Me.picEnemy03Bullet00.TabStop = False
        '
        'picEnemy02Bullet00
        '
        Me.picEnemy02Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy02Bullet00.Location = New System.Drawing.Point(477, 548)
        Me.picEnemy02Bullet00.Name = "picEnemy02Bullet00"
        Me.picEnemy02Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy02Bullet00.TabIndex = 3
        Me.picEnemy02Bullet00.TabStop = False
        '
        'picEnemy01Bullet00
        '
        Me.picEnemy01Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy01Bullet00.Location = New System.Drawing.Point(446, 548)
        Me.picEnemy01Bullet00.Name = "picEnemy01Bullet00"
        Me.picEnemy01Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy01Bullet00.TabIndex = 3
        Me.picEnemy01Bullet00.TabStop = False
        '
        'picEnemy00Bullet00
        '
        Me.picEnemy00Bullet00.BackColor = System.Drawing.Color.Black
        Me.picEnemy00Bullet00.Location = New System.Drawing.Point(415, 548)
        Me.picEnemy00Bullet00.Name = "picEnemy00Bullet00"
        Me.picEnemy00Bullet00.Size = New System.Drawing.Size(5, 5)
        Me.picEnemy00Bullet00.TabIndex = 3
        Me.picEnemy00Bullet00.TabStop = False
        '
        'picRockHeight05
        '
        Me.picRockHeight05.BackColor = System.Drawing.Color.Silver
        Me.picRockHeight05.Location = New System.Drawing.Point(875, 618)
        Me.picRockHeight05.Name = "picRockHeight05"
        Me.picRockHeight05.Size = New System.Drawing.Size(30, 30)
        Me.picRockHeight05.TabIndex = 11
        Me.picRockHeight05.TabStop = False
        '
        'picRockHeight04
        '
        Me.picRockHeight04.BackColor = System.Drawing.Color.Silver
        Me.picRockHeight04.Location = New System.Drawing.Point(769, 618)
        Me.picRockHeight04.Name = "picRockHeight04"
        Me.picRockHeight04.Size = New System.Drawing.Size(30, 30)
        Me.picRockHeight04.TabIndex = 11
        Me.picRockHeight04.TabStop = False
        '
        'picRockHeight03
        '
        Me.picRockHeight03.BackColor = System.Drawing.Color.Silver
        Me.picRockHeight03.Location = New System.Drawing.Point(663, 618)
        Me.picRockHeight03.Name = "picRockHeight03"
        Me.picRockHeight03.Size = New System.Drawing.Size(30, 30)
        Me.picRockHeight03.TabIndex = 11
        Me.picRockHeight03.TabStop = False
        '
        'picRockHeight02
        '
        Me.picRockHeight02.BackColor = System.Drawing.Color.Silver
        Me.picRockHeight02.Location = New System.Drawing.Point(557, 618)
        Me.picRockHeight02.Name = "picRockHeight02"
        Me.picRockHeight02.Size = New System.Drawing.Size(30, 30)
        Me.picRockHeight02.TabIndex = 11
        Me.picRockHeight02.TabStop = False
        '
        'picRockHeight01
        '
        Me.picRockHeight01.BackColor = System.Drawing.Color.Silver
        Me.picRockHeight01.Location = New System.Drawing.Point(451, 618)
        Me.picRockHeight01.Name = "picRockHeight01"
        Me.picRockHeight01.Size = New System.Drawing.Size(30, 30)
        Me.picRockHeight01.TabIndex = 11
        Me.picRockHeight01.TabStop = False
        '
        'picRockHeight00
        '
        Me.picRockHeight00.BackColor = System.Drawing.Color.Silver
        Me.picRockHeight00.Location = New System.Drawing.Point(345, 618)
        Me.picRockHeight00.Name = "picRockHeight00"
        Me.picRockHeight00.Size = New System.Drawing.Size(30, 30)
        Me.picRockHeight00.TabIndex = 11
        Me.picRockHeight00.TabStop = False
        '
        'picEnemy09
        '
        Me.picEnemy09.BackColor = System.Drawing.Color.Purple
        Me.picEnemy09.Location = New System.Drawing.Point(277, 579)
        Me.picEnemy09.Name = "picEnemy09"
        Me.picEnemy09.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy09.TabIndex = 2
        Me.picEnemy09.TabStop = False
        '
        'picEnemy08
        '
        Me.picEnemy08.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picEnemy08.Location = New System.Drawing.Point(246, 579)
        Me.picEnemy08.Name = "picEnemy08"
        Me.picEnemy08.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy08.TabIndex = 2
        Me.picEnemy08.TabStop = False
        '
        'picEnemy04
        '
        Me.picEnemy04.BackColor = System.Drawing.Color.Green
        Me.picEnemy04.Location = New System.Drawing.Point(277, 548)
        Me.picEnemy04.Name = "picEnemy04"
        Me.picEnemy04.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy04.TabIndex = 2
        Me.picEnemy04.TabStop = False
        '
        'picEnemy07
        '
        Me.picEnemy07.BackColor = System.Drawing.Color.Fuchsia
        Me.picEnemy07.Location = New System.Drawing.Point(215, 579)
        Me.picEnemy07.Name = "picEnemy07"
        Me.picEnemy07.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy07.TabIndex = 2
        Me.picEnemy07.TabStop = False
        '
        'picEnemy03
        '
        Me.picEnemy03.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picEnemy03.Location = New System.Drawing.Point(246, 548)
        Me.picEnemy03.Name = "picEnemy03"
        Me.picEnemy03.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy03.TabIndex = 2
        Me.picEnemy03.TabStop = False
        '
        'picEnemy06
        '
        Me.picEnemy06.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picEnemy06.Location = New System.Drawing.Point(184, 579)
        Me.picEnemy06.Name = "picEnemy06"
        Me.picEnemy06.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy06.TabIndex = 2
        Me.picEnemy06.TabStop = False
        '
        'picEnemy02
        '
        Me.picEnemy02.BackColor = System.Drawing.Color.Lime
        Me.picEnemy02.Location = New System.Drawing.Point(215, 548)
        Me.picEnemy02.Name = "picEnemy02"
        Me.picEnemy02.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy02.TabIndex = 2
        Me.picEnemy02.TabStop = False
        '
        'picEnemy05
        '
        Me.picEnemy05.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picEnemy05.Location = New System.Drawing.Point(153, 579)
        Me.picEnemy05.Name = "picEnemy05"
        Me.picEnemy05.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy05.TabIndex = 2
        Me.picEnemy05.TabStop = False
        '
        'picEnemy01
        '
        Me.picEnemy01.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picEnemy01.Location = New System.Drawing.Point(184, 548)
        Me.picEnemy01.Name = "picEnemy01"
        Me.picEnemy01.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy01.TabIndex = 2
        Me.picEnemy01.TabStop = False
        '
        'picEnemy00
        '
        Me.picEnemy00.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picEnemy00.Location = New System.Drawing.Point(153, 548)
        Me.picEnemy00.Name = "picEnemy00"
        Me.picEnemy00.Size = New System.Drawing.Size(25, 25)
        Me.picEnemy00.TabIndex = 2
        Me.picEnemy00.TabStop = False
        '
        'picBoss
        '
        Me.picBoss.BackColor = System.Drawing.Color.Red
        Me.picBoss.Location = New System.Drawing.Point(981, 523)
        Me.picBoss.Name = "picBoss"
        Me.picBoss.Size = New System.Drawing.Size(250, 250)
        Me.picBoss.TabIndex = 10
        Me.picBoss.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picPlayer.Location = New System.Drawing.Point(112, 174)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(50, 50)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        Me.picPlayer.Visible = False
        '
        'picPlayerBullet05
        '
        Me.picPlayerBullet05.BackColor = System.Drawing.Color.Gray
        Me.picPlayerBullet05.Location = New System.Drawing.Point(34, 508)
        Me.picPlayerBullet05.Name = "picPlayerBullet05"
        Me.picPlayerBullet05.Size = New System.Drawing.Size(20, 5)
        Me.picPlayerBullet05.TabIndex = 1
        Me.picPlayerBullet05.TabStop = False
        '
        'picPlayerBullet04
        '
        Me.picPlayerBullet04.BackColor = System.Drawing.Color.Gray
        Me.picPlayerBullet04.Location = New System.Drawing.Point(34, 497)
        Me.picPlayerBullet04.Name = "picPlayerBullet04"
        Me.picPlayerBullet04.Size = New System.Drawing.Size(20, 5)
        Me.picPlayerBullet04.TabIndex = 1
        Me.picPlayerBullet04.TabStop = False
        '
        'picPlayerBullet03
        '
        Me.picPlayerBullet03.BackColor = System.Drawing.Color.Gray
        Me.picPlayerBullet03.Location = New System.Drawing.Point(34, 486)
        Me.picPlayerBullet03.Name = "picPlayerBullet03"
        Me.picPlayerBullet03.Size = New System.Drawing.Size(20, 5)
        Me.picPlayerBullet03.TabIndex = 1
        Me.picPlayerBullet03.TabStop = False
        '
        'picPlayerBullet02
        '
        Me.picPlayerBullet02.BackColor = System.Drawing.Color.Gray
        Me.picPlayerBullet02.Location = New System.Drawing.Point(34, 475)
        Me.picPlayerBullet02.Name = "picPlayerBullet02"
        Me.picPlayerBullet02.Size = New System.Drawing.Size(20, 5)
        Me.picPlayerBullet02.TabIndex = 1
        Me.picPlayerBullet02.TabStop = False
        '
        'picPlayerBullet01
        '
        Me.picPlayerBullet01.BackColor = System.Drawing.Color.Gray
        Me.picPlayerBullet01.Location = New System.Drawing.Point(34, 464)
        Me.picPlayerBullet01.Name = "picPlayerBullet01"
        Me.picPlayerBullet01.Size = New System.Drawing.Size(20, 5)
        Me.picPlayerBullet01.TabIndex = 1
        Me.picPlayerBullet01.TabStop = False
        '
        'picBackgroundGrass03
        '
        Me.picBackgroundGrass03.BackgroundImage = CType(resources.GetObject("picBackgroundGrass03.BackgroundImage"), System.Drawing.Image)
        Me.picBackgroundGrass03.Location = New System.Drawing.Point(595, 253)
        Me.picBackgroundGrass03.Name = "picBackgroundGrass03"
        Me.picBackgroundGrass03.Size = New System.Drawing.Size(300, 93)
        Me.picBackgroundGrass03.TabIndex = 12
        Me.picBackgroundGrass03.TabStop = False
        '
        'picBackgroundGrass05
        '
        Me.picBackgroundGrass05.BackgroundImage = CType(resources.GetObject("picBackgroundGrass05.BackgroundImage"), System.Drawing.Image)
        Me.picBackgroundGrass05.Location = New System.Drawing.Point(1195, 253)
        Me.picBackgroundGrass05.Name = "picBackgroundGrass05"
        Me.picBackgroundGrass05.Size = New System.Drawing.Size(300, 93)
        Me.picBackgroundGrass05.TabIndex = 12
        Me.picBackgroundGrass05.TabStop = False
        '
        'picBackgroundGrass04
        '
        Me.picBackgroundGrass04.BackgroundImage = CType(resources.GetObject("picBackgroundGrass04.BackgroundImage"), System.Drawing.Image)
        Me.picBackgroundGrass04.Location = New System.Drawing.Point(895, 253)
        Me.picBackgroundGrass04.Name = "picBackgroundGrass04"
        Me.picBackgroundGrass04.Size = New System.Drawing.Size(300, 93)
        Me.picBackgroundGrass04.TabIndex = 12
        Me.picBackgroundGrass04.TabStop = False
        '
        'picBackgroundGrass00
        '
        Me.picBackgroundGrass00.Image = Global.Movement.My.Resources.Resources.bg_hills_300x931
        Me.picBackgroundGrass00.Location = New System.Drawing.Point(104, 435)
        Me.picBackgroundGrass00.Name = "picBackgroundGrass00"
        Me.picBackgroundGrass00.Size = New System.Drawing.Size(300, 93)
        Me.picBackgroundGrass00.TabIndex = 12
        Me.picBackgroundGrass00.TabStop = False
        '
        'picBackgroundGrass01
        '
        Me.picBackgroundGrass01.BackColor = System.Drawing.Color.Transparent
        Me.picBackgroundGrass01.Image = Global.Movement.My.Resources.Resources.bg_hills_300x931
        Me.picBackgroundGrass01.Location = New System.Drawing.Point(-5, 253)
        Me.picBackgroundGrass01.Name = "picBackgroundGrass01"
        Me.picBackgroundGrass01.Size = New System.Drawing.Size(300, 93)
        Me.picBackgroundGrass01.TabIndex = 12
        Me.picBackgroundGrass01.TabStop = False
        '
        'picBackgroundGrass02
        '
        Me.picBackgroundGrass02.BackgroundImage = CType(resources.GetObject("picBackgroundGrass02.BackgroundImage"), System.Drawing.Image)
        Me.picBackgroundGrass02.Location = New System.Drawing.Point(295, 253)
        Me.picBackgroundGrass02.Name = "picBackgroundGrass02"
        Me.picBackgroundGrass02.Size = New System.Drawing.Size(300, 93)
        Me.picBackgroundGrass02.TabIndex = 12
        Me.picBackgroundGrass02.TabStop = False
        '
        'picBarrier
        '
        Me.picBarrier.BackColor = System.Drawing.Color.Transparent
        Me.picBarrier.Location = New System.Drawing.Point(-5, 287)
        Me.picBarrier.Name = "picBarrier"
        Me.picBarrier.Size = New System.Drawing.Size(1652, 88)
        Me.picBarrier.TabIndex = 9
        Me.picBarrier.TabStop = False
        '
        'picBackgroundMountain00
        '
        Me.picBackgroundMountain00.Image = Global.Movement.My.Resources.Resources.bg_mountains_300x147
        Me.picBackgroundMountain00.Location = New System.Drawing.Point(104, 381)
        Me.picBackgroundMountain00.Name = "picBackgroundMountain00"
        Me.picBackgroundMountain00.Size = New System.Drawing.Size(300, 147)
        Me.picBackgroundMountain00.TabIndex = 13
        Me.picBackgroundMountain00.TabStop = False
        '
        'picBackgroundMountain05
        '
        Me.picBackgroundMountain05.Image = CType(resources.GetObject("picBackgroundMountain05.Image"), System.Drawing.Image)
        Me.picBackgroundMountain05.Location = New System.Drawing.Point(1195, 134)
        Me.picBackgroundMountain05.Name = "picBackgroundMountain05"
        Me.picBackgroundMountain05.Size = New System.Drawing.Size(300, 147)
        Me.picBackgroundMountain05.TabIndex = 13
        Me.picBackgroundMountain05.TabStop = False
        '
        'picBackgroundMountain04
        '
        Me.picBackgroundMountain04.Image = CType(resources.GetObject("picBackgroundMountain04.Image"), System.Drawing.Image)
        Me.picBackgroundMountain04.Location = New System.Drawing.Point(895, 134)
        Me.picBackgroundMountain04.Name = "picBackgroundMountain04"
        Me.picBackgroundMountain04.Size = New System.Drawing.Size(300, 147)
        Me.picBackgroundMountain04.TabIndex = 13
        Me.picBackgroundMountain04.TabStop = False
        '
        'picBackgroundMountain03
        '
        Me.picBackgroundMountain03.Image = CType(resources.GetObject("picBackgroundMountain03.Image"), System.Drawing.Image)
        Me.picBackgroundMountain03.Location = New System.Drawing.Point(595, 134)
        Me.picBackgroundMountain03.Name = "picBackgroundMountain03"
        Me.picBackgroundMountain03.Size = New System.Drawing.Size(300, 147)
        Me.picBackgroundMountain03.TabIndex = 13
        Me.picBackgroundMountain03.TabStop = False
        '
        'picBackgroundMountain02
        '
        Me.picBackgroundMountain02.Image = Global.Movement.My.Resources.Resources.bg_mountains_300x147
        Me.picBackgroundMountain02.Location = New System.Drawing.Point(295, 134)
        Me.picBackgroundMountain02.Name = "picBackgroundMountain02"
        Me.picBackgroundMountain02.Size = New System.Drawing.Size(300, 147)
        Me.picBackgroundMountain02.TabIndex = 13
        Me.picBackgroundMountain02.TabStop = False
        '
        'picBackgroundMountain01
        '
        Me.picBackgroundMountain01.Image = Global.Movement.My.Resources.Resources.bg_mountains_300x147
        Me.picBackgroundMountain01.Location = New System.Drawing.Point(-5, 134)
        Me.picBackgroundMountain01.Name = "picBackgroundMountain01"
        Me.picBackgroundMountain01.Size = New System.Drawing.Size(300, 147)
        Me.picBackgroundMountain01.TabIndex = 13
        Me.picBackgroundMountain01.TabStop = False
        '
        'tmrBackgroundTransition00
        '
        '
        'tmrBackgroundTransition01
        '
        Me.tmrBackgroundTransition01.Interval = 10
        '
        'mnuMovement
        '
        Me.mnuMovement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit, Me.mnuRestart, Me.mnuStart, Me.mnuHowToPlay})
        Me.mnuMovement.Location = New System.Drawing.Point(0, 0)
        Me.mnuMovement.Name = "mnuMovement"
        Me.mnuMovement.Size = New System.Drawing.Size(1184, 24)
        Me.mnuMovement.TabIndex = 14
        Me.mnuMovement.Text = "MenuStrip1"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(38, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuRestart
        '
        Me.mnuRestart.Enabled = False
        Me.mnuRestart.Name = "mnuRestart"
        Me.mnuRestart.Size = New System.Drawing.Size(55, 20)
        Me.mnuRestart.Text = "&Restart"
        '
        'mnuStart
        '
        Me.mnuStart.Name = "mnuStart"
        Me.mnuStart.Size = New System.Drawing.Size(43, 20)
        Me.mnuStart.Text = "&Start"
        '
        'mnuHowToPlay
        '
        Me.mnuHowToPlay.Name = "mnuHowToPlay"
        Me.mnuHowToPlay.Size = New System.Drawing.Size(84, 20)
        Me.mnuHowToPlay.Text = "&How To Play"
        '
        'lblMovement
        '
        Me.lblMovement.AutoSize = True
        Me.lblMovement.BackColor = System.Drawing.Color.Transparent
        Me.lblMovement.Font = New System.Drawing.Font("Microsoft YaHei UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovement.ForeColor = System.Drawing.Color.White
        Me.lblMovement.Location = New System.Drawing.Point(47, 45)
        Me.lblMovement.Name = "lblMovement"
        Me.lblMovement.Size = New System.Drawing.Size(387, 86)
        Me.lblMovement.TabIndex = 15
        Me.lblMovement.Text = "Movement"
        '
        'lblPaused
        '
        Me.lblPaused.AutoSize = True
        Me.lblPaused.BackColor = System.Drawing.Color.Silver
        Me.lblPaused.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaused.ForeColor = System.Drawing.Color.White
        Me.lblPaused.Location = New System.Drawing.Point(529, 73)
        Me.lblPaused.Name = "lblPaused"
        Me.lblPaused.Size = New System.Drawing.Size(156, 50)
        Me.lblPaused.TabIndex = 16
        Me.lblPaused.Text = "Paused"
        Me.lblPaused.Visible = False
        '
        'picPauseBoxOutline
        '
        Me.picPauseBoxOutline.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picPauseBoxOutline.Location = New System.Drawing.Point(491, 64)
        Me.picPauseBoxOutline.Name = "picPauseBoxOutline"
        Me.picPauseBoxOutline.Size = New System.Drawing.Size(232, 71)
        Me.picPauseBoxOutline.TabIndex = 17
        Me.picPauseBoxOutline.TabStop = False
        Me.picPauseBoxOutline.Visible = False
        '
        'picPauseBox
        '
        Me.picPauseBox.BackColor = System.Drawing.Color.Silver
        Me.picPauseBox.Location = New System.Drawing.Point(500, 73)
        Me.picPauseBox.Name = "picPauseBox"
        Me.picPauseBox.Size = New System.Drawing.Size(214, 55)
        Me.picPauseBox.TabIndex = 17
        Me.picPauseBox.TabStop = False
        Me.picPauseBox.Visible = False
        '
        'frmMovement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 361)
        Me.Controls.Add(Me.mnuMovement)
        Me.Controls.Add(Me.lblPaused)
        Me.Controls.Add(Me.picPauseBox)
        Me.Controls.Add(Me.picPauseBoxOutline)
        Me.Controls.Add(Me.lblMovement)
        Me.Controls.Add(Me.picDeckTransition02)
        Me.Controls.Add(Me.picDeckTransition01)
        Me.Controls.Add(Me.picDeckTransition00)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblTimeColon)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblLifeScore)
        Me.Controls.Add(Me.lblBulletScore)
        Me.Controls.Add(Me.lblScoreValue)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblBullets)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picDeckMain03)
        Me.Controls.Add(Me.picDeckMain02)
        Me.Controls.Add(Me.picDeckMain01)
        Me.Controls.Add(Me.picDeckMain00)
        Me.Controls.Add(Me.picDeckHighlight03)
        Me.Controls.Add(Me.picDeckHighlight02)
        Me.Controls.Add(Me.picDeckLower03)
        Me.Controls.Add(Me.picDeckHighlight00)
        Me.Controls.Add(Me.picDeckLower02)
        Me.Controls.Add(Me.picDeckHighlight01)
        Me.Controls.Add(Me.picDeckLower01)
        Me.Controls.Add(Me.picDeckLower00)
        Me.Controls.Add(Me.picBoard)
        Me.Controls.Add(Me.picBoardHighlight)
        Me.Controls.Add(Me.picBoardLower)
        Me.Controls.Add(Me.picEnemy09Bullet00)
        Me.Controls.Add(Me.picEnemy08Bullet00)
        Me.Controls.Add(Me.picEnemy07Bullet00)
        Me.Controls.Add(Me.picEnemy06Bullet00)
        Me.Controls.Add(Me.picEnemy05Bullet00)
        Me.Controls.Add(Me.picEnemy04Bullet00)
        Me.Controls.Add(Me.picEnemy03Bullet00)
        Me.Controls.Add(Me.picEnemy02Bullet00)
        Me.Controls.Add(Me.picEnemy01Bullet00)
        Me.Controls.Add(Me.picEnemy00Bullet00)
        Me.Controls.Add(Me.picRockHeight05)
        Me.Controls.Add(Me.picRockHeight04)
        Me.Controls.Add(Me.picRockHeight03)
        Me.Controls.Add(Me.picRockHeight02)
        Me.Controls.Add(Me.picRockHeight01)
        Me.Controls.Add(Me.picRockHeight00)
        Me.Controls.Add(Me.picEnemy09)
        Me.Controls.Add(Me.picEnemy08)
        Me.Controls.Add(Me.picEnemy04)
        Me.Controls.Add(Me.picEnemy07)
        Me.Controls.Add(Me.picEnemy03)
        Me.Controls.Add(Me.picEnemy06)
        Me.Controls.Add(Me.picEnemy02)
        Me.Controls.Add(Me.picEnemy05)
        Me.Controls.Add(Me.picEnemy01)
        Me.Controls.Add(Me.picEnemy00)
        Me.Controls.Add(Me.picBoss)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picPlayerBullet05)
        Me.Controls.Add(Me.picPlayerBullet04)
        Me.Controls.Add(Me.picPlayerBullet03)
        Me.Controls.Add(Me.picPlayerBullet02)
        Me.Controls.Add(Me.picPlayerBullet01)
        Me.Controls.Add(Me.picBackgroundGrass03)
        Me.Controls.Add(Me.picBackgroundGrass05)
        Me.Controls.Add(Me.picBackgroundGrass04)
        Me.Controls.Add(Me.picBackgroundGrass00)
        Me.Controls.Add(Me.picBackgroundGrass01)
        Me.Controls.Add(Me.picBackgroundGrass02)
        Me.Controls.Add(Me.picBarrier)
        Me.Controls.Add(Me.picBackgroundMountain00)
        Me.Controls.Add(Me.picBackgroundMountain05)
        Me.Controls.Add(Me.picBackgroundMountain04)
        Me.Controls.Add(Me.picBackgroundMountain03)
        Me.Controls.Add(Me.picBackgroundMountain02)
        Me.Controls.Add(Me.picBackgroundMountain01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMovement
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovement"
        Me.ShowIcon = False
        Me.Text = "Movement"
        CType(Me.picDeckTransition02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckTransition01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckTransition00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckMain03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckMain02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckMain01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckMain00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckHighlight03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckHighlight02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckLower03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckHighlight00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckLower02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckHighlight01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckLower01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeckLower00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoardHighlight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoardLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy09Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy08Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy07Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy06Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy05Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy04Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy03Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy02Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy01Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy00Bullet00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockHeight05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockHeight04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockHeight03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockHeight02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockHeight01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockHeight00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerBullet05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerBullet04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerBullet03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerBullet02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerBullet01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundGrass03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundGrass05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundGrass04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundGrass00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundGrass01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundGrass02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarrier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundMountain00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundMountain05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundMountain04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundMountain03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundMountain02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundMountain01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMovement.ResumeLayout(False)
        Me.mnuMovement.PerformLayout()
        CType(Me.picPauseBoxOutline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPauseBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents tmrMain As Timer
    Friend WithEvents tmrBullet As Timer
    Friend WithEvents picPlayerBullet01 As PictureBox
    Friend WithEvents picPlayerBullet02 As PictureBox
    Friend WithEvents picPlayerBullet03 As PictureBox
    Friend WithEvents picPlayerBullet04 As PictureBox
    Friend WithEvents picPlayerBullet05 As PictureBox
    Friend WithEvents tmrW As Timer
    Friend WithEvents tmrA As Timer
    Friend WithEvents tmrS As Timer
    Friend WithEvents tmrD As Timer
    Friend WithEvents tmrCoolDown As Timer
    Friend WithEvents picEnemy00 As PictureBox
    Friend WithEvents picEnemy01 As PictureBox
    Friend WithEvents picEnemy02 As PictureBox
    Friend WithEvents picEnemy03 As PictureBox
    Friend WithEvents picEnemy04 As PictureBox
    Friend WithEvents tmrEnemy As Timer
    Friend WithEvents picEnemy05 As PictureBox
    Friend WithEvents picEnemy06 As PictureBox
    Friend WithEvents picEnemy07 As PictureBox
    Friend WithEvents picEnemy08 As PictureBox
    Friend WithEvents picEnemy09 As PictureBox
    Friend WithEvents picEnemy00Bullet00 As PictureBox
    Friend WithEvents picEnemy01Bullet00 As PictureBox
    Friend WithEvents picEnemy02Bullet00 As PictureBox
    Friend WithEvents picEnemy03Bullet00 As PictureBox
    Friend WithEvents picEnemy04Bullet00 As PictureBox
    Friend WithEvents picEnemy05Bullet00 As PictureBox
    Friend WithEvents picEnemy06Bullet00 As PictureBox
    Friend WithEvents picEnemy07Bullet00 As PictureBox
    Friend WithEvents picEnemy08Bullet00 As PictureBox
    Friend WithEvents picEnemy09Bullet00 As PictureBox
    Friend WithEvents tmrEnemyBullet As Timer
    Friend WithEvents tmrEnemyBulletMovement As Timer
    Friend WithEvents tmrLevel As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents lblScoreValue As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents tmrSeconds As Timer
    Friend WithEvents lblTimeColon As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents tmrMinutes As Timer
    Friend WithEvents tmrLastSeconds As Timer
    Friend WithEvents tmrEnemyMovement As Timer
    Friend WithEvents picBoardLower As PictureBox
    Friend WithEvents picDeckHighlight00 As PictureBox
    Friend WithEvents picDeckHighlight01 As PictureBox
    Friend WithEvents picBoard As PictureBox
    Friend WithEvents picDeckMain00 As PictureBox
    Friend WithEvents picDeckMain01 As PictureBox
    Friend WithEvents picDeckLower00 As PictureBox
    Friend WithEvents picDeckLower01 As PictureBox
    Friend WithEvents picDeckLower02 As PictureBox
    Friend WithEvents picDeckHighlight02 As PictureBox
    Friend WithEvents picDeckMain02 As PictureBox
    Friend WithEvents picDeckLower03 As PictureBox
    Friend WithEvents picDeckHighlight03 As PictureBox
    Friend WithEvents picDeckMain03 As PictureBox
    Friend WithEvents picBoardHighlight As PictureBox
    Friend WithEvents lblBullets As Label
    Friend WithEvents lblBulletScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblLifeScore As Label
    Friend WithEvents tmrLifeCheck As Timer
    Friend WithEvents tmrMusicTransition As Timer
    Friend WithEvents tmrMusicSecondTransition As Timer
    Friend WithEvents tmrInvincibilityOnState As Timer
    Friend WithEvents tmrInvincibilityOffState As Timer
    Friend WithEvents tmrInvincibilityDuration As Timer
    Friend WithEvents picBarrier As PictureBox
    Friend WithEvents tmrBossTransition As Timer
    Friend WithEvents picBoss As PictureBox
    Friend WithEvents tmrBossTransition2 As Timer
    Friend WithEvents tmrBossTransition3 As Timer
    Friend WithEvents tmrBossTransitionLeft As Timer
    Friend WithEvents tmrBossTransitionRight As Timer
    Friend WithEvents picDeckTransition00 As PictureBox
    Friend WithEvents picDeckTransition01 As PictureBox
    Friend WithEvents picDeckTransition02 As PictureBox
    Friend WithEvents tmrBossTransition4 As Timer
    Friend WithEvents tmrBossTransitionDown As Timer
    Friend WithEvents tmrBossTransition5 As Timer
    Friend WithEvents tmrBossTransitionUp As Timer
    Friend WithEvents tmrBossTransition6 As Timer
    Friend WithEvents tmrBossTransitionDuration As Timer
    Friend WithEvents tmrBossDecision As Timer
    Friend WithEvents picRockHeight00 As PictureBox
    Friend WithEvents picRockHeight01 As PictureBox
    Friend WithEvents picRockHeight02 As PictureBox
    Friend WithEvents picRockHeight03 As PictureBox
    Friend WithEvents picRockHeight04 As PictureBox
    Friend WithEvents picRockHeight05 As PictureBox
    Friend WithEvents tmrRockFall As Timer
    Friend WithEvents tmrRockFallPeriod As Timer
    Friend WithEvents tmrRockFalling As Timer
    Friend WithEvents tmrBossCheck As Timer
    Friend WithEvents tmrBossEndLeft As Timer
    Friend WithEvents tmrBossEndRight As Timer
    Friend WithEvents tmrBossEndDuration As Timer
    Friend WithEvents tmrBossEndLeave As Timer
    Friend WithEvents tmrBossLeaving As Timer
    Friend WithEvents picBackgroundGrass02 As PictureBox
    Friend WithEvents picBackgroundGrass04 As PictureBox
    Friend WithEvents picBackgroundGrass03 As PictureBox
    Friend WithEvents tmrBackgroundMovement As Timer
    Friend WithEvents picBackgroundGrass05 As PictureBox
    Friend WithEvents picBackgroundGrass01 As PictureBox
    Friend WithEvents picBackgroundGrass00 As PictureBox
    Friend WithEvents picBackgroundMountain01 As PictureBox
    Friend WithEvents picBackgroundMountain00 As PictureBox
    Friend WithEvents picBackgroundMountain02 As PictureBox
    Friend WithEvents picBackgroundMountain03 As PictureBox
    Friend WithEvents picBackgroundMountain04 As PictureBox
    Friend WithEvents picBackgroundMountain05 As PictureBox
    Friend WithEvents tmrBackgroundTransition00 As Timer
    Friend WithEvents tmrBackgroundTransition01 As Timer
    Friend WithEvents mnuMovement As MenuStrip
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuRestart As ToolStripMenuItem
    Friend WithEvents mnuHowToPlay As ToolStripMenuItem
    Friend WithEvents lblMovement As Label
    Friend WithEvents mnuStart As ToolStripMenuItem
    Friend WithEvents lblPaused As Label
    Friend WithEvents picPauseBoxOutline As PictureBox
    Friend WithEvents picPauseBox As PictureBox
End Class
