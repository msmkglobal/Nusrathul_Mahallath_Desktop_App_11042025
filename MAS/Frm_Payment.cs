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
    public partial class Frm_Payment : Form
    {
        Cls_Payment Obj_Cls_Payment;
        public Frm_Payment()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                //int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "[Transactions]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //if (result == (int)DialogResult.OK)
                //{
                //    for (int i = 0; i < panel1.Controls.Count; i++)
                //    {
                //        if ((string)panel1.Controls[i].Tag == "M" && panel1.Controls[i].Text == "")
                //        {
                //            MessageBox.Show("Empty text box not allowed!", "[Transactions]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            panel1.Controls[i].Focus();
                //            return;
                //        }
                //    }
                   
                //}
                //else
                //{
                //    return;
                //}
                Obj_Cls_Payment = new Cls_Payment();                
                Obj_Cls_Payment.Pxdate = Convert.ToDateTime(c_pxdate.Value);
                Obj_Cls_Payment.Account = c_account.Text;
                Obj_Cls_Payment.Pxreference = c_px_reference.Text;
                Obj_Cls_Payment.Paidto = c_paidto.Text;
                Obj_Cls_Payment.Pxamount = Convert.ToDouble(c_pxamount.Text);
                Obj_Cls_Payment.Pxmode = c_pxmode.Text;
                Obj_Cls_Payment.Pxdetails = c_pxdetails.Text;
                Obj_Cls_Payment.Towards = c_towards.Text;
                Obj_Cls_Payment.Formonth = c_formonth.SelectedIndex;
                Obj_Cls_Payment.Foryear = Convert.ToInt32(c_foryear.Text);
                Obj_Cls_Payment.Finyear = "2018-2019";
                Obj_Cls_Payment.Created = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                Obj_Cls_Payment.Modified = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                Obj_Cls_Payment.Deleted = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                Obj_Cls_Payment.Userid = "MONCY";
                Obj_Cls_Payment.Pxlog = "NA";
                Obj_Cls_Payment.Status = "ACTIVE";

                if (Obj_Cls_Payment.Payment_Save() > 0)
                {
                    MessageBox.Show("Data Saved!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("Process Failed!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void Frm_Payment_Load(object sender, EventArgs e)
        {

        }

        private void c_search_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_search_option_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }
    }
}
