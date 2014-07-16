namespace lib_project
{
    partial class ReturnBook
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.guihuan = new System.Windows.Forms.Button();
            this.BookName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BorrowTime = new System.Windows.Forms.Label();
            this.ReturnTime = new System.Windows.Forms.Label();
            this.xujie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guihuan
            // 
            this.guihuan.Location = new System.Drawing.Point(457, 60);
            this.guihuan.Name = "guihuan";
            this.guihuan.Size = new System.Drawing.Size(90, 45);
            this.guihuan.TabIndex = 9;
            this.guihuan.Text = "归还";
            this.guihuan.UseVisualStyleBackColor = true;
            this.guihuan.Click += new System.EventHandler(this.guihuan_Click);
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookName.Location = new System.Drawing.Point(146, 21);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(42, 16);
            this.BookName.TabIndex = 7;
            this.BookName.Text = "书名";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::lib_project.Properties.Resources.user_pict;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::lib_project.Properties.Resources.SkypeApp;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BookAuthor
            // 
            this.BookAuthor.AutoSize = true;
            this.BookAuthor.Location = new System.Drawing.Point(147, 53);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(29, 12);
            this.BookAuthor.TabIndex = 10;
            this.BookAuthor.Text = "作者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "借书日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "还书日期：";
            // 
            // BorrowTime
            // 
            this.BorrowTime.AutoSize = true;
            this.BorrowTime.Location = new System.Drawing.Point(305, 69);
            this.BorrowTime.Name = "BorrowTime";
            this.BorrowTime.Size = new System.Drawing.Size(53, 12);
            this.BorrowTime.TabIndex = 13;
            this.BorrowTime.Text = "借书时间";
            // 
            // ReturnTime
            // 
            this.ReturnTime.AutoSize = true;
            this.ReturnTime.Location = new System.Drawing.Point(305, 93);
            this.ReturnTime.Name = "ReturnTime";
            this.ReturnTime.Size = new System.Drawing.Size(53, 12);
            this.ReturnTime.TabIndex = 14;
            this.ReturnTime.Text = "还书时间";
            // 
            // xujie
            // 
            this.xujie.Location = new System.Drawing.Point(457, 12);
            this.xujie.Name = "xujie";
            this.xujie.Size = new System.Drawing.Size(90, 42);
            this.xujie.TabIndex = 15;
            this.xujie.Text = "续借";
            this.xujie.UseVisualStyleBackColor = true;
            this.xujie.Click += new System.EventHandler(this.xujie_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xujie);
            this.Controls.Add(this.ReturnTime);
            this.Controls.Add(this.BorrowTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.guihuan);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReturnBook";
            this.Size = new System.Drawing.Size(580, 120);
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guihuan;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BorrowTime;
        private System.Windows.Forms.Label ReturnTime;
        private System.Windows.Forms.Button xujie;
    }
}
