using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace MAS
{
    class Cls_Committee_Master
    {

        Cls_Db obj_db;

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

        int strength;
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        string dos;
        public string Dos
        {
            get { return dos; }
            set { dos = value; }
        }

        string doe;
        public string Doe
        {
            get { return doe; }
            set { doe = value; }
        }

        string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        DateTime l_update;
        public DateTime L_update
        {
            get { return l_update; }
            set { l_update = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }


        public int Committee_Master_Get_Id()
        {
            int rtn_flag = 0;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Master_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                rtn_flag = obj_db.Exec_Scalar(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public DataTable Committee_Master_Select_All()
        {
            DataTable DT=new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Master_Select_All");
                DT = obj_db.Read(cmd);              
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Committee_Master_Find_Cmty_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Master_Find_Cmty_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cmty_Id", Cmty_id);                
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
        public DataTable Committee_Master_Find_Cmty_Year()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Master_Find_Cmty_Year");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cmty_Year", Cmty_year);
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
      
        public int Committee_Master_Save()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Master_Insert");
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Cmty_Year",Cmty_year);
                cmd.Parameters.AddWithValue("@Strength",Strength);
                cmd.Parameters.AddWithValue("@Dos",Dos);
                cmd.Parameters.AddWithValue("@Doe",Doe);
                cmd.Parameters.AddWithValue("@Message",Message);
                cmd.Parameters.AddWithValue("@L_Update",L_update);
                cmd.Parameters.AddWithValue("@Status",Status);
                cmd.Parameters.AddWithValue("@Note", Note);

                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch
            {
                
            }
            return rtn_flag;
        }

        public int Committee_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Master_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cmty_Id", Cmty_id);
                cmd.Parameters.AddWithValue("@Cmty_Year", Cmty_year);
                cmd.Parameters.AddWithValue("@Strength", Strength);
                cmd.Parameters.AddWithValue("@Dos", Dos);
                cmd.Parameters.AddWithValue("@Doe", Doe);
                cmd.Parameters.AddWithValue("@Message", Message);
                cmd.Parameters.AddWithValue("@L_Update", L_update);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Note", Note);

                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Committee_Master_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Committee_Master_Delete");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cmty_Id", Cmty_id);                
                rtn_flag = obj_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }
    }
}
