//Team Project for CIS345 @ 1030
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
            int x = 0;
            int y = 0;
        }

        private void andrewGBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey this is Andrew Gomez's Bio");
        }

        private void dieuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Dieu Dang's bio.");
        }

        private void ZhixinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is Zhixin Wang.");
        }
    }
}
