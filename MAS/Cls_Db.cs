using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace MAS
{
    class Cls_Db
    {
       
        //Development 
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQH6DVK\\SQLEXPRESS;Initial Catalog=TVMPPMJ2018;Persist Security Info=True;User ID=sa;Password=dbadmin@2025");

        //TVMPPMJ KANIYAPURAM PRODUCTION DB
        SqlConnection con = new SqlConnection("Server=206.189.140.214;Initial Catalog=KL1M1_PPMJ2025;Persist Security Info=True;User ID=sa;Password=dbadmin@2025");

        public int Execute_Non(SqlCommand cmd)//for isert and update
        {
            int rtn_flag = -1;
            try
            {
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                rtn_flag = cmd.ExecuteNonQuery();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString(), "Database Error[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                con.Close(); 
            }
            return rtn_flag;
        }

        public DataTable Read(SqlCommand cmd)//for read data to data table
        {
            DataTable DT = new DataTable();
            try
            {
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(DT);
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message.ToString()); 
            }
            finally 
            { 
                con.Close(); 
            }
            return DT;
        }

        public int Exec_Scalar(SqlCommand cmd)//for count from table reows
        {
            int rtn_flag = 0;
            try
            {
                cmd.Connection = con;
                if (con.State != ConnectionState.Open)
                    con.Open();
                rtn_flag = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch { }
            finally { con.Close(); }
            return rtn_flag;
        }      

    }
}
