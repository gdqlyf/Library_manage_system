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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(Directory.GetCurrentDirectory() + @"/help.rtf",RichTextBoxStreamType.RichText);
            richTextBox2.LoadFile(Directory.GetCurrentDirectory() + @"/instructions.rtf", RichTextBoxStreamType.RichText);
        }
    }
}
