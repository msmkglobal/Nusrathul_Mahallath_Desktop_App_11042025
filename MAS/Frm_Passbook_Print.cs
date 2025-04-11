using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAS
{
    public partial class Frm_Passbook_Print : Form
    {
        DataTable DT_Residence;
        DataTable DT_Community;
        DataTable DT_Account_Transaction;

        Cls_Residence_Master obj_residence_master;
        Cls_Community_Master Obj_Community_master;
        Cls_Account_Transaction Obj_Account_Transaction;
        Cls_Residence_Account Obj_Residence_Account;   

        public Frm_Passbook_Print()
        {
            InitializeComponent();
        }
        
        public void Pb_print_Search_By_Rid()
        {            
            try
            {
                DT_Residence = new DataTable();
                DT_Community = new DataTable();
                c_dgv_pb_print.DataSource = null; 
             
                obj_residence_master = new Cls_Residence_Master();
                Obj_Community_master = new Cls_Community_Master();

                obj_residence_master.Rid = c_search_by_rid.Text;
                Obj_Community_master.Resi_id = c_search_by_rid.Text;

                DT_Residence = obj_residence_master.Residence_Passbook_Print_Frontpage();
                DT_Community = Obj_Community_master.Commuinty_Passbook_Print_P4P5();

                if (DT_Residence.Rows.Count > 0)
                {
                    c_dgv_pb_print.DataSource = DT_Residence;
                    c_rid.Text = DT_Residence.Rows[0]["RID"].ToString();
                    c_rname.Text = DT_Residence.Rows[0]["RNAME"].ToString();
                    c_rowner.Text = DT_Residence.Rows[0]["ROWNER"].ToString();
                    //c_ward.Text = DT_Residence.Rows[0]["RID"].ToString();
                    c_mobile.Text = DT_Residence.Rows[0]["MOBILE"].ToString();
                }
                if (DT_Community.Rows.Count >0)
                {
                    c_dgv_pb_print.DataSource = DT_Community;
                    //c_dgv_pb_print.DataSource = DT_Residence;
                }
            }
            catch
            {
            }
        }    
        private void c_search_by_key_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (c_cmnty_list.Checked == true)
                {
                    DT_Community = new DataTable();                    
                    Obj_Community_master = new Cls_Community_Master();
                    Obj_Community_master.Resi_id = c_search_by_rid.Text;
                    Obj_Community_master.Mode = "COMMUNITY_MASTER_SELECT_BY_RID";
                    //DT_Community = Obj_Community_master.Commuinty_Passbook_Print_P4P5();
                    DT_Community = Obj_Community_master.Community_Master_Select_By_Resi_Id();
                    c_dgv_pb_print.DataSource = DT_Community;
                }
                else if (c_subscription_list.Checked == true)
                {
                    Obj_Residence_Account = new Cls_Residence_Account();                    
                    DT_Residence = new DataTable();
                    Obj_Residence_Account.Rid = c_search_by_rid.Text;
                    Obj_Residence_Account.Mode = "RESIDENCE_ACCOUNT_SELECT_BY_RID";                  
                    DT_Residence= Obj_Residence_Account.Residence_Account_Select_By_Rid();                 
                    c_dgv_pb_print.DataSource = DT_Residence;
                }
            }
            catch { }
        }

        private void Frm_Passbook_Print_Load(object sender, EventArgs e)
        {

        }

        private void c_print_pb_fpage_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Printer Obj_Printer = new Frm_Printer(DT_Residence, "P2P3");
                Obj_Printer.Show();
            }
            catch { }
        }

        private void c_p4p5_Click(object sender, EventArgs e)
        {
            try
            {                
                Obj_Community_master = new Cls_Community_Master();
                Obj_Community_master.Resi_id = c_search_by_rid.Text;
                Obj_Community_master.Printed = "YES";
                if (Obj_Community_master.Community_Passbook_Print_Update_P4P5() > 0)
                {
                    Frm_Printer Obj_Printer = new Frm_Printer(DT_Community, "P4P5");
                    Obj_Printer.Show();
                }
                else
                {
                    MessageBox.Show("No item selected", "Passbook Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void c_panel_residence_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c_p6p7_Click(object sender, EventArgs e)
        {
            try
            {
                DT_Account_Transaction = new DataTable();        
                Obj_Residence_Account = new Cls_Residence_Account();
                Obj_Residence_Account.Rid = c_search_by_rid.Text;
                DT_Account_Transaction = Obj_Residence_Account.Residence_Account_Print_By_Rid();
                if (DT_Account_Transaction.Rows.Count > 0)
                {
                    Frm_Printer Obj_Printer = new Frm_Printer(DT_Account_Transaction, "P6P7");
                    Obj_Printer.Show();
                }       
            }
            catch { }
        }

        private void c_transaction_header_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Printer Obj_Printer = new Frm_Printer(DT_Account_Transaction, "P6P7_Headder");
                Obj_Printer.Show();

            }
            catch { }
        }

        private void c_yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void c_yes_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void c_family_members_Click(object sender, EventArgs e)
        {
            try
            {                
                DT_Community = new DataTable();
                c_dgv_pb_print.DataSource = null;
                Obj_Community_master = new Cls_Community_Master();
                Obj_Community_master.Resi_id = c_search_by_rid.Text;
                DT_Community = Obj_Community_master.Commuinty_Passbook_Print_P4P5();
                c_dgv_pb_print.DataSource = DT_Community;
            }
            catch
            {
            }
        }

        private void c_dgv_pb_print_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void c_cmnty_list_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DT_Community = new DataTable();
                c_receipt_refno.Clear();
                c_receipt_refno.Enabled = false;
                c_cmnty_print_order.Enabled = true;

                c_dgv_pb_print.DataSource = null;
                Obj_Community_master = new Cls_Community_Master();
                Obj_Community_master.Resi_id = c_search_by_rid.Text;
                DT_Community = Obj_Community_master.Commuinty_Passbook_Print_P4P5();
                c_dgv_pb_print.DataSource = DT_Community;
            }
            catch
            {
            }
        }

        private void c_subscription_list_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Obj_Residence_Account = new Cls_Residence_Account();
                DT_Residence = new DataTable();
                c_receipt_refno.Text = "";
                c_receipt_refno.Enabled = true;
                c_cmnty_print_order.Clear();
                c_cmnty_print_order.Enabled = false;              
               
                Obj_Residence_Account.Rid = c_search_by_rid.Text;
                Obj_Residence_Account.Mode = "RESIDENCE_ACCOUNT_SELECT_BY_RID";
                DT_Residence = Obj_Residence_Account.Residence_Account_Select_By_Rid();
                c_dgv_pb_print.DataSource = DT_Residence;
            }
            catch { }
        }

        private void c_dgv_pb_print_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Rawindex = c_dgv_pb_print.CurrentCell.RowIndex;
                if (c_cmnty_list.Checked == true)
                {
                    DT_Community = new DataTable();
                    c_cmnty_print_order.Text = c_dgv_pb_print.Rows[Rawindex].Cells["NARRATION"].FormattedValue.ToString();
                    if (c_dgv_pb_print.Rows[Rawindex].Cells["PRINTED"].FormattedValue.ToString() == "YES")
                    {
                        c_yes.Checked = true;
                    }
                    if (c_dgv_pb_print.Rows[Rawindex].Cells["PRINTED"].FormattedValue.ToString() == "NO")
                    {
                        c_no.Checked = true;                        
                    }
                }
                else if(c_subscription_list.Checked==true)
                {
                    DT_Account_Transaction = new DataTable();
                    c_cmnty_print_order.Text = "";
                    c_cmnty_print_order.Enabled = false;

                    c_receipt_refno.Text = c_dgv_pb_print.Rows[Rawindex].Cells["RECEIPTREFNO"].FormattedValue.ToString();
                    if (c_dgv_pb_print.Rows[Rawindex].Cells["PRINTED"].FormattedValue.ToString() == "YES")
                    {
                        c_yes.Checked = true;
                    }
                    if (c_dgv_pb_print.Rows[Rawindex].Cells["PRINTED"].FormattedValue.ToString() == "NO")
                    {
                        c_no.Checked = true;
                    }
                }
            }
            catch
            {
            }
        }

        private void c_print_settings_Click(object sender, EventArgs e)
        {
            try
            {
                int Rawindex = c_dgv_pb_print.CurrentCell.RowIndex;                
                if (c_cmnty_list.Checked==true)
                {
                    Obj_Community_master = new Cls_Community_Master();
                    Obj_Community_master.Resi_id = c_dgv_pb_print.Rows[Rawindex].Cells["RID"].FormattedValue.ToString();
                    Obj_Community_master.Cmnty_id = c_dgv_pb_print.Rows[Rawindex].Cells["CMNTID"].FormattedValue.ToString();
                    if(c_yes.Checked==true)
                    {
                        Obj_Community_master.Printed = "YES";
                    }
                    if(c_no.Checked==true)
                    {
                        Obj_Community_master.Printed = "NO";
                    }                   
                    Obj_Community_master.Narration = c_cmnty_print_order.Text;
                    if (Obj_Community_master.Community_Passbook_Print_Update_P4P5_By_Rid_Cmntid() > 0)
                    {
                        c_dgv_pb_print.DataSource = null;
                        DT_Community = new DataTable();
                        Obj_Community_master = new Cls_Community_Master();
                        Obj_Community_master.Resi_id = c_search_by_rid.Text;
                        Obj_Community_master.Mode = "COMMUNITY_MASTER_SELECT_BY_RID";                        
                        DT_Community = Obj_Community_master.Community_Master_Select_By_Resi_Id();
                        c_dgv_pb_print.DataSource = DT_Community;
                    }                   
                }
                else if(c_subscription_list.Checked==true)
                {
                    Obj_Residence_Account = new Cls_Residence_Account();
                    Obj_Residence_Account.Mode = "RESIDENCE_ACCOUNT_PRINT_UPDATE_BY_RID_RECEIPTREFNO";
                    Obj_Residence_Account.Rid = c_search_by_rid.Text;
                    Obj_Residence_Account.Receiptrefno = c_receipt_refno.Text;
                    if (c_yes.Checked == true)
                    {
                        Obj_Residence_Account.Printed = "YES";
                    }
                    if (c_no.Checked == true)
                    {
                        Obj_Residence_Account.Printed = "NO";
                    }
                   
                    if(Obj_Residence_Account.Residence_Account_Passbook_Print_Update_By_Rid_Receiptrefno()>0)
                    {
                        c_dgv_pb_print.DataSource = null;
                        Obj_Residence_Account = new Cls_Residence_Account();
                        DT_Residence = new DataTable();
                        Obj_Residence_Account.Rid = c_search_by_rid.Text;
                        Obj_Residence_Account.Mode = "RESIDENCE_ACCOUNT_SELECT_BY_RID";
                        DT_Residence = Obj_Residence_Account.Residence_Account_Select_By_Rid();
                        c_dgv_pb_print.DataSource = DT_Residence;
                        //Obj_Residence_Account = new Cls_Residence_Account();
                        //DataTable _DT = new DataTable();
                        //Obj_Residence_Account.Rid = c_search_by_rid.Text;
                        //Obj_Residence_Account.Mode = "RESIDENCE_ACCOUNT_SELECT_BY_RID";
                        //_DT = Obj_Residence_Account.Residence_Account_Select_By_Rid_Receiptno();
                        //c_dgv_pb_print.DataSource = _DT;
                    }                    
                }

            }
            catch { }
        }

        private void c_receipt_refno_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_cmnty_print_order_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
