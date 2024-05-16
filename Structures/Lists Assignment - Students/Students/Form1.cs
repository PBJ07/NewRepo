using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Students
{
    //Pearl Baburaj
    //March 1, 2024
    /*Add & Remove students names
      Clear listbox
      Sort names alphabetically*/
    public partial class frmStudents : Form
    {
        List<string> Students = new List<string>(); //Students list
        public frmStudents()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit Program Button
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Add students Button
        {
            //if-else to check if user input is valid
            if (txtAdd.Text.Trim() == "")
            {
                MessageBox.Show("Please type in a name.");
            }
            else
            {
                Students.Add(txtAdd.Text.Trim());
                Display(); //Display in listbox
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) //Remove students Button
        {
            //Remove highlighted name off list
            if (lstDisplay.SelectedIndex != -1)
            {
                Students.RemoveAt(lstDisplay.SelectedIndex);
                Display(); //Display function
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //Delete Class List Button
        {
            Students.Clear(); //delete from list
            lstDisplay.Items.Clear(); //delete from listbox display
        }

        private void btnSort_Click(object sender, EventArgs e) //Sort Alphabetically Button
        {
            Students.Sort();
            Display(); //Display function
        }

        private void Display() //Display Function
        {
            lstDisplay.Items.Clear(); //delete from listbox display
            //Display in listbox
            for (int i = 0; i < Students.Count; i++)
            {
                lstDisplay.Items.Add(Students[i]);
            }
        }
    }
}
