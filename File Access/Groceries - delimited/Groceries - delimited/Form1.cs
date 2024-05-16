using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Groceries___delimited
{
    //Pearl Baburaj
    //March 26 2024
    /*View already written grocey lists
     *Create new grocery list
     *Add items to your grocery list*/
    public partial class frmGroceries : Form
    {
        string filePath = Application.StartupPath + "\\groceries.txt";
        string[] myArray;  //No initial size

        public frmGroceries()
        {
            InitializeComponent();
        }
        private void frmGroceries_Load(object sender, EventArgs e) //FormLoad
        {
            Display(); //Display Function
        }

        private void btnAdd_Click(object sender, EventArgs e) //Add Groceries button 
        {
            try //Ask user what item to add to list through input box and display in list box
            {
                FileStream fs = new FileStream(filePath, FileMode.Append);
                StreamWriter myFile = new StreamWriter(fs);
                string newList;
                newList = InputBox("Type in an item to add to list. (To add more than one item add ',' between each item)");
                myFile.WriteLine(newList);
                myFile.Close();
                Display();
            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOverwrite_Click(object sender, EventArgs e) //Create new list button 
        {
            try //Overwrite file with new grocery list user typed in RTB and display in listbox
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                StreamWriter myFile = new StreamWriter(fs);
                myFile.WriteLine(rtbNewList.Text);
                myFile.Close();
                Display();
            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display() //Display Function
        {
            try //Display grocery list in the file
            {
                lstGrocery.Items.Clear();
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader myFile = new StreamReader(fs);
                //Read what is in file
                while (!myFile.EndOfStream)
                {
                    string myLine = myFile.ReadLine();
                    myArray = myLine.Split(',');
                    //Store words in array and display in list box
                    for (int i = 0; i < myArray.Count(); i++)
                    {
                        lstGrocery.Items.Add(myArray[i].Trim());
                    }
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

        private static string InputBox(string question) //Input Box
        {
            int maxWidth = question.Length * 6;  //width needed to display label
            int realWidth = Math.Max(250, maxWidth);
            //Create a form
            Size size = new Size(realWidth, 100);
            Form inBox = new Form();
            inBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inBox.ClientSize = size;
            inBox.Text = "Groceries";
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
                return txtInput.Text;
            }
            //Else return an empty string.
            else
            {
                return "";
            }
        }
    }
}
