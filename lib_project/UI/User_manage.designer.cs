namespace lib_project
{
    partial class User_manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_manage));
            this.Reader_message = new System.Windows.Forms.GroupBox();
            this.userView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.User_message = new System.Windows.Forms.GroupBox();
            this.UID_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User_query = new System.Windows.Forms.Button();
            this.passwd_user = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.User_delete = new System.Windows.Forms.Button();
            this.User_modity = new System.Windows.Forms.Button();
            this.User_add = new System.Windows.Forms.Button();
            this.effective_user = new System.Windows.Forms.TextBox();
            this.URtime_user = new System.Windows.Forms.TextBox();
            this.borrowed_user = new System.Windows.Forms.TextBox();
            this.borrowing_user = new System.Windows.Forms.TextBox();
            this.账户有效期 = new System.Windows.Forms.Label();
            this.注册日期 = new System.Windows.Forms.Label();
            this.可借量 = new System.Windows.Forms.Label();
            this.已借量 = new System.Windows.Forms.Label();
            this.照片 = new System.Windows.Forms.Label();
            this.Uphoto_user = new System.Windows.Forms.PictureBox();
            this.Utel_user = new System.Windows.Forms.TextBox();
            this.Umail_user = new System.Windows.Forms.TextBox();
            this.identity_user = new System.Windows.Forms.ComboBox();
            this.Uname_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reader_message.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.User_message.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uphoto_user)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reader_message
            // 
            this.Reader_message.Controls.Add(this.userView);
            this.Reader_message.Controls.Add(this.bindingNavigator1);
            this.Reader_message.Location = new System.Drawing.Point(12, 222);
            this.Reader_message.Name = "Reader_message";
            this.Reader_message.Size = new System.Drawing.Size(592, 184);
            this.Reader_message.TabIndex = 9;
            this.Reader_message.TabStop = false;
            this.Reader_message.Text = "所有读者信息";
            // 
            // userView
            // 
            this.userView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userView.Location = new System.Drawing.Point(8, 45);
            this.userView.Name = "userView";
            this.userView.RowTemplate.Height = 23;
            this.userView.Size = new System.Drawing.Size(573, 133);
            this.userView.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(586, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // User_message
            // 
            this.User_message.Controls.Add(this.UID_user);
            this.User_message.Controls.Add(this.label1);
            this.User_message.Controls.Add(this.User_query);
            this.User_message.Controls.Add(this.passwd_user);
            this.User_message.Controls.Add(this.label6);
            this.User_message.Controls.Add(this.User_delete);
            this.User_message.Controls.Add(this.User_modity);
            this.User_message.Controls.Add(this.User_add);
            this.User_message.Controls.Add(this.effective_user);
            this.User_message.Controls.Add(this.URtime_user);
            this.User_message.Controls.Add(this.borrowed_user);
            this.User_message.Controls.Add(this.borrowing_user);
            this.User_message.Controls.Add(this.账户有效期);
            this.User_message.Controls.Add(this.注册日期);
            this.User_message.Controls.Add(this.可借量);
            this.User_message.Controls.Add(this.已借量);
            this.User_message.Controls.Add(this.照片);
            this.User_message.Controls.Add(this.Uphoto_user);
            this.User_message.Controls.Add(this.Utel_user);
            this.User_message.Controls.Add(this.Umail_user);
            this.User_message.Controls.Add(this.identity_user);
            this.User_message.Controls.Add(this.Uname_user);
            this.User_message.Controls.Add(this.label5);
            this.User_message.Controls.Add(this.label4);
            this.User_message.Controls.Add(this.label3);
            this.User_message.Controls.Add(this.label2);
            this.User_message.Location = new System.Drawing.Point(12, 1);
            this.User_message.Name = "User_message";
            this.User_message.Size = new System.Drawing.Size(592, 215);
            this.User_message.TabIndex = 8;
            this.User_message.TabStop = false;
            this.User_message.Text = "用户详细信息";
            // 
            // UID_user
            // 
            this.UID_user.Location = new System.Drawing.Point(392, 20);
            this.UID_user.Name = "UID_user";
            this.UID_user.Size = new System.Drawing.Size(100, 21);
            this.UID_user.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "用户编号";
            // 
            // User_query
            // 
            this.User_query.Location = new System.Drawing.Point(506, 23);
            this.User_query.Name = "User_query";
            this.User_query.Size = new System.Drawing.Size(75, 23);
            this.User_query.TabIndex = 23;
            this.User_query.Text = "用户查询";
            this.User_query.UseVisualStyleBackColor = true;
            this.User_query.Click += new System.EventHandler(this.User_query_Click_1);
            // 
            // passwd_user
            // 
            this.passwd_user.Location = new System.Drawing.Point(218, 134);
            this.passwd_user.Name = "passwd_user";
            this.passwd_user.Size = new System.Drawing.Size(100, 21);
            this.passwd_user.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "密码";
            // 
            // User_delete
            // 
            this.User_delete.Location = new System.Drawing.Point(506, 149);
            this.User_delete.Name = "User_delete";
            this.User_delete.Size = new System.Drawing.Size(75, 23);
            this.User_delete.TabIndex = 20;
            this.User_delete.Text = "用户删除";
            this.User_delete.UseVisualStyleBackColor = true;
            this.User_delete.Click += new System.EventHandler(this.User_delete_Click);
            // 
            // User_modity
            // 
            this.User_modity.Location = new System.Drawing.Point(506, 111);
            this.User_modity.Name = "User_modity";
            this.User_modity.Size = new System.Drawing.Size(75, 23);
            this.User_modity.TabIndex = 19;
            this.User_modity.Text = "用户修改";
            this.User_modity.UseVisualStyleBackColor = true;
            this.User_modity.Click += new System.EventHandler(this.User_modity_Click);
            // 
            // User_add
            // 
            this.User_add.Location = new System.Drawing.Point(506, 70);
            this.User_add.Name = "User_add";
            this.User_add.Size = new System.Drawing.Size(75, 23);
            this.User_add.TabIndex = 18;
            this.User_add.Text = "用户添加";
            this.User_add.UseVisualStyleBackColor = true;
            this.User_add.Click += new System.EventHandler(this.User_add_Click);
            // 
            // effective_user
            // 
            this.effective_user.Location = new System.Drawing.Point(392, 174);
            this.effective_user.Name = "effective_user";
            this.effective_user.Size = new System.Drawing.Size(100, 21);
            this.effective_user.TabIndex = 17;
            // 
            // URtime_user
            // 
            this.URtime_user.Location = new System.Drawing.Point(392, 137);
            this.URtime_user.Name = "URtime_user";
            this.URtime_user.Size = new System.Drawing.Size(100, 21);
            this.URtime_user.TabIndex = 16;
            // 
            // borrowed_user
            // 
            this.borrowed_user.Location = new System.Drawing.Point(392, 62);
            this.borrowed_user.Name = "borrowed_user";
            this.borrowed_user.Size = new System.Drawing.Size(100, 21);
            this.borrowed_user.TabIndex = 15;
            // 
            // borrowing_user
            // 
            this.borrowing_user.Location = new System.Drawing.Point(392, 103);
            this.borrowing_user.Name = "borrowing_user";
            this.borrowing_user.Size = new System.Drawing.Size(100, 21);
            this.borrowing_user.TabIndex = 14;
            // 
            // 账户有效期
            // 
            this.账户有效期.AutoSize = true;
            this.账户有效期.Location = new System.Drawing.Point(324, 177);
            this.账户有效期.Name = "账户有效期";
            this.账户有效期.Size = new System.Drawing.Size(53, 12);
            this.账户有效期.TabIndex = 13;
            this.账户有效期.Text = "是否有效";
            // 
            // 注册日期
            // 
            this.注册日期.AutoSize = true;
            this.注册日期.Location = new System.Drawing.Point(324, 140);
            this.注册日期.Name = "注册日期";
            this.注册日期.Size = new System.Drawing.Size(53, 12);
            this.注册日期.TabIndex = 12;
            this.注册日期.Text = "注册日期";
            // 
            // 可借量
            // 
            this.可借量.AutoSize = true;
            this.可借量.Location = new System.Drawing.Point(324, 103);
            this.可借量.Name = "可借量";
            this.可借量.Size = new System.Drawing.Size(41, 12);
            this.可借量.TabIndex = 11;
            this.可借量.Text = "可借量";
            // 
            // 已借量
            // 
            this.已借量.AutoSize = true;
            this.已借量.Location = new System.Drawing.Point(324, 65);
            this.已借量.Name = "已借量";
            this.已借量.Size = new System.Drawing.Size(41, 12);
            this.已借量.TabIndex = 10;
            this.已借量.Text = "已借量";
            // 
            // 照片
            // 
            this.照片.AutoSize = true;
            this.照片.Location = new System.Drawing.Point(183, 23);
            this.照片.Name = "照片";
            this.照片.Size = new System.Drawing.Size(29, 12);
            this.照片.TabIndex = 9;
            this.照片.Text = "照片";
            // 
            // Uphoto_user
            // 
            this.Uphoto_user.Image = global::lib_project.Properties.Resources.backgrond1;
            this.Uphoto_user.Location = new System.Drawing.Point(218, 23);
            this.Uphoto_user.Name = "Uphoto_user";
            this.Uphoto_user.Size = new System.Drawing.Size(100, 91);
            this.Uphoto_user.TabIndex = 8;
            this.Uphoto_user.TabStop = false;
            this.Uphoto_user.Click += new System.EventHandler(this.Uphoto_user_Click);
            // 
            // Utel_user
            // 
            this.Utel_user.Location = new System.Drawing.Point(70, 157);
            this.Utel_user.Name = "Utel_user";
            this.Utel_user.Size = new System.Drawing.Size(100, 21);
            this.Utel_user.TabIndex = 7;
            // 
            // Umail_user
            // 
            this.Umail_user.Location = new System.Drawing.Point(70, 113);
            this.Umail_user.Name = "Umail_user";
            this.Umail_user.Size = new System.Drawing.Size(100, 21);
            this.Umail_user.TabIndex = 6;
            // 
            // identity_user
            // 
            this.identity_user.FormattingEnabled = true;
            this.identity_user.Items.AddRange(new object[] {
            "学生",
            "研究生",
            "教师"});
            this.identity_user.Location = new System.Drawing.Point(70, 70);
            this.identity_user.Name = "identity_user";
            this.identity_user.Size = new System.Drawing.Size(100, 20);
            this.identity_user.TabIndex = 5;
            // 
            // Uname_user
            // 
            this.Uname_user.Location = new System.Drawing.Point(70, 26);
            this.Uname_user.Name = "Uname_user";
            this.Uname_user.Size = new System.Drawing.Size(100, 21);
            this.Uname_user.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "身份类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(670, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "当前管理员：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel3.Text = "当前时间";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // User_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 440);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Reader_message);
            this.Controls.Add(this.User_message);
            this.Name = "User_manage";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.User_manage_Load);
            this.Reader_message.ResumeLayout(false);
            this.Reader_message.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.User_message.ResumeLayout(false);
            this.User_message.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uphoto_user)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Reader_message;
        private System.Windows.Forms.DataGridView userView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox User_message;
        private System.Windows.Forms.Button User_delete;
        private System.Windows.Forms.Button User_modity;
        private System.Windows.Forms.Button User_add;
        private System.Windows.Forms.TextBox effective_user;
        private System.Windows.Forms.TextBox URtime_user;
        private System.Windows.Forms.TextBox borrowed_user;
        private System.Windows.Forms.TextBox borrowing_user;
        private System.Windows.Forms.Label 账户有效期;
        private System.Windows.Forms.Label 注册日期;
        private System.Windows.Forms.Label 可借量;
        private System.Windows.Forms.Label 已借量;
        private System.Windows.Forms.Label 照片;
        private System.Windows.Forms.PictureBox Uphoto_user;
        private System.Windows.Forms.TextBox Utel_user;
        private System.Windows.Forms.TextBox Umail_user;
        private System.Windows.Forms.ComboBox identity_user;
        private System.Windows.Forms.TextBox Uname_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UID_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button User_query;
        private System.Windows.Forms.TextBox passwd_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
    }
}