using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void userControl11_Gesture(object sender, GestureEventArgs e)
        {
            listBox1.Items.Add(e.X + ":" + e.Y);
            //MessageBox.Show(e.X + ":" + e.Y);

            ///手势方向应该与滚动方向一致，但是这里存在一个BUG。无法使用它们行为一致，
            ///当尝试设置他们行为一致时，e.x和e.y的值会正负变化，导致滚动条随意滚动。
            ///同时，不要尝试使用AutoScrollPosition设置滚动条值。
            ///因为此属性的行为很诡异。

            //var y = Math.Abs(flowLayoutPanel1.AutoScrollPosition.Y);
            //y += e.Y;
            //flowLayoutPanel1.AutoScrollPosition = new Point(0, y);

            var v = flowLayoutPanel1.VerticalScroll.Value;

            v += e.Y;

            if (v > flowLayoutPanel1.VerticalScroll.Maximum)
                v = flowLayoutPanel1.VerticalScroll.Maximum;

            if (v < flowLayoutPanel1.VerticalScroll.Minimum)
                v = flowLayoutPanel1.VerticalScroll.Minimum;

            flowLayoutPanel1.VerticalScroll.Value = v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //MessageBox.Show(flowLayoutPanel1.AutoScrollPosition.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(0, -10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(0, 100);
        }
    }
}
