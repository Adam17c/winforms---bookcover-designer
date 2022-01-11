
namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBoxTextAlignment = new System.Windows.Forms.GroupBox();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.radioButtonCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxTextAlignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTextAlignment
            // 
            resources.ApplyResources(this.groupBoxTextAlignment, "groupBoxTextAlignment");
            this.groupBoxTextAlignment.Controls.Add(this.radioButtonRight);
            this.groupBoxTextAlignment.Controls.Add(this.radioButtonCenter);
            this.groupBoxTextAlignment.Controls.Add(this.radioButtonLeft);
            this.groupBoxTextAlignment.Name = "groupBoxTextAlignment";
            this.groupBoxTextAlignment.TabStop = false;
            // 
            // radioButtonRight
            // 
            resources.ApplyResources(this.radioButtonRight, "radioButtonRight");
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.TabStop = true;
            this.radioButtonRight.UseVisualStyleBackColor = true;
            this.radioButtonRight.Click += new System.EventHandler(this.radioButtonRight_Click);
            // 
            // radioButtonCenter
            // 
            resources.ApplyResources(this.radioButtonCenter, "radioButtonCenter");
            this.radioButtonCenter.Name = "radioButtonCenter";
            this.radioButtonCenter.TabStop = true;
            this.radioButtonCenter.UseVisualStyleBackColor = true;
            this.radioButtonCenter.Click += new System.EventHandler(this.radioButtonCenter_Click);
            // 
            // radioButtonLeft
            // 
            resources.ApplyResources(this.radioButtonLeft, "radioButtonLeft");
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.TabStop = true;
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            this.radioButtonLeft.Click += new System.EventHandler(this.radioButtonLeft_Click);
            // 
            // labelFontSize
            // 
            resources.ApplyResources(this.labelFontSize, "labelFontSize");
            this.labelFontSize.Name = "labelFontSize";
            // 
            // numericUpDownFontSize
            // 
            resources.ApplyResources(this.numericUpDownFontSize, "numericUpDownFontSize");
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.numericUpDownFontSize);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.groupBoxTextAlignment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.groupBoxTextAlignment.ResumeLayout(false);
            this.groupBoxTextAlignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTextAlignment;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonCenter;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.TextBox textBox;
    }
}