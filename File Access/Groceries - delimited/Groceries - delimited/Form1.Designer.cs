namespace Groceries___delimited
{
    partial class frmGroceries
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lstGrocery = new System.Windows.Forms.ListBox();
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInsturctions = new System.Windows.Forms.Label();
            this.rtbNewList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(344, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstGrocery
            // 
            this.lstGrocery.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGrocery.FormattingEnabled = true;
            this.lstGrocery.ItemHeight = 16;
            this.lstGrocery.Location = new System.Drawing.Point(202, 67);
            this.lstGrocery.Name = "lstGrocery";
            this.lstGrocery.Size = new System.Drawing.Size(235, 228);
            this.lstGrocery.TabIndex = 2;
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverwrite.Location = new System.Drawing.Point(36, 226);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(138, 30);
            this.btnOverwrite.TabIndex = 3;
            this.btnOverwrite.Text = "Create New List";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(36, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Groceries";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(87, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Grocery List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInsturctions
            // 
            this.lblInsturctions.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsturctions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInsturctions.Location = new System.Drawing.Point(-3, 40);
            this.lblInsturctions.Name = "lblInsturctions";
            this.lblInsturctions.Size = new System.Drawing.Size(457, 21);
            this.lblInsturctions.TabIndex = 7;
            this.lblInsturctions.Text = "Display your grocery list. Add new items to the list or create a new one.";
            this.lblInsturctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbNewList
            // 
            this.rtbNewList.Location = new System.Drawing.Point(21, 174);
            this.rtbNewList.Name = "rtbNewList";
            this.rtbNewList.Size = new System.Drawing.Size(165, 46);
            this.rtbNewList.TabIndex = 8;
            this.rtbNewList.Text = "";
            // 
            // frmGroceries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(449, 334);
            this.Controls.Add(this.rtbNewList);
            this.Controls.Add(this.lblInsturctions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOverwrite);
            this.Controls.Add(this.lstGrocery);
            this.Controls.Add(this.btnExit);
            this.Name = "frmGroceries";
            this.Text = "Groceries";
            this.Load += new System.EventHandler(this.frmGroceries_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstGrocery;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInsturctions;
        private System.Windows.Forms.RichTextBox rtbNewList;
    }
}

