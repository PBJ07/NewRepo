using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes___Music
{
    //MusicGroup class
    internal class MusicGroup
    {
        //Properties
        public string BandName;
        public string Style;
        public int AlbumsReleased;

        public string ShowBandInfo() //method for dan name and style
        {
            return (BandName + " - " + Style);
        }

        public bool Superstar() //method for # of albums released
        {
            if (AlbumsReleased >= 10)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
