using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbers
{
    
    public partial class FrmRandomNumbers : Form
    {
        
        public FrmRandomNumbers()
        {
            InitializeComponent();
        }
        //Pearl Baburaj
        //February 23 2024
        /*Asks how many numbers should be generated, the lowest random number, and the highest numbers to generate.
         Generates random number within those ranges*/
        private void btnExit_Click(object sender, EventArgs e) //Exit program
        {
            Application.Exit();
        }

        private void btnDisplay_Click(object sender, EventArgs e) //Display numbers
        {
            int highnum;
            int lownum;
            int amount;
            //check if inputs are valid
            if (int.TryParse(txtHighest.Text, out highnum) && int.TryParse(txtLowest.Text, out lownum) && int.TryParse(txtNumbers.Text, out amount))
            {
                GenerateNum(highnum, lownum, amount);
            }
            else
            {
                MessageBox.Show("Please input whole numbers.");
            }
        }

        private void GenerateNum(int highnum, int lownum, int amount)//Generates and displays random numbers in listbox
        {
            lstDisplay.Items.Clear();
            Random rnd = new Random();
            //keep generating numbers, within given range, until amount of number generated meets amount asked to be generated
            for (int i = 0;  i < amount; i++)
            {
                lstDisplay.Items.Add(rnd.Next(lownum, highnum));
            }
        }
    }
}
