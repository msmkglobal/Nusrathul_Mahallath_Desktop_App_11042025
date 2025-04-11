using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{
    class Cls_Common_search
    {
        Cls_Db obj_cls_db;

        string key;
        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public DataTable Commonsearch_Residense_By_Commnity()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Commonsearch_residense_by_commnity");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEY",Key);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Commonsearch_Residense()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Commonsearch_residense");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEY", Key);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Commonsearch_Commnity()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Commonsearch_Commnity");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEY", Key);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
    }
}
