using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{    
    class Cls_Payment
    {        
        Cls_Db Obj_Database;

        int pxno;
        public int Pxno
        {
            get { return pxno; }
            set { pxno = value; }
        }

        DateTime pxdate;
        public DateTime Pxdate
        {
            get { return pxdate; }
            set { pxdate = value; }
        }

        string account;
        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        string pxreference;
        public string Pxreference
        {
            get { return pxreference; }
            set { pxreference = value; }
        }

        string paidto;
        public string Paidto
        {
            get { return paidto; }
            set { paidto = value; }
        }

        double pxamount;
        public double Pxamount
        {
            get { return pxamount; }
            set { pxamount = value; }
        }

        string pxmode;
        public string Pxmode
        {
            get { return pxmode; }
            set { pxmode = value; }
        }

        string pxdetails;
        public string Pxdetails
        {
            get { return pxdetails; }
            set { pxdetails = value; }
        }

        string towards;
        public string Towards
        {
            get { return towards; }
            set { towards = value; }
        }

        int formonth;
        public int Formonth
        {
            get { return formonth; }
            set { formonth = value; }
        }

        int foryear;
        public int Foryear
        {
            get { return foryear; }
            set { foryear = value; }
        }

        string finyear;
        public string Finyear
        {
            get { return finyear; }
            set { finyear = value; }
        }

        DateTime created;
        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

        DateTime modified;
        public DateTime Modified
        {
            get { return modified; }
            set { modified = value; }
        }

        DateTime deleted;
        public DateTime Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        string userid;
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        string pxlog;
        public string Pxlog
        {
            get { return pxlog; }
            set { pxlog = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        //////////////////////////////////////////////////////////  FUNCTIONS  ////////////////////////////////////////////////////////////////////////

        public int Payment_Save()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Database = new Cls_Db();
                SqlCommand cmd = new SqlCommand("PAYMENT_INSERT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PXNUMBER",Pxno);
                cmd.Parameters.AddWithValue("@PXDATE",Pxdate);
                cmd.Parameters.AddWithValue("@ACCOUNT",Account);
                cmd.Parameters.AddWithValue("@PXREFNUMBER",Pxreference);
                cmd.Parameters.AddWithValue("@PAIDTO",Paidto);
                cmd.Parameters.AddWithValue("@PXAMOUNT",Pxamount);
                cmd.Parameters.AddWithValue("@PXMODE",Pxmode);
                cmd.Parameters.AddWithValue("@PXDETAILS",Pxdetails);
                cmd.Parameters.AddWithValue("@TOWARDS",Towards);
                cmd.Parameters.AddWithValue("@FORMONTH",Formonth);
                cmd.Parameters.AddWithValue("@FORYEAR",Foryear);
                cmd.Parameters.AddWithValue("@FINYEAR",Finyear);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@PXLOG", Pxlog);
                cmd.Parameters.AddWithValue("@STATUS", Status);
                rtn_flag = Obj_Database.Execute_Non(cmd);     
            }
            catch { }
            return rtn_flag;
        }      

    }
}
