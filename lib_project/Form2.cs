using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace lib_project
{
    public partial class Form2 : Form
    {
        #region 窗体边框阴影效果变量申明

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-32);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        #endregion
        public static string ID;
        public static string name;
        public Form2()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void panel_heard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void panel_heard_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void panel_heard_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "书籍查询";
            pictureBox3.Image = imageList_book_sidbar.Images[0];
            pictureBox4.Image = imageList_book_sidbar.Images[7];
            pictureBox5.Image = imageList_book_sidbar.Images[5];
            pictureBox6.Image = imageList_book_sidbar.Images[3];
            this.tc_book.SelectedIndex = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "书籍借阅";
            pictureBox3.Image = imageList_book_sidbar.Images[1];
            pictureBox4.Image = imageList_book_sidbar.Images[6];
            pictureBox5.Image = imageList_book_sidbar.Images[5];
            pictureBox6.Image = imageList_book_sidbar.Images[3];
            this.tc_book.SelectedIndex = 1;

            if (panel_jieyue.Controls.Count == 0)
                MessageBox.Show("你还没有查询书籍，请返回查询。");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "书籍推荐";
            pictureBox3.Image = imageList_book_sidbar.Images[1];
            pictureBox4.Image = imageList_book_sidbar.Images[7];
            pictureBox5.Image = imageList_book_sidbar.Images[4];
            pictureBox6.Image = imageList_book_sidbar.Images[3];
            this.tc_book.SelectedIndex = 2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.panel_guihuan.Controls.Clear();
            label1.Text = "书籍归还";
            pictureBox3.Image = imageList_book_sidbar.Images[1];
            pictureBox4.Image = imageList_book_sidbar.Images[7];
            pictureBox5.Image = imageList_book_sidbar.Images[5];
            pictureBox6.Image = imageList_book_sidbar.Images[2];
            this.tc_book.SelectedIndex = 3;

            for (int i = 0; i < 10; i++)
            {

                Control_guihuan bbb = new Control_guihuan();
                bbb.Name = i.ToString();
                if (i % 2 == 0)
                    bbb.BackColor = SystemColors.ButtonHighlight;
                else
                    bbb.BackColor = SystemColors.ButtonShadow;
                this.panel_guihuan.Controls.Add(bbb);
                bbb.Location = new Point(0, 0 + i * 120);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void button_serch_MouseLeave(object sender, EventArgs e)
        {
            button_serch.BackgroundImage = imageList_buttun_serch.Images[1];
        }

        private void button_serch_MouseDown(object sender, MouseEventArgs e)
        {
            button_serch.BackgroundImage = imageList_buttun_serch.Images[0];
        }

        private void button_serch_Click(object sender, EventArgs e)
        {





            this.panel_jieyue.Controls.Clear();
            string serch;
            serch = textbox_heard_serch.Text;
            this.tc_book.SelectedIndex = 1;
            label1.Text = "书籍借阅";
            pictureBox3.Image = imageList_book_sidbar.Images[1];
            pictureBox4.Image = imageList_book_sidbar.Images[6];
            pictureBox5.Image = imageList_book_sidbar.Images[5];
            pictureBox6.Image = imageList_book_sidbar.Images[3];




            for (int i = 0; i < 10; i++)
            {

                Control_jieyue bbb = new Control_jieyue();
                bbb.Name = i.ToString();
                bbb.aa = "这是一个啦啦啦";
                if (i % 2 == 0)
                    bbb.BackColor = SystemColors.ButtonHighlight;
                else
                    bbb.BackColor = SystemColors.ButtonShadow;
                this.panel_jieyue.Controls.Add(bbb);
                bbb.Location = new Point(0, 0 + i * 120);
            }

            this.tc_book.SelectedIndex = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_shuji_Click(object sender, EventArgs e)
        {
            this.tc_heard.SelectedIndex = 0;
            pictureBox_shuji.Image = imageList_tc_heard.Images[0];
            pictureBox_geren.Image = imageList_tc_heard.Images[3];
        }

        private void pictureBox_geren_Click(object sender, EventArgs e)
        {
            this.tc_heard.SelectedIndex = 1;
            pictureBox_shuji.Image = imageList_tc_heard.Images[1];
            pictureBox_geren.Image = imageList_tc_heard.Images[2];
        }

        private void panel_heard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jiangousql = textBox2.Text + " from " + label4.Text.Trim() + label2.Text.Trim() + "\n";
            FileStream MyBase=new FileStream(Directory.GetCurrentDirectory()+@"\jiangou.txt",FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter Myfile=new StreamWriter((Stream)MyBase,System.Text.Encoding.Default);
            Myfile.Write(jiangousql);
            Myfile.Flush();
            Myfile.Close();
            MessageBox.Show("推荐成功", "提示");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = ID;
            label2.Text = name;
        }
    }
}
