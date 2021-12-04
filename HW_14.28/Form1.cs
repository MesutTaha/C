using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_14._28
{
    public partial class RadioButtonsTest : Form
    {
        private MessageBoxIcon IconType { get; set; }
        private MessageBoxButtons ButtonType { get; set; }

        public RadioButtonsTest()
        {
            InitializeComponent();
        }

        private void RadioButtonsTest_Load(object sender, EventArgs e)
        {
            OKRadioButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);
            OKCancelRadioButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);
            ARIradioButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);
            YNCradioButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);
            YNradioButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);
            RCradioButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);

            asteriksRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
            errorRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
            exclamationRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
            handRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
            informationRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
            questionRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
            stopRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
            warningRadioButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);
        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == OKRadioButton)
                ButtonType = MessageBoxButtons.OK;

            if (sender == OKCancelRadioButton)
                ButtonType = MessageBoxButtons.OKCancel;

            if (sender == ARIradioButton)
                ButtonType = MessageBoxButtons.AbortRetryIgnore;

            if (sender == YNCradioButton)
                ButtonType = MessageBoxButtons.YesNoCancel;

            if (sender == YNradioButton)
                ButtonType = MessageBoxButtons.YesNo;

            if (sender == RCradioButton)
                ButtonType = MessageBoxButtons.RetryCancel;
        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriksRadioButton)
                IconType = MessageBoxIcon.Asterisk;

            if (sender == errorRadioButton)
                IconType = MessageBoxIcon.Error;

            if (sender == exclamationRadioButton)
                IconType = MessageBoxIcon.Exclamation;

            if (sender == handRadioButton)
                IconType = MessageBoxIcon.Hand;

            if (sender == informationRadioButton)
                IconType = MessageBoxIcon.Information;

            if (sender == questionRadioButton)
                IconType = MessageBoxIcon.Question;

            if (sender == stopRadioButton)
                IconType = MessageBoxIcon.Stop;

            if (sender == warningRadioButton)
                IconType = MessageBoxIcon.Warning;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This is your Custom MessageBox.", "Custon MessageBox", ButtonType, IconType);
            switch(result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "OK was pressed";
                    break;

                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed";
                    break;

                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed";
                    break;

                case DialogResult.Retry:
                    displayLabel.Text = "Retry was pressed";
                    break;

                case DialogResult.Ignore:
                    displayLabel.Text = "Ignore was pressed";
                    break;

                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed";
                    break;

                case DialogResult.No:
                    displayLabel.Text = "No was pressed";
                    break;
            }
        }

        
    }
}
