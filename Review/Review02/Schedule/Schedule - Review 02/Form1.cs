using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule___Review_02
{
    //Pearl Baburaj
    //March 18 2024
    /* Asks user what classes they have each period (5-period day), then stores results in the array
     * Users can then:
     * Display all 5 classes in a listbox
     * asks user to choose a period number and displays the class they have in that period*/
    public partial class frmSchedule : Form
    {
        string[] classes = new string[5]; //global array for class input
        public frmSchedule()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit program button
        {
            Application.Exit();
        }

        private void btnClasses_Click(object sender, EventArgs e) //Input classes button
        {
            //asks what classes you have for each period and stores in classes array
            for (int i = 0; i < classes.Count(); i++)
            {
                classes[i] = InputBox($"What class do you have period {i + 1}?");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e) //Display classes button
        {
            lstSchedule.Items.Clear();
            //display all the user input from the array into listbox
            for (int i = 0; i < classes.Count(); i++)
            {
                lstSchedule.Items.Add(classes[i]);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e) //Choose period button
        {
            string periodNum = InputBox("Choose a period to show what class you have."); //asks question in input box
            //check if user input in question is a valid number
            if (int.TryParse(periodNum, out int periodIndex) && periodIndex >= 1 && periodIndex <= 5)
            { //display the class in period user wanted to see
                lstSchedule.Items.Clear();
                lstSchedule.Items.Add(classes[periodIndex - 1]);
            }
            else
            {
                MessageBox.Show("Please input a number from 1-5.");
            }

        }

        private static string InputBox(string question) //InputBox function //Input box to answer questions asked by program
        {
            int maxWidth = question.Length * 6;  //width needed to display label
            int realWidth = Math.Max(200, maxWidth);
            //Create a form
            Size size = new Size(realWidth, 100);
            Form inBox = new Form();
            inBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inBox.ClientSize = size;
            inBox.Text = "Periods";
            inBox.StartPosition = FormStartPosition.CenterParent;

            //Create a label to display the user's question
            Label lblMessage = new Label();
            lblMessage.Size = new Size(size.Width - 10, 23);
            lblMessage.Location = new Point(5, 5);
            lblMessage.Text = question;
            inBox.Controls.Add(lblMessage);

            //Create a textbox for the user to enter their response
            TextBox txtInput = new TextBox();
            txtInput.Size = new Size(size.Width - 10, 23);
            txtInput.Location = new Point(5, 30);
            txtInput.Text = "";
            inBox.Controls.Add(txtInput);

            //Create a button for the user to submit their response
            Button btnOK = new Button();
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.Text = "&OK";
            btnOK.Location = new Point(size.Width - 80 - 80, 55);
            inBox.Controls.Add(btnOK);

            //Create a button for the user to discard/cancel their response
            Button btnCancel = new Button();
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.Text = "&Cancel";
            btnCancel.Location = new Point(size.Width - 80, 55);
            inBox.Controls.Add(btnCancel);

            //Assign the OK/Cancel buttons as the official DialogBox OK/Cancel buttons
            inBox.AcceptButton = btnOK;
            inBox.CancelButton = btnCancel;

            //Display the form, and store the result of which button was pressed
            DialogResult result = inBox.ShowDialog();

            //If OK was pressed, return the user's response from the textbox.
            if (result == DialogResult.OK)
            {
                return txtInput.Text.Trim();
            }
            //Else return an empty string.
            else
            {
                return "";
            }
        }


    }
}
