using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Review_2
{
    public partial class helloAgain : Form
    {
        //Pearl Baburaj
        //February 6 2024
        //Output helloAgain in textbox, label, and 10 times in listbox
        public helloAgain()
        {
            InitializeComponent();
        }

        private void ClickMe_Click(object sender, EventArgs e) //Click button
        {
            //helloAgain outputted in txtbox, lstbox, lbl
            string words = "helloAgain";
            lblhello.Text = words;
            txthello.Text = words;
            for (int i = 1; i <=10; i++) 
            {
                Console.WriteLine(i);
                lsthello.Items.Add(words);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
