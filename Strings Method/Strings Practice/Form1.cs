using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Practice
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string phrase;
            string newPhrase;
            int num;
            bool found;

            phrase = "This is" + " crazy!";
            lstbox1.Items.Add(phrase);
            phrase = phrase.ToLower();
            lstbox1.Items.Add(phrase);
            phrase = phrase.ToUpper();
            lstbox1.Items.Add(phrase);
            num = phrase.Length;
            lstbox1.Items.Add(num);
            num = phrase.Count();
            lstbox1.Items.Add(num);
            newPhrase = phrase.Substring(5, 9);
            lstbox1.Items.Add(newPhrase);
            newPhrase = phrase.Replace("S", "5");
            newPhrase = newPhrase.Replace("A", "@");
            lstbox1.Items.Add(newPhrase);
            found = phrase.Contains("CRA");
            lstbox1.Items.Add(found);
            num = phrase.IndexOf("CRA");
            lstbox1.Items.Add(num);
            newPhrase = "   I don't like spaces.    ";
            newPhrase = newPhrase.Trim();
            lstbox1.Items.Add(newPhrase);
        }
    }
}
