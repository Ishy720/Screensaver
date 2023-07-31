namespace Ambience
{
    partial class Screensaver
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
            this.components = new System.ComponentModel.Container();
            this.timeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateLbl = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.backColorLbl = new System.Windows.Forms.Label();
            this.backColorDropDownList = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLbl.Location = new System.Drawing.Point(25, 428);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLbl.Size = new System.Drawing.Size(400, 120);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "00:00:00";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.timeLbl.Click += new System.EventHandler(this.timeLbl_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dateLbl.Location = new System.Drawing.Point(31, 509);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(640, 124);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "Date";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateLbl.Click += new System.EventHandler(this.dateLbl_Click);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.BackColor = System.Drawing.Color.DimGray;
            this.settingsGroupBox.Controls.Add(this.exitBtn);
            this.settingsGroupBox.Controls.Add(this.backColorLbl);
            this.settingsGroupBox.Controls.Add(this.backColorDropDownList);
            this.settingsGroupBox.Controls.Add(this.cancelBtn);
            this.settingsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsGroupBox.Location = new System.Drawing.Point(413, 99);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(629, 419);
            this.settingsGroupBox.TabIndex = 2;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(491, 353);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(123, 51);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backColorLbl
            // 
            this.backColorLbl.AutoSize = true;
            this.backColorLbl.Location = new System.Drawing.Point(27, 44);
            this.backColorLbl.Name = "backColorLbl";
            this.backColorLbl.Size = new System.Drawing.Size(193, 27);
            this.backColorLbl.TabIndex = 2;
            this.backColorLbl.Text = "Background Colour:";
            // 
            // backColorDropDownList
            // 
            this.backColorDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backColorDropDownList.FormattingEnabled = true;
            this.backColorDropDownList.Items.AddRange(new object[] {
            "Black",
            "Yellow",
            "Blue",
            "Red",
            "Gray"});
            this.backColorDropDownList.Location = new System.Drawing.Point(226, 36);
            this.backColorDropDownList.Name = "backColorDropDownList";
            this.backColorDropDownList.Size = new System.Drawing.Size(199, 35);
            this.backColorDropDownList.TabIndex = 1;
            this.backColorDropDownList.SelectedIndexChanged += new System.EventHandler(this.backColorDropDownList_SelectedIndexChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(491, 296);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 51);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Hide";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Screensaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1337, 676);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateLbl);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Screensaver";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox backColorDropDownList;
        private System.Windows.Forms.Label backColorLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}

