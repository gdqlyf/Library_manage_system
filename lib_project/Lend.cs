using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class lend
{
    public string borrowed(string UID, string BID)
    {
        string out_str = "";
        out_str = DBControl.borrowed(BID, UID);
        return out_str;
    }

    public bool return_book(string UID, string BID)
    {
        string returnsql = "delete from [Lend] where UID='" + UID + "' and BID='" + BID + "'";
        bool isreturn = DBControl.Delete(returnsql);
        if (isreturn == true) return true;
        else return false;
    }
}
