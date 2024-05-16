namespace Sorting_Techniques
{
    partial class frmSort
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBetterBub = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnB = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnLinear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblNums = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 102);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(113, 20);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 17;
            this.lstDisplay.Location = new System.Drawing.Point(154, 92);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(189, 276);
            this.lstDisplay.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(372, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.Location = new System.Drawing.Point(12, 157);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(113, 23);
            this.btnBubble.TabIndex = 3;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 128);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(114, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBetterBub
            // 
            this.btnBetterBub.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetterBub.Location = new System.Drawing.Point(12, 186);
            this.btnBetterBub.Name = "btnBetterBub";
            this.btnBetterBub.Size = new System.Drawing.Size(113, 23);
            this.btnBetterBub.TabIndex = 5;
            this.btnBetterBub.Text = "Better Bubble Sort";
            this.btnBetterBub.UseVisualStyleBackColor = true;
            this.btnBetterBub.Click += new System.EventHandler(this.btnBetterBub_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelection.Location = new System.Drawing.Point(12, 215);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(113, 23);
            this.btnSelection.TabIndex = 6;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertion.Location = new System.Drawing.Point(12, 244);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(113, 23);
            this.btnInsertion.TabIndex = 7;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(359, 128);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnB.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(359, 186);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(113, 23);
            this.btnB.TabIndex = 12;
            this.btnB.Text = "Binary Search";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(170, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 23);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Sort and Search";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(68, 44);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(368, 23);
            this.lblInstructions.TabIndex = 14;
            this.lblInstructions.Text = "Generate random number, sort them and search for a value";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLinear
            // 
            this.btnLinear.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinear.Location = new System.Drawing.Point(359, 157);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(113, 23);
            this.btnLinear.TabIndex = 15;
            this.btnLinear.Text = "Linear Search";
            this.btnLinear.UseVisualStyleBackColor = true;
            this.btnLinear.Click += new System.EventHandler(this.btnLinear_Click_1);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(356, 99);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 23);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search for a number";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNums
            // 
            this.lblNums.Location = new System.Drawing.Point(0, 76);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(148, 23);
            this.lblNums.TabIndex = 17;
            this.lblNums.Text = "Generate random numbers";
            this.lblNums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 404);
            this.Controls.Add(this.lblNums);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnLinear);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBetterBub);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtNum);
            this.Name = "frmSort";
            this.Text = "Sort and Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBetterBub;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnLinear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblNums;
    }
}

