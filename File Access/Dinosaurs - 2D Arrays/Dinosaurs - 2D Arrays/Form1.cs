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

namespace Dinosaurs___2D_Arrays
{
    //Pearl Baburaj
    //April 4 2024
    /*Display all dinosaurs or based on their characteristics*/
    public partial class frmDinos : Form
    {
        string filePath = Application.StartupPath + "\\dinos.txt"; //
        string[,] dinos = new string[6, 3]; //2D Array
        public frmDinos()
        {
            InitializeComponent();
        }

        private void frmDinos_Load(object sender, EventArgs e) //Form
        {
            try //Read each line in file into array "dinos"
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader myFile = new StreamReader(fs);
                for (int x = 0; x < dinos.GetLength(0); x++)
                {
                    for (int y = 0; y < dinos.GetLength(1); y++)
                    {
                        dinos[x, y] = myFile.ReadLine();
                    }
                }
                myFile.Close();
            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e) //Quit button
        {
            Application.Exit();
        }

        private void btnShowAll_Click(object sender, EventArgs e) //Show All Dinos button
        {
            //Display 
            lstDisplay.Items.Clear();
            for (int x = 0; x < dinos.GetLength(0); x++)
            {
                lstDisplay.Items.Add($"{dinos[x, 0],-16}{dinos[x, 1],-16}{dinos[x, 2],-16}");
            }
        }

        private void btnShowHerbs_Click(object sender, EventArgs e) //Show Herbivores button
        {
            //Display herbivore dinosaurs only
            lstDisplay.Items.Clear();
            for (int x = 0; x < dinos.GetLength(0); x++)
            {
                if (dinos[x, 1] == "Herbivore")
                {
                    lstDisplay.Items.Add($"{dinos[x, 0],-16}{dinos[x, 1],-16}{dinos[x, 2],-16}");
                }
            }
        }

        private void btnShowCarns_Click(object sender, EventArgs e) //Show Carnivores button
        {
            //Display carnivore dinosaurs only
            lstDisplay.Items.Clear();
            for (int x = 0; x < dinos.GetLength(0); x++)
            {
                if (dinos[x, 1] == "Carnivore")
                {
                    lstDisplay.Items.Add($"{dinos[x, 0],-16}{dinos[x, 1],-16}{dinos[x, 2],-16}");
                }
            }
        }

        private void btnShow2_Click(object sender, EventArgs e) //Show Bipeds button
        {
            //Display biped dinosaurs only
            lstDisplay.Items.Clear();
            for (int x = 0; x < dinos.GetLength(0); x++)
            {
                if (dinos[x, 2] == "Biped")
                {
                    lstDisplay.Items.Add($"{dinos[x, 0],-16}{dinos[x, 1],-16}{dinos[x, 2],-16}");
                }
            }
        }

        private void btnShow4_Click(object sender, EventArgs e) //Show Quadrupeds button
        {
            //Display quadruped dinosaurs only
            lstDisplay.Items.Clear();
            for (int x = 0; x < dinos.GetLength(0); x++)
            {
                if (dinos[x, 2] == "Quadruped")
                {
                    lstDisplay.Items.Add($"{dinos[x, 0],-16}{dinos[x, 1],-16}{dinos[x, 2],-16}");
                }
            }
        }
    }
}
