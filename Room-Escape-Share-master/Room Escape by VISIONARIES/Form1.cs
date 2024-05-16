using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Escape_by_VISIONARIES
{
    public partial class frmMain : Form
    {
        
        Graphics g;
        frmStorage frmG = new frmStorage();          //This is where picturebox and etc are stored
        Bitmap backbuffer1;                          //For room1     
        Bitmap backbuffer2;                          //For room2   
        Bitmap sprite;
        Bitmap dialog;
        int characSize = 500;       
        Rectangle rectDest;
        Button change;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Make every image screen size
            backbuffer1 = new Bitmap(frmG.picBack1.Image,Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(backbuffer1, 0, 0, backbuffer1.Width, backbuffer1.Height);

        }

        private void picArrowL_Click(object sender, EventArgs e)
        {

        }


        private void picArrowR_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.DrawImage(backbuffer2, 0, 0, backbuffer2.Width, backbuffer2.Height);
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}

