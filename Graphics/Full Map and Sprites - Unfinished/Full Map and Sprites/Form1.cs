//Full Map and Sprites
//Mrs. French
//April 2022
//This program uses KeyDown and a Timer to animate a sprite around a map.
//There is some map-building capability on MouseMove to make grass and water.
//Program is incomplete - students may add:
//       - error proofing
//       - better mapping including load and save
//       - more versatile map-building tile options


//Edited by:
//Date:
//Changes made:


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

namespace Full_Map_and_Sprites
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        frmGraphics frmG = new frmGraphics();  //This is an instance of the second form
        Bitmap backbuffer;                     //This will hold the image to be drawn on the Form
        Bitmap minibuffer;                     //For repairing the background

        Bitmap bmpGirl;                        //To hold image of your sprite character
        Bitmap bmpGrass;
        Bitmap bmpWater;
        Rectangle rectSource, rect0, rectDest; //Rectangles for where we are getting or putting images
        int tileSize = 33;                     //Tilesize in this program is 33 pixels
        int curX, curY;                        //For Current Position of sprite
        int moves;                             //Sprite makes 3 moves in the animation
        int smallMove = 11;                    //Each move is 11 pixels, for total of 33
        int direction;                         //Will hold (int)dir.___  See enum below.

        int[,] map = new int[10, 10];          //A 10 x 10 array to keep track of tile types
       
        //Enumerator - creates constants for specific words
        //Here you will get the corresponding values:
        //   0  dir.down
        //   1  dir.left
        //   2  dir.right
        //   3  dir.up
        //This order is based on the order of the images in the spritemap
        //We can multiply the dir by tileSize to grab images from the correct row of the spritemap
        enum dir
        {
            down,
            left,
            right,
            up
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //depending on which arrow key is pressed, choose a direction (actual value will be a number from 0 to 3)
            //also check the destination tile to make sure it is grass, not water

            if (tmrMove.Enabled == false)
            {
                int destTile = 99;              //default destTile is NOT WALKABLE
                //depending on key pressed, check the tile you would move to (get it's tile number from the map)
                if (e.KeyCode == Keys.Right)
                {
                    direction = (int)dir.right;
                    destTile = map[(curX + tileSize) / tileSize, curY / tileSize];
                }
                else if (e.KeyCode == Keys.Left)
                {
                    direction = (int)dir.left;
                    destTile = map[(curX - tileSize) / tileSize, curY / tileSize];
                }
                else if (e.KeyCode == Keys.Up)
                {
                    direction = (int)dir.up;
                    destTile = map[curX / tileSize, (curY - tileSize) / tileSize];
                }
                else if (e.KeyCode == Keys.Down)
                {
                    direction = (int)dir.down;
                    destTile = map[curX / tileSize, (curY + tileSize) / tileSize];
                }

                if (destTile == 0)             //grass - 0 - is only WALKABLE tile.
                {
                    moves = 0;
                    tmrMove.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You can't go there!");
                }
            }
 
        }

        //When enabled, makes the character take three small steps, cycling through the correct frames of the spritemap
        private void tmrMove_Tick(object sender, EventArgs e)
        {
            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            //Heal the backbuffer (this essentially erases your sprite from the backbuffer)
            gback.DrawImage(minibuffer,rectSource,rect0,GraphicsUnit.Pixel);

            //adjust x or y coordinates based on direction
            if (direction == (int)dir.right)
            {
                curX += smallMove;
            }
            else if (direction == (int)dir.left)
            {
                curX -= smallMove;
            }
            else if (direction == (int)dir.up)
            {
                curY -= smallMove;
            }
            else if (direction == (int)dir.down)
            {
                curY += smallMove;
            }

            //Preserve the area of the backbuffer that you intend to move to next
            rectSource = new Rectangle(curX,curY,tileSize,tileSize);
            gmini.DrawImage(backbuffer, rect0, rectSource, GraphicsUnit.Pixel);

            //Move your sprite onto the backbuffer at the preserved location
            //Notice the y-coordinate of where we grab our sprite is multiplied by the direction (0, 1, 2 or 3)
            rectDest = new Rectangle(moves*tileSize, direction*tileSize, tileSize, tileSize);
            gback.DrawImage(bmpGirl, rectSource, rectDest, GraphicsUnit.Pixel);
            this.Invalidate();

            //Track the number of mini-moves.  Stop after the 3rd one (because our spritemap has 3 frames)
            moves++;
            if (moves == 3)
            {
                tmrMove.Enabled = false;
            }

        }


        private void lblSave_Click(object sender, EventArgs e)
        {
            //yours to complete
        }

        private void lblLoad_Click(object sender, EventArgs e)
        {
            //yours to complete
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            //yours to complete
        }

        //Allows you to draw grass or water with your left and right mouse buttons
        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(backbuffer);
            int newX = e.X - e.X % tileSize;
            int newY = e.Y - e.Y % tileSize;

            //If you are not out of range of the form, draw water or grass
            if (e.X < 330 && e.X > 0 && e.Y < 330 && e.Y > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    g.DrawImage(bmpGrass, newX, newY, tileSize, tileSize);
                    map[newX / tileSize, newY / tileSize] = 0;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    g.DrawImage(bmpWater, newX, newY, tileSize, tileSize);
                    map[newX / tileSize, newY / tileSize] = 1;
                }

                g.Dispose();
                this.Invalidate();
            }
        }

        //Actually draws the contents of the backbuffer onto the form
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(backbuffer, 0, 0, backbuffer.Width, backbuffer.Height);
   
        }

         private void frmMain_Load(object sender, EventArgs e)
        {
            //Get all the bitmaps ready
            //The ClientRectangle is the usable area of your form. It doesn’t include borders.
            backbuffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            minibuffer = new Bitmap(tileSize, tileSize);
            bmpGirl = new Bitmap(frmG.picSprite.Image, 99, 132);
            bmpGirl.MakeTransparent(Color.White);
            bmpGrass = new Bitmap(frmG.picGrass.Image, tileSize, tileSize);
            bmpWater = new Bitmap(frmG.picWater.Image, tileSize, tileSize);

            //We can draw to these Graphics objects.
            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            //handy for stuff in top left corner
            rect0 = new Rectangle(0, 0, tileSize, tileSize);   

            //fill in the background with a default map  (will be all 0's so all grass)
            //later you can try loading a map from a file
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 10; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpGrass, rectDest, rect0, GraphicsUnit.Pixel);
                }
            }

            //Start off all rectangles in the top left corner where we plan to draw our sprite
            rectDest = new Rectangle(0, 0, tileSize, tileSize);
            rectSource = new Rectangle(0, 0, tileSize, tileSize);

            //Preserve the background behind your sprite before you draw the sprite
            gmini.DrawImage(backbuffer, rect0, rectSource, GraphicsUnit.Pixel);

            //Draw from the sprite into the backbuffer, to 0,0 from 0,0
            gback.DrawImage(bmpGirl, rectDest, rect0, GraphicsUnit.Pixel);

            curX = 0; //Current location is top left corner
            curY = 0;

            gback.Dispose();
            gmini.Dispose();
        }
    }
}
