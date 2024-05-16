namespace SequentialFiles
{
    partial class frmFiles
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
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.rtbWrite = new System.Windows.Forms.RichTextBox();
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReadLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbRead
            // 
            this.rtbRead.Location = new System.Drawing.Point(22, 14);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.Size = new System.Drawing.Size(332, 201);
            this.rtbRead.TabIndex = 0;
            this.rtbRead.Text = "";
            // 
            // rtbWrite
            // 
            this.rtbWrite.Location = new System.Drawing.Point(22, 288);
            this.rtbWrite.Name = "rtbWrite";
            this.rtbWrite.Size = new System.Drawing.Size(332, 96);
            this.rtbWrite.TabIndex = 2;
            this.rtbWrite.Text = "";
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Location = new System.Drawing.Point(22, 390);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(157, 23);
            this.btnOverwrite.TabIndex = 3;
            this.btnOverwrite.Text = "Overwrite File";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(22, 221);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(157, 23);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(197, 390);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(157, 23);
            this.btnAppend.TabIndex = 5;
            this.btnAppend.Text = "Append to File";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "What would you like to write to the file?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(332, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReadLine
            // 
            this.btnReadLine.Location = new System.Drawing.Point(197, 221);
            this.btnReadLine.Name = "btnReadLine";
            this.btnReadLine.Size = new System.Drawing.Size(157, 23);
            this.btnReadLine.TabIndex = 8;
            this.btnReadLine.Text = "Read File Line by Line";
            this.btnReadLine.UseVisualStyleBackColor = true;
            this.btnReadLine.Click += new System.EventHandler(this.btnReadLine_Click);
            // 
            // frmFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 463);
            this.Controls.Add(this.btnReadLine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnOverwrite);
            this.Controls.Add(this.rtbWrite);
            this.Controls.Add(this.rtbRead);
            this.Name = "frmFiles";
            this.Text = "Sequential Access Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRead;
        private System.Windows.Forms.RichTextBox rtbWrite;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReadLine;
    }
}

