namespace Graphics_and_Tiling
{
    partial class frmTiling1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiling1));
            this.btnDrawTiles = new System.Windows.Forms.Button();
            this.picGrass = new System.Windows.Forms.PictureBox();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawTiles
            // 
            this.btnDrawTiles.Location = new System.Drawing.Point(12, 183);
            this.btnDrawTiles.Name = "btnDrawTiles";
            this.btnDrawTiles.Size = new System.Drawing.Size(75, 23);
            this.btnDrawTiles.TabIndex = 0;
            this.btnDrawTiles.Text = "Draw Tiles";
            this.btnDrawTiles.UseVisualStyleBackColor = true;
            this.btnDrawTiles.Click += new System.EventHandler(this.btnDrawTiles_Click);
            // 
            // picGrass
            // 
            this.picGrass.Image = ((System.Drawing.Image)(resources.GetObject("picGrass.Image")));
            this.picGrass.Location = new System.Drawing.Point(228, 95);
            this.picGrass.Name = "picGrass";
            this.picGrass.Size = new System.Drawing.Size(100, 50);
            this.picGrass.TabIndex = 1;
            this.picGrass.TabStop = false;
            // 
            // picWater
            // 
            this.picWater.Image = ((System.Drawing.Image)(resources.GetObject("picWater.Image")));
            this.picWater.Location = new System.Drawing.Point(455, 95);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(100, 50);
            this.picWater.TabIndex = 2;
            this.picWater.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 154);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Map";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // frmTiling1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picWater);
            this.Controls.Add(this.picGrass);
            this.Controls.Add(this.btnDrawTiles);
            this.Name = "frmTiling1";
            this.Text = "Tiled Graphics";
            this.Load += new System.EventHandler(this.frmTiling_Load);
            //this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTiling_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTiling_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrawTiles;
        private System.Windows.Forms.PictureBox picGrass;
        private System.Windows.Forms.PictureBox picWater;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
    }
}

