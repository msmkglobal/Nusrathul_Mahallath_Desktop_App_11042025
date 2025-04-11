using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MAS
{
    public partial class Frm_Community : Form
    {
        //object declaration
        Cls_Community_Master obj_cmnty_master;
        Frm_Resi_lookup obj_Frm_Resi_lookup;
        //Frm_community_lookup obj_Frm_Community_lookup;
        //Cls_Lookup_Bridge Obj_Bridge;
        
        //end of object declaration
        //user defined functions
        //public void Community_Get_Id()
        //{
        //    try
        //    {                
        //        obj_cmnty_master = new Cls_Community_Master();
        //        txt_cmnty_id.Text = obj_cmnty_master.Community_Master_Get_Id().ToString();
        //    }
        //    catch
        //    {
        //    }
        //}

        //public void Community_Datagrid_Refresh()
        //{
        //    try
        //    {
        //        DataTable DT = new DataTable();
        //        obj_cmnty_master = new Cls_Community_Master();
        //        DT = obj_cmnty_master.Community_Select_All();
        //        dgv_community.DataSource = DT;
        //    }
        //    catch
        //    {
        //    }
        //}

        public byte[] imageToByteArray(System.Drawing.Image imageIn)//img to byte
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public void Clear_Controls()
        {
            try
            {
                //txt_cmnty_id.Text = "";
                //txt_resi_id.Text = "";
                txt_name.Text = "";
                cmb_gender.Text = "";
                dtp_dob.Text = "";
                c_age.Clear();
                cmb_mstatus.Text = "";
                cmb_relation.Text = "";
                cmb_phc.Text = "NA";
                cmb_bgroup.Text = "NA";
                txt_pspt_num.Text = "NA";
                txt_uaid.Text = "NA";
                txt_licence.Text = "NA";
                cmb_occupation.Text = "NA";
                txt_email.Text = "NA";
                txt_contact.Text = "NA";
                pbx_photo.Image = pbx_photo.ErrorImage;
                cmb_hujjdone.Text = "NA";
                cmb_status.Text = "ALIVE";
                txt_narration.Text = "NA";
                cmb_phc.Text = "NA";
                cmb_health_status.Text = "NA";
                cmb_lplace.Text = "NA";
                txt_cmnty_id.Focus();
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
                    //txt_cmnty_id.Enabled = false;
                    //txt_resi_id.Enabled = false;
                    txt_name.Enabled = false;
                    cmb_gender.Enabled = false;
                    dtp_dob.Enabled = false;
                    c_age.Enabled = false;
                    cmb_mstatus.Enabled = false;
                    cmb_relation.Enabled = false;
                    cmb_phc.Enabled = false;
                    cmb_bgroup.Enabled = false;
                    txt_pspt_num.Enabled = false;
                    txt_uaid.Enabled = false;
                    txt_licence.Enabled = false;
                    cmb_occupation.Enabled = false;
                    cmb_lplace.Enabled = false;
                    txt_email.Enabled = false;
                    txt_contact.Enabled = false;
                    pbx_photo.Image = pbx_photo.ErrorImage;
                    cmb_hujjdone.Enabled = false;
                    cmb_status.Enabled = false;
                    txt_narration.Enabled = false;
                    cmb_phc.Enabled = false;
                    cmb_health_status.Enabled = false;
                    btn_pick_jno.Enabled = false;
                    btn_pik_cmnty_id.Enabled = false;
                }
                else if (mode == "False")
                {
                    //txt_cmnty_id.Enabled = true;
                    //txt_resi_id.Enabled = true;
                    txt_name.Enabled = true;
                    cmb_gender.Enabled = true;
                    dtp_dob.Enabled = true;
                    c_age.Enabled = true;
                    cmb_mstatus.Enabled = true;
                    cmb_relation.Enabled = true;
                    cmb_phc.Enabled = true;
                    cmb_bgroup.Enabled = true;
                    txt_pspt_num.Enabled = true;
                    txt_uaid.Enabled = true;
                    txt_licence.Enabled = true;
                    cmb_occupation.Enabled = true;
                    cmb_lplace.Enabled = true;
                    txt_email.Enabled = true;
                    txt_contact.Enabled = true;
                    pbx_photo.Image = pbx_photo.ErrorImage;
                    cmb_hujjdone.Enabled = true;
                    cmb_status.Enabled = true;
                    txt_narration.Enabled = true;
                    cmb_phc.Enabled = true;
                    cmb_health_status.Enabled = true;
                    btn_pick_jno.Enabled = true;
                    btn_pik_cmnty_id.Enabled = true;
                    

                }
            }
            catch { }
        }

        private void Community_Bind_Controls(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                obj_cmnty_master = new Cls_Community_Master();
                if (Keys != "")
                {
                    Controls_Readonly("True");
                    obj_cmnty_master.Keys = Keys;
                    DT = obj_cmnty_master.Community_Master_Select_By_Keys();
                    txt_cmnty_id.Text = DT.Rows[0][0].ToString();
                    txt_resi_id.Text = DT.Rows[0][1].ToString();
                    txt_name.Text = DT.Rows[0][2].ToString();
                    cmb_gender.Text = DT.Rows[0][3].ToString();
                    dtp_dob.Text = DT.Rows[0][4].ToString();

                    c_age.Text=DT.Rows[0][5].ToString();
                    cmb_mstatus.Text = DT.Rows[0][6].ToString();
                    cmb_relation.Text = DT.Rows[0][7].ToString();
                    cmb_bgroup.Text = DT.Rows[0][8].ToString();
                    cmb_health_status.Text = DT.Rows[0][9].ToString();
                    cmb_phc.Text = DT.Rows[0][10].ToString();
                    txt_uaid.Text = DT.Rows[0][11].ToString();
                    txt_pspt_num.Text = DT.Rows[0][12].ToString();
                    txt_licence.Text = DT.Rows[0][13].ToString();
                    cmb_occupation.Text = DT.Rows[0][14].ToString();
                    cmb_lplace.Text = DT.Rows[0][15].ToString();
                    txt_email.Text = DT.Rows[0][16].ToString();
                    txt_contact.Text = DT.Rows[0][17].ToString();
                    cmb_hujjdone.Text = DT.Rows[0][18].ToString();

                    byte[] Photo = new byte[0];
                    Photo = (byte[])(DT.Rows[0][20]);
                    MemoryStream Photostream = new MemoryStream(Photo);
                    pbx_photo.Image = Image.FromStream(Photostream);
                    txt_narration.Text = DT.Rows[0][21].ToString();
                    cmb_status.Text = DT.Rows[0][22].ToString();                   

                }
                else
                {
                    Clear_Controls();
                    btn_save.Enabled = true;
                    Controls_Readonly("True");
                    txt_search.Focus();
                }
            }
            catch { }
        }

        public void Community_Search_By_Cmnty_Id()
        {
            try
            {

                DataTable DT = new DataTable();
                obj_cmnty_master = new Cls_Community_Master();
                obj_cmnty_master.Cmnty_id = txt_search.Text;
                DT = obj_cmnty_master.Community_Select_By_Cmnty_Id();
                if ((DT.Rows.Count > 0) && (txt_search.Text != ""))
                {
                    dgv_community.DataSource = DT;
                    txt_cmnty_id.Text = DT.Rows[0][0].ToString();
                    txt_resi_id.Text = DT.Rows[0][1].ToString();
                    txt_name.Text = DT.Rows[0][2].ToString();
                    cmb_gender.Text = DT.Rows[0][3].ToString();
                    dtp_dob.Text = DT.Rows[0][4].ToString();
                    cmb_mstatus.Text = DT.Rows[0][5].ToString();
                    cmb_relation.Text = DT.Rows[0][6].ToString();
                    cmb_bgroup.Text = DT.Rows[0][7].ToString();
                    cmb_health_status.Text = DT.Rows[0][8].ToString();
                    cmb_phc.Text = DT.Rows[0][9].ToString();
                    txt_pspt_num.Text = DT.Rows[0][10].ToString();
                    txt_uaid.Text = DT.Rows[0][11].ToString();
                    cmb_occupation.Text = DT.Rows[0][12].ToString();
                    txt_email.Text = DT.Rows[0][13].ToString();
                    txt_contact.Text = DT.Rows[0][14].ToString();

                    byte[] Photo = new byte[0];
                    Photo = (byte[])(DT.Rows[0][18]);
                    MemoryStream Photostream = new MemoryStream(Photo);
                    pbx_photo.Image = Image.FromStream(Photostream);


                    cmb_hujjdone.Text = DT.Rows[0][16].ToString();
                    cmb_status.Text = DT.Rows[0][20].ToString();
                    txt_narration.Text = DT.Rows[0][19].ToString();
                }
                else
                {

                    dgv_community.DataSource = null;
                    Clear_Controls();

                }
            }
            catch
            {
            }

        }

        public void Community_Search_By_Keys(string Keys)
        {
            try
            {

                DataTable DT = new DataTable();
                obj_cmnty_master = new Cls_Community_Master();
                obj_cmnty_master.Keys = Keys;
                DT = obj_cmnty_master.Community_Master_Select_By_Keys();
                if (DT.Rows.Count > 0)
                {

                    dgv_community.DataSource = DT;

                }
                else
                {
                    dgv_community.DataSource = null;
                }
            }
            catch
            {
            }


        }
        //end of userdefined functions

        public Frm_Community()
        {
            InitializeComponent();
        }

        private void Frm_Community_Load(object sender, EventArgs e)
        {
            //lbl_date.Text = System.DateTime.Now.ToShortDateString();
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            Clear_Controls();
            dgv_community.Enabled = false;
            //Community_Datagrid_Refresh();
            // Community_Get_Id();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtp_dob.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void cmb_phc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_bgroup.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void cmb_mstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_relation.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void cmb_relation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_phc.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void cmb_bgroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_health_status.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void cmb_occupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_lplace.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }
        
        private void cmb_health_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_uaid.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void cmb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_narration.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_gender.Focus();
            }
        }

        private void dtp_dob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_mstatus.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void txt_pspt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_licence.Focus();
            }
        }

        private void txt_uaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_pspt_num.Focus();
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_hujjdone.Focus();
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_email.Focus();
            }
        }

        private void txt_cmnty_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_resi_id.Focus();
            }
        }

        private void txt_resi_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_name.Focus();
            }
        }

        private void txt_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmb_status.Focus();
                }
            }
            catch
            {
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permanently delete this file?", "Community [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    obj_cmnty_master = new Cls_Community_Master();
                    obj_cmnty_master.Cmnty_id = txt_cmnty_id.Text;

                    if (obj_cmnty_master.Community_Master_Delete() > 0)
                    {
                        MessageBox.Show("File Deleted!", "Community[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_Controls();                        
                        //Community_Datagrid_Refresh();
                        txt_search.Text = "";
                        dgv_community.DataSource = null;
                        txt_search.Focus();
                    }
                }
            }
            catch
            {
            }
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Community[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gpbx_community.Controls.Count; i++)
                    {
                        if ((string)gpbx_community.Controls[i].Tag == "M" && gpbx_community.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Community[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gpbx_community.Controls[i].Focus();
                            return;
                        }
                    }
                    obj_cmnty_master = new Cls_Community_Master();
                    obj_cmnty_master.Cmnty_id = txt_cmnty_id.Text; ;
                    obj_cmnty_master.Resi_id = txt_resi_id.Text;
                    obj_cmnty_master.Name = txt_name.Text;
                    obj_cmnty_master.Gender = cmb_gender.Text;
                    obj_cmnty_master.Dob = dtp_dob.Text;
                    obj_cmnty_master.Age = Convert.ToInt32(c_age.Text);
                    obj_cmnty_master.Mstatus = cmb_mstatus.Text;
                    obj_cmnty_master.Relation = cmb_relation.Text;
                    obj_cmnty_master.B_group = cmb_bgroup.Text;
                    obj_cmnty_master.Health_status = cmb_health_status.Text;
                    obj_cmnty_master.Phc = cmb_phc.Text;
                    obj_cmnty_master.Pspt_num = txt_pspt_num.Text;
                    obj_cmnty_master.Uaid = txt_uaid.Text;
                    obj_cmnty_master.Dlc = txt_licence.Text; ;
                    obj_cmnty_master.Occupation = cmb_occupation.Text;
                    obj_cmnty_master.Lplace = cmb_lplace.Text;
                    obj_cmnty_master.Email = txt_email.Text;
                    obj_cmnty_master.Contact = txt_contact.Text;
                    obj_cmnty_master.Photo = imageToByteArray(pbx_photo.BackgroundImage);
                    obj_cmnty_master.Hajj_done = cmb_hujjdone.Text;
                    obj_cmnty_master.Dod = "";
                    obj_cmnty_master.Status = cmb_status.Text;
                    obj_cmnty_master.Narration = txt_narration.Text;
                    obj_cmnty_master.Description = txt_narration.Text;
                    obj_cmnty_master.Created = DateTime.Today.ToShortDateString();
                    obj_cmnty_master.Modified = DateTime.Today.ToShortDateString();
                    obj_cmnty_master.Deleted = DateTime.Today.ToShortDateString();
                    obj_cmnty_master.Printed = "NO";
                    obj_cmnty_master.Userid = "Admin";
                }
                else
                {
                    txt_cmnty_id.Focus();
                    return;

                }

                if (obj_cmnty_master.Community_Master_Insert() > 0)
                {
                    MessageBox.Show("Data Saved!", "Community[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Community_Search_By_Keys(txt_cmnty_id.Text);
                    Clear_Controls();
                    //Community_Datagrid_Refresh();
                    //Community_Get_Id();
                }



            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString(), "Community[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            //Community_Datagrid_Refresh();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            //Community_Get_Id();
            //Community_Datagrid_Refresh(); 
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                int result = 0;

                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Community [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    for (int i = 0; i < gpbx_community.Controls.Count; i++)
                    {
                        if ((string)gpbx_community.Controls[i].Tag == "M" && gpbx_community.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Community[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gpbx_community.Controls[i].Focus();
                            return;
                        }
                    }
                    obj_cmnty_master = new Cls_Community_Master();
                    obj_cmnty_master.Cmnty_id = txt_cmnty_id.Text;
                    obj_cmnty_master.Resi_id = txt_resi_id.Text;
                    obj_cmnty_master.Name = txt_name.Text;
                    obj_cmnty_master.Gender = cmb_gender.Text;
                    obj_cmnty_master.Dob = dtp_dob.Text;
                    obj_cmnty_master.Mstatus = cmb_mstatus.Text;
                    obj_cmnty_master.Relation = cmb_relation.Text;
                    obj_cmnty_master.B_group = cmb_bgroup.Text;
                    obj_cmnty_master.Health_status = cmb_health_status.Text;
                    obj_cmnty_master.Phc = cmb_phc.Text;
                    obj_cmnty_master.Pspt_num = txt_pspt_num.Text;
                    obj_cmnty_master.Uaid = txt_uaid.Text;
                    obj_cmnty_master.Dlc = txt_licence.Text; ;
                    obj_cmnty_master.Occupation = cmb_occupation.Text;
                    obj_cmnty_master.Lplace = cmb_lplace.Text;
                    obj_cmnty_master.Email = txt_email.Text;
                    obj_cmnty_master.Contact = txt_contact.Text;
                    obj_cmnty_master.Photo = imageToByteArray(pbx_photo.BackgroundImage);
                    obj_cmnty_master.Hajj_done = cmb_hujjdone.Text;
                    obj_cmnty_master.Dod = "";
                    obj_cmnty_master.Status = cmb_status.Text;
                    obj_cmnty_master.Narration = txt_narration.Text;
                    obj_cmnty_master.Created = DateTime.Today.ToShortDateString();
                    obj_cmnty_master.Modified = DateTime.Today.ToShortDateString();
                    obj_cmnty_master.Deleted = "";
                    obj_cmnty_master.Userid = "Admin";
                }
                else
                {
                    txt_cmnty_id.Focus();
                    return;
                }

                if (obj_cmnty_master.Community_Master_Update() > 0)
                {
                    MessageBox.Show("File Updated!", "Community[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Community_Search_By_Keys(txt_cmnty_id.Text);
                    
                    Community_Search_By_Keys(txt_cmnty_id.Text);
                    Controls_Readonly("True");
                    //Community_Datagrid_Refresh();
                    dgv_community.Enabled = true;
                }

            }
            catch
            {
            }
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            int result = (int)MessageBox.Show("Do you want to clear the data?", "Residence [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == (int)DialogResult.OK)
            {
                dgv_community.Enabled = false;
                Clear_Controls();
                Controls_Readonly("False");
                dgv_community.DataSource = null;
                txt_search.Text = "";
                btn_save.Enabled = true;
                txt_cmnty_id.Enabled = false;
                txt_resi_id.Enabled = false;

                //Community_Get_Id();
                //Community_Datagrid_Refresh(); 
            }
            else
            {
                if (dgv_community.DataSource == null)
                {
                    btn_save.Enabled = true;
                }
                return;
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i <= Controls[1].Controls.Count; i++)
            //{
            //MessageBox.Show(Controls[1].Controls[i].Name.ToString());
            //}
        }

        private void txt_licence_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmb_occupation.Focus();
                }
            }
            catch
            {
            }
        }
        
        private void cmb_lplace_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_contact.Focus();
                }
            }
            catch
            {
            }
        }
                
        private void dgv_community_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                try
                {
                    btn_save.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_delete.Enabled = false;
                    int rowIndex = dgv_community.CurrentCell.RowIndex;
                    Community_Bind_Controls(dgv_community.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                }
                catch { }
            }
            catch
            {
            }
        }

        private void dgv_community_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_community.CurrentCell.RowIndex;
                Community_Bind_Controls(dgv_community.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Community_Search_By_Keys(txt_cmnty_id.Text);
                Controls_Readonly("False");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            catch { }
        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                dgv_community.Enabled = true;
                if (txt_search.Text != "")
                {

                    Community_Search_By_Keys(txt_search.Text);

                }
                else
                {
                    btn_edit.Enabled = true;
                }

            }
            catch
            {
            }
        }

        private void txt_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPEG Image(*jpeg)|*.jpg|Bitmap(*bmp)|*.bmp";
                open.Multiselect = false;
                if (open.ShowDialog(this) != DialogResult.Cancel)
                {
                    pbx_photo.BackgroundImage = Image.FromFile(open.FileName);
                }
            }
            catch
            {
            }
        }

        private void cmb_hujjdone_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == 13)
                {
                    cmb_status.Focus();
                }
            }
            catch
            {
            } 
            e.KeyChar = (char)Keys.None;
        }

        private void lbl_capture_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cancel_Click(object sender, EventArgs e)
        {
            pbx_photo.Image = pbx_photo.ErrorImage;
        }

        private void txt_resi_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pick_jno_Click(object sender, EventArgs e)
        {
            try
            {
                obj_Frm_Resi_lookup = new Frm_Resi_lookup(this, "Frm_Community");
                obj_Frm_Resi_lookup.ShowDialog();
                
            }
            catch
            {
            }

        }
        
        private void btn_pik_cmnty_id_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_resi_id.Text != "")
                {
                    Frm_Family_Tree obj_Frm_Famly_Tree = new Frm_Family_Tree(this);
                    obj_Frm_Famly_Tree.ShowDialog();
                }
                else
                {
                    MessageBox.Show("JNO was not supplied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }


        }

        private void lbl_brows_Click(object sender, EventArgs e)
        {

        }

        private void cmb_occupation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_community_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void c_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
