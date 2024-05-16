namespace Control_Arrays___Shell_Games
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.btnExit = new System.Windows.Forms.Button();
            this.picShell2 = new System.Windows.Forms.PictureBox();
            this.picPearl1 = new System.Windows.Forms.PictureBox();
            this.picPearl2 = new System.Windows.Forms.PictureBox();
            this.picPearl3 = new System.Windows.Forms.PictureBox();
            this.picShell1 = new System.Windows.Forms.PictureBox();
            this.picShell3 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShell2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShell1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShell3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(662, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picShell2
            // 
            this.picShell2.Image = ((System.Drawing.Image)(resources.GetObject("picShell2.Image")));
            this.picShell2.Location = new System.Drawing.Point(274, 147);
            this.picShell2.Name = "picShell2";
            this.picShell2.Size = new System.Drawing.Size(261, 193);
            this.picShell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShell2.TabIndex = 2;
            this.picShell2.TabStop = false;
            this.picShell2.Tag = "1";
            // 
            // picPearl1
            // 
            this.picPearl1.Image = ((System.Drawing.Image)(resources.GetObject("picPearl1.Image")));
            this.picPearl1.Location = new System.Drawing.Point(79, 207);
            this.picPearl1.Name = "picPearl1";
            this.picPearl1.Size = new System.Drawing.Size(117, 73);
            this.picPearl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPearl1.TabIndex = 4;
            this.picPearl1.TabStop = false;
            this.picPearl1.Tag = "0";
            // 
            // picPearl2
            // 
            this.picPearl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPearl2.Image = ((System.Drawing.Image)(resources.GetObject("picPearl2.Image")));
            this.picPearl2.Location = new System.Drawing.Point(356, 214);
            this.picPearl2.Name = "picPearl2";
            this.picPearl2.Size = new System.Drawing.Size(98, 66);
            this.picPearl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPearl2.TabIndex = 7;
            this.picPearl2.TabStop = false;
            this.picPearl2.Tag = "1";
            // 
            // picPearl3
            // 
            this.picPearl3.Image = ((System.Drawing.Image)(resources.GetObject("picPearl3.Image")));
            this.picPearl3.Location = new System.Drawing.Point(619, 214);
            this.picPearl3.Name = "picPearl3";
            this.picPearl3.Size = new System.Drawing.Size(106, 63);
            this.picPearl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPearl3.TabIndex = 8;
            this.picPearl3.TabStop = false;
            this.picPearl3.Tag = "2";
            // 
            // picShell1
            // 
            this.picShell1.Image = ((System.Drawing.Image)(resources.GetObject("picShell1.Image")));
            this.picShell1.Location = new System.Drawing.Point(7, 147);
            this.picShell1.Name = "picShell1";
            this.picShell1.Size = new System.Drawing.Size(261, 193);
            this.picShell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShell1.TabIndex = 9;
            this.picShell1.TabStop = false;
            this.picShell1.Tag = "0";
            // 
            // picShell3
            // 
            this.picShell3.Image = ((System.Drawing.Image)(resources.GetObject("picShell3.Image")));
            this.picShell3.Location = new System.Drawing.Point(541, 147);
            this.picShell3.Name = "picShell3";
            this.picShell3.Size = new System.Drawing.Size(261, 193);
            this.picShell3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShell3.TabIndex = 10;
            this.picShell3.TabStop = false;
            this.picShell3.Tag = "2";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(275, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 59);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Shells Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInstructions.Location = new System.Drawing.Point(175, 94);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(488, 19);
            this.lblInstructions.TabIndex = 12;
            this.lblInstructions.Text = "Gain points by clicking on the shell to find the hidden pearl.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWin
            // 
            this.lblWin.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(12, 9);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(100, 23);
            this.lblWin.TabIndex = 13;
            this.lblWin.Text = "Wins:";
            // 
            // lblLoss
            // 
            this.lblLoss.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.Location = new System.Drawing.Point(12, 49);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(100, 23);
            this.lblLoss.TabIndex = 14;
            this.lblLoss.Text = "Losses:";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picShell3);
            this.Controls.Add(this.picShell1);
            this.Controls.Add(this.picPearl3);
            this.Controls.Add(this.picPearl1);
            this.Controls.Add(this.picShell2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picPearl2);
            this.Name = "frmGame";
            this.Text = "Shell Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShell2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShell1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShell3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picShell2;
        private System.Windows.Forms.PictureBox picPearl1;
        private System.Windows.Forms.PictureBox picPearl2;
        private System.Windows.Forms.PictureBox picPearl3;
        private System.Windows.Forms.PictureBox picShell1;
        private System.Windows.Forms.PictureBox picShell3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoss;
    }
}

