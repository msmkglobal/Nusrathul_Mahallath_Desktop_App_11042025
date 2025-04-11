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
    public partial class Frm_community_lookup : Form
    {

        Cls_Community_Master Obj_Cls_cmnty;

        Form Obj_Pointer;
        string Frm_Name;

        public Frm_community_lookup(Form Obj_Ptr,string Name)
        {
            Obj_Pointer = Obj_Ptr;
            Frm_Name = Name;
            InitializeComponent();
        }
        private void Cmnty_lookup_Search(string key)
        {
            try
            {
                dgv_cmnty_lookup.DataSource = null;
                DataTable DT = new DataTable();
                Obj_Cls_cmnty = new Cls_Community_Master();
                Obj_Cls_cmnty.Keys = key;
                DT = Obj_Cls_cmnty.Education_Find_By_Key_lookup();
                if (DT.Rows.Count > 0 && txt_search_cmnty.Text != "")
                {
                   
                    DT.Columns.RemoveAt(4);
                    DT.Columns.RemoveAt(4);
                    
                    dgv_cmnty_lookup.DataSource = DT;

                }
            }
            catch
            {
            }
        }
        private void Cmnty_Lookup_Bind_controls(string key)
        {
            try
            {
                DataTable DT = new DataTable();
                Obj_Cls_cmnty = new Cls_Community_Master();
                Obj_Cls_cmnty.Keys = key;
                DT = Obj_Cls_cmnty.Education_Find_By_Key_lookup();
                if (DT.Rows.Count > 0 && txt_search_cmnty.Text != "")
                {

                    txt_cmntid.Text = DT.Rows[0][0].ToString();
                    txt_name.Text = DT.Rows[0][1].ToString();
                    txt_dob.Text = DT.Rows[0][2].ToString();
                    txt_adress.Text = DT.Rows[0][3].ToString();
                    txt_mob.Text = DT.Rows[0][4].ToString();
                    byte[] Photo = new byte[0];
                    Photo = (byte[])(DT.Rows[0][5]);
                    MemoryStream Photostream = new MemoryStream(Photo);
                    pbx_image.BackgroundImage= Image.FromStream(Photostream);

                }
            }
            catch
            {
            }
        }

        private void txt_search_cmnty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cmnty_lookup_Search(txt_search_cmnty.Text);
            }
            catch
            {
            }

        }

        private void dgv_cmnty_lookup_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int Rowindex = dgv_cmnty_lookup.CurrentCell.RowIndex;
                Cmnty_Lookup_Bind_controls(dgv_cmnty_lookup.Rows[Rowindex].Cells[0].FormattedValue.ToString());
            }
            catch
            {
            }
        }

        private void Frm_community_lookup_Load(object sender, EventArgs e)
        {

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Frm_Name)
                {
                    case "Frm_Education":
                        {
                            Obj_Pointer.Controls[0].Controls[5].Text = txt_cmntid.Text;
                            this.Close();
                        }
                        break;
                    case "Frm_Commitee_Member":
                        {
                            Obj_Pointer.Controls[0].Controls[6].Text = txt_cmntid.Text;
                            Obj_Pointer.Controls[0].Controls[4].Text = txt_cmntid.Text;
                            this.Close();
                        }
                        break;
                    case "Frm_Job":
                        {
                            Obj_Pointer.Controls[1].Controls[24].Text = txt_cmntid.Text;
                           
                            this.Close();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
