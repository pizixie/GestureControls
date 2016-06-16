using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl2 : GestureUserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var c = sender as Control;

            MessageBox.Show(c.Text);
        }
    }
}
