using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Control_Arrays___Shell_Games
{
    //Pearl Baburaj
    //April 17 2024
    /* Game:
     * user tries to find the pearl that is hidden under one of three shells */

    public partial class frmGame : Form
    {
        //GLOBAL arrays for picture boxes
        //GLOBAL variables
        PictureBox[] Shells;
        PictureBox[] Pearls;
        int wins;
        int loss;

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            //assign control arrays 
            Shells = new PictureBox[] { picShell1, picShell2, picShell3 };
            Pearls = new PictureBox[] { picPearl1, picPearl2, picPearl3 };
            lblWin.Text = $"Wins: {wins = 0}";
            lblLoss.Text = $"Losses: {loss = 0}";
            Pearls_Hide();

            //When a shell is clicked
            for (int i = 0; i < Shells.Count(); i++)
            {
                Shells[i].Tag = i;
                Shells[i].Click += new EventHandler(Shells_Click);
            }
        }

        //Function to tag shell clicked
        private void Shells_Click(object sender, EventArgs e) 
        {
            PictureBox shellClick = (PictureBox)sender;
            shellClick.Hide();
            int tag = int.Parse(shellClick.Tag.ToString());
            Score(tag); 
        }

        //Function to hide pearls and display only random one from array
        private void Pearls_Hide() 
        {
            Random rnd = new Random();
            //hide all pearl picture boxes
            for (int i = 0; i < Pearls.Count(); i++)
            {
                Pearls[i].Hide();
            }
            int Pearlrnd = rnd.Next(Pearls.Count()); 
            Pearls[Pearlrnd].Show(); //display only one pearl
        }

        //Score update based on if clicked shell has a pearl under it
        private void Score(int tag)
        {
            //Check if pearl is under shell clicked, update wins or losses score
            if (Pearls[tag].Visible)
            {
                MessageBox.Show("You found the pearl!");
                lblWin.Text = $"Wins: {wins+= 1}";
                gameRedo();
            }
            else
            {
                MessageBox.Show("Not here! Try again.");
                lblLoss.Text = $"Losses: {loss+= 1}";
                gameRedo();
                Pearls_Hide();
            }
        }

        //Function to put display back to how it was
        private void gameRedo() 
        {
            for (int i = 0; i < Shells.Length; i++)
            {
                Shells[i].Show();
            }
            Pearls_Hide();
        }

        //Exit Program button
        private void btnExit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}
