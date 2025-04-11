using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MAS
{
    class Cls_mahallumaster
    {
        Cls_Db obj_db;
        String Mahal_Name;
        private String misid;

        public String Misid
        {
            get { return misid; }
            set { misid = value; }
        }

        public String MAHAL_NAME
        {
            get { return Mahal_Name; }
            set { Mahal_Name = value; }
        }
        String Mosq_Name;

        public String MOSQ_NAME
        {
            get { return Mosq_Name; }
            set { Mosq_Name = value; }
        }
        String Type;

        public String TYPE
        {
            get { return Type; }
            set { Type = value; }
        }
        String Place;

        public String PLACE
        {
            get { return Place; }
            set { Place = value; }
        }
        String Bldg_Num;

        public String BLDG_NUM
        {
            get { return Bldg_Num; }
            set { Bldg_Num = value; }
        }
        String Address;

        public String ADDRESS

        {
            get { return Address; }
            set { Address = value; }
        }
        String Pincode;

        public String PINCODE
        {
            get { return Pincode; }
            set { Pincode = value; }
        }
        String Panjayath;

        public String PANJAYATH
        {
            get { return Panjayath; }
            set { Panjayath = value; }
        }
        String Village;

        public String VILLAGE
        {
            get { return Village; }
            set { Village = value; }
        }
        String Thaluk;

        public String THALUK
        {
            get { return Thaluk; }
            set { Thaluk = value; }
        }
        String Block_Num;

        public String BLOCK_NUM
        {
            get { return Block_Num; }
            set { Block_Num = value; }
        }
        String Ward_Num;

        public String WARD_NUM
        {
            get { return Ward_Num; }
            set { Ward_Num = value; }
        }
        String District;

        public String DISTRICT
        {
            get { return District; }
            set { District = value; }
        }
        String State;

        public String STATE
        {
            get { return State; }
            set { State = value; }
        }
        String Khabar_Sthany;

        public String KHABAR_STHANY
        {
            get { return Khabar_Sthany; }
            set { Khabar_Sthany = value; }
        }
        decimal Area;

        public decimal AREA
        {
            get { return Area; }
            set { Area = value; }
        }
        String Since;

        public String SINCE
        {
            get { return Since; }
            set { Since = value; }
        }
        string Phone;
        

        public string PHONE
        {
        get { return Phone; }
        set { Phone = value; }
        }
        public DataTable Mahallumaster_read()
        {
            DataTable dt;
            obj_db = new Cls_Db();
            SqlCommand cmd = new SqlCommand("Mahallumaster_Read");
            cmd.CommandType = CommandType.StoredProcedure;
            dt = obj_db.Read(cmd);
            return dt;
            
            /*MOSQ_NAME,TYPE,PLACE,BLDG_NUM,ADDRESS,PINCODE,PANJAYATH,VILLAGE
THALUK,BLOCK_NUM,WARD_NUM,DISTRICT,STATE,KHABAR_STHANY,AREA,SINCE*/


        }

        public int Mahallu_Master_Save()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Mahallu_Master_Insert");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mahal_Name",Mahal_Name);
                cmd.Parameters.AddWithValue("@Mosq_Name",Mosq_Name);
                cmd.Parameters.AddWithValue("@Type",Bldg_Num);
                cmd.Parameters.AddWithValue("@Place",Place);
                cmd.Parameters.AddWithValue("@Bldg_Num",Bldg_Num);
                cmd.Parameters.AddWithValue("@Address",Address);
                cmd.Parameters.AddWithValue("@Pincode",Pincode);
                cmd.Parameters.AddWithValue("@Panjayath",Panjayath);
                cmd.Parameters.AddWithValue("@Village",Village);
                cmd.Parameters.AddWithValue("@Thaluk",Thaluk);
                cmd.Parameters.AddWithValue("@Block_Num",Block_Num);
                cmd.Parameters.AddWithValue("@Ward_Num",Ward_Num);
                cmd.Parameters.AddWithValue("@District",District);
                cmd.Parameters.AddWithValue("@State",State);
                cmd.Parameters.AddWithValue("@Khabar_Sthany",Khabar_Sthany);
                cmd.Parameters.AddWithValue("@Area",Area);
                cmd.Parameters.AddWithValue("@Since", Since);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch
            {

            }
            return rtn_flag;
        }
        public int Mahallu_Master_Edit()
        {
            int rtn_flag = -1;
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("Mahallu_Master_Update");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MISID", Misid);
                cmd.Parameters.AddWithValue("@Mahal_Name", Mahal_Name);
                cmd.Parameters.AddWithValue("@Mosq_Name", Mosq_Name);
                cmd.Parameters.AddWithValue("@Type", Bldg_Num);
                cmd.Parameters.AddWithValue("@Place", Place);
                cmd.Parameters.AddWithValue("@Bldg_Num", Bldg_Num);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Pincode", Pincode);
                cmd.Parameters.AddWithValue("@Panjayath", Panjayath);
                cmd.Parameters.AddWithValue("@Village", Village);
                cmd.Parameters.AddWithValue("@Thaluk", Thaluk);
                cmd.Parameters.AddWithValue("@Block_Num", Block_Num);
                cmd.Parameters.AddWithValue("@Ward_Num", Ward_Num);
                cmd.Parameters.AddWithValue("@District", District);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@Khabar_Sthany", Khabar_Sthany);
                cmd.Parameters.AddWithValue("@Area", Area);
                cmd.Parameters.AddWithValue("@Since", Since);
                cmd.Parameters.AddWithValue("@Phone",Phone);
                rtn_flag = obj_db.Execute_Non(cmd);

            }
            catch
            {

            }
            return rtn_flag;
        }

        public DataTable Select_Mis_Info_For_Mdipanel()
        {
            DataTable DT = new DataTable();
            try
            {
                obj_db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("RESIDENCEMASTER_SELECT_MIS_INFO_FOR_MDIPANEL");
                cmd.CommandType = CommandType.StoredProcedure;
                DT = obj_db.Read(cmd);
            }
            catch
            {

            }
            return DT;
        }
        
    }
}
