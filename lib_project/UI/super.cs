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
    public partial class super : Form
    {
        public super()
        {
            InitializeComponent();
        }

       // private string UAID;
        private string UAname;
        private string UApasswd;
        private string UAtel;
        private string UAmail;
       // private string BAID;
        private string BAname;
        private string BApasswd;
        private string BAtel;
        private string BAmail;

        private void User_manage_Load(object sender, EventArgs e)
        {

        }
        private void UA_Panduan()
        {
            //判断
            if (UAID_Admin.Text == "")
            {
                MessageBox.Show("请输入UAID!");
                return;
            }
            if (UAname_UAdmin.Text == "")
            {
                MessageBox.Show("请输入UAname!");
                return;
            }
            if ( UApasswd_UAdmin.Text == "")
            {
                MessageBox.Show("请输入UApassed!");
                return;
            }
            if (UAmail_UAdmin.Text== "")
            {
                MessageBox.Show("请输入UAmail!");
                return;
            }
            if (UAtel_Admin.Text == "")
            {
                MessageBox.Show("请输入UAtel!");
                return;
            }
        }
        private void BA_Panduan()
        {
            //判断
            if (BAID_BAdmin.Text == "")
            {
                MessageBox.Show("请输入BAID!");
                return;
            }
            if (BAname_BAdmin.Text == "")
            {
                MessageBox.Show("请输入BAname!");
                return;
            }
            if (BApasswd_BAdmin.Text == "")
            {
                MessageBox.Show("请输入BApassed!");
                return;
            }
            if (BAmail_BAdmin.Text == "")
            {
                MessageBox.Show("请输入BAmail!");
                return;
            }
            if (BAtel_BAdmin.Text == "")
            {
                MessageBox.Show("请输入BAtel!");
                return;
            }
        }
       
        //增加人员管理员信息
        private void UAdmin_add_Click(object sender, EventArgs e)
        {
            string UAID = UAID_Admin.Text.Trim();
            Admin ua = new Admin();
            DataSet data = new DataSet();
            //判断
            UA_Panduan();
            //执行
            UAname = UAname_UAdmin.Text.Trim();
            UApasswd = UApasswd_UAdmin.Text.Trim();
            UApasswd = EncryptDES.strEncryptDES(UApasswd, "asdfghjkl");                //加密
            UAmail = UAmail_UAdmin.Text.Trim();
            UAtel = UAtel_Admin.Text.Trim();
            bool TF = ua.UA_Insert(UAID, UAname, UApasswd, UAmail, UAtel);
            if (TF == false)
            {
                MessageBox.Show("增加用户管理员失败");
                MessageBox.Show("改编号已存在,或异常错误");
                return;
            }
            else
            {
                data = ua.UAData_deal(UAID);
                UAID_Admin.Text = data.Tables["tables"].Rows[0]["UAID"].ToString();
                UAname_UAdmin.Text = data.Tables["tables"].Rows[0]["UAname"].ToString();
                UApasswd_UAdmin.Text = data.Tables["tables"].Rows[0]["UApasswd"].ToString();
                UAmail_UAdmin.Text = data.Tables["tables"].Rows[0]["UAmail"].ToString();
                UAtel_Admin.Text = data.Tables["tables"].Rows[0]["UAtel"].ToString();

                userView.DataSource = data.Tables["tables"];
                userView.Show();
            }

        }
        //删除用户管理员信息
        private void UAdmin_delete_Click(object sender, EventArgs e)
        {
            string UAID = UAID_Admin.Text.Trim();
            Admin ua = new Admin();
            DataSet data = new DataSet();
            bool TF = ua.UA_Delete(UAID);
            if (TF == false)
            {
                MessageBox.Show("删除管理员信息失败");
                return;
            }
            else
            {
                MessageBox.Show("删除成功");
                UAID_Admin.Text = "";
                UAname_UAdmin.Text = "";
                UApasswd_UAdmin.Text = "";
                UAmail_UAdmin.Text = "";
                UAtel_Admin.Text = "";
            }
        }
        //查询用户管理员信息
        private void UAdmin_query_Click(object sender, EventArgs e)
        {
            string UAID = UAID_Admin.Text.Trim();
            Admin ua = new Admin();
            DataSet data = new DataSet();
            bool TF = ua.UA_Select(UAID);
            if (TF == false)
            {
                MessageBox.Show("查询管理员失败");
                return;
            }
            else
            {
                data = ua.UAData_deal(UAID);
                UAID_Admin.Text = data.Tables["tables"].Rows[0]["UAID"].ToString();
                UAname_UAdmin.Text = data.Tables["tables"].Rows[0]["UAname"].ToString();
                UApasswd_UAdmin.Text = data.Tables["tables"].Rows[0]["UApasswd"].ToString();
                UAmail_UAdmin.Text = data.Tables["tables"].Rows[0]["UAmail"].ToString();
                UAtel_Admin.Text = data.Tables["tables"].Rows[0]["UAtel"].ToString();

                userView.DataSource = data.Tables["tables"];
                userView.Show();
            }

        }
        //修改用户管理员信息
        private void UAdmin_modity_Click(object sender, EventArgs e)
        {
            string UAID = UAID_Admin.Text.Trim();
            Admin ua = new Admin();
            DataSet data = new DataSet();
            //判断
            UA_Panduan();
            //执行
            UAname = UAname_UAdmin.Text.Trim();
            UApasswd = UApasswd_UAdmin.Text.Trim();
            UApasswd = EncryptDES.strEncryptDES(UApasswd, "asdfghjkl");                //加密
            UAmail = UAmail_UAdmin.Text.Trim();
            UAtel = UAtel_Admin.Text.Trim();
            bool TF = ua.UA_Update(UAID, UAname, UApasswd, UAmail, UAtel);

            if (TF == false)
            {
                MessageBox.Show("修改用户失败");
            }
            else
            {
                data = ua.UAData_deal(UAID);
                UAID_Admin.Text = data.Tables["tables"].Rows[0]["UAID"].ToString();
                UAname_UAdmin.Text = data.Tables["tables"].Rows[0]["UAname"].ToString();
                UApasswd_UAdmin.Text = data.Tables["tables"].Rows[0]["UApasswd"].ToString();
                UAmail_UAdmin.Text = data.Tables["tables"].Rows[0]["UAmail"].ToString();
                UAtel_Admin.Text = data.Tables["tables"].Rows[0]["UAtel"].ToString();

                userView.DataSource = data.Tables["tables"];
                userView.Show();
            }
        }
        /******************************************************************************************/

        //增加图书馆管理员信息
        private void BAdmin_add_Click(object sender, EventArgs e)
        {
            String BAID = BAID_BAdmin.Text.Trim();
            Admin ba = new Admin();
            DataSet data = new DataSet();
            //判断
            BA_Panduan();
            //执行
            BAname = BAname_BAdmin.Text.Trim();
            BApasswd = BApasswd_BAdmin.Text.Trim();
            BApasswd = EncryptDES.strEncryptDES(BApasswd, "asdfghjkl");                //加密
            BAmail = BAmail_BAdmin.Text.Trim();
            BAtel = BAtel_BAdmin.Text.Trim();
            bool TF = ba.BA_Insert(BAID, BAname, BApasswd, BAmail, BAtel);
            if (TF == false)
            {
                MessageBox.Show("增加用户管理员失败");
            }
            else
            {
                data = ba.BAData_deal(BAID);
                BAID_BAdmin.Text = data.Tables["tables"].Rows[0]["BAID"].ToString();
                BAname_BAdmin.Text = data.Tables["tables"].Rows[0]["BAname"].ToString();
                BApasswd_BAdmin.Text = data.Tables["tables"].Rows[0]["BApasswd"].ToString();
                BAmail_BAdmin.Text = data.Tables["tables"].Rows[0]["BAmail"].ToString();
                BAtel_BAdmin.Text = data.Tables["tables"].Rows[0]["BAtel"].ToString();
                MessageBox.Show("增加成功");
                bookView.DataSource = data.Tables["tables"];
                bookView.Show();

            }
        }
        //删除图书管理员信息
        private void BAdmin_delete_Click(object sender, EventArgs e)
        {
            string BAID = BAID_BAdmin.Text.Trim();
            Admin ba = new Admin();
            DataSet data = new DataSet();
            bool TF = ba.BA_Delete(BAID);
            if (TF == false)
            {
                MessageBox.Show("删除管理员信息失败");
                return;
            }
            else
            {
                MessageBox.Show("删除成功");
                BAID_BAdmin.Text = "";
                BAname_BAdmin.Text = "";
                BApasswd_BAdmin.Text = "";
                BAmail_BAdmin.Text = "";
                BAtel_BAdmin.Text = "";
            }

        }
        //查询图书管理员信息
        private void Badmin_select_Click(object sender, EventArgs e)
        {
            string BAID = BAID_BAdmin.Text.Trim();
            Admin ba = new Admin();
            DataSet data = new DataSet();
            bool TF = ba.BA_Select(BAID);
            if (TF == false)
            {
                MessageBox.Show("查询管理员失败");
                return;
            }
            else
            {
                data = ba.BAData_deal(BAID);
                BAID_BAdmin.Text = data.Tables["tables"].Rows[0]["BAID"].ToString();
                BAname_BAdmin.Text = data.Tables["tables"].Rows[0]["BAname"].ToString();
                BApasswd_BAdmin.Text = data.Tables["tables"].Rows[0]["BApasswd"].ToString();
                BAmail_BAdmin.Text = data.Tables["tables"].Rows[0]["BAmail"].ToString();
                BAtel_BAdmin.Text = data.Tables["tables"].Rows[0]["BAtel"].ToString();

                bookView.DataSource = data.Tables["tables"];
                bookView.Show();
            }
        }
        //修改图书管理员信息
        private void BAdmin_modify_Click(object sender, EventArgs e)
        {
            string BAID = BAID_BAdmin.Text.Trim();
            Admin ba = new Admin();
            DataSet data = new DataSet();
            //判断
            BA_Panduan();
            //执行
            BAname = BAname_BAdmin.Text.Trim();
            BApasswd = BApasswd_BAdmin.Text.Trim();
            BApasswd = EncryptDES.strEncryptDES(BApasswd, "asdfghjkl");                //加密
            BAmail = BAmail_BAdmin.Text.Trim();
            BAtel = BAtel_BAdmin.Text.Trim();
            bool TF = ba.BA_Update(BAID, BAname, BApasswd, BAmail, BAtel);
            if (TF == false)
            {
                MessageBox.Show("修改用户失败");
            }
            else
            {
                data = ba.BAData_deal(BAID);
                BAID_BAdmin.Text = data.Tables["tables"].Rows[0]["BAID"].ToString();
                BAname_BAdmin.Text = data.Tables["tables"].Rows[0]["BAname"].ToString();
                BApasswd_BAdmin.Text = data.Tables["tables"].Rows[0]["BApasswd"].ToString();
                BAmail_BAdmin.Text = data.Tables["tables"].Rows[0]["BAmail"].ToString();
                BAtel_BAdmin.Text = data.Tables["tables"].Rows[0]["BAtel"].ToString();

                bookView.DataSource = data.Tables["tables"];
                bookView.Show();
            }
        }       
    }
}
