using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Oscillations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void зарядToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Charge().Show();
        }

        private void напругаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Voltage().Show();
        }
    }
}
