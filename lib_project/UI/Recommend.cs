using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lib_project
{
    public partial class Recommend : Form
    {
        public Recommend()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recommend_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(Directory.GetCurrentDirectory() + @"/jiangou.txt", RichTextBoxStreamType.PlainText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Modified)
            {
                richTextBox1.SaveFile(Directory.GetCurrentDirectory() + @"/jiangou.txt", RichTextBoxStreamType.PlainText);
                richTextBox1.Modified = false;
                MessageBox.Show("已修改成功");
            }
        }
    }
}
