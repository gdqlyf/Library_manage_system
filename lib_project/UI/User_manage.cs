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
    public partial class User_manage : Form
    {
        public static string id = "";
        public User_manage()
        {
            InitializeComponent();
        }
            private string UID;
            private string Uname;
            private string passwd;
            private string ON_passwd;
            private string identity;
            private string Utel;
            private string Umail;
            //private string Uphoto;
            private int borrowed;
            private int borrowing;
            private string URtime;
            private string effective;

            private void User_manage_Load(object sender, EventArgs e)
            {
                toolStripStatusLabel2.Text = id;
            }
            private void Panduan()
            {
                //判断
                if (UID_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入UID!");
                    return;
                }
                if (Uname_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入Uname!");
                    return;
                }
                if (passwd_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入passwd!");
                    return;
                }
                if (identity_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入identity!");
                    return;
                }
                if (Utel_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入Utel!");
                    return;
                }
                if (Umail_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入Umail!");
                    return;
                }
                if (borrowed_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入borrowed!");
                    return;
                }
                if (borrowing_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入borrowing!");
                    return;
                }
                if (URtime_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入URtime!");
                    return;
                }
                if (effective_user.Text.Trim() == "")
                {
                    MessageBox.Show("请输入 effective!");
                    return;
                }
            }

        //添加用户操作
        private void User_add_Click(object sender, EventArgs e)
        {
            //判断
            Panduan();
            //执行
            string UID = UID_user.Text.Trim();
            Users use = new Users();
            DataSet data = new DataSet();
             //读取textbox里的数据；
            UID = UID_user.Text.Trim();
            Uname = Uname_user.Text.Trim();
            passwd = passwd_user.Text.Trim();
            passwd = EncryptDES.strEncryptDES(passwd, "asdfghjkl");                //加密
            identity=identity_user.Text.Trim();
            Utel=Utel_user.Text.Trim();
            Umail=Umail_user.Text.Trim();
            borrowed = Convert.ToInt32(borrowed_user.Text.Trim());
            borrowing = Convert.ToInt32(borrowing_user.Text.Trim());
            URtime=URtime_user.Text.Trim();
            effective = effective_user.Text.Trim();
            bool TF = use.Insert(UID, Uname, passwd, identity, Utel, Umail, borrowed, borrowing, URtime, effective);
            if (TF == false)
            {
                MessageBox.Show("添加用户失败");
                return;
            }
            else
            {
                data = use.Data_deal(UID);
                Uname_user.Text = data.Tables["tables"].Rows[0]["Uname"].ToString();
                passwd_user.Text = data.Tables["tables"].Rows[0]["passwd"].ToString();
                identity_user.Text = data.Tables["tables"].Rows[0]["identity"].ToString();
                Utel_user.Text = data.Tables["tables"].Rows[0]["Utel"].ToString();
                Umail_user.Text = data.Tables["tables"].Rows[0]["Umail"].ToString();
                borrowed_user.Text = data.Tables["tables"].Rows[0]["borrowed"].ToString();
                borrowing_user.Text = data.Tables["tables"].Rows[0]["borrowing"].ToString();
                URtime_user.Text = data.Tables["tables"].Rows[0]["URtime"].ToString();
                effective_user.Text = data.Tables["tables"].Rows[0]["effective"].ToString();

                userView.DataSource = data.Tables["tables"];
                userView.Show();             
            }
         
        }
        
        //删除用户信息
        private void User_delete_Click(object sender, EventArgs e)
        {
            string UID = UID_user.Text.Trim();
            Users use = new Users();
            DataSet data = new DataSet();
            bool TF = use.Delete(UID); ;
            if (TF == false)
            {
                MessageBox.Show("删除用户失败");
                return;
            }
            else
            {
                data = use.Data_deal(UID);
                MessageBox.Show("删除用户成功");
                UID_user.Text = "";
                Uname_user.Text = "";
                passwd_user.Text = "";
                identity_user.Text = "";
                Utel_user.Text = "";
                Umail_user.Text = "";
                borrowed_user.Text = "";
                borrowing_user.Text = "";
                URtime_user.Text = "";
                effective_user.Text = "";
               
            }
        }
        //用户查询
        private void User_query_Click_1(object sender, EventArgs e)
        {

            string UID = UID_user.Text.Trim();
            Users use = new Users();
            DataSet data = new DataSet();
            bool TF = use.Select(UID);
            if (TF == false)
            {
                MessageBox.Show("查询用户失败");
                return;
            }
            else
            {
                data = use.Data_deal(UID);
                Uname_user.Text = data.Tables["tables"].Rows[0]["Uname"].ToString();
                passwd_user.Text = data.Tables["tables"].Rows[0]["passwd"].ToString();
                ON_passwd = passwd_user.Text;
                identity_user.Text = data.Tables["tables"].Rows[0]["identity"].ToString();
                Utel_user.Text = data.Tables["tables"].Rows[0]["Utel"].ToString();
                Umail_user.Text = data.Tables["tables"].Rows[0]["Umail"].ToString();
                borrowed_user.Text = data.Tables["tables"].Rows[0]["borrowed"].ToString();
                borrowing_user.Text = data.Tables["tables"].Rows[0]["borrowing"].ToString();
                URtime_user.Text = data.Tables["tables"].Rows[0]["URtime"].ToString();
                effective_user.Text = data.Tables["tables"].Rows[0]["effective"].ToString();
                userView.DataSource = data.Tables["tables"];
                userView.Show(); 
            }

        }
        //修改用户信息
        private void User_modity_Click(object sender, EventArgs e)
        {
            Users use = new Users();
            DataSet data = new DataSet();
            //判断
            Panduan();
            //执行
            UID = UID_user.Text.Trim();
            Uname = Uname_user.Text.Trim();
            passwd = passwd_user.Text.Trim();
            if (passwd != ON_passwd)//加密  
            {
                ON_passwd = passwd;
                passwd = EncryptDES.strEncryptDES(passwd, "asdfghjkl");
            }                            
            identity = identity_user.Text.Trim();
            Utel = Utel_user.Text.Trim();
            Umail = Umail_user.Text.Trim();
            borrowed = Convert.ToInt32(borrowed_user.Text.Trim());
            borrowing = Convert.ToInt32(borrowing_user.Text.Trim());
            URtime = URtime_user.Text.Trim();
            effective = effective_user.Text.Trim();
            use.Delete(UID);
            bool TF = use.Insert(UID, Uname, passwd, identity, Utel, Umail, borrowed, borrowing, URtime, effective);
            if (TF == false)
            {
                MessageBox.Show("修改用户失败");
            }
            else
            {
                data = use.Data_deal(UID);
                Uname_user.Text = data.Tables["tables"].Rows[0]["Uname"].ToString();
                passwd_user.Text = data.Tables["tables"].Rows[0]["passwd"].ToString();
                identity_user.Text = data.Tables["tables"].Rows[0]["identity"].ToString();
                Utel_user.Text = data.Tables["tables"].Rows[0]["Utel"].ToString();
                Umail_user.Text = data.Tables["tables"].Rows[0]["Umail"].ToString();
                borrowed_user.Text = data.Tables["tables"].Rows[0]["borrowed"].ToString();
                borrowing_user.Text = data.Tables["tables"].Rows[0]["borrowing"].ToString();
                URtime_user.Text = data.Tables["tables"].Rows[0]["URtime"].ToString();
                effective_user.Text = data.Tables["tables"].Rows[0]["effective"].ToString();
                userView.DataSource = data.Tables["tables"];
                userView.Show();
            }

        }

        private void Uphoto_user_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Start();
            toolStripStatusLabel4.Text = "当前时间："+ DateTime.Now;
        }
    }
}
