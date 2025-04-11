using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MAS
{
    class Class_Idmaster
    {
        Cls_Db Obj_Database;

        string mode;
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        string relation;
        public string Relation
        {
            get { return relation; }
            set { relation = value; }
        }

        string atribute;
        public string Atribute
        {
            get { return atribute; }
            set { atribute = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public DataTable Idmaster_Select_All_By_Reletion_Atribute()
        {
            DataTable DT=new DataTable();
            try
            {
                Obj_Database = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_IDMASTER");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE",Mode);
                cmd.Parameters.AddWithValue("@RELATION", Relation);
                cmd.Parameters.AddWithValue("@ATRIBUTE",Atribute);
                cmd.Parameters.AddWithValue("@STATUS",Status);
                DT = Obj_Database.Read(cmd);
            }
            catch { }
            return DT;
        }
    }
}
