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
    public partial class Frm_Debit : Form
    {
        Cls_Debit obj_cls_debit;

        public Frm_Debit()
        {
            InitializeComponent();
        }

        public void ClearContol()
        {
            c_pxamount.Text = "";
            c_pxdate.Text = DateTime.Now.ToShortDateString();
            c_pxdescription.Text = "";
            c_pxdetails.Text = "";
            c_pxenddate.Text = DateTime.Now.ToShortDateString();
            c_pxmode.Text = "";
            c_pxno.Text = "";
            c_pxkeyword.Text = "";
            c_pxstartdate.Text = DateTime.Now.ToShortDateString();
            c_pxtype.Text = "";
            dgv_debit.DataSource = "";
            


        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearContol();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                obj_cls_debit = new Cls_Debit();
                obj_cls_debit.Pxdate = Convert.ToDateTime(c_pxdate.Text);
                obj_cls_debit.Pxno = c_pxno.Text;
                obj_cls_debit.Pxtype = c_pxtype.Text;
                obj_cls_debit.Pxamount =Convert.ToDouble(c_pxamount.Text);
                obj_cls_debit.Pxmode = c_pxmode.Text;
                obj_cls_debit.Pxdetails = c_pxdetails.Text;
                obj_cls_debit.Pxdescription = c_pxdescription.Text;
                obj_cls_debit.Created = "2019-2020";
                obj_cls_debit.Modified = "2019-2020";
                obj_cls_debit.Deleted = "2019-2020";
                obj_cls_debit.Status = "ACTIVE";
                if(obj_cls_debit.Debit_Insert()==1)
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                obj_cls_debit = new Cls_Debit();
                obj_cls_debit.Pxdate = Convert.ToDateTime(c_pxdate.Text);
                obj_cls_debit.Pxno = c_pxno.Text;
                obj_cls_debit.Pxtype = c_pxtype.Text;
                obj_cls_debit.Pxamount = Convert.ToDouble(c_pxamount.Text);
                obj_cls_debit.Pxmode = c_pxmode.Text;
                obj_cls_debit.Pxdetails = c_pxdetails.Text;
                obj_cls_debit.Pxdescription = c_pxdescription.Text;
                obj_cls_debit.Created = "2019-2020";
                obj_cls_debit.Modified = "2019-2020";
                obj_cls_debit.Deleted = "2019-2020";
                obj_cls_debit.Status = "ACTIVE";
                if (obj_cls_debit.Debit_Update() == 1)
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

       

        private void c_pxenddate_ValueChanged(object sender, EventArgs e)
        {
            obj_cls_debit = new Cls_Debit();
            try
            {
                DataTable DT = new DataTable();
                obj_cls_debit.Pxstartdate = Convert.ToDateTime(c_pxstartdate.Text);
                obj_cls_debit.Pxenddate = Convert.ToDateTime(c_pxenddate.Text);
                DT = obj_cls_debit.Debit_Search_Between_date();
                if (DT.Rows.Count > 0)
                {
                    dgv_debit.DataSource = DT;
                }
                else
                {
                    dgv_debit.DataSource = "";
                }
            }
            catch
            {
            }
        }

        private void c_pxkeyword_TextChanged(object sender, EventArgs e)
        {
            obj_cls_debit = new Cls_Debit();
            try
            {
                DataTable DT = new DataTable();
                obj_cls_debit.Pxkeyword = c_pxkeyword.Text;

                DT = obj_cls_debit.Debit_Search_By_Keyword();
                if (DT.Rows.Count > 0)
                {
                    dgv_debit.DataSource = DT;
                }
                else
                {
                    dgv_debit.DataSource = "";
                }
            }
            catch
            {
            }
        }

        private void dgv_debit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_debit = new Cls_Debit();
                int row_index = dgv_debit.SelectedCells[0].RowIndex;
                obj_cls_debit.Pxno = dgv_debit.Rows[row_index].Cells[1].Value.ToString();
                DT = obj_cls_debit.Debit_Search_By_Pxno();
                if (DT.Rows.Count == 1)
                {
                    ClearContol();
                    dgv_debit.DataSource = DT;
                    c_pxdate.Text = DT.Rows[0]["PXDATE"].ToString();
                    c_pxno.Text = DT.Rows[0]["PXNO"].ToString();
                    c_pxtype.Text = DT.Rows[0]["PXTYPE"].ToString();
                    c_pxamount.Text = DT.Rows[0]["PXAMOUNT"].ToString();
                    c_pxmode.Text = DT.Rows[0]["PXMODE"].ToString();
                    c_pxdetails.Text = DT.Rows[0]["PXDETAILS"].ToString();
                    c_pxdescription.Text = DT.Rows[0]["PXDESCRIPTION"].ToString();

                }
                else
                {
                    dgv_debit.DataSource = null;
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
                obj_cls_debit = new Cls_Debit();
                obj_cls_debit.Pxno = c_pxno.Text;
                if (obj_cls_debit.Debit_Delete() == 1)
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

       
    }
}
