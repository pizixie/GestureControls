using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseWheel += listView1_MouseWheel;
            panel3.MouseWheel += listView1_MouseWheel;
        }

        void listView1_MouseWheel(object sender, MouseEventArgs e)
        {
            //Console.WriteLine(e.Delta);

            HandledMouseEventArgs h = e as HandledMouseEventArgs;

            //Console.WriteLine(h.Handled);

            listBox1.Items.Add(e.Delta);
            listBox1.Items.Add(h.Handled);


            //h.Handled = true;
            //if (h != null)
            //{
            //    h.Handled = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel3.Focus();

            //this.Activate();

            //checkBox1.Select();

            panel1.Select();
        }
    }
}
