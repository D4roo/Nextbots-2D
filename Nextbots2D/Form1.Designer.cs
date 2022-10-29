namespace Nextbots2D
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.cb2Player = new System.Windows.Forms.CheckBox();
            this.txtCustomBots = new System.Windows.Forms.TextBox();
            this.cbCustomBotCount = new System.Windows.Forms.CheckBox();
            this.cmdDarkMode = new System.Windows.Forms.Button();
            this.cmdLeaderboard = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.txtBotSpeed = new System.Windows.Forms.TextBox();
            this.txtPlayerSpeed = new System.Windows.Forms.TextBox();
            this.cbBotSpeed = new System.Windows.Forms.CheckBox();
            this.cbPlayerSpeed = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdEasy = new System.Windows.Forms.Button();
            this.cmdNormal = new System.Windows.Forms.Button();
            this.cmdHard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCubes = new System.Windows.Forms.CheckBox();
            this.cbNextbots = new System.Windows.Forms.CheckBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.labelBots = new System.Windows.Forms.Label();
            this.labelMines2 = new System.Windows.Forms.Label();
            this.timerExe = new System.Windows.Forms.Timer(this.components);
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelPos1 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.labelPos2 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMines = new System.Windows.Forms.Label();
            this.labelKills = new System.Windows.Forms.Label();
            this.sprintBar = new System.Windows.Forms.ProgressBar();
            this.labelSprint = new System.Windows.Forms.Label();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.cb2Player);
            this.gbControl.Controls.Add(this.txtCustomBots);
            this.gbControl.Controls.Add(this.cbCustomBotCount);
            this.gbControl.Controls.Add(this.cmdDarkMode);
            this.gbControl.Controls.Add(this.cmdLeaderboard);
            this.gbControl.Controls.Add(this.cmdReset);
            this.gbControl.Controls.Add(this.txtBotSpeed);
            this.gbControl.Controls.Add(this.txtPlayerSpeed);
            this.gbControl.Controls.Add(this.cbBotSpeed);
            this.gbControl.Controls.Add(this.cbPlayerSpeed);
            this.gbControl.Controls.Add(this.label8);
            this.gbControl.Controls.Add(this.cmdEasy);
            this.gbControl.Controls.Add(this.cmdNormal);
            this.gbControl.Controls.Add(this.cmdHard);
            this.gbControl.Controls.Add(this.label7);
            this.gbControl.Controls.Add(this.label6);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.cbCubes);
            this.gbControl.Controls.Add(this.cbNextbots);
            this.gbControl.Controls.Add(this.labelVersion);
            this.gbControl.Controls.Add(this.cmdExit);
            this.gbControl.Controls.Add(this.labelName);
            this.gbControl.Controls.Add(this.cmdPlay);
            this.gbControl.Location = new System.Drawing.Point(12, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(176, 462);
            this.gbControl.TabIndex = 7;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control Panel";
            // 
            // cb2Player
            // 
            this.cb2Player.AutoSize = true;
            this.cb2Player.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb2Player.ForeColor = System.Drawing.Color.White;
            this.cb2Player.Location = new System.Drawing.Point(97, 262);
            this.cb2Player.Name = "cb2Player";
            this.cb2Player.Size = new System.Drawing.Size(73, 21);
            this.cb2Player.TabIndex = 25;
            this.cb2Player.Text = "2 Player";
            this.cb2Player.UseVisualStyleBackColor = true;
            this.cb2Player.CheckedChanged += new System.EventHandler(this.cb2Player_CheckedChanged);
            // 
            // txtCustomBots
            // 
            this.txtCustomBots.BackColor = System.Drawing.Color.Silver;
            this.txtCustomBots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomBots.Enabled = false;
            this.txtCustomBots.Location = new System.Drawing.Point(115, 293);
            this.txtCustomBots.MaxLength = 10;
            this.txtCustomBots.Name = "txtCustomBots";
            this.txtCustomBots.Size = new System.Drawing.Size(55, 23);
            this.txtCustomBots.TabIndex = 24;
            this.txtCustomBots.Text = "Infinite";
            // 
            // cbCustomBotCount
            // 
            this.cbCustomBotCount.AutoSize = true;
            this.cbCustomBotCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCustomBotCount.ForeColor = System.Drawing.Color.White;
            this.cbCustomBotCount.Location = new System.Drawing.Point(6, 295);
            this.cbCustomBotCount.Name = "cbCustomBotCount";
            this.cbCustomBotCount.Size = new System.Drawing.Size(90, 21);
            this.cbCustomBotCount.TabIndex = 23;
            this.cbCustomBotCount.Text = "Bots Count";
            this.cbCustomBotCount.UseVisualStyleBackColor = true;
            this.cbCustomBotCount.CheckedChanged += new System.EventHandler(this.cbCustomBotCount_CheckedChanged);
            // 
            // cmdDarkMode
            // 
            this.cmdDarkMode.BackColor = System.Drawing.Color.Gray;
            this.cmdDarkMode.BackgroundImage = global::Nextbots2D.Properties.Resources.DarkMode;
            this.cmdDarkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDarkMode.Location = new System.Drawing.Point(125, 134);
            this.cmdDarkMode.Name = "cmdDarkMode";
            this.cmdDarkMode.Size = new System.Drawing.Size(44, 44);
            this.cmdDarkMode.TabIndex = 22;
            this.cmdDarkMode.UseVisualStyleBackColor = false;
            this.cmdDarkMode.Click += new System.EventHandler(this.cmdDarkMode_Click);
            // 
            // cmdLeaderboard
            // 
            this.cmdLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLeaderboard.Location = new System.Drawing.Point(69, 380);
            this.cmdLeaderboard.Name = "cmdLeaderboard";
            this.cmdLeaderboard.Size = new System.Drawing.Size(101, 35);
            this.cmdLeaderboard.TabIndex = 21;
            this.cmdLeaderboard.Text = "Leaderboard";
            this.cmdLeaderboard.UseVisualStyleBackColor = false;
            // 
            // cmdReset
            // 
            this.cmdReset.BackColor = System.Drawing.Color.Gray;
            this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReset.Location = new System.Drawing.Point(6, 380);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(57, 35);
            this.cmdReset.TabIndex = 20;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = false;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // txtBotSpeed
            // 
            this.txtBotSpeed.BackColor = System.Drawing.Color.Silver;
            this.txtBotSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBotSpeed.Enabled = false;
            this.txtBotSpeed.Location = new System.Drawing.Point(115, 347);
            this.txtBotSpeed.Name = "txtBotSpeed";
            this.txtBotSpeed.Size = new System.Drawing.Size(55, 23);
            this.txtBotSpeed.TabIndex = 19;
            this.txtBotSpeed.Text = "2";
            this.txtBotSpeed.TextChanged += new System.EventHandler(this.txtBotSpeed_TextChanged);
            // 
            // txtPlayerSpeed
            // 
            this.txtPlayerSpeed.BackColor = System.Drawing.Color.Silver;
            this.txtPlayerSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerSpeed.Enabled = false;
            this.txtPlayerSpeed.Location = new System.Drawing.Point(115, 320);
            this.txtPlayerSpeed.Name = "txtPlayerSpeed";
            this.txtPlayerSpeed.Size = new System.Drawing.Size(55, 23);
            this.txtPlayerSpeed.TabIndex = 18;
            this.txtPlayerSpeed.Text = "5";
            this.txtPlayerSpeed.TextChanged += new System.EventHandler(this.txtPlayerSpeed_TextChanged);
            // 
            // cbBotSpeed
            // 
            this.cbBotSpeed.AutoSize = true;
            this.cbBotSpeed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBotSpeed.ForeColor = System.Drawing.Color.White;
            this.cbBotSpeed.Location = new System.Drawing.Point(6, 349);
            this.cbBotSpeed.Name = "cbBotSpeed";
            this.cbBotSpeed.Size = new System.Drawing.Size(87, 21);
            this.cbBotSpeed.TabIndex = 17;
            this.cbBotSpeed.Text = "Bot Speed";
            this.cbBotSpeed.UseVisualStyleBackColor = true;
            this.cbBotSpeed.CheckedChanged += new System.EventHandler(this.cbBotSpeed_CheckedChanged);
            // 
            // cbPlayerSpeed
            // 
            this.cbPlayerSpeed.AutoSize = true;
            this.cbPlayerSpeed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPlayerSpeed.ForeColor = System.Drawing.Color.White;
            this.cbPlayerSpeed.Location = new System.Drawing.Point(6, 322);
            this.cbPlayerSpeed.Name = "cbPlayerSpeed";
            this.cbPlayerSpeed.Size = new System.Drawing.Size(103, 21);
            this.cbPlayerSpeed.TabIndex = 16;
            this.cbPlayerSpeed.Text = "Player Speed";
            this.cbPlayerSpeed.UseVisualStyleBackColor = true;
            this.cbPlayerSpeed.CheckedChanged += new System.EventHandler(this.cbPlayerSpeed_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Custom";
            // 
            // cmdEasy
            // 
            this.cmdEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEasy.Location = new System.Drawing.Point(125, 214);
            this.cmdEasy.Name = "cmdEasy";
            this.cmdEasy.Size = new System.Drawing.Size(47, 35);
            this.cmdEasy.TabIndex = 14;
            this.cmdEasy.Text = "Cake";
            this.cmdEasy.UseVisualStyleBackColor = false;
            // 
            // cmdNormal
            // 
            this.cmdNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNormal.Location = new System.Drawing.Point(64, 214);
            this.cmdNormal.Name = "cmdNormal";
            this.cmdNormal.Size = new System.Drawing.Size(58, 35);
            this.cmdNormal.TabIndex = 13;
            this.cmdNormal.Text = "Normal";
            this.cmdNormal.UseVisualStyleBackColor = false;
            // 
            // cmdHard
            // 
            this.cmdHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHard.Location = new System.Drawing.Point(4, 214);
            this.cmdHard.Name = "cmdHard";
            this.cmdHard.Size = new System.Drawing.Size(57, 35);
            this.cmdHard.TabIndex = 12;
            this.cmdHard.Text = "Gamer";
            this.cmdHard.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Difficulty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Visuals";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "__________________________";
            // 
            // cbCubes
            // 
            this.cbCubes.AutoSize = true;
            this.cbCubes.Checked = true;
            this.cbCubes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCubes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCubes.ForeColor = System.Drawing.Color.White;
            this.cbCubes.Location = new System.Drawing.Point(6, 157);
            this.cbCubes.Name = "cbCubes";
            this.cbCubes.Size = new System.Drawing.Size(63, 21);
            this.cbCubes.TabIndex = 8;
            this.cbCubes.Text = "Cubes";
            this.cbCubes.UseVisualStyleBackColor = true;
            this.cbCubes.CheckedChanged += new System.EventHandler(this.cbCubes_CheckedChanged);
            // 
            // cbNextbots
            // 
            this.cbNextbots.AutoSize = true;
            this.cbNextbots.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNextbots.ForeColor = System.Drawing.Color.White;
            this.cbNextbots.Location = new System.Drawing.Point(6, 132);
            this.cbNextbots.Name = "cbNextbots";
            this.cbNextbots.Size = new System.Drawing.Size(80, 21);
            this.cbNextbots.TabIndex = 7;
            this.cbNextbots.Text = "Nextbots";
            this.cbNextbots.UseVisualStyleBackColor = true;
            this.cbNextbots.CheckedChanged += new System.EventHandler(this.cbNextbots_CheckedChanged);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(69, 49);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(82, 17);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "Version 0.1.0";
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Silver;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Location = new System.Drawing.Point(6, 421);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(57, 35);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(6, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 30);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nextbots 2D";
            // 
            // cmdPlay
            // 
            this.cmdPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPlay.Location = new System.Drawing.Point(69, 421);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(101, 35);
            this.cmdPlay.TabIndex = 0;
            this.cmdPlay.Text = "Start";
            this.cmdPlay.UseVisualStyleBackColor = false;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // labelBots
            // 
            this.labelBots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBots.AutoSize = true;
            this.labelBots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelBots.Location = new System.Drawing.Point(3, 387);
            this.labelBots.Name = "labelBots";
            this.labelBots.Size = new System.Drawing.Size(42, 15);
            this.labelBots.TabIndex = 17;
            this.labelBots.Text = "Bots: 0";
            this.labelBots.Visible = false;
            // 
            // labelMines2
            // 
            this.labelMines2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMines2.AutoSize = true;
            this.labelMines2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelMines2.Location = new System.Drawing.Point(3, 407);
            this.labelMines2.Name = "labelMines2";
            this.labelMines2.Size = new System.Drawing.Size(57, 15);
            this.labelMines2.TabIndex = 17;
            this.labelMines2.Text = "Mines: 20";
            this.labelMines2.Visible = false;
            // 
            // timerExe
            // 
            this.timerExe.Interval = 1;
            this.timerExe.Tick += new System.EventHandler(this.timerExe_Tick);
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.picPlayer.Location = new System.Drawing.Point(206, 202);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(38, 38);
            this.picPlayer.TabIndex = 8;
            this.picPlayer.TabStop = false;
            // 
            // labelRes
            // 
            this.labelRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRes.AutoSize = true;
            this.labelRes.ForeColor = System.Drawing.Color.White;
            this.labelRes.Location = new System.Drawing.Point(3, 468);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(63, 15);
            this.labelRes.TabIndex = 9;
            this.labelRes.Text = "Resolution";
            this.labelRes.Visible = false;
            // 
            // labelPos1
            // 
            this.labelPos1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPos1.AutoSize = true;
            this.labelPos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelPos1.Location = new System.Drawing.Point(3, 427);
            this.labelPos1.Name = "labelPos1";
            this.labelPos1.Size = new System.Drawing.Size(32, 15);
            this.labelPos1.TabIndex = 10;
            this.labelPos1.Text = "Pos1";
            this.labelPos1.Visible = false;
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(727, 3);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(70, 21);
            this.labelTimer.TabIndex = 11;
            this.labelTimer.Text = "00:00:00";
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.picPlayer2.Enabled = false;
            this.picPlayer2.Location = new System.Drawing.Point(206, 246);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(38, 38);
            this.picPlayer2.TabIndex = 13;
            this.picPlayer2.TabStop = false;
            this.picPlayer2.Visible = false;
            // 
            // labelPos2
            // 
            this.labelPos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPos2.AutoSize = true;
            this.labelPos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPos2.Location = new System.Drawing.Point(3, 448);
            this.labelPos2.Name = "labelPos2";
            this.labelPos2.Size = new System.Drawing.Size(32, 15);
            this.labelPos2.TabIndex = 14;
            this.labelPos2.Text = "Pos2";
            this.labelPos2.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(370, 3);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(87, 25);
            this.labelScore.TabIndex = 15;
            this.labelScore.Text = "SCORE: 0";
            // 
            // labelMines
            // 
            this.labelMines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMines.AutoSize = true;
            this.labelMines.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelMines.Location = new System.Drawing.Point(741, 24);
            this.labelMines.Name = "labelMines";
            this.labelMines.Size = new System.Drawing.Size(47, 37);
            this.labelMines.TabIndex = 16;
            this.labelMines.Text = "20";
            // 
            // labelKills
            // 
            this.labelKills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKills.AutoSize = true;
            this.labelKills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelKills.Location = new System.Drawing.Point(3, 367);
            this.labelKills.Name = "labelKills";
            this.labelKills.Size = new System.Drawing.Size(40, 15);
            this.labelKills.TabIndex = 18;
            this.labelKills.Text = "Kills: 0";
            this.labelKills.Visible = false;
            // 
            // sprintBar
            // 
            this.sprintBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sprintBar.Location = new System.Drawing.Point(292, 470);
            this.sprintBar.Name = "sprintBar";
            this.sprintBar.Size = new System.Drawing.Size(258, 13);
            this.sprintBar.TabIndex = 19;
            // 
            // labelSprint
            // 
            this.labelSprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSprint.AutoSize = true;
            this.labelSprint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSprint.ForeColor = System.Drawing.Color.White;
            this.labelSprint.Location = new System.Drawing.Point(556, 463);
            this.labelSprint.Name = "labelSprint";
            this.labelSprint.Size = new System.Drawing.Size(29, 20);
            this.labelSprint.TabIndex = 20;
            this.labelSprint.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.labelSprint);
            this.Controls.Add(this.sprintBar);
            this.Controls.Add(this.labelKills);
            this.Controls.Add(this.labelBots);
            this.Controls.Add(this.labelMines);
            this.Controls.Add(this.labelMines2);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelPos2);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelPos1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.gbControl);
            this.MinimumSize = new System.Drawing.Size(816, 525);
            this.Name = "Form1";
            this.Text = "Nextbots 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbControl;
        private Button cmdLeaderboard;
        private Button cmdReset;
        private TextBox txtBotSpeed;
        private TextBox txtPlayerSpeed;
        private CheckBox cbBotSpeed;
        private CheckBox cbPlayerSpeed;
        private Label label8;
        private Button cmdEasy;
        private Button cmdNormal;
        private Button cmdHard;
        private Label label7;
        private Label label6;
        private Label label5;
        private CheckBox cbCubes;
        private CheckBox cbNextbots;
        private Label labelVersion;
        private Button cmdExit;
        private Label labelName;
        private Button cmdPlay;
        private System.Windows.Forms.Timer timerExe;
        private PictureBox picPlayer;
        private Label labelRes;
        private Label labelPos1;
        private Label labelTimer;
        private Button cmdDarkMode;
        private CheckBox cbCustomBotCount;
        private CheckBox cb2Player;
        private TextBox txtCustomBots;
        private PictureBox picPlayer2;
        private Label labelPos2;
        private Label labelScore;
        private Label labelMines;
        private Label labelBots;
        private Label labelMines2;
        private Label labelKills;
        private ProgressBar sprintBar;
        private Label labelSprint;
    }
}