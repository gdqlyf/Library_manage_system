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
    public partial class login : Form
    {
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        public string deskey = "asdfghjkl"; //加密密钥
        public login()
        {
            InitializeComponent();
        }

        public byte isUser = 1;

        private void UsersBox_Click(object sender, EventArgs e)
        {
            UsersBox.Image = imageList1.Images[2];
            ManageBox.Image = imageList1.Images[1];
            isUser = 1;
        }

        private void ManageBox_Click(object sender, EventArgs e)
        {
            ManageBox.Image = imageList1.Images[0];
            UsersBox.Image = imageList1.Images[3];
            isUser = 0;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            ExitBox.Image = imageList2.Images[1];
            Application.Exit();
        }

        private void resertbox_Click(object sender, EventArgs e)
        {
            id.Text = null;
            password.Text = null;
        }

        private void loginbox_Click(object sender, EventArgs e)
        {
            string encryptpasswd = EncryptDES.strEncryptDES(password.Text.Trim(),deskey);
            bool isUserLogin = Login_in.Userlogin(id.Text.Trim(), encryptpasswd);
            char isAdminLogin = Login_in.Managelogin(id.Text.Trim(), encryptpasswd);
            if (isUser == 1)
            {
                if (isUserLogin == true)
                {
                    MainUsers form2 = new MainUsers();
                    MainUsers.ID = id.Text.Trim();
                    MainUsers.name = "DSDSD";
                    form2.Show();
                }
                else
                    MessageBox.Show("没有此用户或用户密码错误", "提示");
            }
            else
            {
                if(isAdminLogin == (char)1)
                {

                }
                else if(isAdminLogin == (char)2)
                {

                }
                else if(isAdminLogin == (char)3)
                {

                }
                else
                    MessageBox.Show("没有此管理员或管理员密码错误", "提示");
            }
        }

        private void forgotlable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请找管理员！","密码找回");
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text.Trim() == "请输入密码")
            {
                password.Text = null;
                password.PasswordChar = '*';
            } 
        }

        private void id_Click(object sender, EventArgs e)
        {
            if (id.Text.Trim() == "请输入用户名")
            {
                id.Text = null;
            } 
        }   
    }
}
