using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            txtResult.Text = (n1 + n2).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            txtResult.Text = (n1 - n2).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            txtResult.Text = (n1 * n2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            txtResult.Text = (n1 / n2).ToString();
        }
    }
}
