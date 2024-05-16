using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Review_3
{
    public partial class frmTriangle : Form
    {
        public frmTriangle()
        {
            InitializeComponent();
        }

        //Pearl Baburaj
        //February 8 2024
        //Calculate the area of a triangle
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height;
            double width;
            double area;

            if (double.TryParse(txtHeight.Text, out height) && double.TryParse(txtWidth.Text, out width)) //check user input to avoid crash
            {
                //Calculate area
                area = (height * width) / 2;
                lblTotal.Text = area.ToString("N2");
;           }
            else //if valid numbers were not inputted
            {
                MessageBox.Show("Please input numbers.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
