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
    public partial class Frm_Credit : Form
    {
        Cls_Credit obj_cls_credit;

        public Frm_Credit()
        {
            InitializeComponent();
        }

        public void clearcontrols()
        {
            c_rxamount.Text = "";
            c_rxdate.Text = DateTime.Now.ToShortDateString();
            c_rxdescription.Text = "";
            c_rxdetails.Text = "";
            c_rxenddate.Text = DateTime.Now.ToShortDateString();
            c_rxmode.Text = "";
            c_rxno.Text = "";
            c_rxkeyword.Text = "";
            c_rxstartdate.Text = DateTime.Now.ToShortDateString();
            c_rxtype.Text = "";
            dgv_credit.DataSource = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearcontrols();
        }

        private void Frm_Credit_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                obj_cls_credit = new Cls_Credit();
                obj_cls_credit.Rxdate = Convert.ToDateTime(c_rxdate.Text);
                obj_cls_credit.Rxno = c_rxno.Text;
                obj_cls_credit.Rxtype = c_rxtype.Text;
                obj_cls_credit.Rxamount = Convert.ToDouble(c_rxamount.Text);
                obj_cls_credit.Rxmode = c_rxmode.Text;
                obj_cls_credit.Rxdetails = c_rxdetails.Text;
                obj_cls_credit.Rxdescription = c_rxdescription.Text;
                obj_cls_credit.Created = "2019-2020";
                obj_cls_credit.Modified = "2019-2020";
                obj_cls_credit.Deleted = "2019-2020";
                obj_cls_credit.Status = "ACTIVE";
                if (obj_cls_credit.Credit_Insert() == 1)
                {
                    MessageBox.Show("Data Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Data Not Saved!");
                }
            }
            catch
            {

            }
        }

        private void c_rxkeyword_TextChanged(object sender, EventArgs e)
        {
            obj_cls_credit = new Cls_Credit();
            try
            {
                DataTable DT = new DataTable();
                obj_cls_credit.Rxkeyword = c_rxkeyword.Text;

                DT = obj_cls_credit.Credit_Search_By_Keyword();
                if (DT.Rows.Count > 0)
                {
                    dgv_credit.DataSource = DT;
                }
                else
                {
                    dgv_credit.DataSource = "";
                }
            }
            catch
            {
            }
        }

        private void c_rxenddate_ValueChanged(object sender, EventArgs e)
        {
            obj_cls_credit = new Cls_Credit();
            try
            {
                DataTable DT = new DataTable();
                obj_cls_credit.Rxstartdate = Convert.ToDateTime(c_rxstartdate.Text);
                obj_cls_credit.Rxenddate = Convert.ToDateTime(c_rxenddate.Text);
                DT = obj_cls_credit.Credit_Search_Between_date();
                if (DT.Rows.Count > 0)
                {
                    dgv_credit.DataSource = DT;
                }
                else
                {
                    dgv_credit.DataSource = "";
                }
            }
            catch
            {
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            try
            {
                obj_cls_credit = new Cls_Credit();
                obj_cls_credit.Rxdate = Convert.ToDateTime(c_rxdate.Text);
                obj_cls_credit.Rxno = c_rxno.Text;
                obj_cls_credit.Rxtype = c_rxtype.Text;
                obj_cls_credit.Rxamount = Convert.ToDouble(c_rxamount.Text);
                obj_cls_credit.Rxmode = c_rxmode.Text;
                obj_cls_credit.Rxdetails = c_rxdetails.Text;
                obj_cls_credit.Rxdescription = c_rxdescription.Text;
                obj_cls_credit.Created = "2019-2020";
                obj_cls_credit.Modified = "2019-2020";
                obj_cls_credit.Deleted = "2019-2020";
                obj_cls_credit.Status = "ACTIVE";
                if (obj_cls_credit.Credit_Update() == 1)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Data Not Updated!");
                }
            }
            catch
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                obj_cls_credit = new Cls_Credit();
               
                obj_cls_credit.Rxno = c_rxno.Text;
                
                if (obj_cls_credit.Credit_Delete() == 1)
                {
                    MessageBox.Show("Data Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Data Not Deleted!");
                }
            }
            catch
            {

            }

        }


      




        private void dgv_credit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_credit = new Cls_Credit();

                int row_index = dgv_credit.SelectedCells[0].RowIndex;
                obj_cls_credit.Rxno = dgv_credit.Rows[row_index].Cells[1].Value.ToString();
                DT = obj_cls_credit.Credit_Search_By_Rxno();
                if (DT.Rows.Count == 1)
                {
                    clearcontrols();
                    dgv_credit.DataSource = DT;
                    c_rxdate.Text = DT.Rows[0]["RXDATE"].ToString();
                    c_rxno.Text = DT.Rows[0]["RXNO"].ToString();
                    c_rxtype.Text = DT.Rows[0]["RXTYPE"].ToString();
                    c_rxamount.Text = DT.Rows[0]["RXAMOUNT"].ToString();
                    c_rxmode.Text = DT.Rows[0]["RXMODE"].ToString();
                    c_rxdetails.Text = DT.Rows[0]["RXDETAILS"].ToString();
                    c_rxdescription.Text = DT.Rows[0]["RXDESCRIPTION"].ToString();

                }
                else
                {
                    dgv_credit.DataSource = null;
                }

               
            }
            catch
            {

            }
        }

        
      
       
    }
}
