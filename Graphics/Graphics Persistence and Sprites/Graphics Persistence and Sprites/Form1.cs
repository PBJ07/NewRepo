using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Persistence_and_Sprites
{
    public partial class frmMain : Form
    {
        frmGraphics frmG = new frmGraphics();  //This is an instance of the second form
        Bitmap backBuffer;                     //This will hold the image to be drawn on the Form
        Bitmap miniBuffer;                     //For repairing the background

        Bitmap bmpSprite;                        //To hold image of your sprite character
        //Bitmap bmpGrass;
        //Bitmap bmpWater;
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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) //Form load
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Graphics gback, gmini;
            //The ClientRectangle is the usable area of your form. It doesn’t include borders.
            backBuffer = new Bitmap(frmG.picBack.Image,
                                    this.ClientRectangle.Width,
                                    this.ClientRectangle.Height);
            bmpSprite = new Bitmap(frmG.picSprite.Image, tileSize, tileSize);
            bmpSprite.MakeTransparent(Color.White);
            miniBuffer = new Bitmap(tileSize, tileSize);
            gback = Graphics.FromImage(backBuffer);
            gmini = Graphics.FromImage(miniBuffer);

            //Start off all rectangles in the top left corner
            rectDest = new Rectangle(0, 0, tileSize, tileSize);
            rectSource = new Rectangle(0, 0, tileSize, tileSize);
            rect0 = new Rectangle(0, 0, tileSize, tileSize);
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e) //Show the sprite 
        {
            Graphics gback = Graphics.FromImage(backBuffer);
            //First heal the old destination on the background
            gback.DrawImage(miniBuffer, rectDest, rect0, GraphicsUnit.Pixel);
            curX = e.X - e.X % tileSize;
            curY = e.Y - e.Y % tileSize;
            Graphics gmini = Graphics.FromImage(miniBuffer);
            rectDest = new Rectangle(curX, curY, tileSize, tileSize);
            gmini.DrawImage(backBuffer, rect0, rectDest, GraphicsUnit.Pixel);
            gback.DrawImage(bmpSprite, rectDest);
            this.Invalidate();  //force the form to repaint itself, or else you will not see any changes
            gback.Dispose();
            //Preserve the new location in the minibuffer before putting the sprite there
            gmini.Dispose();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e) //
        {
            Graphics g = e.Graphics;
            g.DrawImage(backBuffer, 0, 0, backBuffer.Width, backBuffer.Height);
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            Graphics gback = Graphics.FromImage(backBuffer);
            Graphics gmini = Graphics.FromImage(miniBuffer);

            //Heal the backbuffer (this essentially erases your sprite from the backbuffer)
            gback.DrawImage(miniBuffer, rectSource, rect0, GraphicsUnit.Pixel);

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
            rectSource = new Rectangle(curX, curY, tileSize, tileSize);
            gmini.DrawImage(backBuffer, rect0, rectSource, GraphicsUnit.Pixel);

            //Move your sprite onto the backbuffer at the preserved location
            //Notice the y-coordinate of where we grab our sprite is multiplied by the direction (0, 1, 2 or 3)
            rectDest = new Rectangle(moves * tileSize, direction * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpSprite, rectSource, rectDest, GraphicsUnit.Pixel);
            this.Invalidate();

            //Track the number of mini-moves.  Stop after the 3rd one (because our spritemap has 3 frames)
            moves++;
            if (moves == 3)
            {
                tmrMove.Enabled = false;
            }

        }
    }
}
