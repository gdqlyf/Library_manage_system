using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

public class DBControl
{
    public static string strcon = @"Data Source=GUODONG-PC\SQLEXPRESS;Initial Catalog=library;Integrated Security=SSPI";  //数据库连接语句
    public static SqlConnection conn = new SqlConnection(strcon);
    public static DataSet refreshnew(string refresql)   //实现数据库返回信息的刷新
    {
        try
        { 
            conn.Open();
            SqlDataAdapter reader = new SqlDataAdapter(refresql,conn);  //执行命令获得数据集
            DataSet result=new DataSet();
            reader.Fill(result,"result");
            conn.Close();
            return result;
        }
        catch
        {
            conn.Close();
            return (DataSet)null;
        }
    }

    public static bool Insert(string insertsql)
    {
        int a = 0;
        try
        {
            SqlCommand cmd = new SqlCommand(insertsql, conn);
            conn.Open();
            a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0) return true;
            else return false;
        }
        catch
        {
            conn.Close();
            return false;
        }
    }

    public static bool Delete(string deletesql)
    {
        int a = 0;
        try
        {
            SqlCommand cmd = new SqlCommand(deletesql, conn);
            conn.Open();
            a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0) return true;
            else return false;
        }
        catch
        {
            conn.Close();
            return false;
        }
    }

    public static bool Select(string selectsql)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        catch
        {
            conn.Close();
            return false;
        }
    }

    public static bool Update(string updatesql)
    {
        int a = 0;
        try
        {
            SqlCommand cmd = new SqlCommand(updatesql, conn);
            conn.Open();
            a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0) return true;
            else return false;
        }
        catch
        {
            conn.Close();
            return false;
        }
    }

    public static string borrowed(string UID, string BID)
    {
        SqlCommand cmd = new SqlCommand("borrow", conn); 	//新建数据库命令对象
        cmd.CommandType = CommandType.StoredProcedure;			//设置命令类型为存储过程

        SqlParameter inReaderID = new SqlParameter("@UID", SqlDbType.Char, 20);
        inReaderID.Direction = ParameterDirection.Input;				//参数类型为输入参数
        inReaderID.Value = UID;					//给参数赋值
        cmd.Parameters.Add(inReaderID);

        SqlParameter inBookID = new SqlParameter("@BID", SqlDbType.Char, 20);
        inBookID.Direction = ParameterDirection.Input;
        inBookID.Value = BID;
        cmd.Parameters.Add(inBookID);

        SqlParameter outReturn = new SqlParameter("@out_str", SqlDbType.Char, 30);
        outReturn.Direction = ParameterDirection.Output;				//参数类型为输出参数
        cmd.Parameters.Add(outReturn);							//添加参数
        try
        {
            conn.Open();									//打开数据库连接
            cmd.ExecuteNonQuery();							//执行存储过程
            conn.Close();
            return outReturn.Value.ToString();
        }
         catch(Exception ex)
        {
            conn.Close();
            return ex.ToString();
        }
    }
}
