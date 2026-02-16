using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string vowels = "aeiouAEIOU";
            if (vowels.Contains(e.KeyChar.ToString()))
            {
                lblResult.Text = e.KeyChar + " is a Vowel";
            }
            else
            {
                lblResult.Text = e.KeyChar + " is a Consonant";
            }
        }
    }
}
