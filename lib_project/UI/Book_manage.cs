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
    public partial class Book_manage : Form
    {
        //  定义一个string变量保存当前用户名字。
         public static string  currentUser = "";

        //  图书信息结构体,使用时应声明为全局变量。
        public struct struct_Book
        {
            public string BID;
            public string ISBN;
            public string Bname;
            public string autor;
            public string type;
            public string press;
            public string price;
            // byte[] Bphoto 
            public DateTime Btime;
            public string remainNum;
            public string totalNum;
            public string introduction;

        };

        public Book_manage()
        {
            InitializeComponent();
        }

        //  图书查询事件
        private void book_select_Click(object sender, EventArgs e)
        {
            //  将BID_book设置为只读，防止在修改图书时将其修改。
             BID_book.ReadOnly = true;
             if (name_book.Text == "")
             {
                 MessageBox.Show("查询的内容不能为空，请重新输入！");
                 return;
             }

             Books book_manages = new Books();      //  实例化一个图书类Books的对象book_manages
             DataSet book_dataSet = new DataSet();  //  声明一个数据集，用来保存执行图书查询成功返回的图书信息

             if (book_manages.Select(name_book.Text.Trim()))    //  执行图书查询命令，命令执行成功返回true，否则返回false
             {
                 book_dataSet = book_manages.Data_Refresh(name_book.Text.Trim());  //  当图书查询命令成功，更新内存中的图书信息。

                 //  将图书表中的数据显示到dataGrideview中。
                 bookView.DataSource = book_dataSet.Tables["tables"];
                 bookView.Show();  

                 //   将查询的成功的图书信息存储到对应控件中。
                 BID_book.Text = book_dataSet.Tables["tables"].Rows[0]["BID"].ToString();
                 ISBN_book.Text = book_dataSet.Tables["tables"].Rows[0]["ISBN"].ToString();
                 Bname_book.Text = book_dataSet.Tables["tables"].Rows[0]["Bname"].ToString();
                 author_book.Text = book_dataSet.Tables["tables"].Rows[0]["author"].ToString();
                 type_book.Text = book_dataSet.Tables["tables"].Rows[0]["type"].ToString();
                 press_book.Text = book_dataSet.Tables["tables"].Rows[0]["press"].ToString();
                 price_book.Text = book_dataSet.Tables["tables"].Rows[0]["price"].ToString();
                 Btime_book.Text = book_dataSet.Tables["tables"].Rows[0]["Btime"].ToString();
                 remainNum_book.Text = book_dataSet.Tables["tables"].Rows[0]["remainNum"].ToString();
                 totalNum_book.Text = book_dataSet.Tables["tables"].Rows[0]["totalNum"].ToString();
                 introduction_book.Text = book_dataSet.Tables["tables"].Rows[0]["introduction"].ToString();                          
             }
             else
             {
                 MessageBox.Show("抱歉：没有此书，请重新输入！");
                 //  将BID_book设置为可写，用于后面添加或修改图书
                 BID_book.ReadOnly = false;
                 return;
             }
        }

        //  图书插入事件
        private void book_add_Click(object sender, EventArgs e)
        {
            //  判断用户输入的图书信息是否为空
            if (BID_book.Text == "")
            {
                MessageBox.Show("图书编号不能为空，请确认后再执行！");
                return;
            }
            if (ISBN_book.Text == "")
            {
                MessageBox.Show("ISBN不能为空，请确认后再执行！");
                return;
            }
            if (Bname_book.Text == "")
            {
                MessageBox.Show("书名不能为空，请确认后再执行！");
                return;
            }
            if (author_book.Text == "")
            {
                MessageBox.Show("作者不能为空，请确认后再执行！");
                return;
            } if (press_book.Text == "")
            {
                MessageBox.Show("出版社不能为空，请确认后再执行！");
                return;
            }
            if (type_book.Text == "")
            {
                MessageBox.Show("图书类型不能为空，请确认后再执行！");
                return;
            }
            if (price_book.Text == "")
            {
                MessageBox.Show("价格不能为空，请确认后再执行！");
                return;
            }
            if (Btime_book.Text == "")
            {
                MessageBox.Show("出版时间不能为空，请确认后再执行！");
                return;
            }
            if (remainNum_book.Text == "")
            {
                MessageBox.Show("书籍剩余量不能为空，请确认后再执行！");
                return;
            }
            if (totalNum_book.Text == "")
            {
                MessageBox.Show("书籍总量不能为空，请确认后再执行！");
                return;
               
            }
         
            Books book_add = new Books();      //  实例化一个图书类Books的对象book_add
             

            //  添加图书之前先查看数据库中是否已经有该图书，如果已有该图书，显示该图书的信息，提示管理员修改藏书量，没有则添加新的图书。
            if (book_add.Select(Bname_book.Text.Trim()))
            {
                DataSet book_addSet = new DataSet();
                book_addSet = book_add.Data_Refresh(name_book.Text.Trim()); 
                //  将图书表中的数据显示到dataGrideview中。
                bookView.DataSource = book_addSet.Tables["tables"];
                bookView.Show();

                //  将BID_book设置为只读，防止在修改图书时将其修改。
                BID_book.ReadOnly = true;

                //   将查询的成功的图书信息存储到对应控件中。
                BID_book.Text = book_addSet.Tables["tables"].Rows[0]["BID"].ToString();
                ISBN_book.Text = book_addSet.Tables["tables"].Rows[0]["ISBN"].ToString();
                Bname_book.Text = book_addSet.Tables["tables"].Rows[0]["Bname"].ToString();
                author_book.Text = book_addSet.Tables["tables"].Rows[0]["author"].ToString();
                type_book.Text = book_addSet.Tables["tables"].Rows[0]["type"].ToString();
                press_book.Text = book_addSet.Tables["tables"].Rows[0]["press"].ToString();
                price_book.Text = book_addSet.Tables["tables"].Rows[0]["price"].ToString();
                Btime_book.Text = book_addSet.Tables["tables"].Rows[0]["Btime"].ToString();
                remainNum_book.Text = book_addSet.Tables["tables"].Rows[0]["remainNum"].ToString();
                totalNum_book.Text = book_addSet.Tables["tables"].Rows[0]["totalNum"].ToString();
                introduction_book.Text = book_addSet.Tables["tables"].Rows[0]["introduction"].ToString(); 

                MessageBox.Show("该图书已存在于书库中，现已将该图书的信息显示\n请按照您的需求修改该图书！");
                return;
            }
           
            //  执行图书插入sql语句，成功返回true，失败返回false
            if (book_add.Insert(
            BID_book.Text.Trim(),
            ISBN_book.Text.Trim(),
            Bname_book.Text.Trim(),
            author_book.Text.Trim(),
            type_book.Text.Trim(),
            press_book.Text.Trim(),
            Convert.ToSingle(price_book.Text),
            Convert.ToDateTime(Btime_book.Text.Trim()),
            Convert.ToInt16(remainNum_book.Text.Trim()),
            Convert.ToInt16(totalNum_book.Text.Trim()),
            introduction_book.Text.Trim() ))
            {
                book_add.Data_Refresh();
                MessageBox.Show("图书插入成功！");
                //  图书插入成功后，将之前的输入信息清空

                return;
            }
            else
            {
                MessageBox.Show("抱歉：图书插入出错！");
                return;
            }
        }
        
        //  图书修改
        private void book_modify_Click(object sender, EventArgs e)
        {
            //  实例化一个负责书籍修改的图书类。
            Books book_update = new Books();
            //  执行图书修改sql命令，成功，更新内存图书信息并返回true, 失败提示出错，返回false
           if (book_update.Update(
           BID_book.Text.Trim(),
           ISBN_book.Text.Trim(),
           Bname_book.Text.Trim(),
           author_book.Text.Trim(),
           type_book.Text.Trim(),
           press_book.Text.Trim(),
           Convert.ToSingle(price_book.Text),
           Convert.ToDateTime(Btime_book.Text.Trim()),
           Convert.ToInt16(remainNum_book.Text.Trim()),
           Convert.ToInt16(totalNum_book.Text.Trim()),
           introduction_book.Text.Trim()))
            {
                //  修改后，更新dataGridView的信息,以及 更新图书信息控件内容。
                DataSet book_updateSet = new DataSet();
                if (book_update.Select(Bname_book.Text.Trim()))
                {
                    book_updateSet = book_update.Data_Refresh(Bname_book.Text.Trim());
                    bookView.DataSource = book_updateSet.Tables["tables"];
                    bookView.Show();
                    MessageBox.Show("图书修改成功！");
                    return;
                }
                else
                {
                    MessageBox.Show("抱歉：图书信息同步出错！");
                    return;
                }            
            }
            else
            {
                MessageBox.Show("抱歉：图书修改出错！");
                return;
            }
        }

        private void book_delete_Click(object sender, EventArgs e)
        {
           // DataSet book_delSet = new DataSet();

            Books book_del = new Books();
            if (book_del.Delete(BID_book.Text))
            {
                book_del.Data_Refresh();
                //  删除dataGridView中对应的图书信息
                for (int i = this.bookView.SelectedRows.Count; i > 0; i--)
                {
                    int ID = Convert.ToInt32(bookView.SelectedRows[i - 1].Cells[0].Value);
                    bookView.Rows.RemoveAt(bookView.SelectedRows[i - 1].Index);
                }
                //  删除图书信息控件中的信息
                    BID_book.Text ="";
                    ISBN_book.Text ="";
                    Bname_book.Text ="";
                    author_book.Text ="";
                    type_book.Text ="";
                    press_book.Text ="";
                    price_book.Text ="";
                    Btime_book.Text ="";
                    remainNum_book.Text ="";
                    totalNum_book.Text ="";
                    introduction_book.Text = "";

                    //  修改后，更新dataGridView的信息,以及 更新图书信息控件内容。
                    DataSet book_delSet = new DataSet();
                    book_delSet = book_del.Data_Refresh();
                    bookView.DataSource = book_delSet.Tables["tables"];
                    bookView.Show();
                    

                    

                MessageBox.Show("删除图书成功！");
                return;
            }
            else
            {
                MessageBox.Show("抱歉：删除图书出错！");
                return;
            }
        }

        //  打开图书管理界面时，加载当前用户
        private void Book_manage_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前用户：" + currentUser;
        }

        //  当单击dataGridView的单元格时，在图书信息控件中显示该行的信息。
        private void bookView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  当单击dataGridView的单元格时，选中整行。
            this.bookView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //   将查询的成功的图书信息存储到对应控件中。 
            BID_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["BID"].Value.ToString();
            ISBN_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["ISBN"].Value.ToString();
            Bname_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["Bname"].Value.ToString();
            author_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["author"].Value.ToString();
            type_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["type"].Value.ToString();
            press_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["press"].Value.ToString();
            price_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["price"].Value.ToString();
            Btime_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["Btime"].Value.ToString();
            remainNum_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["remainNum"].Value.ToString();
            totalNum_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["totalNum"].Value.ToString();
            introduction_book.Text = bookView.Rows[bookView.CurrentRow.Index].Cells["introduction"].Value.ToString(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Start();
            toolStripStatusLabel2.Text = "当前时间："+ DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BID_book.ReadOnly = false;
            BID_book.Text ="";
            ISBN_book.Text ="";
            Bname_book.Text ="";
            author_book.Text ="";
            type_book.Text ="";
            press_book.Text ="";
            price_book.Text ="";
            Btime_book.Text ="";
            remainNum_book.Text ="";
            totalNum_book.Text ="";
            introduction_book.Text = "";
        }
    }
}
