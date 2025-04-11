using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MAS
{
    class Cls_Marriage_Registration
    {
        Cls_Db Obj_cls_Db;

                int  rgn;
        public int Rgn
        {
          get { return rgn; }
          set { rgn = value; }
        }
                string    grgn;
        public string Grgn
        {
          get { return grgn; }
          set { grgn = value; }
        }
                string    cno;
        public string Cno
        {
          get { return cno; }
          set { cno = value; }
        }

        string    mdate;
        public string Mdate
        {
          get { return mdate; }
          set { mdate = value; }
        }
                string    mplace;
        public string Mplace
        {
          get { return mplace; }
          set { mplace = value; }
        }

                string    mname;

        public string Mname
        {
          get { return mname; }
          set { mname = value; }
        }
                string    mahar;

        public string Mahar
        {
          get { return mahar; }
          set { mahar = value; }
        }
                string    mconductor;

        public string Mconductor
        {
          get { return mconductor; }
          set { mconductor = value; }
        }
                string    crcvd;
        public string Crcvd
        {
          get { return crcvd; }
          set { crcvd = value; }
        }
                string    secretarary;
        public string Secretarary
        {
          get { return secretarary; }
          set { secretarary = value; }
        }
                string    president;
        public string President
        {
          get { return president; }
          set { president = value; }
        }
                string    bcmntid;
        public string Bcmntid
        {
          get { return bcmntid; }
          set { bcmntid = value; }
        }
                string    bname;
        public string Bname
        {
          get { return bname; }
          set { bname = value; }
        }
                string    bcontact;
        public string Bcontact
        {
          get { return bcontact; }
          set { bcontact = value; }
        }
                string    bdob;
        public string Bdob
        {
          get { return bdob; }
          set { bdob = value; }
        }
                string    bage;
        public string Bage
        {
          get { return bage; }
          set { bage = value; }
        }
                string    bjob;
        public string Bjob
        {
          get { return bjob; }
          set { bjob = value; }
        }
                string    bfather;
        public string Bfather
        {
          get { return bfather; }
          set { bfather = value; }
        }
                string    bmother;
        public string Bmother
        {
          get { return bmother; }
          set { bmother = value; }
        }
                string    bmahallu;
        public string Bmahallu
        {
          get { return bmahallu; }
          set { bmahallu = value; }
        }
                string    bhouse;
        public string Bhouse
        {
          get { return bhouse; }
          set { bhouse = value; }
        }
                string    bpost;
        public string Bpost
        {
          get { return bpost; }
          set { bpost = value; }
        }
                string    bdistrict;
        public string Bdistrict
        {
          get { return bdistrict; }
          set { bdistrict = value; }
        }
                string    bstate;
        public string Bstate
        {
          get { return bstate; }
          set { bstate = value; }
        }
                string    bcountry;
        public string Bcountry
        {
          get { return bcountry; }
          set { bcountry = value; }
        }
                string    bmcount;
        public string Bmcount
        {
          get { return bmcount; }
          set { bmcount = value; }
        }
                string    bmreason;
        public string Bmreason
        {
          get { return bmreason; }
          set { bmreason = value; }
        }
                byte[]  bphoto;
        public byte[] Bphoto
        {
          get { return bphoto; }
          set { bphoto = value; }
        }
                string    bwitness1;
        public string Bwitness1
        {
          get { return bwitness1; }
          set { bwitness1 = value; }
        }
                string    bwitness2;
        public string Bwitness2
        {
          get { return bwitness2; }
          set { bwitness2 = value; }
        }
                string    gcmntid;
        public string Gcmntid
        {
          get { return gcmntid; }
          set { gcmntid = value; }
        }
                string    gname;
        public string Gname
        {
          get { return gname; }
          set { gname = value; }
        }
                string    gcontact;
        public string Gcontact
        {
          get { return gcontact; }
          set { gcontact = value; }
        }
                string    gdob;
        public string Gdob
        {
          get { return gdob; }
          set { gdob = value; }
        }
                string    gage;
        public string Gage
        {
          get { return gage; }
          set { gage = value; }
        }
                string    gjob;
        public string Gjob
        {
          get { return gjob; }
          set { gjob = value; }
        }
                string    gfather;
        public string Gfather
        {
          get { return gfather; }
          set { gfather = value; }
        }
                string    gmother;
        public string Gmother
        {
          get { return gmother; }
          set { gmother = value; }
        }
                string    gmahallu;
        public string Gmahallu
        {
          get { return gmahallu; }
          set { gmahallu = value; }
        }
                string    ghouse;
        public string Ghouse
        {
          get { return ghouse; }
          set { ghouse = value; }
        }
                string    gpost;
        public string Gpost
        {
          get { return gpost; }
          set { gpost = value; }
        }
                string    gdistrict;
        public string Gdistrict
        {
          get { return gdistrict; }
          set { gdistrict = value; }
        }
                string    gstate;
        public string Gstate
        {
          get { return gstate; }
          set { gstate = value; }
        }
                string    gcountry;
        public string Gcountry
        {
          get { return gcountry; }
          set { gcountry = value; }
        }
                string    gmcount;
        public string Gmcount
        {
          get { return gmcount; }
          set { gmcount = value; }
        }
                string    gmreason;
        public string Gmreason
        {
          get { return gmreason; }
          set { gmreason = value; }
        }
                byte[]  gphoto;
        public byte[] Gphoto
        {
          get { return gphoto; }
          set { gphoto = value; }
        }
                string    gwitness1;
        public string Gwitness1
        {
          get { return gwitness1; }
          set { gwitness1 = value; }
        }
                string    gwitness2;
        public string Gwitness2
        {
          get { return gwitness2; }
          set { gwitness2 = value; }
        }
                string    narration;
        public string Narration
        {
          get { return narration; }
          set { narration = value; }
        }
                string    created;
        public string Created
        {
          get { return created; }
          set { created = value; }
        }
                string    modified;
        public string Modified
        {
          get { return modified; }
          set { modified = value; }
        }
                string    deleted;
        public string Deleted
        {
          get { return deleted; }
          set { deleted = value; }
        }
                string    userid;
        public string Userid
        {
          get { return userid; }
          set { userid = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        string mode;
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        string key;
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        public int Marriage_Register_Get_Id()
        {
            int rtn_flag = 0;
            try
            {
                Obj_cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Marriage_Register_Get_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                rtn_flag = Obj_cls_Db.Exec_Scalar(cmd);

            }
            catch { }
            return rtn_flag;
        }


        public int Marriage_Register_Update()
        {
            int rtn_flag = -1;
            try
            {
                Obj_cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Marriage_Register_Insert_Updadte");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MODE", "UPDATE_VALUE");
                cmd.Parameters.AddWithValue("@RGN", Rgn);
                cmd.Parameters.AddWithValue("@GRGN", Grgn);
                cmd.Parameters.AddWithValue("@CNO", Cno);
                cmd.Parameters.AddWithValue("@MDATE", Mdate);
                cmd.Parameters.AddWithValue("@MPLACE", Mplace);
                cmd.Parameters.AddWithValue("@MNAME", Mname);
                cmd.Parameters.AddWithValue("@MAHAR", Mahar);
                cmd.Parameters.AddWithValue("@MCONDUCTOR", Mconductor);
                cmd.Parameters.AddWithValue("@CRCVD", Crcvd);
                cmd.Parameters.AddWithValue("@SECRETARARY", Secretarary);
                cmd.Parameters.AddWithValue("@PRESIDENT", President);
                cmd.Parameters.AddWithValue("@BCMNTID", Bcmntid);
                cmd.Parameters.AddWithValue("@BNAME", Bname);
                cmd.Parameters.AddWithValue("@BCONTACT", bcontact);
                cmd.Parameters.AddWithValue("@BDOB", Bdob);
                cmd.Parameters.AddWithValue("@BAGE", Bage);
                cmd.Parameters.AddWithValue("@BJOB", Bjob);
                cmd.Parameters.AddWithValue("@BFATHER", Bfather);
                cmd.Parameters.AddWithValue("@BMOTHER", Bmother);
                cmd.Parameters.AddWithValue("@BMAHALLU", Bmahallu);
                cmd.Parameters.AddWithValue("@BHOUSE", Bhouse);
                cmd.Parameters.AddWithValue("@BPOST", Bpost);
                cmd.Parameters.AddWithValue("@BDISTRICT", Bdistrict);
                cmd.Parameters.AddWithValue("@BSTATE", Bstate);
                cmd.Parameters.AddWithValue("@BCOUNTRY", Bcountry);
                cmd.Parameters.AddWithValue("@BMCOUNT", Bmcount);
                cmd.Parameters.AddWithValue("@BMREASON", Bmreason);
                cmd.Parameters.AddWithValue("@BPHOTO", Bphoto);
                cmd.Parameters.AddWithValue("@BWITNESS1", Bwitness1);
                cmd.Parameters.AddWithValue("@BWITNESS2", Bwitness2);
                cmd.Parameters.AddWithValue("@GCMNTID", Gcmntid);
                cmd.Parameters.AddWithValue("@GNAME", Gname);
                cmd.Parameters.AddWithValue("@GCONTACT", Gcontact);
                cmd.Parameters.AddWithValue("@GDOB", Gdob);
                cmd.Parameters.AddWithValue("@GAGE", Gage);
                cmd.Parameters.AddWithValue("@GJOB", Gjob);
                cmd.Parameters.AddWithValue("@GFATHER", Gfather);
                cmd.Parameters.AddWithValue("@GMOTHER", Gmother);
                cmd.Parameters.AddWithValue("@GMAHALLU", Gmahallu);
                cmd.Parameters.AddWithValue("@GHOUSE", Ghouse);
                cmd.Parameters.AddWithValue("@GPOST", Gpost);
                cmd.Parameters.AddWithValue("@GDISTRICT", Gdistrict);
                cmd.Parameters.AddWithValue("@GSTATE", Gstate);
                cmd.Parameters.AddWithValue("@GCOUNTRY", Gcountry);
                cmd.Parameters.AddWithValue("@GMCOUNT", Gmcount);
                cmd.Parameters.AddWithValue("@GMREASON", Gmreason);
                cmd.Parameters.AddWithValue("@GPHOTO", Gphoto);
                cmd.Parameters.AddWithValue("@GWITNESS1", Gwitness1);
                cmd.Parameters.AddWithValue("@GWITNESS2", Gwitness2);
                cmd.Parameters.AddWithValue("@NARRATION", Narration);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@STATUS", Status);


                rtn_flag = Obj_cls_Db.Execute_Non(cmd);


            }
            catch
            {
            }
            return rtn_flag;
        }
        public int Marriage_Register_Insert()
        {
            int rtn_flag = -1;
            try
            {
                Obj_cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Marriage_Register_Insert_Updadte");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MODE", "INSERT_VALUE");
                cmd.Parameters.AddWithValue("@RGN", Rgn);
                cmd.Parameters.AddWithValue("@GRGN", Grgn);
                cmd.Parameters.AddWithValue("@CNO", Cno);
                cmd.Parameters.AddWithValue("@MDATE", Mdate);
                cmd.Parameters.AddWithValue("@MPLACE", Mplace);
                cmd.Parameters.AddWithValue("@MNAME", Mname);
                cmd.Parameters.AddWithValue("@MAHAR", Mahar);
                cmd.Parameters.AddWithValue("@MCONDUCTOR", Mconductor);
                cmd.Parameters.AddWithValue("@CRCVD", Crcvd);
                cmd.Parameters.AddWithValue("@SECRETARARY", Secretarary);
                cmd.Parameters.AddWithValue("@PRESIDENT", President);
                cmd.Parameters.AddWithValue("@BCMNTID", Bcmntid);
                cmd.Parameters.AddWithValue("@BNAME", Bname);
                cmd.Parameters.AddWithValue("@BCONTACT", bcontact);
                cmd.Parameters.AddWithValue("@BDOB", Bdob);
                cmd.Parameters.AddWithValue("@BAGE", Bage);
                cmd.Parameters.AddWithValue("@BJOB", Bjob);
                cmd.Parameters.AddWithValue("@BFATHER", Bfather);
                cmd.Parameters.AddWithValue("@BMOTHER", Bmother);
                cmd.Parameters.AddWithValue("@BMAHALLU", Bmahallu);
                cmd.Parameters.AddWithValue("@BHOUSE", Bhouse);
                cmd.Parameters.AddWithValue("@BPOST", Bpost);
                cmd.Parameters.AddWithValue("@BDISTRICT", Bdistrict);
                cmd.Parameters.AddWithValue("@BSTATE", Bstate);
                cmd.Parameters.AddWithValue("@BCOUNTRY", Bcountry);
                cmd.Parameters.AddWithValue("@BMCOUNT", Bmcount);
                cmd.Parameters.AddWithValue("@BMREASON", Bmreason);
                cmd.Parameters.AddWithValue("@BPHOTO",Bphoto);
                cmd.Parameters.AddWithValue("@BWITNESS1", Bwitness1);
                cmd.Parameters.AddWithValue("@BWITNESS2", Bwitness2);
                cmd.Parameters.AddWithValue("@GCMNTID", Gcmntid);
                cmd.Parameters.AddWithValue("@GNAME", Gname);
                cmd.Parameters.AddWithValue("@GCONTACT", Gcontact);
                cmd.Parameters.AddWithValue("@GDOB", Gdob);
                cmd.Parameters.AddWithValue("@GAGE", Gage);
                cmd.Parameters.AddWithValue("@GJOB", Gjob);
                cmd.Parameters.AddWithValue("@GFATHER", Gfather);
                cmd.Parameters.AddWithValue("@GMOTHER", Gmother);
                cmd.Parameters.AddWithValue("@GMAHALLU", Gmahallu);
                cmd.Parameters.AddWithValue("@GHOUSE", Ghouse);
                cmd.Parameters.AddWithValue("@GPOST", Gpost);
                cmd.Parameters.AddWithValue("@GDISTRICT", Gdistrict);
                cmd.Parameters.AddWithValue("@GSTATE", Gstate);
                cmd.Parameters.AddWithValue("@GCOUNTRY", Gcountry);
                cmd.Parameters.AddWithValue("@GMCOUNT", Gmcount);
                cmd.Parameters.AddWithValue("@GMREASON", Gmreason);
                cmd.Parameters.AddWithValue("@GPHOTO", Gphoto);
                cmd.Parameters.AddWithValue("@GWITNESS1", Gwitness1);
                cmd.Parameters.AddWithValue("@GWITNESS2", Gwitness2);
                cmd.Parameters.AddWithValue("@NARRATION", Narration);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@STATUS", Status);


                rtn_flag = Obj_cls_Db.Execute_Non(cmd);


            }
            catch
            {
            }
            return rtn_flag;
        }

        public DataTable Marriage_Register_Select_By_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                Obj_cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Marriage_Register_Search_By_Id");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEY",Key);
                DT = Obj_cls_Db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
        public DataTable Marriage_Register_Select_By_key()
        {
            DataTable DT = new DataTable();
            try
            {
                Obj_cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Marriage_Register_Search_By_key");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KEY", Key);
                DT = Obj_cls_Db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }
        public int Marriage_Register_Delete()
        {
            int rtn_flag = -1;
            try
            {
                Obj_cls_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Marriage_Register_Delete");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RGN", Rgn);
                rtn_flag = Obj_cls_Db.Execute_Non(cmd);

            }
            catch
            {
            }
            return rtn_flag;
        }
    }
}
