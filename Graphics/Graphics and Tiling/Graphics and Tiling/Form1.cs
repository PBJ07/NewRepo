using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Graphics_and_Tiling
{

    public partial class frmTiling1 : Form
    {
        Graphics G;
        int tileSize = 32;
        int newX;
        int newY;
        Bitmap bmpGrass;
        Bitmap bmpWater;
        string filePath = Application.StartupPath + "\\Map.txt";
        List<int> myFileLines = new List<int>();

        public frmTiling1()
        {
            InitializeComponent();
        }

        private void frmTiling_Load(object sender, EventArgs e)
        {
            bmpGrass = new Bitmap(picGrass.Image);
            bmpWater = new Bitmap(picWater.Image);
            picGrass.Hide();
            picWater.Hide();
        }

        private void btnDrawTiles_Click(object sender, EventArgs e)
        {
            G = this.CreateGraphics();
            for (int x = 0; x < this.Width; x += tileSize)        //fill background across
            {
                for (int y = 0; y < this.Height; y += tileSize)   //fill background down
                {
                    G.FillRectangle(Brushes.Black, x, y, tileSize, tileSize);
                    G.DrawRectangle(Pens.PaleVioletRed, x, y, tileSize, tileSize);
                }
            }
            G.Dispose();   // de-allocate memory for graphics object
        }


        private void frmTiling_MouseMove(object sender, MouseEventArgs e)
        {
            G = this.CreateGraphics();
            newX = e.X - e.X % tileSize;
            newY = e.Y - e.Y % tileSize;
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader myFile = new StreamReader(fs);
                while (!myFile.EndOfStream)
                {
                    myFileLines.Add(int.Parse(myFile.ReadLine()));
                    bmpGrass = ;
                    //myFilesLines[0] = bmpGrass;
                    //myFiles[1] = bmpWater;
                    //myFiles[2] = 1
                }

                if (e.Button == MouseButtons.Right)
                {
                    G.DrawImage(bmpGrass, newX, newY, tileSize, tileSize);
                    if (e.Button != MouseButtons.Right)
                    {
                        MessageBox.Show($"You clicked on ({e.X % 32},{e.Y % 32})");
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    G.DrawImage(bmpWater, newX, newY, tileSize, tileSize);
                    if (e.Button != MouseButtons.Left)
                    {
                        MessageBox.Show($"You clicked on ({e.X % tileSize},{e.Y % tileSize})");
                    }
                }
                myFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //else
            //{
            //    if (e.Button != MouseButtons.Right)
            //    {
            //        MessageBox.Show($"You clicked on ({e.X % 32},{e.Y % 32})");
            //    }
            //    else if (e.Button != MouseButtons.Left)
            //    {
            //        MessageBox.Show($"You clicked on ({e.X % 32},{e.Y % 32})");
            //    }
            //}
            G.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit Button
        {
            Application.Exit();
        }

        //private void frmTiling_MouseDown(object sender, MouseEventArgs e)
        //{
        //    G = this.CreateGraphics();
        //    //newX = e.X - e.X % tileSize;
        //    //newY = e.Y - e.Y % tileSize;

        //    if (e.Button == MouseButtons.Right)
        //    {
        //        //G.DrawImage(bmpGrass, newX, newY, tileSize, tileSize);
        //    }
        //    else if (e.Button == MouseButtons.Left)
        //    {
        //        //G.DrawImage(bmpWater, newX, newY, tileSize, tileSize);
        //        MessageBox.Show($"You clicked on ({e.X},{e.Y})");
        //    }
        //    G.Dispose();
        //}
    }
}
