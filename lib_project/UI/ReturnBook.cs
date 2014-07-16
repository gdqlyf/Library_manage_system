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
    public partial class ReturnBook : UserControl
    {
        public string bookid;
        public string userid;
        public string book_name;
        public string book_author;
        public byte[] photo;
        public string Btime;
        public string Rtime;
        public bool havephoto;
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            BookName.Text = book_name;
            BookAuthor.Text = book_author;
            BorrowTime.Text = Btime;
            ReturnTime.Text = Rtime;
            if (havephoto == true)
            {
                MemoryStream memStream = null;
                memStream = new MemoryStream(photo); //字节流转换为内存流
                pictureBox1.Image = null;
                pictureBox1.Image = Image.FromStream(memStream);//内存流转换为照片
            }
        }

        private void guihuan_Click(object sender, EventArgs e)
        {
            bool isreturn = lend.return_book(userid, bookid);
            if(isreturn == true)
            {
                MessageBox.Show("还书成功,请刷新查看");
            }
            else
            {
                MessageBox.Show("还书失败");
            }
        }

        private void xujie_Click(object sender, EventArgs e)
        {
            TimeSpan days = Convert.ToDateTime(Rtime) - Convert.ToDateTime(Btime);
            if(days.Days>100)
            {
                MessageBox.Show("已到续借最大时间，请尽快还书");
            }
            else
            {
                bool result = lend.renew_book(userid, bookid);
                if (result == true)
                    MessageBox.Show("续借成功,请刷新查看");
                else
                    MessageBox.Show("续借出错");
            }
        }

    }
}
