namespace lib_project
{
    partial class xiangxi
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
            this.button2 = new System.Windows.Forms.Button();
            this.book_xiangxiphoto = new System.Windows.Forms.PictureBox();
            this.book_remain = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.book_xinxi = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.Label();
            this.book_isbn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.book_xiangxiphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "借阅";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // book_xiangxiphoto
            // 
            this.book_xiangxiphoto.BackgroundImage = global::lib_project.Properties.Resources.user_pict;
            this.book_xiangxiphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.book_xiangxiphoto.Image = global::lib_project.Properties.Resources.SkypeApp;
            this.book_xiangxiphoto.Location = new System.Drawing.Point(12, 79);
            this.book_xiangxiphoto.Name = "book_xiangxiphoto";
            this.book_xiangxiphoto.Size = new System.Drawing.Size(198, 204);
            this.book_xiangxiphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.book_xiangxiphoto.TabIndex = 16;
            this.book_xiangxiphoto.TabStop = false;
            // 
            // book_remain
            // 
            this.book_remain.AutoSize = true;
            this.book_remain.Location = new System.Drawing.Point(96, 359);
            this.book_remain.Name = "book_remain";
            this.book_remain.Size = new System.Drawing.Size(17, 12);
            this.book_remain.TabIndex = 15;
            this.book_remain.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "剩余数：";
            // 
            // book_xinxi
            // 
            this.book_xinxi.Location = new System.Drawing.Point(262, 55);
            this.book_xinxi.Name = "book_xinxi";
            this.book_xinxi.Size = new System.Drawing.Size(226, 390);
            this.book_xinxi.TabIndex = 13;
            this.book_xinxi.Text = "简介";
            // 
            // book_name
            // 
            this.book_name.AutoSize = true;
            this.book_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.book_name.Location = new System.Drawing.Point(261, 14);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(42, 16);
            this.book_name.TabIndex = 12;
            this.book_name.Text = "书名";
            // 
            // book_id
            // 
            this.book_id.AutoSize = true;
            this.book_id.Location = new System.Drawing.Point(50, 18);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(29, 12);
            this.book_id.TabIndex = 18;
            this.book_id.Text = "编号";
            // 
            // book_isbn
            // 
            this.book_isbn.AutoSize = true;
            this.book_isbn.Location = new System.Drawing.Point(50, 40);
            this.book_isbn.Name = "book_isbn";
            this.book_isbn.Size = new System.Drawing.Size(29, 12);
            this.book_isbn.TabIndex = 19;
            this.book_isbn.Text = "ISBN";
            // 
            // xiangxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 454);
            this.Controls.Add(this.book_isbn);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.book_xiangxiphoto);
            this.Controls.Add(this.book_remain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.book_xinxi);
            this.Controls.Add(this.book_name);
            this.Name = "xiangxi";
            this.Text = "xiangxi";
            this.Load += new System.EventHandler(this.xiangxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.book_xiangxiphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox book_xiangxiphoto;
        private System.Windows.Forms.Label book_remain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label book_xinxi;
        private System.Windows.Forms.Label book_name;
        private System.Windows.Forms.Label book_id;
        private System.Windows.Forms.Label book_isbn;
    }
}