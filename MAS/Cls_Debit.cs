using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MAS
{
    class Cls_Debit
    {
        Cls_Db obj_cls_db;

        DateTime pxdate;

        public DateTime Pxdate
        {
            get { return pxdate; }
            set { pxdate = value; }
        }

        string pxno;

        public string Pxno
        {
            get { return pxno; }
            set { pxno = value; }
        }
        string pxtype;

        public string Pxtype
        {
            get { return pxtype; }
            set { pxtype = value; }
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
        string pxdescription;

        public string Pxdescription
        {
            get { return pxdescription; }
            set { pxdescription = value; }
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

        DateTime pxstartdate;

        public DateTime Pxstartdate
        {
            get { return pxstartdate; }
            set { pxstartdate = value; }
        }
        DateTime pxenddate;

        public DateTime Pxenddate
        {
            get { return pxenddate; }
            set { pxenddate = value; }
        }

        string pxkeyword;

        public string Pxkeyword
        {
            get { return pxkeyword; }
            set { pxkeyword = value; }
        }

        public int Debit_Insert()
        {

            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("DEBIT_INSERT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PXDATE",Pxdate);
                cmd.Parameters.AddWithValue("@PXNO", Pxno);
                cmd.Parameters.AddWithValue("@PXTYPE", Pxtype);
                cmd.Parameters.AddWithValue("@PXAMOUNT", Pxamount);
                cmd.Parameters.AddWithValue("@PXMODE",Pxmode);
                cmd.Parameters.AddWithValue("@PXDETAILS", Pxdetails);
                cmd.Parameters.AddWithValue("@PXDESCRIPTION", Pxdescription);
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

        public int Debit_Update()
        {

            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("DEBIT_UPDATE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PXDATE", Pxdate);
                cmd.Parameters.AddWithValue("@PXNO", Pxno);
                cmd.Parameters.AddWithValue("@PXTYPE", Pxtype);
                cmd.Parameters.AddWithValue("@PXAMOUNT", Pxamount);
                cmd.Parameters.AddWithValue("@PXMODE", Pxmode);
                cmd.Parameters.AddWithValue("@PXDETAILS", Pxdetails);
                cmd.Parameters.AddWithValue("@PXDESCRIPTION", Pxdescription);
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

        public int Debit_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("DEBIT_DELETE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PXNO", Pxno);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }

            catch
            {
            }
            return rtn_flag;
        }

        public DataTable Debit_Search_Between_date()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("DEBIT_SEARCH_BETWEEN_DATE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PXSTARTDATE", Pxstartdate);
                cmd.Parameters.AddWithValue("@PXENDDATE", Pxenddate);
                DT = obj_cls_db.Read(cmd); ;
            }
            catch
            {

            }
            return DT;
        }

        public DataTable Debit_Search_By_Keyword()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("DEBIT_SEARCH_BY_KEYWORD");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PXKEYWORD", Pxkeyword);
               
                DT = obj_cls_db.Read(cmd); ;
            }
            catch
            {

            }
            return DT;
        }

        public DataTable Debit_Search_By_Pxno()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("DEBIT_SEARCH_BY_PXNO");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PXNO", Pxno);

                DT = obj_cls_db.Read(cmd); ;
            }
            catch
            {

            }
            return DT;
        }

    }

}
