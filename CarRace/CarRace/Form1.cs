using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int pictureBox1Hiz, pictureBox2Hiz, pictureBo3xHiz;
        public Form1()


        {
            InitializeComponent();
            timer1.Interval = 50;


        }


        // Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            BaslangicAyarlari();
            timer1.Start();
        }


        private void BaslangicAyarlari()
        {

            pictureBox1Hiz = rnd.Next(5, 15);
            pictureBox2Hiz = rnd.Next(5, 15);
            pictureBo3xHiz = rnd.Next(5, 15);
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            BaslangicAyarlari();
            timer1.Start();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            BaslangicAyarlari();
            pictureBox1.Left = 800;
            pictureBox2.Left = 800;
            pictureBox3.Left = 800;


        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= pictureBox1Hiz;
            pictureBox2.Left -= pictureBox2Hiz;
            pictureBox3.Left -= pictureBo3xHiz;


            if (pictureBox1.Left <= 30 ||
           pictureBox2.Left <= 30 ||
           pictureBox3.Left <= 30)
            {
                timer1.Stop(); // Yarışı durdur

                if (pictureBox1.Left <= 30)
                    MessageBox.Show("Winner is Konsol Oyun Gurulu Bakış"); // Kazananı belirlemek için ek kod ekleyebilirsin
                else if (pictureBox2.Left <= 30)
                    MessageBox.Show("Winner is IshowSpeed");
                else if (pictureBox1.Left <= 30)
                    MessageBox.Show("Winner is Mcqueen");
            }
        }



    }
}
