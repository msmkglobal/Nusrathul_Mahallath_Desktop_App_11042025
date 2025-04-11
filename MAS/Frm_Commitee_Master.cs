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
    public partial class Frm_Commitee_Master : Form
    {
        Cls_Committee_Master obj_cmty_master;
        public Frm_Commitee_Master()
        {
            InitializeComponent();
        }
        private void validateTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();
            TextBox T = (TextBox)sender;
            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);                    
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        public void Clear_Controls()
        {
            try
            {
                txt_cmty_id.Text = "";
                txt_cmty_year.Text = "";
                txt_doe.Text = "";
                txt_dos.Text = "";
                txt_message.Text = "";
                txt_note.Text = "";
                txt_strength.Text = "";
                cmb_status.SelectedIndex = 0;
                
                
            }
            catch { }
        }

        private void Controls_Readonly(string mode)
        {
            try
            {
                if (mode == "False")
                {

                    txt_cmty_year.Enabled = true;
                    txt_doe.Enabled = true;
                    txt_dos.Enabled = true;
                    txt_message.Enabled = true;
                    txt_note.Enabled = true;
                    txt_strength.Enabled = true;
                    cmb_status.Enabled = true;







                }
                else if (mode == "True")
                {

                    txt_cmty_year.Enabled = false;
                    txt_doe.Enabled = false;
                    txt_dos.Enabled = false;
                    txt_message.Enabled = false;
                    txt_note.Enabled = false;
                    txt_strength.Enabled = false;
                    cmb_status.Enabled = false;
                }
            }
            catch
            {
            }
            }
            
        public void Committee_Dgv_Fill()
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cmty_master = new Cls_Committee_Master();
                DT = obj_cmty_master.Committee_Master_Select_All();
                dgv_commitee.DataSource = DT;              
               
            }
            catch
            {
            }
        }
        public void Committee_Master_Get_Id()
        {
            try
            {
                obj_cmty_master = new Cls_Committee_Master();
                int Cmty_Id = obj_cmty_master.Committee_Master_Get_Id();
                txt_cmty_id.Text = Cmty_Id.ToString();
            }
            catch
            {
               
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Commitee_Master_Load(object sender, EventArgs e)
        {
            try
            {

                dgv_commitee.Enabled = false;
                Clear_Controls();
                Committee_Master_Get_Id();
                //ts_date.Text = DateTime.Now.ToShortDateString();
                Committee_Dgv_Fill();
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                
            }
            catch { }
        }

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void btn_edit_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void btn_edit_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btn_update_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn_update_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btn_delete_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Committee [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    obj_cmty_master = new Cls_Committee_Master();
                    obj_cmty_master.Cmty_id = int.Parse(txt_cmty_id.Text);
                    obj_cmty_master.Cmty_year = txt_cmty_year.Text;
                    obj_cmty_master.Strength = int.Parse(txt_strength.Text);
                    obj_cmty_master.Dos = txt_dos.Text;
                    obj_cmty_master.Doe = txt_doe.Text;
                    obj_cmty_master.Message = txt_message.Text;
                    obj_cmty_master.L_update = DateTime.Now.Date;
                    obj_cmty_master.Status = cmb_status.Text;
                    obj_cmty_master.Note = txt_note.Text;
                    if (obj_cmty_master.Committee_Master_Update() > 0)
                    {
                        MessageBox.Show("File Updated!", "Committee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_Controls();
                        Committee_Dgv_Fill();
                        Controls_Readonly("True");

                    }
                }

            }
            catch (Exception )
            {
            }
        }

        private void btn_search_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn_search_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_new_MouseEnter(object sender, EventArgs e)
        {
                     
        }

        private void btn_new_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txt_cmty_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if(e.KeyChar==13)
            {
                txt_strength.Focus();                
            }
        }

        private void txt_strength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_dos.Focus();
            }
        }

        private void txt_Dos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                if (e.KeyChar == 13)
                {
                    txt_doe.Focus();
                }
            }
            catch
            {
            }

        }

        private void txt_doe_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                if (e.KeyChar == 13)
                {
                    cmb_status.Focus();
                }
                else
                {

                }
            }
            catch
            {
            }
        }

        private void cmb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == 13)
                {
                    txt_message.Focus();
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

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Do you want to clear the data?", "Committee [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                 if (result == (int)DialogResult.OK)
                 {
                     btn_save.Enabled = true;
                     Clear_Controls();
                     txt_search.Text = "";
                     Committee_Dgv_Fill();
                     Committee_Master_Get_Id();
                     txt_cmty_year.Focus();
                     Controls_Readonly("False");
                     dgv_commitee.DataSource = null;
                     dgv_commitee.Enabled = false;
                 }
                 if (dgv_commitee.DataSource == null)
                 {
                     btn_save.Enabled = true;
                 }
            }
            catch
            { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Committee [MAS]]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gbx_commitee.Controls.Count; i++)
                    {
                        if ((string)gbx_commitee.Controls[i].Tag == "M" && gbx_commitee.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Committee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_commitee.Controls[i].Focus();
                            return;
                        }
                    }
                    obj_cmty_master = new Cls_Committee_Master();
                    obj_cmty_master.Cmty_year = txt_cmty_year.Text;
                    obj_cmty_master.Strength = int.Parse(txt_strength.Text);
                    obj_cmty_master.Dos = txt_dos.Text;
                    obj_cmty_master.Doe = txt_doe.Text;
                    obj_cmty_master.Message = txt_message.Text;
                    obj_cmty_master.L_update = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    obj_cmty_master.Status = cmb_status.Text;
                    obj_cmty_master.Note = txt_note.Text;
                }
                else
                {
                    return;
                }
                if (obj_cmty_master.Committee_Master_Save() > 0)
                {
                    MessageBox.Show("New Committee Saved!", "Committee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls();
                    Committee_Dgv_Fill();
                    Committee_Master_Get_Id();
                    txt_cmty_year.Focus();
                }

            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message.ToString(), "Committee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_strength_TextChanged(object sender, EventArgs e)
        {           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Online Updation not possible! Must Configure Database Server", "Committee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    obj_cmty_master = new Cls_Committee_Master();
                    obj_cmty_master.Cmty_id = int.Parse(txt_cmty_id.Text);

                    if (obj_cmty_master.Committee_Master_Delete() > 0)
                    {
                        MessageBox.Show("File Deleted!", "Committee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_Controls();
                        Committee_Dgv_Fill();
                        txt_search.Focus();
                        Controls_Readonly("True");

                    }
                }

            }
            catch 
            {
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_commitee.Enabled = true;
                txt_search.Text = "";
                Clear_Controls();
                Committee_Dgv_Fill();
                Committee_Master_Get_Id();
                txt_cmty_year.Focus();
                Controls_Readonly("True");
            }
            catch
            {
            }
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
        //                Committee_Find_Cmty_Id();
        //            }
        //            else
        //            {
        //                Committee_Find_Cmty_Year();
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_commitee.Enabled = true;
                if (txt_search.Text != "")
                {
                    btn_save.Enabled = false;
                    if (rdb_by_id.Checked == true)
                    {
                        Committee_Find_Cmty_Id_search(txt_search.Text);
                    }
                    else
                    {
                        Committee_Find_Cmty_Year();
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

        public void Committee_Find_Cmty_Id(string key)
        {
            DataTable DT = new DataTable();
            try
            {
                //dgv_commitee.DataSource = null;
                Clear_Controls();
                obj_cmty_master = new Cls_Committee_Master();
                obj_cmty_master.Cmty_id = int.Parse(key);
                DT = obj_cmty_master.Committee_Master_Find_Cmty_Id();
                if (DT.Rows.Count > 0)
                {                    
                   // dgv_commitee.DataSource = DT;
                    txt_cmty_id.Text = DT.Rows[0][0].ToString();
                    txt_cmty_year.Text = DT.Rows[0][1].ToString();
                    txt_strength.Text = DT.Rows[0][2].ToString();
                    txt_dos.Text = DT.Rows[0][3].ToString();
                    txt_doe.Text = DT.Rows[0][4].ToString();
                    txt_message.Text = DT.Rows[0][5].ToString();
                    cmb_status.Text = DT.Rows[0][7].ToString();
                    txt_note.Text = DT.Rows[0][8].ToString();

                }
            }
            catch
            {                
            }
        }
        public void Committee_Find_Cmty_Id_search(string key)
        {
            DataTable DT = new DataTable();
            try
            {
                dgv_commitee.DataSource = null;
                Clear_Controls();
                obj_cmty_master = new Cls_Committee_Master();
                obj_cmty_master.Cmty_id = int.Parse(key);
                DT = obj_cmty_master.Committee_Master_Find_Cmty_Id();
                if (DT.Rows.Count > 0)
                {
                    dgv_commitee.DataSource = DT;
                }
            }
            catch
            {
            }
        }
        public void Committee_Find_Cmty_Year()
        {
            DataTable DT = new DataTable();
            try
            {
                dgv_commitee.DataSource = null;
                Clear_Controls();
                obj_cmty_master = new Cls_Committee_Master();
                obj_cmty_master.Cmty_year = txt_search.Text;
                DT = obj_cmty_master.Committee_Master_Find_Cmty_Year();
                if (DT.Rows.Count > 0)
                {
                    dgv_commitee.DataSource = DT;
                    

                }
            }
            catch
            {
            }
        }

        private void txt_cmty_year_search_TextChanged(object sender, EventArgs e)
        {           
        }

        private void rdb_by_id_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Focus();
        }

        private void rdb_by_word_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Focus();
        }

        private void btn_cpanel_Click(object sender, EventArgs e)
        {

        }

        private void dgv_commitee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btn_save.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                int rowIndex = dgv_commitee.CurrentCell.RowIndex;
                Committee_Find_Cmty_Id(dgv_commitee.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Controls_Readonly("True");
            }
            catch
            {
            }
        }

        private void dgv_commitee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_commitee.CurrentCell.RowIndex;
                Committee_Find_Cmty_Id(dgv_commitee.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Controls_Readonly("False");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            catch
            {
            }
        }

        
    }
}
