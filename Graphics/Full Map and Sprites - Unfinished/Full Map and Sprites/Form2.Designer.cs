namespace Full_Map_and_Sprites
{
    partial class frmGraphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraphics));
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.picGrass = new System.Windows.Forms.PictureBox();
            this.picWater = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            this.SuspendLayout();
            // 
            // picSprite
            // 
            this.picSprite.Image = ((System.Drawing.Image)(resources.GetObject("picSprite.Image")));
            this.picSprite.Location = new System.Drawing.Point(0, 0);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(165, 168);
            this.picSprite.TabIndex = 0;
            this.picSprite.TabStop = false;
            // 
            // picGrass
            // 
            this.picGrass.Image = ((System.Drawing.Image)(resources.GetObject("picGrass.Image")));
            this.picGrass.Location = new System.Drawing.Point(216, 0);
            this.picGrass.Name = "picGrass";
            this.picGrass.Size = new System.Drawing.Size(50, 50);
            this.picGrass.TabIndex = 1;
            this.picGrass.TabStop = false;
            // 
            // picWater
            // 
            this.picWater.Image = ((System.Drawing.Image)(resources.GetObject("picWater.Image")));
            this.picWater.Location = new System.Drawing.Point(331, 0);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(50, 50);
            this.picWater.TabIndex = 2;
            this.picWater.TabStop = false;
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 236);
            this.Controls.Add(this.picWater);
            this.Controls.Add(this.picGrass);
            this.Controls.Add(this.picSprite);
            this.Name = "frmGraphics";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picSprite;
        public System.Windows.Forms.PictureBox picGrass;
        public System.Windows.Forms.PictureBox picWater;
    }
}