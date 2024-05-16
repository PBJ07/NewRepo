namespace Graphics_Persistence_and_Sprites
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
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picSprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.Image = global::Graphics_Persistence_and_Sprites.Properties.Resources.Ocean;
            this.picBack.InitialImage = global::Graphics_Persistence_and_Sprites.Properties.Resources.Ocean;
            this.picBack.Location = new System.Drawing.Point(-20, -29);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(843, 479);
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // picSprite
            // 
            this.picSprite.Image = ((System.Drawing.Image)(resources.GetObject("picSprite.Image")));
            this.picSprite.Location = new System.Drawing.Point(0, 0);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(33, 34);
            this.picSprite.TabIndex = 1;
            this.picSprite.TabStop = false;
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSprite);
            this.Controls.Add(this.picBack);
            this.Name = "frmGraphics";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picBack;
        public System.Windows.Forms.PictureBox picSprite;
    }
}