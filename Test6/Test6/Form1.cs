using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDates.Items.Clear();
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            while (start <= end)
            {
                lstDates.Items.Add(start.ToShortDateString());
                start = start.AddDays(1);
            }
        }
    }
}
