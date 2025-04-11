using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MAS
{
    class Cls_Job_Master
    {
        Cls_Db Obj_Cls_Db;
        string key;
        public string Key
        {
          get { return key; }
          set { key = value; }
        }
       

        int job_Id;
        public int Job_Id
        {
          get { return job_Id; }
          set { job_Id = value; }
        }
        

        string mode;
        public string Mode
        {
          get { return mode; }
          set { mode = value; }
        }
        

        string cmnt_Id;
        public string Cmnt_Id
        {
          get { return cmnt_Id; }
          set { cmnt_Id = value; }
        }
        

        string job_Type;
        public string Job_Type
        {
          get { return job_Type; }
          set { job_Type = value; }
        }
        

        string designation;
        public string Designation
        {
          get { return designation; }
          set { designation = value; }
        }
        

        string employer;

        public string Employer
        {
          get { return employer; }
          set { employer = value; }
        }
        

        string address;

        public string Address
        {
          get { return address; }
          set { address = value; }
        }
        

        string district;

        public string District
        {
          get { return district; }
          set { district = value; }
        }
        

        string state;

        public string State
        {
          get { return state; }
          set { state = value; }
        }
       

        string country;

        public string Country
        {
          get { return country; }
          set { country = value; }
        }
        

        string contact_Num;

        public string Contact_Num
        {
          get { return contact_Num; }
          set { contact_Num = value; }
        }
                    

        string joining_Date;

        public string Joining_Date
        {
          get { return joining_Date; }
          set { joining_Date = value; }
        }
               

        string resignation_Date;

        public string Resignation_Date
        {
          get { return resignation_Date; }
          set { resignation_Date = value; }
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
                
        public int Job_Master_Get_Id()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Job_Master_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                rtn_flag = Obj_Cls_Db.Exec_Scalar(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public int Job_Master_Save()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                 SqlCommand cmd = new SqlCommand("Job_Master_Insert_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MODE","INSERT_VALUE");

                cmd.Parameters.AddWithValue("@Job_Id",Job_Id);
                cmd.Parameters.AddWithValue("@Cmnt_Id", Cmnt_Id);
                cmd.Parameters.AddWithValue("@Job_Type", Job_Type);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Employer", Employer);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@District", District);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Country", Country);
                cmd.Parameters.AddWithValue("@Contact_Num", Contact_Num);
                cmd.Parameters.AddWithValue("@Join_Date", Joining_Date);
                cmd.Parameters.AddWithValue("@Resign_Date", Resignation_Date);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Created", Created);
                cmd.Parameters.AddWithValue("@Modified", Modified);
                cmd.Parameters.AddWithValue("@Status", Status);
                rtn_flag = Obj_Cls_Db.Execute_Non(cmd);

            }
            catch { }
            return rtn_flag;
        }
        public int Job_Master_Delete()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Job_Master_Delete");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK", Job_Id);
                rtn_flag = Obj_Cls_Db.Execute_Non(cmd);
            }
            catch { }
            return rtn_flag;
        }
        public int Job_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Job_Master_Insert_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MODE","UPDATE_VALUE");

                cmd.Parameters.AddWithValue("@Job_Id", Job_Id);
                cmd.Parameters.AddWithValue("@Cmnt_Id", Cmnt_Id);
                cmd.Parameters.AddWithValue("@Job_Type", Job_Type);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Employer", Employer);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@District", District);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Country", Country);
                cmd.Parameters.AddWithValue("@Contact_Num", Contact_Num);
                cmd.Parameters.AddWithValue("@Join_Date", Joining_Date);
                cmd.Parameters.AddWithValue("@Resign_Date", Resignation_Date);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Created", Created);
                cmd.Parameters.AddWithValue("@Modified", Modified);
                cmd.Parameters.AddWithValue("@Status", Status);

                rtn_flag = Obj_Cls_Db.Execute_Non(cmd);

            }
            catch { }
            return rtn_flag;
        }
        public DataTable Job_Master_Find_PK()
        {
            Obj_Cls_Db = new Cls_Db();
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Job_Master_Find_By_Pk");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK",Key);
                DT = Obj_Cls_Db.Read(cmd);
            }
            catch { }
            return DT;
        }
        public DataTable Job_Master_Find_By_Key()
        {
            Obj_Cls_Db = new Cls_Db();
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Job_Master_Find_By_Key");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEY", Key);
                DT = Obj_Cls_Db.Read(cmd);
            }
            catch { }
            return DT;
        }
        public DataTable Job_Master_Find_By_Cmnt()
        {
            Obj_Cls_Db = new Cls_Db();
            DataTable DT = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Job_Master_Find_By_Cmnty_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cmnt_id", Key );
                DT = Obj_Cls_Db.Read(cmd);
            }
            catch { }
            return DT;
        }

    }
}
