using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MAS
{
    class Cls_Food_Master
    {
        Cls_Db obj_cls_obj;


        string keys;
        public string Keys
        {
            get { return keys; }
            set { keys = value; }
        }

        int resi_id;
        public int Resi_id
        {
            get { return resi_id; }
            set { resi_id = value; }
        }

        string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        string breakfast;
        public string Breakfast
        {
            get { return breakfast; }
            set { breakfast = value; }
        }

        string lunch;
        public string Lunch
        {
            get { return lunch; }
            set { lunch = value; }
        }

        string tea;
        public string Tea
        {
            get { return tea; }
            set { tea = value; }
        }

        string supper;
        public string Supper
        {
            get { return supper; }
            set { supper = value; }
        }

        string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Food_Master_Insert()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_obj = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Food_Master_Insert");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Resi_Id", Resi_id);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Breakfast", Breakfast);
                cmd.Parameters.AddWithValue("Lunch", Lunch);
                cmd.Parameters.AddWithValue("Tea", Tea);
                cmd.Parameters.AddWithValue("Supper", Supper);
                cmd.Parameters.AddWithValue("Description", Description);
                rtn_flag = obj_cls_obj.Execute_Non(cmd);                
                
            }
            catch { }
            return rtn_flag;
        }

        public int Food_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_obj = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Food_Master_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Resi_Id", Resi_id);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Breakfast", Breakfast);
                cmd.Parameters.AddWithValue("@Lunch", Lunch);
                cmd.Parameters.AddWithValue("@Tea", Tea);
                cmd.Parameters.AddWithValue("@Supper", Supper);
                cmd.Parameters.AddWithValue("@Description", Description);
                rtn_flag = obj_cls_obj.Execute_Non(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public int Food_Master_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_obj = new Cls_Db();
                SqlCommand cmd = new SqlCommand("");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Resi_Id", Resi_id);                
                rtn_flag = obj_cls_obj.Execute_Non(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public DataTable Food_Master_Select_All()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_obj = new Cls_Db();
                SqlCommand cmd = new SqlCommand("");
                cmd.CommandType = CommandType.StoredProcedure;

                DT = obj_cls_obj.Read(cmd);
            }
            catch { }
            return DT;
        }

        public DataTable Food_Master_Select_Resi_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_obj = new Cls_Db();
                SqlCommand cmd = new SqlCommand("");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Resi_Id", Resi_id);
                DT = obj_cls_obj.Read(cmd);
            }
            catch { }
            return DT;
        }

        public DataTable Food_Master_Select_By_Keys()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_obj = new Cls_Db();
                SqlCommand cmd = new SqlCommand("");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Keys",Keys);
                DT = obj_cls_obj.Read(cmd);
            }
            catch { }
            return DT;
        }




    }
}
