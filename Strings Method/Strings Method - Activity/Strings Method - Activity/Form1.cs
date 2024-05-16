using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Method___Activity
{
    public partial class Form1 : Form
    {
        //Pearl Baburaj
        //February 25 2024
        /*Checks to see if the word the user entered is in the sentence they entered*/
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit Program
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e) //Search for a word Button
        {
            string sentence;
            string search;
            bool found;
            sentence = txtSentence.Text.ToUpper().Trim();
            search = txtWord.Text.ToUpper().Trim();
            //if-else statement to check in the word is in the sentence they entered
            if (found = sentence.Contains(search))
            {
                lblDisplay.Text = "This word is in the sentence.";
            }
            else
            {
                lblDisplay.Text = "This word is not in the sentence.";
            }
        }
    }
}
