using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MAS
{
    public partial class Frm_Search : Form
    {
        Cls_Common_search Obj_Cls_Common_search;
        Cls_Residence_Master obj_residence_master;
        Cls_Community_Master obj_cmnty_master;
        Cls_Education Obj_Cls_Education;
        Cls_Job_Master Obj_Job_master;
        int flag = 0;
        public Frm_Search()
        {
            InitializeComponent();
            txt_search.Visible = false;
            lbl_search.Visible = false;
        }

        public void Residence_dgv_load(string key)
        {
            try
            {
                dgv_search.DataSource = null;
                DataTable DT = new DataTable();
                Obj_Cls_Common_search = new Cls_Common_search();
                Obj_Cls_Common_search.Key = key;
                DT = Obj_Cls_Common_search.Commonsearch_Residense();
                if (DT.Rows.Count > 0 && txt_search.Text != "")
                {
                    flag = 1;
                    dgv_searchpik.DataSource = DT;
                    dgv_searchpik.Columns[0].Visible = false;
                }

            }
            catch
            {
            }
        }

        public void Commnity_dgv_load(string key)
        {
            try
            {
                dgv_search.DataSource = null;
                DataTable DT = new DataTable();
                Obj_Cls_Common_search = new Cls_Common_search();
                Obj_Cls_Common_search.Key = key;
                DT = Obj_Cls_Common_search.Commonsearch_Commnity();
                if (DT.Rows.Count > 0 && txt_search.Text != "")
                {
                    dgv_searchpik.DataSource = DT;
                    dgv_searchpik.Columns[0].Visible = false;
                }

            }
            catch
            {
            }
        }
        public void load_lablels_community(string Key)
        {
            try
            {
                DataTable DT = new DataTable();
            
                DT.Rows.Clear();
                obj_cmnty_master = new Cls_Community_Master();
                if (Key != "")
                {
                   
                    obj_cmnty_master.Keys = Key;
                    DT = obj_cmnty_master.Community_Select_By_Cmnty_Id();
                    if (DT.Rows.Count != 0)
                    {
                        lbl_s_cmntid.Text = DT.Rows[0][0].ToString();
                        //txt_resi_id.Text = DT.Rows[0][1].ToString();
                        lbl_s_name.Text = DT.Rows[0][2].ToString();
                        lbl_s_gender.Text = DT.Rows[0][3].ToString();
                        lbl_s_dob.Text = DT.Rows[0][4].ToString();
                        lbl_s_mstatus.Text = DT.Rows[0][5].ToString();
                        lbl_s_relation.Text = DT.Rows[0][6].ToString();
                        lbl_s_bgroup.Text = DT.Rows[0][7].ToString();
                        lbl_s_hstatus.Text = DT.Rows[0][8].ToString();
                        lbl_s_phc.Text = DT.Rows[0][9].ToString();
                        lbl_s_uaid.Text = DT.Rows[0][10].ToString();
                        lbl_s_psptno.Text = DT.Rows[0][11].ToString();
                        lbl_s_licence_no.Text = DT.Rows[0][12].ToString();
                        lbl_s_occupation.Text = DT.Rows[0][13].ToString();
                        lbl_s_livingplace.Text = DT.Rows[0][14].ToString();
                        lbl_s_email.Text = DT.Rows[0][15].ToString();
                        lbl_s_contact.Text = DT.Rows[0][16].ToString();
                        lbl_s_hajj.Text = DT.Rows[0][17].ToString();

                        byte[] Photo = new byte[0];
                        Photo = (byte[])(DT.Rows[0][19]);
                        MemoryStream Photostream = new MemoryStream(Photo);
                        pbx_s_photo.Image = Image.FromStream(Photostream);

                        lbl_s_status.Text = DT.Rows[0][21].ToString();
                        lbl_s_narration.Text = DT.Rows[0][20].ToString();
                    }
                }
                else
                {
                    
                }
            }
            catch { }
        
        }

        private void load_lablels_education(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                Obj_Cls_Education = new Cls_Education();
                if (Keys != "")
                {
                    
                    Obj_Cls_Education.Key = Keys;
                    DT = Obj_Cls_Education.Education_Find_By_Cmnt();
                    if (DT.Rows.Count != 0)
                    {

                        //txt_edu_id.Text = DT.Rows[0][0].ToString();
                        //txt_Cmnt_Id.Text = DT.Rows[0][1].ToString();
                        lbl_s_quallification.Text = DT.Rows[0][2].ToString();
                        lbl_s_subject.Text = DT.Rows[0][3].ToString();
                        lbl_s_stream.Text = DT.Rows[0][4].ToString();
                        lbl_s_issuingauthority.Text = DT.Rows[0][5].ToString();
                        lbl_s_percentage.Text = DT.Rows[0][6].ToString();
                        lbl_s_grade.Text = DT.Rows[0][7].ToString();
                        lbl_s_passngyear.Text = DT.Rows[0][8].ToString();
                        lbl_s_regno.Text = DT.Rows[0][9].ToString();
                        lbl_s_eremarks.Text = DT.Rows[0][10].ToString();
                    }

                }
                else
                {
                    
                }
            }
            catch { }
        }

        private void load_lablels_Job(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                Obj_Job_master = new Cls_Job_Master();
                if (Keys != "")
                {
                    
                    Obj_Job_master.Key = Keys;
                    DT = Obj_Job_master.Job_Master_Find_By_Cmnt();
                    if (DT.Rows.Count != 0)
                    {
                        //txt_employmentid.Text = DT.Rows[0][0].ToString();
                        //lbl_s_emp_cmnt_id.Text = DT.Rows[0][1].ToString();
                        lbl_s_jobtype.Text = DT.Rows[0][2].ToString();
                        lbl_s_designation.Text = DT.Rows[0][3].ToString();
                        lbl_s_employer.Text = DT.Rows[0][4].ToString();
                        txt_address.Text = DT.Rows[0][5].ToString();
                        lbl_s_jdistrict.Text = DT.Rows[0][6].ToString();
                        lbl_s_state.Text = DT.Rows[0][7].ToString();
                        lbl_s_country.Text = DT.Rows[0][8].ToString();
                        lbl_s_contact.Text = DT.Rows[0][9].ToString();
                        lbl_s_joindate.Text = DT.Rows[0][10].ToString();
                        lbl_s_jremarks.Text = DT.Rows[0][11].ToString();
                    }
                }
                else
                {
                    
                }
            }
            catch { }
        }

        private void load_lablels_Residence(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                obj_residence_master = new Cls_Residence_Master();
                obj_cmnty_master = new Cls_Community_Master();
                if (Keys != "")
                {
                    
                    obj_cmnty_master.Keys = Keys;
                    
                    DT = obj_cmnty_master.Commuinty_Master_Get_rid();
                    obj_residence_master.Rid = DT.Rows[0][0].ToString();
                    DT.Rows.Clear();
                    DT = obj_residence_master.Residence_Find_Resi_Id();
                    if (DT.Rows.Count != 0)
                    {
                        lbl_s_jno.Text = DT.Rows[0][0].ToString();
                        lbl_s_rsidencetype.Text = DT.Rows[0][2].ToString();
                        lbl_s_famlytype.Text = DT.Rows[0][3].ToString();
                        lbl_s_famlyclass.Text = DT.Rows[0][4].ToString();
                        lbl_s_buildingno.Text = DT.Rows[0][6].ToString();
                        lbl_s_wardno.Text = DT.Rows[0][7].ToString();
                        lbl_s_panchayath.Text = DT.Rows[0][8].ToString();
                        lbl_s_block.Text = DT.Rows[0][9].ToString();
                        lbl_s_rdistrict.Text = DT.Rows[0][10].ToString();
                        lbl_s_resiname.Text = DT.Rows[0][11].ToString();
                        lbl_s_owner.Text = DT.Rows[0][12].ToString();
                        lbl_s_area.Text = DT.Rows[0][13].ToString();
                        lbl_s_post.Text = DT.Rows[0][14].ToString();
                        lbl_s_via.Text = DT.Rows[0][15].ToString();
                        lbl_s_pincode.Text = DT.Rows[0][16].ToString();
                        lbl_s_phone.Text = DT.Rows[0][17].ToString();
                        lbl_s_mobile.Text = DT.Rows[0][18].ToString();
                        lbl_s_totalmembers.Text = DT.Rows[0][19].ToString();
                        //lbl_s_male.Text = DT.Rows[0][20].ToString();
                        //lbl_s_emale.Text = DT.Rows[0][21].ToString();
                        lbl_s_income.Text = DT.Rows[0][22].ToString();
                        lbl_s_povertyln.Text = DT.Rows[0][23].ToString();
                        lbl_s_ratncard.Text = DT.Rows[0][24].ToString();
                        lbl_s_propertydtls.Text = DT.Rows[0][25].ToString();
                        lbl_s_relocated.Text = DT.Rows[0][5].ToString();
                        lbl_s_narration.Text = DT.Rows[0][26].ToString();
                    }
                }
                else
                {
                    
                }
            }
            catch { }
        } 

        public void Commonsearch_Residense_By_Community(string key)
        {
            try
            {
                dgv_search.DataSource = null;
                DataTable DT = new DataTable();
                Obj_Cls_Common_search = new Cls_Common_search();
                Obj_Cls_Common_search.Key = key;
                DT = Obj_Cls_Common_search.Commonsearch_Residense_By_Commnity();
                if (DT.Rows.Count > 0 && txt_search.Text != "")
                {
                    flag = 0;
                    dgv_searchpik.DataSource = DT;
                    dgv_searchpik.Columns[0].Visible = false;                    
                }
            }
            catch
            {
            }
        }
        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmb_search.Text == "EDUCATION"))
            {
                pnl_search.Visible = false;
                pnl_search_pick.Visible = false;
                txt_search.Visible = false;
                lbl_search.Visible = false;
                gbx_education_advanced_search.Visible = true;
                pnl_job_search.Visible = false;
            }
            if (cmb_search.Text == "JOB")
            {
                pnl_job_search.Visible = true;
                pnl_search.Visible = false;
                pnl_search_pick.Visible = false;
                txt_search.Visible = false;
                lbl_search.Visible = false;
                gbx_education_advanced_search.Visible =false;
               
            }


            if((cmb_search.Text == "RESIDENCE")||(cmb_search.Text == "COMMUNITY"))
            {
                pnl_search.Visible = true;
                pnl_search_pick.Visible = true;
                txt_search.Visible = true;
                lbl_search.Visible = true;
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != null)
            {
                flag = 0;
                switch (cmb_search.Text)
                {
                    case "RESIDENCE":
                        {
                            Residence_dgv_load(txt_search.Text);
                            return;
                        }
                    case "COMMUNITY":
                        {
                            Commnity_dgv_load(txt_search.Text);
                            return;
                        }
                    case "EDUCATION":
                        {
                                                       
                            return; 

                        }
                    //case "JOB":
                    //    {
                    //    }
                    //default:
                    //    {
                    //    }                        
                }
            }
        }

        private void dgv_searchpik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_searchpik.CurrentCell.RowIndex;
                Commonsearch_Residense_By_Community(dgv_searchpik.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                
                
                
            }
            catch { }
        }

        private void dgv_searchpik_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgv_searchpik.Columns[0].Visible = true;
                if (flag!=1)
                {
                    int rowIndex = dgv_searchpik.CurrentCell.RowIndex;
                    load_lablels_community(dgv_searchpik.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                    load_lablels_education(dgv_searchpik.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                    load_lablels_Job(dgv_searchpik.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                    load_lablels_Residence(dgv_searchpik.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                }
            }
            catch
            {
            }
        }

        private void btn_education_adv_search_Click(object sender, EventArgs e)
        {
            Cls_Db Obj_Cls_Db = new Cls_Db();
            string QRY = "SELECT * FROM EDUCATION_MASTER WHERE ";
            int QRY_COUNT = 1;
            DataTable DT = new DataTable();
            try
            {

                for (int i = 0; i < gbx_education_advanced_search.Controls.Count; i++)
                {
                    if ((string)gbx_education_advanced_search.Controls[i].Tag == "Q" && gbx_education_advanced_search.Controls[i].Text != "")
                    {
                        
                        if (QRY_COUNT <= 1)
                        {
                            QRY = QRY + gbx_education_advanced_search.Controls[i].AccessibleName + "=" +"'"+gbx_education_advanced_search.Controls[i].Text+"'";
                        }
                        else
                        {
                            QRY = QRY + " AND";
                            QRY = QRY + " " + gbx_education_advanced_search.Controls[i].AccessibleName + "=" +"'"+gbx_education_advanced_search.Controls[i].Text+"'";
                        }
                        QRY_COUNT = QRY_COUNT + 1;
                    }
                }

                SqlCommand cmd = new SqlCommand(QRY);
                DT = Obj_Cls_Db.Read(cmd);
                //MessageBox.Show(QRY.ToString());
                dgv_search.DataSource = DT;
            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_job_adv_search_Click(object sender, EventArgs e)
        {
            Cls_Db Obj_Cls_Db = new Cls_Db();
            string QRY = "SELECT * FROM JOB_MASTER WHERE ";
            int QRY_COUNT = 1;
            DataTable DT = new DataTable();
            try
            {

                for (int i = 0; i < gbx_job_advanced_search.Controls.Count; i++)
                {
                    if ((string)gbx_job_advanced_search.Controls[i].Tag == "Q" && gbx_job_advanced_search.Controls[i].Text != "")
                    {
                        
                        if (QRY_COUNT <= 1)
                        {
                            QRY = QRY + gbx_job_advanced_search.Controls[i].AccessibleName + "=" + "'" + gbx_job_advanced_search.Controls[i].Text + "'";
                        }
                        else
                        {
                            QRY = QRY + " AND";
                            QRY = QRY + " " + gbx_job_advanced_search.Controls[i].AccessibleName + "=" + "'" + gbx_job_advanced_search.Controls[i].Text + "'";
                        }
                        QRY_COUNT = QRY_COUNT + 1;
                    }
                }

                SqlCommand cmd = new SqlCommand(QRY);
                DT = Obj_Cls_Db.Read(cmd);
                //MessageBox.Show(QRY.ToString());
                dgv_search.DataSource = DT;
            }
            catch { }
        }

        private void Frm_Search_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
            }
        }

        private void gbx_search_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.KeyChar = (char)Keys.None;
            }
            catch
            {
            }

        }           

               
    }
}
