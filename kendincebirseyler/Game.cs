using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendincebirseyler
{
    public partial class Game : Form
    {
        int saniye = 0;
        int dakika = 0;
        int score = 0 ;
        int kontrolskor = -10;
        public Game()
        {
            InitializeComponent();
            pic1.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic2.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic3.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic4.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic5.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic6.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic7.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic8.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic9.ImageLocation = "C:/Users/Sefa/source/repos/kendincebirseyler/kendincebirseyler/kenny.jpg";
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
            pic8.Visible = false;
            pic9.Visible = false;
            lblScore.Text = "score : " + score.ToString(); ;
            score = 0;
            lbldk.Text = dakika.ToString();
            lblsn.Text = saniye.ToString();
            dakika = Convert.ToInt32(txtdk.Text);
            saniye = Convert.ToInt32(txtsn.Text);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic6.Enabled = false;
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
        }
        int spawnTime = 750;
        public void isVisible()
        {
            /*
            pic1.Enabled = true;
            pic2.Enabled = true;
            pic3.Enabled = true;
            pic4.Enabled = true;
            pic5.Enabled = true;
            pic6.Enabled = true;
            pic7.Enabled = true;
            pic8.Enabled = true;
            pic9.Enabled = true;
            */
            
            Random rnd = new Random();
            int a = rnd.Next(0, 9);
            if (a == 0)
            {
                pic1.Enabled = true;
                pic1.Visible = true;
                
            }
            else if (a == 1)
            {
                pic2.Enabled = true;
                pic2.Visible = true;
               
            }
            else if (a == 2)
            {
                pic3.Enabled = true;
                pic3.Visible = true;
                
            }
            else if (a == 3)
            {
                pic4.Enabled = true;
                pic4.Visible = true;
                
            }
            else if (a == 4)
            {
                pic5.Enabled = true;
                pic5.Visible = true;
                
            }
            else if (a == 5)
            {
                pic6.Enabled = true;
                pic6.Visible = true;
                
            }
            else if (a == 6)
            {
                pic7.Enabled = true;
                pic7.Visible = true;
               

            }
            else if (a == 7)
            {
                pic8.Enabled = true;
                pic8.Visible = true;
                
            }
            else if (a == 8)
            {
                pic9.Enabled = true;
                pic9.Visible = true;
                
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dakika != 0 || saniye != 0)
            {
                timer1.Stop();
                timer2.Stop();
                btnPause.Enabled = true;
                btnStart.Enabled = false;
                timer1.Start();
                timer2.Start();
                txtdk.Enabled = false;
                txtsn.Enabled = false;
                txtSpawn.Enabled = false;
                btnStart.Visible = false;
                BtnRestart.Visible = false;
                txtsn.Visible = false;
                txtdk.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                lblspawn.Visible = false;
                txtSpawn.Visible = false;
                spawnTime = Convert.ToInt32(txtSpawn.Text);
            }
        }

        
        public void restartGame()
        {
            score = 0;
            saniye = 30;
            btnPause.Enabled = false;
            spawnTime = 755;
            lblScore.Text = "score : " + score.ToString(); ;
            txtdk.Text = "";
            txtsn.Text = "";
            lblspawn.Visible = true;
            txtSpawn.Visible = true;
            txtdk.Enabled = true;
            txtsn.Enabled = true;
            txtSpawn.Enabled = true;
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
            pic8.Visible = false;
            pic9.Visible = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;
            BtnRestart.Visible = true;
            txtsn.Visible = true;
            txtdk.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            lblspawn.Visible = true;
            txtSpawn.Visible = true;
            lbldk.Text = "00";
            lblsn.Text = "00";
            txtsn.Text = saniye.ToString();
            kontrolskor = -1;
        }
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            restartGame();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (dakika == 0&&saniye==0)
            {
                
                timer1.Stop();
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic7.Visible = false;
                pic8.Visible = false;
                pic9.Visible = false;
                MessageBox.Show("Time Over \n" + lblScore.Text+"\nYOU WİN!");
                btnStart.Visible = true;
                BtnRestart.Visible = true;
                txtsn.Visible = true;
                txtdk.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                lblspawn.Visible = true;
                txtSpawn.Visible = true;
            }
            else
            {
                if (saniye == 0)
                {
                    dakika -= 1;
                    saniye = 60;
                }
                saniye = saniye - 1;
                lblsn.Text = Convert.ToString(saniye);
                lbldk.Text = Convert.ToString(dakika);
            }
            

            
        }

        private void lblsn_Click(object sender, EventArgs e)
        {

        }

        private void lblsn_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = spawnTime;
            if (dakika == 0 && saniye == 0)
            {
                timer2.Stop();
                
            }
            if (spawnTime > 300)
            {
                spawnTime -= 5;
                lblCurr.Text = "Current Spawn Time : " + spawnTime.ToString();
            }
            if (kontrolskor-14> score*2)
            {
                // github deneme 
                timer2.Stop();
                timer1.Stop();
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic7.Visible = false;
                pic8.Visible = false;
                pic9.Visible = false;
                btnStart.Visible = true;
                BtnRestart.Visible = true;
                txtsn.Visible = true;
                txtdk.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                lblspawn.Visible = true;
                txtSpawn.Visible = true;
                MessageBox.Show("YOU DIED");
            }
            
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
            pic8.Visible = false;
            pic9.Visible = false;
            isVisible();

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic1.Enabled = false;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic2.Enabled = false;
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic3.Enabled = false;
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic4.Enabled = false;
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic5.Enabled = false;
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic7.Enabled = false;
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic8.Enabled = false;
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "score : " + score;
            pic9.Enabled = false;
        }

        private void txtdk_TextChanged(object sender, EventArgs e)
        {
            
            if (txtdk.Text != "")
            {
                if (Convert.ToInt32(txtdk.Text) < 0 || Convert.ToInt32(txtdk.Text) > 59)
                {
                    MessageBox.Show("Dakika giriniz!\n(0-60 aralığında)");
                    txtdk.Text = "0";
                }
                dakika = Convert.ToInt32(txtdk.Text);
                lbldk.Text = Convert.ToString(dakika);
            }
        }

        private void txtsn_TextChanged(object sender, EventArgs e)
        {
           
            if (txtsn.Text != "")
            {
                if (Convert.ToInt32(txtsn.Text) < 0 || Convert.ToInt32(txtsn.Text) > 59)
                {
                    MessageBox.Show("Saniye giriniz!\n(0-60 aralığında)");
                    txtsn.Text = "0";
                }
                saniye = Convert.ToInt32(txtsn.Text);
                lblsn.Text = Convert.ToString(saniye);
            }
        }

        private void txtdk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtsn_Leave(object sender, EventArgs e)
        {
                
        }

        private void txtSpawn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public static Boolean a = true;
        public void pause()
        {
           
            
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Yes for Unpause\nNo for Restart", "PAUSED", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                timer1.Start();
                timer2.Start();
            }
            if (result == DialogResult.No)
            {
                restartGame();
            }


        }

        private void pic4_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic1_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic2_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic3_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic5_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic6_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic7_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic9_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }

        private void pic8_VisibleChanged(object sender, EventArgs e)
        {
            kontrolskor++;
        }
    }
}
