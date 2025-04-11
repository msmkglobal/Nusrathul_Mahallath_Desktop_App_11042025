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
    public partial class Frm_Education : Form
    {
        Cls_Education Obj_Cls_Education;
        public Frm_Education()
        {
            InitializeComponent();
        }

        private void Frm_Education_Load(object sender, EventArgs e)
        {
            try
            {
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                dgv_education.Enabled = false;
            }
            catch
            {
            }
        }
        public void Clear_Controls_Education()
        {
            try
            {

                //txt_Cmnt_Id.Text = "";
                txt_Qualification.Text = "";
                txt_Subject.Text = "";
                txt_Stream.Text = "";
                txt_Issuing_Authority.Text = "";
                txt_Percentage.Text = "";
                txt_Grade.Text = "";
                txt_Passing_Year.Text = "";
                txt_Reg_No.Text = "";
                txt_Remarks.Text = "";
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
                    //txt_Cmnt_Id.Enabled = true;
                    txt_Qualification.Enabled = true;
                    txt_Subject.Enabled = true;
                    txt_Stream.Enabled = true;
                    txt_Issuing_Authority.Enabled = true;
                    txt_Percentage.Enabled = true;
                    txt_Grade.Enabled = true;
                    txt_Passing_Year.Enabled = true;
                    txt_Reg_No.Enabled = true;
                    txt_Remarks.Enabled = true;
                    cmb_status.Enabled = true;


                }
                else if (mode == "False")
                {
                   // txt_Cmnt_Id.Enabled = false;
                    txt_Qualification.Enabled = false;
                    txt_Subject.Enabled = false;
                    txt_Stream.Enabled = false;
                    txt_Issuing_Authority.Enabled = false;
                    txt_Percentage.Enabled = false;
                    txt_Grade.Enabled = false;
                    txt_Passing_Year.Enabled = false;
                    txt_Reg_No.Enabled = false;
                    txt_Remarks.Enabled = false;
                    cmb_status.Enabled = false;
                }
            }
            catch { }
        }

        private void Education_Bind_Controls(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                Obj_Cls_Education = new Cls_Education();
                if (Keys != "")
                {
                    Controls_Readonly("False");
                    Obj_Cls_Education.Key = Keys;
                    DT = Obj_Cls_Education.Education_Find_By_PK();
                    dgv_education.DataSource = DT;

                    //txt_edu_id.Text = DT.Rows[0][0].ToString();
                        txt_Cmnt_Id.Text = DT.Rows[0][1].ToString();
                        txt_Qualification.Text = DT.Rows[0][2].ToString();
                        txt_Subject.Text = DT.Rows[0][3].ToString();
                        txt_Stream.Text = DT.Rows[0][4].ToString();
                        txt_Issuing_Authority.Text = DT.Rows[0][5].ToString();
                        txt_Percentage.Text = DT.Rows[0][6].ToString();
                        txt_Grade.Text = DT.Rows[0][7].ToString();
                        txt_Passing_Year.Text = DT.Rows[0][8].ToString();
                        txt_Reg_No.Text = DT.Rows[0][9].ToString();
                        txt_Remarks.Text = DT.Rows[0][10].ToString();

                }
                else
                {
                    Clear_Controls_Education();
                    btn_save.Enabled = true;
                    Controls_Readonly("True");
                    txt_search.Focus();
                }
            }
            catch { }
        }       
        public void Search_By_key_Education(string key)
        {
            try
            {
                dgv_education.DataSource = null;
                DataTable DT = new DataTable();
                Obj_Cls_Education = new Cls_Education();
                Obj_Cls_Education.Key = key;
                DT = Obj_Cls_Education.Education_Find_By_Key();
                if (DT.Rows.Count > 0 && txt_Cmnt_Id.Text != "")
                {
                    dgv_education.DataSource = DT;

                }
                if (DT.Rows.Count > 0&& txt_search.Text!="")
                {
                    dgv_education.DataSource = DT;

                }

                else
                {
                    Clear_Controls_Education();
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
                int result = (int)MessageBox.Show("Do you want to clear the data?", "Education[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    txt_search.Text = "";
                    dgv_education.Enabled = false;
                    Clear_Controls_Education();
                    Controls_Readonly("True");
                    dgv_education.DataSource = null;
                    btn_save.Enabled = true;
                    btn_edit.Enabled = false;
                    btn_delete.Enabled = false;
                    txt_Cmnt_Id.Text = "";
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Education[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gpbx_education.Controls.Count; i++)
                    {
                        if ((string)gpbx_education.Controls[i].Tag == "M" && gpbx_education.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Education[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gpbx_education.Controls[i].Focus();
                            return;
                        }
                    }
                    Obj_Cls_Education = new Cls_Education();
                    Obj_Cls_Education.Edu_Id = 0;
                    Obj_Cls_Education.Cmnt_Id = txt_Cmnt_Id.Text;
                    Obj_Cls_Education.Qualification = txt_Qualification.Text;
                    Obj_Cls_Education.Subject = txt_Subject.Text;
                    Obj_Cls_Education.Stream = txt_Stream.Text;
                    Obj_Cls_Education.Issuing_Authority = txt_Issuing_Authority.Text;
                    Obj_Cls_Education.Percentage = int.Parse(txt_Percentage.Text);
                    Obj_Cls_Education.Grade = txt_Grade.Text;
                    Obj_Cls_Education.Passing_Year = int.Parse(txt_Passing_Year.Text);
                    Obj_Cls_Education.Reg_No = txt_Reg_No.Text;
                    Obj_Cls_Education.Remarks = txt_Remarks.Text;
                    Obj_Cls_Education.Created = System.DateTime.Now.ToString();
                    Obj_Cls_Education.Modified = System.DateTime.Now.ToString();
                    Obj_Cls_Education.Status = cmb_status.Text;
                }
                if (Obj_Cls_Education.Education_Save() > 0)
                {
                    MessageBox.Show("Educational Detailes Saved!", "Education[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls_Education();
                    dgv_education.Enabled = true;
                    Search_By_key_Education(txt_Cmnt_Id.Text);
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

                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Education[MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    for (int i = 0; i < gpbx_education .Controls.Count; i++)
                    {
                        if ((string)gpbx_education .Controls[i].Tag == "M" && gpbx_education .Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Education[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gpbx_education .Controls[i].Focus();
                            return;
                        }
                    }
                    Obj_Cls_Education = new Cls_Education();
                   int rowIndex = dgv_education.CurrentCell.RowIndex;
                   Obj_Cls_Education.Edu_Id = Convert.ToInt32(dgv_education.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                   Obj_Cls_Education.Cmnt_Id = txt_Cmnt_Id.Text;
                   Obj_Cls_Education.Qualification = txt_Qualification.Text;
                   Obj_Cls_Education.Subject = txt_Subject.Text;
                   Obj_Cls_Education.Stream = txt_Stream.Text;
                   Obj_Cls_Education.Issuing_Authority = txt_Issuing_Authority.Text;
                   Obj_Cls_Education.Percentage = Convert.ToInt32(txt_Percentage.Text);
                   Obj_Cls_Education.Grade = txt_Grade.Text;
                   Obj_Cls_Education.Passing_Year = Convert.ToInt32(txt_Passing_Year.Text);
                   Obj_Cls_Education.Reg_No = txt_Reg_No.Text;
                   Obj_Cls_Education.Remarks = txt_Remarks.Text;
                   Obj_Cls_Education.Created = System.DateTime.Now.ToString();
                   Obj_Cls_Education.Modified = System.DateTime.Now.ToString();
                   Obj_Cls_Education.Status = cmb_status.Text;
                }
                else
                {
                    return;
                }
                    if (Obj_Cls_Education .Education_Master_Update() > 0)
                    {
                        MessageBox.Show("File Updated!", "Education[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Search_By_key_Education(txt_Cmnt_Id.Text);
                        Controls_Readonly("False");
                        dgv_education .Enabled = true;
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

                int result = ((int)MessageBox.Show("Are you sure you want to delete ", "Education[MAS]", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    Obj_Cls_Education = new Cls_Education();
                    int rowIndex = dgv_education.CurrentCell.RowIndex;
                    Obj_Cls_Education.Edu_Id = int.Parse(dgv_education.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                    if (Obj_Cls_Education.Education_Delete() > 0)
                    {
                        MessageBox.Show("File Deleted!", "Education[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Search_By_key_Education(txt_Cmnt_Id.Text);
                        Controls_Readonly("False");
                        dgv_education.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("File Could not Delete!", "Education[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
            }

        }

        private void dgv_education_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btn_save.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                int rowIndex = dgv_education.CurrentCell.RowIndex;
                Education_Bind_Controls(dgv_education.Rows[rowIndex].Cells[0].FormattedValue.ToString());
            }
            catch { }
        }

        private void dgv_education_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_education.CurrentCell.RowIndex;
                Education_Bind_Controls(dgv_education .Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Search_By_key_Education(txt_Cmnt_Id.Text);
                Controls_Readonly("True");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
                
            }
            catch { }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_By_key_Education(txt_search.Text);
                dgv_education.Enabled = true;
            }
            catch
            {
            }
        }

        private void txt_Passing_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Reg_No.Focus();
                }
            }
            catch
            {
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Percentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Grade.Focus();
                }
            }
            catch
            {
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Qualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Subject.Focus();
                }
            }
            catch
            {
            }

        }

        private void txt_Subject_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Stream.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_Stream_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Issuing_Authority.Focus();
                }
            }
            catch
            {
            }

        }

        private void txt_Issuing_Authority_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Percentage.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_Grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Passing_Year.Focus();
                }
            }
            catch
            {
            }

        }

        private void txt_Reg_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Remarks.Focus();
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
                    e.KeyChar = (char)Keys.None;
            }
            catch
            {
            }
        }

        private void txt_Qualification_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txt_Subject.Focus();
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

        private void btn_pick_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_community_lookup Obj_Frm_Cmnt_Lookup = new Frm_community_lookup(this, "Frm_Education");
                Obj_Frm_Cmnt_Lookup.ShowDialog();
            }
            catch { }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        

              
        }        
}
