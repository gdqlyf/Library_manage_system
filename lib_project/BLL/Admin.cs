using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace lib_project
{
    public class Admin
    {
        /***************************************************************************************************************/
        //图书管理员数据库操作
        public DataSet BAData_deal(string str)
        {
            //执行查询操作，并把数据集返回给 界面层
            string sql_re = "select * from BAdmin where BAID='" + str + "'";
            DataSet a = new DataSet();
            a = DBControl.refreshnew(sql_re);
            return a;
        }

        //增加图书管理员功能
        public bool BA_Insert(string BAID, string BAname, string BApasswd, string BAmail, string BAtel)   
        {
            //提取BAID；
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果存在，回复 界面层错误信息 提示该管理员存在；
            //如果回复 不存在,向数据访问层 发送“insert”语句 数据访问层执行 插入数据操作。
            string sql_select = "select [BAID] from BAdmin where [BAID]='" + BAID + "'";
            string sql_insert = "insert into BAdmin(BAID, BAname, BApasswd, BAmail, BAtel) values('"+BAID+"','"+BAname+"','"+BApasswd+"','"+BAmail+"','"+BAtel+"')";
            if (DBControl.Select(sql_select) == true)
            {
                return false;
            }
            else
            {
                bool TF = DBControl.Insert(sql_insert);
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
        //删除图书管理员功能
        public bool BA_Delete(string BAID)
        {
            //提取BAID；
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            //如果回复 存在,向数据访问层 发送“delete”语句 数据访问层执行 删除数据操作。
            string sql_select = "select [BAID] from BAdmin where [BAID]='" + BAID + "'";
            string sql_delete = "delete from BAdmin where BAID ='" + BAID + "'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该管理员；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
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
        //查询图书管理员功能
        public bool BA_Select(string BAID)
        {
            //获取 BAID 参数
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            //如果回复 存在,则 数据访问层 发送反馈回 BAID相关数据集；
            //对数据访问层回馈数据集 进行处理 并转化为 字符串；
            //将 字符串传递给 界面层。

            string sql_select = "select BAID from BAdmin where BAID='" + BAID + "'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该管理员；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            }
            else
            {
                bool TF = DBControl.Select(sql_select);           //如果回复 存在,向数据访问层 发送“select”语句 数据访问层执行 删除数据操作。        
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

        //修改图书管理员功能
        public bool BA_Update(string BAID, string BAname, string BApasswd, string BAmail, string BAtel)                            
        {
            //从所有 参数中获取 BAID 参数 
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            //如果回复 存在,则 数据访问层 发送“update”语句 数据访问层执行 修改数据。
            string sql_select = "select [BAID] from BAdmin where [BAID]='" + BAID + "'";
            string sql_update = "update BAdmin set BAname='" + BAname + "',BApasswd='" + BApasswd + "',BAmail='" + BAmail + "',BAtel='"+BAtel+"'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该管理员；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
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

        /*****************************************************************************************************************/

        //人员管理员数据库操作
        public DataSet UAData_deal(string str)
        {
            //执行查询操作，并把数据集返回给 界面层
            string sql_re = "select * from UAdmin where UAID='" + str + "'";
            DataSet a = new DataSet();
            a = DBControl.refreshnew(sql_re);
            return a;
        }
        //增加人员管理员功能
        public bool UA_Insert(string UAID, string UAname, string UApasswd, string UAmail, string UAtel)
        {
            //提取UAID；
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果存在，回复 界面层错误信息 提示该管理员存在；
            //如果回复 不存在,向数据访问层 发送“insert”语句 数据访问层执行 插入数据操作。
            string sql_select = "select [UAID] from UAdmin where [UAID]='" + UAID + "'";
            string sql_insert = "insert into UAdmin(UAID, UAname, UApasswd, UAmail, UAtel) values('"+UAID+"','"+UAname+"','"+UApasswd+"','"+UAmail+"','"+UAtel+"')";
            if (DBControl.Select(sql_select) == true)
            {
                return false;               
            }
            else
            {
                bool TF = DBControl.Insert(sql_insert);
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

        //删除人员管理员功能
        public bool UA_Delete(string UAID)
        {
            //提取UAID；
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            //如果回复 存在,向数据访问层 发送“delete”语句 数据访问层执行 删除数据操作。
            string sql_select = "select [UAID] from UAdmin where [UAID]='" + UAID + "'";
            string sql_delete = "delete from UAdmin where UAID ='" + UAID + "'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该管理员；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
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
        //查询人员管理员功能
        public bool UA_Select(string UAID)
        {
            //获取 UAID 参数
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            //如果回复 存在,则 数据访问层 发送反馈回 UAID相关数据集；
            //对数据访问层回馈数据集 进行处理 并转化为 字符串；
            //将 字符串传递给 界面层。
            string sql_select = "select [UAID] from UAdmin where [UAID]='" + UAID + "'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该管理员；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            }
            else
            {
                bool TF = DBControl.Select(sql_select);           //如果回复 存在,向数据访问层 发送“select”语句 数据访问层执行 删除数据操作。        
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

        //修改人员管理员功能
        public bool UA_Update(string UAID, string UAname, string UApasswd, string UAmail, string UAtel)
        {
            //从所有 参数中获取 UAID 参数 
            //发送“select”语句 判断是否存在该管理员；
            //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            //如果回复 存在,则 数据访问层 发送“update”语句 数据访问层执行 修改数据。
            string sql_select = "select [UAID] from UAdmin where [UAID]='" + UAID + "'";
            string sql_update = "update UAdmin set UAname='" + UAname + "',UApasswd='" + UApasswd + "',UAmail='" + UAmail + "',UAtel='" + UAtel + "'";
            if (DBControl.Select(sql_select) == false)              //发送“select”语句 判断是否存在该管理员；
            {
                return false;                             //数据访问层回复信息： 如果不存在，回复 界面层错误信息 提示该管理员不存在；
            }
            else
            {
                bool TF = DBControl.Update(sql_update);           //如果回复 存在,向数据访问层 发送“Update”语句 数据访问层执行 删除数据操作。        
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

    }
}
