
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelAdditionalText = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelColorSettings = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonChangeBackground = new System.Windows.Forms.Button();
            this.buttonChangeText = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPolish = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAdditionalText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAuthor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddText, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelAuthor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelColorSettings, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // textBoxTitle
            // 
            resources.ApplyResources(this.textBoxTitle, "textBoxTitle");
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelAdditionalText
            // 
            resources.ApplyResources(this.labelAdditionalText, "labelAdditionalText");
            this.labelAdditionalText.Name = "labelAdditionalText";
            // 
            // textBoxAuthor
            // 
            resources.ApplyResources(this.textBoxAuthor, "textBoxAuthor");
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // buttonAddText
            // 
            resources.ApplyResources(this.buttonAddText, "buttonAddText");
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAuthor
            // 
            resources.ApplyResources(this.labelAuthor, "labelAuthor");
            this.labelAuthor.Name = "labelAuthor";
            // 
            // labelColorSettings
            // 
            resources.ApplyResources(this.labelColorSettings, "labelColorSettings");
            this.labelColorSettings.Name = "labelColorSettings";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.labelBackground, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangeBackground, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangeText, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // labelBackground
            // 
            resources.ApplyResources(this.labelBackground, "labelBackground");
            this.labelBackground.Name = "labelBackground";
            // 
            // labelText
            // 
            resources.ApplyResources(this.labelText, "labelText");
            this.labelText.Name = "labelText";
            // 
            // buttonChangeBackground
            // 
            resources.ApplyResources(this.buttonChangeBackground, "buttonChangeBackground");
            this.buttonChangeBackground.Name = "buttonChangeBackground";
            this.buttonChangeBackground.UseVisualStyleBackColor = true;
            this.buttonChangeBackground.Click += new System.EventHandler(this.buttonChangeBackground_Click);
            // 
            // buttonChangeText
            // 
            resources.ApplyResources(this.buttonChangeText, "buttonChangeText");
            this.buttonChangeText.Name = "buttonChangeText";
            this.buttonChangeText.UseVisualStyleBackColor = true;
            this.buttonChangeText.Click += new System.EventHandler(this.buttonChangeText_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemSettings});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            resources.ApplyResources(this.toolStripMenuItemFile, "toolStripMenuItemFile");
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            // 
            // toolStripMenuItemNew
            // 
            resources.ApplyResources(this.toolStripMenuItemNew, "toolStripMenuItemNew");
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // toolStripMenuItemOpen
            // 
            resources.ApplyResources(this.toolStripMenuItemOpen, "toolStripMenuItemOpen");
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemSave
            // 
            resources.ApplyResources(this.toolStripMenuItemSave, "toolStripMenuItemSave");
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // toolStripMenuItemSettings
            // 
            resources.ApplyResources(this.toolStripMenuItemSettings, "toolStripMenuItemSettings");
            this.toolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLanguage});
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            // 
            // toolStripMenuItemLanguage
            // 
            resources.ApplyResources(this.toolStripMenuItemLanguage, "toolStripMenuItemLanguage");
            this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEnglish,
            this.toolStripMenuItemPolish});
            this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
            // 
            // toolStripMenuItemEnglish
            // 
            resources.ApplyResources(this.toolStripMenuItemEnglish, "toolStripMenuItemEnglish");
            this.toolStripMenuItemEnglish.Checked = true;
            this.toolStripMenuItemEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemEnglish.Name = "toolStripMenuItemEnglish";
            this.toolStripMenuItemEnglish.Click += new System.EventHandler(this.toolStripMenuItemEnglish_Click);
            // 
            // toolStripMenuItemPolish
            // 
            resources.ApplyResources(this.toolStripMenuItemPolish, "toolStripMenuItemPolish");
            this.toolStripMenuItemPolish.Name = "toolStripMenuItemPolish";
            this.toolStripMenuItemPolish.Click += new System.EventHandler(this.toolStripMenuItemPolish_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelAdditionalText;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishLanguage;
        private System.Windows.Forms.ToolStripMenuItem polishLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnglish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPolish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.Label labelColorSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonChangeBackground;
        private System.Windows.Forms.Button buttonChangeText;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

