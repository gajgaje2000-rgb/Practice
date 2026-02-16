using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        // 1. Declare this variable to track turns (True = X, False = O)
        bool isXTurn = true;

        public Form1()
        {
            InitializeComponent();
        }

        // 2. Double click btnStart and paste this code
        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Clear old buttons if restarting
            int x = 0;
            int y = 0;

            // Loop to create 9 buttons dynamically
            for (int i = 0; i < 9; i++)
            {
                Button btn = new Button();
                btn.Width = 60;
                btn.Height = 60;
                btn.Location = new Point(x, y);
                btn.Font = new Font("Arial", 24, FontStyle.Bold); // Make text big

                // IMPORTANT: Link the click event to our custom function
                btn.Click += new EventHandler(DynamicButton_Click);

                panel1.Controls.Add(btn);

                // Logic to move to next column/row
                x += 60;
                if ((i + 1) % 3 == 0) // Every 3 buttons, move to new row
                {
                    x = 0;
                    y += 60;
                }
            }
        }

        // 3. Manually copy-paste this function OUTSIDE the btnStart_Click
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            // Determine which letter to put
            if (isXTurn)
                clickedBtn.Text = "X";
            else
                clickedBtn.Text = "O";

            clickedBtn.Enabled = false; // Disable button so it can't be clicked again
            isXTurn = !isXTurn; // Flip the turn
        }
    }
}
