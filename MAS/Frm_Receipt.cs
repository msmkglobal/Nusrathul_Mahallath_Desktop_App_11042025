using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS
{
    public partial class Frm_Receipt : Form
    {
        Cls_Residence_Account Obj_Cls_Residence_Account;
        Class_Idmaster Obj_Class_Idmaster;
        public Frm_Receipt()
        {
            InitializeComponent();
        }

        public void Clear_Controls()
        {
            try
            {
                c_rcpt_no.Text = "";
                c_rcpt_refno.Text = "NA";
                c_rid.Text = "";
                c_rcpt_remarks.Text = "";
                c_rcpt_type.Text = "CASH";
                c_rcpt_details.Text = "BY CASH";
                c_subscription.Text = "240.00";
                c_salary.Text = "100.00";
                c_foodexpense.Text = "0.00";
                c_contribution.Text = "0.00";
                c_eid_al_fitr.Text = "50.00";
                c_eid_al_adha.Text = "50.00";
                c_cocunut.Text = "0.00";
                c_other.Text = "0.00";
                c_total_amount.Text = "0.00";
                c_rcpt_month.Text = null;
                c_rcpt_year.Text = null;
                c_search_value.Text = "";
                c_dgv.DataSource = null;
                c_rcpt_no.Focus();
            }
            catch
            {

            }
        }

        public void Get_Receiptrefno()
        {
            try
            {
                DataTable DT = new DataTable();
                Obj_Class_Idmaster = new Class_Idmaster();

                Obj_Class_Idmaster.Mode = "SELECT_RECEIPT_REFNO";
                Obj_Class_Idmaster.Relation = "RESIDENCE_ACCOUNT";
                Obj_Class_Idmaster.Atribute = "RECEIPTREFNO";
                Obj_Class_Idmaster.Status = "ACTIVE";
                DT = Obj_Class_Idmaster.Idmaster_Select_All_By_Reletion_Atribute();
                if(DT.Rows.Count==1)
                {
                    c_rcpt_refno.Text = DT.Rows[0][5].ToString();                    
                }                
            }
            catch
            {
                MessageBox.Show("Unable to process your request!", "Residence Account", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        public void Residense_Account_Select_By_Rid(string _Rid)
        {
            try
            {
                Obj_Cls_Residence_Account = new Cls_Residence_Account();
                DataTable _DT = new DataTable();
                Obj_Cls_Residence_Account.Rid = _Rid;
                Obj_Cls_Residence_Account.Mode = "RESIDENCE_ACCOUNT_SELECT_BY_RID";
                _DT = Obj_Cls_Residence_Account.Residence_Account_Select_By_Rid();
                c_dgv.DataSource = _DT;
            }
            catch { }
        }

        public void Residense_Account_Select_By_Rid_Receiptno()
        {
            try
            {
                Obj_Cls_Residence_Account = new Cls_Residence_Account();
                DataTable _DT = new DataTable();
                string _serach_mode = "RESIDENCE_ACCOUNT_SELECT_BY_RID";
                if(c_rdb_rid.Checked==true)
                {
                    _serach_mode="RESIDENCE_ACCOUNT_SELECT_BY_RID";
                }
                else
                {
                    _serach_mode = "RESIDENCE_ACCOUNT_SELECT_BY_RECEIPTNO";
                }
                Obj_Cls_Residence_Account.Rid = c_search_value.Text;
                Obj_Cls_Residence_Account.Receiptno = c_search_value.Text;
                Obj_Cls_Residence_Account.Mode = _serach_mode;
                _DT= Obj_Cls_Residence_Account.Residence_Account_Select_By_Rid_Receiptno();
                c_dgv.DataSource = _DT;
            }
            catch { }
        }

        public void Calculate_Total_Amount()
        {
            try
            {
                double _total_amount = 0.00;
                double _subscription = Convert.ToDouble(c_subscription.Text);
                double _salary = Convert.ToDouble(c_salary.Text);
                double _foodexpense = Convert.ToDouble(c_foodexpense.Text);
                double _contribution = Convert.ToDouble(c_contribution.Text);
                double _eidalfitr = Convert.ToDouble(c_eid_al_fitr.Text);
                double _eidaladha = Convert.ToDouble(c_eid_al_adha.Text);
                double _cocunut = Convert.ToDouble(c_cocunut.Text);
                double _other = Convert.ToDouble(c_other.Text);
                _total_amount = _subscription + _salary + _foodexpense + _contribution + _eidalfitr + _eidaladha + _cocunut + _other;
                c_total_amount.Text = _total_amount.ToString("#,0.00");
            }
            catch { }
        }

        public void Residense_Account_Passbook_Print_Update()
        {
            try
            {
                Obj_Cls_Residence_Account = new Cls_Residence_Account();
                
                Obj_Cls_Residence_Account.Mode = "RESIDENCE_ACCOUNT_PASSBOOK_PRINT_UPDATE";
                Obj_Cls_Residence_Account.Rid = c_search_value.Text;
                Obj_Cls_Residence_Account.Printed = "YES";
                Obj_Cls_Residence_Account.Residence_Account_Passbook_Print_Update();             
            }
            catch { }
        }

        //

        private void btn_residenceid_pickup_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Resi_lookup Obj_Frm_Resi_lookup = new Frm_Resi_lookup(this, "Frm_Receipt");
                Obj_Frm_Resi_lookup.ShowDialog();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            Get_Receiptrefno();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Residence[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    Obj_Cls_Residence_Account = new Cls_Residence_Account();
                    Obj_Cls_Residence_Account.Mode = "RESIDENCE_ACCOUNT_SAVE";
                    Obj_Cls_Residence_Account.Receiptno = c_rcpt_no.Text;
                    Obj_Cls_Residence_Account.Receiptdate = Convert.ToDateTime(c_rcpt_date.Text);
                    Obj_Cls_Residence_Account.Receiptrefno = c_rcpt_refno.Text;
                    Obj_Cls_Residence_Account.Rid = c_rid.Text;
                    Obj_Cls_Residence_Account.Finyear = "2024-2025";
                    Obj_Cls_Residence_Account.Receiptyear = Convert.ToDateTime(c_rcpt_date.Text).Year;
                    Obj_Cls_Residence_Account.Receiptmonth = Convert.ToInt32(c_rcpt_month.SelectedIndex + 1);
                    Obj_Cls_Residence_Account.Fortheyear = c_rcpt_year.Text;

                    Obj_Cls_Residence_Account.Subscription = Convert.ToDouble(c_subscription.Text);
                    Obj_Cls_Residence_Account.Salary = Convert.ToDouble(c_salary.Text);
                    Obj_Cls_Residence_Account.Foodexpense = Convert.ToDouble(c_foodexpense.Text);
                    Obj_Cls_Residence_Account.Contribution = Convert.ToDouble(c_contribution.Text);
                    Obj_Cls_Residence_Account.Eidalfitr = Convert.ToDouble(c_eid_al_fitr.Text);
                    Obj_Cls_Residence_Account.Eidaladha = Convert.ToDouble(c_eid_al_adha.Text);
                    Obj_Cls_Residence_Account.Cocunut = Convert.ToDouble(c_cocunut.Text);
                    Obj_Cls_Residence_Account.Other = Convert.ToDouble(c_other.Text);
                    Obj_Cls_Residence_Account.Totalamount = Convert.ToDouble(c_total_amount.Text);                
                    Obj_Cls_Residence_Account.Receipttype = c_rcpt_type.Text;
                    Obj_Cls_Residence_Account.Receiptdetails = c_rcpt_details.Text;
                    Obj_Cls_Residence_Account.Remarks = c_rcpt_remarks.Text;
                    Obj_Cls_Residence_Account.Created = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    Obj_Cls_Residence_Account.Modified = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    Obj_Cls_Residence_Account.Deleted = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    Obj_Cls_Residence_Account.Userid = "ADMIN";
                    Obj_Cls_Residence_Account.Aclog = "CREATED";
                    Obj_Cls_Residence_Account.Printed = "NO";
                    Obj_Cls_Residence_Account.Status = "ACTIVE";
                    if (Obj_Cls_Residence_Account.Residence_Account_Save() > 0)
                    {
                        MessageBox.Show("Successfully Saved");
                        Residense_Account_Select_By_Rid(c_rid.Text);
                        Get_Receiptrefno();
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        private void Frm_Receipt_Load(object sender, EventArgs e)
        {

        }

        private void c_panel_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c_subscription_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_salary_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_foodexpense_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_contribution_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_eid_al_fitr_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_eid_al_adha_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_other_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_print_passbook_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT= new DataTable();
                Obj_Cls_Residence_Account = new Cls_Residence_Account();
                Obj_Cls_Residence_Account.Rid = c_search_value.Text;
                DT = Obj_Cls_Residence_Account.Residence_Account_Print_By_Rid();
                if (DT.Rows.Count > 0)
                {
                    Frm_Printer Obj_Printer = new Frm_Printer(DT, "P6P7");
                    int result = (int)MessageBox.Show("Do you update passbook now?", "Passbook print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if ((result == (int)DialogResult.Yes))
                    {                        
                        Obj_Printer.Show();
                        Residense_Account_Passbook_Print_Update();
                    }
                    else
                    {
                        Obj_Printer.Show();                       
                    }
                }
                else
                {
                    MessageBox.Show("No item selected", "Passbook Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No item selected","Passbook Print",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void c_cocunut_TextChanged(object sender, EventArgs e)
        {
            Calculate_Total_Amount();
        }

        private void c_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c_search_value_TextChanged(object sender, EventArgs e)
        {
            Residense_Account_Select_By_Rid_Receiptno();
        }

        private void c_print_head_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Frm_Printer Obj_Printer = new Frm_Printer(DT_Account_Transaction, "P6P7_Headder");
            //    Obj_Printer.Show();

            //}
            //catch { }
        }

        private void c_update_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int result = (int)MessageBox.Show("Make sure that, Data has to be updated", "Recipt[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //    if (result == (int)DialogResult.OK)
            //    {
            //        Obj_Cls_Residence_Account = new Cls_Residence_Account();
            //        Obj_Cls_Residence_Account.Mode = "RESIDENCE_ACCOUNT_UPDATE";
            //        Obj_Cls_Residence_Account.Receiptno = c_rcpt_no.Text;
            //        Obj_Cls_Residence_Account.Receiptdate = Convert.ToDateTime(c_rcpt_date.Text);
            //        Obj_Cls_Residence_Account.Receiptrefno = c_rcpt_refno.Text;
            //        Obj_Cls_Residence_Account.Rid = c_rid.Text;
            //        Obj_Cls_Residence_Account.Finyear = "2019-2020";
            //        Obj_Cls_Residence_Account.Receiptyear = Convert.ToInt32(c_rcpt_year.Text);
            //        Obj_Cls_Residence_Account.Receiptmonth = Convert.ToInt32(c_rcpt_month.SelectedIndex + 1);
            //        Obj_Cls_Residence_Account.Subscription = Convert.ToDouble(c_subscription.Text);
            //        Obj_Cls_Residence_Account.Salary = Convert.ToDouble(c_salary.Text);
            //        Obj_Cls_Residence_Account.Foodexpense = Convert.ToDouble(c_foodexpense.Text);
            //        Obj_Cls_Residence_Account.Contribution = Convert.ToDouble(c_contribution.Text);
            //        Obj_Cls_Residence_Account.Eidalfitr = Convert.ToDouble(c_eid_al_fitr.Text);
            //        Obj_Cls_Residence_Account.Eidaladha = Convert.ToDouble(c_eid_al_adha.Text);
            //        Obj_Cls_Residence_Account.Cocunut = Convert.ToDouble(c_cocunut.Text);
            //        Obj_Cls_Residence_Account.Other = Convert.ToDouble(c_other.Text);
            //        Obj_Cls_Residence_Account.Totalamount = Convert.ToDouble(c_total_amount.Text);
            //        Obj_Cls_Residence_Account.Receipttype = c_rcpt_type.Text;
            //        Obj_Cls_Residence_Account.Receiptdetails = c_rcpt_details.Text;
            //        Obj_Cls_Residence_Account.Remarks = c_rcpt_remarks.Text;                    
            //        Obj_Cls_Residence_Account.Modified = Convert.ToDateTime(DateTime.Now.ToShortDateString());                    
            //        Obj_Cls_Residence_Account.Userid = "ADMIN";
            //        Obj_Cls_Residence_Account.Aclog = "UPDATED";                   
                  
            //        if (Obj_Cls_Residence_Account.Residence_Account_Update() > 0)
            //        {
            //            MessageBox.Show("Successfully Updated");
            //            Residense_Account_Select_By_Rid(c_rid.Text);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed");
            //        }
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.Message.ToString());
            //}
        }

        private void c_rcpt_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                c_rcpt_month.SelectedIndex = Convert.ToDateTime(c_rcpt_date.Text).Month-1;
            }
            catch { }           
        }

        private void c_clear_all_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Get_Receiptrefno();
        }

        private void c_rcpt_year_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if(c_rcpt_year.Text=="2025")
                {
                    c_subscription.Text = "600.00";                    
                    c_salary.Text = "0.00";
                    c_foodexpense.Text = "0.00";
                    c_contribution.Text = "0.00";
                    c_eid_al_fitr.Text = "0.00";
                    c_eid_al_adha.Text = "0.00";
                    c_cocunut.Text = "0.00";
                    c_other.Text = "0.00";
                }
                else
                {
                    c_rcpt_type.Text = "CASH";
                    c_rcpt_details.Text = "BY CASH";
                    c_subscription.Text = "240.00";
                    c_salary.Text = "100.00";
                    c_foodexpense.Text = "0.00";
                    c_contribution.Text = "0.00";
                    c_eid_al_fitr.Text = "50.00";
                    c_eid_al_adha.Text = "50.00";
                    c_cocunut.Text = "0.00";
                    c_other.Text = "0.00";
                    c_total_amount.Text = "0.00";
                    c_rcpt_month.Text = null;
                    c_search_value.Text = null;
                    c_dgv.DataSource = null;                    
                }

            }
            catch { }
        }
    }
}
