using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS
{
    class Cls_Residence_Account
    {
        Cls_Db Obj_Db;

        string receiptno;
        public string Receiptno
        {
            get { return receiptno; }
            set { receiptno = value; }
        }

        DateTime receiptdate;
        public DateTime Receiptdate
        {
            get { return receiptdate; }
            set { receiptdate = value; }
        }

        string receiptrefno;
        public string Receiptrefno
        {
            get { return receiptrefno; }
            set { receiptrefno = value; }
        }

        string rid;
        public string Rid
        {
            get { return rid; }
            set { rid = value; }
        }

        string finyear;
        public string Finyear
        {
            get { return finyear; }
            set { finyear = value; }
        }

        int receiptyear;
        public int Receiptyear
        {
            get { return receiptyear; }
            set { receiptyear = value; }
        }

        int receiptmonth;
        public int Receiptmonth
        {
            get { return receiptmonth; }
            set { receiptmonth = value; }
        }

        string fortheyear;
        public string Fortheyear
        {
            get { return fortheyear; }
            set { fortheyear = value; }
        }

        double subscription;
        public double Subscription
        {
            get { return subscription; }
            set { subscription = value; }
        }

        double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        double foodexpense;
        public double Foodexpense
        {
            get { return foodexpense; }
            set { foodexpense = value; }
        }

        double contribution;
        public double Contribution
        {
            get { return contribution; }
            set { contribution = value; }
        }

        double eidalfitr;
        public double Eidalfitr
        {
            get { return eidalfitr; }
            set { eidalfitr = value; }
        }

        double eidaladha;
        public double Eidaladha
        {
            get { return eidaladha; }
            set { eidaladha = value; }
        }

        double cocunut;
        public double Cocunut
        {
            get { return cocunut; }
            set { cocunut = value; }
        }

        double other;
        public double Other
        {
            get { return other; }
            set { other = value; }
        }

        double totalamount;
        public double Totalamount
        {
            get { return totalamount; }
            set { totalamount = value; }
        }
               
        string receipttype;
        public string Receipttype
        {
            get { return receipttype; }
            set { receipttype = value; }
        }

        string receiptdetails;
        public string Receiptdetails
        {
            get { return receiptdetails; }
            set { receiptdetails = value; }
        }

        string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        DateTime created;
        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

        DateTime modified;
        public DateTime Modified
        {
            get { return modified; }
            set { modified = value; }
        }

        DateTime deleted;
        public DateTime Deleted
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

        string aclog;
        public string Aclog
        {
            get { return aclog; }
            set { aclog = value; }
        }

        string printed;
        public string Printed
        {
            get { return printed; }
            set { printed = value; }
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



        public DataTable Residence_Account_Print_By_Rid()
        {
            DataTable DT = new DataTable();
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mode", "RESIDENCE_ACCOUNT_PRINT");
                cmd.Parameters.AddWithValue("@RID", Rid);
                DT = Obj_Db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public int Residence_Account_Save()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE", Mode);

                cmd.Parameters.AddWithValue("@RECEIPTNO", Receiptno);
                cmd.Parameters.AddWithValue("@RECEIPTDATE", Receiptdate);
                cmd.Parameters.AddWithValue("@RECEIPTREFNO", Receiptrefno);
                cmd.Parameters.AddWithValue("@RID", Rid);
                cmd.Parameters.AddWithValue("@FINYEAR", Finyear);
                cmd.Parameters.AddWithValue("@RECEIPTYEAR", Receiptyear);
                cmd.Parameters.AddWithValue("@RECEIPTMONTH", Receiptmonth);
                cmd.Parameters.AddWithValue("@FORTHEYEAR", Fortheyear);
                cmd.Parameters.AddWithValue("@SUBSCRIPTION", Subscription);
                cmd.Parameters.AddWithValue("@SALARY", Salary);
                cmd.Parameters.AddWithValue("@FOODEXPENSE", Foodexpense);
                cmd.Parameters.AddWithValue("@CONTRIBUTION", Contribution);
                cmd.Parameters.AddWithValue("@EIDALFITR", Eidalfitr);
                cmd.Parameters.AddWithValue("@EIDALADHA", Eidaladha);
                cmd.Parameters.AddWithValue("@COCUNUT", Cocunut);
                cmd.Parameters.AddWithValue("@OTHER", Other);
                cmd.Parameters.AddWithValue("@TOTALAMOUNT", Totalamount);                
                cmd.Parameters.AddWithValue("@RECEIPTTYPE", Receipttype);
                cmd.Parameters.AddWithValue("@RECEIPTDETAILS", Receiptdetails);
                cmd.Parameters.AddWithValue("@REMARKS", Remarks);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@ACLOG", Aclog);
                cmd.Parameters.AddWithValue("@PRINTED",Printed);
                cmd.Parameters.AddWithValue("@STATUS", Status);
                rtn_flag = Obj_Db.Execute_Non(cmd);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
            return rtn_flag;
        }

        public int Residence_Account_Update()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE", Mode);

                cmd.Parameters.AddWithValue("@RECEIPTNO", Receiptno);
                cmd.Parameters.AddWithValue("@RECEIPTDATE", Receiptdate);
                cmd.Parameters.AddWithValue("@RECEIPTREFNO", Receiptrefno);
                cmd.Parameters.AddWithValue("@RID", Rid);
                cmd.Parameters.AddWithValue("@FINYEAR", Finyear);
                cmd.Parameters.AddWithValue("@RECEIPTYEAR", Receiptyear);
                cmd.Parameters.AddWithValue("@RECEIPTMONTH", Receiptmonth);
                cmd.Parameters.AddWithValue("@SUBSCRIPTION", Subscription);
                cmd.Parameters.AddWithValue("@SALARY", Salary);
                cmd.Parameters.AddWithValue("@FOODEXPENSE", Foodexpense);
                cmd.Parameters.AddWithValue("@CONTRIBUTION", Contribution);
                cmd.Parameters.AddWithValue("@EIDALFITR", Eidalfitr);
                cmd.Parameters.AddWithValue("@EIDALADHA", Eidaladha);
                cmd.Parameters.AddWithValue("@COCUNUT", Cocunut);
                cmd.Parameters.AddWithValue("@OTHER", Other);
                cmd.Parameters.AddWithValue("@TOTALAMOUNT", Totalamount);
                cmd.Parameters.AddWithValue("@RECEIPTTYPE", Receipttype);
                cmd.Parameters.AddWithValue("@RECEIPTDETAILS", Receiptdetails);
                cmd.Parameters.AddWithValue("@REMARKS", Remarks);
                cmd.Parameters.AddWithValue("@CREATED", Created);
                cmd.Parameters.AddWithValue("@MODIFIED", Modified);
                cmd.Parameters.AddWithValue("@DELETED", Deleted);
                cmd.Parameters.AddWithValue("@USERID", Userid);
                cmd.Parameters.AddWithValue("@ACLOG", Aclog);
                cmd.Parameters.AddWithValue("@PRINTED", Printed);
                cmd.Parameters.AddWithValue("@STATUS", Status);
                rtn_flag = Obj_Db.Execute_Non(cmd);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
            return rtn_flag;
        }

        public int Residence_Account_Passbook_Print_Update()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE", Mode);                             
                cmd.Parameters.AddWithValue("@RID", Rid);                
                cmd.Parameters.AddWithValue("@PRINTED", Printed);                
                rtn_flag = Obj_Db.Execute_Non(cmd);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
            return rtn_flag;
        }

        public DataTable Residence_Account_Select_By_Rid()
        {
            DataTable DT = new DataTable();
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mode", Mode);
                cmd.Parameters.AddWithValue("@RID", Rid);                
                DT = Obj_Db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Residence_Account_Select_By_Rid_Receiptno()
        {
            DataTable DT = new DataTable();
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mode",Mode);
                cmd.Parameters.AddWithValue("@RID", Rid);
                cmd.Parameters.AddWithValue("@RECEIPTNO", Receiptno);
                DT = Obj_Db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public DataTable Residence_Account_Select_By_Rid_Receiptrefno()
        {
            DataTable DT = new DataTable();
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mode", Mode);
                cmd.Parameters.AddWithValue("@RID", Rid);
                cmd.Parameters.AddWithValue("@RECEIPTREFNO", Receiptrefno);
                DT = Obj_Db.Read(cmd);
            }
            catch
            {
            }
            return DT;
        }

        public int Residence_Account_Passbook_Print_Update_By_Rid_Receiptrefno()
        {
            int rtn_flag = -1;
            try
            {
                Obj_Db = new Cls_Db();
                SqlCommand cmd = new SqlCommand("SP_RESIDENCE_ACCOUNT");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MODE", Mode);
                cmd.Parameters.AddWithValue("@RID", Rid);
                cmd.Parameters.AddWithValue("@RECEIPTREFNO", Receiptrefno);
                cmd.Parameters.AddWithValue("@PRINTED", Printed);
                rtn_flag = Obj_Db.Execute_Non(cmd);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
            return rtn_flag;
        }

    }
}
