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
    public partial class Form2 : Form
    {
        Form1 mainForm;
        
        public Form2()
        {
            InitializeComponent();
        }

        public void CreateForm2(Form1 form1)
        {
            mainForm = form1;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            mainForm.coverWidth = (int)numericUpDownWidth.Value;
            mainForm.coverHeight = (int)numericUpDownHeight.Value;
            mainForm.spineWidth = (int)numericUpDownSpineWitdth.Value;
            mainForm.texts = null;
            mainForm.coverBrush.Dispose();
            mainForm.coverBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            mainForm.textBrush.Dispose();
            mainForm.textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
