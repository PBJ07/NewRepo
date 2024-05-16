namespace Dinosaurs___2D_Arrays
{
    partial class frmDinos
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowHerbs = new System.Windows.Forms.Button();
            this.btnShowCarns = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnShow4 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(417, 66);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(135, 27);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All Dinos";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowHerbs
            // 
            this.btnShowHerbs.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHerbs.Location = new System.Drawing.Point(417, 99);
            this.btnShowHerbs.Name = "btnShowHerbs";
            this.btnShowHerbs.Size = new System.Drawing.Size(135, 27);
            this.btnShowHerbs.TabIndex = 1;
            this.btnShowHerbs.Text = "Show Herbivores";
            this.btnShowHerbs.UseVisualStyleBackColor = true;
            this.btnShowHerbs.Click += new System.EventHandler(this.btnShowHerbs_Click);
            // 
            // btnShowCarns
            // 
            this.btnShowCarns.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCarns.Location = new System.Drawing.Point(417, 132);
            this.btnShowCarns.Name = "btnShowCarns";
            this.btnShowCarns.Size = new System.Drawing.Size(135, 27);
            this.btnShowCarns.TabIndex = 2;
            this.btnShowCarns.Text = "Show Carnivores";
            this.btnShowCarns.UseVisualStyleBackColor = true;
            this.btnShowCarns.Click += new System.EventHandler(this.btnShowCarns_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow2.Location = new System.Drawing.Point(558, 66);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(135, 27);
            this.btnShow2.TabIndex = 3;
            this.btnShow2.Text = "Show Bipeds";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(558, 132);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 27);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnShow4
            // 
            this.btnShow4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow4.Location = new System.Drawing.Point(558, 99);
            this.btnShow4.Name = "btnShow4";
            this.btnShow4.Size = new System.Drawing.Size(135, 27);
            this.btnShow4.TabIndex = 5;
            this.btnShow4.Text = "Show Quadrupeds";
            this.btnShow4.UseVisualStyleBackColor = true;
            this.btnShow4.Click += new System.EventHandler(this.btnShow4_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(199, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 23);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Deluxe Dinosaur Data Display ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 15;
            this.lstDisplay.Location = new System.Drawing.Point(12, 46);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(399, 139);
            this.lstDisplay.TabIndex = 7;
            // 
            // frmDinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(103)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(705, 196);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShow4);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShowCarns);
            this.Controls.Add(this.btnShowHerbs);
            this.Controls.Add(this.btnShowAll);
            this.Name = "frmDinos";
            this.Text = "Dinos";
            this.Load += new System.EventHandler(this.frmDinos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowHerbs;
        private System.Windows.Forms.Button btnShowCarns;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnShow4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}

