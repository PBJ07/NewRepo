namespace RandomNumbers
{
    partial class FrmRandomNumbers
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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.txtLowest = new System.Windows.Forms.TextBox();
            this.txtHighest = new System.Windows.Forms.TextBox();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(278, 108);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(120, 238);
            this.lstDisplay.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(74, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Random Number Generator";
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(79, 115);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(100, 20);
            this.txtNumbers.TabIndex = 2;
            // 
            // txtLowest
            // 
            this.txtLowest.Location = new System.Drawing.Point(79, 178);
            this.txtLowest.Name = "txtLowest";
            this.txtLowest.Size = new System.Drawing.Size(100, 20);
            this.txtLowest.TabIndex = 3;
            // 
            // txtHighest
            // 
            this.txtHighest.Location = new System.Drawing.Point(79, 247);
            this.txtHighest.Name = "txtHighest";
            this.txtHighest.Size = new System.Drawing.Size(100, 20);
            this.txtHighest.TabIndex = 4;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(27, 99);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(206, 13);
            this.lblNumbers.TabIndex = 5;
            this.lblNumbers.Text = "How many numbers should be generated?";
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Location = new System.Drawing.Point(16, 162);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(228, 13);
            this.lblLowest.TabIndex = 6;
            this.lblLowest.Text = "What should the lowest generated number be?";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(12, 231);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(232, 13);
            this.lblHighest.TabIndex = 7;
            this.lblHighest.Text = "What should the highest generated number be?";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(145, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT PROGRAM";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(89, 307);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display Numbers";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // FrmRandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.txtHighest);
            this.Controls.Add(this.txtLowest);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstDisplay);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmRandomNumbers";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.TextBox txtLowest;
        private System.Windows.Forms.TextBox txtHighest;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplay;
    }
}

