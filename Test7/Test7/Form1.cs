using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Rich Text Format|*.rtf|Text Files|*.txt"; // Allow .rtf or .txt
            saveDlg.DefaultExt = "rtf";

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                // This saves the file to the chosen location
                richTextBox1.SaveFile(saveDlg.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("File Saved Successfully!");
            }
        }
    }
}
