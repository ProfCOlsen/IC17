﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int y = 0;
            int x = 0;
        }

        private void chadHayesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Chad Hayes Button Bio");
        }

        private void raajpaalGohlwarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Raaj Paal Button Bio");
        }

        private void jKellyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is John Kelly's Button Bio");
        }

        private void HaydenBurnsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Hayden Burns's Bio.");
        }

        private void jessicaSheldonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Jessica Sheldon's bio:");
        }
    }
}
