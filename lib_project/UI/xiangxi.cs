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
    public partial class xiangxi : Form
    {
        public string userid;
        public string bookid;
        public byte[] photo;
        public xiangxi()
        {
            InitializeComponent();
        }

        private void xiangxi_Load(object sender, EventArgs e)
        {
            Books books = new Books();
            DataSet result = books.Data_fresh(bookid); 
            book_id.Text = "编号：" + bookid;
            book_name.Text = result.Tables["tables"].Rows[0]["Bname"].ToString();
            book_remain.Text = result.Tables["tables"].Rows[0]["remainNum"].ToString();
            book_isbn.Text = "ISBN：" + result.Tables["tables"].Rows[0]["ISBN"].ToString();
            book_xinxi.Text = "作者：" + result.Tables["tables"].Rows[0]["author"].ToString() + "\n\n"
                           + "出版社：" + result.Tables["tables"].Rows[0]["press"].ToString() + "\n\n"
                           + "类型：" + result.Tables["tables"].Rows[0]["type"].ToString() + "\n\n"
                           + "价格：" + result.Tables["tables"].Rows[0]["price"].ToString() + "\n\n"
                           + "出版日期：" + Convert.ToDateTime(result.Tables["tables"].Rows[0]["Btime"]).ToShortDateString() + "\n\n"
                           + "简单介绍：" + result.Tables["tables"].Rows[0]["introduction"].ToString() + "\n\n";
            if (result.Tables["tables"].Rows[0]["Bphoto"] != DBNull.Value)
            {
                byte[] rephoto = (byte[])result.Tables["tables"].Rows[0]["Bphoto"];
                MemoryStream memStream = null;
                memStream = new MemoryStream(photo); //字节流转换为内存流
                book_xiangxiphoto.Image = null;
                book_xiangxiphoto.Image = Image.FromStream(memStream);//内存流转换为照片
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            DataSet result = users.Data_deal(userid);
            byte effective = Convert.ToByte(result.Tables["tables"].Rows[0]["effective"]);
            if(effective == (byte)0)
            {
                MessageBox.Show("您有书超期或账号无效\n\t请联系管理员");
            }
            else
            {
                string out_str="";
                out_str = lend.borrowed_book(userid, bookid);
                MessageBox.Show(out_str);
                xiangxi_Load(null,null);
            }

        }
    }
}
