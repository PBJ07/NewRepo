using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequentialFiles
{
    //Pearl Baburaj
    //March 20 2024
    /*Read and display what is in file in a RTB 
     *Overwrite or Append the file with what is in another RTB
     *Read each line in the file*/

    public partial class frmFiles : Form
    {
        string filePath = Application.StartupPath + "\\Sample.txt"; //file path to find text
        public frmFiles()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e) //Read File button
        {
            //Read what is in Sample.txt file and display in rtb.
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader myFile = new StreamReader(fs);
                string fileContents = myFile.ReadToEnd();
                rtbRead.Text = (fileContents); //rtbRead: Top RTB
                myFile.Close();

            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOverwrite_Click(object sender, EventArgs e) //Overwrite File button
        {
            //Overwrite text in Sample.txt with whatever is in the bottom RTB.
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                StreamWriter myFile = new StreamWriter(fs);
                myFile.WriteLine(rtbWrite.Text); //rtbWrite: Bottom RTB 
                myFile.Close();
            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAppend_Click(object sender, EventArgs e) //Append to File button
        {
            //Add text in bottom RTB to the file. Not removing the text already there.
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Append);
                StreamWriter myFile = new StreamWriter(fs);
                myFile.WriteLine(rtbWrite.Text); 
                myFile.Close();
            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadLine_Click(object sender, EventArgs e) //Read File Line by Line button
        {
            //Show each line of text in a message box.
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader myFile = new StreamReader(fs);
                while (!myFile.EndOfStream)
                {
                    string myLine = myFile.ReadLine();
                    MessageBox.Show(myLine);
                }
                myFile.Close();
            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit Program Button
        {
            Application.Exit();
        }
    }
}

