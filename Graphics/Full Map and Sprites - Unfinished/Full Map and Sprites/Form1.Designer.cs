namespace Full_Map_and_Sprites
{
    partial class frmMain
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
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSave = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // lblSave
            // 
            this.lblSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSave.Location = new System.Drawing.Point(12, 344);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(100, 23);
            this.lblSave.TabIndex = 3;
            this.lblSave.Text = "Save";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblLoad
            // 
            this.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoad.Location = new System.Drawing.Point(118, 344);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(100, 23);
            this.lblLoad.TabIndex = 4;
            this.lblLoad.Text = "Load";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoad.Click += new System.EventHandler(this.lblLoad_Click);
            // 
            // lblClear
            // 
            this.lblClear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClear.Location = new System.Drawing.Point(224, 344);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(100, 23);
            this.lblClear.TabIndex = 5;
            this.lblClear.Text = "Clear";
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 381);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.lblSave);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblClear;
    }
}

