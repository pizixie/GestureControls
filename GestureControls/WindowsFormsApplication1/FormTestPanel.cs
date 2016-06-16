using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormTestPanel : Form
    {
        public FormTestPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var y = flowLayoutPanel1.AutoScrollPosition.Y;

            var v = Math.Abs(y);

            v += 10;

            flowLayoutPanel1.AutoScrollPosition = new Point(0, v);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var y = flowLayoutPanel1.AutoScrollPosition.Y;

            var v = Math.Abs(y);

            v -= 10;

            flowLayoutPanel1.AutoScrollPosition = new Point(0, v);
        }
    }
}
