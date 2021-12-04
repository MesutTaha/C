using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_14._30
{
    public partial class PictureBoxTest : Form
    {
        private int ImageNumber { get; set; } = -1;
        public PictureBoxTest()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            imagePictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"image{ImageNumber}"));
        }
    }
}
