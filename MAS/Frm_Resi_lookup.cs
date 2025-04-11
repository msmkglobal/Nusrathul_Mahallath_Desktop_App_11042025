using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MAS
{
    public partial class Frm_Resi_lookup : Form
    {
        Cls_Residence_Master Obj_Cls_Residence;
        //Form Frm_Community;
        Form Obj_Pointer;
        string Frm_Name;
        public Frm_Resi_lookup(Form Obj_Ptr, string Name)
        {
            Obj_Pointer = Obj_Ptr;
            Frm_Name = Name;
            InitializeComponent();            
        }

        private void Resi_lookup_Search(string key)
        {
            try
            {
                dgv_resi_llookup.DataSource = null;
                DataTable DT = new DataTable();
                Obj_Cls_Residence = new Cls_Residence_Master();
                Obj_Cls_Residence.Keys = key;
                DT = Obj_Cls_Residence.Residence_Find_By_Key_lookup();
                if (DT.Rows.Count > 0&&txt_search.Text!="" )
                {

                    DT.Columns.RemoveAt(4);
                    DT.Columns.RemoveAt(4);
                    //DT.Columns.RemoveAt(0);
                    

                    dgv_resi_llookup.DataSource = DT;

                }
            }
            catch
            {
            }
        }

        private void Residence_Lookup_Bind_controls(string key)
        {
            try
            {
                DataTable DT = new DataTable();
                Obj_Cls_Residence = new Cls_Residence_Master();
                Obj_Cls_Residence.Keys = key;
                DT = Obj_Cls_Residence.Residence_Find_By_Key_lookup();
                if (DT.Rows.Count > 0 )
                {

                    txt_resi_id.Text = DT.Rows[0][0].ToString();
                    txt_bldg_num.Text = DT.Rows[0][1].ToString();
                    txt_residance_name.Text = DT.Rows[0][2].ToString();
                    txt_owner_name.Text = DT.Rows[0][3].ToString();
                    txt_place.Text = DT.Rows[0][4].ToString();
                    txt_phone.Text = DT.Rows[0][4].ToString();
                                      

                }
            }
            catch
            {
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Resi_lookup_Load(object sender, EventArgs e)
        {
            txt_search.Focus();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Resi_lookup_Search(txt_search.Text);
        }

        private void dgv_resi_llookup_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int Rowindex = dgv_resi_llookup.CurrentCell.RowIndex;
                Residence_Lookup_Bind_controls(dgv_resi_llookup.Rows[Rowindex].Cells[0].FormattedValue.ToString());
            }
            catch
            {
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {  
              switch (Frm_Name)
              {
                  case "Frm_Community":
                      {
                        Obj_Pointer.Controls[1].Controls[5].Text = txt_resi_id.Text;                   
                        this.Close();
                      }
                      break;
                  case "Frm_Receipt":
                      {
                          //Obj_Pointer.Controls[1].Controls[2].Text = txt_resi_id.Text;
                          //Obj_Pointer.Controls[1].Controls[9].Text = txt_owner_name.Text + txt_residance_name.Text;

                            Obj_Pointer.Controls[1].Controls["c_rid"].Text = txt_resi_id.Text;
                            Obj_Pointer.Controls[1].Controls["c_rcpt_remarks"].Text = txt_owner_name.Text+ Environment.NewLine + txt_residance_name.Text;
                            this.Close();                            
                      }
                      break;
                  case "Frm_Residence":
                      {
                          Obj_Pointer.Controls[1].Controls["c_rid"].Text = txt_resi_id.Text;
                          Obj_Pointer.Controls[1].Controls["c_rcpt_remarks"].Text = txt_residance_name.Text; 
                          this.Close();
                      }
                      break;

              }

               
            }
            catch { }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }       

        private void txt_residance_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_owner_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_place_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_resi_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bldg_num_TextChanged_1(object sender, EventArgs e)
        {

        }

                
    }
}
