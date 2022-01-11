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
    public partial class Form1 : Form
    {
        bool adding = false;
        public List<PositionedText> texts;
        PositionedText text;
        public int coverWidth = 300, coverHeight = 500, spineWidth = 30;
        public System.Drawing.SolidBrush coverBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        public System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        PositionedText selectedText;
        bool moving;
        Point lastCursorPos;

        // https://stackoverflow.com/questions/6442421/c-sharp-fastest-way-to-remove-extra-white-spaces
        static readonly System.Text.RegularExpressions.Regex trimmer = new System.Text.RegularExpressions.Regex(@"\s\s+");

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.DarkGray);
            Rectangle cover, spine;
            int coverLeft = (splitContainer1.Panel1.Width - 2 * coverWidth - spineWidth) / 2;
            int coverTop = (splitContainer1.Panel1.Height - coverHeight) / 2;
            cover = new Rectangle(coverLeft, coverTop, 2 * coverWidth + spineWidth, coverHeight);
            spine = new Rectangle((splitContainer1.Panel1.Width - spineWidth) / 2, coverTop, spineWidth, coverHeight);

            e.Graphics.FillRectangle(coverBrush, cover);
            e.Graphics.DrawRectangle(pen, cover);
            e.Graphics.DrawRectangle(pen, spine);
            pen.Dispose();
            Font font;
            StringFormat textFormat = new StringFormat();
            textFormat.LineAlignment = StringAlignment.Center;
            // write additional texts
            if (texts != null)
            foreach (var pt in texts)
            {
                font = new Font("Arial", pt.fontSize);

                Point pos = new Point();
                pos.X = coverLeft + pt.X;
                pos.Y = coverTop + pt.Y;
                int textAreaWidth, textAreaHeight;

                switch(pt.formatcase)
                {
                    case (0):
                         textFormat.Alignment = StringAlignment.Center;
                         e.Graphics.DrawString(pt.text, font, textBrush,
                            pos.X , pos.Y , textFormat);
                        break;
                    case (-1):
                        textFormat.Alignment = StringAlignment.Near;
                        e.Graphics.DrawString(pt.text, font, textBrush,
                            pos.X - e.Graphics.MeasureString(pt.text, font).Width / 2, pos.Y , textFormat);
                        break;
                    case(1):
                            textFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(pt.text, font, textBrush,
                            pos.X + e.Graphics.MeasureString(pt.text, font).Width / 2, pos.Y , textFormat);
                        break;
                }
                textAreaWidth = (int)e.Graphics.MeasureString(pt.text, font).Width;
                textAreaHeight = (int)e.Graphics.MeasureString(pt.text, font).Height;
                font.Dispose();
                pt.area = new Rectangle(pos.X - textAreaWidth / 2, pos.Y - textAreaHeight / 2, textAreaWidth, textAreaHeight);
                if(pt.drawBorder) e.Graphics.DrawRectangle(new Pen(Color.FromArgb(coverBrush.Color.ToArgb() ^ 0xffffff)), pt.area);
                //https://stackoverflow.com/questions/1165107/how-do-i-invert-a-colour
            }

            // write title on cover
            Int32 fontSize = 32;
            font = new Font("Arial", fontSize);
            string text = textBoxTitle.Text;
            int maxHeight = coverHeight / 3;
            int maxWidth = coverWidth;
            while(e.Graphics.MeasureString(text, font).Width > maxWidth || e.Graphics.MeasureString(text, font).Height > maxHeight)
            {
                if (--fontSize < 1)
                {
                    text = "";
                    break;
                }
                font.Dispose();
                font = new Font("Arial", fontSize);
            }
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(text, font, textBrush, coverLeft + (3 * coverWidth) / 2 + spineWidth - e.Graphics.MeasureString(text, font).Width / 2, coverTop + coverHeight / 6, format);
            font.Dispose();

            // write author on cover
            fontSize = 24;
            font = new Font("Arial", fontSize);
            text = textBoxAuthor.Text;
            maxHeight = coverHeight / 6;
            while (e.Graphics.MeasureString(text, font).Width > maxWidth || e.Graphics.MeasureString(text, font).Height > maxHeight)
            {
                if (--fontSize < 1)
                {
                    text = "";
                    break;
                }
                font.Dispose();
                font = new Font("Arial", fontSize);
            }
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(text, font, textBrush, coverLeft + coverWidth + spineWidth + coverWidth / 2, coverTop + coverHeight / 3, format);
            font.Dispose();

            //http://www.java2s.com/Code/CSharp/2D-Graphics/Rotatethetext45degrees.htm
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.GraphicsState state = e.Graphics.Save();
            g.ResetTransform();
            g.RotateTransform(-90);
            g.TranslateTransform(coverLeft + coverWidth + spineWidth / 2, coverTop + coverHeight, System.Drawing.Drawing2D.MatrixOrder.Append);

            // write title on spine
            fontSize = 32;
            font = new Font("Arial", fontSize);
            text = trimmer.Replace(textBoxTitle.Text, " ");
            maxHeight = spineWidth;
            maxWidth = coverHeight / 2;
            while (e.Graphics.MeasureString(text, font).Width > maxWidth || e.Graphics.MeasureString(text, font).Height > maxHeight)
            {
                if (--fontSize < 1)
                {
                    text = "";
                    break;
                }
                font.Dispose();
                font = new Font("Arial", fontSize);
            }
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawString(text, font, textBrush, coverHeight / 4, 0, format);
            font.Dispose();

            // write author on spine
            fontSize = 24;
            font = new Font("Arial", fontSize);
            text = trimmer.Replace(textBoxAuthor.Text, " ");
            maxHeight = spineWidth;
            maxWidth = coverHeight / 2;
            while (e.Graphics.MeasureString(text, font).Width > maxWidth || e.Graphics.MeasureString(text, font).Height > maxHeight)
            {
                if (--fontSize < 1)
                {
                    text = "";
                    break;
                }
                font.Dispose();
                font = new Font("Arial", fontSize);
            }
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawString(text, font, textBrush, 3 * (coverHeight / 4), 0, format);
            font.Dispose();
            format.Dispose();

            e.Graphics.Restore(state);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 textDlg = new Form3();
            text = new PositionedText();
            textDlg.CreateForm3(text);
            if (textDlg.ShowDialog() == DialogResult.OK)
            {
                adding = true;
                pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            }
            else
            {
                adding = false;
                text = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (adding)
            {
                int coverLeft = (splitContainer1.Panel1.Width - 2 * coverWidth - spineWidth) / 2;
                int coverTop = (splitContainer1.Panel1.Height - coverHeight) / 2;
                Point pos = pictureBox1.PointToClient(Cursor.Position);
                text.X = pos.X - coverLeft;
                text.Y = pos.Y - coverTop;

                if (texts == null) texts = new List<PositionedText>();
                texts.Add(text);
                pictureBox1.Invalidate();
                pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
                adding = false;
                return;
            }

            if(((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                if (texts == null) return;
                bool foundTextToSelect = false;

                Point cursorPos = pictureBox1.PointToClient(Cursor.Position);
                foreach (var pt in texts)
                {
                    if (pt.area.Contains(cursorPos))
                    {
                        if (selectedText != null) selectedText.drawBorder = false;
                        selectedText = pt;
                        pt.drawBorder = true;
                        foundTextToSelect = true;
                        break;
                    }
                }
                if(!foundTextToSelect)
                {
                    if(selectedText != null) selectedText.drawBorder = false;
                    selectedText = null;
                }
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Middle)
                moving = true;
            lastCursorPos = Cursor.Position;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Middle)
                moving = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedText == null) return;
            if (moving)
            {
                Point cursorPos = Cursor.Position;
                int offX = cursorPos.X - lastCursorPos.X;
                int offY = cursorPos.Y - lastCursorPos.Y;
                selectedText.X += offX;
                selectedText.Y += offY;
                lastCursorPos = cursorPos;

                pictureBox1.Invalidate();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (selectedText == null) return;
            if (e.KeyCode == Keys.Delete)
            {

                texts.Remove(selectedText);
                selectedText = null;
                pictureBox1.Invalidate();
                moving = false;
            }
        }


        private void toolStripMenuItemEnglish_Click(object sender, EventArgs e)
        {
            toolStripMenuItemEnglish.Checked = true;
            toolStripMenuItemPolish.Checked = false;

            ChangeLanguage("en");
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItemPolish_Click(object sender, EventArgs e)
        {
            toolStripMenuItemPolish.Checked = true;
            toolStripMenuItemEnglish.Checked = false;

            ChangeLanguage("pl-PL");
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            Form2 newDialog = new Form2();
            newDialog.CreateForm2(this);
            if (newDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAuthor.Clear();
                textBoxTitle.Clear();
                pictureBox1.Invalidate();
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        //https://www.youtube.com/watch?v=loRRYrKj3f0&t=179s&ab_channel=ProgrammingWizardsTV
        private void buttonChangeBackground_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                coverBrush.Dispose();
                coverBrush = new System.Drawing.SolidBrush(colorDialog1.Color);
                pictureBox1.Invalidate();
            }
        }

        private void buttonChangeText_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBrush.Dispose();
                textBrush = new System.Drawing.SolidBrush(colorDialog1.Color);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (texts == null) return;
            
            Point cursorPos = pictureBox1.PointToClient(Cursor.Position);
            foreach (var pt in texts)
            {
                if (pt.area.Contains(cursorPos))
                {
                    Form3 dlg = new Form3();
                    dlg.RecreateForm3(pt);
                    dlg.textBox.Text = pt.text;
                    dlg.ShowDialog();
                }
            }
            pictureBox1.Invalidate();
        }

        //https://stackoverflow.com/questions/21067507/change-language-at-runtime-in-c-sharp-winform
        private static void ChangeLanguage(string lang)
        {
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            foreach (Form frm in Application.OpenForms)
            {
                localizeForm(frm);
            }
        }

        private static void localizeForm(Form frm)
        {
            var manager = new ComponentResourceManager(frm.GetType());

            Size size = frm.ClientSize;
            Point location = frm.Location;
            manager.ApplyResources(frm, "$this");
            frm.ClientSize = size;
            frm.Location = location;
            applyResources(manager, frm.Controls);
        }

        private static void applyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                int dist = 0;
                if (ctl is SplitContainer)
                {
                    SplitContainer spl = ctl as SplitContainer;
                    dist = spl.SplitterDistance;
                }
                manager.ApplyResources(ctl, ctl.Name);
                applyResources(manager, ctl.Controls);
                if (ctl is MenuStrip)
                {
                    MenuStrip ms = ctl as MenuStrip;
                    foreach (ToolStripMenuItem item in ms.Items)
                    {
                        manager.ApplyResources(item, item.Name);
                        foreach(ToolStripDropDownItem dropDownItem in item.DropDownItems)
                        {
                            manager.ApplyResources(dropDownItem, dropDownItem.Name);
                            foreach (ToolStripDropDownItem dropDownDownItem in dropDownItem.DropDownItems)
                                manager.ApplyResources(dropDownDownItem,dropDownDownItem.Name);
                        }
                    }
                }
                if (ctl is SplitContainer)
                {
                    SplitContainer spl = ctl as SplitContainer;
                    spl.SplitterDistance = dist;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.DefaultExt = "XML (*.xml)";
            saveFileDialog1.Filter = "XML (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((fs = (System.IO.FileStream)saveFileDialog1.OpenFile()) != null)
                {
                    SerializationArgs args = new SerializationArgs();
                    args.texts = texts;
                    args.author = textBoxAuthor.Text;
                    args.title = textBoxTitle.Text;
                    args.coverWidth = coverWidth; args.coverHeight = coverHeight; args.spineWidth = spineWidth;
                    args.coverColorR = coverBrush.Color.R;
                    args.coverColorG = coverBrush.Color.G;
                    args.coverColorB = coverBrush.Color.B;
                    args.textColorR = textBrush.Color.R;
                    args.textColorG = textBrush.Color.G;
                    args.textColorB = textBrush.Color.B;

                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(SerializationArgs));
                    xs.Serialize(fs, args);
                    fs.Close();
                }
            }
        }
        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.DefaultExt = "XML (*.xml)";
                openFileDialog.Filter = "XML (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(SerializationArgs));
                    System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Open);

                    SerializationArgs args = new SerializationArgs();
                    try
                    {
                        args = (SerializationArgs)xs.Deserialize(fs);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Input string was not in correct format", "Error during file opening", MessageBoxButtons.OK ,MessageBoxIcon.Stop);
                        return;
                    }
                    fs.Close();

                    textBoxTitle.Text = args.title;
                    textBoxAuthor.Text = args.author;
                    if (texts != null) texts.Clear();
                    texts = args.texts;
                    if (texts != null)
                    {
                        foreach (PositionedText pt in texts)
                            pt.drawBorder = false;
                    }
                    coverWidth = args.coverWidth; coverHeight = args.coverHeight; spineWidth = args.spineWidth;

                    coverBrush.Dispose();
                    textBrush.Dispose();
                    Color brushColor = Color.FromArgb(args.coverColorR, args.coverColorG, args.coverColorB);
                    coverBrush = new SolidBrush(brushColor);
                    brushColor = Color.FromArgb(args.textColorR, args.textColorG, args.textColorB);
                    textBrush = new SolidBrush(brushColor);
                    pictureBox1.Invalidate();

                }
            }
        }
    }

    public class PositionedText
    {
        public PositionedText(string _text, Point _position, int left, int top)
        {
            text = _text;
            area = new Rectangle();
            drawBorder = false;
        }

        public PositionedText()
        {
            text = "";
            area = new Rectangle();
            drawBorder = false;
        }

        public Int32 fontSize;
        public string text { get; set; }
        public int formatcase { get; set; }
        public Rectangle area { set; get; }
        public bool drawBorder;

        // pozycja względem okładki
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class SerializationArgs
    {
        public SerializationArgs() { }

        public List<PositionedText> texts;
        public string title;
        public string author;
        public int coverWidth = 300, coverHeight = 500, spineWidth = 30;
        public byte coverColorR;
        public byte coverColorG;
        public byte coverColorB;
        public byte textColorR;
        public byte textColorG;
        public byte textColorB;
    }
}
