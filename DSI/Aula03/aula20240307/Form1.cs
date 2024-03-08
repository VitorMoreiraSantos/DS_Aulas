using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula20240307
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();

            int x = gera.Next(0, 6);

            if (x >= 6)
            {
                pictureBox4.Image = Properties.Resources.limao;
            }else if(x == 5)
            {
                pictureBox4.Image = Properties.Resources.melancia;
            }
            else if (x == 4)
            {
                pictureBox4.Image = Properties.Resources.cereja;
            }
            else if (x == 3)
            {
                pictureBox4.Image = Properties.Resources.cereja_azul;
            }
            else if (x <= 2)
            {
                pictureBox4.Image = Properties.Resources.sete;
            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();

            int x = gera.Next(0, 6);

            if (x >= 6)
            {
                pictureBox2.Image = Properties.Resources.limao;
            }
            else if (x == 5)
            {
                pictureBox2.Image = Properties.Resources.melancia;
            }
            else if (x == 4)
            {
                pictureBox2.Image = Properties.Resources.cereja;
            }
            else if (x == 3)
            {
                pictureBox2.Image = Properties.Resources.cereja_azul;
            }
            else if (x <= 2)
            {
                pictureBox2.Image = Properties.Resources.sete;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();

            int x = gera.Next(0, 6);

            if (x >= 6)
            {
                pictureBox3.Image = Properties.Resources.limao;
            }
            else if (x == 5)
            {
                pictureBox3.Image = Properties.Resources.melancia;
            }
            else if (x == 4)
            {
                pictureBox3.Image = Properties.Resources.cereja;
            }
            else if (x == 3)
            {
                pictureBox3.Image = Properties.Resources.cereja_azul;
            }
            else if (x <= 2)
            {
                pictureBox3.Image = Properties.Resources.sete;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            //timer1.Tick += new EventHandler(timer1_disable);
            //timer2.Tick += new EventHandler(timer2_disable);
            //timer3.Tick += new EventHandler(timer3_disable);
        }

        private void timer1_disable(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void timer2_disable(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
        private void timer3_disable(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }
    }
}
