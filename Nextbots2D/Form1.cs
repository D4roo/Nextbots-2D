using System.Timers;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Nextbots2D
{
    public partial class Form1 : Form
    {
        public bool GoRight = false;
        public bool GoLeft = false;
        public bool GoUp = false;
        public bool GoDown = false;
        public bool GoRight2 = false;
        public bool GoLeft2 = false;
        public bool GoUp2 = false;
        public bool GoDown2 = false;
        public bool GoSprint = false;
        public bool SprintLock = false;
        public int speed = 5;
        public int sprintSpeed;
        public int originalSpeed;
        public int botSpeed = 2;
        public int m, s, ms, ms2, spawnIntervalMs;
        public int botCount = 0;
        public int mines = 20;
        public int score = 0;
        public int kills = 0;
        public string difficulty = "Normal";
        System.Timers.Timer t = new System.Timers.Timer();// t;
        List<PictureBox> items = new List<PictureBox>();
        List<PictureBox> items2 = new List<PictureBox>();
        List<PictureBox> itemsTotal = new List<PictureBox>();
        List<PictureBox> itemsMine = new List<PictureBox>();
        List<PictureBox> itemsRessuply = new List<PictureBox>();
        Image Munci = Image.FromFile(@"..\..\..\Resources\Munci1.png");
        Image Obunga = Image.FromFile(@"..\..\..\Resources\Obunga.png");
        Image Pinhead = Image.FromFile(@"..\..\..\Resources\Pinhead.png");
        Image Alternate = Image.FromFile(@"..\..\..\Resources\Alternate.png");
        Image PVZmine = Image.FromFile(@"..\..\..\Resources\PVZ.png");

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            picPlayer2.Location = new Point(-100, 0);
            this.KeyPreview = true;
            t = new System.Timers.Timer();
            t.Interval = 1;
            t.Elapsed += OnTimeEvent;
        }
        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    ms += 1;
                    ms2 += 1;
                    if (GoSprint && sprintBar.Value > 0) { sprintBar.Value -= 1; } else if (sprintBar.Value < 100) { sprintBar.Value += 1; }
                    if (ms == 65)
                    {
                        ms = 0;
                        s += 1;
                        if (SprintLock == true) SprintLock = false;
                    }
                    if (s == 60)
                    {
                        s = 0;
                        m += 1;
                    }
                    if (ms2 == 650) { ms2 = 0; spawnSupply(); }
                    labelTimer.Text = string.Format("{0}:{1}:{2}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'), ms.ToString().PadLeft(2, '0'));
                    if (cbCustomBotCount.Checked) //Spawn Custom Bots
                    {
                        if (botCount.ToString() == txtCustomBots.Text) return;
                        spawnIntervalMs += 1;
                        if(spawnIntervalMs == 50)
                        {
                            spawnBot();
                            spawnIntervalMs = 0;
                        }
                    } 
                    else
                    {
                        //Spawn Bots
                        spawnIntervalMs += 1;
                        if (spawnIntervalMs == 50) //About Every half a second
                        {
                            spawnBot();
                            spawnIntervalMs = 0;
                        }
                    }
                }));
            } catch { };
        }
        private void cmdPlay_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (txtPlayerSpeed.BackColor == Color.FromArgb(255, 128, 128)) return;
            if (txtBotSpeed.BackColor == Color.FromArgb(255, 128, 128)) return;
            foreach (PictureBox bot in items.ToList()) { items.Remove(bot); this.Controls.Remove(bot); }
            foreach (PictureBox bot in items2.ToList()) { items2.Remove(bot); this.Controls.Remove(bot); }
            foreach (PictureBox bot in itemsTotal.ToList()) { itemsTotal.Remove(bot); this.Controls.Remove(bot); }
            foreach (PictureBox mine in itemsMine.ToList()) { itemsMine.Remove(mine); this.Controls.Remove(mine); }
            foreach (PictureBox resupply in itemsRessuply.ToList()) { itemsRessuply.Remove(resupply); this.Controls.Remove(resupply); }
            m = 0; s = 0; ms = 0; ms2 = 0; spawnIntervalMs = 0; botCount = 0; mines = 20;
            picPlayer.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
            if (picPlayer2.Visible == true) { picPlayer.Location = new Point(this.Size.Width / 2 - 200, this.Size.Height / 2); picPlayer2.Location = new Point(this.Size.Width / 2 + 200, this.Size.Height / 2); }
            if (cbNextbots.Checked == true && picPlayer2.Visible == true && txtCustomBots.Text == "0")
            {
                int rand = random.Next(0, 4);
                int rand2 = random.Next(0, 2);
                if (rand2 == 0)
                {
                    picPlayer.BackColor = Color.Transparent;
                    picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (rand == 0) picPlayer.Image = Munci;
                    if (rand == 1) picPlayer.Image = Obunga;
                    if (rand == 2) picPlayer.Image = Pinhead;
                    if (rand == 3) picPlayer.Image = Alternate;
                }
                else
                {
                    picPlayer2.BackColor = Color.Transparent;
                    picPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (rand == 0) picPlayer2.Image = Munci;
                    if (rand == 1) picPlayer2.Image = Obunga;
                    if (rand == 2) picPlayer2.Image = Pinhead;
                    if (rand == 3) picPlayer2.Image = Alternate;
                }
            }
            speed = int.Parse(txtPlayerSpeed.Text);
            botSpeed = int.Parse(txtBotSpeed.Text);
            gbControl.Visible = false;
            labelPos1.Visible = true;
            labelPos2.Visible = true;
            labelRes.Visible = true;
            labelMines2.Visible = true;
            labelBots.Visible = true;
            labelKills.Visible = true;
            labelMines.Text = "20";
            labelMines2.Text = "Mines: 20";
            labelBots.Text = "Bots: 0";
            labelKills.Text = "Kills: 0";
            labelScore.Text = "SCORE: 0";
            score = 0;
            kills = 0;
            sprintBar.Value = 100;
            sprintSpeed = speed + 5;
            originalSpeed = speed;
            txtName.Text = "";
            cmdSaveScore.Enabled = true; cmdSaveScore.Text = "Save To Leaderboard"; cmdSaveScore.BackColor = Color.FromArgb(192, 255, 192);
            if (cbPlayerSpeed.Checked || cbBotSpeed.Checked || cbCustomBotCount.Checked) { cmdSaveScore.Enabled = false; cmdSaveScore.Text = "Cannot Save Custom Game"; cmdSaveScore.BackColor = Color.FromArgb(255, 128, 128); }
            timerExe.Enabled = true; //Starts Game Movements
            t.Start(); //Starts Game Timer + Events
        }
        private void cbCustomBotCount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustomBotCount.Checked == true) 
            {
                txtCustomBots.Enabled = true;
                txtCustomBots.Text = "1";
            } else
            {
                txtCustomBots.Enabled = false;
                txtCustomBots.Text = "Infinite";
            }
        }
        private void cbPlayerSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayerSpeed.Checked == true)
            {
                txtPlayerSpeed.Enabled = true;
            } else
            {
                txtPlayerSpeed.Enabled = false;
                txtPlayerSpeed.Text = "5";
            }
        }
        private void cbBotSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBotSpeed.Checked == true)
            {
                txtBotSpeed.Enabled = true;
            } else
            {
                txtBotSpeed.Enabled = false;
                txtBotSpeed.Text = "2";
            }
        }
        private void cb2Player_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2Player.Checked == true)
            {
                picPlayer2.Enabled = true;
                picPlayer2.Visible = true;
            }
            else
            {
                picPlayer2.Enabled = false;
                picPlayer2.Visible = false;
                picPlayer2.Location = new Point(-100, 0);
            }
        }
        private void cbNextbots_CheckedChanged(object sender, EventArgs e)
        {
            if(cbNextbots.Checked == true) cbCubes.Checked = false;
        }
        private void cbCubes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCubes.Checked == true) cbNextbots.Checked = false;
        }
        private void cmdReset_Click(object sender, EventArgs e)
        {
            txtPlayerSpeed.Text = "5";
            txtBotSpeed.Text = "2";
            txtCustomBots.Text = "Infinite";
            cbPlayerSpeed.Checked = false;
            cbBotSpeed.Checked = false;
            cbCustomBotCount.Checked = false;
            cb2Player.Checked = false;
        }
        private void cmdDarkMode_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.FromArgb(64, 64, 64))
            {   //Light Mode
                this.BackColor = Color.FromName("Control");
                labelName.ForeColor = Color.Black;
                labelVersion.ForeColor = Color.Black;
                labelRes.ForeColor = Color.Black;
                labelTimer.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                labelScore.ForeColor = Color.Black;
                labelMines.ForeColor = Color.FromArgb(128, 64, 0);
                labelMines2.ForeColor = Color.FromArgb(128, 64, 0);
                labelBots.ForeColor = Color.Red;
                labelPos1.ForeColor = Color.FromArgb(128, 128, 255);
                labelPos2.ForeColor = Color.FromArgb(128, 255, 128);
                labelSprint.ForeColor = Color.Black;
                cbNextbots.ForeColor = Color.Black;
                cbCubes.ForeColor = Color.Black;
                cbCustomBotCount.ForeColor = Color.Black;
                cbPlayerSpeed.ForeColor = Color.Black;
                cbBotSpeed.ForeColor = Color.Black;
                cb2Player.ForeColor = Color.Black;
            }
            else
            {   //Dark Mode
                this.BackColor = Color.FromArgb(64, 64, 64);
                labelName.ForeColor = Color.White;
                labelVersion.ForeColor = Color.White;
                labelRes.ForeColor = Color.White;
                labelTimer.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                labelScore.ForeColor = Color.White;
                labelMines.ForeColor = Color.FromArgb(255, 255, 192);
                labelMines2.ForeColor = Color.FromArgb(255, 255, 192);
                labelBots.ForeColor = Color.FromArgb(255, 192, 192);
                labelPos1.ForeColor = Color.FromArgb(192, 192, 255);
                labelPos2.ForeColor = Color.FromArgb(192, 255, 192);
                labelSprint.ForeColor = Color.White;
                cbNextbots.ForeColor = Color.White;
                cbCubes.ForeColor = Color.White;
                cbCustomBotCount.ForeColor = Color.White;
                cbPlayerSpeed.ForeColor = Color.White;
                cbBotSpeed.ForeColor = Color.White;
                cb2Player.ForeColor = Color.White;
            }
        }
        //Difficulty Levels
        private void cmdHard_Click(object sender, EventArgs e) //Hard
        {
            txtPlayerSpeed.Text = "8";
            txtBotSpeed.Text = "5";
            difficulty = "Gamer";
        }
        private void cmdNormal_Click(object sender, EventArgs e)
        {
            txtPlayerSpeed.Text = "5";
            txtBotSpeed.Text = "2";
            difficulty = "Normal";
        }
        private void cmdEasy_Click(object sender, EventArgs e)
        {
            txtPlayerSpeed.Text = "2";
            txtBotSpeed.Text = "1";
            difficulty = "Cake";
        }
        private void cmdCancelScore_Click(object sender, EventArgs e)
        {
            gbStats.Visible = false;
            gbControl.Visible = true;
        }
        private void cmdSaveScore_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") { txtName.BackColor = Color.FromArgb(255, 128, 128); return; }
            cmdSaveScore.Enabled = false;

            //Save score to leaderboard using MongoDB
            MongoClient dbClient = new MongoClient("mongodb+srv://dara:wIfXFsNb9lHg7O9F@shaydacluster.svpy6.mongodb.net/ShaydaCluster?retryWrites=true&w=majority");

            var database = dbClient.GetDatabase("Nextbots2DCluster");
            var collection = database.GetCollection<BsonDocument>("Leaderboard");
            var document = new BsonDocument {
            { "Name", txtName.Text },
            { "Score", score },
            { "Kills", kills },
            { "Time", labelTimer.Text },
            { "Difficulty", difficulty },
            };
            collection.InsertOne(document);
            gbStats.Visible = false;
            gbControl.Visible = true;
        }
        private void cmdLeaderboard_Click(object sender, EventArgs e)
        {
            //View Leaderboard
            if (lbLeaderboard.Visible == false) { lbLeaderboard.Visible = true; } else { lbLeaderboard.Visible = false; }
            MongoClient dbClient = new MongoClient("mongodb+srv://dara:wIfXFsNb9lHg7O9F@shaydacluster.svpy6.mongodb.net/ShaydaCluster?retryWrites=true&w=majority");

            var database = dbClient.GetDatabase("Nextbots2DCluster");
            var collection = database.GetCollection<BsonDocument>("Leaderboard");
            var documents = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument doc in documents)
            {
                Console.WriteLine(doc.ToString());
            }

        }
        private void txtPlayerSpeed_TextChanged(object sender, EventArgs e)
        {
            if (!txtPlayerSpeed.Text.All(char.IsDigit) || txtPlayerSpeed.Text == "")
            {
                txtPlayerSpeed.BackColor = Color.FromArgb(255, 128, 128);
            }
            else txtPlayerSpeed.BackColor = Color.Silver;
        }
        private void txtBotSpeed_TextChanged(object sender, EventArgs e)
        {
            if (!txtBotSpeed.Text.All(char.IsDigit) || txtBotSpeed.Text == "")
            {
                txtBotSpeed.BackColor = Color.FromArgb(255, 128, 128);
            }
            else txtBotSpeed.BackColor = Color.Silver;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.BackColor == Color.FromArgb(255, 128, 128)) txtName.BackColor = Color.FromName("Control");
            int charLimit = txtName.TextLength;
            labelTxtIndacator.Text = (charLimit).ToString() + "/" + (30).ToString();
            if (charLimit == 30) { labelTxtIndacator.ForeColor = Color.Red; } else if (charLimit < 30) { labelTxtIndacator.ForeColor = Color.Cyan; }
        }
        private void Form_MouseDown(object? sender, MouseEventArgs e)
        {
            if (timerExe.Enabled == true && e.Button == MouseButtons.Left)
            {
                if (mines <= 0) return;
                mines -= 1;
                labelMines.Text = mines.ToString();
                int mouseX = e.Location.X;
                int mouseY = e.Location.Y;
                //Create bullet below
                PictureBox p = new PictureBox();
                p.Size = new Size(10, 10);
                p.BackColor = Color.FromArgb(255, 255, 192);
                if (this.BackColor == Color.FromName("Control")) p.BackColor = Color.Black;
                p.Location = new Point(mouseX, mouseY);
                this.Controls.Add(p);
                itemsMine.Add(p);
                labelMines2.Text = "Mines: " + mines.ToString(); //s
            }
        }
        public void spawnSupply()
        {
            //Spawn Resupply Crate
            Random random = new Random();
            PictureBox p = new PictureBox();
            p.Size = new Size(45, 45);
            p.BackColor = Color.Transparent; //Color.FromArgb(128, 64, 0);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Image = PVZmine;
            int x = random.Next(0, this.Size.Width);
            int y = random.Next(0, this.Size.Height);
            p.Location = new Point(x, y);
            this.Controls.Add(p);
            itemsRessuply.Add(p);
        }
        public void spawnBot()
        {
            //Spawn Enemy Bots
            Random random = new Random();
            PictureBox p = new PictureBox();
            p.Size = new Size(picPlayer.Size.Width, picPlayer.Size.Height);
            p.BackColor = Color.FromArgb(255, 128, 128);
            if(cbNextbots.Checked == true)
            {
                p.BackColor = Color.Transparent;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                int nextbotIndex = random.Next(0, 4);
                if (nextbotIndex == 0) p.Image = Munci;
                if (nextbotIndex == 1) p.Image = Obunga;
                if (nextbotIndex == 2) p.Image = Pinhead;
                if (nextbotIndex == 3) p.Image = Alternate;
            }
            int x = random.Next(0, this.Size.Width);
            int y = random.Next(0, this.Size.Height);
            p.Location = new Point(x, y);
            this.Controls.Add(p);
            int chaseWhichPlayer = random.Next(0, 2);
            if(picPlayer2.Visible == true)
            {
                if (chaseWhichPlayer == 0) items.Add(p);
                if (chaseWhichPlayer == 1) items2.Add(p);
            } else items.Add(p);
            itemsTotal.Add(p);
            labelBots.Text = "Bots: " + (botCount += 1).ToString();
        }
        //------------------------------------------------Player Movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) GoRight = true;
            if (e.KeyCode == Keys.A) GoLeft = true;
            if (e.KeyCode == Keys.W) GoUp = true;
            if (e.KeyCode == Keys.S) GoDown = true;
            if (e.KeyCode == Keys.L) GoRight2 = true;
            if (e.KeyCode == Keys.J) GoLeft2 = true;
            if (e.KeyCode == Keys.I) GoUp2 = true;
            if (e.KeyCode == Keys.K) GoDown2 = true;
            if (e.KeyCode == Keys.ShiftKey) GoSprint = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) GoRight = false;
            if (e.KeyCode == Keys.A) GoLeft = false;
            if (e.KeyCode == Keys.W) GoUp = false;
            if (e.KeyCode == Keys.S) GoDown = false;
            if (e.KeyCode == Keys.L) GoRight2 = false;
            if (e.KeyCode == Keys.J) GoLeft2 = false;
            if (e.KeyCode == Keys.I) GoUp2 = false;
            if (e.KeyCode == Keys.K) GoDown2 = false;
            if (e.KeyCode == Keys.ShiftKey) GoSprint = false;
        }
        //---------------------------------------------------------------
        private void timerExe_Tick(object sender, EventArgs e)
        {
            labelSprint.Text = sprintBar.Value.ToString() + "%";
            labelRes.Text = this.Size.ToString();
            labelPos1.Text = picPlayer.Location.ToString();
            labelPos2.Text = picPlayer2.Location.ToString();
            //Movement Controls + Border Restrictions
            if (sprintBar.Value == 0) SprintLock = true;
            if (GoSprint && sprintBar.Value > 0 && SprintLock == false) { speed = sprintSpeed; } else { speed = originalSpeed; }
            if (GoRight && picPlayer.Location.X < this.Size.Width - picPlayer.Size.Width * 1.45) picPlayer.Location = new Point(picPlayer.Location.X + speed, picPlayer.Location.Y);
            if (GoLeft && picPlayer.Location.X > 0) picPlayer.Location = new Point(picPlayer.Location.X - speed, picPlayer.Location.Y);
            if (GoUp && picPlayer.Location.Y > 0) picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y - speed);
            if (GoDown && picPlayer.Location.Y < this.Size.Height - picPlayer.Size.Height * 2) picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y + speed);
            if (picPlayer2.Visible == true)
            {
                if (GoRight2 && picPlayer2.Location.X < this.Size.Width - picPlayer2.Size.Width * 1.45) picPlayer2.Location = new Point(picPlayer2.Location.X + speed, picPlayer2.Location.Y);
                if (GoLeft2 && picPlayer2.Location.X > 0) picPlayer2.Location = new Point(picPlayer2.Location.X - speed, picPlayer2.Location.Y);
                if (GoUp2 && picPlayer2.Location.Y > 0) picPlayer2.Location = new Point(picPlayer2.Location.X, picPlayer2.Location.Y - speed);
                if (GoDown2 && picPlayer2.Location.Y < this.Size.Height - picPlayer2.Size.Height * 2) picPlayer2.Location = new Point(picPlayer2.Location.X, picPlayer2.Location.Y + speed);
            }
            //Bot AI Movement
            foreach (PictureBox bot in items.ToList())
            {
                if (bot.Location.X < picPlayer.Location.X) bot.Location = new Point(bot.Location.X + botSpeed, bot.Location.Y);
                if (bot.Location.X > picPlayer.Location.X) bot.Location = new Point(bot.Location.X - botSpeed, bot.Location.Y);
                if (bot.Location.Y > picPlayer.Location.Y) bot.Location = new Point(bot.Location.X, bot.Location.Y - botSpeed);
                if (bot.Location.Y < picPlayer.Location.Y) bot.Location = new Point(bot.Location.X, bot.Location.Y + botSpeed);
                
            }
            if (picPlayer2.Visible == true) //If second player
            {
                foreach (PictureBox bot in items2.ToList())
                {
                    if (bot.Location.X < picPlayer2.Location.X) bot.Location = new Point(bot.Location.X + botSpeed, bot.Location.Y);
                    if (bot.Location.X > picPlayer2.Location.X) bot.Location = new Point(bot.Location.X - botSpeed, bot.Location.Y);
                    if (bot.Location.Y > picPlayer2.Location.Y) bot.Location = new Point(bot.Location.X, bot.Location.Y - botSpeed);
                    if (bot.Location.Y < picPlayer2.Location.Y) bot.Location = new Point(bot.Location.X, bot.Location.Y + botSpeed);
                }
            }
            if(txtCustomBots.Text == "0" && picPlayer2.Visible == true && picPlayer.Bounds.IntersectsWith(picPlayer2.Bounds)) //1v1 Player
            {
                timerExe.Enabled = false;
                t.Stop();
                gbControl.Visible = true;
                labelPos1.Visible = false;
                labelPos2.Visible = false;
                labelRes.Visible = false;
                labelMines2.Visible = false;
                labelBots.Visible = false;
                labelKills.Visible = false;
                picPlayer.BackColor = Color.FromArgb(192, 192, 255);
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                picPlayer.Image = null;
                picPlayer2.BackColor = Color.FromArgb(128, 255, 128);
                picPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
                picPlayer2.Image = null;
                sprintBar.Value = 0;
            }
            foreach (PictureBox bot in itemsTotal.ToList()) //Mines
            {
                foreach (PictureBox mine in itemsMine.ToList())
                {
                    if (bot.Bounds.IntersectsWith(mine.Bounds))
                    {
                        items.Remove(bot);
                        items2.Remove(bot);
                        itemsTotal.Remove(bot);
                        itemsMine.Remove(mine);
                        this.Controls.Remove(bot);
                        this.Controls.Remove(mine);
                        labelBots.Text = "Bots: " + (botCount -= 1).ToString();
                        labelScore.Text = "SCORE: " + (score += 20).ToString();
                        labelKills.Text = "Kills: " + (kills += 1).ToString();
                    }
                }
            }
            foreach (PictureBox resupply in itemsRessuply.ToList()) //Resupply Mines
            {
                if (picPlayer.Bounds.IntersectsWith(resupply.Bounds) || picPlayer2.Bounds.IntersectsWith(resupply.Bounds))
                {
                    mines += 20;
                    labelMines.Text = mines.ToString();
                    labelMines2.Text = "Mines: " + mines.ToString();
                    itemsRessuply.Remove(resupply);
                    this.Controls.Remove(resupply);
                }
            }
            foreach (PictureBox bot in itemsTotal.ToList())
            {
                if (picPlayer.Bounds.IntersectsWith(bot.Bounds) || picPlayer2.Bounds.IntersectsWith(bot.Bounds))
                {
                    timerExe.Enabled = false; //GameOver
                    t.Stop();
                    labelPos1.Visible = false;
                    labelPos2.Visible = false;
                    labelRes.Visible = false;
                    labelMines2.Visible = false;
                    labelBots.Visible = false;
                    labelKills.Visible = false;
                    sprintBar.Value = 0;
                    labelStatScore.Text = "Score: " + score.ToString();
                    labelStatsKills.Text = "Kills: " + kills.ToString();
                    labelStatsTime.Text = "Time: " + labelTimer.Text;
                    labelStatsDifficulty.Text = difficulty;
                    if (difficulty == "Gamer") labelStatsDifficulty.ForeColor = Color.FromArgb(255, 128, 128);
                    if (difficulty == "Normal") labelStatsDifficulty.ForeColor = Color.FromArgb(255, 192, 128);
                    if (difficulty == "Cake") labelStatsDifficulty.ForeColor = Color.FromArgb(128, 255, 128);
                    gbStats.Visible = true;
                }
            }
        }
        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}