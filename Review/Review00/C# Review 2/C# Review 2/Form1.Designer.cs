namespace C__Review_2
{
    partial class helloAgain
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblhello = new System.Windows.Forms.Label();
            this.txthello = new System.Windows.Forms.TextBox();
            this.lsthello = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClick.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClick.Location = new System.Drawing.Point(85, 249);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(215, 39);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.ClickMe_Click);
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhello.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblhello.Location = new System.Drawing.Point(237, 34);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(0, 21);
            this.lblhello.TabIndex = 1;
            // 
            // txthello
            // 
            this.txthello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthello.Location = new System.Drawing.Point(240, 88);
            this.txthello.Name = "txthello";
            this.txthello.Size = new System.Drawing.Size(100, 29);
            this.txthello.TabIndex = 2;
            // 
            // lsthello
            // 
            this.lsthello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsthello.FormattingEnabled = true;
            this.lsthello.ItemHeight = 21;
            this.lsthello.Location = new System.Drawing.Point(43, 34);
            this.lsthello.Name = "lsthello";
            this.lsthello.Size = new System.Drawing.Size(157, 172);
            this.lsthello.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(134, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // helloAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lsthello);
            this.Controls.Add(this.txthello);
            this.Controls.Add(this.lblhello);
            this.Controls.Add(this.btnClick);
            this.Name = "helloAgain";
            this.Text = "helloAgain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.TextBox txthello;
        private System.Windows.Forms.ListBox lsthello;
        private System.Windows.Forms.Button btnExit;
    }
}

