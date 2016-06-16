using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = flowLayoutPanel1.ClientRectangle;
            var b = flowLayoutPanel1.DisplayRectangle;

            flowLayoutPanel1.VerticalScroll.Value -= 1000;
        }
    }
}
