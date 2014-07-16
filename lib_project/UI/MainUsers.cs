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
using System.Data.SqlClient;

namespace lib_project
{
    public partial class MainUsers : Form
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
        private string booktype;
        private string password;
        public MainUsers()
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
            label1.Text = "书籍荐购";
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

            DataSet result = new DataSet();
            result = lend.select_uid(ID);

            for (int i = 0; i < result.Tables["tables"].Rows.Count; i++)
            {
                ReturnBook bbb = new ReturnBook();
                bbb.Name = i.ToString();
                bbb.bookid = result.Tables["tables"].Rows[i]["BID"].ToString();
                bbb.userid = ID;
                bbb.book_name = result.Tables["tables"].Rows[i]["Bname"].ToString();
                bbb.book_author = result.Tables["tables"].Rows[i]["author"].ToString();
                bbb.Btime = Convert.ToDateTime(result.Tables["tables"].Rows[i]["Ltime"]).ToShortDateString();
                bbb.Rtime = Convert.ToDateTime(result.Tables["tables"].Rows[i]["Rtime"]).ToShortDateString();

                if (result.Tables["tables"].Rows[i]["Bphoto"] != DBNull.Value)
                {
                    byte[] rephoto = (byte[])result.Tables["tables"].Rows[i]["Bphoto"];
                    bbb.photo = rephoto;
                    bbb.havephoto = true;
                }

                if (i % 2 == 0)
                    bbb.BackColor = SystemColors.ButtonHighlight;
                else
                    bbb.BackColor = SystemColors.ButtonShadow;
                this.panel_guihuan.Controls.Add(bbb);
                bbb.Location = new Point(0, 0 + i * 120);
            }
        }

        private void button_serch_MouseLeave(object sender, EventArgs e)
        {
            button_serch.BackgroundImage = imageList_buttun_serch.Images[1];
        }

        private void button_serch_MouseDown(object sender, MouseEventArgs e)
        {
            button_serch.BackgroundImage = imageList_buttun_serch.Images[0];
        }

        private void Show(DataSet result)
        {
            for (int i = 0; i < result.Tables["tables"].Rows.Count; i++)
            {
                SimpleBook FindBook = new SimpleBook();
                FindBook.Name = i.ToString();
                FindBook.userid = ID;
                FindBook.id = result.Tables["tables"].Rows[i]["BID"].ToString();
                FindBook.name = result.Tables["tables"].Rows[i]["Bname"].ToString();
                FindBook.jianjie = result.Tables["tables"].Rows[i]["introduction"].ToString();
                FindBook.shengyuliang = result.Tables["tables"].Rows[i]["remainNum"].ToString();

                if (result.Tables["tables"].Rows[i]["Bphoto"] != DBNull.Value)
                {
                    byte[] rephoto = (byte[])result.Tables["tables"].Rows[i]["Bphoto"];
                    FindBook.photo = rephoto;
                    FindBook.havephoto = true;
                }
                else
                    FindBook.havephoto = false;
                if (i % 2 == 0)
                    FindBook.BackColor = SystemColors.ButtonHighlight;
                else
                    FindBook.BackColor = SystemColors.ButtonShadow;
                this.panel_jieyue.Controls.Add(FindBook);
                FindBook.Location = new Point(0, 0 + i * 120);
            }
        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            DataSet result = new DataSet();
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入书名");
                return;
            }
            if(books.Select(textBox1.Text.Trim()) == false)
            {
                MessageBox.Show("无此书");
                return;
            }
            label6.Text = "为您推荐";
            result = books.Data_Refresh(textBox1.Text.Trim());
            booktype = result.Tables["tables"].Rows[0]["type"].ToString();
            this.panel_jieyue.Controls.Clear();
            string serch;
            serch = textbox_heard_serch.Text;
            this.tc_book.SelectedIndex = 1;
            label1.Text = "书籍借阅";
            pictureBox3.Image = imageList_book_sidbar.Images[1];
            pictureBox4.Image = imageList_book_sidbar.Images[6];
            pictureBox5.Image = imageList_book_sidbar.Images[5];
            pictureBox6.Image = imageList_book_sidbar.Images[3];
            Show(result);
            this.tc_book.SelectedIndex = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login_in = new login();
            login_in.Show();          
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
            
            Users users = new Users();
            label_UID.Text = ID;
            label_Uname.Text = name;
            DataSet result = new DataSet();
            result = users.Data_deal(ID);
            label_identity.Text = result.Tables["tables"].Rows[0]["identity"].ToString();
            label_borrowed.Text = result.Tables["tables"].Rows[0]["borrowed"].ToString();
            password = result.Tables["tables"].Rows[0]["passwd"].ToString();
            label_borrowing.Text = result.Tables["tables"].Rows[0]["borrowing"].ToString();
            label_Umail.Text = result.Tables["tables"].Rows[0]["Umail"].ToString();
            label_Utell.Text = result.Tables["tables"].Rows[0]["Utel"].ToString();

            byte effective = Convert.ToByte(result.Tables["tables"].Rows[0]["effective"]);
            if (effective == (byte)0)
                label_effective.Text = "有书超期，请找管理员";

            if (result.Tables["tables"].Rows[0]["Uphoto"] != DBNull.Value)
            {
                byte[] photo = (byte[])result.Tables["tables"].Rows[0]["Uphoto"];
                MemoryStream memStream = null;
                memStream = new MemoryStream(photo); //字节流转换为内存流
                pictureBox_Uphoto.Image = null;
                pictureBox_Uphoto.Image = Image.FromStream(memStream);//内存流转换为照片
            }

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

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor =  Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void textbox_heard_serch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Text = textbox_heard_serch.Text.Trim();
                button_serch_Click(null,null);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DataSet result = new DataSet();
            Books books=new Books();
            result = books.Data_freshs(booktype);
            panel_jieyue.Controls.Clear();
            Show(result);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void textbox_heard_serch_Click(object sender, EventArgs e)
        {
            if (textbox_heard_serch.Text == "请输入书名，回车查询")
                textbox_heard_serch.Text = null;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "请输入书名")
                textBox1.Text = null;
        }

        private void Passwd_Change_Click(object sender, EventArgs e)
        {
            if(old_passwd.Text == "" || new_passwd.Text == "" || news_passwd.Text == "")
            {
                MessageBox.Show("输入不可为空");
            }
            else if(new_passwd.Text != news_passwd.Text)
            {
                MessageBox.Show("两次密码不一样\n请重新输入");
            }
            else if(EncryptDES.strEncryptDES(old_passwd.Text.Trim(), "asdfghjkl") != password)
            {
                MessageBox.Show("旧密码输入错误");
            }
            else
            {
                Users users = new Users();
                if (users.Update(ID, EncryptDES.strEncryptDES(news_passwd.Text.Trim(), "asdfghjkl")) == true)
                    MessageBox.Show("密码修改成功");
                else
                    MessageBox.Show("密码修改失败");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            HelpForm helps = new HelpForm();
            helps.Show();
        }

    }
}
