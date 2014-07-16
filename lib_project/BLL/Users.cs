using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace lib_project
{
    //用户类 
    //用户管理员操作Users表
    //依赖于DBControl类
    //返回数据集给界面层
    public class Users
    {
    //    private string UID;
    //    private string Uname;
    //    private string passwd;
    //    private string identity;
    //    private string Utel;
    //    private string Umail;
    //    private string Uphoto;
    //    private int borrowed;
    //    private int borrowing;
    //    private string URtime
    //    private string effective;

        public DataSet Data_deal(string str)
        {
            //执行查询操作，并把数据集返回给 界面层
            string sql_re = "select * from Users where UID='"+str+"'";
            DataSet a=new DataSet();
            a=DBControl.refreshnew(sql_re);
            return a;
            

        }

        //增加用户功能
        public bool Insert(string UID, string Uname, string passwd, string identity, string Utel, string Umail
                                     /*, string Uphoto*/, int borrowed, int borrowing, string URtime, string effective)
        {
            //提取UID；
            //发送“select”语句 判断是否存在该用户；
            //数据访问层回复信息： 如果存在，回复 界面层错误信息 提示该用户存在；
            //如果回复 不存在,向数据访问层 发送“insert”语句 数据访问层执行 插入数据操作。
            string sql_select = "select [UID] from Users where [UID]='"+UID+"'";
            string sql_insert = "insert into Users(UID,Uname,passwd,[identity],Utel,Umail ,borrowed,borrowing,URtime,effective) values('"+UID+"','"+Uname+"','"+passwd+"','"+identity+"','"+Utel+"','"+Umail+"' ,'"+borrowed+"','"+borrowing+"','"+URtime+"','"+effective+"')";
            if (DBControl.Select(sql_select) == true)
            {
                return false;
            }
            else
            {
                bool TF=DBControl.Insert(sql_insert);
                if (TF == true)
                {
                    return true;
                       
                }
                else
                {
                    return false;
                }                   
            }
            


        }
        //删除用户功能
        public bool Delete(string UID)
        {
            //提取UID；
            //发送“select”语句 判断是否存在该用户；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该用户不存在；
            //如果回复 存在,向数据访问层 发送“delete”语句 数据访问层执行 删除数据操作。
            string sql_select = "select [UID] from Users where [UID]='" + UID + "'";
            string sql_delete = "delete from Users where UID ='"+UID+"'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该用户；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该用户不存在；
            }
            else
            {
                bool TF = DBControl.Delete(sql_delete);           //如果回复 存在,向数据访问层 发送“delete”语句 数据访问层执行 删除数据操作。        
                if (TF == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }
        //查询用户功能
        public bool Select(string UID)
        {
            //获取 UID 参数
            //发送“select”语句 判断是否存在该用户；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该用户不存在；
            //如果回复 存在,则 数据访问层 发送反馈回 UID相关数据集；
            //对数据访问层回馈数据集 进行处理 并转化为 字符串；
            //将 字符串传递给 界面层。
            string sql_select = "select [UID] from Users where [UID]='" + UID + "'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该用户；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该用户不存在；
            }
            else
            {                   
                return true;           
            }
        }

        //修改用户功能
        public bool Update(string UID, string Uname, string passwd, string identity, string Utel, string Umail
                                    /* , string Uphoto*/, int borrowed, int borrowing, string URtime, string effective)
        {
            //从所有 参数中获取 UID 参数 
            //发送“select”语句 判断是否存在该用户；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该用户不存在；
            //如果回复 存在,则 数据访问层 发送“update”语句 数据访问层执行 修改数据。
            string sql_select = "select [UID] from Users where [UID]='" + UID + "'";
            string sql_update = "update Users set Uname='" + Uname + "',passwd='" + passwd + "',[identity]='" + identity + "',Utel='" + Utel + "',Umail='" + Umail +  "',borrowed=" +borrowed + ",borrowing=" +borrowing + ",URtime='" + URtime + "', effective='" + effective + "' where[UID]='" + UID + "'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该用户；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该用户不存在；
            }
            else
            {
                bool TF = DBControl.Update(sql_update);           //如果回复 存在,向数据访问层 发送“select”语句 数据访问层执行 删除数据操作。        
                if (TF == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Update(string UID, string Upasswd)
        {
            string update_sql = "update [Users] set [passwd]='" + Upasswd + "' where [UID]='" + UID + "'";
            if (DBControl.Update(update_sql) == true)
                return true;
            else
                return false;
        }
    }
}
