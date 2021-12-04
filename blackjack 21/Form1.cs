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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int oyuncu1 = 0;
        int oyuncu2 = 0;
        int a = 0;
        Random kart = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(kart.Next(1, 11));
            
            int top = 0;

            int[] kartlar = new int[listBox1.Items.Count];
           
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                a = i;
                kartlar[i] = Int32.Parse(listBox1.Items[i].ToString());
                top = top + kartlar[i];
                oyuncu1 = top;
                label1.Text = top.ToString();
                if (top > 21)
                {
                    oyuncu1 = 0;
                }
                if (i == 3)
                {
                    button1.Enabled = false;
                    button1.Text = "kart hakkınız bitti";
                }
            }
            button2.Enabled = true;
            button2.Text = "kart çek";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           for(int j = 0; j <= 0; j++)
            {
                listBox2.Items.Add(kart.Next(1, 11));
               
            }
           

            int toplam = 0;
            
            int[] çek = new int[listBox2.Items.Count];
            
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                çek[i] = Int32.Parse(listBox2.Items[i].ToString());
                toplam = toplam + çek[i];
                oyuncu2 = toplam;
                label2.Text = toplam.ToString();
                if (toplam > 21)
                {
                    oyuncu2 = 0;
                }
                if (i == 3 && a==i)
                {
                    button2.Enabled = false;
                    button2.Text= "kart hakkınız bitti";
                    if(oyuncu2>oyuncu1 && oyuncu2 <= 21)
                    {
                        MessageBox.Show("kazanan oyuncu-2");
                        
                    }
                    else if(oyuncu1>oyuncu2 && oyuncu1 <= 21)
                    {
                        MessageBox.Show("kazanan oyuncu-1");
                    }
                }
            }
            button1.Enabled = true;
            button1.Text = "kart çek";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "Tur pas geçildi";
            button2.Enabled = true;
            button2.Text = "kart çek";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Text = "Tur pas geçildi";
            button1.Enabled = true;
            button1.Text = "kart çek";
        }
    }
}
