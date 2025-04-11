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
    //Aptorasoft
    public partial class Frm_Employee : Form
    {

        //Declaration
        Cls_Employee_Master obj_cls_Employee_master;
        //
        //functions

        public void Clear_controls()
        {
            try
            {
                txt_emp_name.Text = "";
                txt_address.Text = "";
                txt_pin.Text = "";
                dtp_dob.Text = "";
                txt_contact.Text = "";
                pbx_photo.Image = pbx_photo.ErrorImage;
                txt_designation.Text = "";
                txt_salary.Text = "";
                txt_qualification.Text = "";
                cmb_status.Text = "";
                txt_discription.Text = "";
                txt_search.Text = "";
                dgv_employee.DataSource = null;
                
                
            }
            catch { }
        }

       public void Get_id()
        {
            try
            {
                obj_cls_Employee_master = new Cls_Employee_Master();
                txt_emp_id.Text = obj_cls_Employee_master.Employee_Master_Get_Id().ToString();
            }
            catch { }
        }


        private void Controls_Readonly(string mode)
        {
            try
            {
                if (mode == "False")
                {
                    txt_emp_name.Enabled = true;
                    txt_address.Enabled = true;
                    txt_pin.Enabled = true;
                    dtp_dob.Enabled = true;
                    txt_contact.Enabled = true;
                    pbx_photo.Image = pbx_photo.ErrorImage;
                    txt_designation.Enabled = true;
                    txt_salary.Enabled = true;
                    txt_qualification.Enabled = true;
                    cmb_status.Enabled = true;
                    txt_discription.Enabled = true;
                    



                }
                else if (mode == "True")
                {
                    txt_emp_name.Enabled = false;
                    txt_address.Enabled = false;
                    txt_pin.Enabled = false;
                    dtp_dob.Enabled = false;
                    txt_contact.Enabled = false;
                    pbx_photo.Image = pbx_photo.ErrorImage;
                    txt_designation.Enabled = false;
                    txt_salary.Enabled = false;
                    txt_qualification.Enabled = false;
                    cmb_status.Enabled = false;
                    txt_discription.Enabled = false;
                    



                }
            }
            catch { }
        }
        public void Employee_Bind_Controls(string key)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_Employee_master.Emp_id = Convert.ToInt32(key);
                DT = obj_cls_Employee_master.Employee_Master_Select_By_Id();
                if ((DT.Rows.Count > 0))
                {

                    txt_emp_id.Text = DT.Rows[0][0].ToString();
                    txt_emp_name.Text = DT.Rows[0][1].ToString();
                    txt_address.Text = DT.Rows[0][2].ToString();
                    txt_pin.Text = DT.Rows[0][3].ToString();
                    dtp_dob.Text = DT.Rows[0][4].ToString();
                    txt_contact.Text = DT.Rows[0][5].ToString();

                    byte[] Photo = new byte[0];
                    Photo = (byte[])(DT.Rows[0][6]);
                    MemoryStream Photostream = new MemoryStream(Photo);
                    pbx_photo.Image = Image.FromStream(Photostream);

                    txt_designation.Text = DT.Rows[0][7].ToString();
                    txt_salary.Text = DT.Rows[0][8].ToString();
                    txt_qualification.Text = DT.Rows[0][9].ToString();
                    cmb_status.Text = DT.Rows[0][10].ToString();
                    txt_discription.Text = DT.Rows[0][11].ToString();



                }

            }
            catch
            {
            }
        }

        public void Employee_Find_By_Id(string key)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_Employee_master.Emp_id = Convert.ToInt32(key);
                DT = obj_cls_Employee_master.Employee_Master_Select_By_Id();
                if ((DT.Rows.Count > 0) && (txt_search.Text != ""))
                {
                    dgv_employee.DataSource = DT;
                }
                else
                {
                    dgv_employee.DataSource = null;
                }
               
            }
            catch
            {
            }
        }

        public void Employee_Find_By_Keys(string key)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_Employee_master.Keys = key;
                DT = obj_cls_Employee_master.Employee_Master_Select_By_Keys();
                if (DT.Rows.Count > 0)
                {
                    dgv_employee.DataSource = DT;
                }
                else
                {
                    dgv_employee.DataSource = null;
                }
               
            }
            catch
            {
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

        private void No_Special_Char(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || char.IsNumber(pressedKey)||tb.Text!="")
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
        //End of functions
        public Frm_Employee()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Employee [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gbx_employee.Controls.Count; i++)
                    {
                        if ((string)gbx_employee.Controls[i].Tag == "M" && gbx_employee.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Employee [MAS]]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_employee.Controls[i].Focus();
                            return;
                        }
                    }

                    obj_cls_Employee_master = new Cls_Employee_Master();

                    obj_cls_Employee_master.Emp_name = txt_emp_name.Text;
                    obj_cls_Employee_master.Address = txt_address.Text;
                    obj_cls_Employee_master.Pin = Convert.ToInt32(txt_pin.Text);
                    obj_cls_Employee_master.Dob = Convert.ToDateTime(dtp_dob.Text);
                    obj_cls_Employee_master.Contact = txt_contact.Text;
                    obj_cls_Employee_master.Photo = imageToByteArray(pbx_photo.Image);
                    obj_cls_Employee_master.Designation = txt_designation.Text;
                    obj_cls_Employee_master.Salary = Convert.ToDouble(txt_salary.Text);
                    obj_cls_Employee_master.Qualification = txt_qualification.Text;
                    obj_cls_Employee_master.Status = cmb_status.Text;
                    obj_cls_Employee_master.Description = txt_designation.Text;

                    if (obj_cls_Employee_master.Employee_Master_Insert() > 0)
                    {
                        MessageBox.Show("New Employee Saved!", "Employee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Employee_Find_By_Id(txt_emp_id.Text);
                        Clear_controls();
                        // Dgv_Employee_Refresh();
                        Get_id();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not save!", "Employee[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Get_id();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Do you want to clear the data?", "Employee[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == (int)DialogResult.OK)
            {
                Clear_controls();
                Get_id();
                Controls_Readonly("False");
                dgv_employee.Enabled = false;
                dgv_employee.DataSource =null;
            }
            else
            {
                if (dgv_employee.DataSource == null)
                {
                    btn_save.Enabled = true;
                }
                return; 
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
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Employee [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    for (int i = 0; i < gbx_employee.Controls.Count; i++)
                    {
                        if ((string)gbx_employee.Controls[i].Tag == "M" && gbx_employee.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Employee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_employee.Controls[i].Focus();
                            return;
                        }
                    }
                    obj_cls_Employee_master = new Cls_Employee_Master();

                    obj_cls_Employee_master.Emp_id = Convert.ToInt32(txt_emp_id.Text);
                    obj_cls_Employee_master.Emp_name = txt_emp_name.Text;
                    obj_cls_Employee_master.Address = txt_address.Text;
                    obj_cls_Employee_master.Pin = Convert.ToInt32(txt_pin.Text);
                    obj_cls_Employee_master.Dob = Convert.ToDateTime(dtp_dob.Text);
                    obj_cls_Employee_master.Contact = txt_contact.Text;
                    obj_cls_Employee_master.Photo = imageToByteArray(pbx_photo.Image);
                    obj_cls_Employee_master.Designation = txt_designation.Text;
                    obj_cls_Employee_master.Salary = Convert.ToDouble(txt_salary.Text);
                    obj_cls_Employee_master.Qualification = txt_qualification.Text;
                    obj_cls_Employee_master.Status = cmb_status.Text;
                    obj_cls_Employee_master.Description = txt_designation.Text;

                    if (obj_cls_Employee_master.Employee_Master_Update() > 0)
                    {
                        MessageBox.Show("File updated!", "Employee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Employee_Find_By_Id(txt_emp_id.Text);
                        Employee_Bind_Controls(txt_emp_id.Text);
                        Employee_Find_By_Id(txt_emp_id.Text);
                        Controls_Readonly("True");
                        Get_id();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Updation failed!", "Employee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_controls();
                Get_id();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = ((int)MessageBox.Show("Are you sure you want to permanently delete this file?", "Employee [MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    obj_cls_Employee_master = new Cls_Employee_Master();
                    obj_cls_Employee_master.Emp_id = Convert.ToInt32(txt_emp_id.Text);

                    if (obj_cls_Employee_master.Employee_Master_Delete() > 0)
                    {
                        MessageBox.Show("File deleted!", "Employee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_controls();
                        Controls_Readonly("True");
                        Get_id();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not delete the file!", "Employee [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_search.Text!="")
                {
                    btn_save.Enabled = false;
                    if (rdb_byid.Checked == true)
                    {
                        Employee_Find_By_Id(txt_search.Text);
                    }
                    else
                    {
                        Employee_Find_By_Keys(txt_search.Text);
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

        

        private void lbl_brows_Click(object sender, EventArgs e)
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

        private void lbl_brows_MouseEnter(object sender, EventArgs e)
        {
            lbl_brows.ForeColor = Color.Red;
        }

        private void lbl_brows_MouseLeave(object sender, EventArgs e)
        {
            lbl_brows.ForeColor = Color.Black;
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            pbx_photo.Image = BackgroundImage;
        }

        private void lbl_clear_MouseLeave(object sender, EventArgs e)
        {
            lbl_clear.ForeColor = Color.Black;
        }

        private void lbl_clear_MouseEnter(object sender, EventArgs e)
        {
            lbl_clear.ForeColor = Color.Red;
        }

        

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();
            TextBox T = (TextBox)sender;
            T.Text = T.Text.Trim();
            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);
                    if (T.Text.Contains(','))
                        throw X;
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

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            try
            {
                Clear_controls();                
                Get_id();
                dgv_employee.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
            }
            catch
            {
            }
        }

        private void cmb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_discription.Focus();
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {

          
        }

        private void txt_emp_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_emp_name.Focus();  
            }
        }

        private void txt_emp_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            No_Special_Char(sender, e);
            if (e.KeyChar == 13)
            {
                txt_address.Focus();
            }
        }
                
        private void txt_pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == 13)
            {
                dtp_dob.Focus();
            }
        }

        private void dtp_dob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_contact.Focus();
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_designation.Focus();
            }
        }

        private void txt_designation_KeyPress(object sender, KeyPressEventArgs e)
        {
            No_Special_Char(sender, e);
            if (e.KeyChar == 13)
            {
                txt_salary.Focus();
            }
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_qualification.Focus();
            }
        }

        private void txt_qualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_status.Focus();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != "")
                {
                    btn_save.Enabled = false;
                    if (rdb_byid.Checked == true)
                    {
                        Employee_Find_By_Id(txt_search.Text);
                    }
                    else
                    {
                        Employee_Find_By_Keys(txt_search.Text);
                    }
                    dgv_employee.Enabled = true;
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

        private void rdb_byid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_employee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btn_save.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                int rowIndex = dgv_employee.CurrentCell.RowIndex;
                Employee_Bind_Controls(dgv_employee.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Controls_Readonly("True");
            }
            catch
            {
            }
        }

        private void dgv_employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_employee.CurrentCell.RowIndex;
                Employee_Bind_Controls(dgv_employee.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Controls_Readonly("False");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            catch
            {
            }
        }

        private void lbl_photo_Click(object sender, EventArgs e)
        {

        }

        private void btn_cpanel_Click(object sender, EventArgs e)
        {

        }
    }
}
