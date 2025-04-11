using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{
    class Cls_Credit
    {
        Cls_Db obj_cls_db;

        DateTime rxdate;

        public DateTime Rxdate
        {
            get { return rxdate; }
            set { rxdate = value; }
        }
        string rxno;

        public string Rxno
        {
            get { return rxno; }
            set { rxno = value; }
        }
        string rxtype;

        public string Rxtype
        {
            get { return rxtype; }
            set { rxtype = value; }
        }
        double rxamount;

        public double Rxamount
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
        string rxdescription;

        public string Rxdescription
        {
            get { return rxdescription; }
            set { rxdescription = value; }
        }
        string created;

        public string Created
        {
            get { return created; }
            set { created = value; }
        }
        string modified;

        public string Modified
        {
            get { return modified; }
            set { modified = value; }
        }
        string deleted;

        public string Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        DateTime rxstartdate;

        public DateTime Rxstartdate
        {
            get { return rxstartdate; }
            set { rxstartdate = value; }
        }

        DateTime rxenddate;

        public DateTime Rxenddate
        {
            get { return rxenddate; }
            set { rxenddate = value; }
        }


        string rxkeyword;

        public string Rxkeyword
        {
            get { return rxkeyword; }
            set { rxkeyword = value; }
        }

       

        public int Credit_Insert()
        {
            
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("CREDIT_INSERT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXDATE", Rxdate);
                cmd.Parameters.AddWithValue("@RXNO", Rxno);
                cmd.Parameters.AddWithValue("@RXTYPE", Rxtype);
                cmd.Parameters.AddWithValue("@RXAMOUNT", Rxamount);
                cmd.Parameters.AddWithValue("@RXMODE", Rxmode);
                cmd.Parameters.AddWithValue("@RXDETAILS", Rxdetails);
                cmd.Parameters.AddWithValue("@RXDESCRIPTION", Rxdescription);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@STATUS", Status);

                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Credit_Update()
        {

            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("CREDIT_UPDATE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXDATE", Rxdate);
                cmd.Parameters.AddWithValue("@RXNO", Rxno);
                cmd.Parameters.AddWithValue("@RXTYPE", Rxtype);
                cmd.Parameters.AddWithValue("@RXAMOUNT", Rxamount);
                cmd.Parameters.AddWithValue("@RXMODE", Rxmode);
                cmd.Parameters.AddWithValue("@RXDETAILS", Rxdetails);
                cmd.Parameters.AddWithValue("@RXDESCRIPTION", Rxdescription);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@STATUS", Status);

                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Credit_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("CREDIT_DELETE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXNO", Rxno);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }

            catch
            {
            }
            return rtn_flag;
        }

        public DataTable Credit_Search_Between_date()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("CREDIT_SEARCH_BETWEEN_DATE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXSTARTDATE", Rxstartdate);
                cmd.Parameters.AddWithValue("@RXENDDATE", Rxenddate);
                DT = obj_cls_db.Read(cmd); ;
            }
            catch
            {

            }
            return DT;
        }

        public DataTable Credit_Search_By_Keyword()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("CREDIT_SEARCH_BY_KEYWORD");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXKEYWORD", Rxkeyword);

                DT = obj_cls_db.Read(cmd); ;
            }
            catch
            {

            }
            return DT;
        }

        public DataTable Credit_Search_By_Rxno()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("CREDIT_SEARCH_BY_RXNO");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RXNO", Rxno);

                DT = obj_cls_db.Read(cmd); ;
            }
            catch
            {

            }
            return DT;
        }


    }
}
