using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{
    class Cls_Residence_Master
    {
        Cls_Db obj_db;
        string keys;
        public string Keys
        {
            get { return keys; }
            set { keys = value; }
        }

        string rid;
        public string Rid
        {
            get { return rid; }
            set { rid = value; }
        }
        
        string reg_date;
        public string Reg_date
        {
            get { return reg_date; }
            set { reg_date = value; }
        }

        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string fmly_type;
        public string Fmly_type
        {
            get { return fmly_type; }
            set { fmly_type = value; }
        }
        string famlyclass;
        public string Famlyclass
        {
            get { return famlyclass; }
            set { famlyclass = value; }
        }

        string relocated;
        public string Relocated
        {
            get { return relocated; }
            set { relocated = value; }
        }
        

        string bldg_num;
        public string Bldg_num
        {
            get { return bldg_num; }
            set { bldg_num = value; }
        }

        string ward_num;
        public string Ward_num
        {
            get { return ward_num; }
            set { ward_num = value; }
        }

        string pnj_name;
        public string Pnj_name
        {
            get { return pnj_name; }
            set { pnj_name = value; }
        }

        string panchayat_ward;
        public string Panchayat_ward
        {
            get { return panchayat_ward; }
            set { panchayat_ward = value; }
        }

        string block_num;
        public string Block_num
        {
            get { return block_num; }
            set { block_num = value; }
        }

        string district;
        public string District
        {
            get { return district; }
            set { district = value; }
        }

        string owner_name;
        public string Owner_name
        {
            get { return owner_name; }
            set { owner_name = value; }
        }

        string resi_name;
        public string Resi_name
        {
            get { return resi_name; }
            set { resi_name = value; }
        }

        int male;
        public int Male
        {
            get { return male; }
            set { male = value; }
        }

        int female;
        public int Female
        {
            get { return female; }
            set { female = value; }
        }

        int total_mem;
        public int Total_mem
        {
            get { return total_mem; }
            set { total_mem = value; }
        }

        string place;
        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        string post;
        public string Post
        {
            get { return post; }
            set { post = value; }
        }        

        int pincode;
        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        string mobile;
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        string fmly_income;
        public string Fmly_income
        {
            get { return fmly_income; }
            set { fmly_income = value; }
        }
        

        string poverty;
        public string Poverty
        {
            get { return poverty; }
            set { poverty = value; }
        }

        string rnc_num;
        public string Rnc_num
        {
            get { return rnc_num; }
            set { rnc_num = value; }
        }

        string property;
        public string Property
        {
            get { return property; }
            set { property = value; }
        }

        string narration;
        public string Narration
        {
            get { return narration; }
            set { narration = value; }
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

        string deleted;
        public string Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        string user_id;
        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        
        //public int Residence_Get_Id()
        //{
        //    int rtn_flag = -1;
        //    try
        //    {
        //        obj_db = new Cls_Db();
        //        SqlCommand cmd = new SqlCommand("Residence_Get_Id");
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        rtn_flag = obj_db.Exec_Scalar(cmd);

        //    }
        //    catch { }
        //    return rtn_flag;
        //}

        public DataTable Residence_Select_All()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_Select_All");
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
        
        public DataTable Residence_Master_Select_By_Keyword()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_Master_Select_By_Keyword");
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@RNAME", Resi_name);
                cmd.Parameters.AddWithValue("@WARDNUM", Ward_num);
                cmd.Parameters.AddWithValue("@ROWNER", Owner_name);
                cmd.Parameters.AddWithValue("@MOBILE", Mobile);
                
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Residence_Find_Resi_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_Find_Resi_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Resi_Id", Rid);
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Residence_Find_By_Key_lookup()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_Find_By_key_lookup");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Key",Keys);
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Residence_pk_chek()
        {
            DataTable DT = new DataTable();
            
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_master_pk_chek");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RID", Rid);
                DT = obj_db.Read(cmd);

            }
            catch
            {
            }
            return DT;
        }

        public int Residence_Master_Insert()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_Master_Insert");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RID", Rid);
                cmd.Parameters.AddWithValue("@REG_DATE", Reg_date);
                cmd.Parameters.AddWithValue("@RTYPE",Type);
                cmd.Parameters.AddWithValue("@FAMILY_TYPE", Fmly_type);
                cmd.Parameters.AddWithValue("@FAMILY_CLASS", Famlyclass);
                cmd.Parameters.AddWithValue("@RL_DETAIL",Relocated);
                cmd.Parameters.AddWithValue("@BLDGNUM",Bldg_num);
                cmd.Parameters.AddWithValue("@WARDNUM",Ward_num);
                cmd.Parameters.AddWithValue("@PANCHAYATH", Pnj_name);
                cmd.Parameters.AddWithValue("@PANCHAYATWARD", Panchayat_ward);
                cmd.Parameters.AddWithValue("@BLOCK", Block_num);
                cmd.Parameters.AddWithValue("@DISTRICT", District);
                cmd.Parameters.AddWithValue("@RNAME", Resi_name);
                cmd.Parameters.AddWithValue("@ROWNER", Owner_name);
                cmd.Parameters.AddWithValue("@AREA", Place);
                cmd.Parameters.AddWithValue("@POST", Post);                
                cmd.Parameters.AddWithValue("@PINCODE", Pincode);
                cmd.Parameters.AddWithValue("@PHONE", Phone);
                cmd.Parameters.AddWithValue("@MOBILE", Mobile);
                cmd.Parameters.AddWithValue("@RSTRENGTH", Total_mem);
                cmd.Parameters.AddWithValue("@MALE", Male);
                cmd.Parameters.AddWithValue("@FEMALE", Female);
                cmd.Parameters.AddWithValue("@INCOME", fmly_income);
                cmd.Parameters.AddWithValue("@POVERTY", Poverty);
                cmd.Parameters.AddWithValue("@RCN", Rnc_num);
                cmd.Parameters.AddWithValue("@PROPERTY", Property);
                cmd.Parameters.AddWithValue("@NARRATION", Narration);
                cmd.Parameters.AddWithValue("@CREATED",Created);
                cmd.Parameters.AddWithValue("@MODIFIED",Modified);
                cmd.Parameters.AddWithValue("@DELETED",Deleted);
                cmd.Parameters.AddWithValue("@USERID",User_id);
                cmd.Parameters.AddWithValue("@STATUS",Status);
                rtn_flag = obj_db.Execute_Non(cmd);
            }
            catch
            {

            }
            return rtn_flag;
        }

        public int Residence_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_Master_Update");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RID", Rid);
                cmd.Parameters.AddWithValue("@REG_DATE", Reg_date);
                cmd.Parameters.AddWithValue("@RTYPE", Type);
                cmd.Parameters.AddWithValue("@FAMILY_TYPE", Fmly_type);
                cmd.Parameters.AddWithValue("@FAMILY_CLASS", Famlyclass);
                cmd.Parameters.AddWithValue("@RL_DETAIL", Relocated);
                cmd.Parameters.AddWithValue("@BLDGNUM", Bldg_num);
                cmd.Parameters.AddWithValue("@WARDNUM", Ward_num);
                cmd.Parameters.AddWithValue("@PANCHAYATH", Pnj_name);
                cmd.Parameters.AddWithValue("@PANCHAYATWARD", Panchayat_ward);
                cmd.Parameters.AddWithValue("@BLOCK", Block_num);
                cmd.Parameters.AddWithValue("@DISTRICT", District);
                cmd.Parameters.AddWithValue("@RNAME", Resi_name);
                cmd.Parameters.AddWithValue("@ROWNER", Owner_name);
                cmd.Parameters.AddWithValue("@AREA", Place);
                cmd.Parameters.AddWithValue("@POST", Post);                
                cmd.Parameters.AddWithValue("@PINCODE", Pincode);
                cmd.Parameters.AddWithValue("@PHONE", Phone);
                cmd.Parameters.AddWithValue("@MOBILE", Mobile);
                cmd.Parameters.AddWithValue("@RSTRENGTH", Total_mem);
                cmd.Parameters.AddWithValue("@MALE", Male);
                cmd.Parameters.AddWithValue("@FEMALE", Female);
                cmd.Parameters.AddWithValue("@INCOME", fmly_income);
                cmd.Parameters.AddWithValue("@POVERTY", Poverty);
                cmd.Parameters.AddWithValue("@RCN", Rnc_num);
                cmd.Parameters.AddWithValue("@PROPERTY", Property);
                cmd.Parameters.AddWithValue("@NARRATION", Narration);
                //cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                //cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", User_id);
                cmd.Parameters.AddWithValue("@STATUS", Status);

                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch
            {

            }
            return rtn_flag;
        }

        public int Residence_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Residence_Delete");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Resi_Id", Rid);
                rtn_flag = obj_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public DataTable Residence_Passbook_Print_Frontpage()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RESIDENCE_PASSBOOK_PRINT_FRONTPAGE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RID", Rid);
                DT = obj_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

    }
}
