using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random kart = new Random();
        int sayaç = 0;
        int toplam = 0;
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayaç++;
            int top = 0;
            if (sayaç == 1)
            {
                label1.Text = kart.Next(1, 11).ToString();
                label2.Text = kart.Next(1, 11).ToString();
                top = Convert.ToInt32(label2.Text);
            }
            if (sayaç==2)
            {
                label3.Text = kart.Next(1, 11).ToString();
                top = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) ;
            }
            if (sayaç == 3)
            {
                label4.Text= kart.Next(1, 11).ToString();
                top = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text);
            }
            if (sayaç == 4)
            {
                top = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text);
                button1.Enabled = false;
                button2.Enabled = false;
                label1.Visible = true;
            }
           
            toplam = top;
            if (toplam > 21)
                toplam = 0;
            label5.Text=toplam.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label12.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = (toplam + Convert.ToInt32(label1.Text)).ToString();
            label1.Visible = true;
            button1.Enabled = false;
        }
        int say = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            say++;
            int sums = 0;
            if (say == 1)
            {
                label12.Text = kart.Next(1, 11).ToString();
                label14.Text = kart.Next(1, 11).ToString();
                sums = Convert.ToInt32(label14.Text);
            }
            if (say == 2)
            {
                label16.Text = kart.Next(1, 11).ToString();
                sums = Convert.ToInt32(label14.Text) + Convert.ToInt32(label16.Text);
            }
            if (say == 3)
            {
                label17.Text = kart.Next(1, 11).ToString();
                sums = Convert.ToInt32(label14.Text) + Convert.ToInt32(label16.Text) + Convert.ToInt32(label17.Text);
            }
            if (say == 4)
            {
               
                sums = Convert.ToInt32(label12.Text) + Convert.ToInt32(label14.Text) + Convert.ToInt32(label16.Text) + Convert.ToInt32(label17.Text);
                button4.Enabled = false;
                button3.Enabled = false;
                label12.Visible = true;
               
            }
            sum = sums;
            if (sum > 21)
            {
                sum = 0;
            }
            label18.Text = sum.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label18.Text = (sum + Convert.ToInt32(label12.Text)).ToString();
            button4.Enabled = false;
            label12.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false && button4.Enabled == false)
            {
                if (sum > toplam && sum <= 21)
                {
                    MessageBox.Show("kazanan 2. oyuncu");
                }
                else if (toplam > sum && toplam <= 21)
                {
                    MessageBox.Show("kazanan 1. oyuncu");
                }
            }
        }
    }
}
