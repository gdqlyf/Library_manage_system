namespace lib_project
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.ManageBox = new System.Windows.Forms.PictureBox();
            this.UsersBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.PictureBox();
            this.resertbox = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.forgotlable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resertbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "管理员登录1.png");
            this.imageList1.Images.SetKeyName(1, "管理员登录2.png");
            this.imageList1.Images.SetKeyName(2, "用户登录1.png");
            this.imageList1.Images.SetKeyName(3, "用户登录2.png");
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(193, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::lib_project.Properties.Resources.textbox;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.id);
            this.panel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(83, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 34);
            this.panel1.TabIndex = 3;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.id.Location = new System.Drawing.Point(16, 11);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(312, 20);
            this.id.TabIndex = 0;
            this.id.Text = "请输入用户名";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // ManageBox
            // 
            this.ManageBox.BackColor = System.Drawing.Color.Transparent;
            this.ManageBox.Image = global::lib_project.Properties.Resources.管理员登录2;
            this.ManageBox.Location = new System.Drawing.Point(284, 101);
            this.ManageBox.Name = "ManageBox";
            this.ManageBox.Size = new System.Drawing.Size(142, 36);
            this.ManageBox.TabIndex = 1;
            this.ManageBox.TabStop = false;
            this.ManageBox.Click += new System.EventHandler(this.ManageBox_Click);
            // 
            // UsersBox
            // 
            this.UsersBox.BackColor = System.Drawing.Color.Transparent;
            this.UsersBox.Image = global::lib_project.Properties.Resources.用户登录1;
            this.UsersBox.Location = new System.Drawing.Point(83, 101);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(142, 36);
            this.UsersBox.TabIndex = 0;
            this.UsersBox.TabStop = false;
            this.UsersBox.Click += new System.EventHandler(this.UsersBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::lib_project.Properties.Resources.textbox;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.password);
            this.panel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(83, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 34);
            this.panel2.TabIndex = 4;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(16, 11);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(312, 20);
            this.password.TabIndex = 0;
            this.password.Text = "请输入密码";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // loginbox
            // 
            this.loginbox.BackColor = System.Drawing.Color.Transparent;
            this.loginbox.Image = global::lib_project.Properties.Resources.登录2;
            this.loginbox.Location = new System.Drawing.Point(83, 302);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(142, 36);
            this.loginbox.TabIndex = 5;
            this.loginbox.TabStop = false;
            this.loginbox.Click += new System.EventHandler(this.loginbox_Click);
            // 
            // resertbox
            // 
            this.resertbox.BackColor = System.Drawing.Color.Transparent;
            this.resertbox.Image = ((System.Drawing.Image)(resources.GetObject("resertbox.Image")));
            this.resertbox.Location = new System.Drawing.Point(284, 302);
            this.resertbox.Name = "resertbox";
            this.resertbox.Size = new System.Drawing.Size(142, 36);
            this.resertbox.TabIndex = 6;
            this.resertbox.TabStop = false;
            this.resertbox.Click += new System.EventHandler(this.resertbox_Click);
            // 
            // ExitBox
            // 
            this.ExitBox.BackColor = System.Drawing.Color.Transparent;
            this.ExitBox.Image = global::lib_project.Properties.Resources.exit;
            this.ExitBox.Location = new System.Drawing.Point(479, 12);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(32, 32);
            this.ExitBox.TabIndex = 7;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "exit.png");
            this.imageList2.Images.SetKeyName(1, "exit1.png");
            // 
            // forgotlable
            // 
            this.forgotlable.AutoSize = true;
            this.forgotlable.BackColor = System.Drawing.Color.Transparent;
            this.forgotlable.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forgotlable.ForeColor = System.Drawing.Color.Red;
            this.forgotlable.Location = new System.Drawing.Point(83, 362);
            this.forgotlable.Name = "forgotlable";
            this.forgotlable.Size = new System.Drawing.Size(63, 14);
            this.forgotlable.TabIndex = 8;
            this.forgotlable.Text = "忘记密码";
            this.forgotlable.Click += new System.EventHandler(this.forgotlable_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lib_project.Properties.Resources.backgrond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 426);
            this.Controls.Add(this.forgotlable);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.resertbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ManageBox);
            this.Controls.Add(this.UsersBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resertbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UsersBox;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox ManageBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox loginbox;
        private System.Windows.Forms.PictureBox resertbox;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label forgotlable;

    }
}

