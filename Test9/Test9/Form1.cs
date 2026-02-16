using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkToggle_CheckedChanged(object sender, EventArgs e)
        {
            bool state = chkToggle.Checked;
            lbl1.Visible = state;
            lbl2.Visible = state;
            txt1.Visible = state;
            txt2.Visible = state;
        }
    }
}
