namespace kendincebirseyler
{
    partial class Game
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldk = new System.Windows.Forms.Label();
            this.lblsn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtdk = new System.Windows.Forms.TextBox();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblspawn = new System.Windows.Forms.Label();
            this.txtSpawn = new System.Windows.Forms.TextBox();
            this.randomtextlabeli = new System.Windows.Forms.Label();
            this.fhdsfsd = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblCurr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(274, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(400, 350);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.VisibleChanged += new System.EventHandler(this.pic1_VisibleChanged);
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BtnCikis.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCikis.Location = new System.Drawing.Point(1743, 215);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(100, 30);
            this.BtnCikis.TabIndex = 1;
            this.BtnCikis.Text = "Quit";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(680, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(400, 350);
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.VisibleChanged += new System.EventHandler(this.pic2_VisibleChanged);
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(1086, 12);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(400, 350);
            this.pic3.TabIndex = 3;
            this.pic3.TabStop = false;
            this.pic3.VisibleChanged += new System.EventHandler(this.pic3_VisibleChanged);
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(274, 365);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(400, 350);
            this.pic4.TabIndex = 4;
            this.pic4.TabStop = false;
            this.pic4.VisibleChanged += new System.EventHandler(this.pic4_VisibleChanged);
            this.pic4.Click += new System.EventHandler(this.pic4_Click);
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(680, 365);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(400, 350);
            this.pic5.TabIndex = 5;
            this.pic5.TabStop = false;
            this.pic5.VisibleChanged += new System.EventHandler(this.pic5_VisibleChanged);
            this.pic5.Click += new System.EventHandler(this.pic5_Click);
            // 
            // pic6
            // 
            this.pic6.Location = new System.Drawing.Point(1086, 365);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(400, 350);
            this.pic6.TabIndex = 6;
            this.pic6.TabStop = false;
            this.pic6.VisibleChanged += new System.EventHandler(this.pic6_VisibleChanged);
            this.pic6.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pic7
            // 
            this.pic7.Location = new System.Drawing.Point(274, 721);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(400, 350);
            this.pic7.TabIndex = 7;
            this.pic7.TabStop = false;
            this.pic7.VisibleChanged += new System.EventHandler(this.pic7_VisibleChanged);
            this.pic7.Click += new System.EventHandler(this.pic7_Click);
            // 
            // pic8
            // 
            this.pic8.Location = new System.Drawing.Point(1086, 721);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(400, 350);
            this.pic8.TabIndex = 8;
            this.pic8.TabStop = false;
            this.pic8.VisibleChanged += new System.EventHandler(this.pic8_VisibleChanged);
            this.pic8.Click += new System.EventHandler(this.pic8_Click);
            // 
            // pic9
            // 
            this.pic9.Location = new System.Drawing.Point(680, 721);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(400, 350);
            this.pic9.TabIndex = 9;
            this.pic9.TabStop = false;
            this.pic9.VisibleChanged += new System.EventHandler(this.pic9_VisibleChanged);
            this.pic9.Click += new System.EventHandler(this.pic9_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1753, 267);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 19);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score : 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1753, 606);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 19);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time";
            // 
            // BtnRestart
            // 
            this.BtnRestart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BtnRestart.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestart.Location = new System.Drawing.Point(1743, 461);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(112, 66);
            this.BtnRestart.TabIndex = 12;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnStart.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1743, 377);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 66);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldk
            // 
            this.lbldk.AutoSize = true;
            this.lbldk.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldk.Location = new System.Drawing.Point(1726, 696);
            this.lbldk.Name = "lbldk";
            this.lbldk.Size = new System.Drawing.Size(51, 19);
            this.lbldk.TabIndex = 14;
            this.lbldk.Text = "Time";
            // 
            // lblsn
            // 
            this.lblsn.AutoSize = true;
            this.lblsn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsn.Location = new System.Drawing.Point(1804, 696);
            this.lblsn.Name = "lblsn";
            this.lblsn.Size = new System.Drawing.Size(51, 19);
            this.lblsn.TabIndex = 15;
            this.lblsn.Text = "Time";
            this.lblsn.TextChanged += new System.EventHandler(this.lblsn_TextChanged);
            this.lblsn.Click += new System.EventHandler(this.lblsn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1783, 696);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtdk
            // 
            this.txtdk.Location = new System.Drawing.Point(1820, 102);
            this.txtdk.Name = "txtdk";
            this.txtdk.Size = new System.Drawing.Size(52, 20);
            this.txtdk.TabIndex = 17;
            this.txtdk.Text = "0";
            this.txtdk.TextChanged += new System.EventHandler(this.txtdk_TextChanged);
            this.txtdk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdk_KeyPress);
            // 
            // txtsn
            // 
            this.txtsn.Location = new System.Drawing.Point(1820, 138);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(52, 20);
            this.txtsn.TabIndex = 18;
            this.txtsn.Text = "30";
            this.txtsn.TextChanged += new System.EventHandler(this.txtsn_TextChanged);
            this.txtsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsn_KeyPress);
            this.txtsn.Leave += new System.EventHandler(this.txtsn_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1739, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1739, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sn";
            // 
            // lblspawn
            // 
            this.lblspawn.AutoSize = true;
            this.lblspawn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspawn.Location = new System.Drawing.Point(1726, 795);
            this.lblspawn.Name = "lblspawn";
            this.lblspawn.Size = new System.Drawing.Size(102, 19);
            this.lblspawn.TabIndex = 22;
            this.lblspawn.Text = "SpawnTime";
            // 
            // txtSpawn
            // 
            this.txtSpawn.Location = new System.Drawing.Point(1730, 826);
            this.txtSpawn.Name = "txtSpawn";
            this.txtSpawn.Size = new System.Drawing.Size(98, 20);
            this.txtSpawn.TabIndex = 21;
            this.txtSpawn.Text = "750";
            this.txtSpawn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpawn_KeyPress);
            // 
            // randomtextlabeli
            // 
            this.randomtextlabeli.AutoSize = true;
            this.randomtextlabeli.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomtextlabeli.Location = new System.Drawing.Point(25, 83);
            this.randomtextlabeli.Name = "randomtextlabeli";
            this.randomtextlabeli.Size = new System.Drawing.Size(210, 75);
            this.randomtextlabeli.TabIndex = 23;
            this.randomtextlabeli.Text = "Catch";
            // 
            // fhdsfsd
            // 
            this.fhdsfsd.AutoSize = true;
            this.fhdsfsd.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fhdsfsd.Location = new System.Drawing.Point(17, 158);
            this.fhdsfsd.Name = "fhdsfsd";
            this.fhdsfsd.Size = new System.Drawing.Size(218, 75);
            this.fhdsfsd.TabIndex = 24;
            this.fhdsfsd.Text = "KENNY";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPause.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(1743, 179);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 30);
            this.btnPause.TabIndex = 25;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblCurr
            // 
            this.lblCurr.AutoSize = true;
            this.lblCurr.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurr.Location = new System.Drawing.Point(1671, 884);
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(172, 19);
            this.lblCurr.TabIndex = 26;
            this.lblCurr.Text = "Current Spawn Time";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblCurr);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.fhdsfsd);
            this.Controls.Add(this.randomtextlabeli);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblspawn);
            this.Controls.Add(this.txtSpawn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsn);
            this.Controls.Add(this.txtdk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsn);
            this.Controls.Add(this.lbldk);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldk;
        private System.Windows.Forms.Label lblsn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtdk;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblspawn;
        private System.Windows.Forms.TextBox txtSpawn;
        private System.Windows.Forms.Label randomtextlabeli;
        private System.Windows.Forms.Label fhdsfsd;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblCurr;
    }
}

