using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{
    class Cls_Community_Master
    {
        Cls_Db obj_cls_db;


        string keys;
        public string Keys
        {
            get { return keys; }
            set { keys = value; }
        }
        string cmnty_id;
        public string Cmnty_id
        {
            get { return cmnty_id; }
            set { cmnty_id = value; }
        }


        string resi_id; 
        public string Resi_id
        {
            get { return resi_id; }
            set { resi_id = value; }
        }
       

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        string dob;
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        string mstatus;
        public string Mstatus
        {
            get { return mstatus; }
            set { mstatus = value; }
        }

        string relation;
        public string Relation
        {
            get { return relation; }
            set { relation = value; }
        }

        string b_group;
        public string B_group
        {
            get { return b_group; }
            set { b_group = value; }
        }

        string health_status;
        public string Health_status
        {
            get { return health_status; }
            set { health_status = value; }
        }

        string phc;
        public string Phc
        {
            get { return phc; }
            set { phc = value; }
        }

        string pspt_num;
        public string Pspt_num
        {
            get { return pspt_num; }
            set { pspt_num = value; }
        }
        string lplace;
        public string Lplace
        {
            get { return lplace; }
            set { lplace = value; }
        }
        string dlc;
        public string Dlc
        {
            get { return dlc; }
            set { dlc = value; }
        }

        string uaid;
        public string Uaid
        {
            get { return uaid; }
            set { uaid = value; }
        }

        string occupation;
        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
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

        string hajj_done;
        public string Hajj_done
        {
            get { return hajj_done; }
            set { hajj_done = value; }
        }

        string dod;
        public string Dod
        {
            get { return dod; }
            set { dod = value; }
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
        string userid;
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        string narration;
        public string Narration
        {
            get { return narration; }
            set { narration = value; }
        }

        string printed;
        public string Printed
        {
            get { return printed; }
            set { printed = value; }
        }

        string mode;
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        //functions

        public int Community_Master_Get_Id()
        {
            int rtn_flag = 0;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                rtn_flag = obj_cls_db.Exec_Scalar(cmd);
            }
            catch { }
            return rtn_flag;
        }

        public int Community_Master_Insert()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Insert");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CMNTID", Cmnty_id);
                cmd.Parameters.AddWithValue("@RID",Resi_id);
                cmd.Parameters.AddWithValue("@NAME",Name);
                cmd.Parameters.AddWithValue("@GENDER",Gender);
                cmd.Parameters.AddWithValue("@DOB",Dob);
                cmd.Parameters.AddWithValue("@AGE", Age);
                cmd.Parameters.AddWithValue("@MSTATUS",Mstatus);
                cmd.Parameters.AddWithValue("@RELATION",Relation);
                cmd.Parameters.AddWithValue("@BGROUP",B_group);
                cmd.Parameters.AddWithValue("@HLS", Health_status);
                cmd.Parameters.AddWithValue("@PHC", Phc);
                cmd.Parameters.AddWithValue("@UAID", Uaid);
                cmd.Parameters.AddWithValue("@PSPTN",Pspt_num);
                cmd.Parameters.AddWithValue("@DLN", Dlc);                
                cmd.Parameters.AddWithValue("@PROFESSION",Occupation);
                cmd.Parameters.AddWithValue("@LPLACE",Lplace);
                cmd.Parameters.AddWithValue("@EMAIL",Email);
                cmd.Parameters.AddWithValue("@CONTACT", Contact);
                cmd.Parameters.AddWithValue("@HAJJ", Hajj_done);                               
                cmd.Parameters.AddWithValue("@DOD",Dod);
                cmd.Parameters.AddWithValue("@PHOTO", Photo); 
                cmd.Parameters.AddWithValue("NARRATION", Narration);
                cmd.Parameters.AddWithValue("@CREATED",Created);
                cmd.Parameters.AddWithValue("@MODIFIED",Modified);
                cmd.Parameters.AddWithValue("@DELETED",Deleted);
                cmd.Parameters.AddWithValue("@USERID",Userid);
                cmd.Parameters.AddWithValue("@PRINTED", Printed);
                cmd.Parameters.AddWithValue("@STATUS", Status);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Community_Master_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Update");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CMNTID", Cmnty_id);
                cmd.Parameters.AddWithValue("@RID", Resi_id);
                cmd.Parameters.AddWithValue("@NAME", Name);
                cmd.Parameters.AddWithValue("@GENDER", Gender);
                cmd.Parameters.AddWithValue("@DOB", Dob);
                cmd.Parameters.AddWithValue("@MSTATUS", Mstatus);
                cmd.Parameters.AddWithValue("@RELATION", Relation);
                cmd.Parameters.AddWithValue("@BGROUP", B_group);
                cmd.Parameters.AddWithValue("@HLS", Health_status);
                cmd.Parameters.AddWithValue("@PHC", Phc);
                cmd.Parameters.AddWithValue("@UAID", Uaid);
                cmd.Parameters.AddWithValue("@PSPTN", Pspt_num);
                cmd.Parameters.AddWithValue("@DLN", Dlc);
                cmd.Parameters.AddWithValue("@PROFESSION", Occupation);
                cmd.Parameters.AddWithValue("@LPLACE", Lplace);
                cmd.Parameters.AddWithValue("@EMAIL", Email);
                cmd.Parameters.AddWithValue("@CONTACT", Contact);                
                cmd.Parameters.AddWithValue("@HAJJ", Hajj_done);
                cmd.Parameters.AddWithValue("@DOD", Dod);
                cmd.Parameters.AddWithValue("@PHOTO", Photo);
                cmd.Parameters.AddWithValue("NARRATION", Narration);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@STATUS", Status);

                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Community_Master_Delete()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Delete");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CMNTID", Cmnty_id);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public DataTable Community_Select_All()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Select_All");
                cmd.CommandType = CommandType.StoredProcedure;
                DT = obj_cls_db.Read(cmd);             
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Community_Select_By_Cmnty_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Select_By_Cmnty_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@key",Keys);                
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Community_Master_Select_By_Keys()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Select_By_Keys");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keys",Keys);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Community_Master_Select_By_Resi_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_COMMUNITY_MASTER");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE", Mode);
                cmd.Parameters.AddWithValue("@RID", Resi_id);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Education_Find_By_Key_lookup()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Community_Master_Select_By_Key_Lookup");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Key", Keys);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Commuinty_Master_Get_rid()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Commuinty_Master_Get_rid");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Key",Keys);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Commuinty_Passbook_Print_P4P5()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("COMMUNITY_PASSBOOK_PRINT_P4P5");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RID", resi_id);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
        public int Community_Passbook_Print_Update_P4P5()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_COMMUNITY_MASTER");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE", "COMMUNITY_MASTER_PASSBOOK_PRINT_P4P5_UPDATE");
                cmd.Parameters.AddWithValue("@RID", Resi_id);
                cmd.Parameters.AddWithValue("@PRINTED", Printed);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;
        }

        public int Community_Passbook_Print_Update_P4P5_By_Rid_Cmntid()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_COMMUNITY_MASTER");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE", "COMMUNITY_MASTER_PASSBOOK_PRINT_UPDATE_BY_CMNTID");
                cmd.Parameters.AddWithValue("@RID", Resi_id);
                cmd.Parameters.AddWithValue("@CMNTID", Cmnty_id);
                cmd.Parameters.AddWithValue("@PRINTED", Printed);
                cmd.Parameters.AddWithValue("@NARRATION", Narration);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {

            }
            finally
            { }
            return rtn_flag;
        }

        public DataTable community_master_election_list_print()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("COMMUNITY_MASTER_ELECTION_LIST_PRINT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RID", resi_id);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
    
        
    }
}
