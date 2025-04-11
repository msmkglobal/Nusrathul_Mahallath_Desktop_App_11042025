using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{
    class Cls_Education
    {
        Cls_Db Obj_Cls_Db;

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
        public int  Education_Get_Id()
        {
            int return_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Education_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                return_flag = Obj_Cls_Db.Exec_Scalar(cmd);
            }
            catch { }
            return return_flag;
        }

        public int Education_Save()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Education_Insert_Update");
                cmd.CommandType = CommandType.StoredProcedure;

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

                rtn_flag = Obj_Cls_Db.Execute_Non(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public int Education_Delete()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Education_Master_Delete");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK",Edu_Id);
                rtn_flag= Obj_Cls_Db.Execute_Non(cmd);
            }
            catch { }
            return rtn_flag;
        }

        public int Education_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Education_Insert_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MODE", "UPDATEVALUE");

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

                //add other parameter values

                rtn_flag = Obj_Cls_Db.Execute_Non(cmd);

               
            }
            catch { }
            return rtn_flag;
        }

        public DataTable Education_Find_By_PK()
        {
            Obj_Cls_Db = new Cls_Db();
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Find_By_Pk");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK", Key);                
                DT = Obj_Cls_Db.Read(cmd);
            }
            catch { }
            return DT;
        }

        public DataTable Education_Find_By_Key()
        {
            Obj_Cls_Db = new Cls_Db();
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Find_By_Key");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEY", Key);
                DT = Obj_Cls_Db.Read(cmd);
            }
            catch { }
            return DT;
        }

        public DataTable Education_Select_All()
        {
            Obj_Cls_Db = new Cls_Db();
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT_ALL_FROM_RELATION");
                cmd.CommandType = CommandType.StoredProcedure;
                
                DT = Obj_Cls_Db.Read(cmd);
            }
            catch { }
            return DT;
        }

        public DataTable Education_Find_By_Cmnt()
        {
            Obj_Cls_Db = new Cls_Db();
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Education_Master_Find_By_Cmnt");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cmnt_id", Key);                
                DT = Obj_Cls_Db.Read(cmd);
            }
            catch { }
            return DT;
        }
    }
}