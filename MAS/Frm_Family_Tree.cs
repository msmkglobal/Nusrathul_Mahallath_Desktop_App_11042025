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
    public partial class Frm_Family_Tree : Form
    {
        Form Obj_Frm_Pointer;
        public Frm_Family_Tree(Form Obj_Temp)
        {
            Obj_Frm_Pointer = Obj_Temp;
            InitializeComponent();            
        }
        private void Frm_Family_Tree_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {
            }
        }       

        private void rdb_gf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_gf.Checked == true)
            {
                txt_selected_member.Text = "GRAND FATHER OF THE FAMLY";
                txt_fml_id.Text = "GF";
            }          
        }

        private void rdb_gm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_gm.Checked == true)
            {
                txt_selected_member.Text = "GRAND MOTHER OF THE FAMLY";
                txt_fml_id.Text = "GM";
                
            }
        }      
        private void rdb_f_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_f.Checked==true)
            {
                txt_selected_member.Text = "FATHER OF THE FAMLY";
                txt_fml_id.Text = "F";

            }
        }

        private void rdb_m_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_m.Checked==true)
            {
                txt_selected_member.Text = "MOTHER OF THE FAMLY";
                txt_fml_id.Text = "M";

            }
        }
        private void rdb_gs1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gs1.Checked == true)
            {
                txt_selected_member.Text = "GRAND SON OF THE FAMLY";
                txt_fml_id.Text = "GS";
            }
        }


        

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdb_b_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_b.Checked == true)
            {
                txt_selected_member.Text = "BROTHER OF THE FAMLY";
                txt_fml_id.Text = "B";

            }
        }

        private void rdb_s_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_s.Checked== true)
            {
                txt_selected_member.Text = "SISTER OF THE FAMLY";
                txt_fml_id.Text = "S";

            }
        }

       

        private void txt_gx_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_gx_TextChanged_1(object sender, EventArgs e)
        {
            {
                txt_selected_member.Text = "Gust of the Family";
                txt_fml_id.Text += txt_gx.Text;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_gx.Text ==""))
                {
                    Obj_Frm_Pointer.Controls[1].Controls[8].Text = Obj_Frm_Pointer.Controls[1].Controls[5].Text+txt_fml_id.Text;
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Please select corect Relation", "Famly Tree [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            }
            catch { }
        }

        private void txt_note_Click(object sender, EventArgs e)
        {

        }

        private void rdb_guardian_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_guardian.Checked == true)
            {
                txt_selected_member.Text = "GUARDIAN OF THE FAMLY";
                txt_fml_id.Text = "GUA";
            }
        }

        private void c_s1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_s1.Checked == true)
            {
                txt_selected_member.Text = "FIRST SON OF THE FAMLY";
                txt_fml_id.Text = "S1";
            }
        }

        private void c_s2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_s2.Checked == true)
            {
                txt_selected_member.Text = "SECOND SON OF THE FAMLY";
                txt_fml_id.Text = "S2";
            }
        }

        private void c_s3_CheckedChanged(object sender, EventArgs e)
        {
            if (c_s3.Checked == true)
            {
                txt_selected_member.Text = "THIRD SON OF THE FAMLY";
                txt_fml_id.Text = "S3";
            }
        }

        private void c_s4_CheckedChanged(object sender, EventArgs e)
        {
            if (c_s4.Checked == true)
            {
                txt_selected_member.Text = "FOURTH SON OF THE FAMLY";
                txt_fml_id.Text = "S4";
            }
        }

        private void c_d1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_d1.Checked == true)
            {
                txt_selected_member.Text = "FIRST DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "D1";
            }
        }

        private void c_d2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_d2.Checked == true)
            {
                txt_selected_member.Text = "SECOND DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "D2";
            }
        }

        private void c_d3_CheckedChanged(object sender, EventArgs e)
        {
            if (c_d3.Checked == true)
            {
                txt_selected_member.Text = "THIRD DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "D3";
            }
        }

        private void c_d4_CheckedChanged(object sender, EventArgs e)
        {
            if (c_d4.Checked == true)
            {
                txt_selected_member.Text = "FOURTH DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "D4";
            }
        }

        private void c_dl1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_dl1.Checked == true)
            {
                txt_selected_member.Text = "FIRST DAUGHTER IN LAW OF THE FAMLY";
                txt_fml_id.Text = "DL1";
            }
        }

        private void c_dl2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_dl2.Checked == true)
            {
                txt_selected_member.Text = "SECOND DAUGHTER IN LAW OF THE FAMLY";
                txt_fml_id.Text = "DL2";
            }
        }

        private void c_dl3_CheckedChanged(object sender, EventArgs e)
        {
            if (c_dl3.Checked == true)
            {
                txt_selected_member.Text = "THIRD DAUGHTER IN LAW OF THE FAMLY";
                txt_fml_id.Text = "DL3";
            }
        }

        private void c_dl4_CheckedChanged(object sender, EventArgs e)
        {
            if (c_dl4.Checked == true)
            {
                txt_selected_member.Text = "FORTH DAUGHTER IN LAW OF THE FAMLY";
                txt_fml_id.Text = "DL4";
            }
        }

        private void c_gs1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gs1.Checked == true)
            {
                txt_selected_member.Text = "FIRST GRAND SON OF THE FAMLY";
                txt_fml_id.Text = "GS1";
            }
        }

        private void c_gs2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gs2.Checked == true)
            {
                txt_selected_member.Text = "SECOND GRAND SON OF THE FAMLY";
                txt_fml_id.Text = "GS2";
            }
        }

        private void c_gs3_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gs3.Checked == true)
            {
                txt_selected_member.Text = "THIRD GRAND SON OF THE FAMLY";
                txt_fml_id.Text = "GS3";
            }
        }

        private void c_gs4_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gs4.Checked == true)
            {
                txt_selected_member.Text = "FOURTH GRAND SON OF THE FAMLY";
                txt_fml_id.Text = "GS4";
            }
        }

        private void c_sl1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_sl1.Checked == true)
            {
                txt_selected_member.Text = "FIRST SON IN LAW OF THE FAMLY";
                txt_fml_id.Text = "SL1";
            }
        }

        private void c_sl2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_sl2.Checked == true)
            {
                txt_selected_member.Text = "FIRST SON IN LAW OF THE FAMLY";
                txt_fml_id.Text = "SL2";
            }
        }

        private void c_sl3_CheckedChanged(object sender, EventArgs e)
        {
            if (c_sl3.Checked == true)
            {
                txt_selected_member.Text = "THIRD SON IN LAW OF THE FAMLY";
                txt_fml_id.Text = "SL3";
            }
        }

        private void c_sl4_CheckedChanged(object sender, EventArgs e)
        {
            if (c_sl4.Checked == true)
            {
                txt_selected_member.Text = "FOURTH SON IN LAW OF THE FAMLY";
                txt_fml_id.Text = "SL4";
            }
        }

        private void c_gd1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gd1.Checked == true)
            {
                txt_selected_member.Text = "FIRST GRAND DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "GD1";
            }
        }

        private void c_gd2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gd2.Checked == true)
            {
                txt_selected_member.Text = "SECOND GRAND DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "GD2";
            }
        }

        private void c_gd3_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gd3.Checked == true)
            {
                txt_selected_member.Text = "THIRD GRAND DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "GD3";
            }
        }

        private void c_gd4_CheckedChanged(object sender, EventArgs e)
        {
            if (c_gd4.Checked == true)
            {
                txt_selected_member.Text = "FOURTH GRAND DAUGHTER OF THE FAMLY";
                txt_fml_id.Text = "GD4";
            }
        }

        private void c_as1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_as1.Checked == true)
            {
                txt_selected_member.Text = "AS1";
                txt_fml_id.Text = "AS1";
            }
        }

        private void c_as2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_as2.Checked == true)
            {
                txt_selected_member.Text = "AS2";
                txt_fml_id.Text = "AS2";
            }
        }

        private void c_ad1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_ad1.Checked == true)
            {
                txt_selected_member.Text = "AD1";
                txt_fml_id.Text = "AD1";
            }
        }

        private void c_ad2_CheckedChanged(object sender, EventArgs e)
        {
            if (c_ad2.Checked == true)
            {
                txt_selected_member.Text = "AD2";
                txt_fml_id.Text = "AD2";
            }
        }

        private void c_w1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_w1.Checked == true)
            {
                txt_selected_member.Text = "WIFE OF THE FAMLY";
                txt_fml_id.Text = "W1";
            }
        }       
    }
}
