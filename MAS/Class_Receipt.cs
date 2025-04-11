using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MAS
{
    class Class_Receipt
    {
        Cls_Db obj_db;

        int rxnumber;
        public int Rxnumber
        {
            get { return rxnumber; }
            set { rxnumber = value; }
        }

        DateTime rxdate;
        public DateTime Rxdate
        {
            get { return rxdate; }
            set { rxdate = value; }
        }

        string rxtype;
        public string Rxtype
        {
            get { return rxtype; }
            set { rxtype = value; }
        }

        string rxname;
        public string Rxname
        {
            get { return rxname; }
            set { rxname = value; }
        }

        string rxrid;
        public string Rxrid
        {
            get { return rxrid; }
            set { rxrid = value; }
        }

        string rxcmntid;
        public string Rxcmntid
        {
            get { return rxcmntid; }
            set { rxcmntid = value; }
        }

       
        
        string rxaccount;
        public string Rxaccount
        {
            get { return rxaccount; }
            set { rxaccount = value; }
        }
       
        decimal rxamount;
        public decimal Rxamount
        {
            get { return rxamount; }
            set { rxamount = value; }
        }
        
        string rxmode;
        public string Rxmode
        {
            get { return rxmode; }
            set { rxmode = value; }
        }
        
        string rxdetails; 
        public string Rxdetails
        {
            get { return rxdetails; }
            set { rxdetails = value; }
        }
       
        string finyear;
        public string Finyear
        {
            get { return finyear; }
            set { finyear = value; }
        }

        int foryear;
        public int Foryear
        {
            get { return foryear; }
            set { foryear = value; }
        }

        int formonth;
        public int Formonth
        {
            get { return formonth; }
            set { formonth = value; }
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
        
        string rxlog;
        public string Rxlog
        {
            get { return rxlog; }
            set { rxlog = value; }
        }
        
        string rxstatus;
        public string Rxstatus
        {
            get { return rxstatus; }
            set { rxstatus = value; }
        }

        DateTime fromdate;
        public DateTime Fromdate
        {
            get { return fromdate; }
            set { fromdate = value; }
        }

        DateTime todate;
        public DateTime Todate
        {
            get { return todate; }
            set { todate = value; }
        }

        string keyword;
        public string Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }

        public int  Receipt_Save()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_SAVE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXNUMBER", Rxnumber);
                cmd.Parameters.AddWithValue("@RXDATE", Rxdate);
                cmd.Parameters.AddWithValue("@RXTYPE", Rxtype);
                cmd.Parameters.AddWithValue("@RXNAME", Rxname);
                cmd.Parameters.AddWithValue("@RXRID",Rxrid);
                cmd.Parameters.AddWithValue("@RXCMNTID", Rxcmntid);
                cmd.Parameters.AddWithValue("@RXACCOUNT", Rxaccount);
                cmd.Parameters.AddWithValue("@RXAMOUNT", Rxamount);
                cmd.Parameters.AddWithValue("@RXMODE", Rxmode);
                cmd.Parameters.AddWithValue("@RXDETAILS", Rxdetails);                                
                cmd.Parameters.AddWithValue("@FINYEAR", Finyear);
                cmd.Parameters.AddWithValue("@FORYEAR", Foryear);
                cmd.Parameters.AddWithValue("@FORMONTH", Formonth);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@RXLOG", Rxlog);
                cmd.Parameters.AddWithValue("@RXSTATUS", Rxstatus);
                rtn_flag = obj_db.Execute_Non(cmd);
            }

            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
            return rtn_flag;
       }

        public int Receipt_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_UPDATE_BY_RXNUMBER");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXNUMBER", Rxnumber);
                cmd.Parameters.AddWithValue("@RXDATE", Rxdate);
                cmd.Parameters.AddWithValue("@RXTYPE", Rxtype);
                cmd.Parameters.AddWithValue("@RXNAME", Rxname);
                cmd.Parameters.AddWithValue("@RXRID", Rxrid);
                cmd.Parameters.AddWithValue("@RXCMNTID", Rxcmntid);
                cmd.Parameters.AddWithValue("@RXACCOUNT", Rxaccount);
                cmd.Parameters.AddWithValue("@RXAMOUNT", Rxamount);
                cmd.Parameters.AddWithValue("@RXMODE", Rxmode);
                cmd.Parameters.AddWithValue("@RXDETAILS", Rxdetails);
                cmd.Parameters.AddWithValue("@FINYEAR", Finyear);
                cmd.Parameters.AddWithValue("@FORYEAR", Foryear);
                cmd.Parameters.AddWithValue("@FORMONTH", Formonth);
                //cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                //cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@RXLOG", Rxlog);
                cmd.Parameters.AddWithValue("@RXSTATUS", Rxstatus);
                
               
                rtn_flag = obj_db.Execute_Non(cmd);
            }

            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
            return rtn_flag;
        }

        public int Receipt_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_DELETE_BY_RXNUMBER");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXNUMBER", Rxnumber);
                
                rtn_flag = obj_db.Execute_Non(cmd);
            }

            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
            return rtn_flag;
        }

        public DataTable Receipt_Select_By_Rxstatus()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_SELECT_BY_RXSTATUS");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXSTATUS", Rxstatus);
                DT = obj_db.Read(cmd);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
            return DT;
        }

        public DataTable Receipt_Select_By_Rxnumber()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_SELECT_BY_RXNUMBER");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXNUMBER", Rxnumber);
                DT = obj_db.Read(cmd);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
            return DT;
        }

        public DataTable Receipt_Select_By_Between_Date()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_SELECT_BY_BETWEEN_DATE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FROMDATE", Fromdate);
                cmd.Parameters.AddWithValue("@TODATE", Todate);
                DT = obj_db.Read(cmd);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
            return DT;
        }

        public DataTable Receipt_Select_By_Keyword()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_SELECT_BY_KEYWORD");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEYWORD",Keyword);
                DT =obj_db.Read(cmd);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
            return DT;
        }

        public DataTable Receipt_Print_Passbook()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RECEIPT_PRINT_PASSBOOK");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXNUMBER", Rxnumber);
                DT = obj_db.Read(cmd);

            }
            catch
            {
                
            }
            return DT;
        }
    }
}
