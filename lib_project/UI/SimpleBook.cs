using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lib_project
{
    public partial class SimpleBook : UserControl
    {
        public string userid;
        public string id;
        public string name;
        public string jianjie;
        public string shengyuliang;
        public byte [] photo;
        public DataSet result;
        public bool havephoto;
        public SimpleBook()
        {
            InitializeComponent();
        }


        public void UserControl2_Load(object sender, EventArgs e)
        {
            this.label1.Text = name;
            this.label2.Text = jianjie;
            this.label4.Text = shengyuliang;
            this.label5.Text = id;
            if (havephoto == true)
            {
                MemoryStream memStream = null;
                memStream = new MemoryStream(photo); //字节流转换为内存流
                pictureBox1.Image = null;
                pictureBox1.Image = Image.FromStream(memStream);//内存流转换为照片
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xiangxi one = new xiangxi();
            one.bookid = label5.Text.Trim();
            one.userid = userid;
            one.Show();
        }
    }
}
