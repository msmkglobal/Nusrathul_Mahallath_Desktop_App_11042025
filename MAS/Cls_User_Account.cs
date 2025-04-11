using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{
    class Cls_User_Account
    {
        string user_id;
        Cls_Db obj_db;
        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        string user_name;
        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        byte[] photo;
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string paswd_old;
        public string Paswd_old
        {
            get { return paswd_old; }
            set { paswd_old = value; }
        }

        public int User_Account_Save()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("User_Account_Insert");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id",User_id);
                cmd.Parameters.AddWithValue("@user_name",User_name);
                cmd.Parameters.AddWithValue("@password",Password);
                cmd.Parameters.AddWithValue("@type",Type);
                cmd.Parameters.AddWithValue("@photo",Photo);
                cmd.Parameters.AddWithValue("@status",Status);
                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch { }
            return rtn_flag;
        }
        public DataTable User_Account_Select_All()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("User_Account_Select_All");
                cmd.CommandType = CommandType.StoredProcedure;
                DT = obj_db.Read(cmd);

            }
            catch { }
            return DT;            
        }

        public DataTable User_Account_Select_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("User_Account_Select_User_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_id", User_id);
                DT = obj_db.Read(cmd);

            }
            catch { }
            return DT;            
        }
        public int User_Account_Change_Paswd()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("User_Account_Change_Paswd");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_id", User_id);
                cmd.Parameters.AddWithValue("@password_old",Paswd_old);
                cmd.Parameters.AddWithValue("@password",Password);
                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch { }
            return rtn_flag;
        }
        public DataTable User_Account_Login()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("User_Account_Login");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_Id", User_id);
                cmd.Parameters.AddWithValue("@Password", Password);
                DT = obj_db.Read(cmd);
            }
            catch { }
            return DT;
        }


    }
}
