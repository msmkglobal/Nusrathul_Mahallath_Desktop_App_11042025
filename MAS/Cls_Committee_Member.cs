using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace MAS
{
    class Cls_Committee_Member
    {
        Cls_Db obj_db;


        string keys;
        public string Keys
        {
            get { return keys; }
            set { keys = value; }
        }

        int mem_id;
        public int Mem_id
        {
            get { return mem_id; }
            set { mem_id = value; }
        }

        int cmty_id;
        public int Cmty_id
        {
            get { return cmty_id; }
            set { cmty_id = value; }
        }

        string cmty_year;
        public string Cmty_year
        {
            get { return cmty_year; }
            set { cmty_year = value; }
        }

        int cmnty_id;
        public int Cmnty_id
        {
            get { return cmnty_id; }
            set { cmnty_id = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string designation;
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        string contact_num;
        public string Contact_num
        {
            get { return contact_num; }
            set { contact_num = value; }
        }

        byte[] photo;
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        byte[] signature;
        public byte[] Signature
        {
            get { return signature; }
            set { signature = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }    


        public int Committee_Member_Get_Id()
        {
            int rtn_flag =0;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Member_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                rtn_flag = obj_db.Exec_Scalar(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public DataTable Committee_Member_Select_All()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Member_Select_All");
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Committee_Member_Find_By_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Member_Find_By_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mem_Id", Mem_id);              
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Committee_Member_Find_By_Keys()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Member_Select_By_Keys");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keys",Keys);
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public int Committee_Member_Save()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Member_Insert");

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cmty_Id", Cmty_id);
                cmd.Parameters.AddWithValue("@Cmty_Year", Cmty_year);
                cmd.Parameters.AddWithValue("@Cmnty_Id", Cmnty_id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Contact_Num", Contact_num);
                cmd.Parameters.AddWithValue("@Photo", Photo);
                cmd.Parameters.AddWithValue("@Signature", Signature);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Description", Description);

                rtn_flag = obj_db.Execute_Non(cmd);
            }
            catch
            {

            }
            return rtn_flag;
        }

        public int Committee_Member_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Member_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Mem_Id", Mem_id);
                cmd.Parameters.AddWithValue("@Cmty_Id", Cmty_id);
                cmd.Parameters.AddWithValue("@Cmty_Year", Cmty_year);
                cmd.Parameters.AddWithValue("@Cmnty_Id", Cmnty_id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Contact_Num", Contact_num);
                cmd.Parameters.AddWithValue("@Photo", Photo);
                cmd.Parameters.AddWithValue("@Signature", Signature);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Description", Description);

                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Committee_Member_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Member_Delete");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mem_Id", Mem_id);
                rtn_flag = obj_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }


    }
}
