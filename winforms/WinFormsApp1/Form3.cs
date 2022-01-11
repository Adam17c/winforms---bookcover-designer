using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        PositionedText text;
        
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(PositionedText _text)
        {
            InitializeComponent();
        }

        public void CreateForm3(PositionedText _text)
        {
            text = _text;
        }

        public void RecreateForm3(PositionedText _text)
        {
            text = _text;
            //textBox.Text = text.text;
            numericUpDownFontSize.Value = (decimal)text.fontSize;
            switch (text.formatcase)
            {
                case (0):
                    radioButtonCenter.Checked = true;
                    break;
                case (-1):
                    radioButtonLeft.Checked = true;
                    break;
                case (1):
                    radioButtonRight.Checked = true;
                    break;
            }
        }

        private void radioButtonLeft_Click(object sender, EventArgs e)
        {
            textBox.TextAlign = HorizontalAlignment.Left;
            text.formatcase = -1;
        }

        private void radioButtonCenter_Click(object sender, EventArgs e)
        {
            textBox.TextAlign = HorizontalAlignment.Center;
            text.formatcase = 0;
        }

        private void radioButtonRight_Click(object sender, EventArgs e)
        {
            textBox.TextAlign = HorizontalAlignment.Right;
            text.formatcase = 1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            text.text = textBox.Text;
            text.fontSize = (Int32)numericUpDownFontSize.Value;
            //text.font.Dispose();
            //text.font = new Font("Arial", size);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
