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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
            pictureBox2.Image = imageList1.Images[1];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
            pictureBox1.Image = imageList1.Images[3];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = imageList2.Images[1];
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_Click(object sender, EventArgs e)
        {
            if(a==1)
            {
                textBox2.Text = "";
                a++;
            }
            
            
        }



       
    }
}
