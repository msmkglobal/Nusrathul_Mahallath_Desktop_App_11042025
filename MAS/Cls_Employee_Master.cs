using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MAS
{
    class Cls_Employee_Master
    {
        Cls_Db obj_cls_db;

        string keys;
        public string Keys
        {
            get { return keys; }
            set { keys = value; }
        }

        int emp_id;
        public int Emp_id
        {
            get { return emp_id; }
            set { emp_id = value; }
        }

        string emp_name;
        public string Emp_name
        {
            get { return emp_name; }
            set { emp_name = value; }
        }

        string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        int pin;
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        DateTime dob;
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        string contact;
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        byte[] photo;
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        string designation;
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        string qualification;
        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
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

        public int Employee_Master_Get_Id()
        {
            int rtn_flag = 0;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Employee_Master_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                rtn_flag = obj_cls_db.Exec_Scalar(cmd);

            }
            catch { }
            return rtn_flag;
        }

        public int Employee_Master_Insert()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Employee_Master_Insert");
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@Emp_Name", Emp_name);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Pin", Pin);
                cmd.Parameters.AddWithValue("@Dob", Dob);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@Photo", Photo);
                cmd.Parameters.AddWithValue("@Designation", Description);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.Parameters.AddWithValue("@Qualification", Qualification);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Description", Description);
                rtn_flag = obj_cls_db.Execute_Non(cmd);

            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Employee_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Employee_Master_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Emp_Id", Emp_id);
                cmd.Parameters.AddWithValue("@Emp_Name", Emp_name);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Pin", Pin);
                cmd.Parameters.AddWithValue("@Dob", Dob);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@Photo", Photo);
                cmd.Parameters.AddWithValue("@Designation",Designation);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.Parameters.AddWithValue("@Qualification", Qualification);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Descripton",Description );
                rtn_flag = obj_cls_db.Execute_Non(cmd);

            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Employee_Master_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Employee_Master_Delete");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Emp_Id", Emp_id);                
                rtn_flag = obj_cls_db.Execute_Non(cmd);

            }
            catch
            {
            }
            return rtn_flag;
        }

        public DataTable Employee_Master_Select_All()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Employee_Master_Select_All");
                cmd.CommandType = CommandType.StoredProcedure;
                DT = obj_cls_db.Read(cmd);               
                
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Employee_Master_Select_By_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Employee_Master_Select_By_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_Id", Emp_id);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Employee_Master_Select_By_Keys()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Employee_Master_Select_By_Keys");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Keys",Keys);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
    }
}
