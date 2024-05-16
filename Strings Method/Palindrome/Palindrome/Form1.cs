using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class frmPalindrome : Form
    {
        public frmPalindrome()
        {
            InitializeComponent();
        }

        //Pearl Baburaj
        //February 29 2024
        /*Check if a user input word is a palindrome (the same word backwards)*/
        private void btnExit_Click(object sender, EventArgs e) //Exit Program
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e) //Search for Palindrome
        {
            string word;
            string reversed = "";

            word = txtWord.Text.ToUpper().Trim();
            //pull out each character, starting from the last letter, in the user input word. Add it to reversed variable
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word.Substring(i, 1);
            }
            txtReversed.Text = reversed;
            //check if word is a palindrome
            if (word == reversed)
            {
                lblDisplay.Text = $"{word} is a palindrome.";
            }
            else
            {
                lblDisplay.Text = $"{word} is not a palindrome.";
            }
        }
    }
}
