using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lib_project
{
    class Login_in
    {
        public static char Managelogin(string id,string passwd)
        {
            string sql1 = @"select * from [PAdmin] where [PAID]='" + id + "' and [PApasswd]='" + passwd + "'";
            string sql2 = @"select * from [BAdmin] where [BAID]='" + id + "' and [BApasswd]='" + passwd + "'";
            string sql3 = @"select * from [UAdmin] where [UAID]='" + id + "' and [UApasswd]='" + passwd + "'";
            if (DBControl.Select(sql1) == true)
                return (char)1;
            else if (DBControl.Select(sql2) == true)
                return (char)2;
            else if (DBControl.Select(sql3) == true)
                return (char)3;
            else
                return (char)0;
        }
        public static bool Userlogin(string id, string passwd)
        {
            string selectsql = @"select * from [Users] where [UID]='" + id + "' and [passwd]='" + passwd + "'";
            bool result = DBControl.Select(selectsql);
            if (result == true) return true;
            else return false;
        }
    }
}
