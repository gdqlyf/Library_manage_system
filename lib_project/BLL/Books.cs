using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//  添加所需的
using System.Data.SqlClient;
using System.IO;
using System.Data;


        //图书类
        //功能：实现对图书的曾删改查。
        //by: li 
        //时间：2014-07-05
namespace lib_project
{
    class Books
    {
        //  数据传递-- 方法一
        public  DataSet Data_Refresh()
        {
            string str_update = "select * from Book";
            DataSet dataSet = new DataSet();
            dataSet = DBControl.refreshnew(str_update);
            return dataSet;
        }

         //  重载函数
        public  DataSet Data_Refresh(string Bname)
        {
            string str_select = "select * from Book where Bname like '%"+ Bname +"%'";
            DataSet dataSet = new DataSet();
            dataSet = DBControl.refreshnew(str_select);
            return dataSet;
        }

        public DataSet Data_fresh(string bookid)
        {
            string str_select = "select * from Book where BID='" + bookid + "'";
            DataSet dataSet = new DataSet();
            dataSet = DBControl.refreshnew(str_select);
            return dataSet;
        }
        public DataSet Data_freshs(string booktype)
        {
            string str_select = "select * from Book where type='" + booktype + "'";
            DataSet dataSet = new DataSet();
            dataSet = DBControl.refreshnew(str_select);
            return dataSet;
        }

        //  图书添加
        public bool Insert(string BID,string ISBN,string Bname,string autor,string type,string press,
                          float price,DateTime Btime,int remainNum, int totalNum,string introduction)
        {
            //  sql命令
            string str_insert = "insert Book values('" + BID + "','"
                + ISBN + "','" + Bname + "','" + autor + "','" + type + "','" 
                + press + "'," + Convert.ToString(price) + ",null,'" + Btime + "',"
                + Convert.ToString(remainNum) + "," + Convert.ToString(totalNum) + ",'"
                + introduction + "')";

            //  调用数据类对图书进行添加，若正确则向表示层返回true，出错则返回false
            if (DBControl.Insert(str_insert))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //  图书删除
        public bool Delete(string BID)
        {
            //  删除Sql语句
            string str_delete = "delete from Book where BID = '" + BID + "'";

            if (DBControl.Delete(str_delete))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //  图书查询
        public bool Select(string Bname)
        {
           //  图书查询sql语句, 模糊查询
            string str_select = "select * from Book where Bname like '%" + Bname + "%'";

            if (DBControl.Select(str_select))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //  图书修改
        public bool Update(string BID,string ISBN,string Bname,string author, string type,string press,float price,
                            DateTime Btime,int remainNum,int totalNum,string introduction)
        {
           //  图书修改sql语句
            string str_insert = "update Book set ISBN='"
                + ISBN + "'," + "Bname='" + Bname + "'," + "author='" 
                + author + "'," + "type ='" + type + "'," + "press='" 
                + press + "'," + "price = " + Convert.ToString(price) + "," 
                + "Btime='" + Btime + "'," + "remainNum=" + Convert.ToString(remainNum) 
                + "," + "totalNum = " + Convert.ToString(totalNum) + "," + "introduction = '"
                + introduction + "' where BID = '"+ BID +"'";

           //  执行图书修改sql语句，执行成功返回true，失败返回false
            if (DBControl.Update(str_insert))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}