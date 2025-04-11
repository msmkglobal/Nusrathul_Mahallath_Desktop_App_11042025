using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MAS
{
    class Cls_Marriage
    { 
        Cls_Db obj_cls_db;
        string marriageid;

        public string Marriageid
        {
            get { return marriageid; }
            set { marriageid = value; }
        }
        string groomcmntid;

        public string Groomcmntid
        {
            get { return groomcmntid; }
            set { groomcmntid = value; }
        }
        string groomresdid;

        public string Groomresdid
        {
            get { return groomresdid; }
            set { groomresdid = value; }
        }
        string groomname;

        public string Groomname
        {
            get { return groomname; }
            set { groomname = value; }
        }
        string groomfather;

        public string Groomfather
        {
            get { return groomfather; }
            set { groomfather = value; }
        }
        string groomaddress;

        public string Groomaddress
        {
            get { return groomaddress; }
            set { groomaddress = value; }
        }
        int groompincode;

        public int Groompincode
        {
            get { return groompincode; }
            set { groompincode = value; }
        }
        string groomdistrict;

        public string Groomdistrict
        {
            get { return groomdistrict; }
            set { groomdistrict = value; }
        }
        string groomstate;

        public string Groomstate
        {
            get { return groomstate; }
            set { groomstate = value; }
        }
        string groomcontactno;

        public string Groomcontactno
        {
            get { return groomcontactno; }
            set { groomcontactno = value; }
        }
        string groommahallu;

        public string Groommahallu
        {
            get { return groommahallu; }
            set { groommahallu = value; }
        }
        string bridecmntid;

        public string Bridecmntid
        {
            get { return bridecmntid; }
            set { bridecmntid = value; }
        }
        string brideresdid;

        public string Brideresdid
        {
            get { return brideresdid; }
            set { brideresdid = value; }
        }
        string bridename;

        public string Bridename
        {
            get { return bridename; }
            set { bridename = value; }
        }
        string bridefather;

        public string Bridefather
        {
            get { return bridefather; }
            set { bridefather = value; }
        }
        string brideaddress;

        public string Brideaddress
        {
            get { return brideaddress; }
            set { brideaddress = value; }
        }
        int bridepincode;

        public int Bridepincode
        {
            get { return bridepincode; }
            set { bridepincode = value; }
        }
        string bridedistrict;

        public string Bridedistrict
        {
            get { return bridedistrict; }
            set { bridedistrict = value; }
        }
        string bridestate;

        public string Bridestate
        {
            get { return bridestate; }
            set { bridestate = value; }
        }
        string bridecontactno;

        public string Bridecontactno
        {
            get { return bridecontactno; }
            set { bridecontactno = value; }
        }
        string bridemahallu;

        public string Bridemahallu
        {
            get { return bridemahallu; }
            set { bridemahallu = value; }
        }
        DateTime weddingdate;

        public DateTime Weddingdate
        {
            get { return weddingdate; }
            set { weddingdate = value; }
        }

        DateTime issuingdate;

        public DateTime Issuingdate
        {
            get { return issuingdate; }
            set { issuingdate = value; }
        }
        
        string witness1;

        public string Witness1
        {
            get { return witness1; }
            set { witness1 = value; }
        }
        string witness1contact;

        public string Witness1contact
        {
            get { return witness1contact; }
            set { witness1contact = value; }
        }
        string witness2;

        public string Witness2
        {
            get { return witness2; }
            set { witness2 = value; }
        }
        string witness2contact;

        public string Witness2contact
        {
            get { return witness2contact; }
            set { witness2contact = value; }
        }
        string witness3;

        public string Witness3
        {
            get { return witness3; }
            set { witness3 = value; }
        }
        string witness3contact;

        public string Witness3contact
        {
            get { return witness3contact; }
            set { witness3contact = value; }
        }
        string weddingplace;

        public string Weddingplace
        {
            get { return weddingplace; }
            set { weddingplace = value; }
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
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string keyword;

        public string Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }

        public int Marriage_Insert()
        {
           int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("MARRIAGE_INSERT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GROOMCMNTID", Groomcmntid);
                cmd.Parameters.AddWithValue("@GROOMRESDID", Groomresdid);
                cmd.Parameters.AddWithValue("@GROOMNAME", Groomname);
                cmd.Parameters.AddWithValue("@GROOMFATHER", Groomfather);
                cmd.Parameters.AddWithValue("@GROOMADDRESS", Groomaddress);
                cmd.Parameters.AddWithValue("@GROOMPINCODE", Groompincode);
                cmd.Parameters.AddWithValue("@GROOMDISTRICT",Groomdistrict);
                cmd.Parameters.AddWithValue("@GROOMSTATE",Groomstate);
                cmd.Parameters.AddWithValue("@GROOMCONTACTNO", Groomcontactno);
                cmd.Parameters.AddWithValue("@GROOMMAHALLU", Groommahallu);
                cmd.Parameters.AddWithValue("@BRIDECMNTID", Bridecmntid);
                cmd.Parameters.AddWithValue("@BRIDERESDID", Brideresdid);
                cmd.Parameters.AddWithValue("@BRIDENAME", Bridename);
                cmd.Parameters.AddWithValue("@BRIDEFATHER", Bridefather);
                cmd.Parameters.AddWithValue("@BRIDEADDRESS", Brideaddress);
                cmd.Parameters.AddWithValue("@BRIDEPINCODE", Bridepincode);
                cmd.Parameters.AddWithValue("@BRIDEDISTRICT", Bridedistrict);
                cmd.Parameters.AddWithValue("@BRIDESTATE", Bridestate);
                cmd.Parameters.AddWithValue("@BRIDECONTACTNO", Bridecontactno);
                cmd.Parameters.AddWithValue("@BRIDEMAHALLU", Bridemahallu);
                cmd.Parameters.AddWithValue("@MARRIAGEID", Marriageid);
                cmd.Parameters.AddWithValue("@WEDDINGDATE", Weddingdate);
                cmd.Parameters.AddWithValue("@ISSUINGDATE", Issuingdate);
                cmd.Parameters.AddWithValue("@WITNESS1", Witness1);
                cmd.Parameters.AddWithValue("@WITNESS1CONTACT", Witness1contact);
                cmd.Parameters.AddWithValue("@WITNESS2", Witness2);
                cmd.Parameters.AddWithValue("@WITNESS2CONTACT", Witness2contact);
                cmd.Parameters.AddWithValue("@WITNESS3", Witness3);
                cmd.Parameters.AddWithValue("@WITNESS3CONTACT", Witness3contact);
                cmd.Parameters.AddWithValue("@WEDDINGPLACE", Weddingplace);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@STATUS", Status);

                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;

        }

        public int Marriage_Update()
        {
            int rtn_flag = -1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("MARRIAGE_UPDATE");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GROOMCMNTID", Groomcmntid);
                cmd.Parameters.AddWithValue("@GROOMRESDID", Groomresdid);
                cmd.Parameters.AddWithValue("@GROOMNAME", Groomname);
                cmd.Parameters.AddWithValue("@GROOMFATHER", Groomfather);
                cmd.Parameters.AddWithValue("@GROOMADDRESS", Groomaddress);
                cmd.Parameters.AddWithValue("@GROOMPINCODE", Groompincode);
                cmd.Parameters.AddWithValue("@GROOMDISTRICT", Groomdistrict);
                cmd.Parameters.AddWithValue("@GROOMSTATE", Groomstate);
                cmd.Parameters.AddWithValue("@GROOMCONTACTNO", Groomcontactno);
                cmd.Parameters.AddWithValue("@GROOMMAHALLU", Groommahallu);
                cmd.Parameters.AddWithValue("@BRIDECMNTID", Bridecmntid);
                cmd.Parameters.AddWithValue("@BRIDERESDID", Brideresdid);
                cmd.Parameters.AddWithValue("@BRIDENAME", Bridename);
                cmd.Parameters.AddWithValue("@BRIDEFATHER", Bridefather);
                cmd.Parameters.AddWithValue("@BRIDEADDRESS", Brideaddress);
                cmd.Parameters.AddWithValue("@BRIDEPINCODE", Bridepincode);
                cmd.Parameters.AddWithValue("@BRIDEDISTRICT", Bridedistrict);
                cmd.Parameters.AddWithValue("@BRIDESTATE", Bridestate);
                cmd.Parameters.AddWithValue("@BRIDECONTACTNO", Bridecontactno);
                cmd.Parameters.AddWithValue("@BRIDEMAHALLU", Bridemahallu);
                cmd.Parameters.AddWithValue("@MARRIAGEID", Marriageid);
                cmd.Parameters.AddWithValue("@WEDDINGDATE", Weddingdate);
                cmd.Parameters.AddWithValue("@ISSUINGDATE", Issuingdate);
                cmd.Parameters.AddWithValue("@WITNESS1", Witness1);
                cmd.Parameters.AddWithValue("@WITNESS1CONTACT", Witness1contact);
                cmd.Parameters.AddWithValue("@WITNESS2", Witness2);
                cmd.Parameters.AddWithValue("@WITNESS2CONTACT", Witness2contact);
                cmd.Parameters.AddWithValue("@WITNESS3", Witness3);
                cmd.Parameters.AddWithValue("@WITNESS3CONTACT", Witness3contact);
                cmd.Parameters.AddWithValue("@WEDDINGPLACE", Weddingplace);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@STATUS", Status);

                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {
            }
            return rtn_flag;

        }

        public DataTable Marriage_Select_By_Keyword()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd= new SqlCommand("MARRIAGE_SELECT_BY_KEYWORD");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEYWORD",Keyword);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }

            return DT; 
        }

        public DataTable Marriage_Select_By_Marriageid()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("MARRIAGE_SELECT_BY_MARRIAGEID");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MARRIAGEID", Marriageid);
                DT = obj_cls_db.Read(cmd);
            }
            catch
            {
            }

            return DT;
        }

        public int Marriage_Delete()
        {
            int rtn_flag=-1;
            try
            {
                obj_cls_db = new Cls_Db();
                SqlCommand cmd=new SqlCommand("MARRIAGE_DELETE");
                cmd.CommandType =CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MARRIAGEID", Marriageid);
                rtn_flag = obj_cls_db.Execute_Non(cmd);
            }
            catch
            {

            }
            return rtn_flag;
        }

    }
}
