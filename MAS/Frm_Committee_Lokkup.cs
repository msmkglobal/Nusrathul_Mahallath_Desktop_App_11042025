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
    public partial class Frm_Committee_Lokkup : Form
    {
        Cls_Committee_Master obj_cmty_master;
        //Form Frm_Commitee_Member;
        Form Obj_Pointer;
        string Frm_Name;
        public Frm_Committee_Lokkup(Form Obj_Ptr, string Name)
        {
            Obj_Pointer = Obj_Ptr;
            Frm_Name = Name;
            InitializeComponent();
        }

        private void Frm_Committee_Lokkup_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cmty_master = new Cls_Committee_Master();
                DT = obj_cmty_master.Committee_Master_Select_All();
                cmb_select.DataSource = DT;
                cmb_select.DisplayMember = DT.Columns[0].ToString();
            }
            catch
            {
            }
        }

        private void cmb_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cmty_master = new Cls_Committee_Master();
                obj_cmty_master.Cmty_id = int.Parse(cmb_select.Text);
                DT = obj_cmty_master.Committee_Master_Find_Cmty_Id();
                if (DT.Rows.Count > 0)
                {
                    txt_cmty_id.Text = DT.Rows[0][0].ToString();
                    txt_cmty_year.Text = DT.Rows[0][1].ToString();
                    txt_status.Text = DT.Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Record in the file", "Lookup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                Obj_Pointer.Controls[0].Controls[20].Text = txt_cmty_id.Text;
                Obj_Pointer.Controls[0].Controls[15].Text = txt_cmty_year.Text;
                this.Close();
            }
            catch
            {
            }
                        
        }
    }
}
