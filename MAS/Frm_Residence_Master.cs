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
    public partial class Frm_Residence : Form
    {
        Cls_Residence_Master obj_residence_master;
        

        public Frm_Residence()
        {
            InitializeComponent();
        }
        
        //public void Residence_Get_Id()
        //{
        //    try
        //    {
        //        obj_residence_master = new Cls_Residence_Master();

        //        int Resi_Id = obj_residence_master.Residence_Get_Id();
        //        txt_resi_id.Text = Resi_Id.ToString();
        //    }
        //    catch
        //    {
        //    }
        //}        

        public void Clear_Controls()
        {
            try
            {                
                txt_resi_id.Text = "";
                cmb_type.Text="";
                cmb_fmlytype.Text = "";
                txt_bldg_num.Text="NA";
                txt_ward_num.Text="";
                txt_panjayath.Text="NA";
                txt_block_num.Text="NA";
                txt_owner_name.Text="";
                txt_residance_name.Text="";
                txt_place.Text="NA";
                txt_post.Text="KANIYAPURAM";
                c_panchayath_ward_number.Text="NA";
                txt_pincode.Text = "695301";
                txt_phone.Text="000";
                txt_male.Text="";
                txt_female.Text="";
                txt_total_mem.Text="";
                txt_family_income.Text = "NA";
                cmb_poverty.Text = "NA";
                txt_rnc_num.Text = "NA";
                txt_property.Text = "NA";
                txt_mobile.Text = "NA";
                txt_district.Text = "THIRUVANANTHAPURAM";
                Cmb_fmlyclass.Text = "MIDDLE";
                cmb_poverty.Text = "NA";
                txt_relocated.Text = "NA";
                txt_naration.Text = "NA";
                cbx_relocated.Checked=false;
                
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
                        cmb_type.Enabled = false;
                        cmb_fmlytype.Enabled = false;
                        txt_resi_id.ReadOnly = true;
                        txt_bldg_num.ReadOnly = true;
                        txt_ward_num.ReadOnly = true;
                        txt_panjayath.ReadOnly = true;
                        txt_block_num.ReadOnly = true;
                        txt_owner_name.ReadOnly = true;
                        txt_residance_name.ReadOnly = true;
                        txt_place.ReadOnly = true;
                        txt_post.ReadOnly = true;
                        c_panchayath_ward_number.ReadOnly = true;
                        txt_pincode.ReadOnly = true;
                        txt_phone.ReadOnly = true;
                        txt_male.ReadOnly = true;
                        txt_female.ReadOnly = true;
                        
                        txt_family_income.Enabled = false;
                        cmb_poverty.Enabled = false;
                        txt_rnc_num.ReadOnly = true;
                        txt_property.ReadOnly = true;
                        txt_mobile.ReadOnly = true;
                        txt_district.ReadOnly = true;
                        Cmb_fmlyclass.Enabled = false;
                        cmb_poverty.Enabled = false;
                        txt_relocated.ReadOnly = true;
                        txt_naration.ReadOnly = true;
                        cbx_relocated.Enabled = false;
                      
                    }
                    else if(mode=="False")
                    {
                        cmb_type.Enabled = true;
                        cmb_fmlytype.Enabled = true;
                        txt_resi_id.ReadOnly = false;
                        txt_bldg_num.ReadOnly = false;
                        txt_ward_num.ReadOnly = false;
                        txt_panjayath.ReadOnly = false;
                        txt_block_num.ReadOnly = false;
                        txt_owner_name.ReadOnly = false;
                        txt_residance_name.ReadOnly = false;
                        txt_place.ReadOnly = false;
                        txt_post.ReadOnly = false;
                        c_panchayath_ward_number.ReadOnly = false;
                        txt_pincode.ReadOnly = false;
                        txt_phone.ReadOnly = false;
                        txt_male.ReadOnly = false;
                        txt_female.ReadOnly = false;
                        
                        txt_family_income.Enabled = true;
                        cmb_poverty.Enabled = true;
                        txt_rnc_num.ReadOnly = false;
                        txt_property.ReadOnly = false;
                        txt_mobile.ReadOnly = false;
                        txt_district.ReadOnly = false;
                        Cmb_fmlyclass.Enabled = true;
                        cmb_poverty.Enabled = true;
                        txt_relocated.ReadOnly = false;
                        txt_naration.ReadOnly = false;
                        cbx_relocated.Checked = false;
                        cbx_relocated.Enabled = true;                        
                    }
                }
                catch { }
            }
                
        private void Residence_Bind_Controls(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                obj_residence_master = new Cls_Residence_Master();
                if (Keys != "")
                {
                    Controls_Readonly("True");
                    obj_residence_master.Rid = Keys;
                    DT = obj_residence_master.Residence_Find_Resi_Id();

                    txt_resi_id.Text = DT.Rows[0]["RESIDENCE ID"].ToString();
                    cmb_type.Text = DT.Rows[0]["RESIDENCE TYPE"].ToString();
                    cmb_fmlytype.Text = DT.Rows[0]["FAMILY TYPE"].ToString();
                    Cmb_fmlyclass.Text = DT.Rows[0]["FAMILY CLASS"].ToString();
                    txt_bldg_num.Text = DT.Rows[0]["BUILDING NUMBER"].ToString();
                    txt_ward_num.Text = DT.Rows[0]["WARD NUM"].ToString();
                    txt_panjayath.Text = DT.Rows[0]["PANCHAYATH"].ToString();
                    txt_block_num.Text = DT.Rows[0]["BLOCK"].ToString();
                    txt_district.Text = DT.Rows[0]["DISTRICT"].ToString();
                    txt_residance_name.Text = DT.Rows[0]["RESIDENCE NAME"].ToString();
                    txt_owner_name.Text = DT.Rows[0]["RESIDENCE OWNER"].ToString();
                    txt_place.Text = DT.Rows[0]["AREA"].ToString();
                    txt_post.Text = DT.Rows[0]["POST"].ToString();
                    c_panchayath_ward_number.Text = DT.Rows[0]["PANCHAYATWARD"].ToString();
                    txt_pincode.Text = DT.Rows[0]["PINCODE"].ToString();
                    txt_phone.Text = DT.Rows[0]["PHONE"].ToString();
                    txt_mobile.Text = DT.Rows[0]["MOBILE"].ToString();
                    txt_total_mem.Text = DT.Rows[0]["STRENGTH"].ToString();
                    txt_male.Text = DT.Rows[0]["MALE"].ToString();
                    txt_female.Text = DT.Rows[0]["FEMALE"].ToString();
                    txt_family_income.Text = DT.Rows[0]["INCOME"].ToString();
                    cmb_poverty.Text = DT.Rows[0]["POVERTY"].ToString();
                    txt_rnc_num.Text = DT.Rows[0]["RATION CARDNUMBER"].ToString();
                    txt_property.Text = DT.Rows[0]["PROPERTY"].ToString();
                    txt_relocated.Text = DT.Rows[0]["RELOCATED DETAILS"].ToString();
                    txt_naration.Text = DT.Rows[0]["NARRATION"].ToString();
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

        public void Residence_Dgv_Fill()
        {
            try
            {
                DataTable DT = new DataTable();
                obj_residence_master = new Cls_Residence_Master();
                obj_residence_master.Rid = txt_resi_id.Text;
                DT = obj_residence_master.Residence_Find_Resi_Id();
                dgv_residence.DataSource = DT;
            }
            catch
            {
            }
        }

        private void Total_member_find()
        {
            int a, b, c;
            try
            {

                a = (int.Parse(txt_male.Text));
                b = (int.Parse(txt_female.Text));
                c = a + b;
                txt_total_mem.Text = c.ToString();
            }
            catch
            {
            }
        }

        private void No_Special_Char(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || char.IsNumber(pressedKey)||char.IsControl(pressedKey))
            {
                //Disable entering the character
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Residence [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gpbx_residance.Controls.Count; i++)
                    {
                        if ((string)gpbx_residance.Controls[i].Tag == "M" && gpbx_residance.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gpbx_residance.Controls[i].Focus();
                            return;
                        }
                    }
                    obj_residence_master = new Cls_Residence_Master();
                    obj_residence_master.Rid = txt_resi_id.Text.Trim();
                    obj_residence_master.Reg_date = DateTime.Today.ToShortDateString(); ;
                    obj_residence_master.Type = cmb_type.Text;
                    obj_residence_master.Fmly_type = cmb_fmlytype.Text;
                    obj_residence_master.Famlyclass = Cmb_fmlyclass.Text;
                    obj_residence_master.Relocated = txt_relocated.Text;
                    obj_residence_master.Bldg_num = txt_bldg_num.Text;
                    obj_residence_master.Ward_num = txt_ward_num.Text;
                    obj_residence_master.Pnj_name = txt_panjayath.Text;
                    obj_residence_master.Panchayat_ward = c_panchayath_ward_number.Text;
                    obj_residence_master.Block_num = txt_block_num.Text;
                    obj_residence_master.District = txt_district.Text;
                    obj_residence_master.Resi_name = txt_residance_name.Text;
                    obj_residence_master.Owner_name = txt_owner_name.Text;
                    obj_residence_master.Place = txt_place.Text;
                    obj_residence_master.Post = txt_post.Text;                    
                    obj_residence_master.Pincode = int.Parse(txt_pincode.Text);
                    obj_residence_master.Phone = txt_phone.Text;
                    obj_residence_master.Mobile = txt_mobile.Text;
                    obj_residence_master.Total_mem = int.Parse(txt_total_mem.Text);
                    obj_residence_master.Male = int.Parse(txt_male.Text);
                    obj_residence_master.Female = int.Parse(txt_female.Text);
                    obj_residence_master.Fmly_income = txt_family_income.Text;
                    obj_residence_master.Poverty = cmb_poverty.Text;
                    obj_residence_master.Rnc_num = txt_rnc_num.Text;
                    obj_residence_master.Property = txt_property.Text;
                    obj_residence_master.Narration = txt_naration.Text;
                    obj_residence_master.Created = DateTime.Now.ToShortTimeString();
                    obj_residence_master.Modified = "NA";
                    obj_residence_master.Deleted = "NA";
                    obj_residence_master.User_id = "Admin";
                    obj_residence_master.Status = "ACTIVE";
                    dgv_residence.Enabled = true;
                }
                else
                {
                    return;
                }

                if (obj_residence_master.Residence_Master_Insert() > 0)
                {
                    MessageBox.Show("New Residence Saved!", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Residence_Dgv_Fill();
                    txt_resi_id.Focus();
                    btn_save.Enabled = false;
                    Controls_Readonly("True");
                }
                else
                {
                    txt_resi_id.Focus();
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString(), "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Residence_Master_Select_By_Keyword()
        {
            DataTable DT = new DataTable();
            try
            {
                dgv_residence.DataSource = null;
                Clear_Controls();
                obj_residence_master = new Cls_Residence_Master();
                obj_residence_master.Resi_name = txt_search.Text;
                obj_residence_master.Ward_num = txt_search.Text;
                obj_residence_master.Owner_name = txt_search.Text;
                obj_residence_master.Mobile = txt_search.Text;

                DT = obj_residence_master.Residence_Master_Select_By_Keyword();
                if (DT.Rows.Count > 0)
                {
                    dgv_residence.DataSource = DT;
                    
                }
            
            }
            catch
            {

            }
        }

        public void Residence_Find_Resi_Id()
        {
            DataTable DT = new DataTable();
            try
            {
                dgv_residence.DataSource = null;
                Clear_Controls();
                obj_residence_master = new Cls_Residence_Master();
                obj_residence_master.Rid = txt_search.Text;
                DT = obj_residence_master.Residence_Find_Resi_Id();
                if (DT.Rows.Count > 0)
                {
                    dgv_residence.DataSource = DT;                    

                }
            }
            catch
            {
            }
        }

        private void Frm_Residence_Load(object sender, EventArgs e)
        {
                dgv_residence.Enabled = false;
                Clear_Controls();
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
        }

        private void cmb_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmb_fmlytype.Focus();
                }
                else
                {
                    e.KeyChar = (char)Keys.None;
                }
            }
            catch { }
        }

        private void txt_bldg_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_ward_num.Focus();
                }               
            }
            catch { }
        }

        private void txt_panjayath_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_block_num.Focus();
                }
                else
                {
                    e.KeyChar = (char)Keys.None;
                }
            }
            catch { }
        }

        private void txt_block_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_district.Focus();
                }

            }
            catch { }
        }

        private void txt_ward_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_panjayath.Focus();
                }
               
            }
            catch { }
        }

        private void txt_owner_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_place.Focus();
                }
              
            }
            catch { }
        }

        private void txt_residance_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_owner_name.Focus();
                }
               
            }
            catch { }
        }

        private void txt_male_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                if (e.KeyChar == 13)
                {
                    txt_female.Focus();
                }

            }
            catch { }
        }

        private void txt_female_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == 13)
            {
                
                txt_family_income.Focus();
            }
        }        

        private void txt_place_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_post.Focus();
                }                
            }
            catch { }
        }

        private void txt_post_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    c_panchayath_ward_number.Focus();
                }               
            }
            catch { }
        }

        private void txt_via_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_pincode.Focus();
                }
                
            }
            catch { }
        }

        private void txt_pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                if (e.KeyChar == 13)
                {
                    txt_phone.Focus();
                }
               
            }
            catch { }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if (e.KeyChar == 13)
                {
                    txt_mobile.Focus();
                }
                
            }
            catch { }
        }

        private void txt_family_income_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmb_poverty.Focus();
                }
              
            }
            catch { }
        }

        private void cmb_poverty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_rnc_num.Focus();
                }
               
            }
            catch { }
        }

        private void txt_rnc_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_property.Focus();
                }
                
            }
            catch { }
        }

        private void txt_resi_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //No_Special_Char(sender, e);
                if (e.KeyChar == 13)
                {
                    cmb_type.Focus();
                }                
            }
            catch { }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Do you want to clear the data?", "Residence [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    btn_save.Enabled = true;
                    Clear_Controls();                    
                    txt_search.Text = "";
                    Controls_Readonly("False");
                    dgv_residence.Enabled = false;
                    dgv_residence.DataSource = null;
                    //txt_panjayath.Text = "PAYYOLI";
                    //txt_block_num.Text = "MELADI";
                    //txt_district.Text = "KOZHIKKODE";
                    //txt_post.Text="KOTTAKKAL";
                    //c_panchayath_ward_number.Text = "IRINGAL";
                    //txt_pincode.Text = "673521";
                        
                }
                else
                {
                    btn_save.Enabled = true;
                    return;
                }
            }
            catch
            {
            }
           
        }      

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                btn_save.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                if (rdb_byid.Checked == true)
                {
                    Residence_Find_Resi_Id();
                }
                else
                {
                    Residence_Master_Select_By_Keyword();
                } 
                dgv_residence.Enabled = true;

            }
            else
            {
                btn_save.Enabled = true;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permenently Delete this file?", "Residence [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes && txt_resi_id.Text != "")
                {
                    obj_residence_master = new Cls_Residence_Master();
                    obj_residence_master.Rid = txt_resi_id.Text;
                    if (obj_residence_master.Residence_Delete() > 0)
                    {
                        MessageBox.Show("File Deleted!", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_Controls();
                        Residence_Dgv_Fill();
                    }
                }
                else
                {
                    MessageBox.Show("Please select  a valid data", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            catch
            {
            }
        }

        private void rdb_byid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
      
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                obj_residence_master = new Cls_Residence_Master();
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Residence [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    for (int i = 0; i < gpbx_residance.Controls.Count; i++)
                    {
                        if ((string)gpbx_residance.Controls[i].Tag == "M" && gpbx_residance.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gpbx_residance.Controls[i].Focus();
                            return;
                        }
                    }
                    obj_residence_master.Rid = txt_resi_id.Text;
                    obj_residence_master.Reg_date = DateTime.Today.ToShortDateString(); ;
                    obj_residence_master.Type = cmb_type.Text;
                    obj_residence_master.Fmly_type = cmb_fmlytype.Text;
                    obj_residence_master.Famlyclass = Cmb_fmlyclass.Text;
                    obj_residence_master.Relocated = txt_relocated.Text;
                    obj_residence_master.Bldg_num = txt_bldg_num.Text;
                    obj_residence_master.Ward_num = txt_ward_num.Text;
                    obj_residence_master.Pnj_name = txt_panjayath.Text;
                    obj_residence_master.Block_num = txt_block_num.Text;
                    obj_residence_master.District = txt_district.Text;
                    obj_residence_master.Resi_name = txt_residance_name.Text;
                    obj_residence_master.Owner_name = txt_owner_name.Text;
                    obj_residence_master.Place = txt_place.Text;
                    obj_residence_master.Post = txt_post.Text;
                    obj_residence_master.Panchayat_ward = c_panchayath_ward_number.Text;
                    obj_residence_master.Pincode = int.Parse(txt_pincode.Text);
                    obj_residence_master.Phone = txt_phone.Text;
                    obj_residence_master.Mobile = txt_mobile.Text;
                    obj_residence_master.Total_mem = int.Parse(txt_total_mem.Text);
                    obj_residence_master.Male = int.Parse(txt_male.Text);
                    obj_residence_master.Female = int.Parse(txt_female.Text);
                    obj_residence_master.Fmly_income = txt_family_income.Text;
                    obj_residence_master.Poverty = cmb_poverty.Text;
                    obj_residence_master.Rnc_num = txt_rnc_num.Text;
                    obj_residence_master.Property = txt_property.Text;
                    obj_residence_master.Narration = txt_naration.Text;
                    //obj_residence_master.Created = DateTime.Now.ToShortTimeString();
                    obj_residence_master.Modified = "NA";
                    //obj_residence_master.Deleted = "NA";
                    obj_residence_master.User_id = "Admin";
                    obj_residence_master.Status = "ACTIVE";
                    dgv_residence.Enabled = true;

                    if (obj_residence_master.Residence_Master_Update() > 0)
                    {
                        MessageBox.Show("File Updated!", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Residence_Dgv_Fill();
                        txt_resi_id.Focus();
                        Controls_Readonly("True");
                    }
                }

            }
            catch 
            {
                MessageBox.Show("Please enter the  correct data in fields", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_panjayath_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_block_num.Focus();
                }
            }
            catch { }
        }

        private void cbx_relocated_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_relocated.Checked == true)
                {
                    txt_relocated.Enabled = true;
                }
                else
                {
                    txt_relocated.Enabled = false;
                }
            }
            catch { }
        }

        //private void txt_resi_id_Validated(object sender, EventArgs e)
        //{
        //    if (btn_save.Enabled == true)
        //    {
        //        DataTable DT = new DataTable();
        //        try
        //        {
        //            obj_residence_master = new Cls_Residence_Master();
        //            obj_residence_master.Rid = txt_resi_id.Text;
        //            DT = obj_residence_master.Residence_pk_chek();

        //            if (DT.Rows.Count > 0)
        //            {
        //                MessageBox.Show("This ID is alredy used pleas choose another", "Residence [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                txt_resi_id.Focus();
        //                txt_resi_id.Text = "";
        //            }
        //        }
        //        catch { }
        //    }
        //}

        private void dgv_residence_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                try
                {
                    btn_save.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_delete.Enabled = false;
                    int rowIndex = dgv_residence.CurrentCell.RowIndex;
                    Residence_Bind_Controls(dgv_residence.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                }
                catch { } 
            }
            catch
            {
            }
        }

        private void dgv_residence_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_residence.CurrentCell.RowIndex;
                Residence_Bind_Controls(dgv_residence.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Controls_Readonly("False");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;                
                if (txt_relocated.Text == "")
                {
                    cbx_relocated.Checked = false;
                }
                else
                {
                    cbx_relocated.Checked = true;
                }


                cmb_type.Focus();
            }
            catch { }
        }

        private void txt_district_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_residance_name.Focus();
                }
            }
            catch { }
        }

        private void txt_family_income_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmb_poverty.Focus();
                }
                else
                {
                    e.KeyChar = (char)Keys.None;
                }

            }
            catch { }
        }

        private void cmb_poverty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_rnc_num.Focus();
                }
                else
                {
                    e.KeyChar = (char)Keys.None;
                }

            }
            catch { }
        }

        private void txt_rnc_num_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_property.Focus();
                }

            }
            catch { }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_male.Focus();
                }

            }
            catch { }
        }

        private void btn_cpanel_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_fmlyclass_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_bldg_num.Focus();
                }
                else
                {
                    e.KeyChar = (char)Keys.None;
                }

            }
            catch { }
        }

        private void txt_ward_num_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_fmlytype_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    Cmb_fmlyclass.Focus();
                }
                else
                {
                    e.KeyChar = (char)Keys.None;
                }

            }
            catch { }
        }

        private void btn_pick_jno_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Resi_lookup obj_Frm_Resi_lookup = new Frm_Resi_lookup(this, "Frm_Community");
                obj_Frm_Resi_lookup.ShowDialog();
            }
            catch
            {
            }
        }

        private void gpbx_residance_Enter(object sender, EventArgs e)
        {

        }

        private void txt_male_Validated(object sender, EventArgs e)
        {
            try
            {

                if (txt_male.Text == "")
                {
                    txt_male.Text = "0";
                    Total_member_find();
                }
                if (txt_male.Text != (null) && (int.Parse(txt_male.Text)) > 0)
                {
                    Total_member_find();
                }

            }
            catch
            {
            }
        }

        private void txt_female_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txt_female.Text == "")
                {
                    txt_female.Text = "0";
                    Total_member_find();
                }
                if (txt_female.Text != (null) && (int.Parse(txt_female.Text) > 0))
                {
                    Total_member_find();
                }
            }
            catch
            {
            }
        }

        private void txt_resi_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_residence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_residence_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void c_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}
