using System;
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
        }

        private void samVaccaroButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Sam Vaccaro's Button!");
        }

        private void AngelWongButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Angel's bio");
        }

        private void tylerSharpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Tyler Sharp's bio");
        }

        private void JakeKampfButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Jake Kampf's bio.");
        }

        private void victoriaTangButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Victoria Tang's bio.");
        }

        private void NateGauthierButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Nate's bio");
        }
    }
}
