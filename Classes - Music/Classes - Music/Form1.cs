using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes___Music
{
    //Pearl Baburaj
    //April 29 2024
    /*Display information about the band name, style and how many albums they've released*/
    public partial class frmMusic : Form
    {
        string filePath = Application.StartupPath + "\\Music Groups Data.txt"; //file
        string[] myBands; //array

        public frmMusic()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) // Exit Program button
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e) //Bands from Files button
        {
            try //display bands who released more than 10 albums
            {
                lstBands.Items.Clear();
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader myFile = new StreamReader(fs);
                //Read each line of file and put into array
                while (!myFile.EndOfStream) 
                {
                    MusicGroup Bands = new MusicGroup();
                    string myLine = myFile.ReadLine();
                    string[] myBands = myLine.Split(',');
                    //put each line into three component variables in array
                    for (int i = 0; i < myBands.Count(); i++)
                    {
                        Bands.BandName = myBands[0];
                        Bands.Style = myBands[1];
                        Bands.AlbumsReleased = (int.Parse(myBands[2]));
                    }
                    if (Bands.Superstar()) //display bands with more than 10 albums released
                    {
                        lstBands.Items.Add($"{Bands.ShowBandInfo()} - {Bands.AlbumsReleased}");
                    }
                }
                myFile.Close();
            }
            catch (Exception ex) //catch errors
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

