﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_14._20
{
    public partial class LabelTextBoxButtonTest : Form
    {
        public LabelTextBoxButtonTest()
        {
            InitializeComponent();
        }

        private void displayPasswordButton_Click(object sender, EventArgs e)
        {
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        }
    }
}
