using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace simplegame
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0;
        int z = 2, cunt = 0;

        GenreateFire obj = new GenreateFire();

        private void btnplay_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnFire.Enabled = true;
            btnload.Enabled = true;
            btnSpin.Enabled = true;
            pictureBox1.ImageLocation = @"C:\Users\vicky\source\repos\simplegame\media\176195-004-413CA8DB.jpg";
            pictureBox2.ImageLocation = @"C:\Users\vicky\source\repos\simplegame\media\download.jpg";
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            btnSpin.Enabled = true;
            btnload.Enabled = false;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\vicky\source\repos\simplegame\media\gun-cocking-01.wav");
            splayer.Play();
            x = x + 1;
            if (x == 1)
            {

                pictureBox1.ImageLocation = @"C:\Users\vicky\source\repos\simplegame\media\Russian_roulette_2500016b.jpg";
            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\vicky\source\repos\simplegame\media\Chambering A Round-SoundBible.com-854171848 (1).wav");
                splayer.Play();
                pictureBox2.ImageLocation = @"C:\Users\vicky\source\repos\simplegame\media\barrel.jpg";
            }
            else
            {
                MessageBox.Show("Please Click on Load Bullet First");
            }
            btnFire.Enabled = true;
            btnSpin.Enabled = false;

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int value()
        {
            Random rand = new Random();
            int random = rand.Next(1, 3);
            return random;

        }
        private void btnFire_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                y++;
              
                if (y == z && cunt < 2)
                {
                    pictureBox2.ImageLocation = @"C:\Users\vicky\source\repos\simplegame\media\download (1).jpg";
                    pictureBox1.ImageLocation = @"C:\Users\vicky\source\repos\simplegame\media\Revolver.gif";
                    cunt++;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\vicky\source\repos\simplegame\media\gun-gunshot-01.wav");
                    player.Play();
                    z = obj.fire();
                }
                if (cunt == 1)
                {
                   
                    MessageBox.Show("Game Over you won ");
                    btnFire.Enabled = false;
                }
                
           
                }
            }

        }
    }


        
   