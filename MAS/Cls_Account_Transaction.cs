using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace MAS
{
    class Cls_Account_Transaction
    {

        Cls_Db Obj_Db;

        int txid;
        public int Txid
        {
            get { return txid; }
            set { txid = value; }
        }

        DateTime txdate;
        public DateTime Txdate
        {
            get { return txdate; }
            set { txdate = value; }
        }

        string voucherno;
        public string Voucherno
        {
            get { return voucherno; }
            set { voucherno = value; }
        }

        string txtype;
        public string Txtype
        {
            get { return txtype; }
            set { txtype = value; }
        }

        string accountid;
        public string Accountid
        {
            get { return accountid; }
            set { accountid = value; }
        }

        string rid;
        public string Rid
        {
            get { return rid; }
            set { rid = value; }
        }

        string txmode;
        public string Txmode
        {
            get { return txmode; }
            set { txmode = value; }
        }

        double txamount;
        public double Txamount
        {
            get { return txamount; }
            set { txamount = value; }
        }

        string txdetails;
        public string Txdetails
        {
            get { return txdetails; }
            set { txdetails = value; }
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

        string txlog;
        public string Txlog
        {
            get { return txlog; }
            set { txlog = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DataTable Account_Transaction_Print_By_Rid()
        {
            DataTable DT = new DataTable();
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_ACCOUNT_TRANSACTION");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mode", "ACCOUNT_TRANSATION_PRINT");
                cmd.Parameters.AddWithValue("@RID", Rid);
                DT = Obj_Db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
    }
}
