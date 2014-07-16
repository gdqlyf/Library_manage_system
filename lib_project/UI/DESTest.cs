using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lib_project
{
    public partial class DESTest : Form
    {
        public DESTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = EncryptDES.strEncryptDES(textBox1.Text.Trim(), "asdfghjkl");
        }
    }
}
