using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace MAS
{
    class Cls_Education_Master
    {

        Cls_Db obj_cls_db;
        string key;
        public string Key
        {
            get { return key; }
            set { key = value; }
        }


        string mode;
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }


        int edu_Id;
        public int Edu_Id
        {
            get { return edu_Id; }
            set { edu_Id = value; }
        }


        string cmnt_Id;
        public string Cmnt_Id
        {
            get { return cmnt_Id; }
            set { cmnt_Id = value; }
        }


        string qualification;
        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }


        string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }


        string stream;
        public string Stream
        {
            get { return stream; }
            set { stream = value; }
        }


        string issuing_Authority;
        public string Issuing_Authority
        {
            get { return issuing_Authority; }
            set { issuing_Authority = value; }
        }


        int percentage;
        public int Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }


        string grade;
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }


        int passing_Year;
        public int Passing_Year
        {
            get { return passing_Year; }
            set { passing_Year = value; }
        }


        string reg_No;
        public string Reg_No
        {
            get { return reg_No; }
            set { reg_No = value; }
        }


        string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
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


        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        

        public int Education_Master_Get_Id()
        {
            int rtn_flag = 0;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Education_Master_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                rtn_flag = obj_cls_db.Exec_Scalar(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public int Education_Master_Insert()
        {
            int rtn_flag = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Insert");
                cmd.CommandType = CommandType.StoredProcedure;
                obj_cls_db = new Cls_Db();

                cmd.Parameters.AddWithValue("@MODE", "INSERTVALUE");

                cmd.Parameters.AddWithValue("@Edu_Id", Edu_Id);
                cmd.Parameters.AddWithValue("@Cmnt_id", Cmnt_Id);
                cmd.Parameters.AddWithValue("@Qualification", Qualification);
                cmd.Parameters.AddWithValue("@Subject", Subject);
                cmd.Parameters.AddWithValue("@Stream", Stream);
                cmd.Parameters.AddWithValue("@Issuing_Authority", Issuing_Authority);
                cmd.Parameters.AddWithValue("@Percentage", Percentage);
                cmd.Parameters.AddWithValue("@Grade", Grade);
                cmd.Parameters.AddWithValue("@Passing_Year", Passing_Year);
                cmd.Parameters.AddWithValue("@Reg_No", Reg_No);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Created", created);
                cmd.Parameters.AddWithValue("@Modified", Modified);
                cmd.Parameters.AddWithValue("@status", Status);

                rtn_flag = obj_cls_db.Execute_Non(cmd);                             
            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Education_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Update");
                cmd.CommandType = CommandType.StoredProcedure;
                obj_cls_db = new Cls_Db();


                cmd.Parameters.AddWithValue("@MODE", "UPDATE_VALUE");

                cmd.Parameters.AddWithValue("@Edu_Id", Edu_Id);
                cmd.Parameters.AddWithValue("@Cmnt_id", Cmnt_Id);
                cmd.Parameters.AddWithValue("@Qualification", Qualification);
                cmd.Parameters.AddWithValue("@Subject", Subject);
                cmd.Parameters.AddWithValue("@Stream", Stream);
                cmd.Parameters.AddWithValue("@Issuing_Authority", Issuing_Authority);
                cmd.Parameters.AddWithValue("@Percentage", Percentage);
                cmd.Parameters.AddWithValue("@Grade", Grade);
                cmd.Parameters.AddWithValue("@Passing_Year", Passing_Year);
                cmd.Parameters.AddWithValue("@Reg_No", Reg_No);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Created", created);
                cmd.Parameters.AddWithValue("@Modified", Modified);
                cmd.Parameters.AddWithValue("@status", Status);

                rtn_flag = obj_cls_db.Execute_Non(cmd);  

            }
            catch
            {
            }
            return rtn_flag;
        }
        public int Education_Master_Delete()
        {
            int rtn_flag = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Delete");
                cmd.CommandType = CommandType.StoredProcedure;
                obj_cls_db = new Cls_Db();

                cmd.Parameters.AddWithValue("@Cmnty_Id", Cmnt_Id);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public DataTable Education_Master_Select_All()
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Select_All");
                cmd.CommandType = CommandType.StoredProcedure;
                obj_cls_db = new Cls_Db();
                DT = obj_cls_db.Read(cmd);          

            }
            catch
            {
            }
            return DT;
        }

        public DataTable Education_Master_Select_By_Cmnty_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Select_By_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cmnty_Id", Cmnt_Id);
                obj_cls_db = new Cls_Db();
                DT = obj_cls_db.Read(cmd);

            }
            catch
            {
            }
            return DT;
        }

        public DataTable Education_Master_Select_By_Keys()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Education_Master_Select_By_Keys");
                cmd.CommandType = CommandType.StoredProcedure;

                DT = obj_cls_db.Read(cmd);

            }
            catch
            {
            }
            return DT;
        }
    }
}
