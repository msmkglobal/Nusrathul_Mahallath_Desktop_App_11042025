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
    public partial class Frm_Job : Form
    {
        Cls_Job_Master Obj_Job_master;
        public Frm_Job()
        {
            InitializeComponent();
        }
        private void Frm_Job_Load(object sender, EventArgs e)
        {
            try
            {
                txt_search.Focus();
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                dgv_employment.Enabled = false;
            }
            catch
            {
            }
        }
        public void Clear_Control_Employment()
        {
            try
            {
                //txt_employmentid.Text = "";
                //txt_emp_cmnt_id.Text = "";
                cmb_job_type.Text = "";
                txt_designation.Text = "";
                txt_employer.Text = "";
                txt_address.Text = "";
                txt_emp_district.Text = "";
                txt_emp_state.Text = "";
                txt_country.Text = "";
                txt_contact_number.Text = "";
                txt_join_date.Text = "";
                txt_remarks_employment.Text = "";
                cmb_status.Text = "";
            }
            catch
            {
            }
        }
        private void Controls_Readonly(string mode)
            {
                try
                {
                    if (mode == "True")
                    {
                       // txt_employmentid.Enabled = false;
                //txt_emp_cmnt_id.Enabled = false;
                cmb_job_type.Enabled = false;
                txt_designation.Enabled = false;
                txt_employer.Enabled = false;
                txt_address.Enabled = false;
                txt_emp_district.Enabled = false;
                txt_emp_state.Enabled = false;
                txt_country.Enabled = false;
                txt_contact_number.Enabled = false;
                txt_join_date.Enabled = false;
                txt_remarks_employment.Enabled = false;
                cmb_status.Enabled = false;


                    }
                    else if(mode=="False")
                    {
                        //txt_employmentid.Enabled = true;
                //txt_emp_cmnt_id.Enabled = true;
                cmb_job_type.Enabled = true;
                txt_designation.Enabled = true;
                txt_employer.Enabled = true;
                txt_address.Enabled = true;
                txt_emp_district.Enabled = true;
                txt_emp_state.Enabled = true;
                txt_country.Enabled = true;
                txt_contact_number.Enabled = true;
                txt_join_date.Enabled = true;
                txt_remarks_employment.Enabled = true;
                cmb_status.Enabled = true;
                    }
                }
                catch { }
            }
    
        private void Job_Bind_Controls(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                Obj_Job_master=new Cls_Job_Master();
                if (Keys != "")
                {
                    Controls_Readonly("True");
                    Obj_Job_master.Key=Keys;
                    DT=Obj_Job_master.Job_Master_Find_PK();
                    dgv_employment.DataSource = DT;

                    //txt_employmentid.Text = DT.Rows[0][0].ToString();
                    txt_emp_cmnt_id.Text = DT.Rows[0][1].ToString();
                    cmb_job_type.Text = DT.Rows[0][2].ToString();
                    txt_designation.Text = DT.Rows[0][3].ToString();
                    txt_employer.Text = DT.Rows[0][4].ToString();
                    txt_address.Text = DT.Rows[0][5].ToString();
                    txt_emp_district.Text = DT.Rows[0][6].ToString();
                    txt_emp_state.Text = DT.Rows[0][7].ToString();
                    txt_country.Text = DT.Rows[0][8].ToString();
                    txt_contact_number.Text = DT.Rows[0][9].ToString();
                    txt_join_date.Text = DT.Rows[0][10].ToString();
                    txt_remarks_employment.Text = DT.Rows[0][11].ToString();


                }
                else
                {
                    Clear_Control_Employment();
                    btn_save.Enabled = true;
                    Controls_Readonly("True");
                    txt_search.Focus();
                }
            }
            catch { }
        }       
        public void Job_Search_By_key(string key)
        {
            try
            {
                if (txt_search != null)
                {
                    dgv_employment.DataSource = null;
                    DataTable DT = new DataTable();
                    Obj_Job_master = new Cls_Job_Master();
                    Obj_Job_master.Key = key;
                    DT = Obj_Job_master.Job_Master_Find_By_Key();
                    dgv_employment.DataSource = DT;
                }

            }
            catch
            {
            }
        }




        private void btn_new_Click(object sender, EventArgs e)
        {
            int result = (int)MessageBox.Show("Do you want to clear the data?", "Residence [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == (int)DialogResult.OK)
            {
                dgv_employment .Enabled = false;
                Clear_Control_Employment();
                Controls_Readonly("False");
                dgv_employment.DataSource = null;
                txt_search.Text = "";
                btn_save.Enabled = true;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Community[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gbx_job.Controls.Count; i++)
                    {
                        if ((string)gbx_job.Controls[i].Tag == "M" && gbx_job.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Community[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_job.Controls[i].Focus();
                            return;
                        }
                    }
                    Obj_Job_master = new Cls_Job_Master();
                    Obj_Job_master.Job_Id = 0;
                    Obj_Job_master.Cmnt_Id = txt_emp_cmnt_id.Text;
                    Obj_Job_master.Job_Type = cmb_job_type.Text;
                    Obj_Job_master.Designation = txt_designation.Text;
                    Obj_Job_master.Employer = txt_employer.Text;
                    Obj_Job_master.Address = txt_address.Text;
                    Obj_Job_master.District = txt_emp_district.Text;
                    Obj_Job_master.State = txt_emp_state.Text;
                    Obj_Job_master.Country = txt_country.Text;
                    Obj_Job_master.Contact_Num = txt_contact_number.Text;
                    Obj_Job_master.Joining_Date = txt_join_date.Text;
                    Obj_Job_master.Resignation_Date = "NA";
                    Obj_Job_master.Remarks = txt_remarks_employment.Text;
                    Obj_Job_master.Created = System.DateTime.Now.ToString();
                    Obj_Job_master.Modified = System.DateTime.Now.ToString();
                    Obj_Job_master.Status = cmb_status.Text;
                }
                if (Obj_Job_master.Job_Master_Save() > 0)
                    {
                        MessageBox.Show("Data Saved!", "Job[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Job_Search_By_key(txt_emp_cmnt_id.Text);
                        dgv_employment.Enabled = true;
                        Controls_Readonly("True");
                    }
                    else
                    {
                        MessageBox.Show("Process Failed!", "Job[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }               

            }
            catch
            {
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result = ((int)MessageBox.Show("Are you sure you want to delete ", "Job[MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (result == (int)DialogResult.Yes)
            {
                Obj_Job_master = new Cls_Job_Master();
                int rowIndex = dgv_employment.CurrentCell.RowIndex;

                Obj_Job_master.Job_Id = Convert.ToInt32(dgv_employment.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                if (Obj_Job_master.Job_Master_Delete() > 0)
                {
                    MessageBox.Show("File Deleted!", "Job[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Controls_Readonly("True");
                    Clear_Control_Employment();
                    Job_Search_By_key(txt_emp_cmnt_id.Text);
                    
                    
                }
                else
                {
                    MessageBox.Show("File Could not Delete!", "Job[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                
                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Job [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    for (int i = 0; i < gbx_job .Controls.Count; i++)
                    {
                        if ((string)gbx_job .Controls[i].Tag == "M" && gbx_job .Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Job[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_job .Controls[i].Focus();
                            return;
                        }
                    }
                   Obj_Job_master  = new Cls_Job_Master();
                   int rowIndex = dgv_employment.CurrentCell.RowIndex;
                   Obj_Job_master.Job_Id = Convert.ToInt32(dgv_employment.Rows[rowIndex].Cells[0].FormattedValue.ToString()); 
                   Obj_Job_master.Cmnt_Id = txt_emp_cmnt_id.Text;
                    Obj_Job_master.Job_Type = cmb_job_type.Text;
                    Obj_Job_master.Designation = txt_designation.Text;
                    Obj_Job_master.Employer = txt_employer.Text;
                    Obj_Job_master.Address = txt_address.Text;
                    Obj_Job_master.District = txt_emp_district.Text;
                    Obj_Job_master.State = txt_emp_state.Text;
                    Obj_Job_master.Country = txt_country.Text;
                    Obj_Job_master.Contact_Num = txt_contact_number.Text;
                    Obj_Job_master.Joining_Date = txt_join_date.Text;
                    Obj_Job_master.Resignation_Date = "NA";
                    Obj_Job_master.Remarks = txt_remarks_employment.Text;
                    Obj_Job_master .Created = System.DateTime.Now.ToString();
                    Obj_Job_master .Modified = System.DateTime.Now.ToString();
                    Obj_Job_master.Status = cmb_status.Text;
                }
                else
                {
                    return;
                }
                    if (Obj_Job_master .Job_Master_Update() > 0)
                    {
                        MessageBox.Show("File Updated!", "job[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Job_Search_By_key(txt_emp_cmnt_id.Text);
                        Controls_Readonly("True");
                        dgv_employment .Enabled = true;
                    }
            }
            catch
            {
            }
        }

        private void txt_employmentid_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_emp_cmnt_id.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_emp_cmnt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void cmb_job_type_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_designation.Focus();
                }
                else
                {
                    e.KeyChar = (char)Keys.None; 
                }

            }
            catch
            {
            }
        }

        private void txt_designation_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_employer.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_employer_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_address.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_emp_district.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_emp_district_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_emp_state.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_emp_state_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_country.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_country_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_contact_number.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_contact_number_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_join_date.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_join_date_KeyPress(object sender, KeyPressEventArgs e)
        {
        try
            {
                if (e.KeyChar == 13)
                {
                    txt_remarks_employment.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_remarks_employment_KeyPress(object sender, KeyPressEventArgs e)
        {
         try
            {
                if (e.KeyChar == 13)
                {
                    txt_remarks_employment.Focus();
                }
            }
            catch
            {
            }
        }

        private void dgv_employment_MouseClick(object sender, MouseEventArgs e)
        {
            
                try
                {
                    btn_save.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_delete.Enabled = false;
                    int rowIndex = dgv_employment.CurrentCell.RowIndex;
                    Job_Bind_Controls(dgv_employment.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                    Controls_Readonly("True");
                }
                catch { }
        
        }

        private void dgv_employment_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        try
            {
                int rowIndex = dgv_employment.CurrentCell.RowIndex;
                Job_Bind_Controls(dgv_employment .Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Job_Search_By_key(txt_emp_cmnt_id.Text);
                Controls_Readonly("False");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
                
            }
            catch { }
        }

        private void txt_remarks_employment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_join_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contact_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_country_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emp_state_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Job_Search_By_key(txt_search.Text);
                dgv_employment.Enabled = true;
            }
            catch
            {
            }
        }
        private void cmb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               
                e.KeyChar = (char)Keys.None;
                
            }
            catch
            {
            }
        }

        private void lbl_pick_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_community_lookup Obj_Frm_Cmnt_Lookup = new Frm_community_lookup(this, "Frm_Job");
                Obj_Frm_Cmnt_Lookup.ShowDialog();
            }
            catch { }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                MessageBox.Show(this.Controls[i].Name.ToString());
                txt_country.Text = i.ToString();
            }
        }

        
        

        }


        }

