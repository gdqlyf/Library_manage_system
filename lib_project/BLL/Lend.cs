using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


class lend
{
    public static string borrowed_book(string UID, string BID)
    {
        string out_str = "";
        out_str = DBControl.borrowed(UID,BID);
        return out_str;
    }

    public static bool return_book(string UID, string BID)
    {
        string returnsql = "delete from [Lend] where UID='" + UID + "' and BID='" + BID + "'";
        bool isreturn = DBControl.Delete(returnsql);
        if (isreturn == true) return true;
        else return false;
    }

    public static bool renew_book(string UID, string BID)
    {
        int renewday = 30;
        string renewsql = "update [Lend] set [Rtime]=DATEADD(day," + renewday.ToString() + ",[Rtime]) where UID='" + UID + "' and BID='" + BID + "'";
        bool isreturn = DBControl.Update(renewsql);
        if (isreturn == true) return true;
        else return false;
    }

    public static DataSet select_uid(string UID)
    {
        string selectsql = "select [Lend].BID as BID,Bname,author,Bphoto,Ltime,Rtime from [Lend],[Book] where [Lend].BID=[Book].BID and UID='" + UID + "'";
        DataSet isreturn = new DataSet(); 
        isreturn = DBControl.refreshnew(selectsql);
        return isreturn;
    }

    public static DataSet select_bid(string BID)
    {
        string selectsql = "select * from [Lend] where BID='" + BID + "'";
        DataSet isreturn = new DataSet();
        isreturn = DBControl.refreshnew(selectsql);
        return isreturn;
    }
}
