using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountVowelsModularized
{
    public partial class Form1 : Form
    {
        int numberAs, numberEs, numberIs, numberOs, numberUs = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            string textToParse = txtInput.Text.ToLowerInvariant();
            txtInput.Text = "";
            //loop or recurse on each letter
            foreach (char aeiou in textToParse)
            {
                switch(aeiou)
                {
                    case 'a':
                        numberAs++;
                        break;
                    case 'e':
                        numberEs++;
                        break;
                    case 'i':
                        numberIs++;
                        break;
                    case 'o':
                        numberOs++;
                        break;
                    default:
                        numberUs++;
                        break;
                }
            }
            lblOutput.Text += "There were " + numberAs + " a's in the text.\n";
            lblOutput.Text += "There were " + numberEs + " e's in the text.\n";
            lblOutput.Text += "There were " + numberIs + " i's in the text.\n";
            lblOutput.Text += "There were " + numberOs + " o's in the text.\n";
            lblOutput.Text += "There were " + numberUs + " u's in the text.\n";
        }
    }
}
