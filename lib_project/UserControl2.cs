using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lib_project
{
    public partial class Control_jieyue : UserControl
    {

        public string aa;
        public Control_jieyue()
        {
            InitializeComponent();
        }


        public void UserControl2_Load(object sender, EventArgs e)
        {
            this.label1.Text=aa;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            xiangxi one = new xiangxi();
            one.Show();
        }
    }
}
