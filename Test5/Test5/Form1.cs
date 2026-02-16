using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Black)
                textBox1.ForeColor = Color.Red; // Or use txtBlink.Visible = !txtBlink.Visible
            else
                textBox1.ForeColor = Color.Black;
        }
    }
}
