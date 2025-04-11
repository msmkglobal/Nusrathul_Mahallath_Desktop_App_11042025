using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS
{
    public partial class Frm_Marriage : Form
    {
        Cls_Marriage obj_Cls_Marriage;
        public Frm_Marriage()
        {
            InitializeComponent();
        }

        public void clearcontrols()
        {
            c_groom_cmntid.Text = "";
            c_groom_resdid.Text = "";
            c_groom_name.Text = "";
            c_groom_father.Text = "";
            c_groom_address.Text = "";
            c_groom_pincode.Text = "";
            c_groom_district.Text = "";
            c_groom_state.Text = "";
            c_groom_contactno.Text = "";
            c_groom_mahallu.Text = "";
            c_bride_cmntid.Text = "";
            c_bride_resdid.Text = "";
            c_bride_name.Text = "";
            c_bride_father.Text = "";
            c_bride_address.Text = "";
            c_bride_pincode.Text = "";
            c_bride_district.Text = "";
            c_bride_state.Text = "";
            c_bride_contactno.Text = "";
            c_bride_mahallu.Text = "";
            c_wedding_date.Text = DateTime.Now.ToShortDateString();
            c_isssuing_date.Text = DateTime.Now.ToShortDateString();
            c_witness1.Text = "";
            c_witness1_contact.Text = "";
            c_witness2.Text = "";
            c_witness2_contact.Text = "";
            c_witness3.Text = "";
            c_witness3_contact.Text = "";
            c_wedding_place.Text = "";
            c_marriageid.Text = "";
            dgv_marriage.DataSource = "";
            c_keyword.Text = "";






        }

        private void c_bride_state_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_groom_pincode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearcontrols();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                obj_Cls_Marriage = new Cls_Marriage();
                obj_Cls_Marriage.Groomcmntid = c_groom_cmntid.Text;
                obj_Cls_Marriage.Groomresdid = c_groom_resdid.Text;
                obj_Cls_Marriage.Groomname = c_groom_name.Text;
                obj_Cls_Marriage.Groomfather = c_groom_father.Text;
                obj_Cls_Marriage.Groomaddress = c_groom_address.Text;
                obj_Cls_Marriage.Groompincode = Convert.ToInt32(c_groom_pincode.Text);
                obj_Cls_Marriage.Groomdistrict = c_groom_district.Text;
                obj_Cls_Marriage.Groomstate = c_groom_state.Text;
                obj_Cls_Marriage.Groomcontactno = c_groom_contactno.Text;
                obj_Cls_Marriage.Groommahallu = c_groom_mahallu.Text;
                obj_Cls_Marriage.Bridecmntid = c_bride_cmntid.Text;
                obj_Cls_Marriage.Brideresdid = c_bride_resdid.Text;
                obj_Cls_Marriage.Bridename = c_bride_name.Text;
                obj_Cls_Marriage.Bridefather = c_bride_father.Text;
                obj_Cls_Marriage.Brideaddress = c_bride_address.Text;
                obj_Cls_Marriage.Bridepincode = Convert.ToInt32(c_bride_pincode.Text);
                obj_Cls_Marriage.Bridedistrict = c_bride_district.Text;
                obj_Cls_Marriage.Bridestate = c_bride_state.Text;
                obj_Cls_Marriage.Bridecontactno = c_bride_contactno.Text;
                obj_Cls_Marriage.Bridemahallu = c_bride_mahallu.Text;
                obj_Cls_Marriage.Marriageid = c_marriageid.Text;
                obj_Cls_Marriage.Weddingdate = Convert.ToDateTime(c_wedding_date.Text);
                obj_Cls_Marriage.Issuingdate = Convert.ToDateTime(c_wedding_date.Text);
                obj_Cls_Marriage.Witness1 = c_witness1.Text;
                obj_Cls_Marriage.Witness1contact = c_witness1_contact.Text;
                obj_Cls_Marriage.Witness2 = c_witness2.Text;
                obj_Cls_Marriage.Witness2contact = c_witness2_contact.Text;
                obj_Cls_Marriage.Witness3 = c_witness3.Text;
                obj_Cls_Marriage.Witness3contact = c_witness3_contact.Text;
                obj_Cls_Marriage.Weddingplace = c_wedding_place.Text;
                obj_Cls_Marriage.Created = "";
                obj_Cls_Marriage.Modified = "";
                obj_Cls_Marriage.Deleted = "";
                obj_Cls_Marriage.Status = "ACTIVE";
                if (obj_Cls_Marriage.Marriage_Insert() == 1)
                {
                    MessageBox.Show("Data Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Data Not Saved!");
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
                obj_Cls_Marriage = new Cls_Marriage();
                obj_Cls_Marriage.Groomcmntid = c_groom_cmntid.Text;
                obj_Cls_Marriage.Groomresdid = c_groom_resdid.Text;
                obj_Cls_Marriage.Groomname = c_groom_name.Text;
                obj_Cls_Marriage.Groomfather = c_groom_father.Text;
                obj_Cls_Marriage.Groomaddress = c_groom_address.Text;
                obj_Cls_Marriage.Groompincode = Convert.ToInt32(c_groom_pincode.Text);
                obj_Cls_Marriage.Groomdistrict = c_groom_district.Text;
                obj_Cls_Marriage.Groomstate = c_groom_state.Text;
                obj_Cls_Marriage.Groomcontactno = c_groom_contactno.Text;
                obj_Cls_Marriage.Groommahallu = c_groom_mahallu.Text;
                obj_Cls_Marriage.Bridecmntid = c_bride_cmntid.Text;
                obj_Cls_Marriage.Brideresdid = c_bride_resdid.Text;
                obj_Cls_Marriage.Bridename = c_bride_name.Text;
                obj_Cls_Marriage.Bridefather = c_bride_father.Text;
                obj_Cls_Marriage.Brideaddress = c_bride_address.Text;
                obj_Cls_Marriage.Bridepincode = Convert.ToInt32(c_bride_pincode.Text);
                obj_Cls_Marriage.Bridedistrict = c_bride_district.Text;
                obj_Cls_Marriage.Bridestate = c_bride_state.Text;
                obj_Cls_Marriage.Bridecontactno = c_bride_contactno.Text;
                obj_Cls_Marriage.Bridemahallu = c_bride_mahallu.Text;
                obj_Cls_Marriage.Marriageid = c_marriageid.Text;
                obj_Cls_Marriage.Weddingdate = Convert.ToDateTime(c_wedding_date.Text);
                obj_Cls_Marriage.Issuingdate = Convert.ToDateTime(c_wedding_date.Text);
                obj_Cls_Marriage.Witness1 = c_witness1.Text;
                obj_Cls_Marriage.Witness1contact = c_witness1_contact.Text;
                obj_Cls_Marriage.Witness2 = c_witness2.Text;
                obj_Cls_Marriage.Witness2contact = c_witness2_contact.Text;
                obj_Cls_Marriage.Witness3 = c_witness3.Text;
                obj_Cls_Marriage.Witness3contact = c_witness3_contact.Text;
                obj_Cls_Marriage.Weddingplace = c_wedding_place.Text;
                obj_Cls_Marriage.Created = "";
                obj_Cls_Marriage.Modified = "";
                obj_Cls_Marriage.Deleted = "";
                obj_Cls_Marriage.Status = "ACTIVE";
                if (obj_Cls_Marriage.Marriage_Update() == 1)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Data Not Updated!");
                }
            }
            catch
            {

            }

        }

        private void dgv_marriage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                obj_Cls_Marriage = new Cls_Marriage();
                int row_index = dgv_marriage.SelectedCells[0].RowIndex;
                obj_Cls_Marriage.Marriageid = dgv_marriage.Rows[row_index].Cells[0].Value.ToString();
                DT = obj_Cls_Marriage.Marriage_Select_By_Marriageid();
                if (DT.Rows.Count == 1)
                {
                    clearcontrols();
                    dgv_marriage.DataSource = DT;
                    c_groom_cmntid.Text = DT.Rows[0]["GROOMCMNTID"].ToString();
                    c_groom_resdid.Text = DT.Rows[0]["GROOMRESDID"].ToString();
                    c_groom_name.Text = DT.Rows[0]["GROOMNAME"].ToString();
                    c_groom_father.Text = DT.Rows[0]["GROOMFATHER"].ToString();
                    c_groom_address.Text = DT.Rows[0]["GROOMADDRESS"].ToString();
                    c_groom_pincode.Text = DT.Rows[0]["GROOMPINCODE"].ToString();
                    c_groom_district.Text = DT.Rows[0]["GROOMDISTRICT"].ToString();
                    c_groom_state.Text = DT.Rows[0]["GROOMSTATE"].ToString();
                    c_groom_contactno.Text = DT.Rows[0]["GROOMCONTACTNO"].ToString();
                    c_groom_mahallu.Text = DT.Rows[0]["GROOMMAHALLU"].ToString();
                    c_bride_cmntid.Text = DT.Rows[0]["BRIDECMNTID"].ToString();
                    c_bride_resdid.Text = DT.Rows[0]["BRIDERESDID"].ToString();
                    c_bride_name.Text = DT.Rows[0]["BRIDENAME"].ToString();
                    c_bride_father.Text = DT.Rows[0]["BRIDEFATHER"].ToString();
                    c_bride_address.Text = DT.Rows[0]["BRIDEADDRESS"].ToString();
                    c_bride_pincode.Text = DT.Rows[0]["BRIDEPINCODE"].ToString();
                    c_bride_district.Text = DT.Rows[0]["BRIDEDISTRICT"].ToString();
                    c_bride_state.Text = DT.Rows[0]["BRIDESTATE"].ToString();
                    c_bride_contactno.Text = DT.Rows[0]["BRIDECONTACTNO"].ToString();
                    c_bride_mahallu.Text = DT.Rows[0]["BRIDEMAHALLU"].ToString();
                    c_marriageid.Text = DT.Rows[0]["MARRIAGEID"].ToString();
                    c_wedding_date.Text = DT.Rows[0]["WEDDINGDATE"].ToString();
                    c_isssuing_date.Text = DT.Rows[0]["ISSUINGDATE"].ToString();
                    c_witness1.Text = DT.Rows[0]["WITNESS1"].ToString();
                    c_witness1_contact.Text = DT.Rows[0]["WITNESS1CONTACT"].ToString();
                    c_witness2.Text = DT.Rows[0]["WITNESS2"].ToString();
                    c_witness2_contact.Text = DT.Rows[0]["WITNESS2CONTACT"].ToString();
                    c_witness3.Text = DT.Rows[0]["WITNESS3"].ToString();
                    c_witness3_contact.Text = DT.Rows[0]["WITNESS3CONTACT"].ToString();
                    c_wedding_place.Text = DT.Rows[0]["WEDDINGPLACE"].ToString();
                }
                else
                {
                    dgv_marriage.DataSource = "";
                }
            }

            catch
            {

            }
        }

        private void c_keyword_TextChanged(object sender, EventArgs e)
        {
            obj_Cls_Marriage = new Cls_Marriage();
            try
            {
                DataTable DT = new DataTable();
                obj_Cls_Marriage.Keyword = c_keyword.Text;
                DT = obj_Cls_Marriage.Marriage_Select_By_Keyword();
                if (DT.Rows.Count > 0)
                {
                    dgv_marriage.DataSource = DT;
                }

            }
            catch
            {
                dgv_marriage.DataSource = "";
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                obj_Cls_Marriage = new Cls_Marriage();
                obj_Cls_Marriage.Marriageid = c_marriageid.Text;
                if (obj_Cls_Marriage.Marriage_Delete() == 1)
                {
                    MessageBox.Show("Data Deleted!");
                }
                else
                {
                    MessageBox.Show("Data Not Deleted?");
                }
            }
            catch
            {
            }
        }
    }
}

