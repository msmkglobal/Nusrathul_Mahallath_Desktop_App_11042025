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
    public partial class Frm_Commitee_Member : Form
    {
        Cls_Committee_Member obj_cmty_member;
        //Frm_Committee_Lokkup obj_Frm_commity_lookup;
        
               

        public Frm_Commitee_Member()
        {
            InitializeComponent();
            Committee_Member_Get_Id();
        }
        //function

        public void Clear_Controls()
        {
            try
            {
                txt_mem_id.Text = "";
                txt_cmty_id.Text = "";
                txt_cmty_year.Text = "";
                txt_cmnt_id.Text = "";
                txt_name.Text = "";
                cmb_designation.Text = "Choose";
                txt_contact.Text = "";
                cmb_status.Text = "Choose";
                txt_description.Text = "";
                Committee_Member_Get_Id();
                
                //pbx_photo.Image = pbx_photo.ErrorImage;
                //pbx_sign.Image = pbx_sign.ErrorImage;
            }
            catch
            {
            }
        }
        public void Committee_Member_Get_Id()
        {
            try
            {
                obj_cmty_member = new Cls_Committee_Member();
                int Cmty_Id = obj_cmty_member.Committee_Member_Get_Id();
                txt_mem_id.Text = Cmty_Id.ToString();
            }
            catch
            {

            }

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)//img to byte
        {            
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
           
        }

        private void Controls_Readonly(string mode)
        {
            try
            {
                if (mode == "False")
                {
                    
                    cmb_designation.Enabled = true;
                    txt_contact.Enabled = true;
                    cmb_status.Enabled = true;
                    txt_description.Enabled = true;






                }
                else if (mode == "True")
                {
                    
                    cmb_designation.Enabled = false;
                    txt_contact.Enabled = false;
                    cmb_status.Enabled = false;
                    txt_description.Enabled = false;






                }
            }
            catch { }
        }
        public void Cmty_Member_Fillgrid()
        {
            DataTable DT = new DataTable();
            obj_cmty_member = new Cls_Committee_Member();
            try
            {
                obj_cmty_member.Mem_id = Convert.ToInt32(txt_search.Text);
                DT = obj_cmty_member.Committee_Member_Find_By_Id();
                if (DT.Rows.Count > 0)
                {
                    dgv_cmty_member.DataSource = DT;

                    txt_mem_id.Text = DT.Rows[0][0].ToString();
                    txt_cmty_id.Text = DT.Rows[0][1].ToString();
                    txt_cmty_year.Text = DT.Rows[0][2].ToString();
                    txt_cmnt_id.Text = DT.Rows[0][3].ToString();
                    txt_name.Text = DT.Rows[0][4].ToString();
                    cmb_designation.Text = DT.Rows[0][5].ToString();
                    txt_contact.Text = DT.Rows[0][6].ToString();

                    byte[] Photo = new byte[0];
                    Photo = (byte[])(DT.Rows[0][7]);
                    MemoryStream Photostream = new MemoryStream(Photo);
                    pbx_photo.Image = Image.FromStream(Photostream);

                    byte[] Sign = new byte[0];
                    Sign = (byte[])(DT.Rows[0][8]);
                    MemoryStream Signstream = new MemoryStream(Sign);
                    pbx_sign.Image = Image.FromStream(Signstream);

                    cmb_status.Text = DT.Rows[0][9].ToString();
                    txt_description.Text = DT.Rows[0][10].ToString();
                }
                dgv_cmty_member.DataSource = DT;
                
            }
            catch
            {
            }
            
        }

        public void Committee_Member_Select_By_Mem_Id(string key)
        {
            
            try
            {
                DataTable DT = new DataTable();
                
                obj_cmty_member = new Cls_Committee_Member();

                obj_cmty_member.Mem_id = int.Parse(key);
                DT = obj_cmty_member.Committee_Member_Find_By_Id();
                if (DT.Rows.Count > 0)
                {
                   // dgv_cmty_member.DataSource = DT;

                    txt_mem_id.Text = DT.Rows[0][0].ToString();
                    txt_cmty_id.Text = DT.Rows[0][1].ToString();
                    txt_cmty_year.Text = DT.Rows[0][2].ToString();
                    txt_cmnt_id.Text = DT.Rows[0][3].ToString();
                    txt_name.Text = DT.Rows[0][4].ToString();
                    cmb_designation.Text = DT.Rows[0][5].ToString();
                    txt_contact.Text = DT.Rows[0][6].ToString();

                    byte[] Photo = new byte[0];
                    Photo = (byte[])(DT.Rows[0][7]);
                    MemoryStream Photostream = new MemoryStream(Photo);
                    pbx_photo.Image = Image.FromStream(Photostream);

                    byte[] Sign = new byte[0];
                    Sign = (byte[])(DT.Rows[0][8]);
                    MemoryStream Signstream = new MemoryStream(Sign);
                    pbx_sign.Image = Image.FromStream(Signstream);

                    cmb_status.Text = DT.Rows[0][9].ToString();
                    txt_description.Text = DT.Rows[0][10].ToString();
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void Committee_Member_Select_By_Keys(string keys)
        {
            try
            {
                DataTable DT = new DataTable();
                dgv_cmty_member.DataSource = null;
                obj_cmty_member = new Cls_Committee_Member();
                obj_cmty_member.Keys = keys;
                DT = obj_cmty_member.Committee_Member_Find_By_Keys();
                if (DT.Rows.Count > 0)
                {
                    dgv_cmty_member.DataSource = DT;
                    
                }
            }
            catch
            {
            }
        }

        public void Committee_Member_Select_All()
        {
            try
            {
                DataTable DT = new DataTable();
                dgv_cmty_member.DataSource = null;
                obj_cmty_member = new Cls_Committee_Member();
                DT = obj_cmty_member.Committee_Member_Select_All();
                if (DT.Rows.Count > 0)
                {
                    dgv_cmty_member.DataSource = DT;
                }
            }
            catch
            {
            }
        }

        //End Function


        private void Frm_Commitee_Member_Load(object sender, EventArgs e)
        {
            dgv_cmty_member.Enabled = false;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            Committee_Member_Select_All();

        }




        private void lbl_brows_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Committee_Lokkup obj_Frm_commity_lookup = new Frm_Committee_Lokkup(this, "Frm_Commmitee_Member");
                obj_Frm_commity_lookup.ShowDialog();                
            }
            catch
            {
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {                
                obj_cmty_member = new Cls_Committee_Member();              
                obj_cmty_member.Cmty_id = Convert.ToInt32(txt_cmty_id.Text);
                obj_cmty_member.Cmty_year = txt_cmty_year.Text;
                obj_cmty_member.Cmnty_id = Convert.ToInt32(txt_cmnt_id.Text);
                obj_cmty_member.Name = txt_name.Text;
                obj_cmty_member.Designation = cmb_designation.Text;
                obj_cmty_member.Contact_num = txt_contact.Text;
                obj_cmty_member.Photo = imageToByteArray(pbx_photo.Image);
                obj_cmty_member.Signature = imageToByteArray(pbx_sign.Image);
                obj_cmty_member.Status = cmb_status.Text;
                obj_cmty_member.Description = txt_description.Text;
                if(obj_cmty_member.Committee_Member_Save()>0)
                {
                    MessageBox.Show("New Member Saved!", "Committee Member []", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Committee_Member_Select_All();
                    Clear_Controls();
                    
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString(), "Member []", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        

        private void txt_stat_TextChanged(object sender, EventArgs e)
        {

        }

       

       

        

        private void lbl_sign_cancel_Click(object sender, EventArgs e)
        {
            pbx_sign.Image = null;
        }

        private void lbl_photo_cancel_Click(object sender, EventArgs e)
        {
            pbx_photo.Image = pbx_photo.ErrorImage;
        }

        private void lbl_photo_open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPEG Image(*jpeg)|*.jpg|Bitmap(*bmp)|*.bmp";
                open.Multiselect = false;
                if (open.ShowDialog(this) != DialogResult.Cancel)
                {
                    pbx_photo.Image = Image.FromFile(open.FileName);
                }
            }
            catch
            {
            }
        }

        private void lbl_sign_open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPEG Image(*jpeg)|*.jpg|Bitmap(*bmp)|*.bmp";
                open.Multiselect = false;
                if (open.ShowDialog(this) != DialogResult.Cancel)
                {
                    pbx_sign.Image = Image.FromFile(open.FileName);                    
                }
            }
            catch
            {
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {                
                if(txt_search.Text != "")
                {
                    btn_save.Enabled = false;
                    
                    if (rdb_by_id.Checked == true)
                    {
                        Clear_Controls();
                        Committee_Member_Select_By_Keys(txt_search.Text);
                    }
                    else
                    {
                        Clear_Controls();
                        Committee_Member_Select_By_Keys(txt_search.Text);
                    }
                    
                }
                else
                {
                    btn_save.Enabled = true;

                }               
            }
            catch
            {
            }

        }     
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //Committee_Member_Select_All();
            //Clear_Controls();
            
            //MessageBox.Show(this.Controls[0].Controls[3].Name.ToString());
            
        }

        //private void btn_search_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txt_search.Text != "")
        //        {
        //            btn_save.Enabled = false;
        //            if (rdb_by_id.Checked == true)
        //            {
        //                Committee_Member_Select_By_Mem_Id();
        //            }
        //            else
        //            {
        //                Committee_Member_Select_By_Keys();
        //            }

        //        }
        //        else
        //        {
        //            btn_save.Enabled = true;

        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        private void lbl_photo_open_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                lbl_photo_open.ForeColor = Color.Red;
            }
            catch
            {
            }
        }

        private void lbl_photo_open_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                lbl_photo_open.ForeColor = Color.Black;
            }
            catch
            {
            }
        }

        private void lbl_photo_cancel_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                lbl_photo_cancel.ForeColor = Color.Red;
            }
            catch
            {
            }
        }

        private void lbl_photo_cancel_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                lbl_photo_cancel.ForeColor = Color.Black;
            }
            catch
            {
            }
        }

        private void lbl_photo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sign_open_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                lbl_sign_open.ForeColor = Color.Red;
            }
            catch
            {
            }
        }

        private void lbl_sign_open_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                lbl_sign_open.ForeColor = Color.Black;
            }
            catch
            {
            }
        }

        private void lbl_sign_cancel_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                lbl_sign_cancel.ForeColor = Color.Red;
            }
            catch
            {
            }
        }

        private void lbl_sign_cancel_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                lbl_sign_cancel.ForeColor = Color.Black;
            }
            catch
            {
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permanently delete this file?", "Committee [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    obj_cmty_member = new Cls_Committee_Member();

                    obj_cmty_member.Mem_id = Convert.ToInt32(txt_mem_id.Text);
                    if (obj_cmty_member.Committee_Member_Delete() > 0)
                    {
                        MessageBox.Show("File Deleted!", "Committee Member []", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Committee_Member_Select_All();
                        Clear_Controls();
                        txt_search.Focus();
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString(), "Member []", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Committee [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    obj_cmty_member = new Cls_Committee_Member();

                    obj_cmty_member.Mem_id = Convert.ToInt32(txt_mem_id.Text);
                    obj_cmty_member.Cmty_id = Convert.ToInt32(txt_cmty_id.Text);
                    obj_cmty_member.Cmty_year = txt_cmty_year.Text;
                    obj_cmty_member.Cmnty_id = Convert.ToInt32(txt_cmnt_id.Text);
                    obj_cmty_member.Name = txt_name.Text;
                    obj_cmty_member.Designation = cmb_designation.Text;
                    obj_cmty_member.Contact_num = txt_contact.Text;
                    obj_cmty_member.Photo = imageToByteArray(pbx_photo.Image);
                    obj_cmty_member.Signature = imageToByteArray(pbx_sign.Image);
                    obj_cmty_member.Status = cmb_status.Text;
                    obj_cmty_member.Description = txt_description.Text;
                    if (obj_cmty_member.Committee_Member_Update()>0)
                    {
                        MessageBox.Show("File Updated!", "Committee Member []", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Committee_Member_Select_All();
                        Clear_Controls();
                        txt_search.Focus();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString(), "Member []", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Do you want to clear the data?", "Employee[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    Clear_Controls();
                    txt_search.Text = "";
                    Controls_Readonly("False");
                    Committee_Member_Select_All();
                }
                else
                {
                    if (dgv_cmty_member.DataSource == null)
                    {
                        btn_save.Enabled = true;
                    }
                }
            }

            catch
            { }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_designation.Focus();
            }

        }

        private void cmb_designation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_status.Focus();
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
                txt_description.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
          
        }

        private void gbx_cmty_lookup_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_cmty_member_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btn_save.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                int rowIndex = dgv_cmty_member.CurrentCell.RowIndex;
                Committee_Member_Select_By_Mem_Id(dgv_cmty_member.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Controls_Readonly("True");
            }
            catch
            {
            }
        }

        private void dgv_cmty_member_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_cmty_member.CurrentCell.RowIndex;
                Committee_Member_Select_By_Mem_Id(dgv_cmty_member.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Controls_Readonly("False");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            catch
            {
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_brows_Click_1(object sender, EventArgs e)
        {
            try
            {
                Frm_Committee_Lokkup obj_Frm_commity_lookup = new Frm_Committee_Lokkup(this, "Frm_Commitee_Member");
                obj_Frm_commity_lookup.ShowDialog();
            }
            catch { }
        }

        private void lbl_browscmnty_id_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_community_lookup Obj_Frm_Cmnt_Lookup = new Frm_community_lookup(this,"Frm_Commitee_Member");
                Obj_Frm_Cmnt_Lookup.ShowDialog();
            }
            catch { }
        }




    }
}
